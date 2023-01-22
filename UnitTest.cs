using NUnit.Framework;
using ProgramskoInzenjerstvo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramskoInzenjerstvo
{
    internal class UnitTest
    {
        [Test]
        public void TestTrain()
        {
            Train small = new Train(TrainSize.Small);
            Train big = new Train(TrainSize.Big);


            Assert.AreEqual(small.Size, TrainSize.Small);
            Console.WriteLine("test 1 successful");

            Assert.AreEqual(small.Size.GetValue(), 6);
            Console.WriteLine("test 2 successful");

            Assert.AreEqual(big.Size, TrainSize.Big);
            Console.WriteLine("test 3 successful");

            Assert.AreEqual(big.Size.GetValue(), 8);
            Console.WriteLine("test 4 successful");

        }
    }
}
