#if !NETSTANDARD
using System.Drawing;
#endif

public static partial class Extensions
{
#if !NETSTANDARD
    /// <summary>
    /// Retorna una nova imatge en escala de grisos
    /// </summary>
    /// <param name="image">The image.</param>
    /// <returns></returns>
    public static Image ToGrayScale(this Image image)
    {
        int rgb;
        Color c;
        var bmp = new Bitmap(image);
        for (int y = 0; y < bmp.Height; y++)
            for (int x = 0; x < bmp.Width; x++)
            {
                c = bmp.GetPixel(x, y);
                rgb = ((c.R + c.G + c.B) / 3);
                bmp.SetPixel(x, y, Color.FromArgb(rgb, rgb, rgb, c.A));
            }
        return bmp;
    }
#endif
}