using GenAdxCDE.Source.Model.Business;
using Moq;
using NUnit.Framework;

namespace GenAdxCDE.Test.Source.Model.Business.manager
{
    [TestFixture]
    public class preferenceManagerTests
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
        public void CreatepreferenceSvcSQLManagerTest()
        {


            preferenceManager manager = this.CreateManager();


        }

        private preferenceManager CreateManager()
        {
            return new preferenceManager();
        }
    }
}