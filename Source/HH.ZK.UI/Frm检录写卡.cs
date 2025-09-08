using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using HH.ZK.Model;
using HH.Zhongkao.Device.Reader;

namespace HH.ZK.UI
{
    public partial class Frm检录写卡 : Form
    {
        public Frm检录写卡()
        {
            InitializeComponent();
        }

        public ICCardReader Reader { get; set; }

        public Student Student { get; set; }

        Thread tmr = null;

        private void FrmWriteCard_Load(object sender, EventArgs e)
        {
            tmr = new Thread(new ThreadStart(timer1_Tick));
            tmr.IsBackground = true;
            tmr.Start();
        }

        private void timer1_Tick()
        {
            try
            {
                while (true)
                {
                    Thread.Sleep(200);
                    var ret = Reader.InitCard(Student.ID, Student.Name, Student.Gender == Gender.Male ? "1" : "2", string.Empty);
                    if (ret == CommandRet.SUCCEED) break;
                }
                this.Invoke((Action)(() => this.DialogResult = DialogResult.OK));
            }
            catch
            {
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void FrmWriteCard_FormClosing(object sender, FormClosingEventArgs e)
        {
            tmr.Abort();
        }
    }
}
