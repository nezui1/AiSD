import java.util.Arrays;

public class SortSelection {
    public static void main(String[] args) {
        int[] x = {9,3,2,4,6,8,1,5,7,22};
        System.out.println("Массив до сортировки\n");
        System.out.println(Arrays.toString(x));
        SelectionSort(x);
        System.out.println("\nМассив после сортировки\n");
        System.out.println(Arrays.toString(x));
    }

    public static void SelectionSort(int[] x){
        for(int i = 0; i < x.length; i++) {
            int locMin = i;
            for (int j = i + 1; j < x.length; j++) {
                if(x[locMin] > x[j]){
                    locMin = j;
                }
            }
            int temp = x[locMin];
            x[locMin] = x[i];
            x[i] = temp;
        }
    }
}
