using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreMvcProject.Migrations
{
    public partial class deneme1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "Personals");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "Personals",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
