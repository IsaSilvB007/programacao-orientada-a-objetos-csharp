namespace EX002;

public class Pedido
{
    public string formaPagamento = "";
    public string statusPreparo = "Pendente";
    public double valorTotal = 0.0;

    public void AdicionarItem(Produto produto, int quantidade)
    {
        valorTotal = valorTotal + (produto.preco * quantidade);
    }

    public void RemoverItem(Produto produto)
    {
        valorTotal = valorTotal - produto.preco;
    }

    public double CalcularValorTotal()
    {
        return valorTotal;
    }
}