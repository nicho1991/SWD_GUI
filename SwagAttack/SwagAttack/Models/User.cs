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
        private readonly List<IGame> _AktiveSpilListe = new List<IGame>();

        public IReadOnlyCollection<IGame> AktiveSpilListe => _AktiveSpilListe;

        public void AddAktivtSpil(IGame game)
        {
            if (!_AktiveSpilListe.Contains(game))
                _AktiveSpilListe.Add(game);
        }

        public void removeAktivtSpil(IGame game)
        {
            if (_AktiveSpilListe.Contains(game))
                _AktiveSpilListe.Remove(game);
        }
        public ILobby CreateLobby()
        {
            var lobby = new Lobby();
            lobby.AddUser(this);
            return lobby;
        }
    }
}
