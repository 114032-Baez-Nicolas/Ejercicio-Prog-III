using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Librery_Baez_Nicolas.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DbSetAutores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbSetAutores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DbSetGeneros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbSetGeneros", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DbSetLibros",
                columns: table => new
                {
                    ISBN = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaPublicacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    lAutorId = table.Column<int>(type: "int", nullable: false),
                    lGeneroId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbSetLibros", x => x.ISBN);
                });

            migrationBuilder.InsertData(
                table: "DbSetAutores",
                columns: new[] { "Id", "FechaNacimiento", "Nombre" },
                values: new object[,]
                {
                    { 1, new DateTime(1809, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Charles Darwin" },
                    { 2, new DateTime(1947, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stephen King" },
                    { 3, new DateTime(1939, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Margaret Atwood" },
                    { 4, new DateTime(1965, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "J. K. Rowling" }
                });

            migrationBuilder.InsertData(
                table: "DbSetGeneros",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 1, "Fantasía" },
                    { 2, "Romántica" },
                    { 3, "Terror" },
                    { 4, "Aventuras" }
                });

            migrationBuilder.InsertData(
                table: "DbSetLibros",
                columns: new[] { "ISBN", "FechaPublicacion", "Titulo", "lAutorId", "lGeneroId" },
                values: new object[,]
                {
                    { 1, new DateTime(2000, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harry Potter y el cáliz de fuego", 4, 1 },
                    { 2, new DateTime(1986, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "It", 2, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DbSetAutores");

            migrationBuilder.DropTable(
                name: "DbSetGeneros");

            migrationBuilder.DropTable(
                name: "DbSetLibros");
        }
    }
}
