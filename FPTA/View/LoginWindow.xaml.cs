using FPTA.Controller;
using FPTA.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FPTA
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private ControllerLogin controller;
        public LoginWindow()
        {
            InitializeComponent();
            Model.SambungDB conection = new Model.SambungDB();
            conection.TestConnect();

            controller = new ControllerLogin(this);
        }

        private void txtPassword_GotFocus(object sender, RoutedEventArgs e)
        {
            txtPassword.Password = "";
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            //call function
            controller.ValidasiLogin();
        }

        private void txtUsername_GotFocus(object sender, RoutedEventArgs e)
        {
            txtUsername.SelectionStart = 0;
            txtUsername.SelectionLength = txtUsername.Text.Length;
        }
    }
}

namespace FPTA.Model
{
    public class ConnectDB
    {
        internal void TestConnection()
        {
            throw new NotImplementedException();
        }
    }
}