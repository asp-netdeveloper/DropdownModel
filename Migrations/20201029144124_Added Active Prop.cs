using Microsoft.EntityFrameworkCore.Migrations;

namespace Dropdownworking.Migrations
{
    public partial class AddedActiveProp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Product",
                nullable: false,
                defaultValue: 1
                );
        }
    }
}
