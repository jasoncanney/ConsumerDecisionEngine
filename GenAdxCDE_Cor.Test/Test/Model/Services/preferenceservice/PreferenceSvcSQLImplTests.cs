using GenAdxCDE.Source.Model.Services.preferenceservice;
using Moq;
using NUnit.Framework;

namespace GenAdxCDE.Test.Model.Services.preferenceservice
{
    [TestFixture]
    public class PreferenceSvcSQLImplTests
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
        public void CreateTestServicepreferenceSQLImpl()
        {


            PreferenceSvcSQLImpl preferenceSvcSQLImpl = this.CreatePreferenceSvcSQLImpl();


        }

        private PreferenceSvcSQLImpl CreatePreferenceSvcSQLImpl()
        {
            return new PreferenceSvcSQLImpl();
        }
    }
}