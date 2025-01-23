using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_lole
{
    internal class User
    {
        string? _id;
        string? _name;
        string? _email;
        string? _password;
        int _phone;

        public string?
            Id { get { return _id; }
            set { _id = value; }
        }
        public string?
            Name { get { return _name; }
            set { _name = value; }
        }
        public string?
            Email { get { return _email; }
            set { _email = value; }
        }
        public int
            Phone { get { return _phone; }
            set { _phone = value; } }
        public string? Password { get { return _password; } set { _password = value; } }

        public User(string id, string name, string email, string password, int phone)
        {
            _id = id;
            _name = name;
            _email = email;
            _password = password;
            _phone = phone;
        }


    }
}

