using HackerU_MidProject1;
using HackerU_MidProject2.Tables;
using Microsoft.EntityFrameworkCore;
using Project8;
using Project8.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackerU_MidProject2.Database
{
    public static class CRUD
    {
        private static _DbContext _db = new _DbContext();


        public static class UsersClass
        {
            // Add users to db
            public static void Add(string firstname, string lastname, string username, string userpassword)
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



            //update password for users 
            public static void Update(string username, string password)
            {
                using (var dbContext = new _DbContext())
                {
                    UserLoginData user = dbContext.Users.FirstOrDefault(a => a.UserName == username);

                    user.UserPassword = password;
                    dbContext.Update(user);
                    dbContext.SaveChanges();
                }
            }



            // User Delete Method
            public static void Delete(string username, string userpassword)
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




        public static class AdminsClass
        {
            //update password for Admins 
            public static void AUpdate(string username, string password)
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




        public static class OrdersClass
        {
            //Update Order
            public static void UpdateOrder(int OrderID, string itemName, string itemColor, int itemquantity)
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



            // Adding order to the database
            public static void AddOrder(string username, int OrderID, string itemName, string itemColor, int Quantity)
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



            // Filter orders by date
            public static void FilterOrdersByUserName(string FilterDate, string username, DataGridView dataGridv)
            {
                string txtcmd = $"SELECT OrderId,OrderDate  FROM Orders WHERE OrderDate > '{FilterDate}' and UserName = '{username}' ";
                using (SqlConnection conn = new SqlConnection(SqlConn.stringConn))
                {
                    var dataAdapter = new SqlDataAdapter(txtcmd, conn);

                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(txtcmd, conn))
                    {
                        var commandBuilder = new SqlCommandBuilder(dataAdapter);
                        var ds = new DataSet();
                        dataAdapter.Fill(ds);
                        dataGridv.DataSource = ds.Tables[0];

                        conn.Close();
                    }
                }
            }


            public static void FilterOrders(string FilterDate, DataGridView dataGridv)
            {
                string txtcmd = $"SELECT OrderId,OrderDate  FROM Orders WHERE OrderDate > '{FilterDate}'";

                using (SqlConnection conn = new SqlConnection(SqlConn.stringConn))
                {
                    var dataAdapter = new SqlDataAdapter(txtcmd, conn);

                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(txtcmd, conn))
                    {
                        var commandBuilder = new SqlCommandBuilder(dataAdapter);
                        var ds = new DataSet();
                        dataAdapter.Fill(ds);
                        dataGridv.DataSource = ds.Tables[0];

                        conn.Close();
                    }
                }
            }

            // Order Delete Method
            public static void Deleteorder(int orderid)
            {

                using (var dbContext = new _DbContext())
                {
                    var deleteOrder = dbContext.Orders.FirstOrDefault(x => x.OrderId == orderid);
                    dbContext.Remove(deleteOrder);

                    dbContext.SaveChanges();
                }

            }


            // show orders
            public static void ShowOrders(string username, DataGridView dataGridv)
            {
                string txtcmd = $"SELECT OrderId,OrderDate  FROM Orders WHERE UserName = '{username}'";

                using (SqlConnection conn = new SqlConnection(SqlConn.stringConn))
                {
                    var dataAdapter = new SqlDataAdapter(txtcmd, conn);

                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(txtcmd, conn))
                    {
                        var commandBuilder = new SqlCommandBuilder(dataAdapter);
                        var ds = new DataSet();
                        dataAdapter.Fill(ds);
                        dataGridv.DataSource = ds.Tables[0];

                        conn.Close();
                    }
                }

            }

            public static void AdminShowOrders(DataGridView dataGridv)
            {
                string txtcmd = $"SELECT * FROM Orders ";

                using (SqlConnection conn = new SqlConnection(SqlConn.stringConn))
                {
                    var dataAdapter = new SqlDataAdapter(txtcmd, conn);

                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(txtcmd, conn))
                    {
                        var commandBuilder = new SqlCommandBuilder(dataAdapter);
                        var ds = new DataSet();
                        dataAdapter.Fill(ds);
                        dataGridv.DataSource = ds.Tables[0];

                        conn.Close();
                    }
                }

            }
        }
    }
}






