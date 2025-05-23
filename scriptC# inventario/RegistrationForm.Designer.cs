namespace DevStreamInventory // Certifique-se que este namespace é o mesmo do seu projeto
{
    partial class RegistrationForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblNewUsername;
        private System.Windows.Forms.TextBox txtNewUsername;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Button btnRegisterUser;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblNewUsername = new System.Windows.Forms.Label();
            this.txtNewUsername = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.btnRegisterUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNewUsername
            // 
            this.lblNewUsername.AutoSize = true;
            this.lblNewUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNewUsername.Location = new System.Drawing.Point(28, 30);
            this.lblNewUsername.Name = "lblNewUsername";
            this.lblNewUsername.Size = new System.Drawing.Size(83, 15);
            this.lblNewUsername.TabIndex = 0;
            this.lblNewUsername.Text = "Novo Usuário:";
            // 
            // txtNewUsername
            // 
            this.txtNewUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNewUsername.Location = new System.Drawing.Point(31, 49);
            this.txtNewUsername.Name = "txtNewUsername";
            this.txtNewUsername.Size = new System.Drawing.Size(220, 23);
            this.txtNewUsername.TabIndex = 1;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNewPassword.Location = new System.Drawing.Point(28, 83);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(73, 15);
            this.lblNewPassword.TabIndex = 2;
            this.lblNewPassword.Text = "Nova Senha:";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNewPassword.Location = new System.Drawing.Point(31, 102);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(220, 23);
            this.txtNewPassword.TabIndex = 3;
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblConfirmPassword.Location = new System.Drawing.Point(28, 136);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(99, 15);
            this.lblConfirmPassword.TabIndex = 4;
            this.lblConfirmPassword.Text = "Confirmar Senha:";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtConfirmPassword.Location = new System.Drawing.Point(31, 155);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(220, 23);
            this.txtConfirmPassword.TabIndex = 5;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // btnRegisterUser
            // 
            this.btnRegisterUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRegisterUser.Location = new System.Drawing.Point(90, 195);
            this.btnRegisterUser.Name = "btnRegisterUser";
            this.btnRegisterUser.Size = new System.Drawing.Size(100, 30);
            this.btnRegisterUser.TabIndex = 6;
            this.btnRegisterUser.Text = "Registrar";
            this.btnRegisterUser.UseVisualStyleBackColor = true;
            this.btnRegisterUser.Click += new System.EventHandler(this.btnRegisterUser_Click);
            // 
            // RegistrationForm
            // 
            this.AcceptButton = this.btnRegisterUser;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 251);
            this.Controls.Add(this.btnRegisterUser);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.txtNewUsername);
            this.Controls.Add(this.lblNewUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registrar Novo Usuário";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}