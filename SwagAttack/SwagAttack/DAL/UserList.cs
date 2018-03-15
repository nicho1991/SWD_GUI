using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwagAttack.Interfaces;
using SwagAttack.Models;

namespace SwagAttack.DAL
{
    public static class UserList
    {
        static List<IUser> listOfUsers = new List<IUser>();

        public static bool Add(IUser user)
        {
            if (!listOfUsers.Contains(user)) { 
                listOfUsers.Add(user);
                return true;
            }
            return false;
        }

        public static bool ValidataUser(IUser user)
        {
            if (!listOfUsers.Contains(user))
            {
                return true;
            }
            return false;
        }

        public static void Remove(IUser user)
        {
            listOfUsers.Remove(user);
        }

        public static IUser FindUser(string username)
        {
            var user = listOfUsers.Find(u => u.Username == username);
            return user;
        }

    }
}
