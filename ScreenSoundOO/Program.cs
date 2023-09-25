// Criando banda
Banda beatles = new Banda("The Beatles");

// adicionando um álbum
Album abbeyRoad = new Album("Abbey Road");

// Faixa 1
Musica musica1 = new Musica(beatles, "Come Together")
{
    Duracao = 321,
    Disponivel = true,
};

// Faixa 2
Musica musica2 = new Musica(beatles, "Something")
{
    Duracao = 223,
    Disponivel = false,
};

// Adicionando faixas
abbeyRoad.AdicionarMusica(musica1);
abbeyRoad.AdicionarMusica(musica2);
abbeyRoad.PrintAlbum();
musica1.ExibirFicha();
musica2.ExibirFicha();

// Adicionando álbum
beatles.AdicionarAlbum(abbeyRoad);
beatles.PrintDiscografia();

// Criando podcast
Podcast nerdcast = new Podcast("NerdCast", "Jovem Nerd");

// Criando episódio
Episodios ep1 = new Episodios(1, "Episódio - Game of Thrones", 90);
ep1.AdicionarConvidado(ep1);

// Exibindo detalhes
nerdcast.ExibirDetalhes();

