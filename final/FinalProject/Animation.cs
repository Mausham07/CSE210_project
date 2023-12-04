using System;
using System.Threading;

// Class providing a spinning animation in the console.
public class Spinner
{
    // Array of characters used for the spinning animation.
    private readonly char[] _spinnerChars;

    // Number of iterations for the spinning animation.
    private readonly int _iterations;

    // Delay between iterations to control the speed of the spinning animation.
    private readonly int _delay;

    // Constructor to initialize the spinner with specific characters, iterations, and delay.
    public Spinner(char[] spinnerChars, int iterations, int delay)
    {
        _spinnerChars = spinnerChars;
        _iterations = iterations;
        _delay = delay;
    }

    // Method to perform the spinning animation.
    public void Spin()
    {
        for (int i = 0; i < _iterations; i++)
        {
            // Display the next character in the spinner sequence
            Console.Write(_spinnerChars[i % _spinnerChars.Length]);

            // Pause to create the spinning effect
            Thread.Sleep(_delay);

            // Move the cursor back to overwrite the previously displayed character
            Console.Write('\b');
        }
    }
}
