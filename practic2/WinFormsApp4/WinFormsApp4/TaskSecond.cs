public class TaskSecond
{
    private List<int[]> steps = new List<int[]>();

    public void Sort(int[] array)
    {
        if (array.Length <= 1)
            return;

        int[] tempArray = new int[array.Length];
        MergeSortRecursive(array, tempArray, 0, array.Length - 1);
    }

    private void MergeSortRecursive(int[] array, int[] tempArray, int leftStart, int rightEnd)
    {
        if (leftStart >= rightEnd)
            return;

        int middle = (leftStart + rightEnd) / 2;
        MergeSortRecursive(array, tempArray, leftStart, middle);
        MergeSortRecursive(array, tempArray, middle + 1, rightEnd);
        Merge(array, tempArray, leftStart, rightEnd);
    }

    private void Merge(int[] array, int[] tempArray, int leftStart, int rightEnd)
    {
        int leftEnd = (leftStart + rightEnd) / 2;
        int rightStart = leftEnd + 1;
        int size = rightEnd - leftStart + 1;

        int left = leftStart;
        int right = rightStart;
        int index = leftStart;

        while (left <= leftEnd && right <= rightEnd)
        {
            if (array[left] <= array[right])
            {
                tempArray[index] = array[left];
                left++;
            }
            else
            {
                tempArray[index] = array[right];
                right++;
            }
            index++;
        }

        Array.Copy(array, left, tempArray, index, leftEnd - left + 1);
        Array.Copy(array, right, tempArray, index, rightEnd - right + 1);
        Array.Copy(tempArray, leftStart, array, leftStart, size);

        int[] step = new int[size];
        Array.Copy(array, leftStart, step, 0, size);
        steps.Add(step);
    }

    public List<int[]> GetSortingSteps()
    {
        return steps;
    }
}
