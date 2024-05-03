namespace EnigmaSimulator.Algorithm;

public abstract class Rotor(char startingChar)
{
    public char CurrentChar { get; private set; } = startingChar;
    public char SpinNextRotorCharBackward => (char)(SpinNextRotorCharForward - 1);
    public abstract char SpinNextRotorCharForward { get; }
    protected abstract string RotorMap { get; }

    public char Convert(char value, bool isGoing) => Alphabet.GetCharBy(
        isGoing
            ? Alphabet.GetIndexBy(RotorMap[Alphabet.GetIndexBy(value, CurrentChar - 65)])
            : RotorMap.IndexOf(Alphabet.GetCharBy(Alphabet.GetIndexBy(value, CurrentChar - 65))),
        CurrentChar - 65);

    public void SpinBackward() => CurrentChar = (char)(CurrentChar - 1 < 65 ? 90 : CurrentChar - 1);

    public void SpinForward() => CurrentChar = (char)(CurrentChar + 1 > 90 ? 65 : CurrentChar + 1);
}