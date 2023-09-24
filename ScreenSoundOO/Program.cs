
Musica musica1 = new Musica();

musica1.Nome = "Strawberry Fields Forever";
musica1.Artista = "The Beatles";
musica1.Duracao = 400;
musica1.Disponivel = true;
Console.WriteLine(musica1.Descricao);

Musica musica2 = new Musica();
musica2.Nome = "Man in the box";
musica2.Artista = "Alice in Chains";
musica2.Duracao = 234;
musica2.Disponivel = false;

musica1.ExibirFicha();
musica2.ExibirFicha();



