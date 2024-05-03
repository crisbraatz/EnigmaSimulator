namespace EnigmaSimulator.Algorithm;

public class Plugboard(string mapB)
{
    private static string MapA => "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    private string MapB { get; } = mapB;

    public char Convert(char value, bool isGoing) => isGoing
        ? MapB[MapA.IndexOf(value)]
        : MapA[MapB.IndexOf(value)];
}