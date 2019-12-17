namespace Session2V2
{
    partial class ManageRequest
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
            this.back_button = new System.Windows.Forms.Button();
            this.send_button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tech_note_richbox = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.StartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.department_label = new System.Windows.Forms.Label();
            this.asset_name_label = new System.Windows.Forms.Label();
            this.asset_sn_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.amount_updown = new System.Windows.Forms.NumericUpDown();
            this.parts_combo = new System.Windows.Forms.ComboBox();
            this.parts_dgv = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.remove_button = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amount_updown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parts_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(400, 411);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(148, 32);
            this.back_button.TabIndex = 11;
            this.back_button.Text = "Cancel";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // send_button
            // 
            this.send_button.Location = new System.Drawing.Point(246, 411);
            this.send_button.Name = "send_button";
            this.send_button.Size = new System.Drawing.Size(148, 32);
            this.send_button.TabIndex = 10;
            this.send_button.Text = "Submit";
            this.send_button.UseVisualStyleBackColor = true;
            this.send_button.Click += new System.EventHandler(this.Send_button_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tech_note_richbox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.EndDatePicker);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.StartDatePicker);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 164);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Asset EM Report";
            // 
            // tech_note_richbox
            // 
            this.tech_note_richbox.Location = new System.Drawing.Point(10, 76);
            this.tech_note_richbox.Name = "tech_note_richbox";
            this.tech_note_richbox.Size = new System.Drawing.Size(760, 70);
            this.tech_note_richbox.TabIndex = 7;
            this.tech_note_richbox.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Technician Note:";
            // 
            // EndDatePicker
            // 
            this.EndDatePicker.Location = new System.Drawing.Point(398, 22);
            this.EndDatePicker.Name = "EndDatePicker";
            this.EndDatePicker.Size = new System.Drawing.Size(200, 20);
            this.EndDatePicker.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(315, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Completed On:";
            // 
            // StartDatePicker
            // 
            this.StartDatePicker.Location = new System.Drawing.Point(80, 22);
            this.StartDatePicker.Name = "StartDatePicker";
            this.StartDatePicker.Size = new System.Drawing.Size(200, 20);
            this.StartDatePicker.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Start Date:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.department_label);
            this.groupBox1.Controls.Add(this.asset_name_label);
            this.groupBox1.Controls.Add(this.asset_sn_label);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 74);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Asset";
            // 
            // department_label
            // 
            this.department_label.AutoSize = true;
            this.department_label.Location = new System.Drawing.Point(673, 37);
            this.department_label.Name = "department_label";
            this.department_label.Size = new System.Drawing.Size(35, 13);
            this.department_label.TabIndex = 5;
            this.department_label.Text = "label6";
            // 
            // asset_name_label
            // 
            this.asset_name_label.AutoSize = true;
            this.asset_name_label.Location = new System.Drawing.Point(388, 37);
            this.asset_name_label.Name = "asset_name_label";
            this.asset_name_label.Size = new System.Drawing.Size(35, 13);
            this.asset_name_label.TabIndex = 4;
            this.asset_name_label.Text = "label5";
            // 
            // asset_sn_label
            // 
            this.asset_sn_label.AutoSize = true;
            this.asset_sn_label.Location = new System.Drawing.Point(70, 35);
            this.asset_sn_label.Name = "asset_sn_label";
            this.asset_sn_label.Size = new System.Drawing.Size(35, 13);
            this.asset_sn_label.TabIndex = 3;
            this.asset_sn_label.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(602, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Department:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Asset Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Asset SN:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.remove_button);
            this.groupBox3.Controls.Add(this.amount_updown);
            this.groupBox3.Controls.Add(this.parts_combo);
            this.groupBox3.Controls.Add(this.parts_dgv);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(12, 258);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 147);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Replacement Parts";
            // 
            // amount_updown
            // 
            this.amount_updown.DecimalPlaces = 2;
            this.amount_updown.Location = new System.Drawing.Point(360, 10);
            this.amount_updown.Name = "amount_updown";
            this.amount_updown.Size = new System.Drawing.Size(120, 20);
            this.amount_updown.TabIndex = 9;
            // 
            // parts_combo
            // 
            this.parts_combo.FormattingEnabled = true;
            this.parts_combo.Location = new System.Drawing.Point(64, 13);
            this.parts_combo.Name = "parts_combo";
            this.parts_combo.Size = new System.Drawing.Size(121, 21);
            this.parts_combo.TabIndex = 7;
            // 
            // parts_dgv
            // 
            this.parts_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.parts_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.parts_dgv.Location = new System.Drawing.Point(0, 39);
            this.parts_dgv.Name = "parts_dgv";
            this.parts_dgv.Size = new System.Drawing.Size(763, 99);
            this.parts_dgv.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(653, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 24);
            this.button1.TabIndex = 5;
            this.button1.Text = "+ Add to list";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(315, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Amount:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Part Name:";
            // 
            // remove_button
            // 
            this.remove_button.Location = new System.Drawing.Point(530, 10);
            this.remove_button.Name = "remove_button";
            this.remove_button.Size = new System.Drawing.Size(117, 24);
            this.remove_button.TabIndex = 13;
            this.remove_button.Text = "Remove Item";
            this.remove_button.UseVisualStyleBackColor = true;
            this.remove_button.Click += new System.EventHandler(this.Remove_button_Click);
            // 
            // ManageRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.send_button);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ManageRequest";
            this.Text = "ManageRequest";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amount_updown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parts_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button send_button;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label department_label;
        private System.Windows.Forms.Label asset_name_label;
        private System.Windows.Forms.Label asset_sn_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox tech_note_richbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker EndDatePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker StartDatePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView parts_dgv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown amount_updown;
        private System.Windows.Forms.ComboBox parts_combo;
        private System.Windows.Forms.Button remove_button;
    }
}