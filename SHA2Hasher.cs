using System;
using System.Security.Cryptography;
using System.Text;

public class SHA2Hasher
{
    public string ComputeSHA256Hash(string input)
    {
        using (SHA256 sha256 = SHA256.Create())
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] hashBytes = sha256.ComputeHash(inputBytes);
            string hashHex = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            return hashHex;
        }
    }

    public string ComputeSHA512Hash(string input)
    {
        using (SHA512 sha512 = SHA512.Create())
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] hashBytes = sha512.ComputeHash(inputBytes);
            string hashHex = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            return hashHex;
        }
    }
}

class Program
{
    static void Main()
    {
        string input = "Hello, World!"; // Replace this with your input data

        SHA2Hasher sha2 = new SHA2Hasher();
        string sha256Hash = sha2.ComputeSHA256Hash(input);
        string sha512Hash = sha2.ComputeSHA512Hash(input);

        Console.WriteLine("Input: " + input);
        Console.WriteLine("SHA-256 Hash: " + sha256Hash);
        Console.WriteLine("SHA-512 Hash: " + sha512Hash);
    }
}
