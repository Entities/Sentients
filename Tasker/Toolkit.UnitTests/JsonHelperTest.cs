using BusinessObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Toolkit.UnitTests
{
    [TestClass]
    public class JsonHelperTest
    {
        [TestMethod]
        public void TEST_GetJsonPropertyNameAttribute()
        {
            string memberName = "AreaPath";
            string resultPropertyName = JsonHelper.GetJsonPropertyNameAttribute<JsonEntities>(memberName);
            Assert.IsNotNull(resultPropertyName, "JSON Entity was not found!");
        }        
    }
}
