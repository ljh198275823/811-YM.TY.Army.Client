using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HH.ZK.CommonUI
{
    public partial class FrmSelectHostIDs : Form
    {
        public FrmSelectHostIDs(byte minHost = 1)
        {
            InitializeComponent();
            MinHost = minHost;
            initControls();
        }

        #region 私有变量
        //已选主机编号
        private List<byte> _selectedHostIds = new List<byte>();
        #endregion

        #region 公共变量
        private byte MinHost { get; set; }
        /// <summary>
        /// 获取或设置是否是单选
        /// </summary>
        public bool SelectSingle { get; set; }
        #endregion

        #region 私有方法
        /// <summary>
        /// 初始化主机编号按键
        /// </summary>
        private void initControls()
        {
            int CtrlXMargin = 5;
            int CtrlYMargin = 5;
            int CtrlHeight = 24;
            int CtrlDefaultWidth = 30;
            int yIndex = 30;
            for (int i = MinHost; i < 100; i++)
            {
                Button kcb = new Button();
                kcb.Text = i.ToString();
                kcb.Name = "kcb_" + i.ToString();
                kcb.Location = new Point(CtrlXMargin, CtrlYMargin + yIndex * CtrlHeight);
                kcb.Size = new Size(CtrlDefaultWidth, CtrlHeight);
                kcb.Cursor = Cursors.Hand;
                kcb.Click += new EventHandler(kcb_CheckedChanged);
                pnlHostIds.Controls.Add(kcb);
            }
        }
        /// <summary>
        /// 根据已经选主机编号来初始化控件组.
        /// </summary>
        private void InitControlsByHostId()
        {
            if (_selectedHostIds != null && _selectedHostIds.Count > 0)
            {
                int hostId = 0;
                for (int i = 0; i < _selectedHostIds.Count; i++)
                {
                    hostId = (int)_selectedHostIds[i];
                    foreach (Control ctl in pnlHostIds.Controls)
                    {
                        if (ctl.Name == "kcb_" + hostId.ToString())
                        {
                            ctl.BackColor = Color.Pink;
                            ctl.Tag = hostId;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// 清除所有已选主机编号
        /// </summary>
        private void ClearSelectedHosts()
        {
            if (_selectedHostIds != null) _selectedHostIds.Clear();
            foreach (Control ctl in pnlHostIds.Controls)
            {
                if (ctl.Name.StartsWith("kcb_"))
                {
                    ctl.BackColor = Color.White;
                    ctl.Tag = null;
                }
            }
        }
        /// <summary>
        /// 获取或设置已选择主机编号
        /// </summary>
        public List<byte> SelectedHostIds
        {
            get
            {
                if (_selectedHostIds.Count > 1)
                {
                    _selectedHostIds.Sort();
                }
                return _selectedHostIds;
            }
            set
            {
                _selectedHostIds = value;
            }
        }
        #endregion

        #region 事件处理程序
        private void FrmSelectHostIDs_Load(object sender, EventArgs e)
        {
            InitControlsByHostId();
        }

        private void kcb_CheckedChanged(object sender, EventArgs e)
        {
            if (sender != null)
            {
                Button ctl = (Button)sender;
                if (ctl.Tag != null)
                {
                    ctl.BackColor = Color.White;
                    ctl.Tag = null;
                }
                else
                {
                    if (SelectSingle) ClearSelectedHosts();//如果是单选,先将其它的所有都清空
                    ctl.BackColor = Color.Pink;
                    ctl.Tag = byte.Parse(ctl.Text);
                }
            }
        }

        private void btnClearSelected_Click(object sender, EventArgs e)
        {
            ClearSelectedHosts();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (_selectedHostIds == null) _selectedHostIds = new List<byte>();
            _selectedHostIds.Clear();
            foreach (Control ctl in pnlHostIds.Controls)
            {
                if (ctl.Name.StartsWith("kcb_") && ctl.Tag != null)
                {
                    _selectedHostIds.Add(Convert.ToByte(ctl.Tag));
                }
            }
            if (_selectedHostIds.Count == 0)
            {
                MessageBox.Show("请选择至少一个的主机编号.", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        #endregion
    }
}
