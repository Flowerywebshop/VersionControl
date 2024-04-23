namespace kliens_app_rendeles
{
    partial class Bejelentkezes
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
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Mégse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(156, 17);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(214, 22);
            this.usernameTextBox.TabIndex = 0;
            this.usernameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.usernameTextBox_Validating);
            this.usernameTextBox.Validated += new System.EventHandler(this.usernameTextBox_Validated);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(156, 53);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(214, 22);
            this.emailTextBox.TabIndex = 1;
            this.emailTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.emailTextBox_Validating);
            this.emailTextBox.Validated += new System.EventHandler(this.emailTextBox_Validated);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(156, 82);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(214, 22);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.passwordTextBox_Validating);
            this.passwordTextBox.Validated += new System.EventHandler(this.passwordTextBox_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Felhasználónév:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Jelszó:";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(131, 135);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 6;
            this.submitButton.Text = "Belépés";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Mégse
            // 
            this.Mégse.CausesValidation = false;
            this.Mégse.Enabled = false;
            this.Mégse.Location = new System.Drawing.Point(240, 135);
            this.Mégse.Name = "Mégse";
            this.Mégse.Size = new System.Drawing.Size(75, 23);
            this.Mégse.TabIndex = 7;
            this.Mégse.Text = "button1";
            this.Mégse.UseVisualStyleBackColor = true;
            // 
            // Bejelentkezes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 183);
            this.Controls.Add(this.Mégse);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Name = "Bejelentkezes";
            this.Text = "Bejelentkezes";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button Mégse;
    }
}