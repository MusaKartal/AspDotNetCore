using Microsoft.EntityFrameworkCore.Migrations;

namespace Ne_Yapalim.Data.Migrations
{
    public partial class Custom_App_Create5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_cities_City_Id",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_City_Id",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "City_Id",
                table: "AspNetUsers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "City_Id",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_City_Id",
                table: "AspNetUsers",
                column: "City_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_cities_City_Id",
                table: "AspNetUsers",
                column: "City_Id",
                principalTable: "cities",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
