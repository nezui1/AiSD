import java.util.Arrays;
public class Queue<T> {
    private T[] arr;// Массив
    private int front;// Начало очереди
    private int rear;// Место в очереди
    private int size;// размер массива

    //Конструктор
    public Queue(int k){
        arr = (T[]) new Object[k];
        int front = 0;
        int rear = 0;
        int size = 0;
    }
    //Добавление элемента в очередь
    public  void eQ(T elem){
        newArray();
        arr[rear] = elem;
        rear++;
        size++;

    }
    // вывод первого элемента очереди
    public T dQ(){
        if (isEmpty()) throw new IllegalStateException("Очередь пустая");
        T firstElem = arr[front];
        front++;
        size--;
        return firstElem;
    }

    public boolean isEmpty(){
        return size == 0;
    }

    public void newArray(){
        if(size == arr.length){
            int newSize = arr.length * 2;
            arr = Arrays.copyOf(arr, newSize);
        }
    }

    public int size(){
        return size;
    }

    public T peek(){
        return arr[front];

    }

}
