package n1_2;

import java.util.LinkedList;
import java.util.Queue;
public class Tree{
    Node root;

    // Метод для вставки новых узлов
    private Node addRecursive(Node current, int value) {
        if (current == null) {
            return new Node(value);
        }
        if (value < current.value) {
            current.left = addRecursive(current.left, value);
        } else if (value > current.value) {
            current.right = addRecursive(current.right, value);
        } else {
            // Значение уже существует
            return current;
        }
        return current;
    }
    private Node getMinimumKey(Node current) {
        while (current.left != null) {
            current = current.left;
        }
        return current;
    }

    // Метод для удаления узла
    private Node deleteRecursive(Node current, int value) {
        if (current == null) {
            return null;
        }
        if (value == current.value) {
            // Узел без потомков или с одним потомком
            if (current.left == null) {
                return current.right;
            } else if (current.right == null) {
                return current.left;
            }
            // Узел с двумя потомками
            current.value = getMinimumKey(current.right).value;
            current.right = deleteRecursive(current.right, current.value);
        } else if (value < current.value) {
            current.left = deleteRecursive(current.left, value);
        } else {
            current.right = deleteRecursive(current.right, value);
        }
        return current;
    }

    private boolean containsNodeRecursive(Node current, int value) {
        if (current == null) {
            return false;
        }
        if (value == current.value) {
            return true;
        }
        return value < current.value
                ? containsNodeRecursive(current.left, value)
                : containsNodeRecursive(current.right, value);
    }



    public boolean containsNode(int value) {
        return containsNodeRecursive(root, value);
    }

    public void delete(int value) {
        root = deleteRecursive(root, value);
    }
    public void add(int value) {
        root = addRecursive(root, value);
    }

    // Метод для вывода узлов в порядке Preorder
    public void printPreOrder() {
        printPreOrderRecursive(root);
    }

    private void printPreOrderRecursive(Node current) {
        if (current != null) {
            System.out.print(current.value + " ");
            printPreOrderRecursive(current.left);
            printPreOrderRecursive(current.right);
        }
    }

    public void WidthTraversal(){
        if (root == null) return;

        Queue<Node> queue = new LinkedList<>();
        queue.add(root);

        while(!queue.isEmpty()){
            Node current = queue.poll();
            System.out.println(current.value);

            if(current.left != null){
                queue.add(current.left);
            }
            if(current.right != null){
                queue.add(current.right);
            }
        }
    }
}