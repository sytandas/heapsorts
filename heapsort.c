#include<stdio.h>
// swap function
void swap(int *a, int *b){
	int temp;
	temp = *a;
	*a = *b;
	*b = temp;
}

void heapify(int arr[], int n, int i){
	
	// find largest among root, left child and right child
	int largest = i; // root
	int left = 2 * i + 1;
	int right = 2 * i + 2;

	if (left < n && arr[left] > arr[largest])
		largest = left;

	if (right < n && arr[right] > arr[largest])
		largest = right; 

	// swap continiues if root is not largest 

	if (largest != i) {
	swap (&arr[i], &arr[largest]);
	heapify (arr, n, largest);
	}
}
// do heapsort

void heapSort(int arr[], int n){

	// building max heap
	for (int i = (n / 2) - 1; i >= 0; i--)
		heapify(arr, n, i);

	// HeapSort
	for (int i = n -1; i >= 0; i--){
		swap(&arr[0], &arr[i]);
		
		// heapify root element to get highest element at root again 
		heapify(arr, i, 0);
	}
}

// print array 

void printArray(int arr[], int n){
	for (int i = 0; i < n; ++i)
		printf("%d ", arr[i]);
	printf("\n");
}

// main function 

int main(){
	int arr[] = {1, 2, 24, 46, 57, 88, 102};
	int n = sizeof(arr) / sizeof(arr[0]);

	heapSort(arr, n);

	printf("Sorted array\n");
	printArray(arr, n);	
	return 0;
}
