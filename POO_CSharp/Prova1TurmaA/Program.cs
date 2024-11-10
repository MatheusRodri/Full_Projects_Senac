using Prova1TurmaA;
using Prova1TurmaA.Produtos;

DateTime data = new DateTime(2024,03,12);
ProdutoEletronico celular = new ProdutoEletronico("celular", "motorola", 1500.00f, 500.00f, data,null);
ProdutoAlimenticio bolacha = new ProdutoAlimenticio("Bolacha", "Bauducco", 7f, 300.00f, null,data);

//CarrinhoDeCompra carrinho = new CarrinhoDeCompra(1200f);

Pessoa Matheus = new Pessoa("Matheus","12345678910",500.00f);
Pessoa Wanessa = new Pessoa("Wanessa", "46876498644", 100f);

Matheus.adicionarItemCarrinho(celular);
Matheus.adicionarItemCarrinho(bolacha);
Matheus.removerItemCarrinho(celular);
Matheus.adicionarItemCarrinho(bolacha);
Matheus.finalizarCompra();

Wanessa.adicionarItemCarrinho(celular);
Wanessa.finalizarCompra();

