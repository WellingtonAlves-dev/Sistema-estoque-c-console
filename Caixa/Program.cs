using Estoque;

Estoque.Estoque estoque = new Estoque.Estoque();
Console.ForegroundColor = ConsoleColor.White;
while (true)
{
    Console.BackgroundColor = ConsoleColor.DarkBlue;
    Console.Clear();
    try
    {
        Console.WriteLine("1 - Cadastrar Produto");
        Console.WriteLine("2 - Listar Produtos");
        Console.WriteLine("3 - Deletar Produto");
        Console.Write("Qual é sua opção? ");
        int opcao = Convert.ToInt16(Console.ReadLine());
        if (opcao == 1)
        {
            estoque.CadastrarProduto();
        } else if (opcao == 2)
        {
            estoque.ListarProdutos();
        } else if(opcao == 3)
        {
            estoque.DeletarProduto();
        } else
        {
            Console.WriteLine("esta opção ainda não existe");
        }
    } catch(Exception ex)
    {
        Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.WriteLine(ex.Message);
    }
    Console.WriteLine("Pressione enter para continuar");
    Console.ReadKey();
}
