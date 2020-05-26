using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Task11.Migrations
{
    public partial class AddedSeedToConfiqurations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "janjanych@gmail.com", "Jan", "Janych" },
                    { 2, "killboy@gmail.com", "Al", "Caholic" }
                });

            migrationBuilder.InsertData(
                table: "Medicaments",
                columns: new[] { "Id", "Description", "Name", "Type" },
                values: new object[,]
                {
                    { 1, "For hippies and other shit", "Weed", "Stronks" },
                    { 2, "For mentally desparate situations", "MoodPill", "Music" }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "BirthDate", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(1999, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sans", "TheSkeleton" },
                    { 2, new DateTime(2012, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Frisk", "TheHuman" }
                });

            migrationBuilder.InsertData(
                table: "Prescriptions",
                columns: new[] { "Id", "Date", "DueDate", "IdDoctor", "IdPatient" },
                values: new object[] { 1, new DateTime(2020, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2 });

            migrationBuilder.InsertData(
                table: "Prescription_Medicaments",
                columns: new[] { "IdMedicament", "IdPrescription", "Details", "Dose" },
                values: new object[] { 2, 1, "Mood Pill of type C(piano/violin)", 5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
