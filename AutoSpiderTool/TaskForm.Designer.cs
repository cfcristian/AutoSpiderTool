namespace AutoSpiderTool
{
    partial class task
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btncreateList = new System.Windows.Forms.Button();
            this.btncreatSingle = new System.Windows.Forms.Button();
            this.btnExec = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btncreateList
            // 
            this.btncreateList.Location = new System.Drawing.Point(510, 41);
            this.btncreateList.Name = "btncreateList";
            this.btncreateList.Size = new System.Drawing.Size(114, 33);
            this.btncreateList.TabIndex = 1;
            this.btncreateList.Text = "建立列表任务";
            this.btncreateList.UseVisualStyleBackColor = true;
            this.btncreateList.Click += new System.EventHandler(this.btncreateList_Click);
            // 
            // btncreatSingle
            // 
            this.btncreatSingle.Location = new System.Drawing.Point(510, 94);
            this.btncreatSingle.Name = "btncreatSingle";
            this.btncreatSingle.Size = new System.Drawing.Size(114, 33);
            this.btncreatSingle.TabIndex = 2;
            this.btncreatSingle.Text = "建立详细任务";
            this.btncreatSingle.UseVisualStyleBackColor = true;
            // 
            // btnExec
            // 
            this.btnExec.Location = new System.Drawing.Point(191, 405);
            this.btnExec.Name = "btnExec";
            this.btnExec.Size = new System.Drawing.Size(114, 57);
            this.btnExec.TabIndex = 3;
            this.btnExec.Text = "任务执行";
            this.btnExec.UseVisualStyleBackColor = true;
            this.btnExec.Click += new System.EventHandler(this.btnExec_Click);
            // 
            // btndel
            // 
            this.btndel.Location = new System.Drawing.Point(510, 154);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(114, 33);
            this.btndel.TabIndex = 4;
            this.btndel.Text = "删除任务";
            this.btndel.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Location = new System.Drawing.Point(29, 36);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(446, 339);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 503);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnExec);
            this.Controls.Add(this.btncreatSingle);
            this.Controls.Add(this.btncreateList);
            this.Name = "task";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaskForm";
            this.Load += new System.EventHandler(this.ListPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncreateList;
        private System.Windows.Forms.Button btncreatSingle;
        private System.Windows.Forms.Button btnExec;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.ListView listView1;

    }
}