namespace Session2V2
{
    partial class CreateRequest
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
            this.otherconsideration_richbox = new System.Windows.Forms.RichTextBox();
            this.priority_combo = new System.Windows.Forms.ComboBox();
            this.desc_richbox = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.department_label = new System.Windows.Forms.Label();
            this.asset_name_label = new System.Windows.Forms.Label();
            this.asset_sn_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(388, 411);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(132, 31);
            this.back_button.TabIndex = 7;
            this.back_button.Text = "Cancel";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // send_button
            // 
            this.send_button.Location = new System.Drawing.Point(267, 411);
            this.send_button.Name = "send_button";
            this.send_button.Size = new System.Drawing.Size(115, 31);
            this.send_button.TabIndex = 6;
            this.send_button.Text = "Send Request";
            this.send_button.UseVisualStyleBackColor = true;
            this.send_button.Click += new System.EventHandler(this.Send_button_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.otherconsideration_richbox);
            this.groupBox2.Controls.Add(this.priority_combo);
            this.groupBox2.Controls.Add(this.desc_richbox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 289);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Request Report";
            this.groupBox2.Enter += new System.EventHandler(this.GroupBox2_Enter);
            // 
            // otherconsideration_richbox
            // 
            this.otherconsideration_richbox.Location = new System.Drawing.Point(58, 179);
            this.otherconsideration_richbox.Name = "otherconsideration_richbox";
            this.otherconsideration_richbox.Size = new System.Drawing.Size(271, 54);
            this.otherconsideration_richbox.TabIndex = 6;
            this.otherconsideration_richbox.Text = "";
            // 
            // priority_combo
            // 
            this.priority_combo.FormattingEnabled = true;
            this.priority_combo.Location = new System.Drawing.Point(58, 42);
            this.priority_combo.Name = "priority_combo";
            this.priority_combo.Size = new System.Drawing.Size(121, 21);
            this.priority_combo.TabIndex = 5;
            // 
            // desc_richbox
            // 
            this.desc_richbox.Location = new System.Drawing.Point(58, 97);
            this.desc_richbox.Name = "desc_richbox";
            this.desc_richbox.Size = new System.Drawing.Size(271, 54);
            this.desc_richbox.TabIndex = 4;
            this.desc_richbox.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Other Considerations:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Description of Emergency:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Priority:";
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
            this.groupBox1.Size = new System.Drawing.Size(776, 110);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Asset";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // department_label
            // 
            this.department_label.AutoSize = true;
            this.department_label.Location = new System.Drawing.Point(673, 49);
            this.department_label.Name = "department_label";
            this.department_label.Size = new System.Drawing.Size(35, 13);
            this.department_label.TabIndex = 5;
            this.department_label.Text = "label6";
            // 
            // asset_name_label
            // 
            this.asset_name_label.AutoSize = true;
            this.asset_name_label.Location = new System.Drawing.Point(388, 49);
            this.asset_name_label.Name = "asset_name_label";
            this.asset_name_label.Size = new System.Drawing.Size(35, 13);
            this.asset_name_label.TabIndex = 4;
            this.asset_name_label.Text = "label5";
            // 
            // asset_sn_label
            // 
            this.asset_sn_label.AutoSize = true;
            this.asset_sn_label.Location = new System.Drawing.Point(70, 47);
            this.asset_sn_label.Name = "asset_sn_label";
            this.asset_sn_label.Size = new System.Drawing.Size(35, 13);
            this.asset_sn_label.TabIndex = 3;
            this.asset_sn_label.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(602, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Department:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Asset Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Asset SN:";
            // 
            // CreateRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.send_button);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CreateRequest";
            this.Text = "CreateRequest";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button send_button;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox otherconsideration_richbox;
        private System.Windows.Forms.ComboBox priority_combo;
        private System.Windows.Forms.RichTextBox desc_richbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label department_label;
        private System.Windows.Forms.Label asset_name_label;
        private System.Windows.Forms.Label asset_sn_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}