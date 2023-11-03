using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRM.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class Added_Employees_to_Customer_model_class : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmployeeCount",
                table: "Customers",
                type: "int",
                nullable: true,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmployeeCount",
                table: "Customers");
        }
    }
}
