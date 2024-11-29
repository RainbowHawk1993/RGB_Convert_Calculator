using System;

public class ColorConversion
{
    public static int CalculateSteps(int[] colors, int targetColorIndex)
    {
        int steps = 0;
        int color1Index = (targetColorIndex + 1) % 3;
        int color2Index = (targetColorIndex + 2) % 3;
        int nonTargetColorsDifference = Math.Abs(colors[color1Index] - colors[color2Index]);
        int largerColorIndex = colors[color1Index] < colors[color2Index] ? color2Index : color1Index;
        
        if (nonTargetColorsDifference % 3 != 0 || colors[targetColorIndex] < nonTargetColorsDifference / 3) {
            return -1;
        }
        
        //equalize, I don't modify other values because those operations aren't needed to find amount of steps
        colors[largerColorIndex] -= nonTargetColorsDifference / 3;
        //steps after equalizing
        steps += nonTargetColorsDifference / 3;
        //steps to convert equalized colors to target color
        steps += colors[largerColorIndex];

        return steps; //Amount of steps will always be equal to the larger of the non-target numbers
    }

    public static void Main(string[] args)
    {
        int[] colors = { 7, 1, 9 }; // green, blue, red
        int targetColorIndex = 2; // 0 green, 1 blue, 2 red

        int steps = CalculateSteps(colors, targetColorIndex);

        if (steps == -1)
        {
            Console.WriteLine("Impossible to convert all colors to the target color.");
        }
        else
        {
            Console.WriteLine("Number of steps to convert all colors to the target color: " + steps);
        }
    }
}
