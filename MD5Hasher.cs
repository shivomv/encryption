using System;
using System.Security.Cryptography;
using System.Text;

public class MD5Hasher
{
    public string ComputeMD5Hash(string input)
    {
        using (MD5 md5 = MD5.Create())
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] hashBytes = md5.ComputeHash(inputBytes);
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

        MD5Hasher md5 = new MD5Hasher();
        string md5Hash = md5.ComputeMD5Hash(input);

        Console.WriteLine("Input: " + input);
        Console.WriteLine("MD5 Hash: " + md5Hash);
    }
}
