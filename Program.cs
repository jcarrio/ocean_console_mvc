using consoleMVC.Controller;
using consoleMVC.Model;
using System;

namespace consoleMVC
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutoController produto = new ProdutoController();

            produto.ListarProdutos();
        }
    }
}
