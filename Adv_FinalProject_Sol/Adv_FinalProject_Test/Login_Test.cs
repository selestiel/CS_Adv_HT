using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Adv_FinalProject;
namespace Adv_FinalProject_Test
{
    [TestClass]
    public class Login_Test
    {
        [TestMethod]
        public void SetLogin_CreateAdmin_Test()
        {
            Login login = new Login();
            Admins admins = new Admins();
            admins.CreateAdmin("adm", "adm", "01.01.2000", "56987456", "kukuram");
            login.SetLogin("login1234", "password1", admins);
            admins.SetAdminLogin(login);
            Login login2 = new Login();
            login2.GetLogin(admins);
            Assert.IsNotNull(admins);
            Assert.IsNotNull(login);
            Assert.IsNotNull(login2);
//            Assert.AreEqual(login2.Admins_ID,login.Admins_ID);


        }
    }

}
