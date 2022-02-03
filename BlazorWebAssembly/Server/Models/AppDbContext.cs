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
        }
    }
}
