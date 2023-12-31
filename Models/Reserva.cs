using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioReservaHotelaria.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva(int diasReservados) {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes) {
            Hospedes ??= new();
            if(hospedes.Count < Suite.Capacidade) {
                foreach(Pessoa pessoa in hospedes) {
                    Hospedes.Add(pessoa);
                }
            }
            else throw new Exception("A quantidade de hóspedes não pode execeder a capacidade da suíte");
            
        }

        public void CadastrarSuite(Suite suite) {
            Suite ??= suite;
        }

        public int ObterQuantidadeHospedes() {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria() {
            return DiasReservados * Suite.ValorDiaria;
        }
    }
}