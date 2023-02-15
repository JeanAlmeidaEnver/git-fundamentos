using Newtonsoft.Json;
using ProjetoExemplo.Models;

var produto = new Produto
{
    Nome = "Notebook",
    Valor = 2500,
    Estoque = 10,
};

var json = JsonConvert.SerializeObject(produto);
Console.WriteLine(json);