using demo_var1.AppModel;
using demo_var1.AppServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp;

namespace demo_var1.AppForms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            ContextManager.loginForm = this;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Login(textBoxLogin.Text.Trim(), textBoxPassword.Text.Trim());
        }

        private void Login(string login, string password)
        {
            User user = Program.contextDB.Users.Where(u => u.Login == login && u.Password == password).FirstOrDefault();

            if (user == null)
            {
                MessageBox.Show("Пользователь с таким логином и паролем не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ContextManager.user = user;
            ProductForm productForm = new ProductForm();
            ContextManager.loginForm.Hide();
            ContextManager.productForm.Show();
            textBoxLogin.Text = string.Empty;
            textBoxPassword.Text = string.Empty;
        }

        private void buttonGuest_Click(object sender, EventArgs e)
        {
            ContextManager.user = null;
            ProductForm productForm = new ProductForm();
            ContextManager.loginForm.Hide();
            ContextManager.productForm.Show();
        }
    }
}
