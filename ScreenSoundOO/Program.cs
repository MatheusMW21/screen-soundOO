// adicionando um álbum
Album abbeyRoad = new Album();
abbeyRoad.Nome = "Abbey Road";

// Faixa 1
Musica musica1 = new Musica();
musica1.Nome = "Come Together";
musica1.Duracao = 321;

// Faixa 2
Musica musica2 = new Musica();
musica2.Nome = "Something";
musica2.Duracao = 223;

abbeyRoad.AdicionarMusica(musica1);
abbeyRoad.AdicionarMusica(musica2);

// Criando banda
Banda beatles = new Banda();
beatles.Nome = "The Beatles";
beatles.AdicionarAlbum(abbeyRoad);
beatles.PrintDiscografia();
