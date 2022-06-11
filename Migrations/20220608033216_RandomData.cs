using System;

using Microsoft.EntityFrameworkCore.Migrations;

namespace doctors.Migrations
{
	public partial class RandomData : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.InsertData(
				table: "Doctors",
				columns: new[] { "IdDoctor", "Email", "FirstName", "LastName" },
				values: new object[,]
				{
					{ 1, "doctor@strange.com", "Stephen", "Strange" },
					{ 2, "lizard@doc.com", "Curtis", "Connors" },
					{ 3, "doc@ock.com", "Otto", "Octavius" },
					{ 4, "hulk@smash.com", "Bruce", "Banner" },
					{ 5, "doctor@doom.com", "Victor", "von Doom" }
				});

			migrationBuilder.InsertData(
				table: "Medicaments",
				columns: new[] { "IdMedicament", "Description", "Name", "Type" },
				values: new object[,]
				{
					{ 1, "Sleep deprivation", "Hydroxyzine", "Antihistamine" },
					{ 2, "Multi-purpose", "Mephedrone", "Stimulant" },
					{ 3, "Depression", "Prozac", "Antidepressant" },
					{ 4, "ADHD", "Vyvanse", "Stimulant" },
					{ 5, "Depression", "Xanax", "Antidepressant" }
				});

			migrationBuilder.InsertData(
				table: "Patients",
				columns: new[] { "IdPatient", "Birthdate", "FirstName", "LastName" },
				values: new object[,]
				{
					{ 1, new DateTime(191, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alan", "Turing" },
					{ 2, new DateTime(1950, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bjarne", "Stroustrup" },
					{ 3, new DateTime(1815, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ada", "Lovelace" },
					{ 4, new DateTime(1914, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dennis", "Ritchie" },
					{ 5, new DateTime(1943, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ken", "Thompson" }
				});

			migrationBuilder.InsertData(
				table: "Prescriptions",
				columns: new[] { "IdPrescription", "Date", "DueDate", "IdDoctor", "IdPatient" },
				values: new object[,]
				{
					{ 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
					{ 6, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
					{ 2, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2 },
					{ 7, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2 },
					{ 3, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 3 },
					{ 8, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 3 },
					{ 4, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 4 },
					{ 9, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 4 },
					{ 5, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 5 },
					{ 10, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 5 }
				});

			migrationBuilder.InsertData(
				table: "PrescriptionMedicaments",
				columns: new[] { "IdMedicament", "IdPrescription", "Details", "Dose" },
				values: new object[,]
				{
					{ 5, 1, "1-1-1", 10 },
					{ 2, 1, "1-0-0", 1 },
					{ 1, 2, "0-0-1", 1 },
					{ 3, 2, "1-1-1", 10 },
					{ 4, 3, "0-0-1", 1 },
					{ 2, 3, "0-1-1", 2 },
					{ 3, 4, "1-0-0", 1 },
					{ 5, 4, "0-1-1", 2 },
					{ 4, 5, "1-0-0", 1 },
					{ 1, 5, "1-0-0", 1 }
				});
		}

		protected override void Down(MigrationBuilder migrationBuilder)
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
				keyValues: new object[] { 2, 3 });

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
				keyValues: new object[] { 4, 3 });

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

			migrationBuilder.DeleteData(
				table: "Medicaments",
				keyColumn: "IdMedicament",
				keyValue: 1);

			migrationBuilder.DeleteData(
				table: "Medicaments",
				keyColumn: "IdMedicament",
				keyValue: 2);

			migrationBuilder.DeleteData(
				table: "Medicaments",
				keyColumn: "IdMedicament",
				keyValue: 3);

			migrationBuilder.DeleteData(
				table: "Medicaments",
				keyColumn: "IdMedicament",
				keyValue: 4);

			migrationBuilder.DeleteData(
				table: "Medicaments",
				keyColumn: "IdMedicament",
				keyValue: 5);

			migrationBuilder.DeleteData(
				table: "Prescriptions",
				keyColumn: "IdPrescription",
				keyValue: 1);

			migrationBuilder.DeleteData(
				table: "Prescriptions",
				keyColumn: "IdPrescription",
				keyValue: 2);

			migrationBuilder.DeleteData(
				table: "Prescriptions",
				keyColumn: "IdPrescription",
				keyValue: 3);

			migrationBuilder.DeleteData(
				table: "Prescriptions",
				keyColumn: "IdPrescription",
				keyValue: 4);

			migrationBuilder.DeleteData(
				table: "Prescriptions",
				keyColumn: "IdPrescription",
				keyValue: 5);

			migrationBuilder.DeleteData(
				table: "Doctors",
				keyColumn: "IdDoctor",
				keyValue: 1);

			migrationBuilder.DeleteData(
				table: "Doctors",
				keyColumn: "IdDoctor",
				keyValue: 2);

			migrationBuilder.DeleteData(
				table: "Doctors",
				keyColumn: "IdDoctor",
				keyValue: 3);

			migrationBuilder.DeleteData(
				table: "Doctors",
				keyColumn: "IdDoctor",
				keyValue: 4);

			migrationBuilder.DeleteData(
				table: "Doctors",
				keyColumn: "IdDoctor",
				keyValue: 5);

			migrationBuilder.DeleteData(
				table: "Patients",
				keyColumn: "IdPatient",
				keyValue: 1);

			migrationBuilder.DeleteData(
				table: "Patients",
				keyColumn: "IdPatient",
				keyValue: 2);

			migrationBuilder.DeleteData(
				table: "Patients",
				keyColumn: "IdPatient",
				keyValue: 3);

			migrationBuilder.DeleteData(
				table: "Patients",
				keyColumn: "IdPatient",
				keyValue: 4);

			migrationBuilder.DeleteData(
				table: "Patients",
				keyColumn: "IdPatient",
				keyValue: 5);
		}
	}
}
