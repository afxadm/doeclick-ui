namespace Totem.Domain.Util
{
    public static class PasswordHelper
    {
        public static string HashPassword(string password)
        {
            int workFactor = 12;
            return BCrypt.Net.BCrypt.HashPassword(password, workFactor);
        }

        public static bool ValidatePassword(string password, string hashedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
        }
    }
}
