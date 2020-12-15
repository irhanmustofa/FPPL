using FPTA.Model;
using FPTA.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FPTA.Controller
{
    class ControllerLogin
    {
        private ModelLogin model;
        private LoginWindow view;

        public ControllerLogin(LoginWindow view)
        {
            model = new ModelLogin();
            this.view = view;
        }

        public void ValidasiLogin()
        {
            model.CheckLogin(view.txtUsername.Text, view.txtPassword.Password);
            bool hasil = model.GetHasil();
            if (hasil)
            {
                HomePage home = new HomePage();
                home.Show();
                view.Close();
            }
            else
            {
                MessageBox.Show("Username/Password Salah!!");
                view.txtUsername.Text = "";
                view.txtPassword.Password = "";
                view.txtUsername.Focus();
            }
        }
    }
}
