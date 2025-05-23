using System;
using System.Windows.Forms;

namespace DevStreamInventory // Certifique-se que este namespace é o mesmo do seu projeto
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
            this.Text = "Registro - Sistema de Inventário DevStream";
        }

        private void btnRegisterUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNewUsername.Text) || 
                string.IsNullOrWhiteSpace(txtNewPassword.Text) ||
                string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                MessageBox.Show("Todos os campos são obrigatórios.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtNewPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("As senhas não coincidem.", "Falha no Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool success = AuthService.RegisterUser(txtNewUsername.Text, txtNewPassword.Text);
            if (success)
            {
                MessageBox.Show("Usuário registrado com sucesso! Você já pode fazer login.", "Sucesso no Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // AuthService.SaveUsersToFile(); // Já é chamado dentro do RegisterUser
                this.Close(); // Fecha o formulário de registro
            }
            // AuthService.RegisterUser já mostra mensagens de erro específicas.
        }
    }
}