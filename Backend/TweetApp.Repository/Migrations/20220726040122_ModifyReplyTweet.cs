using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TweetApp.Repository.Migrations
{
    public partial class ModifyReplyTweet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
