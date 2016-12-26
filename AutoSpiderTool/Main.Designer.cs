namespace AutoSpiderTool
{
    partial class Main
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
            this.txtpro = new System.Windows.Forms.TextBox();
            this.btop = new System.Windows.Forms.Button();
            this.txthome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblist = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "项目";
            // 
            // txtpro
            // 
            this.txtpro.Location = new System.Drawing.Point(132, 57);
            this.txtpro.Name = "txtpro";
            this.txtpro.Size = new System.Drawing.Size(243, 25);
            this.txtpro.TabIndex = 1;
            // 
            // btop
            // 
            this.btop.Location = new System.Drawing.Point(150, 197);
            this.btop.Name = "btop";
            this.btop.Size = new System.Drawing.Size(107, 34);
            this.btop.TabIndex = 2;
            this.btop.Text = "新建";
            this.btop.UseVisualStyleBackColor = true;
            this.btop.Click += new System.EventHandler(this.btop_Click);
            // 
            // txthome
            // 
            this.txthome.Location = new System.Drawing.Point(132, 109);
            this.txthome.Name = "txthome";
            this.txthome.Size = new System.Drawing.Size(243, 25);
            this.txthome.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "官方地址";
            // 
            // lblist
            // 
            this.lblist.FormattingEnabled = true;
            this.lblist.ItemHeight = 15;
            this.lblist.Location = new System.Drawing.Point(444, 57);
            this.lblist.Name = "lblist";
            this.lblist.Size = new System.Drawing.Size(120, 199);
            this.lblist.TabIndex = 5;
            this.lblist.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lblist_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 401);
            this.Controls.Add(this.lblist);
            this.Controls.Add(this.txthome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btop);
            this.Controls.Add(this.txtpro);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpro;
        private System.Windows.Forms.Button btop;
        private System.Windows.Forms.TextBox txthome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lblist;
    }
}

