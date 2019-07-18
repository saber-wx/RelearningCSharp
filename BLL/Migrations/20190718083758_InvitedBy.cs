using Microsoft.EntityFrameworkCore.Migrations;

namespace BLL.Migrations
{
    public partial class InvitedBy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InvitedById",
                table: "_users",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX__users_InvitedById",
                table: "_users",
                column: "InvitedById");

            migrationBuilder.AddForeignKey(
                name: "FK__users__users_InvitedById",
                table: "_users",
                column: "InvitedById",
                principalTable: "_users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__users__users_InvitedById",
                table: "_users");

            migrationBuilder.DropIndex(
                name: "IX__users_InvitedById",
                table: "_users");

            migrationBuilder.DropColumn(
                name: "InvitedById",
                table: "_users");
        }
    }
}
