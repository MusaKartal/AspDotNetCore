using Microsoft.EntityFrameworkCore.Migrations;

namespace Ne_Yapalim.Data.Migrations
{
    public partial class Custom_App_user : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_events_users_user_id",
                table: "events");

            migrationBuilder.AlterColumn<string>(
                name: "user_id",
                table: "events",
                maxLength: 450,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_events_AspNetUsers_user_id",
                table: "events",
                column: "user_id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_events_AspNetUsers_user_id",
                table: "events");

            migrationBuilder.AlterColumn<int>(
                name: "user_id",
                table: "events",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 450,
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_events_users_user_id",
                table: "events",
                column: "user_id",
                principalTable: "users",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
