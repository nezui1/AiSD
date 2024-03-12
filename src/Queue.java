public class Queue<T> {
    private T[] data;
    private int front; // Индекс начала очереди
    private int rear; // Индекс конца очереди
    private int size; // Максимальный размер очереди

    public Queue(int capacity) {
        data = (T[]) new Object[capacity];
        front = 0;
        rear = 0;
        size = 0;
    }

    public boolean isEmpty() {
        return size == 0;
    }

    public boolean isFull() {
        return size == data.length;
    }

    public void enqueue(T item) {
        if (isFull()) {
            throw new IllegalStateException("Queue is full");
        }
        data[rear] = item;
        rear = (rear + 1) % data.length;
        size++;
    }

    public T dequeue() {
        if (isEmpty()) {
            throw new IllegalStateException("Queue is empty");
        }
        T item = data[front];
        front = (front + 1) % data.length;
        size--;
        return item;
    }

    public T peek() {
        if (isEmpty()) {
            throw new IllegalStateException("Queue is empty");
        }
        return data[front];
    }

    public int size() {
        return size;
    }
}
