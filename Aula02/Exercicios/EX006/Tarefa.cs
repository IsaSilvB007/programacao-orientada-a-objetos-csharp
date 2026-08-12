namespace EX006;

public class Tarefa
{
    public string titulo = "";
    public string descricao = "";
    public string responsavel = "";
    public string dataCriacao = "";
    public string prioridade = "";
    public string status = "";

    public void MoverColuna(string novaColuna)
    {
        status = novaColuna;
    }

    public void AlterarResponsavel(string novoResponsavel)
    {
        responsavel = novoResponsavel;
    }
}