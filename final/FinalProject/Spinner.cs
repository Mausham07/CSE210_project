public class Spinner
{
    private readonly char[] _spinnerChars;
    private readonly int _iterations;
    private readonly int _delay;

    public Spinner(char[] spinnerChars, int iterations, int delay)
    {
        _spinnerChars = spinnerChars;
        _iterations = iterations;
        _delay = delay;
    }

    public void Spin()
    {
        for (int i = 0; i < _iterations; i++)
        {
            Console.Write(_spinnerChars[i % _spinnerChars.Length]);
            Thread.Sleep(_delay);
            Console.Write('\b');
        }
    }
}