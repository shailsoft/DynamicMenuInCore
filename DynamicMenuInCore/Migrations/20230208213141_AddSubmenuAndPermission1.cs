using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DynamicMenuInCore.Migrations
{
    public partial class AddSubmenuAndPermission1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MenuRolePermission",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MenuId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuRolePermission", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubMenuItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SControllerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SActionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MenuId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubMenuItem", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MenuRolePermission");

            migrationBuilder.DropTable(
                name: "SubMenuItem");
        }
    }
}
