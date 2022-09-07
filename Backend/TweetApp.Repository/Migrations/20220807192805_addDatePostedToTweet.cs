using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TweetApp.Repository.Migrations
{
    public partial class addDatePostedToTweet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DatePosted",
                table: "Tweets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DatePosted",
                table: "Tweets");
        }
    }
}
