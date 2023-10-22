using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelProjectDataAccessLayer.Migrations
{
    public partial class updateSendMessage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReceiverName",
                table: "SendMessages");

            migrationBuilder.DropColumn(
                name: "SenderName",
                table: "SendMessages");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "SendMessages");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ReceiverName",
                table: "SendMessages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SenderName",
                table: "SendMessages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "SendMessages",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
