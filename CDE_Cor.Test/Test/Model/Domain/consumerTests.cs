using System;
// using Microsoft.VisualStudio.TestTools.UnitTesting;
using GenAdxCDE.Source.Model.Domain;	
using NUnit.Framework;

namespace GenAdxCDE.Test.Test.Model.Domain
{
    [TestFixture]

        /// <summary>
        /// @author Jason Canney
        /// @tests consumer domain object 
        /// </summary>
        public class consumerTests
        {
        /// <summary>
        /// Test method for consumer.cs"/>.
        /// </summary>
        /// 

        // Create c1 and c2 consumer objects for use by all TestCases
        consumer c1;
        consumer c2;
        consumer c3;
        consumer cbad;

            [OneTimeSetUp]
            public void TestSetup()
            {
            // populate both of the objects with data to be used by the TestCases
            c1 = new consumer(12345,"John", "U", "Doe","j.doe@hotmail.com","303-555-1212","20 Bridge Street","Lynn","MA","01905","j.doe@hotmail.com");
            c2 = new consumer(12345, "John", "U", "Doe","j.doe@hotmail.com","303-555-1212","20 Bridge Street","Lynn","MA","01905","j.doe@hotmail.com");
            c3 = new consumer(123456, "Paul", "U", "Jone","p.jones@hotmail.com","303-555-1212","20 Bridge Street","Lynn","MA","01905","j.doe@hotmail.com");
            cbad = new consumer();
        }

            [TestCase]
            public virtual void testConsumerCreate()
            {
     
                // c1.validate should assert to True since all variables 
                // being passed to create a new Consumer are all valid.
                Assert.IsTrue(c1.validate(), "c1 validates");
                Console.WriteLine("testConsumerCreate PASSED");
            }


            [TestCase]
            /// <summary>
            /// Tests with an invalid consumer passed in
            /// </summary>
            public virtual void testNotValidConsumerCreate()
            {
                // cbad.validate should not pass here since we are not
                // sending in valid parameters - in the case of consumer
                // class, its valid only if all class variables are passed
                Assert.IsFalse(cbad.validate(), "cbad does not validate");
                Console.WriteLine("testNotValidConsumerCreate PASSED");
            }
            [TestCase]
            /// <summary>
            /// Test method for consumer.cs)"/>.
            /// </summary>
            public virtual void testEqualsConsumer()
            {
                // this should assert to true since the contents of 
                // c1 and c2 class variables are identical.
                Assert.IsTrue(c1.Equals(c2), "c1 equals c2");
                Console.WriteLine("testEqualsConsumer PASSED");
            }

            [TestCase]
            /// <summary>
            /// Test if two consumers are not equal
            /// </summary>
            public virtual void testNotEqualsConsumer()
            {
               
                // this should assert to false since the contents of 
                // c1 and e2 class variables are NOT identical.
                Assert.IsFalse(c1.Equals(c3), "c1 does NOT equal c3");
                Console.WriteLine("testNotEqualsConsumer PASSED");
            }

        }

    }
