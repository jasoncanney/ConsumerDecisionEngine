using GenAdxCDE.Source.Model.Services;
using Moq;
using NUnit.Framework;

namespace GenAdxCDE.Test.Source.Model.Services.consumerservice
{
    [TestFixture]
    public class ConsumerSvcBinaryImplTests2
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
        public void testCreatenewConsumerSvcBinaryImpl()
        {


            ConsumerSvcSQLImpl consumerSvcBinaryImpl = this.CreateConsumerSvcBinaryImpl();


        }

        private ConsumerSvcSQLImpl CreateConsumerSvcBinaryImpl()
        {
            return new ConsumerSvcSQLImpl();
        }
    }
}