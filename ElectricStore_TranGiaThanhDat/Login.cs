using Services.Models;
using Services.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectricStore_TranGiaThanhDat
{
    public partial class Login : Form
    {
        UserRepository _userRepository;

        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = new User();
            String username = txtUsername.Text;
            String password = txtPassword.Text;
            _userRepository = new UserRepository();
            var checkAccount = _userRepository.GetAll();
            user = checkAccount.FirstOrDefault(a => (a.UserName.Equals(username) && (a.Password.Equals(password))));
            if (user != null)
            {
                if (user.UserRole == 1)
                {
                    this.Hide();
                    Form form = new ProductManagement();
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Sorry, you are not allowed to access", "System");
                    clear();
                }
            }
            else
            {
                MessageBox.Show("Sorry, you are not allowed to access", "System");
                clear();
            }
        }

        private void clear()
        {
            txtPassword.Text = "";
            txtUsername.Text = "";
        }
    }
}
