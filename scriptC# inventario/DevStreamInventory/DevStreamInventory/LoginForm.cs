using System;
using System.Windows.Forms;
using System.Linq; // Para Application.OpenForms

namespace DevStreamInventory // Certifique-se que este namespace é o mesmo do seu projeto
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.Text = "Login - Sistema de Inventário DevStream";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = AuthService.LoginUser(txtUsername.Text, txtPassword.Text);
            if (user != null)
            {
                MessageBox.Show("Login bem-sucedido!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainForm mainForm = new MainForm(user); // Passa o usuário logado para o MainForm
                mainForm.Show();
                this.Hide(); // Esconde o formulário de login
            }
            else
            {
                MessageBox.Show("Nome de usuário ou senha inválidos.", "Falha no Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm regForm = new RegistrationForm();
            regForm.ShowDialog(this); // Mostra como um diálogo modal, filho deste form
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Salva usuários sempre que o formulário de login estiver fechando
            AuthService.SaveUsersToFile();

            // Garante que a aplicação feche se o formulário de login for fechado pelo usuário
            // e o MainForm não estiver visível (ou seja, o usuário não fez login com sucesso).
            if (e.CloseReason == CloseReason.UserClosing)
            {
                bool mainFormIsOpenAndVisible = false;
                foreach (Form openForm in Application.OpenForms)
                {
                    if (openForm is MainForm && openForm.Visible)
                    {
                        mainFormIsOpenAndVisible = true;
                        break;
                    }
                }
                if (!mainFormIsOpenAndVisible)
                {
                    Application.Exit();
                }
            }
        }
    }
}