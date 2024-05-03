namespace EnigmaSimulator.Algorithm;

public sealed class RotorTwo(char startingChar) : Rotor(startingChar)
{
    public override char SpinNextRotorCharForward => 'F';
    protected override string RotorMap => "AJDKSIRUXBLHWTMCQGZNPYFVOE";
}