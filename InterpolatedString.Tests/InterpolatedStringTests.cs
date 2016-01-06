using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace InterpolatedString.Tests
{
    [TestClass]
    public class InterpolatedStringTests
    {
        [TestMethod]
        public void StringFormatTest()
        {
            var mpg = 22;
            var fuelTankCapacityInGallons = 18;
            var pricePerGallonUSD = 2.00;
            string stringFormatted = 
                string.Format("If your car has {0} mpg and fuel capacity of {1} gallons you can travel {2} " +
                              "miles which would cost {3}", 
                              mpg,
                              fuelTankCapacityInGallons,
                              fuelTankCapacityInGallons * mpg, 
                              fuelTankCapacityInGallons * pricePerGallonUSD);
        }

        [TestMethod]
        public void StringFormatWithFormattingTest()
        {
            var mpg = 22;
            var fuelTankCapacityInGallons = 18;
            var pricePerGallonUSD = 2.00;
            string stringFormatted =
                string.Format("If your car has {0} mpg and fuel capacity of {1} gallons you can travel {2} " +
                              "miles which would cost {3:C2}",
                              mpg,
                              fuelTankCapacityInGallons,
                              fuelTankCapacityInGallons * mpg,
                              fuelTankCapacityInGallons * pricePerGallonUSD);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void StringFormatThrowsExceptionTest()
        {
            var mpg = 22;
            var fuelTankCapacityInGallons = 18;
            var pricePerGallonUSD = 2.00;
            string stringFormatted =
                string.Format("If your car has {0} mpg and fuel capacity of {1} gallons you can travel {2} " +
                              "miles which would cost {4:C2}",
                              mpg,
                              fuelTankCapacityInGallons,
                              fuelTankCapacityInGallons * mpg,
                              fuelTankCapacityInGallons * pricePerGallonUSD);
        }

        [TestMethod]
        public void InterpolatedStringTest()
        {
            var mpg = 22;
            var fuelTankCapacityInGallons = 18;
            var pricePerGallonUSD = 2.00;
            string stringFormatted = $"If your car has {mpg} mpg and fuel capacity of {fuelTankCapacityInGallons} " +
                                     $"gallons you can travel {fuelTankCapacityInGallons * mpg} " +
                                     $"miles which would cost {fuelTankCapacityInGallons * pricePerGallonUSD}";
        }

        [TestMethod]
        public void InterpolatedStringWithFormattingTest()
        {
            var mpg = 22;
            var fuelTankCapacityInGallons = 18;
            var pricePerGallonUSD = 2.00;
            string stringFormatted = $"If your car has {mpg} mpg and fuel capacity of {fuelTankCapacityInGallons} " +
                                     $"gallons you can travel {fuelTankCapacityInGallons * mpg} " +
                                     $"miles which would cost {fuelTankCapacityInGallons * pricePerGallonUSD:C2}";
        }
    }
}
