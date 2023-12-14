using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_3.Models
{
    public class EstoqueF 
    {

        private List<ProdutoF> estoqueF = new List<ProdutoF>();


        public void CadastrarProdutoF()
        {
            try
            {
            Console.WriteLine("Qual nome do produto?");
            string nome = Console.ReadLine() ?? string.Empty;

            Console.WriteLine("Qual ID do produto?");
            int identificadorProduto = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual a quantidade do produto?");
            int quantidadeProduto = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Faça uma breve descrição do Produto.");
            string descricao = Console.ReadLine() ?? string.Empty;

            ProdutoF produto =  new ProdutoF(nome, identificadorProduto, quantidadeProduto, descricao);

            estoqueF.Add(produto);

            }
            catch(Exception err)
            {
                Console.WriteLine($"Erro! Formato inválido para o produto! {err.Message}");
            }
        }



            public void VisualizarEstoqueF()
        {
            if(estoqueF.Any())
            {

                int cont = 1;
                foreach(var produto in estoqueF)
                {
                    Console.WriteLine($"N° {cont} - Nome:{produto.Nome}, ID : {produto.Identificador}, Quantidade : {produto.Quantidade} , Descrição : {produto.Descricao}");
                    cont++;
                }
            }
        }


        public void DeletarProdutoF()
        {
            Console.WriteLine("Digite o ID do produto para deletar :");

            int removerProduto = Convert.ToInt32(Console.ReadLine());
            int numeroDoId = removerProduto;

            if(estoqueF.Any())
            {
                estoqueF.RemoveAll(produto => produto.Identificador == numeroDoId);
            }
            else
            {
                 Console.WriteLine("Desculpe, esse ID não está no Estoque. Confira o ID corretamente");
            }
        }

    
        public void AtualizarProdutoF()
        {
            Console.WriteLine();
            Console.WriteLine("Digite o ID do Produto para atualiar :");
            int idProduto = Convert.ToInt32(Console.ReadLine());

            ProdutoF? produtoParaRemover = estoqueF.Find(p => p.Identificador == idProduto) ;

            if(produtoParaRemover != null)
            {

                estoqueF.Remove(produtoParaRemover);

                Console.WriteLine();
                Console.WriteLine("Digite um novo nome para o produto :");
                string novoNome = Console.ReadLine() ?? string.Empty;

                Console.WriteLine();
                Console.WriteLine("Digite um novo ID para o produto :");
                int novoID = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("Digite uma nova quantidade:");
                int novaQuantidade = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("Faça uma nova descrição do Produto");
                string  descricao = Console.ReadLine() ?? string.Empty;

                ProdutoF novoProduto= new ProdutoF(novoNome, novoID, novaQuantidade, descricao);
                estoqueF.Add(novoProduto);

            }
            else
            {
                Console.WriteLine("Produto com o IdProduto não encontrado no estoque.");
            }
        }



        public void PesquisarProdutoF()
        {
            Console.WriteLine();
            Console.WriteLine("Digite o ID para procurar Produto :");
            int idProduto = Convert.ToInt32(Console.ReadLine());

            ProdutoF? procurarID = estoqueF.Find(id => id.Identificador == idProduto);

            if(procurarID != null)
            {
                Console.WriteLine($"Produto encontrado : {procurarID}");
            }
            else
            {
                Console.WriteLine("Não consegui achar o ID");
            }
        }







    }
}