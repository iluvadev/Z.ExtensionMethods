using System.Security.Cryptography;

public static partial class Extensions
{
    /// <summary>
    /// Returns the Hash of the string
    /// </summary>
    /// <param name="str">The byte array.</param>
    /// <param name="algorithm">The Hash algorithm</param>
    /// <returns></returns>
    public static string Hash(this string str, HashAlgorithm algorithm)
        => str.ToByteArrayUTF8().Hash(algorithm).ToStringNumbers();

    /// <summary>
    /// Returns the MD5 Hash of the string
    /// </summary>
    /// <param name="str">The string</param>
    /// <returns></returns>
    public static string MD5Hash(this string str)
        => str.Hash(MD5.Create());

    /// <summary>
    /// Gets the sha256 hash.
    /// </summary>
    /// <param name="str">The string.</param>
    /// <returns></returns>
    public static string Sha256Hash(this string str)
        => str.Hash(SHA256.Create());
}