using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioReservaHotelaria.Models;

namespace DesafioReservaHotelaria
{
    public class Program
    {
        public static void Main() {
            List<Pessoa> hospedes = new();

            Pessoa p1 = new(nome: "Jão");
            Pessoa p2 = new(nome: "Pedrin");
            Pessoa p3 = new(nome: "Zeca");

            hospedes.Add(p1);
            hospedes.Add(p2);
            hospedes.Add(p3);

            Suite suite = new(tipoSuite: "Premium", capacidade: 3, valorDiaria: 30.00M);

            Reserva reserva = new(diasReservados: 10);

            reserva.CadastrarSuite(suite);
            reserva.CadastrarHospedes(hospedes);

            Console.WriteLine($"Hóspedes: { reserva.ObterQuantidadeHospedes() }");
            Console.WriteLine($"Valor diária: { reserva.CalcularValorDiaria() }");
        }
    }
}