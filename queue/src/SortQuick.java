import java.util.Arrays;


public class SortQuick {
    public static void main(String[] args) {
        int[] x = {9,3,2,4,6,8,1,5,7,22};
        System.out.println("Массив до сортировки\n");
        System.out.println(Arrays.toString(x));
        QuickSort(x,0, x.length-1);
        System.out.println("\nМассив после сортировки\n");
        System.out.println(Arrays.toString(x));
    }
    public static void QuickSort(int[] x, int left, int right){
        if (left > right) return;
        int center = x[(left + right)/2];
        int i = left;
        int j = right;
        while(i <= j){
            while(center > x[i]) i++;
            while(center < x[j]) j--;
            if (i<=j){
                int temp = x[j];
                x[j] = x[i];
                x[i] = temp;
                i++;
                j--;
        }
        }
        QuickSort(x, left, j);
        QuickSort(x, i, right);
    }
}
