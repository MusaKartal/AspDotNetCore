using Microsoft.EntityFrameworkCore.Migrations;

namespace Ne_Yapalim.Data.Migrations
{
    public partial class Final_mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_events_event_categories_event_category_id",
                table: "events");

            migrationBuilder.AlterColumn<int>(
                name: "event_category_id",
                table: "events",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "image",
                table: "event_image",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_events_event_categories_event_category_id",
                table: "events",
                column: "event_category_id",
                principalTable: "event_categories",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_events_event_categories_event_category_id",
                table: "events");

            migrationBuilder.AlterColumn<int>(
                name: "event_category_id",
                table: "events",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "image",
                table: "event_image",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AddForeignKey(
                name: "FK_events_event_categories_event_category_id",
                table: "events",
                column: "event_category_id",
                principalTable: "event_categories",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
