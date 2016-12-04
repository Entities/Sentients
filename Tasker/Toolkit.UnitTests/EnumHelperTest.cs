using BusinessObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Toolkit.UnitTests
{
    [TestClass]
    public class EnumHelperTest
    {
        [TestMethod]
        public void TEST_GetDescriptionFromEnumName()
        {
            string enumName = "Enum3";
            string resultDescription = EnumHelper.GetDescriptionFromEnumName<Enumerations.TestEnum>(enumName);
            Assert.IsNotNull(resultDescription, "Enum was not found!");
        }
    }
}
