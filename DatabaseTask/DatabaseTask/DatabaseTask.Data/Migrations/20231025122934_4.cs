using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseTask.Data.Migrations
{
    public partial class _4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Stays_StayId",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Wards_Patients_PatientId",
                table: "Wards");

            migrationBuilder.DropIndex(
                name: "IX_Wards_PatientId",
                table: "Wards");

            migrationBuilder.DropIndex(
                name: "IX_Patients_StayId",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "PatientId",
                table: "Wards");

            migrationBuilder.DropColumn(
                name: "RoomNr",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "StayId",
                table: "Patients");

            migrationBuilder.AddColumn<int>(
                name: "RoomNr",
                table: "Wards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "PatientId",
                table: "Stays",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "WardId",
                table: "Patients",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "DepartmentId",
                table: "Doctor",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Stays_PatientId",
                table: "Stays",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_WardId",
                table: "Patients",
                column: "WardId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_DepartmentId",
                table: "Doctor",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctor_Departments_DepartmentId",
                table: "Doctor",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Wards_WardId",
                table: "Patients",
                column: "WardId",
                principalTable: "Wards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stays_Patients_PatientId",
                table: "Stays",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctor_Departments_DepartmentId",
                table: "Doctor");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Wards_WardId",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Stays_Patients_PatientId",
                table: "Stays");

            migrationBuilder.DropIndex(
                name: "IX_Stays_PatientId",
                table: "Stays");

            migrationBuilder.DropIndex(
                name: "IX_Patients_WardId",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Doctor_DepartmentId",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "RoomNr",
                table: "Wards");

            migrationBuilder.DropColumn(
                name: "PatientId",
                table: "Stays");

            migrationBuilder.DropColumn(
                name: "WardId",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Doctor");

            migrationBuilder.AddColumn<Guid>(
                name: "PatientId",
                table: "Wards",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "RoomNr",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "StayId",
                table: "Patients",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Wards_PatientId",
                table: "Wards",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_StayId",
                table: "Patients",
                column: "StayId");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Stays_StayId",
                table: "Patients",
                column: "StayId",
                principalTable: "Stays",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Wards_Patients_PatientId",
                table: "Wards",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
