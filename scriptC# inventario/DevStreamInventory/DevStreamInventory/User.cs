public class User
{
    public string Username { get; set; }
    public string PasswordHash { get; set; } // Armazenar hash da senha, não a senha em si
}