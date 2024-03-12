import java.util.ArrayList;
import java.util.Arrays;

public class Queue<T> {
    private Object[] array;
    private int front;
    private int rear;
    private int size;

    public Queue() {
        array = new Object[1];
        front = 0;
        rear = -1;
        size = 0;
    }

    public void enqueue(T element) {
        if (size == array.length) {
            resizeArray();
        }
        rear = (rear + 1) % array.length;
        array[rear] = element;
        size++;
    }

    public T dequeue() {
        if (isEmpty()) {
            throw new IllegalStateException("Queue is empty");
        }
        T element = (T) array[front];
        front = (front + 1) % array.length;
        size--;
        return element;
    }

    public boolean isEmpty() {
        return size == 0;
    }

    public int size() {
        return size;
    }

    private void resizeArray() {
        int newSize = array.length * 2;
        array = Arrays.copyOf(array, newSize);
    }
}