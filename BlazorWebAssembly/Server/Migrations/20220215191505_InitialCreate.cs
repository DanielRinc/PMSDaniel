using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorWebAssembly.Server.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Documentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DNI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    File64 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documentos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Huespedes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Referencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DNI = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Huespedes", x => x.Id);
                });

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
                table: "Documentos",
                columns: new[] { "Id", "DNI", "File64", "Name" },
                values: new object[,]
                {
                    { 1, "12549828R", "iVBORw0KGgoAAAANSUhEUgAAAKAAAAChCAYAAABAk7SIAACAAElEQVR4XuydBXge55XvZZJsS8aYY2aZQWYmmdkyM8mWZCZZZMliZmaWLJmZYjtxEgccbNKkaZukTbe4bbe07ULPPb+jfNmun717e/cudW/meeaZ+eajmXn/7//8D7zvODl9vXy9fL3891uqa0udqmtKnaqqS75cS51qasucLl4653Tr9jWne/dvOr365JHT66+/pOuLTg8f3nK6fLnGqaQk2ykrK8kpIyPBKTMz0fazMpOe/fmvl6+XhiUvP80pOzfZKTsn2amgMNOptCzfqbKqqJGCr3NNbemGisqiFN2/VVlV8nF5RdGn5y/U/v2Dh3fl+o3L8s67b8ibbz6W9957/Y+PX773y4sXqz/Nzk76NCkp8t3k5OgLmZlJ63NyUoYrEJ/PzU1tVFaW51RZUejEtlD/Ky8v3SknW/9fV7ZfL//Dl+KSfKei4jxd8xVoCoTyQqfCoqz2WdlJa9LS428WFGV+rsf+WFVdLLXnKnQtk8KiHDlX", "Certificado de vacunacion" },
                    { 2, "12549828R", "iVBORw0KGgoAAAANSUhEUgAAAKAAAAChCAYAAABAk7SIAACAAElEQVR4XuydBXge55XvZZJsS8aYY2aZQWYmmdkyM8mWZCZZZMliZmaWLJmZYjtxEgccbNKkaZukTbe4bbe07ULPPb+jfNmun717e/cudW/meeaZ+eajmXn/7//8D7zvODl9vXy9fL3891uqa0udqmtKnaqqS75cS51qasucLl4653Tr9jWne/dvOr365JHT66+/pOuLTg8f3nK6fLnGqaQk2ykrK8kpIyPBKTMz0fazMpOe/fmvl6+XhiUvP80pOzfZKTsn2amgMNOptCzfqbKqqJGCr3NNbemGisqiFN2/VVlV8nF5RdGn5y/U/v2Dh3fl+o3L8s67b8ibbz6W9957/Y+PX773y4sXqz/Nzk76NCkp8t3k5OgLmZlJ63NyUoYrEJ/PzU1tVFaW51RZUejEtlD/Ky8v3SknW/9fV7ZfL//Dl+KSfKei4jxd8xVoCoTyQqfCoqz2WdlJa9LS428WFGV+rsf+WFVdLLXnKnQtk8KiHDlX", "Declaracion jurada" },
                    { 3, "12549828R", "iVBORw0KGgoAAAANSUhEUgAAAKAAAAChCAYAAABAk7SIAACAAElEQVR4XuydBXge55XvZZJsS8aYY2aZQWYmmdkyM8mWZCZZZMliZmaWLJmZYjtxEgccbNKkaZukTbe4bbe07ULPPb+jfNmun717e/cudW/meeaZ+eajmXn/7//8D7zvODl9vXy9fL3891uqa0udqmtKnaqqS75cS51qasucLl4653Tr9jWne/dvOr365JHT66+/pOuLTg8f3nK6fLnGqaQk2ykrK8kpIyPBKTMz0fazMpOe/fmvl6+XhiUvP80pOzfZKTsn2amgMNOptCzfqbKqqJGCr3NNbemGisqiFN2/VVlV8nF5RdGn5y/U/v2Dh3fl+o3L8s67b8ibbz6W9957/Y+PX773y4sXqz/Nzk76NCkp8t3k5OgLmZlJ63NyUoYrEJ/PzU1tVFaW51RZUejEtlD/Ky8v3SknW/9fV7ZfL//Dl+KSfKei4jxd8xVoCoTyQqfCoqz2WdlJa9LS428WFGV+rsf+WFVdLLXnKnQtk8KiHDlX", "Parte de viajero" },
                    { 4, "45381925D", "iVBORw0KGgoAAAANSUhEUgAAAKAAAAChCAYAAABAk7SIAACAAElEQVR4XuydBXge55XvZZJsS8aYY2aZQWYmmdkyM8mWZCZZZMliZmaWLJmZYjtxEgccbNKkaZukTbe4bbe07ULPPb+jfNmun717e/cudW/meeaZ+eajmXn/7//8D7zvODl9vXy9fL3891uqa0udqmtKnaqqS75cS51qasucLl4653Tr9jWne/dvOr365JHT66+/pOuLTg8f3nK6fLnGqaQk2ykrK8kpIyPBKTMz0fazMpOe/fmvl6+XhiUvP80pOzfZKTsn2amgMNOptCzfqbKqqJGCr3NNbemGisqiFN2/VVlV8nF5RdGn5y/U/v2Dh3fl+o3L8s67b8ibbz6W9957/Y+PX773y4sXqz/Nzk76NCkp8t3k5OgLmZlJ63NyUoYrEJ/PzU1tVFaW51RZUejEtlD/Ky8v3SknW/9fV7ZfL//Dl+KSfKei4jxd8xVoCoTyQqfCoqz2WdlJa9LS428WFGV+rsf+WFVdLLXnKnQtk8KiHDlX", "Certificado de vacunacion" },
                    { 5, "45381925D", "iVBORw0KGgoAAAANSUhEUgAAAKAAAAChCAYAAABAk7SIAACAAElEQVR4XuydBXge55XvZZJsS8aYY2aZQWYmmdkyM8mWZCZZZMliZmaWLJmZYjtxEgccbNKkaZukTbe4bbe07ULPPb+jfNmun717e/cudW/meeaZ+eajmXn/7//8D7zvODl9vXy9fL3891uqa0udqmtKnaqqS75cS51qasucLl4653Tr9jWne/dvOr365JHT66+/pOuLTg8f3nK6fLnGqaQk2ykrK8kpIyPBKTMz0fazMpOe/fmvl6+XhiUvP80pOzfZKTsn2amgMNOptCzfqbKqqJGCr3NNbemGisqiFN2/VVlV8nF5RdGn5y/U/v2Dh3fl+o3L8s67b8ibbz6W9957/Y+PX773y4sXqz/Nzk76NCkp8t3k5OgLmZlJ63NyUoYrEJ/PzU1tVFaW51RZUejEtlD/Ky8v3SknW/9fV7ZfL//Dl+KSfKei4jxd8xVoCoTyQqfCoqz2WdlJa9LS428WFGV+rsf+WFVdLLXnKnQtk8KiHDlX", "Declaracion jurada" },
                    { 6, "45381925D", "iVBORw0KGgoAAAANSUhEUgAAAKAAAAChCAYAAABAk7SIAACAAElEQVR4XuydBXge55XvZZJsS8aYY2aZQWYmmdkyM8mWZCZZZMliZmaWLJmZYjtxEgccbNKkaZukTbe4bbe07ULPPb+jfNmun717e/cudW/meeaZ+eajmXn/7//8D7zvODl9vXy9fL3891uqa0udqmtKnaqqS75cS51qasucLl4653Tr9jWne/dvOr365JHT66+/pOuLTg8f3nK6fLnGqaQk2ykrK8kpIyPBKTMz0fazMpOe/fmvl6+XhiUvP80pOzfZKTsn2amgMNOptCzfqbKqqJGCr3NNbemGisqiFN2/VVlV8nF5RdGn5y/U/v2Dh3fl+o3L8s67b8ibbz6W9957/Y+PX773y4sXqz/Nzk76NCkp8t3k5OgLmZlJ63NyUoYrEJ/PzU1tVFaW51RZUejEtlD/Ky8v3SknW/9fV7ZfL//Dl+KSfKei4jxd8xVoCoTyQqfCoqz2WdlJa9LS428WFGV+rsf+WFVdLLXnKnQtk8KiHDlX", "Parte de viajero" },
                    { 7, "65232345C", "iVBORw0KGgoAAAANSUhEUgAAAKAAAAChCAYAAABAk7SIAACAAElEQVR4XuydBXge55XvZZJsS8aYY2aZQWYmmdkyM8mWZCZZZMliZmaWLJmZYjtxEgccbNKkaZukTbe4bbe07ULPPb+jfNmun717e/cudW/meeaZ+eajmXn/7//8D7zvODl9vXy9fL3891uqa0udqmtKnaqqS75cS51qasucLl4653Tr9jWne/dvOr365JHT66+/pOuLTg8f3nK6fLnGqaQk2ykrK8kpIyPBKTMz0fazMpOe/fmvl6+XhiUvP80pOzfZKTsn2amgMNOptCzfqbKqqJGCr3NNbemGisqiFN2/VVlV8nF5RdGn5y/U/v2Dh3fl+o3L8s67b8ibbz6W9957/Y+PX773y4sXqz/Nzk76NCkp8t3k5OgLmZlJ63NyUoYrEJ/PzU1tVFaW51RZUejEtlD/Ky8v3SknW/9fV7ZfL//Dl+KSfKei4jxd8xVoCoTyQqfCoqz2WdlJa9LS428WFGV+rsf+WFVdLLXnKnQtk8KiHDlX", "Certificado de vacunacion" },
                    { 8, "65232345C", "iVBORw0KGgoAAAANSUhEUgAAAKAAAAChCAYAAABAk7SIAACAAElEQVR4XuydBXge55XvZZJsS8aYY2aZQWYmmdkyM8mWZCZZZMliZmaWLJmZYjtxEgccbNKkaZukTbe4bbe07ULPPb+jfNmun717e/cudW/meeaZ+eajmXn/7//8D7zvODl9vXy9fL3891uqa0udqmtKnaqqS75cS51qasucLl4653Tr9jWne/dvOr365JHT66+/pOuLTg8f3nK6fLnGqaQk2ykrK8kpIyPBKTMz0fazMpOe/fmvl6+XhiUvP80pOzfZKTsn2amgMNOptCzfqbKqqJGCr3NNbemGisqiFN2/VVlV8nF5RdGn5y/U/v2Dh3fl+o3L8s67b8ibbz6W9957/Y+PX773y4sXqz/Nzk76NCkp8t3k5OgLmZlJ63NyUoYrEJ/PzU1tVFaW51RZUejEtlD/Ky8v3SknW/9fV7ZfL//Dl+KSfKei4jxd8xVoCoTyQqfCoqz2WdlJa9LS428WFGV+rsf+WFVdLLXnKnQtk8KiHDlX", "Declaracion jurada" },
                    { 9, "65232345C", "iVBORw0KGgoAAAANSUhEUgAAAKAAAAChCAYAAABAk7SIAACAAElEQVR4XuydBXge55XvZZJsS8aYY2aZQWYmmdkyM8mWZCZZZMliZmaWLJmZYjtxEgccbNKkaZukTbe4bbe07ULPPb+jfNmun717e/cudW/meeaZ+eajmXn/7//8D7zvODl9vXy9fL3891uqa0udqmtKnaqqS75cS51qasucLl4653Tr9jWne/dvOr365JHT66+/pOuLTg8f3nK6fLnGqaQk2ykrK8kpIyPBKTMz0fazMpOe/fmvl6+XhiUvP80pOzfZKTsn2amgMNOptCzfqbKqqJGCr3NNbemGisqiFN2/VVlV8nF5RdGn5y/U/v2Dh3fl+o3L8s67b8ibbz6W9957/Y+PX773y4sXqz/Nzk76NCkp8t3k5OgLmZlJ63NyUoYrEJ/PzU1tVFaW51RZUejEtlD/Ky8v3SknW/9fV7ZfL//Dl+KSfKei4jxd8xVoCoTyQqfCoqz2WdlJa9LS428WFGV+rsf+WFVdLLXnKnQtk8KiHDlX", "Parte de viajero" }
                });

            migrationBuilder.InsertData(
                table: "Huespedes",
                columns: new[] { "Id", "DNI", "Referencia" },
                values: new object[,]
                {
                    { 1, null, "XHJ4321" },
                    { 2, "12549828R", "JJJ333" },
                    { 3, "45381925D", "ABC123" }
                });

            migrationBuilder.InsertData(
                table: "Reservas",
                columns: new[] { "Num_reserva", "Bill", "Fec_entrada", "Fec_salida", "Habitacion", "Num_adultos", "Num_menores", "TermsAccepted", "Tip_pension", "VIP" },
                values: new object[,]
                {
                    { "XHJ4321", 100.25f, new DateTime(2022, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "103B", 2, 0, true, "Desayno y Cena", false },
                    { "JJJ333", 100.25f, new DateTime(2022, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "103B", 2, 0, true, "Almuerzo y Cena", false },
                    { "ABC123", 100.25f, new DateTime(2022, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "103B", 2, 0, true, "Cena", false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Documentos");

            migrationBuilder.DropTable(
                name: "Huespedes");

            migrationBuilder.DropTable(
                name: "Reservas");
        }
    }
}
