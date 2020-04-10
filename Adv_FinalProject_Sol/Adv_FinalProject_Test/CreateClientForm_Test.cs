using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Adv_FinalProject;

namespace Adv_FinalProject_Test
{
    [TestClass()]
    public class CreateClientFormTests
    {
        [TestMethod()]
        public void CreateClientFormTest()
        {
            CreateClientForm form = new CreateClientForm();
            Assert.IsNotNull(form);
        }
    }
}
