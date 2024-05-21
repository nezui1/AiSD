public class Main {

    public static void main(String[] args) {
        MyLinkedList list = new MyLinkedList();

        list.insert(list, 4);
        list.insert(list, 3);
        list.insert(list, 2);



        list.search(list, 7);

        list.printList(list);

        list.deleteAtPosition(list, 1);

        list.printList(list);
    }
}
