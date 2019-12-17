namespace Session2V2
{
    partial class LoginForm
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
            this.lyn = new System.Windows.Forms.Button();
            this.josfa = new System.Windows.Forms.Button();
            this.kill_button = new System.Windows.Forms.Button();
            this.login_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.password_box = new System.Windows.Forms.TextBox();
            this.username_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lyn
            // 
            this.lyn.Location = new System.Drawing.Point(555, 153);
            this.lyn.Name = "lyn";
            this.lyn.Size = new System.Drawing.Size(75, 23);
            this.lyn.TabIndex = 9;
            this.lyn.Text = "goddamnlyn";
            this.lyn.UseVisualStyleBackColor = true;
            this.lyn.Click += new System.EventHandler(this.Lyn_Click);
            // 
            // josfa
            // 
            this.josfa.Location = new System.Drawing.Point(555, 124);
            this.josfa.Name = "josfa";
            this.josfa.Size = new System.Drawing.Size(75, 23);
            this.josfa.TabIndex = 8;
            this.josfa.Text = "josfalmao";
            this.josfa.UseVisualStyleBackColor = true;
            this.josfa.Click += new System.EventHandler(this.Josfa_Click);
            // 
            // kill_button
            // 
            this.kill_button.Location = new System.Drawing.Point(479, 321);
            this.kill_button.Name = "kill_button";
            this.kill_button.Size = new System.Drawing.Size(75, 23);
            this.kill_button.TabIndex = 7;
            this.kill_button.Text = "Cancel";
            this.kill_button.UseVisualStyleBackColor = true;
            this.kill_button.Click += new System.EventHandler(this.Kill_button_Click);
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(398, 321);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(75, 23);
            this.login_button.TabIndex = 6;
            this.login_button.Text = "OK";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.password_box);
            this.groupBox1.Controls.Add(this.username_box);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(170, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 209);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sign in to EM Management";
            // 
            // password_box
            // 
            this.password_box.Location = new System.Drawing.Point(90, 140);
            this.password_box.Name = "password_box";
            this.password_box.Size = new System.Drawing.Size(113, 20);
            this.password_box.TabIndex = 3;
            // 
            // username_box
            // 
            this.username_box.Location = new System.Drawing.Point(90, 54);
            this.username_box.Name = "username_box";
            this.username_box.Size = new System.Drawing.Size(113, 20);
            this.username_box.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lyn);
            this.Controls.Add(this.josfa);
            this.Controls.Add(this.kill_button);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.groupBox1);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button lyn;
        private System.Windows.Forms.Button josfa;
        private System.Windows.Forms.Button kill_button;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox password_box;
        private System.Windows.Forms.TextBox username_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

