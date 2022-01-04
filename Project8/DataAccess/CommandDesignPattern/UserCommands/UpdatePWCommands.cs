using HackerU_MidProject2.Tables;
using Project8.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project8.DataAccess.CommandDesignPattern.UserCommands
{
    public class UpdatePWCommands
    {
        public void Update(string username, string password)
        {
            using (var dbContext = new _DbContext())
            {
                UserLoginData user = dbContext.Users.FirstOrDefault(a => a.UserName == username);

                user.UserPassword = password;
                dbContext.Update(user);
                dbContext.SaveChanges();
            }
        }

    }

    class UpdateCommand : ICommand
    {
        private UpdatePWCommands _commands;
        public string _username;
        public string pw;

        public UpdateCommand(UpdatePWCommands cmd, string username, string password)
        {
            _commands = cmd;
            _username = username;
            pw = password;
        }
        public void Execute()
        {
            _commands.Update(_username, pw);
        }

    }

    public class UpdateCMD
    {
        private ICommand updateCommand;
        public UpdateCMD(ICommand update)
        {
            this.updateCommand = update;
                
        }
        public void update()
        {
            updateCommand.Execute();
        }
    }

}