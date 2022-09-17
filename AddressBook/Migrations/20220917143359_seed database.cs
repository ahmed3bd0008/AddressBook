using Microsoft.EntityFrameworkCore.Migrations;

namespace AddressBook.Migrations
{
    public partial class seeddatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "DepartmentName" },
                values: new object[,]
                {
                    { 1, "School" },
                    { 2, "dev" },
                    { 3, "Hos" }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "JobId", "JobName" },
                values: new object[,]
                {
                    { 1, "Teacher" },
                    { 2, "Software Enginering" },
                    { 3, "Docor" }
                });

            migrationBuilder.InsertData(
                table: "AddressBooks",
                columns: new[] { "Id", "Address", "DateOfBirth", "DepartmentId", "Email", "FullName", "JobId", "MobileNumber", "Photo" },
                values: new object[] { 1, null, null, 1, "Ahmed@gmail.com", "Ahmed", 1, "01159510495", "" });

            migrationBuilder.InsertData(
                table: "AddressBooks",
                columns: new[] { "Id", "Address", "DateOfBirth", "DepartmentId", "Email", "FullName", "JobId", "MobileNumber", "Photo" },
                values: new object[] { 2, null, null, 2, "Mohamed@gmail.com", "Mohamed", 2, "01159510495", "" });

            migrationBuilder.InsertData(
                table: "AddressBooks",
                columns: new[] { "Id", "Address", "DateOfBirth", "DepartmentId", "Email", "FullName", "JobId", "MobileNumber", "Photo" },
                values: new object[] { 3, null, null, 3, "Ali@gmail.com", "Ali", 3, "01159510495", "" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AddressBooks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AddressBooks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AddressBooks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "JobId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "JobId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "JobId",
                keyValue: 3);
        }
    }
}
