namespace EX007;

public class Playlist
{
    public string nome = "";
    public Usuario criador;
    public int duracaoTotal = 0;

    public void AdicionarMusica(Musica musica)
    {
        duracaoTotal = duracaoTotal + musica.duracaoSegundo;
    }

    public void RemoverMusica(Musica musica)
    {
        duracaoTotal = duracaoTotal - musica.duracaoSegundo;
    }

    public int RecalcularDuracao()
    {
        return duracaoTotal;
    }
}