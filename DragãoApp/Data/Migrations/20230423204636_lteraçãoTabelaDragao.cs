using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DragãoApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class lteraçãoTabelaDragao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "cor",
                table: "Dragoes",
                newName: "corAura");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Dragoes",
                newName: "estado");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "estado",
                table: "Dragoes",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "corAura",
                table: "Dragoes",
                newName: "cor");
        }
    }
}
