using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SwagAttack.Models;

namespace SwagAttack.DAL
{
    static class UserList
    {
        static List<User> userList = new List<User>();

        static bool Add(User user)
        {
            if (!userList.Contains(user)) { 
                userList.Add(user);
                return true;
            }
            return false;
        }

        static bool validataUser(User user)
        {
            if (!userList.Contains(user))
            {
                return true;
            }
            return false;
        }

    }
}
