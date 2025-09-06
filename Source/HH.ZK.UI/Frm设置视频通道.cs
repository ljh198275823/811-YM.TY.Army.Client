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
    public partial class Frm设置视频通道 : Form
    {
        public Frm设置视频通道()
        {
            InitializeComponent();
            initControls();
        }

        #region 私有变量
        //已选主机编号
        private List<byte> _selectedHostIds = new List<byte>();
        #endregion

        #region 公共变量
        /// <summary>
        /// 获取或设置已选择主机编号
        /// </summary>
        public string VideoChannels
        {
            get
            {
                if (_selectedHostIds == null || _selectedHostIds.Count == 0) return null;
                if (_selectedHostIds.Count > 1)
                {
                    _selectedHostIds.Sort();
                }
                return string.Join(",", _selectedHostIds);
            }
        }
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
            int CtrlHeight = 30;
            int CtrlDefaultWidth = 60;
            int yIndex = 30;
            for (int i = 1; i < 33; i++)
            {
                Button kcb = new Button();
                kcb.Text = "通道" + i.ToString();
                kcb.Name = "kcb_" + i.ToString();
                kcb.Tag = i.ToString();
                kcb.Location = new Point(CtrlXMargin, CtrlYMargin + yIndex * CtrlHeight);
                kcb.Size = new Size(CtrlDefaultWidth, CtrlHeight);
                kcb.Cursor = Cursors.Hand;
                kcb.Click += new EventHandler(kcb_CheckedChanged);
                pnlHostIds.Controls.Add(kcb);
            }
        }
        /// <summary>
        /// 清除所有已选主机编号
        /// </summary>
        private void ClearSelectedHosts()
        {
            _selectedHostIds.Clear();
            foreach (Control ctl in pnlHostIds.Controls)
            {
                if (ctl.Name.StartsWith("kcb_"))
                {
                    ctl.BackColor = Color.White;
                }
            }
        }
        #endregion

        #region 事件处理程序
        private void FrmSelectHostIDs_Load(object sender, EventArgs e)
        {
            
        }

        private void kcb_CheckedChanged(object sender, EventArgs e)
        {
            if (sender != null)
            {
                Button ctl = (Button)sender;
                if (_selectedHostIds.Exists(it => it.ToString() == ctl.Tag.ToString()))
                {
                    ctl.BackColor = Color.White;
                    _selectedHostIds.Remove(Convert.ToByte(ctl.Tag));
                }
                else
                {
                    if (SelectSingle) ClearSelectedHosts();//如果是单选,先将其它的所有都清空
                    ctl.BackColor = Color.Pink;
                    _selectedHostIds.Add(Convert.ToByte(ctl.Tag));
                }
            }
        }

        private void btnClearSelected_Click(object sender, EventArgs e)
        {
            ClearSelectedHosts();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (_selectedHostIds.Count == 0)
            {
                if (MessageBox.Show("你没有选择视频通道，所选成绩的视频通道将设置为空，是否继续？", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        #endregion
    }
}
