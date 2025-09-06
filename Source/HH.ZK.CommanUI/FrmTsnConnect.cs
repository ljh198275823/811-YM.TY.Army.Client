using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HH.Zhongkao.Device;

namespace HH.ZK.CommonUI
{
    public partial class FrmTsnConnect : Form
    {
        public FrmTsnConnect()
        {
            InitializeComponent();
        }

        public TSNUSBDataReader TSNReader { get; set; }

        public TSNClassInfo SelectedClass
        {
            get
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["colSelect"].Value != null && Convert.ToBoolean(row.Cells["colSelect"].Value))
                    {
                        return row.Tag as TSNClassInfo;
                    }
                }
                return null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            button2.Enabled = false;
            List<TSNClassInfo> classes = TSNReader.ReadAllClasses();
            if (classes != null && classes.Count > 0)
            {
                button2.Enabled = true;
                foreach (TSNClassInfo tsnClass in classes)
                {
                    int row = dataGridView1.Rows.Add();
                    dataGridView1.Rows[row].Tag = tsnClass;
                    dataGridView1.Rows[row].Cells["colIndex"].Value = tsnClass.ClassIndex;
                    dataGridView1.Rows[row].Cells["colClassName"].Value = tsnClass.ClassName;
                    dataGridView1.Rows[row].Cells["colCount"].Value = tsnClass.RecordCount;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["colSelect"].Value != null && Convert.ToBoolean(row.Cells["colSelect"].Value))
                {
                    count++;
                }
            }
            if (count == 1) this.DialogResult = DialogResult.OK;
            else if (count == 0)
            {
                MessageBox.Show("请选择一项进行同步");
            }
            else
            {
                MessageBox.Show("选择了多项,每次只能选择一项");
            }
        }
    }
}
