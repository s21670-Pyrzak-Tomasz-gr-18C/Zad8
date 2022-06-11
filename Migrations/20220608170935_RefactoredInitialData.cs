using System;

using Microsoft.EntityFrameworkCore.Migrations;

namespace doctors.Migrations
{
	public partial class RefactoredInitialData : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DeleteData(
				table: "PrescriptionMedicaments",
				keyColumns: new[] { "IdMedicament", "IdPrescription" },
				keyValues: new object[] { 1, 2 });

			migrationBuilder.DeleteData(
				table: "PrescriptionMedicaments",
				keyColumns: new[] { "IdMedicament", "IdPrescription" },
				keyValues: new object[] { 1, 5 });

			migrationBuilder.DeleteData(
				table: "PrescriptionMedicaments",
				keyColumns: new[] { "IdMedicament", "IdPrescription" },
				keyValues: new object[] { 2, 1 });

			migrationBuilder.DeleteData(
				table: "PrescriptionMedicaments",
				keyColumns: new[] { "IdMedicament", "IdPrescription" },
				keyValues: new object[] { 3, 2 });

			migrationBuilder.DeleteData(
				table: "PrescriptionMedicaments",
				keyColumns: new[] { "IdMedicament", "IdPrescription" },
				keyValues: new object[] { 3, 4 });

			migrationBuilder.DeleteData(
				table: "PrescriptionMedicaments",
				keyColumns: new[] { "IdMedicament", "IdPrescription" },
				keyValues: new object[] { 4, 5 });

			migrationBuilder.DeleteData(
				table: "PrescriptionMedicaments",
				keyColumns: new[] { "IdMedicament", "IdPrescription" },
				keyValues: new object[] { 5, 1 });

			migrationBuilder.DeleteData(
				table: "PrescriptionMedicaments",
				keyColumns: new[] { "IdMedicament", "IdPrescription" },
				keyValues: new object[] { 5, 4 });

			migrationBuilder.DeleteData(
				table: "Prescriptions",
				keyColumn: "IdPrescription",
				keyValue: 6);

			migrationBuilder.DeleteData(
				table: "Prescriptions",
				keyColumn: "IdPrescription",
				keyValue: 7);

			migrationBuilder.DeleteData(
				table: "Prescriptions",
				keyColumn: "IdPrescription",
				keyValue: 8);

			migrationBuilder.DeleteData(
				table: "Prescriptions",
				keyColumn: "IdPrescription",
				keyValue: 9);

			migrationBuilder.DeleteData(
				table: "Prescriptions",
				keyColumn: "IdPrescription",
				keyValue: 10);

			migrationBuilder.UpdateData(
				table: "PrescriptionMedicaments",
				keyColumns: new[] { "IdMedicament", "IdPrescription" },
				keyValues: new object[] { 2, 3 },
				columns: new[] { "Details", "Dose" },
				values: new object[] { "1-0-0", 3 });

			migrationBuilder.UpdateData(
				table: "PrescriptionMedicaments",
				keyColumns: new[] { "IdMedicament", "IdPrescription" },
				keyValues: new object[] { 4, 3 },
				columns: new[] { "Details", "Dose" },
				values: new object[] { "1-0-0", 2 });

			migrationBuilder.InsertData(
				table: "PrescriptionMedicaments",
				columns: new[] { "IdMedicament", "IdPrescription", "Details", "Dose" },
				values: new object[,]
				{
					{ 1, 1, "0-0-1", 1 },
					{ 3, 1, "0-0-1", 2 },
					{ 5, 2, "1-1-1", 3 },
					{ 2, 2, "1-1-1", 1 },
					{ 4, 4, "1-0-0", 1 },
					{ 1, 4, "1-0-0", 2 },
					{ 3, 5, "0-1-1", 3 },
					{ 5, 5, "0-1-1", 1 }
				});
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DeleteData(
				table: "PrescriptionMedicaments",
				keyColumns: new[] { "IdMedicament", "IdPrescription" },
				keyValues: new object[] { 1, 1 });

			migrationBuilder.DeleteData(
				table: "PrescriptionMedicaments",
				keyColumns: new[] { "IdMedicament", "IdPrescription" },
				keyValues: new object[] { 1, 4 });

			migrationBuilder.DeleteData(
				table: "PrescriptionMedicaments",
				keyColumns: new[] { "IdMedicament", "IdPrescription" },
				keyValues: new object[] { 2, 2 });

			migrationBuilder.DeleteData(
				table: "PrescriptionMedicaments",
				keyColumns: new[] { "IdMedicament", "IdPrescription" },
				keyValues: new object[] { 3, 1 });

			migrationBuilder.DeleteData(
				table: "PrescriptionMedicaments",
				keyColumns: new[] { "IdMedicament", "IdPrescription" },
				keyValues: new object[] { 3, 5 });

			migrationBuilder.DeleteData(
				table: "PrescriptionMedicaments",
				keyColumns: new[] { "IdMedicament", "IdPrescription" },
				keyValues: new object[] { 4, 4 });

			migrationBuilder.DeleteData(
				table: "PrescriptionMedicaments",
				keyColumns: new[] { "IdMedicament", "IdPrescription" },
				keyValues: new object[] { 5, 2 });

			migrationBuilder.DeleteData(
				table: "PrescriptionMedicaments",
				keyColumns: new[] { "IdMedicament", "IdPrescription" },
				keyValues: new object[] { 5, 5 });

			migrationBuilder.UpdateData(
				table: "PrescriptionMedicaments",
				keyColumns: new[] { "IdMedicament", "IdPrescription" },
				keyValues: new object[] { 2, 3 },
				columns: new[] { "Details", "Dose" },
				values: new object[] { "0-1-1", 2 });

			migrationBuilder.UpdateData(
				table: "PrescriptionMedicaments",
				keyColumns: new[] { "IdMedicament", "IdPrescription" },
				keyValues: new object[] { 4, 3 },
				columns: new[] { "Details", "Dose" },
				values: new object[] { "0-0-1", 1 });

			migrationBuilder.InsertData(
				table: "PrescriptionMedicaments",
				columns: new[] { "IdMedicament", "IdPrescription", "Details", "Dose" },
				values: new object[,]
				{
					{ 1, 2, "0-0-1", 1 },
					{ 5, 1, "1-1-1", 10 },
					{ 3, 2, "1-1-1", 10 },
					{ 4, 5, "1-0-0", 1 },
					{ 2, 1, "1-0-0", 1 },
					{ 3, 4, "1-0-0", 1 },
					{ 1, 5, "1-0-0", 1 },
					{ 5, 4, "0-1-1", 2 }
				});

			migrationBuilder.InsertData(
				table: "Prescriptions",
				columns: new[] { "IdPrescription", "Date", "DueDate", "IdDoctor", "IdPatient" },
				values: new object[,]
				{
					{ 6, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
					{ 7, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2 },
					{ 8, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 3 },
					{ 9, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 4 },
					{ 10, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 5 }
				});
		}
	}
}
