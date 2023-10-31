# Encryption and Hash Functions

This repository contains C# code for computing various hash functions and encryption techniques. You can use these functions to calculate cryptographic hash values and perform encryption of input data. Below are the supported hash functions:

- MD5 (Message Digest 5): Computes the MD5 hash of a given input string.
- SHA-1 (Secure Hash Algorithm 1): Calculates the SHA-1 hash of the input.
- SHA-256 (Secure Hash Algorithm 256): Computes the SHA-256 hash.
- SHA-512 (Secure Hash Algorithm 512): Computes the SHA-512 hash.

## Getting Started

To get started, follow these steps:

1. **Clone this Repository:** To clone this repository to your local machine, run the following command:

git clone https://github.com/shivomv/encryption.git


2. **Open the Project:** Open the project in your preferred C# development environment, such as Visual Studio, Visual Studio Code, or any other C# development environment of your choice.

3. **Using the Hash Functions:** You can use the provided C# classes to compute hash values. Each hash function has its own class:

- `MD5Hasher`: For MD5 hashing.
- `SHA1Hasher`: For SHA-1 hashing.
- `SHA256Hasher`: For SHA-256 hashing.
- `SHA512Hasher`: For SHA-512 hashing.

4. **Modify the Code (Optional):** You're welcome to modify the code to suit your specific needs or integrate it into your own projects.

## Example Usage

Here's an example of how to use the MD5 hashing class to compute an MD5 hash of a string in C#:

```csharp
MD5Hasher md5Hasher = new MD5Hasher();
string input = "Hello, World!";
string md5Hash = md5Hasher.ComputeMD5Hash(input);
Console.WriteLine("MD5 Hash: " + md5Hash);

Repeat a similar process for other hash functions, replacing MD5Hasher with the appropriate class name.

#Author
This code was created by Shivom Verma. Feel free to reach out if you have any questions or suggestions.
