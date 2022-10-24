using System.Transactions;
namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // *FEITO*
            if (hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                // *FEITO - Ficaria mais elegante simplesmente enviar um WriteLine, mas como foi solicitado Exception, assim eu fiz*
                throw new Exception("O Suite disponível não comporta a quantidade de hóspedes solicitada");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            // *FEITO*
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // *FEITO*
            decimal valor = DiasReservados * Suite.ValorDiaria ;


            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IFEITO*
            
            if (DiasReservados>=10)
               { 
                valor = valor - valor*10/100;
               }

               return valor;
        }
    }
}