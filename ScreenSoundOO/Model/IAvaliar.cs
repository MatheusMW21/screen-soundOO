using ScreenSound.Model;

namespace ScreenSoundOO.Model;

internal interface IAvaliar
{
    void AdicionarNota(Avaliacao nota);
    double Media { get; }
}
