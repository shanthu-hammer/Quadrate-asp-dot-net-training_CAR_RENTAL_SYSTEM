namespace carrental
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Package_Distance = new System.Windows.Forms.TextBox();
            this.Package_Cost = new System.Windows.Forms.TextBox();
            this.Package_Name = new System.Windows.Forms.TextBox();
            this.ygujygu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.ADD = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.ADD);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ygujygu);
            this.groupBox1.Controls.Add(this.Package_Name);
            this.groupBox1.Controls.Add(this.Package_Cost);
            this.groupBox1.Controls.Add(this.Package_Distance);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1054, 504);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Package_Distance
            // 
            this.Package_Distance.Location = new System.Drawing.Point(124, 246);
            this.Package_Distance.Name = "Package_Distance";
            this.Package_Distance.Size = new System.Drawing.Size(100, 20);
            this.Package_Distance.TabIndex = 3;
            // 
            // Package_Cost
            // 
            this.Package_Cost.Location = new System.Drawing.Point(124, 181);
            this.Package_Cost.Name = "Package_Cost";
            this.Package_Cost.Size = new System.Drawing.Size(100, 20);
            this.Package_Cost.TabIndex = 4;
            // 
            // Package_Name
            // 
            this.Package_Name.Location = new System.Drawing.Point(124, 126);
            this.Package_Name.Name = "Package_Name";
            this.Package_Name.Size = new System.Drawing.Size(100, 20);
            this.Package_Name.TabIndex = 5;
            // 
            // ygujygu
            // 
            this.ygujygu.AutoSize = true;
            this.ygujygu.Location = new System.Drawing.Point(22, 126);
            this.ygujygu.Name = "ygujygu";
            this.ygujygu.Size = new System.Drawing.Size(84, 13);
            this.ygujygu.TabIndex = 6;
            this.ygujygu.Text = "Package Name ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Package_Cost";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Package Distance ";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 380);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "BACK";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // ADD
            // 
            this.ADD.Location = new System.Drawing.Point(6, 334);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(100, 23);
            this.ADD.TabIndex = 10;
            this.ADD.Text = "ADD";
            this.ADD.UseVisualStyleBackColor = true;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(112, 334);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "DELETE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1060, 510);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Package_Name;
        private System.Windows.Forms.TextBox Package_Cost;
        private System.Windows.Forms.TextBox Package_Distance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ygujygu;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.Button button2;
    }
}
