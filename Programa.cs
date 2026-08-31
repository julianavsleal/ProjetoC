class Programa
{
    static void Main()
    {
        Musica musica1 = new Musica() { Nome = "Roxane", Artista = "The Police" };
        musica1.Duracao = 273;
        musica1.Disponivel = true;
        Console.WriteLine(musica1.DescricaoResumida);

        Musica musica2 = new Musica() { Nome = "Vertigo", Artista = "U2" };
        musica2.Duracao = 367;
        musica2.Disponivel = false;

        musica1.ExibirFichaTecnica();
        musica2.ExibirFichaTecnica();
    }
}