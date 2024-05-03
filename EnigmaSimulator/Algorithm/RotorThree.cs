namespace EnigmaSimulator.Algorithm;

public sealed class RotorThree(char startingChar) : Rotor(startingChar)
{
    public override char SpinNextRotorCharForward => 'W';
    protected override string RotorMap => "BDFHJLCPRTXVZNYEIWGAKMUSQO";
}