public class MyLinkedList {
    Node head;

    static class Node{
        int data;

        Node next;

        Node(int d){
            data = d;
        }
    }

    public static MyLinkedList insert(MyLinkedList list,
                                    int data)
    {

        Node newNode = new Node(data);
        newNode.next = null;


        if (list.head == null) {
            list.head = newNode;
        }
        else {
            Node last = list.head;

            while (last.next != null) {
                last = last.next;
            }

            last.next = newNode;
        }


        return list;
    }

    public static MyLinkedList
    deleteAtPosition(MyLinkedList list, int index)
    {

        Node curNode = list.head, prev = null;



        if (index == 0 && curNode != null) {
            list.head = curNode.next;
            return list;
        }


        int counter = 0;


        while (curNode != null) {

            if (counter == index) {

                prev.next = curNode.next;


                break;
            }
            else {

                prev = curNode;
                curNode = curNode.next;
                counter++;
            }
        }


        if (curNode == null) {

            System.out.println(
                    index + " position element not found");
        }


        return list;
    }

    public  void printList(MyLinkedList list)
    {
        Node currNode = list.head;

        System.out.print("\nLinkedList: ");


        while (currNode != null) {

            System.out.print(currNode.data + " ");

            currNode = currNode.next;
        }
        System.out.println("\n");
    }
    public  MyLinkedList search(MyLinkedList list, int data){

        Node curNode = list.head;
        Node prev = null;
        boolean search = false;

        if(curNode.data == data){
            System.out.println("Элемент со значением " + data + " есть в списке");
            search = true;
        }

        while ((curNode != null)){
            if(curNode.data == data){
                System.out.println("Элемент со значением " + data + " есть в списке");
                search = true;
                break;
            }
            else{
                prev = curNode;
                curNode = curNode.next;

            }
        }
        if(!search){
            System.out.println("Элемента со значением " + data + " нет в списке");
        }
        return list;
    }


}
