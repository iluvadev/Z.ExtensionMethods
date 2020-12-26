// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System;

public static partial class Extensions
{
    
    /// <summary>
    /// Retorna l'edat en anys entre la data actual i la final
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="finalDate">The final date.</param>
    /// <returns></returns>
    public static int Age(this DateTime @this, DateTime? finalDate)
    {
        // Save today's date.
        var today = finalDate ?? DateTime.Today;
        // Calculate the age.
        var age = today.Year - @this.Year;
        // Go back to the year the person was born in case of a leap year
        if (@this > today.AddYears(-age)) age--;

        return age;
    }
}