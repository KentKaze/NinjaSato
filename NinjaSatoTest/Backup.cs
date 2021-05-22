using Microsoft.VisualStudio.TestTools.UnitTesting;
using Aritiafel.Characters.Heroes;

namespace NinjaSatoTest
{
    [TestClass]
    public class Backup
    {
        [TestMethod]
        public void BackupProject()
        {
            Tina.SaveProject(ProjectChoice.NinjaSato);
        }
    }
}
