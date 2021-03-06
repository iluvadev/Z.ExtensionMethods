// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright � ZZZ Projects Inc. All rights reserved.
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Collections.Test
{
    [TestClass]
    public class System_Collections_Generic_ICollection_T_AddIf
    {
        [TestMethod]
        public void AddIf()
        {
            // Type
            var @this = new List<string>();

            // Examples
            @this.AddIf(s => true, "Fizz"); // Add "Fizz" value
            @this.AddIf(s => false, "Buzz"); // Doesn't add "Buzz" value

            // Unit Test
            Assert.IsTrue(@this.Contains("Fizz"));
            Assert.IsFalse(@this.Contains("Buzz"));
        }
    }
}