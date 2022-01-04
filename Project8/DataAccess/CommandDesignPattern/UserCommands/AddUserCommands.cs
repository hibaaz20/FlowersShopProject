using HackerU_MidProject2.Tables;
using Project8.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project8.DataAccess.CommandDesignPattern.UserCommands
{
    public class AddUserCommands
    {

        private static _DbContext _db = new _DbContext();


        public void Add(string firstname, string lastname, string username, string userpassword)
        {
            using (var dbContext = new _DbContext())
            {
                var User = new UserLoginData
                {
                    FirstName = firstname,
                    LastName = lastname,
                    UserName = username,
                    UserPassword = userpassword
                };

                dbContext.Add(User);
                dbContext.SaveChanges();
            }
        }

    }
    public class AddCommand : ICommand
    {
        private AddUserCommands _commands;
        public string fname;
        public string lname;
        public string username;
        public string pw;

        public AddCommand(AddUserCommands commands, string fn, string ln, string un, string _pw)
        {
            _commands = commands;
            fname = fn;
            lname = ln;
            username = un;
            pw = _pw;
        }

        public void Execute()
        {
            _commands.Add(fname, lname, username, pw);
        }
    }

    public class AddUserCMD
    {
        private ICommand addCommand;

        public AddUserCMD(ICommand add)
        {
            this.addCommand = add;
        }
        public void add()
        {
            addCommand.Execute();
        }
    }
}
