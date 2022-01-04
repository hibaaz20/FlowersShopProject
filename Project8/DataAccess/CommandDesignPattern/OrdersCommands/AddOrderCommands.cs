using HackerU_MidProject2.Tables;
using Microsoft.EntityFrameworkCore;
using Project8.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project8.DataAccess.CommandDesignPattern.OrdersCommands
{
    public class AddOrderCommands
    {

        public void AddOrder(string username, int OrderID, string itemName, string itemColor, int Quantity)
        {
            using (var dbContext = new _DbContext())
            {
                var Order = new OrdersDetails
                {
                    UserName = username,
                    OrderId = OrderID,
                    ItemName = itemName,
                    ItemColor = itemColor,
                    Quantity = Quantity,
                    OrderDate = DateTime.Now

                };

                dbContext.Add(Order);


                var conn = dbContext.Database.GetDbConnection();
                conn.Open();
                dbContext.Database.ExecuteSqlCommand("SET IDENTITY_INSERT Orders ON;");

                dbContext.SaveChanges();
                dbContext.Database.ExecuteSqlCommand("SET IDENTITY_INSERT Orders off;");

                conn.Close();
            }

        }

    }



    class AddOrderCommand : ICommand
    {
        private AddOrderCommands _commands;
        public int orderid;
        public string itemname;
        public string itemcolor;
        public int quantity;
        public string userName;
        public AddOrderCommand(AddOrderCommands cmd, string username, int OrderID, string itemName, string itemColor, int Quantity)
        {
            _commands = cmd;
            itemname = itemName;
            itemcolor = itemColor;
            orderid = OrderID;
            quantity = Quantity;
            userName = username;
        }

        public void Execute()
        {
            _commands.AddOrder(userName, orderid, itemname, itemcolor, quantity);
        }
    }

    public class AddOrdersCMD
    {
        private ICommand addCommand;


        public AddOrdersCMD(ICommand add)
        {
            this.addCommand = add;

        }
        public void add()
        {
            addCommand.Execute();
        }
    }
}
