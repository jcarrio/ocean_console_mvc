using consoleMVC.Model;
using consoleMVC.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleMVC.Controller
{
    class ProdutoController
    {
        // com quem vai se comunicar:
        //produto classe
        //view

        Produto produto = new Produto();
        ProdutoView produtoView = new ProdutoView();

        // criando serviço

        public void ListarProdutos()
        {
            produtoView.Listar(produto.Ler());

            // ou de outra forma
            // List<Produto> produtos = produto.Ler();
            // produtoView.Listar(produtos);
        }
    }
}
