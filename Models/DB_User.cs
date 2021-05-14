using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserApp.Models
{
    public class DB_User
    {
        List<User> userList = new List<User>()
        {
            new User(){idUser=1,fname="admin",lname="user",Pass="pass1234",Email="admin@gmail.com"},
            new User(){idUser=1,fname="user",lname="user",Pass="pass1234",Email="admin1@gmail.com"},

        };

        public List<User> GetAllUsers()
        {
            return userList;
        }

        public List<User> Add(User objUser)
        {
            userList.Add(objUser);
            return userList;
        }
    }
}
