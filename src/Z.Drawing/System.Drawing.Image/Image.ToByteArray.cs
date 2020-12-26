#if !NETSTANDARD
using System.Drawing;
#endif

public static partial class Extensions
{
#if !NETSTANDARD
    /// <summary>
    /// To the byte array.
    /// </summary>
    /// <param name="imageIn">The image in.</param>
    /// <returns></returns>
    public static byte[] ToByteArray(this Image imageIn)
    {
        if (imageIn == null)
            return new byte[0];

        using (MemoryStream ms = new MemoryStream())
        {
            imageIn.Save(ms, ImageFormat.Png);
            return ms.ToArray();
        }
    }
#endif
}