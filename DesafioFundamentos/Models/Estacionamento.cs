namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 10;
        private decimal precoPorHora = 2;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            veiculos.Add(Console.ReadLine());
            Console.WriteLine("O veiculo foi adicionado com sucesso");
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Escreva a placa do seu veículo");
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {

                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                string horas = Console.ReadLine();
                int horasInteiro = int.Parse(horas);
                decimal valorTotal = 0;
                valorTotal = precoInicial + precoPorHora * horasInteiro;
                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");

                foreach (string TodosVeiculos in veiculos)
                {
                    Console.WriteLine(TodosVeiculos);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}





