using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.IO; // Para System.IO.File
using System.Windows.Forms; // Para MessageBox

public static class AuthService
{
    private static List<User> users = new List<User>();
    private static readonly string UsersFilePath = "users.dat"; // Salva na pasta do executável

    // Simples "salt" e hash para demonstração. NÃO USE EM PRODUÇÃO.
    private static string GenerateSalt()
    {
        byte[] saltBytes = new byte[16];
        using (var rng = new RNGCryptoServiceProvider())
        {
            rng.GetBytes(saltBytes);
        }
        return Convert.ToBase64String(saltBytes);
    }

    private static string HashPassword(string password, string salt)
    {
        using (var sha256 = SHA256.Create())
        {
            var saltedPassword = password + salt; // Combinar senha e salt
            byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(saltedPassword));
            return Convert.ToBase64String(hashedBytes) + ":" + salt; // Armazenar salt junto com o hash
        }
    }

    public static bool VerifyPassword(string password, string hashedPasswordWithSalt)
    {
        try
        {
            var parts = hashedPasswordWithSalt.Split(':');
            if (parts.Length != 2) return false; // Formato inválido

            string storedHash = parts[0];
            string salt = parts[1];

            using (var sha256 = SHA256.Create())
            {
                var saltedPassword = password + salt;
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(saltedPassword));
                string computedHash = Convert.ToBase64String(hashedBytes);
                return storedHash == computedHash;
            }
        }
        catch
        {
            return false; // Erro durante a verificação
        }
    }

    public static bool RegisterUser(string username, string password)
    {
        if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
        {
            MessageBox.Show("Nome de usuário e senha não podem estar vazios.", "Erro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        if (users.Any(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase)))
        {
            MessageBox.Show("Nome de usuário já existe.", "Erro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        string salt = GenerateSalt();
        string hashedPassword = HashPassword(password, salt);
        users.Add(new User { Username = username, PasswordHash = hashedPassword });
        SaveUsersToFile(); // Salva após registro bem-sucedido
        return true;
    }

    public static User LoginUser(string username, string password)
    {
        if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password)) return null;
        var user = users.FirstOrDefault(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase));
        if (user != null && VerifyPassword(password, user.PasswordHash))
        {
            return user;
        }
        return null;
    }

    public static void LoadUsersFromFile()
    {
        users.Clear();
        if (File.Exists(UsersFilePath))
        {
            try
            {
                string[] lines = File.ReadAllLines(UsersFilePath);
                foreach (string line in lines)
                {
                    var parts = line.Split(new char[] {','}, 2); // Dividir em no máximo 2 partes
                    if (parts.Length == 2)
                    {
                        users.Add(new User { Username = parts[0], PasswordHash = parts[1] });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar usuários: {ex.Message}\nCaminho: {Path.GetFullPath(UsersFilePath)}", "Erro de Leitura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public static void SaveUsersToFile()
    {
        try
        {
            List<string> lines = new List<string>();
            foreach (var user in users)
            {
                lines.Add($"{user.Username},{user.PasswordHash}");
            }
            File.WriteAllLines(UsersFilePath, lines);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao salvar usuários: {ex.Message}\nCaminho: {Path.GetFullPath(UsersFilePath)}", "Erro de Escrita", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}