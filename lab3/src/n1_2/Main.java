package n1_2;

public class Main {
    public static void main(String[] args) {

        Tree tree = new Tree();

        tree.add(10);
        tree.add(5);
        tree.add(8);
        tree.add(7);
        tree.add(4);

        tree.printPreOrder();



        if (tree.containsNode(4)){
            System.out.println("\nТакой элемент есть");

        }
        else System.out.println("\nТакого элемента нет");

        tree.WidthTraversal();
    }
}
