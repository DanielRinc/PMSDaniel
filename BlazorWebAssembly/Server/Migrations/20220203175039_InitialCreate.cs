using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorWebAssembly.Server.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reservas",
                columns: table => new
                {
                    Num_reserva = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Fec_entrada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fec_salida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VIP = table.Column<bool>(type: "bit", nullable: false),
                    Tip_pension = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Num_adultos = table.Column<int>(type: "int", nullable: false),
                    Num_menores = table.Column<int>(type: "int", nullable: false),
                    Habitacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bill = table.Column<float>(type: "real", nullable: false),
                    TermsAccepted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservas", x => x.Num_reserva);
                });

            migrationBuilder.InsertData(
                table: "Reservas",
                columns: new[] { "Num_reserva", "Bill", "Fec_entrada", "Fec_salida", "Habitacion", "Num_adultos", "Num_menores", "TermsAccepted", "Tip_pension", "VIP" },
                values: new object[] { "XHJ4321", 100.25f, new DateTime(2022, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "103B", 2, 0, true, "Desayno y Cena", false });

            migrationBuilder.InsertData(
                table: "Reservas",
                columns: new[] { "Num_reserva", "Bill", "Fec_entrada", "Fec_salida", "Habitacion", "Num_adultos", "Num_menores", "TermsAccepted", "Tip_pension", "VIP" },
                values: new object[] { "JJJ333", 100.25f, new DateTime(2022, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "103B", 2, 0, true, "Almuerzo y Cena", false });

            migrationBuilder.InsertData(
                table: "Reservas",
                columns: new[] { "Num_reserva", "Bill", "Fec_entrada", "Fec_salida", "Habitacion", "Num_adultos", "Num_menores", "TermsAccepted", "Tip_pension", "VIP" },
                values: new object[] { "ABC123", 100.25f, new DateTime(2022, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "103B", 2, 0, true, "Cena", false });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservas");
        }
    }
}
