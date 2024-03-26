public class Main {
    public static void main(String[] args) {
        Queue<SubjectArea> q = new Queue<>(1);
        SubjectArea sub1 = new SubjectArea("Nvidia", 100);
        SubjectArea sub2 = new SubjectArea("AMD", 110);

        q.eQ(sub1);
        q.eQ(sub2);

        System.out.println(q.size());
        System.out.println(q.peek());
        System.out.println(q.dQ());
        System.out.println(q.peek());
        System.out.println(q.size());
        System.out.println(q.dQ());


    }
}