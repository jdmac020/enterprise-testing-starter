using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;

namespace Application.Tests.Dice
{
    [TestClass]
    public class RollCheckShould
    {
        [TestMethod]
        public void ReturnTrue()
        {
            false.ShouldBeTrue();
        }
    }
}
