using GenAdxCDE.Source.Model.Services;
using GenAdxCDE.Source.Model.Services.consumerservice;
using GenAdxCDE.Source.Model.Domain;
using Moq;
using NUnit.Framework;

namespace GenAdxCDE.Test.Source.Model.Services.consumerservice
{
    [TestFixture]
    public class ConsumerSvcSQLImplTests
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
        public void Create_ConsumerSVCSQLImplTest()
        {



            ConsumerSvcSQLImpl consumerSvcSQLImpl = this.CreateConsumerSvcSQLImpl();


         
        }

        private ConsumerSvcSQLImpl CreateConsumerSvcSQLImpl()
        {
            return new ConsumerSvcSQLImpl();
        }
    }
}