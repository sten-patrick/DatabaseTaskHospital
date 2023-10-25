using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseTask.Data.Migrations
{
    public partial class _5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "HospitalId",
                table: "Patients",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "HospitalId",
                table: "Doctor",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "HospitalId",
                table: "Departments",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Hospital",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hospital", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Patients_HospitalId",
                table: "Patients",
                column: "HospitalId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_HospitalId",
                table: "Doctor",
                column: "HospitalId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_HospitalId",
                table: "Departments",
                column: "HospitalId");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Hospital_HospitalId",
                table: "Departments",
                column: "HospitalId",
                principalTable: "Hospital",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctor_Hospital_HospitalId",
                table: "Doctor",
                column: "HospitalId",
                principalTable: "Hospital",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Hospital_HospitalId",
                table: "Patients",
                column: "HospitalId",
                principalTable: "Hospital",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Hospital_HospitalId",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctor_Hospital_HospitalId",
                table: "Doctor");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Hospital_HospitalId",
                table: "Patients");

            migrationBuilder.DropTable(
                name: "Hospital");

            migrationBuilder.DropIndex(
                name: "IX_Patients_HospitalId",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Doctor_HospitalId",
                table: "Doctor");

            migrationBuilder.DropIndex(
                name: "IX_Departments_HospitalId",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "HospitalId",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "HospitalId",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "HospitalId",
                table: "Departments");
        }
    }
}
