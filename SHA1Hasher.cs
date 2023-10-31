using System;
using System.Security.Cryptography;
using System.Text;

public class SHA1Hasher
{
    public string ComputeSHA1Hash(string input)
    {
        using (SHA1 sha1 = SHA1.Create())
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] hashBytes = sha1.ComputeHash(inputBytes);
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

        SHA1Hasher sha1 = new SHA1Hasher();
        string hash = sha1.ComputeSHA1Hash(input);

        Console.WriteLine("Input: " + input);
        Console.WriteLine("SHA-1 Hash: " + hash);
    }
}
