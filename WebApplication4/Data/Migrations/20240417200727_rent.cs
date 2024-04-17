using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rent_a_Car.Data.Migrations
{
    /// <inheritdoc />
    public partial class rent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rent_Cars_CarId1",
                table: "Rent");

            migrationBuilder.DropForeignKey(
                name: "FK_Rent_User_UserId1",
                table: "Rent");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropIndex(
                name: "IX_Rent_CarId1",
                table: "Rent");

            migrationBuilder.DropIndex(
                name: "IX_Rent_UserId1",
                table: "Rent");

            migrationBuilder.DropColumn(
                name: "CarId1",
                table: "Rent");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Rent");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Rent");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CarId1",
                table: "Rent",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Rent",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "UserId1",
                table: "Rent",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EGN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rent_CarId1",
                table: "Rent",
                column: "CarId1");

            migrationBuilder.CreateIndex(
                name: "IX_Rent_UserId1",
                table: "Rent",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Rent_Cars_CarId1",
                table: "Rent",
                column: "CarId1",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rent_User_UserId1",
                table: "Rent",
                column: "UserId1",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
