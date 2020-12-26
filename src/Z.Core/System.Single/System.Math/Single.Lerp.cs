using System;

public static partial class Extensions
{
    /// <summary>
    ///     Returns the interpolated single-precision floating-point number result between the two single-precision floating-point numbers.
    /// </summary>
    /// <param name="val1">The first of two single-precision floating-point numbers to compare.</param>
    /// <param name="val2">The second of two single-precision floating-point numbers to compare.</param>
    /// <param name="amount">The amount between both single-precision floating-point</param>
    /// <returns></returns>
    public static Single Lerp(this Single val1, Single val2, Single amount)
    {
        Single difference = val2 - val1;
        Single adjusted = difference * amount;
        return val1 + adjusted;
    }
}
