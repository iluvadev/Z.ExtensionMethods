using System.Security.Cryptography;

public static partial class Extensions
{
    /// <summary>
    /// Returns the Hash of the the byte[]
    /// </summary>
    /// <param name="byteArray">The byte array.</param>
    /// <param name="algorithm">The Hash algorithm</param>
    /// <returns></returns>
    public static byte[] Hash(this byte[] byteArray, HashAlgorithm algorithm)
        => algorithm.ComputeHash(byteArray);

    /// <summary>
    /// Returns the MD5 Hash of the the byte[]
    /// </summary>
    /// <param name="byteArray">The byte array.</param>
    /// <returns></returns>
    public static byte[] MD5Hash(this byte[] byteArray)
        => byteArray.Hash(MD5.Create());

    /// <summary>
    /// Gets the sha256 hash.
    /// </summary>
    /// <param name="byteArray">The byte array.</param>
    /// <returns></returns>
    public static byte[] Sha256Hash(this byte[] byteArray)
        => byteArray.Hash(SHA256.Create());
}