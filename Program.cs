using System;

namespace dbcodefirst
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var contexto = new AppDbContext())
            {
                var listaProdutos = new System.Collections.Generic.List<Produto>
                {
                    new Produto {Nome = "Caderno" , Preco = 5.50M , Estoque = 10 },
                    new Produto {Nome = "Lápis" , Preco = 3.40M, Estoque = 20 },
                };

                contexto.Produtos.AddRange(listaProdutos);
                contexto.SaveChanges();
                ExibirProdutos(contexto);
            }
            Console.ReadLine();
        }

        private static void ExibirProdutos(AppDbContext db)
        { 
            //exibir produtos
            var Produtos = db.Produtos.ToList();
            foreach (var p in Produtos)
            {
                Console.WriteLine($"{p.Nome} {p.Preço.ToString("c")}");
            }
        }

    }
}
