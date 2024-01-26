using System;

class NicotineTestingAlgorithm
{
    static void Main(string[] args)
    {
        // Simulate a urine sample test
        double nicotineLevel = GetNicotineLevel(); // Get nicotine level from the sample

        // Check nicotine level against threshold
        double threshold = 50; // Example threshold for nicotine level (ng/mL)

        if (nicotineLevel > threshold)
        {
            Console.WriteLine("Nicotine Detected in the Urine Sample!");
            Console.WriteLine($"Nicotine Level: {nicotineLevel} ng/mL");
            Console.WriteLine("Possible tobacco or nicotine product usage.");
        }
        else
        {
            Console.WriteLine("Nicotine level is within normal range.");
        }
    }

    static double GetNicotineLevel()
    {
        // Simulate obtaining nicotine level from the urine sample
        // In a real-world scenario, this data would be obtained from laboratory analysis or testing equipment.
        Random random = new Random();
        double nicotineLevel = random.Next(0, 100); // Simulate nicotine level (ng/mL)
        return nicotineLevel;
    }
}
