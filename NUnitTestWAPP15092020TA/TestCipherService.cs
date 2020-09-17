using Microsoft.AspNetCore.DataProtection;
using NUnit.Framework;
using WAPP15092020TA.Common;

namespace NUnitTestWAPP15092020TA
{
    public class TestCipherService
    {

        IDataProtectionProvider dataProtectionProvider = DataProtectionProvider.Create("WAPP15092020TA");

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestEncryptionDecryptionService()
        {
            string dataToTest = "Hello World!";
            string encData = new CipherService(dataProtectionProvider).Encrypt(dataToTest);
            string decData = new CipherService(dataProtectionProvider).Decrypt(encData);
            Assert.AreEqual(decData, dataToTest);              
        }       
    }
}
