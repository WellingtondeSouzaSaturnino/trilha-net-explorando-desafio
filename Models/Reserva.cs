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
            // *IMPLEMENTE AQUI*


            if (Suite.Capacidade >= hospedes.Count())
            {
                Hospedes = hospedes;
            }




            // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
            // *IMPLEMENTE AQUI*



            try
            {
                if (Hospedes.Count <= 0)
                {

                    return;
                }
            }
            catch (Exception)
            {

                Console.WriteLine("A quantidade de hóspedes não pode exceder a capacidade da suíte.");
                throw;

            }




        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            // *IMPLEMENTE AQUI*

            if (Hospedes == null)
            {
                return 0;

            }
            return Hospedes.Count();


        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // *IMPLEMENTE AQUI*
            decimal valor = DiasReservados * Suite.ValorDiaria;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTE AQUI*
            if (DiasReservados >= 10)
            {

                decimal valor2 = (valor * 10) / 100;
                return valor - valor2;

            }

            return valor;
        }
    }
}