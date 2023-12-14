using projeto_3.Models;

EstoqueM estoqueM = new EstoqueM();
EstoqueF estoqueF = new EstoqueF();

bool exibirEstoque = true;

while (exibirEstoque)
{
    Console.Clear();
    Console.WriteLine("Loja de Sapatos - M & F");
    Console.WriteLine();

    Console.WriteLine("ESTOQUE MASCULINO");
    Console.WriteLine("1 - Cadastrar Produto em Estoque MASCULINO");
    Console.WriteLine("2 - Visualizar Produtos em Estoque MASCULINO");
    Console.WriteLine("3 - Deletar Produto em Estoque MASCULINO");
    Console.WriteLine("4 - Atualizar Produto em Estoque MASCULINO");
    Console.WriteLine("5 - Pesquisar um Produto do Estoque MASCULINO");

    Console.WriteLine();

    Console.WriteLine("ESTOQUE FEMININO");
    Console.WriteLine("6 - Cadastrar um Produto do Estoque FEMININO");
    Console.WriteLine("7 - Visualizar um Produto do Estoque FEMININO");
    Console.WriteLine("8 - Deletar um Produto do Estoque FEMININO");
    Console.WriteLine("9 - Atualizar um Produto do Estoque FEMININO");
    Console.WriteLine("10 - Pesquisar um Produto do Estoque FEMININO");
    Console.WriteLine();
    Console.WriteLine("0 - SAIR DA LOJA");

    switch(Console.ReadLine())
    {
        case "1" :  
            estoqueM.CadastrarProdutoM();
            break;

        case "2" :
            estoqueM.VisualizarEstoqueM();
            break;

        case "3" :
            estoqueM.DeletarProdutoM();
            break;

        case "4" :
            estoqueM.AtualizarProdutoM();
            break;

        case "5" :
            estoqueM.PesquisarProdutoM();
            break;

        case "6" :
            estoqueF.CadastrarProdutoF();
            break;

        case "7" :
            estoqueF.VisualizarEstoqueF();
            break;

        case "8" :
            estoqueF.DeletarProdutoF();
            break;

        case "9" :
            estoqueF.AtualizarProdutoF();
            break;

        case "10" :
            estoqueF.PesquisarProdutoF();
            break;

        case "0" :
            exibirEstoque = false;
            break;

        default :
            Console.WriteLine("Opção Inválida");
            break;
    }

        Console.WriteLine("Pressione uma tecla para continuar");
        Console.ReadLine();

}
        Console.WriteLine("O Sistema se encerrou");


