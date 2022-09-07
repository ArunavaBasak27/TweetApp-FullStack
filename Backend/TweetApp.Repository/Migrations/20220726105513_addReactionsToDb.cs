using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TweetApp.Repository.Migrations
{
    public partial class addReactionsToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Reaction",
                table: "ReplyTweets");

            migrationBuilder.CreateTable(
                name: "Reactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TweetId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Reactions = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reactions_Tweets_TweetId",
                        column: x => x.TweetId,
                        principalTable: "Tweets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reactions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "LoginId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reactions_TweetId",
                table: "Reactions",
                column: "TweetId");

            migrationBuilder.CreateIndex(
                name: "IX_Reactions_UserId",
                table: "Reactions",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reactions");

            migrationBuilder.AddColumn<int>(
                name: "Reaction",
                table: "ReplyTweets",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
