using GenAdxCDE.Source.Model.Services;
using Moq;
using NUnit.Framework;

namespace GenAdxCDE.Test.Source.Model.Services.factory
{
    [TestFixture]
    public class FactoryTests
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
        public void CreateNewFactory()
        {


            Factory factory = this.CreateFactory();


        }

        private Factory CreateFactory()
        {
            return Factory.GetInstance();
        }
    }
}