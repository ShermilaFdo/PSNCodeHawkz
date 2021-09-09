using Microsoft.EntityFrameworkCore.Migrations;

namespace SimpleCodingChallenge.DataAccess.Migrations
{
    public partial class AddCountry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.Sql(@"ALTER TABLE Employees
                    ADD CONSTRAINT IX_EmployeesCountryDef
                    DEFAULT ('N/A') FOR Country WITH VALUES;");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Country",
                table: "Employees");
        }
    }
}
