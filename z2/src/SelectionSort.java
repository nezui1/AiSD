public class SelectionSort {
    public static void sort(int[] arr){
        for(int i = 0; i < arr.length; i++){
            int key = i;
            for(int j = i + 1; j < arr.length; j++){
                if(arr[j] < arr[key]) {
                    key = j;
                }
            }
            int temp = arr[i];
            arr[i] = arr[key];
            arr[key] = temp;
        }
    }
}
