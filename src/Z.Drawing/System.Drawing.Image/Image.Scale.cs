// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System;

#if !NETSTANDARD
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
#endif

public static partial class Extensions
{
#if !NETSTANDARD
    /// <summary>
    ///     An Image extension method that scales an image to the specific ratio.
    /// </summary>
    /// <param name="image">The @this to act on.</param>
    /// <param name="ratio">The ratio.</param>
    /// <returns>The scaled image to the specific ratio.</returns>
    public static Image Scale(this Image image, double ratio)
    {
        int width = Convert.ToInt32(image.Width*ratio);
        int height = Convert.ToInt32(image.Height*ratio);

        return Resize(image, width, height);
    }

    /// <summary>
    /// Scales the image to the specified MaxWidth and Height.
    /// </summary>
    /// <param name="image">The image.</param>
    /// <param name="maxWidth">The maximum width.</param>
    /// <param name="maxHeight">The maximum height.</param>
    /// <returns></returns>
    public static Image Scale(this Image image, int maxWidth, int maxHeight)
    {
        var ratioX = (double)maxWidth / image.Width;
        var ratioY = (double)maxHeight / image.Height;
        var ratio = Math.Min(ratioX, ratioY);

        var newWidth = (int)(image.Width * ratio);
        var newHeight = (int)(image.Height * ratio);

        return Resize(image, newWidth, newHeight);
    }
#endif
}