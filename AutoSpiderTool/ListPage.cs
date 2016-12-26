using Common;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSpiderTool
{
    public partial class ListPage : Form
    {

        string _taskName;
        AnTask Partask = null;
        AnTask task = new AnTask();
        public ListPage()
        {
            InitializeComponent();
        }

        public ListPage(string taskName)
        {
            InitializeComponent();
            _taskName = taskName;
            Partask = Utils.GetTaskByTaskName(taskName);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            task.Name = txtTaskName.Text.Trim(); //vali
            task.ListItemxPath = txtListxPath.Text.Trim();
            task.PageUrl = txtListURl.Text.Trim();
            task.PageNoxPath = txtPagexPath.Text.Trim();
            task.PageNoRegex = txtPageRegex.Text.Trim();
            task.IsInDb = ckIndb.Checked;
            task.Lever = Partask == null ? 0 : Partask.Lever + 1; //vali
           // task.Fields = 
            


        }


        private void BindFields()
        {
            if (this.dv1.Rows != null && this.dv1.Rows.Count > 0)
            {
                foreach (DataGridViewRow item in dv1.Rows)
                {
                    var fd = new FieldProperty();
                    fd.DbName = item.Cells[0].Value.ToString();
                     


                }
            }
        }
    }
}
