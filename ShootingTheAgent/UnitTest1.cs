using AgentInTheMatrix;

using System.Dynamic;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
namespace ShootingTheAgent
{
    [TestClass]
    public class ShootAgent
    {
        private Matricies Matricies => new Matricies();
        [TestMethod]
        public void IsAgentEquipped()
        {
            IEnumerable<MethodInfo> info = typeof(Matricies).GetRuntimeMethods();
            Assert.IsTrue(info.Select(x => x.Name == "ShootingOffset" && x.IsPrivate && x.ReturnType == typeof(void)).First());
        }
    }
}