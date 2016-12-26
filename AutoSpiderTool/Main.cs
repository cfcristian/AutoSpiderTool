using Common;
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
    public partial class Main : Form
    {

        string space = AppConfig.WorkSpace;
        public Main()
        {
            InitializeComponent();
            BindLIstBox();
        }



        private void btop_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtpro.Text))
            {
                MessageBox.Show("项目名不能为空!");
                return;
            }
             var listpros = Utils.GetExistsProject();
             if (listpros != null && listpros.Any(p=>p.Name==txtpro.Text.Trim()))
             {
                 MessageBox.Show("项目名重复！");
                 return;
             }
            Utils.SaveProject(txtpro.Text.Trim(), true,txthome.Text);
            BindLIstBox();
        }

        /// <summary>
        /// 选择最近的项目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblist_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var cur = this.lblist.SelectedIndex;
            if (cur >= 0)
            {
                var curItem = lblist.Items[cur];
               var item = Utils.SaveProject(curItem.ToString(), true);
               if (item != null)
               {
                   txtpro.Text = item.Name;
                   txthome.Text = item.HomePage;
               }
            }

            task tf = new task();
            this.Hide();
            tf.Show();

        }




        #region 

        public void BindLIstBox()
        {
            var listpros = Utils.GetExistsProject();
            if (listpros != null && listpros.Any())
            {
                lblist.SelectionMode = SelectionMode.One;
                lblist.Items.Clear();
                listpros.OrderByDescending(s => s.Time).ToList().ForEach(x =>
                {
                    lblist.Items.Add(x.Name);
                });
            } 
        }
        #endregion
    }
}
