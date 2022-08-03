using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ne_Yapalim.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cities",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cities", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "event_categories",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_event_categories", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "hobbies",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hobbies", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tags",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tags", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    new_id = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "districts",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(maxLength: 255, nullable: true),
                    city_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_districts", x => x.id);
                    table.ForeignKey(
                        name: "FK__districts__city___286302EC",
                        column: x => x.city_id,
                        principalTable: "cities",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "events",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(maxLength: 255, nullable: false),
                    location = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: true),
                    date = table.Column<DateTime>(type: "date", nullable: false),
                    event_category_id = table.Column<int>(nullable: true),
                    user_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_events", x => x.id);
                    table.ForeignKey(
                        name: "FK__events__event_ca__30F848ED",
                        column: x => x.event_category_id,
                        principalTable: "event_categories",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__events__user_id__31EC6D26",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "user_hobby",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    hobby_id = table.Column<int>(nullable: true),
                    user_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_hobby", x => x.id);
                    table.ForeignKey(
                        name: "FK__user_hobb__hobby__48CFD27E",
                        column: x => x.hobby_id,
                        principalTable: "hobbies",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__user_hobb__user___49C3F6B7",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "attendees",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_id = table.Column<int>(nullable: true),
                    event_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_attendees", x => x.id);
                    table.ForeignKey(
                        name: "FK__attendees__event__398D8EEE",
                        column: x => x.event_id,
                        principalTable: "events",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__attendees__user___38996AB5",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "event_image",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    image = table.Column<string>(maxLength: 255, nullable: true),
                    event_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_event_image", x => x.id);
                    table.ForeignKey(
                        name: "FK__event_ima__event__34C8D9D1",
                        column: x => x.event_id,
                        principalTable: "events",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "event_messages",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    massege = table.Column<string>(type: "text", nullable: false),
                    sent_date = table.Column<DateTime>(type: "date", nullable: false),
                    event_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_event_messages", x => x.id);
                    table.ForeignKey(
                        name: "FK__event_mes__event__4CA06362",
                        column: x => x.event_id,
                        principalTable: "events",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "event_scoring",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    point = table.Column<double>(nullable: true),
                    user_id = table.Column<int>(nullable: true),
                    event_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_event_scoring", x => x.id);
                    table.ForeignKey(
                        name: "FK__event_sco__event__5070F446",
                        column: x => x.event_id,
                        principalTable: "events",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__event_sco__user___4F7CD00D",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "event_tags",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    event_id = table.Column<int>(nullable: true),
                    tag_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_event_tags", x => x.id);
                    table.ForeignKey(
                        name: "FK__event_tag__event__3F466844",
                        column: x => x.event_id,
                        principalTable: "events",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__event_tag__tag_i__403A8C7D",
                        column: x => x.tag_id,
                        principalTable: "tags",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_attendees_event_id",
                table: "attendees",
                column: "event_id");

            migrationBuilder.CreateIndex(
                name: "IX_attendees_user_id",
                table: "attendees",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "UQ__cities__72E12F1B55E658F6",
                table: "cities",
                column: "name",
                unique: true,
                filter: "([name] IS NOT NULL)");

            migrationBuilder.CreateIndex(
                name: "IX_districts_city_id",
                table: "districts",
                column: "city_id");

            migrationBuilder.CreateIndex(
                name: "UQ__district__72E12F1B749D999B",
                table: "districts",
                column: "name",
                unique: true,
                filter: "([name] IS NOT NULL)");

            migrationBuilder.CreateIndex(
                name: "UQ__event_ca__72E12F1BA4A51067",
                table: "event_categories",
                column: "name",
                unique: true,
                filter: "([name] IS NOT NULL)");

            migrationBuilder.CreateIndex(
                name: "IX_event_image_event_id",
                table: "event_image",
                column: "event_id");

            migrationBuilder.CreateIndex(
                name: "IX_event_messages_event_id",
                table: "event_messages",
                column: "event_id");

            migrationBuilder.CreateIndex(
                name: "IX_event_scoring_event_id",
                table: "event_scoring",
                column: "event_id");

            migrationBuilder.CreateIndex(
                name: "IX_event_scoring_user_id",
                table: "event_scoring",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_event_tags_event_id",
                table: "event_tags",
                column: "event_id");

            migrationBuilder.CreateIndex(
                name: "IX_event_tags_tag_id",
                table: "event_tags",
                column: "tag_id");

            migrationBuilder.CreateIndex(
                name: "IX_events_event_category_id",
                table: "events",
                column: "event_category_id");

            migrationBuilder.CreateIndex(
                name: "IX_events_user_id",
                table: "events",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "UQ__hobbies__72E12F1B35CAC453",
                table: "hobbies",
                column: "name",
                unique: true,
                filter: "([name] IS NOT NULL)");

            migrationBuilder.CreateIndex(
                name: "UQ__tags__72E12F1BB0872C47",
                table: "tags",
                column: "name",
                unique: true,
                filter: "([name] IS NOT NULL)");

            migrationBuilder.CreateIndex(
                name: "IX_user_hobby_hobby_id",
                table: "user_hobby",
                column: "hobby_id");

            migrationBuilder.CreateIndex(
                name: "IX_user_hobby_user_id",
                table: "user_hobby",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "UQ__users__8215F589BA38EC67",
                table: "users",
                column: "new_id",
                unique: true,
                filter: "([new_id] IS NOT NULL)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "attendees");

            migrationBuilder.DropTable(
                name: "districts");

            migrationBuilder.DropTable(
                name: "event_image");

            migrationBuilder.DropTable(
                name: "event_messages");

            migrationBuilder.DropTable(
                name: "event_scoring");

            migrationBuilder.DropTable(
                name: "event_tags");

            migrationBuilder.DropTable(
                name: "user_hobby");

            migrationBuilder.DropTable(
                name: "cities");

            migrationBuilder.DropTable(
                name: "events");

            migrationBuilder.DropTable(
                name: "tags");

            migrationBuilder.DropTable(
                name: "hobbies");

            migrationBuilder.DropTable(
                name: "event_categories");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
