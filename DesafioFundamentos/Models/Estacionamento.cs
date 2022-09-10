namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo:");    
            veiculos.Add(Console.ReadLine());

            Console.WriteLine("Veículo cadastrado com sucesso!");
        }

        public void RemoverVeiculo()
        {

            Console.WriteLine("Digite a placa do veículo");

            string placa = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Quantidade de horas que o veículo permaneceu estacionado:");
                string qh = Console.ReadLine();

                int horas = int.Parse(qh);
                decimal valorTotal = precoInicial + precoPorHora * horas;

                veiculos.Remove(placa);
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Veículo não estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {

            if (veiculos.Any())
            {
                Console.WriteLine("Veículos estacionados são:");
 
                foreach (string v in veiculos)
                {
                    Console.WriteLine(v);
                }
            }
            else
            {
 
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
