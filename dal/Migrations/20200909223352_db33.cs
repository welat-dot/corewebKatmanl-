using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace dal.Migrations
{
    public partial class db33 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GetMenus");

            migrationBuilder.CreateTable(
                name: "AdressDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ParentId = table.Column<int>(nullable: false),
                    Adress = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdressDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "customersDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CustomerName = table.Column<string>(maxLength: 100, nullable: true),
                    CustomerSurname = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customersDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MyProperty",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CustumersAdress = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyProperty", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomerBankInformations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BankName = table.Column<int>(nullable: false),
                    IBAN = table.Column<string>(maxLength: 26, nullable: true),
                    adressId = table.Column<int>(nullable: true),
                    CustumersAdressDetailsRefId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerBankInformations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerBankInformations_MyProperty_adressId",
                        column: x => x.adressId,
                        principalTable: "MyProperty",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(maxLength: 8, nullable: false),
                    UserPassword = table.Column<string>(maxLength: 8, nullable: false),
                    UserEmail = table.Column<string>(maxLength: 50, nullable: true),
                    UsetDetailId = table.Column<int>(nullable: false),
                    CustomerDetailsRefId = table.Column<int>(nullable: false),
                    customersDetailsId = table.Column<int>(nullable: true),
                    CustumersAdressDetailsRefId = table.Column<int>(nullable: false),
                    custumersAdressDetailsId = table.Column<int>(nullable: true),
                    CustomerBankInformationRefId = table.Column<int>(nullable: false),
                    customerBankInformationId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_CustomerBankInformations_customerBankInformationId",
                        column: x => x.customerBankInformationId,
                        principalTable: "CustomerBankInformations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_customersDetails_customersDetailsId",
                        column: x => x.customersDetailsId,
                        principalTable: "customersDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_MyProperty_custumersAdressDetailsId",
                        column: x => x.custumersAdressDetailsId,
                        principalTable: "MyProperty",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerBankInformations_adressId",
                table: "CustomerBankInformations",
                column: "adressId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_customerBankInformationId",
                table: "Users",
                column: "customerBankInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_customersDetailsId",
                table: "Users",
                column: "customersDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_custumersAdressDetailsId",
                table: "Users",
                column: "custumersAdressDetailsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdressDetails");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "CustomerBankInformations");

            migrationBuilder.DropTable(
                name: "customersDetails");

            migrationBuilder.DropTable(
                name: "MyProperty");

            migrationBuilder.CreateTable(
                name: "GetMenus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    menuAd = table.Column<string>(type: "varchar(40) CHARACTER SET utf8mb4", maxLength: 40, nullable: false),
                    ustId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GetMenus", x => x.Id);
                });
        }
    }
}
