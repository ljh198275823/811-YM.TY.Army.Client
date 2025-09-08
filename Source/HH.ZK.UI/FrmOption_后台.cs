using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HH.ZK.Model;
using HH.ZK.Model.CRM;
using HH.ZK.CommonUI;
using HH.ZK.WebAPIClient;

namespace HH.ZK.UI
{
    public partial class FrmOption_后台 : Form
    {
        public FrmOption_后台()
        {
            InitializeComponent();
        }

        public PhysicalProject Project { get; set; }

        private void FrmOption_Load(object sender, EventArgs e)
        {
            txt总分计算方式.Init();
            var po = SysParaSettingsClient.GetOrCreateSetting<PhysicalProjectOptions>(AppSettings.Current.ConnStr, Project.ID);
            rdBest.Checked = po.ScoreSelectMode == 0;
            rdLast.Checked = po.ScoreSelectMode == 1;
            if (!string.IsNullOrEmpty(po.CertificateTitle)) txt自定义标题.Text = po.CertificateTitle;
            chkCnanotModifyScore.Checked = po.CannotModifyScore;
            txt总分满分.DecimalValue = po.MaxTotal;
            txt总分计算方式.SelectedTotalCalType = po.TotalCalType;
            txtFormula.Text = po.TotalFormula;
            if (po.TotalPoint.HasValue)
            {
                chk保留小数位.Checked = true;
                txtPointCount.IntergerValue = po.TotalPoint.Value;
                rd非零进一.Checked = po.TotalMode == 0;
                rd四舍五入.Checked = po.TotalMode == 1;
                rd直接舍弃.Checked = po.TotalMode == 2;
            }
            else
            {
                chk保留小数位.Checked = false;
                txtPointCount.Enabled = chk保留小数位.Checked;
                pnl舍入方式.Enabled = chk保留小数位.Checked;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txt总分计算方式.SelectedTotalCalType == TotalCalType.自定义公式 && string.IsNullOrEmpty(txtFormula.Text))
            {
                MessageBox.Show("请填写自定义公式");
                return;
            }
            var po = SysParaSettingsClient.GetOrCreateSetting<PhysicalProjectOptions>(AppSettings.Current.ConnStr, Project.ID);
            po.ScoreSelectMode = rdLast.Checked ? 1 : 0;
            po.CertificateTitle = txt自定义标题.Text;
            po.CannotModifyScore = chkCnanotModifyScore.Checked;
            po.MaxTotal = txt总分满分.DecimalValue;
            po.TotalCalType = txt总分计算方式.SelectedTotalCalType;
            po.TotalFormula = txtFormula.Text;
            if (chk保留小数位.Checked)
            {
                po.TotalPoint = txtPointCount.IntergerValue;
                if (rd非零进一.Checked) po.TotalMode = 0;
                else if (rd四舍五入.Checked) po.TotalMode = 1;
                else po.TotalMode = 2;
            }
            else
            {
                po.TotalPoint = null;
                po.TotalMode = null;
            }
            SysParaSettingsClient.SaveSetting<PhysicalProjectOptions>(po, AppSettings.Current.ConnStr, Project.ID);
            this.DialogResult = DialogResult.OK;
        }

        private void chk保留小数位_CheckedChanged(object sender, EventArgs e)
        {
            txtPointCount.Enabled = chk保留小数位.Checked;
            pnl舍入方式.Enabled = chk保留小数位.Checked;
        }

        private void txt总分计算方式_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFormula.Enabled = txt总分计算方式.SelectedTotalCalType == TotalCalType.自定义公式;
        }
    }
}
