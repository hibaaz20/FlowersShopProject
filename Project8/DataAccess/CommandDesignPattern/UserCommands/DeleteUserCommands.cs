using Project8.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project8.DataAccess.CommandDesignPattern.UserCommands
{
    public class DeleteUserCommands
    {

        public void Delete(string username, string userpassword)
        {
            using (var dbContext = new _DbContext())
            {
                var deleteuser = dbContext.Users.FirstOrDefault(x => x.UserName == username);
                dbContext.Remove(deleteuser);

                dbContext.Orders.RemoveRange(dbContext.Orders.Where(x => x.UserName == username));


                dbContext.SaveChanges();
            }
        }
    }

    class DeleteCommand : ICommand
    {
        private DeleteUserCommands _commands;
        public string _username;
        public string pw;

        public DeleteCommand(DeleteUserCommands cmd, string username, string password)
        {
            _commands = cmd;
            _username = username;
            pw = password;
        }
        public void Execute()
        {
            _commands.Delete(_username, pw);
        }

    }

    public class DeleteCMD
    {
        private ICommand updateCommand;
        public DeleteCMD(ICommand update)
        {
            this.updateCommand = update;

        }
        public void delete()
        {
            updateCommand.Execute();
        }
    }

}

