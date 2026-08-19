using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class AddUniqueMaxExposure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Exposure",
                table: "Exposure");

            migrationBuilder.RenameTable(
                name: "Exposure",
                newName: "Exposures");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Exposures",
                table: "Exposures",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "MaxExposures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SkinType = table.Column<int>(type: "int", nullable: false),
                    Minutes = table.Column<int>(type: "int", nullable: false),
                    UvIndex = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaxExposures", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MaxExposures_SkinType_UvIndex",
                table: "MaxExposures",
                columns: new[] { "SkinType", "UvIndex" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MaxExposures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Exposures",
                table: "Exposures");

            migrationBuilder.RenameTable(
                name: "Exposures",
                newName: "Exposure");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Exposure",
                table: "Exposure",
                column: "Id");
        }
    }
}
