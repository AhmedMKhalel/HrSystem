using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class JobTitle_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JobTitle_QualityGroup_GeneralJobGradesGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QualityGroup_GeneralJobGradesGroupsId = table.Column<int>(type: "int", nullable: false),
                    DateOfCreation = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobTitle_QualityGroup_GeneralJobGradesGroups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobTitle_QualityGroup_GeneralJobGradesGroups_QualityGroup_GeneralJobGradesGroups_QualityGroup_GeneralJobGradesGroupsId",
                        column: x => x.QualityGroup_GeneralJobGradesGroupsId,
                        principalTable: "QualityGroup_GeneralJobGradesGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_JobTitle_QualityGroup_GeneralJobGradesGroups_QualityGroup_GeneralJobGradesGroupsId",
                table: "JobTitle_QualityGroup_GeneralJobGradesGroups",
                column: "QualityGroup_GeneralJobGradesGroupsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JobTitle_QualityGroup_GeneralJobGradesGroups");
        }
    }
}
