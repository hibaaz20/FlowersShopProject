using Project8.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project8.DataAccess.CommandDesignPattern
{
    public class DeleteOrdersCommands
    {
        private static _DbContext _db = new _DbContext();

        public void Deleteorder(int orderid)
        {

            using (var dbContext = new _DbContext())
            {
                var deleteOrder = dbContext.Orders.FirstOrDefault(x => x.OrderId == orderid);
                dbContext.Remove(deleteOrder);

                dbContext.SaveChanges();
            }

        }
    }

    class DeleteeOrderCommand : ICommand
    {
        private DeleteOrdersCommands _commands;
        public int Orderid;

        public DeleteeOrderCommand(DeleteOrdersCommands cmd, int orderi)
        {
            _commands = cmd;
            Orderid = orderi;
        }

        public void Execute()
        {
            _commands.Deleteorder(Orderid);
        }
    }


    public class DeleteOrdersCMD
    {
        private ICommand deleteCommand;
        public DeleteOrdersCMD(ICommand delete)
        {
            this.deleteCommand = delete;
        }

      
        public void delete()
        {
            deleteCommand.Execute();
        }
    }

}
