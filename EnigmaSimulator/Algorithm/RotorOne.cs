namespace EnigmaSimulator.Algorithm;

public sealed class RotorOne(char startingChar) : Rotor(startingChar)
{
    public override char SpinNextRotorCharForward => 'R';
    protected override string RotorMap => "EKMFLGDQVZNTOWYHXUSPAIBRCJ";
}