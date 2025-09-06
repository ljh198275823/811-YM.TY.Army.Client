using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using HH.ZK.UI;

namespace HH.ZK.ZKJianLu
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!LJH.GeneralLibrary.SingleInstance.ExistsProcess())
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Form frm = new Frm中考检录系统();
                Application.Run(frm);
            }
            else
            {
                LJH.GeneralLibrary.SingleInstance.ShowSingleProcess();
            }
        }
    }
}
