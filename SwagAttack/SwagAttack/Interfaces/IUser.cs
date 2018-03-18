using System.Collections.Generic;

namespace SwagAttack.Interfaces
{
    public interface IUser
    {
        string Username { get; }
        string Password { get; }
        string Email { get; }
        IReadOnlyCollection<IGame> AktiveSpilListe { get; }
        void AddAktivtSpil(IGame game);
        void removeAktivtSpil(IGame game);
        ILobby CreateLobby();
    }
}