using HackerU_MidProject2.Tables;
using Project8.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project8.DataAccess.CommandDesignPattern.OrdersCommands
{
    public class UpdateOrderCommands
    {
        private static _DbContext _db = new _DbContext();

        public void UserUpdateOrder(int OrderID, string itemName, string itemColor, int itemquantity)
        {
            using (var dbContext = new _DbContext())
            {
                OrdersDetails order = dbContext.Orders.FirstOrDefault(a => a.OrderId == OrderID);

                order.ItemName = itemName;
                order.ItemColor = itemColor;
                order.Quantity = itemquantity;
                dbContext.Update(order);
                dbContext.SaveChanges();
            }
        }
    }


    class UpdateOrderCommand : ICommand
    {
        private UpdateOrderCommands _commands;
        public int orderid;
        public string itemname;
        public string itemcolor;
        public int quantity;

        public UpdateOrderCommand(UpdateOrderCommands cmd, int OrderID, string itemName, string itemColor, int itemquantity)
        {
            _commands = cmd;
            itemname = itemName;
            itemcolor = itemColor;
            orderid = OrderID;
            quantity = itemquantity;
        }

        public void Execute()
        {
            _commands.UserUpdateOrder(orderid, itemname, itemcolor, quantity);
        }
    }

    public class UpdateOrdersCMD
    {
        private ICommand updateCommand;


        public UpdateOrdersCMD(ICommand update)
        {
            this.updateCommand = update;

        }
        public void update()
        {
            updateCommand.Execute();
        }
    }
}
