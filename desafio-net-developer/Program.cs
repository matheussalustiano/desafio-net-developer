internal class Program
{
    private static void Main(string[] args)
    {
        int opcao;

        do
        {
            Console.Clear();
            Console.WriteLine("===== MENU =====");
            Console.WriteLine("1 - Adicionar Produto");
            Console.WriteLine("2 - Listar Produtos");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");

            // Lê a opção digitada e tenta converter
            if (!int.TryParse(Console.ReadLine(), out opcao))
            {
                Console.WriteLine("Opção inválida! Pressione Enter para continuar.");
                Console.ReadLine();
                continue;
            }

            switch (opcao)
            {
                case 1:
                    AdicionarProduto();
                    break;
                case 2:
                    ListarProdutos();
                    break;
                case 0:
                    Console.WriteLine("Encerrando...");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

            if (opcao != 0)
            {
                Console.WriteLine("\nPressione Enter para voltar ao menu...");
                Console.ReadLine();
            }

        } while (opcao != 0);
    }

    static void AdicionarProduto()
    {
        Console.Clear();
        Console.WriteLine("=== Adicionar Produto ===");

        // TODO: Implementar leitura do nome do produto
        // TODO: Implementar leitura do preço
        // TODO: Criar objeto Produto e adicionar à lista

        Console.WriteLine("Produto adicionado com sucesso!");
    }

    static void ListarProdutos()
    {
        Console.Clear();
        Console.WriteLine("=== Lista de Produtos ===");

        // TODO: Listar os produtos armazenados na lista
    }
}