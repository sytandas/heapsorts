using System;
public class HeapSort {
	public void sort(int[] arr)
	{
		int n = arr.Length;

		// Build heap (rearrange array)
		for (int i = n / 2 - 1; i >= 0; i--)
			heapify(arr, n, i);

		// One by one extract an element from heap
		for (int i = n - 1; i > 0; i--) {
			// Move current root to end
			int temp = arr[0];
			arr[0] = arr[i];
			arr[i] = temp;

			// call max heapify on the reduced heap
			heapify(arr, i, 0);
		}
	}

	void heapify(int[] arr, int n, int i)
	{
		int largest = i; 
		int l = 2 * i + 1; 
		int r = 2 * i + 2; 

		// If left child is larger than root
		if (l < n && arr[l] > arr[largest])
			largest = l;

		// If right child is larger than largest so far
		if (r < n && arr[r] > arr[largest])
			largest = r;

		// If largest is not root
		if (largest != i) {
			int swap = arr[i];
			arr[i] = arr[largest];
			arr[largest] = swap;

			// Recursively heapify 
			heapify(arr, n, largest);
		}
	}

	static void printArray(int[] arr)
	{
		int n = arr.Length;
		for (int i = 0; i < n; ++i)
			Console.Write(arr[i] + " ");
		Console.Read();
	}

	public static void Main()
	{
		int[] arr = { 1, 2, 24, 46, 57, 88, 102 };
		int n = arr.Length;

		HeapSort ob = new HeapSort();
		ob.sort(arr);

		Console.WriteLine("Sorted array");
		printArray(arr);
	}
}

