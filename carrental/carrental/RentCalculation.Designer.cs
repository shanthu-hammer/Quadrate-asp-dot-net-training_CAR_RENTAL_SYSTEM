namespace carrental
{
    partial class RentCalculation
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.total_driver_cost = new System.Windows.Forms.TextBox();
            this.total_bill = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.btmdriveryes = new System.Windows.Forms.RadioButton();
            this.dtpreturnedime = new System.Windows.Forms.DateTimePicker();
            this.dtprented_date = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rent_calculate = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.comboBox_options = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_options);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.total_driver_cost);
            this.groupBox1.Controls.Add(this.total_bill);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.btmdriveryes);
            this.groupBox1.Controls.Add(this.dtpreturnedime);
            this.groupBox1.Controls.Add(this.dtprented_date);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rent_calculate);
            this.groupBox1.Location = new System.Drawing.Point(4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(899, 514);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 475);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Total Cost";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Driver Cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Driver";
            // 
            // total_driver_cost
            // 
            this.total_driver_cost.Location = new System.Drawing.Point(136, 394);
            this.total_driver_cost.Name = "total_driver_cost";
            this.total_driver_cost.Size = new System.Drawing.Size(100, 20);
            this.total_driver_cost.TabIndex = 13;
            // 
            // total_bill
            // 
            this.total_bill.Location = new System.Drawing.Point(136, 475);
            this.total_bill.Name = "total_bill";
            this.total_bill.Size = new System.Drawing.Size(100, 20);
            this.total_bill.TabIndex = 12;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(243, 177);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(37, 17);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "no";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // btmdriveryes
            // 
            this.btmdriveryes.AutoSize = true;
            this.btmdriveryes.Location = new System.Drawing.Point(136, 177);
            this.btmdriveryes.Name = "btmdriveryes";
            this.btmdriveryes.Size = new System.Drawing.Size(41, 17);
            this.btmdriveryes.TabIndex = 1;
            this.btmdriveryes.TabStop = true;
            this.btmdriveryes.Text = "yes";
            this.btmdriveryes.UseVisualStyleBackColor = true;
            // 
            // dtpreturnedime
            // 
            this.dtpreturnedime.CustomFormat = "dd-MM-yyyy";
            this.dtpreturnedime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpreturnedime.Location = new System.Drawing.Point(136, 128);
            this.dtpreturnedime.Name = "dtpreturnedime";
            this.dtpreturnedime.Size = new System.Drawing.Size(200, 20);
            this.dtpreturnedime.TabIndex = 10;
            // 
            // dtprented_date
            // 
            this.dtprented_date.CustomFormat = "dd-MM-yyyy";
            this.dtprented_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtprented_date.Location = new System.Drawing.Point(136, 75);
            this.dtprented_date.Name = "dtprented_date";
            this.dtprented_date.Size = new System.Drawing.Size(200, 20);
            this.dtprented_date.TabIndex = 9;
           
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(136, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "vechicle name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "End date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Start date";
            // 
            // rent_calculate
            // 
            this.rent_calculate.Location = new System.Drawing.Point(136, 255);
            this.rent_calculate.Name = "rent_calculate";
            this.rent_calculate.Size = new System.Drawing.Size(200, 23);
            this.rent_calculate.TabIndex = 4;
            this.rent_calculate.Text = "Submit";
            this.rent_calculate.UseVisualStyleBackColor = true;
            this.rent_calculate.Click += new System.EventHandler(this.rent_calculate_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // comboBox_options
            // 
            this.comboBox_options.FormattingEnabled = true;
            this.comboBox_options.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBox_options.Location = new System.Drawing.Point(136, 210);
            this.comboBox_options.Name = "comboBox_options";
            this.comboBox_options.Size = new System.Drawing.Size(121, 21);
            this.comboBox_options.TabIndex = 17;
            // 
            // RentCalculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 531);
            this.Controls.Add(this.groupBox1);
            this.Name = "RentCalculation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RentCalculation";
            this.Load += new System.EventHandler(this.RentCalculation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button rent_calculate;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpreturnedime;
        private System.Windows.Forms.DateTimePicker dtprented_date;
        private System.Windows.Forms.RadioButton btmdriveryes;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox total_driver_cost;
        private System.Windows.Forms.TextBox total_bill;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_options;
    }
}