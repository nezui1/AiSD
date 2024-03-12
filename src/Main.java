public class Main {
    public static void main(String[] args) {
        Queue<String> queue = new Queue<>();
        queue.enqueue("AMD M4");
        queue.enqueue("NVIDIA 4090 super");
        queue.enqueue("БАЙКАЛ");
        queue.enqueue("2x Crucial 16 gb 3600 hz");


        while (!queue.isEmpty()) {
            System.out.println(queue.dequeue());
        }
    }
}