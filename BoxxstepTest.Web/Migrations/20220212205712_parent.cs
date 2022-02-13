using Microsoft.EntityFrameworkCore.Migrations;

namespace BoxxstepTest.Web.Migrations
{
    public partial class parent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Relation_Contact_ContactId",
                table: "Relation");

            migrationBuilder.AddColumn<long>(
                name: "Parent",
                table: "Contact",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Parent",
                table: "Contact");

            migrationBuilder.AddForeignKey(
                name: "FK_Relation_Contact_ContactId",
                table: "Relation",
                column: "ContactId",
                principalTable: "Contact",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
