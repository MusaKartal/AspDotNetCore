using Microsoft.EntityFrameworkCore.Migrations;

namespace Ne_Yapalim.Data.Migrations
{
    public partial class Custom_App_Create7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_cities_CitiesId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_CitiesId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CitiesId",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "City_Id",
                table: "AspNetUsers",
                newName: "city_id");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_city_id",
                table: "AspNetUsers",
                column: "city_id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_cities_city_id",
                table: "AspNetUsers",
                column: "city_id",
                principalTable: "cities",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_cities_city_id",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_city_id",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "city_id",
                table: "AspNetUsers",
                newName: "City_Id");

            migrationBuilder.AddColumn<int>(
                name: "CitiesId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CitiesId",
                table: "AspNetUsers",
                column: "CitiesId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_cities_CitiesId",
                table: "AspNetUsers",
                column: "CitiesId",
                principalTable: "cities",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
