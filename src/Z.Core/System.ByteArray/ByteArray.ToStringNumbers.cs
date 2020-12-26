using System.Text;

public static partial class Extensions
{
    /// <summary>
    /// Converts the byte[] in a String with all numbers in it
    /// </summary>
    /// <param name="byteArray">The byte array.</param>
    /// <returns></returns>
    public static string ToStringNumbers(this byte[] byteArray)
    {
        StringBuilder sb = new StringBuilder();
        foreach (byte b in byteArray)
            sb.Append(b.ToString("X2"));

        return sb.ToString();
    }
}