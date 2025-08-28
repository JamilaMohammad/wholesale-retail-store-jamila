using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wholesale_retail_store.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddIsRetailColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsRetailer",
                table: "Customers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsRetailer",
                table: "Customers");
        }
    }
}
