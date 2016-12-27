using Common;
using Model;
using Provider;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
            LoadBind();

        }

        public ListPage(string taskName)
        {
            InitializeComponent();
            _taskName = taskName;
            Partask = Utils.GetTaskByTaskName(taskName);
            LoadBind();
        }

        private void LoadBind()
        {
            //值类型
            EnumManager<ValueTypeEnum>.SetCombox(ValueType);
            //数据表
            var listTb = DbHelper.GetTables();
            EnumManager<object>.SetCombox(DbTable, listTb);

            //类型
            EnumManager<DbTypeEnum>.SetCombox(DbType);

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


        

        private void dv1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            //判断相应的列		 

            if (dgv.CurrentCell.GetType().Name == "DataGridViewComboEditBoxCell" && dgv.CurrentCell.RowIndex != -1)
            {
                //给这个DataGridViewComboBoxCell加上下拉事件
                (e.Control as ComboBox).SelectedIndexChanged += ListPage_SelectedIndexChanged;
            }
        }

        public void ListPage_SelectedIndexChanged(object sender, EventArgs e)
        {
             ComboBox combox=sender as ComboBox;

            //这里比较重要
            combox.Leave+=new EventHandler(combox_Leave);
             try
             {
                 //在这里就可以做值是否改变判断
                 if (combox.SelectedItem != null)
                 {
                     var selValue = combox.SelectedValue.ToString();
                     if (!string.IsNullOrEmpty(selValue))
                     {
                         EnumManager<object>.SetCombox(DbName, DbHelper.GetColumns(selValue));
                     }
                 }
                 Thread.Sleep(100);
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
        }

 
          

        /// <summary>
        /// 离开combox时，把事件删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void combox_Leave(object sender, EventArgs e)
        {
            ComboBox combox = sender as ComboBox;
            //做完处理，须撤销动态事件
            combox.SelectedIndexChanged -= new EventHandler(ListPage_SelectedIndexChanged);
        }

    }
}
