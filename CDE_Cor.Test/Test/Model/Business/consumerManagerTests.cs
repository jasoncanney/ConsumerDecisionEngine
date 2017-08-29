using GenAdxCDE.Source.Model.Business;
using Moq;
using NUnit.Framework;

namespace GenAdxCDE.Test.Source.Model.Business.manager
{
    [TestFixture]
    public class consumerManagerTests
    {
        private MockRepository mockRepository;



        [SetUp]
        public void TestInitialize()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);


        }

        [TearDown]
        public void TestCleanup()
        {
            this.mockRepository.VerifyAll();
        }

        [Test]
        public void TestMethod1()
        {


            consumerManager manager = this.CreateManager();


        }

        private consumerManager CreateManager()
        {
            return new consumerManager();
        }
    }
}