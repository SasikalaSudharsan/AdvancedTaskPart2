﻿using NUnit.Framework;

namespace AdvancedTaskMarsPart2.AssertHelpers
{
    public class ChangePasswordAssertHelper
    {
        public static void assertChangePasswordSuccessMessage(String expected, String actual)
        {
            Assert.That(expected == actual, "Actual message and expected message do not match");
        }
    }
}
