 class Programa {
static void Main(string[] args){

Banda bts = new Banda("BTS");

Album albumDoBTS = new Album("Forever Young");

Musica musica1 = new Musica(bts, "Normal")
{
  Duracao = 250,
  Disponivel = true,
};

Musica musica2 = new Musica(bts , "Love Yourself")
{
  Duracao = 354,
  Disponivel = false,
};

albumDoBTS.AdicionarMusica(musica1);
albumDoBTS.AdicionarMusica(musica2);
bts.AdicionarAlbum(albumDoBTS);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
albumDoBTS.ExibirMusicasDoAlbum();
bts.ExibirDiscografia();
}
}