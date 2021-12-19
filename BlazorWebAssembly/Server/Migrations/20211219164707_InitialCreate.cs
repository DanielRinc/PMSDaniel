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
                    Num_reserva = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservas", x => x.Num_reserva);
                });

            migrationBuilder.InsertData(
                table: "Reservas",
                column: "Num_reserva",
                value: "XHJ4321");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservas");
        }
    }
}
