using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Store.Migrations
{
    /// <inheritdoc />
    public partial class estoremigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    prod_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    product_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    prod_type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    prod_ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    prod_size = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    prod_color = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.prod_id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    usr_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    usr_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    usr_email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    usr_password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gender = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.usr_id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
