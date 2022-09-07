using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TweetApp.Repository.Migrations
{
    public partial class updateReplyTweet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReplyTweets_Tweets_ReplyId",
                table: "ReplyTweets");

            migrationBuilder.DropIndex(
                name: "IX_ReplyTweets_ReplyId",
                table: "ReplyTweets");

            migrationBuilder.DropColumn(
                name: "ReplyId",
                table: "ReplyTweets");

            migrationBuilder.AddColumn<string>(
                name: "Message",
                table: "ReplyTweets",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Message",
                table: "ReplyTweets");

            migrationBuilder.AddColumn<int>(
                name: "ReplyId",
                table: "ReplyTweets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ReplyTweets_ReplyId",
                table: "ReplyTweets",
                column: "ReplyId");

            migrationBuilder.AddForeignKey(
                name: "FK_ReplyTweets_Tweets_ReplyId",
                table: "ReplyTweets",
                column: "ReplyId",
                principalTable: "Tweets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
