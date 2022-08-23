def heapify(arr, n, i):
	
	# largest among root and child	

	largest = i
	left = 2 * i + 1
	right = 2 * i + 2

	if left < n and arr[i] < arr[left]:
		largest = left

	if right < n and arr[i] < arr [right]:
		largest = right
	
	# if root is not largest, swap with largest and continue heapifying
	
	if largest != i:
		arr[i], arr[largest] = arr[largest], arr[i]
		heapify(arr, n, largest)

def heapSort(arr):
	n = len(arr)

	# build max heap

	for i in range(n//2, -1, -1):
		heapify(arr, n, i)

	for i in range(n-1, 0, n-1):
		# swap
		arr[i], arr[0] = arr[0], arr[i]

		# hepify root element
		heapify(arr, i, 0)

arr = [1, 2, 24, 46, 57, 88, 102]
heapSort(arr)
n = len(arr)
print("Sorted array")
for i in range (n):
	print("%d " % arr[i], end = '')
