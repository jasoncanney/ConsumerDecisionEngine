using GenAdxCDE.Source.Model.Services;
using GenAdxCDE.Source.Model.Services.preferenceservice;
using Moq;
using NUnit.Framework;

namespace GenAdxCDE.Test.Source.Model.Services.preferenceservice
{
    [TestFixture]
    public class PreferenceSvcBinaryImplTests
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
        public void testCreatenewPreferenceSvcBinaryImpl()
        {


            PreferenceSvcBinaryImpl preferenceSvcBinaryImpl = this.CreatePreferenceSvcBinaryImpl();


        }

        private PreferenceSvcBinaryImpl CreatePreferenceSvcBinaryImpl()
        {
            return new PreferenceSvcBinaryImpl();
        }
    }
}