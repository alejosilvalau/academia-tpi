using System.Security.Cryptography;

namespace Utils
{
    public static class PasswordHasher
    {
        private const int SaltSize = 16;
        private const int KeySize = 32;
        private const int Iterations = 10000;

        public static string Hash(string password)
        {
            using var derive = new Rfc2898DeriveBytes(
                password,
                SaltSize,
                Iterations,
                HashAlgorithmName.SHA256);

            var salt = derive.Salt;
            var key = derive.GetBytes(KeySize);

            var result = new byte[1 + SaltSize + KeySize];
            result[0] = 1;
            Buffer.BlockCopy(salt, 0, result, 1, SaltSize);
            Buffer.BlockCopy(key, 0, result, 1 + SaltSize, KeySize);

            return Convert.ToBase64String(result);
        }

        public static bool Verify(string password, string storedHash)
        {
            byte[] data;
            try
            {
                data = Convert.FromBase64String(storedHash);
            }
            catch (FormatException)
            {
                return false;
            }

            if (data.Length < 1 + SaltSize + KeySize || data[0] != 1)
                return false;

            var salt = new byte[SaltSize];
            var expected = new byte[KeySize];
            Buffer.BlockCopy(data, 1, salt, 0, SaltSize);
            Buffer.BlockCopy(data, 1 + SaltSize, expected, 0, KeySize);

            using var derive = new Rfc2898DeriveBytes(
                password,
                salt,
                Iterations,
                HashAlgorithmName.SHA256);

            var actual = derive.GetBytes(KeySize);

            return CryptographicOperations.FixedTimeEquals(actual, expected);
        }
    }
}
