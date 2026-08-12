namespace EX005;

public class Consulta
{
    public Medico medico;
    public Paciente paciente;

    public string motivo = "";
    public double valor = 0.0;
    public string dataHorario = "";
    public bool status;

    public void ConfirmarPresenca()
    {
        status = true;
    }

    public void CancelarAgendamento()
    {
        status = false;
    }
}