namespace AutoSpiderTool
{
    partial class ListPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtListURl = new System.Windows.Forms.TextBox();
            this.txtListxPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPagexPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPageRegex = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ckIndb = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dv1 = new System.Windows.Forms.DataGridView();
            this.DbName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DbText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValueDivide = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboEditBoxColumn1 = new AutoSpiderTool.DataGridViewComboEditBoxColumn();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.DbTable = new AutoSpiderTool.DataGridViewComboEditBoxColumn();
            this.DbType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ValutType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ValuexPath = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dv1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "任务名称";
            // 
            // txtTaskName
            // 
            this.txtTaskName.Location = new System.Drawing.Point(128, 32);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(240, 25);
            this.txtTaskName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "列表Url";
            // 
            // txtListURl
            // 
            this.txtListURl.Location = new System.Drawing.Point(128, 75);
            this.txtListURl.Name = "txtListURl";
            this.txtListURl.Size = new System.Drawing.Size(666, 25);
            this.txtListURl.TabIndex = 3;
            // 
            // txtListxPath
            // 
            this.txtListxPath.Location = new System.Drawing.Point(128, 123);
            this.txtListxPath.Name = "txtListxPath";
            this.txtListxPath.Size = new System.Drawing.Size(666, 25);
            this.txtListxPath.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "列表XPath";
            // 
            // txtPagexPath
            // 
            this.txtPagexPath.Location = new System.Drawing.Point(128, 166);
            this.txtPagexPath.Name = "txtPagexPath";
            this.txtPagexPath.Size = new System.Drawing.Size(551, 25);
            this.txtPagexPath.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "页数XPath";
            // 
            // txtPageRegex
            // 
            this.txtPageRegex.Location = new System.Drawing.Point(128, 214);
            this.txtPageRegex.Name = "txtPageRegex";
            this.txtPageRegex.Size = new System.Drawing.Size(666, 25);
            this.txtPageRegex.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "页数正则";
            // 
            // ckIndb
            // 
            this.ckIndb.AutoSize = true;
            this.ckIndb.Location = new System.Drawing.Point(43, 269);
            this.ckIndb.Name = "ckIndb";
            this.ckIndb.Size = new System.Drawing.Size(89, 19);
            this.ckIndb.TabIndex = 10;
            this.ckIndb.Text = "是否入库";
            this.ckIndb.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 547);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 46);
            this.button1.TabIndex = 17;
            this.button1.Text = "确认";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dv1
            // 
            this.dv1.AllowDrop = true;
            this.dv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DbName,
            this.DbText,
            this.DbTable,
            this.DbType,
            this.ValutType,
            this.ValuexPath,
            this.ValueDivide});
            this.dv1.Location = new System.Drawing.Point(43, 315);
            this.dv1.Name = "dv1";
            this.dv1.RowTemplate.Height = 27;
            this.dv1.Size = new System.Drawing.Size(751, 204);
            this.dv1.TabIndex = 18;
            // 
            // DbName
            // 
            this.DbName.DataPropertyName = "DbName";
            this.DbName.HeaderText = "列名";
            this.DbName.Name = "DbName";
            // 
            // DbText
            // 
            this.DbText.DataPropertyName = "DbText";
            this.DbText.HeaderText = "描述名";
            this.DbText.Name = "DbText";
            // 
            // ValueDivide
            // 
            this.ValueDivide.HeaderText = "分隔符";
            this.ValueDivide.Name = "ValueDivide";
            // 
            // dataGridViewComboEditBoxColumn1
            // 
            this.dataGridViewComboEditBoxColumn1.HeaderText = "表名";
            this.dataGridViewComboEditBoxColumn1.Name = "dataGridViewComboEditBoxColumn1";
            this.dataGridViewComboEditBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.HeaderText = "类型";
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            // 
            // dataGridViewComboBoxColumn2
            // 
            this.dataGridViewComboBoxColumn2.HeaderText = "值类型";
            this.dataGridViewComboBoxColumn2.Name = "dataGridViewComboBoxColumn2";
            // 
            // dataGridViewComboBoxColumn3
            // 
            this.dataGridViewComboBoxColumn3.HeaderText = "值xPath";
            this.dataGridViewComboBoxColumn3.Name = "dataGridViewComboBoxColumn3";
            // 
            // DbTable
            // 
            this.DbTable.HeaderText = "表名";
            this.DbTable.Name = "DbTable";
            this.DbTable.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DbType
            // 
            this.DbType.HeaderText = "类型";
            this.DbType.Name = "DbType";
            // 
            // ValutType
            // 
            this.ValutType.HeaderText = "值类型";
            this.ValutType.Name = "ValutType";
            // 
            // ValuexPath
            // 
            this.ValuexPath.HeaderText = "值xPath";
            this.ValuexPath.Name = "ValuexPath";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(685, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "Or";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(714, 163);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(80, 25);
            this.textBox1.TabIndex = 20;
            // 
            // ListPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 634);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dv1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ckIndb);
            this.Controls.Add(this.txtPageRegex);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPagexPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtListxPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtListURl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTaskName);
            this.Controls.Add(this.label1);
            this.Name = "ListPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListPage";
            ((System.ComponentModel.ISupportInitialize)(this.dv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtListURl;
        private System.Windows.Forms.TextBox txtListxPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPagexPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPageRegex;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox ckIndb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dv1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DbName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DbText;
        private DataGridViewComboEditBoxColumn DbTable;
        private System.Windows.Forms.DataGridViewComboBoxColumn DbType;
        private System.Windows.Forms.DataGridViewComboBoxColumn ValutType;
        private System.Windows.Forms.DataGridViewComboBoxColumn ValuexPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValueDivide;
        private DataGridViewComboEditBoxColumn dataGridViewComboEditBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
    }
}