public static class Arrays
{
    public static double[] MultiplesOf(double number, int length)
    {
        // Plan:
        // 1. Create an array with 'length' slots.
        // 2. Loop through each index from 0 to length - 1.
        // 3. Store the appropriate multiple of 'number' in each slot.
        // 4. Return the finished array.

        double[] result = new double[length];

        // fill the array here
        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }

        return result;
    }

    public static void RotateListRight(List<int> data, int amount)
    {
        // Plan:
        // 1. Find the index where the list should split.
        // 2. Copy the last section into a temporary list.
        // 3. Copy the first section into another temporary list.
        // 4. Clear the original list.
        // 5. Add the last section first, then the first section.

        int splitIndex = data.Count - amount;

        // build temporary lists here
        List<int> end = data.GetRange(splitIndex, amount);
        List<int> beginning = data.GetRange(0, splitIndex);

        // clear and rebuild data here
        data.Clear();
        data.AddRange(end);
        data.AddRange(beginning);
    }
}