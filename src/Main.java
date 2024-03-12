public class Main {
    public static void main(String[] args) {
        Queue<String> computerComponentsQueue = new Queue<>(10);
        computerComponentsQueue.enqueue("CPU");
        computerComponentsQueue.enqueue("RAM");
        computerComponentsQueue.enqueue("GPU");

        System.out.println("Dequeued item: " + computerComponentsQueue.dequeue());
        System.out.println("Peeked item: " + computerComponentsQueue.peek());
        System.out.println("Queue size: " + computerComponentsQueue.size());
    }
}