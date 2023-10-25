using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseTask.Data.Migrations
{
    public partial class _6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Hospital_HospitalId",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctor_Departments_DepartmentId",
                table: "Doctor");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctor_Hospital_HospitalId",
                table: "Doctor");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Hospital_HospitalId",
                table: "Patients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Hospital",
                table: "Hospital");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Doctor",
                table: "Doctor");

            migrationBuilder.RenameTable(
                name: "Hospital",
                newName: "Hospitals");

            migrationBuilder.RenameTable(
                name: "Doctor",
                newName: "Doctors");

            migrationBuilder.RenameIndex(
                name: "IX_Doctor_HospitalId",
                table: "Doctors",
                newName: "IX_Doctors_HospitalId");

            migrationBuilder.RenameIndex(
                name: "IX_Doctor_DepartmentId",
                table: "Doctors",
                newName: "IX_Doctors_DepartmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Hospitals",
                table: "Hospitals",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Doctors",
                table: "Doctors",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Hospitals_HospitalId",
                table: "Departments",
                column: "HospitalId",
                principalTable: "Hospitals",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Departments_DepartmentId",
                table: "Doctors",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Hospitals_HospitalId",
                table: "Doctors",
                column: "HospitalId",
                principalTable: "Hospitals",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Hospitals_HospitalId",
                table: "Patients",
                column: "HospitalId",
                principalTable: "Hospitals",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Hospitals_HospitalId",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Departments_DepartmentId",
                table: "Doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Hospitals_HospitalId",
                table: "Doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Hospitals_HospitalId",
                table: "Patients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Hospitals",
                table: "Hospitals");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Doctors",
                table: "Doctors");

            migrationBuilder.RenameTable(
                name: "Hospitals",
                newName: "Hospital");

            migrationBuilder.RenameTable(
                name: "Doctors",
                newName: "Doctor");

            migrationBuilder.RenameIndex(
                name: "IX_Doctors_HospitalId",
                table: "Doctor",
                newName: "IX_Doctor_HospitalId");

            migrationBuilder.RenameIndex(
                name: "IX_Doctors_DepartmentId",
                table: "Doctor",
                newName: "IX_Doctor_DepartmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Hospital",
                table: "Hospital",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Doctor",
                table: "Doctor",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Hospital_HospitalId",
                table: "Departments",
                column: "HospitalId",
                principalTable: "Hospital",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctor_Departments_DepartmentId",
                table: "Doctor",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
    }
}
