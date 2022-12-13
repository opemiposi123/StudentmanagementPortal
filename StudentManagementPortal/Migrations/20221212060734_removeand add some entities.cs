 using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentManagementPortal.Migrations
{
    public partial class removeandaddsomeentities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourses_Courses_CourseId",
                table: "StudentCourses");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "StudentCourses",
                newName: "SubjectsId");

            migrationBuilder.RenameIndex(
                name: "IX_StudentCourses_CourseId",
                table: "StudentCourses",
                newName: "IX_StudentCourses_SubjectsId");

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubjectName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourses_Subjects_SubjectsId",
                table: "StudentCourses",
                column: "SubjectsId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourses_Subjects_SubjectsId",
                table: "StudentCourses");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.RenameColumn(
                name: "SubjectsId",
                table: "StudentCourses",
                newName: "CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_StudentCourses_SubjectsId",
                table: "StudentCourses",
                newName: "IX_StudentCourses_CourseId");

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Biology = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Chemistry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CivicEvication = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    English = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Geograhy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mathematics = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Physics = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SocialScience = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Yoruba = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourses_Courses_CourseId",
                table: "StudentCourses",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
