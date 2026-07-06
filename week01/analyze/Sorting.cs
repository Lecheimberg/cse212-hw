public static class Sorting
{
    public static void Run()
    {
        int[] numbers = { 3, 2, 1, 6, 4, 9, 8 };

        // Sort the array from smallest to largest
        SortArray(numbers);

        // Print the sorted array
        Console.WriteLine($"int[]{{{string.Join(", ", numbers)}}}");
    }

    // I'm using the bubble sort algorithm.
    // It compares neighboring numbers and swaps them if they are in the wrong order.
    // Because it uses two loops, the running time is O(n²).
    private static void SortArray(int[] data)
    {
        for (int sortPos = data.Length - 1; sortPos > 0; sortPos--)
        {
            for (int swapPos = 0; swapPos < sortPos; swapPos++)
            {
                if (data[swapPos] > data[swapPos + 1])
                {
                    (data[swapPos], data[swapPos + 1]) =
                        (data[swapPos + 1], data[swapPos]);
                }
            }
        }
    }
}