using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Calculator;

namespace Calculator.Test.Unit
{
    [TestFixture]
    public class calculatorunitTest
    {
        [Test]
        public void Add_Add2and4_Returns6()
        {
            var uut = new Lommeregner();
            Assert.That(uut.Add(3.5, 2.5), Is.EqualTo(6));
            
         }

        [Test]
        public void Subract_Subtract10and4_Returns6()
        {
            var uut = new Lommeregner();
            Assert.That(uut.Subtract(10.0, 4.0), Is.EqualTo(6));
        }

    }
}
