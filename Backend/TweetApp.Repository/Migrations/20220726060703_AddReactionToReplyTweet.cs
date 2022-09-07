using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TweetApp.Repository.Migrations
{
    public partial class AddReactionToReplyTweet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Reaction",
                table: "ReplyTweets",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Reaction",
                table: "ReplyTweets");
        }
    }
}
