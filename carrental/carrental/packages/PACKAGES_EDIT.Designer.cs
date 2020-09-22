namespace carrental
{
    partial class EDIT
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
            this.button2 = new System.Windows.Forms.Button();
            this.ADD = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ygujygu = new System.Windows.Forms.Label();
            this.Package_Name = new System.Windows.Forms.TextBox();
            this.Package_Cost = new System.Windows.Forms.TextBox();
            this.Package_Distance = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(125, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "DELETE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ADD
            // 
            this.ADD.Location = new System.Drawing.Point(-4, 171);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(100, 23);
            this.ADD.TabIndex = 19;
            this.ADD.Text = "ADD";
            this.ADD.UseVisualStyleBackColor = true;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(4, 214);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "BACK";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Package Distance ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Package_Cost";
            // 
            // ygujygu
            // 
            this.ygujygu.AutoSize = true;
            this.ygujygu.Location = new System.Drawing.Point(12, 33);
            this.ygujygu.Name = "ygujygu";
            this.ygujygu.Size = new System.Drawing.Size(84, 13);
            this.ygujygu.TabIndex = 15;
            this.ygujygu.Text = "Package Name ";
            // 
            // Package_Name
            // 
            this.Package_Name.Location = new System.Drawing.Point(125, 33);
            this.Package_Name.Name = "Package_Name";
            this.Package_Name.Size = new System.Drawing.Size(100, 20);
            this.Package_Name.TabIndex = 14;
            // 
            // Package_Cost
            // 
            this.Package_Cost.Location = new System.Drawing.Point(125, 72);
            this.Package_Cost.Name = "Package_Cost";
            this.Package_Cost.Size = new System.Drawing.Size(100, 20);
            this.Package_Cost.TabIndex = 13;
            // 
            // Package_Distance
            // 
            this.Package_Distance.Location = new System.Drawing.Point(125, 116);
            this.Package_Distance.Name = "Package_Distance";
            this.Package_Distance.Size = new System.Drawing.Size(100, 20);
            this.Package_Distance.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ygujygu);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.Package_Name);
            this.groupBox1.Controls.Add(this.ADD);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Package_Cost);
            this.groupBox1.Controls.Add(this.Package_Distance);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 335);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // EDIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "EDIT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Review Packages";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ygujygu;
        private System.Windows.Forms.TextBox Package_Name;
        private System.Windows.Forms.TextBox Package_Cost;
        private System.Windows.Forms.TextBox Package_Distance;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}