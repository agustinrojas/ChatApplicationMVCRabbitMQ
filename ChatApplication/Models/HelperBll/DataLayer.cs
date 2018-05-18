using ChatApplication.Models.HelperBll;
using ChatRabbit.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ChatRabbit.Models
{
    public class DataLayer
    {

        public UserModel Login(string email, string password)
        {
            UserModel agus = new UserModel
            {
                userid = 1,
                email = "agusprueba@gmail.com",
                mobile = "665543899",
                password = "Password",
                confirmpassword = "Password",
                dob = "02/02/1994"
            };
            UserModel usuario2 = new UserModel
            {
                userid = 1,
                email = "usuario2prueba@gmail.com",
                mobile = "601928376",
                password = "Password2",
                confirmpassword = "Password2",
                dob = "04/04/1994"
            };
            if (password.Equals(agus.password))
            {
                return agus;
            }
            else
            {
                return usuario2;
            }

        }

        public List<UserModel> Getusers(int id)
        {
            List<UserModel> userlist = new List<UserModel>
            {
                new UserModel
                {
                userid = 1,
                email = "agusprueba@gmail.com",
                mobile = "665543899",
                password = "Password",
                confirmpassword = "Password",
                dob = "02/02/1994"
                },
                new UserModel
                {
                userid = 1,
                email = "usuario2prueba@gmail.com",
                mobile = "601928376",
                password = "Password",
                confirmpassword = "Password",
                dob = "04/04/1994"
                },
            };

            return userlist;
        }
    }
}