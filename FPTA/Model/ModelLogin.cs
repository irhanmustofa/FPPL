using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPTA.Model
{
    class ModelLogin
    {
        //declare var hasil
        private bool hasil;

        public bool GetHasil()
        {
            return hasil;
        }

        //function
        public void CheckLogin(string username, string password)
        {
            if (username == "irhan" && password == "admin")
            {
                hasil = true;
            }
            else
            {
                hasil = false;
            }
        }
    }
}
