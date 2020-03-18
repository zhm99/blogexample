using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogP.Migrations
{
    public partial class InitialDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Post",
                columns: table => new
                {
                    PostId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: false),
                    Slug = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: false),
                    Body = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post", x => x.PostId);
                });

            migrationBuilder.CreateTable(
                name: "Tag",
                columns: table => new
                {
                    TagId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tag", x => x.TagId);
                });

            migrationBuilder.CreateTable(
                name: "PostTag",
                columns: table => new
                {
                    PostId = table.Column<int>(nullable: false),
                    TagId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostTag", x => new { x.PostId, x.TagId });
                    table.ForeignKey(
                        name: "FK_PostTag_Post_PostId",
                        column: x => x.PostId,
                        principalTable: "Post",
                        principalColumn: "PostId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PostTag_Tag_TagId",
                        column: x => x.TagId,
                        principalTable: "Tag",
                        principalColumn: "TagId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Post",
                columns: new[] { "PostId", "Body", "CreatedAt", "Description", "Slug", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Body test", new DateTime(2020, 3, 15, 19, 32, 13, 235, DateTimeKind.Utc), "Description test", "title-test", "Title test", new DateTime(2020, 3, 15, 19, 32, 13, 235, DateTimeKind.Utc) },
                    { 2, "Body test2", new DateTime(2020, 3, 15, 19, 32, 13, 235, DateTimeKind.Utc), "Description test2", "title-test2", "Title test2", new DateTime(2020, 3, 15, 19, 32, 13, 235, DateTimeKind.Utc) },
                    { 3, "Body test3", new DateTime(2020, 3, 15, 19, 32, 13, 235, DateTimeKind.Utc), "Description test3", "title-test3", "Title test3", new DateTime(2020, 3, 15, 19, 32, 13, 235, DateTimeKind.Utc) },
                    { 4, "Body test4", new DateTime(2020, 3, 15, 19, 32, 13, 235, DateTimeKind.Utc), "Description test4", "title-test4", "Title test4", new DateTime(2020, 3, 15, 19, 32, 13, 235, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "Tag",
                column: "TagId",
                values: new object[]
                {
                    "tag1",
                    "tag2",
                    "tag3",
                    "tag4"
                });

            migrationBuilder.InsertData(
                table: "PostTag",
                columns: new[] { "PostId", "TagId" },
                values: new object[,]
                {
                    { 1, "tag1" },
                    { 2, "tag2" },
                    { 3, "tag3" },
                    { 2, "tag3" },
                    { 4, "tag4" },
                    { 1, "tag4" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PostTag_TagId",
                table: "PostTag",
                column: "TagId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PostTag");

            migrationBuilder.DropTable(
                name: "Post");

            migrationBuilder.DropTable(
                name: "Tag");
        }
    }
}
