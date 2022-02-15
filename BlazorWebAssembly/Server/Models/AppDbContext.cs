
using BlazorWebAssembly.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWebAssembly.Server.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Documento> Documentos { get; set; }
        public DbSet<Huesped> Huespedes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Seed Reserva Table
            modelBuilder.Entity<Reserva>().HasData(new Reserva
            {
                Num_reserva = "XHJ4321",

                Fec_entrada = new DateTime(2022, 2, 18), 
                Fec_salida = new DateTime(2022, 2, 25), 
                //VIP = false, 
                Tip_pension = "Desayno y Cena", 
                Num_adultos = 2, 
                Num_menores = 0, 
                Habitacion = "103B",
                Bill = 100.25F,
                TermsAccepted = true,
                //fecha de entrada // Date 	ArrivalData
                //fecha salida // Date	DepartureData
                //tipo de habitacion // String	RoomType
                //tipo de pension // String	PensionType
                //num_adultos // Integer AdultNumber //min->1
                //num_menores // Integer ChildNumber
                //Documents: true/false //pertenece a otra tabla
                //Float: Bill
                //Boolean:TermsAccepted:true or false
                //
                //
            });

            modelBuilder.Entity<Reserva>().HasData(new Reserva
            {
                Num_reserva = "JJJ333",

                Fec_entrada = new DateTime(2022, 2, 18),
                Fec_salida = new DateTime(2022, 2, 25),
                //VIP = false, 
                Tip_pension = "Almuerzo y Cena",
                Num_adultos = 2,
                Num_menores = 0,
                Habitacion = "103B",
                Bill = 100.25F,
                TermsAccepted = true,
                //fecha de entrada // Date 	ArrivalData
                //fecha salida // Date	DepartureData
                //tipo de habitacion // String	RoomType
                //tipo de pension // String	PensionType
                //num_adultos // Integer AdultNumber //min->1
                //num_menores // Integer ChildNumber
                //Documents: true/false //pertenece a otra tabla
                //Float: Bill
                //Boolean:TermsAccepted:true or false
                //
                //
            });

            modelBuilder.Entity<Reserva>().HasData(new Reserva
            {
                Num_reserva = "ABC123",

                Fec_entrada = new DateTime(2022, 2, 18),
                Fec_salida = new DateTime(2022, 2, 25),
                //VIP = false, 
                Tip_pension = "Cena",
                Num_adultos = 2,
                Num_menores = 0,
                Habitacion = "103B",
                Bill = 100.25F,
                TermsAccepted = true,
                //fecha de entrada // Date 	ArrivalData
                //fecha salida // Date	DepartureData
                //tipo de habitacion // String	RoomType
                //tipo de pension // String	PensionType
                //num_adultos // Integer AdultNumber //min->1
                //num_menores // Integer ChildNumber
                //Documents: true/false //pertenece a otra tabla
                //Float: Bill
                //Boolean:TermsAccepted:true or false
                //
                //
            });

            modelBuilder.Entity<Huesped>().HasData(new Huesped
            {
                Id = 1,
                Referencia = "XHJ4321"

            });

            modelBuilder.Entity<Huesped>().HasData(new Huesped
            {
                Id = 2,
                Referencia = "JJJ333",
                DNI = "12549828R"
            });

            modelBuilder.Entity<Huesped>().HasData(new Huesped
            {
                Id = 3,
                Referencia = "ABC123",
                DNI = "45381925D"
            });

            string[] names = { "Certificado de vacunacion",  "Declaracion jurada", "Parte de viajero"};
            string[] RandomDni = { "12549828R", "45381925D", "65232345C" };
            var ind = 1;
            for (var i = 0; i < RandomDni.Length; i++)
            {
                for (var j = 0; j < names.Length; j++)
                {
                    modelBuilder.Entity<Documento>().HasData(new Documento
                    {
                        Id = ind,
                        DNI = RandomDni[i],
                        Name = names[j],
                        File64 = "iVBORw0KGgoAAAANSUhEUgAAAKAAAAChCAYAAABAk7" +
                        "SIAACAAElEQVR4XuydBXge55XvZZJsS8aYY2aZQWYmmdkyM8mWZC" +
                        "ZZZMliZmaWLJmZYjtxEgccbNKkaZukTbe4bbe07ULPPb+jfNmun717" +
                        "e/cudW/meeaZ+eajmXn/7//8D7zvODl9vXy9fL3891uqa0udqmtKna" +
                        "qqS75cS51qasucLl4653Tr9jWne/dvOr365JHT66+/pOuLTg8f3nK6f" +
                        "LnGqaQk2ykrK8kpIyPBKTMz0fazMpOe/fmvl6+XhiUvP80pOzfZKTsn2" +
                        "amgMNOptCzfqbKqqJGCr3NNbemGisqiFN2/VVlV8nF5RdGn5y/U/v2Dh" +
                        "3fl+o3L8s67b8ibbz6W9957/Y+PX773y4sXqz/Nzk76NCkp8t3k5OgLm" +
                        "ZlJ63NyUoYrEJ/PzU1tVFaW51RZUejEtlD/Ky8v3SknW/9fV7ZfL//Dl" +
                        "+KSfKei4jxd8xVoCoTyQqfCoqz2WdlJa9LS428WFGV+rsf+WFVdLLXnK" +
                        "nQtk8KiHDlX"

                    });
                    ind++;
                }
                
            }
            /*modelBuilder.Entity<Documento>().HasData(new Documento
            {
                Id = 1,
                DNI = "42311480T",
                Name = "Certificado de vacunacion",
                File64 = ""

                
                //3docs
                //public string DNI { get; set; }
                //public string Name { get; set; }
                //public string File64 { get; set; }
                 
                 
            });*/
        }
    }
}
