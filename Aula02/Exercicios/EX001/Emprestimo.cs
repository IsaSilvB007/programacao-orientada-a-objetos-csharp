namespace EX001;

public class Emprestimo
{
    public Leitor Leitor;
    public Livro livro;

    public DateTime dataRetirada;
    public DateTime dataPrevistaDevolucao;
    public string status = "Ativo";

    public void RealizarEmprestimo(Leitor leitorInformado, Livro livroInformado)
    {
        Leitor = leitorInformado;
        livro = livroInformado;
        dataRetirada = DateTime.Now;
        dataPrevistaDevolucao = DateTime.Now.AddDays(14);
        status = "Ativo";

        livro.estado - false;
    }

    public void DevolverLivro()
    {
        status = "Concluído";
        if (livro != null)
        {
            livro.estado = true;
        }
    }

}