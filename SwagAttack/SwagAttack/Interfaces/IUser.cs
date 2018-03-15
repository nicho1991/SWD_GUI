namespace SwagAttack.Interfaces
{
    public interface IUser
    {
        string Username { get; }
        string Password { get; }
        string Email { get; }
        ILobby CreateLobby();
    }
}