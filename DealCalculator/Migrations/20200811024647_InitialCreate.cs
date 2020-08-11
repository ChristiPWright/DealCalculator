using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DealCalculator.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    PrimaryPhone = table.Column<string>(nullable: true),
                    PrimaryEmail = table.Column<string>(nullable: true),
                    MailingAddress = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactId);
                });

            migrationBuilder.CreateTable(
                name: "MortgageAssumptions",
                columns: table => new
                {
                    MortgageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProFormaId = table.Column<int>(nullable: false),
                    DownPayment = table.Column<int>(nullable: false),
                    InterestRate = table.Column<decimal>(nullable: false),
                    Term = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MortgageAssumptions", x => x.MortgageId);
                });

            migrationBuilder.CreateTable(
                name: "ProFormas",
                columns: table => new
                {
                    ProFormaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropertyId = table.Column<int>(nullable: false),
                    Vacancy = table.Column<decimal>(nullable: false),
                    PropertyManagement = table.Column<decimal>(nullable: false),
                    PropertyTaxes = table.Column<decimal>(nullable: false),
                    PropertyInsurance = table.Column<decimal>(nullable: false),
                    Mortgage = table.Column<decimal>(nullable: false),
                    Garderner = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProFormas", x => x.ProFormaId);
                });

            migrationBuilder.CreateTable(
                name: "Properties",
                columns: table => new
                {
                    PropertyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StreetAddress = table.Column<string>(nullable: true),
                    Unit = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Zip = table.Column<int>(nullable: false),
                    Sqft = table.Column<int>(nullable: false),
                    Bed = table.Column<int>(nullable: false),
                    Bath = table.Column<decimal>(nullable: false),
                    YearBuilt = table.Column<int>(nullable: false),
                    LotSize = table.Column<decimal>(nullable: false),
                    Heating = table.Column<string>(nullable: true),
                    Cooling = table.Column<string>(nullable: true),
                    CurrentOwner = table.Column<int>(nullable: false),
                    Note = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Properties", x => x.PropertyId);
                });

            migrationBuilder.CreateTable(
                name: "RentComps",
                columns: table => new
                {
                    RentCompId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropertyId = table.Column<int>(nullable: false),
                    RentId1 = table.Column<int>(nullable: false),
                    RentId2 = table.Column<int>(nullable: false),
                    RentId3 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RentComps", x => x.RentCompId);
                });

            migrationBuilder.CreateTable(
                name: "RentHistories",
                columns: table => new
                {
                    RentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropertyId = table.Column<int>(nullable: false),
                    Term = table.Column<int>(nullable: false),
                    Rent = table.Column<decimal>(nullable: false),
                    Deposit = table.Column<decimal>(nullable: false),
                    Pet = table.Column<bool>(nullable: false),
                    PetRent = table.Column<decimal>(nullable: false),
                    PropertyManager = table.Column<int>(nullable: false),
                    Concession = table.Column<string>(nullable: true),
                    Dishwasher = table.Column<bool>(nullable: false),
                    WasherDryer = table.Column<bool>(nullable: false),
                    RentedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RentHistories", x => x.RentId);
                });

            migrationBuilder.CreateTable(
                name: "SaleComps",
                columns: table => new
                {
                    SaleCompId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropertyId = table.Column<int>(nullable: false),
                    SaleId1 = table.Column<int>(nullable: false),
                    SaleId2 = table.Column<int>(nullable: false),
                    SaleId3 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleComps", x => x.SaleCompId);
                });

            migrationBuilder.CreateTable(
                name: "SaleHistories",
                columns: table => new
                {
                    SaleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropertyId = table.Column<int>(nullable: false),
                    ListDate = table.Column<DateTime>(nullable: false),
                    ListPrice = table.Column<decimal>(nullable: false),
                    SoldDAte = table.Column<DateTime>(nullable: false),
                    SoldPrice = table.Column<decimal>(nullable: false),
                    BuyerAgent = table.Column<int>(nullable: false),
                    SellerAgent = table.Column<int>(nullable: false),
                    Seller = table.Column<int>(nullable: false),
                    Buyer = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleHistories", x => x.SaleId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "MortgageAssumptions");

            migrationBuilder.DropTable(
                name: "ProFormas");

            migrationBuilder.DropTable(
                name: "Properties");

            migrationBuilder.DropTable(
                name: "RentComps");

            migrationBuilder.DropTable(
                name: "RentHistories");

            migrationBuilder.DropTable(
                name: "SaleComps");

            migrationBuilder.DropTable(
                name: "SaleHistories");
        }
    }
}
