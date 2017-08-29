using System;
// using Microsoft.VisualStudio.TestTools.UnitTesting;
using GenAdxCDE.Source.Model.Domain;
using NUnit.Framework;

namespace GenAdxCDE.Test.Test.Model.Domain
{
    [TestFixture]

    /// <summary>
    /// @author Jason Canney
    /// @tests preference domain object 
    /// </summary>
    public class preferenceTests
    {
        /// <summary>
        /// Test method for preference.cs"/>.
        /// </summary>
        /// 

        // Create preference objects for use by all TestCases
        preference p1;
        preference p2;
        preference p3;
        preference pbad;

        [OneTimeSetUp]
        public void TestSetup()
        {
            // populate both of the objects with data to be used by the TestCases
            p1 = new preference(12345, 70000000, 20001349, 30008542, "Ford", "F-150 Pickup Truck Ad", "01/20/1952", 12345);
            p2 = new preference(12345, 70000000, 20001349, 30008542, "Ford", "F-150 Pickup Truck Ad", "01/20/1952", 12345);
            p3 = new preference(8675309, 70000000, 20001349, 30008542, "Ford", "F-150 Pickup Truck Ad", "01/20/1952", 12345);
            pbad = new preference();
        }

        [TestCase]
        public virtual void testPreferenceCreate()
        {

            // p1.validate should assert to True since all variables 
            // being passed to create a new preference are all valid.
            Assert.IsTrue(p1.validate(), "p1 validates");
            Console.WriteLine("testPreferenceCreate PASSED");
        }


        [TestCase]
        /// <summary>
        /// Tests with an invalid preference passed in
        /// </summary>
        public virtual void testNotValidPreferenceCreate()
        {
            // pbad.validate should not pass here since we are not
            // sending in valid parameters - in the case of preference
            // class, its valid only if all class variables are passed
            Assert.IsFalse(pbad.validate(), "pbad does not validate");
            Console.WriteLine("testNotValidPreferenceCreate PASSED");
        }
        [TestCase]
        /// <summary>
        /// Test method for preference.cs)"/>.
        /// </summary>
        public virtual void testEqualsPreference()
        {
            // this should assert to true since the contents of 
            // p1 and p2 class variables are identical.
            Assert.IsTrue(p1.Equals(p2), "p1 equals p2");
            Console.WriteLine("testEqualsPreference PASSED");
        }

        [TestCase]
        /// <summary>
        /// Test if two preferences are not equal
        /// </summary>
        public virtual void testNotEqualsPreference()
        {

            // this should assert to false since the contents of 
            // p1 and p3 class variables are NOT identical.
            Assert.IsFalse(p1.Equals(p3), "p1 does NOT equal p3");
            Console.WriteLine("testNotEqualsPreference PASSED");
        }

    }

}
