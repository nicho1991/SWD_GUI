using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using SwagAttack.Interfaces;

namespace SwagAttack.Models
{
    public class User : IUser
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public ILobby CreateLobby()
        {
            var lobby = new Lobby();
            lobby.AddUser(this);
            return lobby;
        }
    }
}
