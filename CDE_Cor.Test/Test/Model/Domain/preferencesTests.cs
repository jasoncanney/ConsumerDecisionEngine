using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GenAdxCDE.Source.Model.Domain;
using System.Threading.Tasks;

namespace GenAdxCDE.Test.Test.Model.Domain
{
    [TestFixture]
    public class accountTests
    {

        // initialize the new collection
        public List<preference> preferences = new List<preference>();

        // Create consumer and account objects and a preferences collection for use by all TestCase
        preference p1, p2, p3;
        preferences ps1;

        [OneTimeSetUp]

        public void TestSetup()
        {
            // populate both of the objects with data to be used by the TestCases
            p1 = new preference(123456, 700001, 123452, 1231231, "Ford", "F150", "01/28/2017", 12345);
            p2 = new preference(123457, 734001, 124552, 1234531, "Chevy", "Colorado", "01/28/2017", 12345);
            p3 = new preference();
            ps1 = new preferences();
        }

        [TestCase]
        ///<summary>
        ///Test adds two preference.cs domain objects to a preferences.cs collection and tests for null</summary>
        public void testPreferencesCollectionValid()
        {
            ps1.Preferences.Add(p1.PreferenceId, p1);
            ps1.Preferences.Add(p2.PreferenceId, p2);
            if (ps1 != null) Assert.Pass();

        }
    }
}


