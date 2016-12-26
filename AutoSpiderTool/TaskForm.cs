using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;
using Model;

namespace AutoSpiderTool
{
    public partial class task : Form
    {

        ProjectItem pro = null;
        public task()
        {
            InitializeComponent();
        }

        private void ListPage_Load(object sender, EventArgs e)
        {
            var selPro = Utils.GetSelProject();
            if (selPro != null)
            {
                this.Text = selPro.Name;
                pro = selPro;
            }
            else
            {
                this.Text = "未选择项目";
               
            } 
            //
            var tc = new TaskCollection();
            //tc.TaskList.Add(new AnTask()
            //{
            //    Name = "列表任务1",
            //    TaskType = 0,
            //    MaxPage = 100,
            //    PageUrl = "http://baidu.com/index{0}.html"
            //});

            //tc.TaskList.Add(new AnTask()
            //{
            //    Name = "详细任务1",
            //    TaskType = 1,
            //    MaxPage = 100,
            //    PageUrl = "http://baidu.com/index{0}.html"
            //});

            //Utils.SaveTask(pro.Name, tc);

            var tlist = Utils.GetTaskByProName(pro.Name);

            this.listView1.Columns.AddRange(new ColumnHeader[]{
                new ColumnHeader{Text="任务名称",Width=180},
                new ColumnHeader{Text="任务类型",Width=80},
                new ColumnHeader{Text="页数",Width=50},
                new ColumnHeader{Text="子任务数",Width=80},
                new ColumnHeader{Text="启用",Width=80}
             });
            this.listView1.View = View.Details;
            this.listView1.Items.Clear(); 
            if (tlist != null && tlist.TaskList != null)
            {                
                this.listView1.BeginUpdate();
                listView1.CheckBoxes = false;
                tlist.TaskList.ForEach(x =>
                {
                    BindListView(x);
                    if(x.ChildTasks!=null){
                         x.ChildTasks.ForEach(cd=>{
                             BindListView(cd,true);
                        });
                    }
                });
                this.listView1.EndUpdate(); 
            }

        }

        private void BindListView(AnTask task,bool ischild=false)
        {
            if (task != null)
            {
                ListViewItem lv=new ListViewItem();
                
                if (ischild)
                {
                    lv.Text = "    " + task.Name;
                    lv.ForeColor = Color.FromArgb(132, 132, 132);
                }
                else
                lv.Text =  task.Name;
                
                lv.SubItems.Add(task.TaskType == 0 ? "列表" : "详细页");
                lv.SubItems.Add(task.MaxPage.ToString());
                lv.SubItems.Add(task.ChildTasks.Count.ToString());
                lv.SubItems.Add(task.IsEnable?"启用":"禁用");
                this.listView1.Items.Add(lv);
            }
        }

       

        private void btnExec_Click(object sender, EventArgs e)
        {

        }

        private void btncreateList_Click(object sender, EventArgs e)
        {
            //var selPro = Utils.GetTaskByProName(pro.Name);
            ListPage lp = new ListPage();
           // this.Hide();
            lp.Show();

        }

        
        private void listView1_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.Item.IndentCount += 4;
        }



    }
}
