using Microsoft.EntityFrameworkCore.Migrations;

namespace BoxxstepTest.Web.Migrations
{
    public partial class datatype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Relation_Contact_ContactId",
                table: "Relation");

            migrationBuilder.AddColumn<string>(
                name: "Relations",
                table: "Contact",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Relations",
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
