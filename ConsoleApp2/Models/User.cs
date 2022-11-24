using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    internal class User
    {
        private string _username;
        private string _password;
        private string _products;
        //private string _isSignedIn;

        public string Username { get => _username;
            set {
                if(Username.Trim().Length >=6 && Username.Trim().Length <=25)
                {
                     _username = value;
                }
                else Console.WriteLine("Istifadechi adi 6 ve 25 sinvol araliginda olmalidir.");
                
            } 
        }
        public string Password { get=>_username;
            set
            {
                if(Password.Trim().Length >=8 && Password.Trim().Length <=25)
                {
                    _password = value;
                }
                
                else Console.WriteLine("Sifre 8 ve 25 sinvol araliginda olmalidir.");
            }
        }
        public string Product { get=> _products; set=> _products=value; }

        public User(string username, string password, string product)
        {
            Username = username;
            Password = password;
            _products = product;
            
        }

        public static void CheckPassword(string password)
        {
            for(int i = 0; i < password.Length; i++)
            {
                
            }
        }
    }
}
