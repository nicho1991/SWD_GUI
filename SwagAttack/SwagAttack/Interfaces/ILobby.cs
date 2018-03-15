 using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SwagAttack.Interfaces
{
    public interface ILobby
    {
        IReadOnlyCollection<IUser> UsersInLobby { get; }
        void AddUser(IUser user);
        void RemoveUser(IUser user);
        void StartGame();
    }
}