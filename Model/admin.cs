using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
      public class admin
    {
        private string _id;
        public string id
        {
            get { return _id; }
            set { _id = value; }
        }
          private string _username;
        public string username
        {
            get { return _username; }
            set { _username = value; }
        }
          private string _password;
        public string password
        {
            get { return _password; }
            set { _password = value; }
        }
    }
}
