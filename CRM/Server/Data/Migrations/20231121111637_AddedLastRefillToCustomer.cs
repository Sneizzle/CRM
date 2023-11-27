using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRM.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedLastRefillToCustomer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "LastRefill",
                table: "Customers",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastRefill",
                table: "Customers");
        }
    }
}
