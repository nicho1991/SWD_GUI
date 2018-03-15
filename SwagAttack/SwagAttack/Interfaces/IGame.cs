using System.Collections.Generic;

namespace SwagAttack.Interfaces
{
    public interface IGame
    {
        IReadOnlyCollection<IUser> UsersInGame { get; }
    }
}