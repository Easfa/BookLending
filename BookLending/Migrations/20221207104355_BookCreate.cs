using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookLending.Migrations
{
    public partial class BookCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    B_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookAuthor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PageNumbers = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.B_ID);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    P_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.P_ID);
                });

            migrationBuilder.CreateTable(
                name: "Transaction",
                columns: table => new
                {
                    T_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    P_ID = table.Column<int>(type: "int", nullable: false),
                    B_ID = table.Column<int>(type: "int", nullable: false),
                    BarrowingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LendingDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transaction", x => x.T_ID);
                    table.ForeignKey(
                        name: "FK_Transaction_Books_B_ID",
                        column: x => x.B_ID,
                        principalTable: "Books",
                        principalColumn: "B_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transaction_Person_P_ID",
                        column: x => x.P_ID,
                        principalTable: "Person",
                        principalColumn: "P_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_B_ID",
                table: "Transaction",
                column: "B_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_P_ID",
                table: "Transaction",
                column: "P_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transaction");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Person");
        }
    }
}
