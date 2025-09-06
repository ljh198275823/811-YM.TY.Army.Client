using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HH.ZK.CommonUI
{
    public class SingleFormManager
    {
        #region 静态方法
        private static List<Form> _openedForms = new List<Form>();

        /// <summary>
        /// 显示窗口的单个实例，如果之前已经打开过，则只是激活打开过的窗体
        /// </summary>
        /// <param name="formType">要打开的窗体类型</param>
        /// <param name="mainPanel">是否在主面板中打开,否则在从面板中打开</param>
        public static T ShowSingleForm<T>() where T : Form
        {
            T instance = null;
            foreach (Form frm in _openedForms)
            {
                if (frm.GetType() == typeof(T))
                {
                    instance = frm as T;
                    break;
                }
            }
            if (instance == null)
            {
                instance = Activator.CreateInstance(typeof(T)) as T;
                _openedForms.Add(instance);
                instance.FormClosed += delegate (object sender, FormClosedEventArgs e)
                {
                    _openedForms.Remove(instance);
                };
            }
            instance.Show();
            instance.Activate();
            return instance;
        }
        #endregion
    }
}
