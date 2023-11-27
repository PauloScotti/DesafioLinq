//Desafio:
//Escrever um programa que recebe um produto como argumento,
//validar se esse produto está na lista de itens disponíveis do mercado.
//Caso esteja, avisar se possui ou não e, por último,
//exibir a lista de produtos disponíveis ordenados por ordem alfabética do mercado,
//para que o usuário possa pedir na próxima vez.

string mensagem = "";

try
{
    string produtoselecionado;
    List<string> listademercado = new List<string>()
    {
        "Tomate",
        "Cebola",
        "Coca-cola",
        "Batata",
        "Vinho",
        "Pilha",
        "Chocolate"
    };

    Console.WriteLine("Digite o produto que gostaria de comprar:");

    produtoselecionado = Console.ReadLine();

    bool validaproduto = listademercado.Where(l => l.Equals(produtoselecionado)).Any();

    if (validaproduto)
    {
        Console.WriteLine("Pode comprar o produto " + produtoselecionado + " pois ele está disponível");
    }
    else
    {
        Console.WriteLine("O produto " + produtoselecionado + " não está a venda");
    }

    Console.WriteLine("Os produtos disponíveis são:");
    foreach (string produto in listademercado.OrderBy(produto => produto))
    {
        Console.WriteLine(produto);
    }

    mensagem = "Obrigado por ter utilizado o sistema do mercado. Boas compras!";

} catch(Exception ex)
{
    mensagem = "Aconteceu o seguinte problema: " + ex.Message;
} finally
{
    Console.WriteLine(mensagem);
}