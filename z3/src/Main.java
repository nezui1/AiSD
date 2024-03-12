public class Main {
    public static void main(String[] args) {

        long time = System.currentTimeMillis();

        int[] arr = {5, 2, 4, 6, 1, 3};

        QuickSort.quickSort(arr, 0, arr.length - 1);

        for (int i = 0; i < arr.length; i++) {
            System.out.println(arr[i]);
        }

        System.out.println("Time: " + (double) (System.currentTimeMillis() - time)/1000);
    }
}