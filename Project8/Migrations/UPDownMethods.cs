using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MainLoginWindow3.Migrations
{
    public partial class UPDownMethods : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdminLogInData",
                columns: table => new
                {
                    AdminName = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    AdminPassword = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", nullable: false)
                },

             constraints: table =>
             {
                 table.PrimaryKey("PK_AdminName", x => x.AdminName);
                
             }); 
    

            migrationBuilder.CreateTable(
                name: "UserLoginData",
                columns: table => new
                {
                    UserName = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    UserPassword = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserName", x => x.UserName);
                });





            migrationBuilder.CreateTable(
                name: "OrdersDetails",
                columns: table => new
                {
                    UserName = table.Column<string>(type: "nvarchar(30)", nullable: false),

                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ItemName = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    ItemColor = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable:false)
                },
                  constraints: table =>
                  {
                      table.PrimaryKey("PK_OrderId", x => x.OrderId);
                      
                  });





            migrationBuilder.CreateTable(
                name: "FlowerTypes",
                columns: table => new
                {
                    FlowerType = table.Column<int>(type: "nvarchar(30)", nullable: false),
                    FlowerId = table.Column<int>(type: "int", nullable: false)
                },
                  constraints: table =>
                  {
                      table.PrimaryKey("PK_OrderId", x => x.FlowerId);
                  });




        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FlowerTypes");

            migrationBuilder.DropTable(
                name: "OrdersDetails");

            migrationBuilder.DropTable(
                name: "UserLoginData");

            migrationBuilder.DropTable(
                name: "AdminLogInData");


        }
    }
}
