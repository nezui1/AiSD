public class Main {
    public static void main(String[] args) {
        SelectionSort r = new SelectionSort();
        int[] arr = {1, 8, 7, 9, 10, 12, -3, 6};

        r.sort(arr);

        for (int i = 0; i < arr.length; i++) {
            System.out.println(arr[i]);
        }
    }
}
