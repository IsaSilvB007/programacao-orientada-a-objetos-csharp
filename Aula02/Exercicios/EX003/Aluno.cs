namespace EX003;

public class Aluno
{
    public string nome = "";
    public double progressaoPercentual = 0.0;
    public double notaFinal = 0.0;
    public Curso cursoMatricula;

    public void EfetuarMatricula(Curso curso)
    {
        cursoMatricula = curso;
    }

    public void RegistrarNota(double nota)
    {
        notaFinal = nota;
    }

    public bool EmitirCertificado()
    {
        if (progressaoPercentual >= 100.0)
        {
            return true;
        }
        return false;
    }
}