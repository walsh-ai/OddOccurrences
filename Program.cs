using System.Collections.Generic;

// top level tests 
int[] array = {9, 3, 9, 3, 7, 8, 8}; 

// Print tests 
Console.WriteLine("Odd array: {9, 3, 9, 7, 8, 8}");
Console.WriteLine($"Result with slow solution: {FindOdd_slow(array)}");
Console.WriteLine($"Result with fast solution: {FindOdd_fast(array)}"); 

public static partial class Program {
    /// <summary>
    /// Find the unpaired element in an array with a hashset. 
    /// For each unseen element, add a key-pair in the hashet 
    /// For each seen existing element, remove the key-pair.
    /// Having iterated the elements, only the unpaired element will remain. 
    /// </summary>
    /// <returns></returns>
    public static int FindOdd_slow(int[] arr) {
        HashSet<int> occurrences = new HashSet<int>(); 

        for (int i = 0; i < arr.Length; i++) {
            if (occurrences.Contains(arr[i]))
                occurrences.Remove(arr[i]);
            else 
                occurrences.Add(arr[i]); 
        }

        // Print the final element 
        foreach (int i in occurrences) {
            return i; 
        }

        return 0; 
    }

    /// <summary>
    /// Find the unpaired element using bitwise operations 
    /// Maintain a value, starting at zero, updated with XOR on each element 
    /// Duplicated (paired) elements will cancel out, only the 
    /// value of the unpaired element will remain 
    /// 0 XOR a = a 
    /// (a XOR b) XOR a = b
    /// (a XOR b) XOR b = a
    /// </summary>
    /// <returns></returns>
    public static int FindOdd_fast(int[] arr) {
        int result = 0; 

        for (int i = 0; i < arr.Length; i++) 
            result ^= arr[i];

        return result;
    }
}