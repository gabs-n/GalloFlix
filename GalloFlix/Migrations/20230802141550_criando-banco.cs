using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GalloFlix.Migrations
{
    public partial class criandobanco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "466edf8f-37cb-4c5d-b0d2-53fb6921d856");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "c1c090e5-f11c-4d79-ab0f-4a4425a20608");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "317cc880-1876-4471-a323-415f1ad5c127", "e125e019-9e54-42d2-b216-5d384d455bf6" });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "317cc880-1876-4471-a323-415f1ad5c127");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "e125e019-9e54-42d2-b216-5d384d455bf6");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2ffe9ecc-aa77-4cc5-be00-8586c9a54c63", "1b8a45f7-dece-4e5d-a77d-eb4aa6456dfa", "Administrador", "ADMINISTRADOR" },
                    { "86ea38aa-6985-41e0-975f-2272a4a6c187", "d8a9a321-acc5-4d7f-9739-0e79955fffff", "Moderador", "MODERADOR" },
                    { "a6bdc5fe-98a4-4f4d-b08c-8dd8b04baa1f", "87f41719-91ff-4edb-a2bd-55f11f7263b7", "Usuário", " USUÁRIO" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "bde8829e-0579-4dad-a028-69be8a72351f", 0, "2757a280-470e-4a4a-bb48-4bb0dd5e1143", new DateTime(2005, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "AppUser", "admin@gmail.com", true, false, null, "Seu Nome Completo", "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEFGCbCXTkaUXjhDPc21Bv7EZ9/TTFK5/5fuIyXS4IoNf2Bpaq5cuafvezw9RwMHZVg==", "14912345678", true, "/img/users/avatar.png", "0883fd1e-7425-4ac5-8910-763f708c8c29", false, "Admin" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2ffe9ecc-aa77-4cc5-be00-8586c9a54c63", "bde8829e-0579-4dad-a028-69be8a72351f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "86ea38aa-6985-41e0-975f-2272a4a6c187");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "a6bdc5fe-98a4-4f4d-b08c-8dd8b04baa1f");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2ffe9ecc-aa77-4cc5-be00-8586c9a54c63", "bde8829e-0579-4dad-a028-69be8a72351f" });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2ffe9ecc-aa77-4cc5-be00-8586c9a54c63");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "bde8829e-0579-4dad-a028-69be8a72351f");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "317cc880-1876-4471-a323-415f1ad5c127", "a2fde88f-03d4-4c2e-91c3-494283b5c44e", "Administrador", "ADMINISTRADOR" },
                    { "466edf8f-37cb-4c5d-b0d2-53fb6921d856", "eaa976a5-c9ed-4161-b44d-9faaa78fcd25", "Moderador", "MODERADOR" },
                    { "c1c090e5-f11c-4d79-ab0f-4a4425a20608", "78276460-b6d3-450d-9199-d24db4de3878", "Usuário", "USUARIO" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e125e019-9e54-42d2-b216-5d384d455bf6", 0, "bd9a8305-0edb-4bd7-8f8f-be6c2968c4d1", new DateTime(2005, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "AppUser", "nicoletigabriela2@gmail.com", true, false, null, "Gabriela Ferreira Nicoleti", "NICOLETIGABRIELA2@GMAIL.COM", "BIBIELA", "AQAAAAEAACcQAAAAEFly8V4NDDwDBBoRVtWQWJ4spXk69bKx/OHvXPHH2jaVaBo1r8uMWgyTK1rW9vBWjg==", "14996664815", true, "/img/users/avatar.png", "36c17f20-d297-47f1-81c9-0f2c20ab48f9", false, "Bibiela" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "317cc880-1876-4471-a323-415f1ad5c127", "e125e019-9e54-42d2-b216-5d384d455bf6" });
        }
    }
}
