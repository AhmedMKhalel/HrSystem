using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class General_Quality_Tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GeneralJobGradesGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfCreation = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralJobGradesGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QualityGroup_GeneralJobGradesGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GeneralJobGradesGroupsId = table.Column<int>(type: "int", nullable: false),
                    DateOfCreation = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QualityGroup_GeneralJobGradesGroups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QualityGroup_GeneralJobGradesGroups_GeneralJobGradesGroups_GeneralJobGradesGroupsId",
                        column: x => x.GeneralJobGradesGroupsId,
                        principalTable: "GeneralJobGradesGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_QualityGroup_GeneralJobGradesGroups_GeneralJobGradesGroupsId",
                table: "QualityGroup_GeneralJobGradesGroups",
                column: "GeneralJobGradesGroupsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QualityGroup_GeneralJobGradesGroups");

            migrationBuilder.DropTable(
                name: "GeneralJobGradesGroups");
        }
    }
}
