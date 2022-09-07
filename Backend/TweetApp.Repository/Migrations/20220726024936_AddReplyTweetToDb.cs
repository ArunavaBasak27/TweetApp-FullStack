using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TweetApp.Repository.Migrations
{
    public partial class AddReplyTweetToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ReplyTweets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    TweetId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReplyTweets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReplyTweets_Tweets_TweetId",
                        column: x => x.TweetId,
                        principalTable: "Tweets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReplyTweets_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "LoginId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReplyTweets_TweetId",
                table: "ReplyTweets",
                column: "TweetId");

            migrationBuilder.CreateIndex(
                name: "IX_ReplyTweets_UserId",
                table: "ReplyTweets",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReplyTweets");
        }
    }
}
