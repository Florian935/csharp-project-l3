using Bll;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Serveur.Entities;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestOffres_GetAll_ReturnListOffres()
        {
            Manager manager = Manager.Instance;
            List<Offre> offres = manager.GetAll();
            Assert.IsNotNull(offres);
        }
    }
}
