Banda linkinPark = new Banda("Linkin Park");
Album albumLikinPark =  new Album("Meteora");

Musica musica1 = new Musica(linkinPark, "Foreward")
{
    Duracao = 13,
    Disponivel = true
};


Musica musica2 = new Musica(linkinPark, "Don't Stay")
{
    Duracao = 184,
    Disponivel = true
};


Musica musica3 = new Musica(linkinPark, "Somewhere I Belong")
{
    Duracao = 200,
    Disponivel = true
};

Musica musica4 = new Musica(linkinPark, "Lying From You")
{
    Duracao = 154,
    Disponivel = true
};

Musica musica5 = new Musica(linkinPark, "Hit The Floor")
{
    Duracao = 147,
    Disponivel = true
};

Musica musica6 = new Musica(linkinPark, "Easier To Run")
{
    Duracao = 194,
    Disponivel = true
};

Musica musica7 = new Musica(linkinPark, "Faint")
{
    Duracao = 148,
    Disponivel = true
};

Musica musica8 = new Musica(linkinPark, "Figure.09")
{
    Duracao = 186,
    Disponivel = true
};

Musica musica9 = new Musica(linkinPark, "Breaking The Habit")
{
    Duracao = 190,
    Disponivel = true
};

Musica musica10 = new Musica(linkinPark, "From The Inside")
{
    Duracao = 154,
    Disponivel = true
};

Musica musica11 = new Musica(linkinPark, "Nobody's Listening")
{
    Duracao = 192,
    Disponivel = true
};

Musica musica12 = new Musica(linkinPark, "Session")
{
    Duracao = 240,
    Disponivel = true
};

Musica musica13 = new Musica(linkinPark, "Numb")
{
    Duracao = 154,
    Disponivel = true
};

albumLikinPark.AdicionarMusica(musica1);
albumLikinPark.AdicionarMusica(musica2);
albumLikinPark.AdicionarMusica(musica3);
albumLikinPark.AdicionarMusica(musica4);
albumLikinPark.AdicionarMusica(musica5);
albumLikinPark.AdicionarMusica(musica6);
albumLikinPark.AdicionarMusica(musica7);
albumLikinPark.AdicionarMusica(musica8);
albumLikinPark.AdicionarMusica(musica9);
albumLikinPark.AdicionarMusica(musica10);
albumLikinPark.AdicionarMusica(musica11);
albumLikinPark.AdicionarMusica(musica12);
albumLikinPark.AdicionarMusica(musica13);


musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
musica3.ExibirFichaTecnica();
musica4.ExibirFichaTecnica();
musica5.ExibirFichaTecnica();
musica6.ExibirFichaTecnica();
musica7.ExibirFichaTecnica();
musica8.ExibirFichaTecnica();
musica9.ExibirFichaTecnica();
musica10.ExibirFichaTecnica();
musica11.ExibirFichaTecnica();
musica12.ExibirFichaTecnica();
musica13.ExibirFichaTecnica();
albumLikinPark.ExibirMusicasDoAlbum();
linkinPark.AdicionarAlbum(albumLikinPark);
linkinPark.ExibirDiscografia();


// Podcast's
Console.WriteLine("Podcasts Disponíveis: ");
Episodio ep1 = new(1, "Técnicas de facilitação", 45);
ep1.AdicionarConvidados("Maria");
ep1.AdicionarConvidados("Marcelo");
Console.WriteLine(ep1.Resumo);

Episodio ep2 = new(2, "Técnicas de aprendizado", 67);
ep2.AdicionarConvidados("Fernando");
ep2.AdicionarConvidados("Marcos");
ep2.AdicionarConvidados("Flavia");
Console.WriteLine(ep2.Resumo);

Podcast podcast = new("Podcast especial", "Daniel");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.ExibirDetalhes();
