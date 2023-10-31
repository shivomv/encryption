class Program
{
    static void Main()
    {
        string input = "Hello, World!"; // Replace this with your input data

        SHA1Encryption sha1Encryptor = new SHA1Encryption();
        string hash = sha1Encryptor.ComputeSHA1Hash(input);

        Console.WriteLine("Input: " + input);
        Console.WriteLine("SHA-1 Hash: " + hash);
    }
}
