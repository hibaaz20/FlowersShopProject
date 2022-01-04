using HackerU_MidProject2.Tables;
using Project8.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project8.DataAccess.CommandDesignPattern
{
    public class AdminCommand
    {
        private static _DbContext _db = new _DbContext();


        public void AUpdate(string username, string password)
        {
            using (var dbContext = new _DbContext())
            {
                AdminLoginData admin = dbContext.Admins.FirstOrDefault(a => a.AdminName == username);

                admin.AdminPassword = password;
                dbContext.Update(admin);
                dbContext.SaveChanges();
            }
        }

    }
    class AUpdateCommand : ICommand
    {
        private AdminCommand _commands;
        public string _username;
        public string pw;

        public AUpdateCommand(AdminCommand cmd, string username, string password)
        {
            _commands = cmd;
            _username = username;
            pw = password;
        }

        public void Execute()
        {
            _commands.AUpdate(_username, pw);
        }

    }
    public class AUpdateCMD
    {
        private ICommand updateCommand;
        public AUpdateCMD(ICommand update)
        {
            this.updateCommand = update;

        }
        public void update()
        {
            updateCommand.Execute();
        }
    }


}
