import java.lang.reflect.Array;
import java.util.Arrays;
import java.util.HashSet;
import java.util.Set;

public class AlgoritmDeikstri {

    private static final int INFINITY = Integer.MAX_VALUE;

    public static void main(String[] args) {


        int[][] graph = {
                {0,1,2},
                {1,0,3},
                {2,3,0}
        };

        int start = 0;

        int[] distance = new int[graph.length];

        Arrays.fill(distance,INFINITY);

        distance[start] = 0;

        Set<Integer> node = new HashSet<>();
        node.add(start);

        while (!node.isEmpty()) {
            int currentNode = getClosestNode(distance, node);
            node.remove(currentNode);

            for (int next = 0; next < graph.length; next++) {
                if (graph[currentNode][next] != 0) {
                    int newDistance = distance[currentNode] + graph[currentNode][next];
                    if (newDistance < distance[next]) {
                        distance[next] = newDistance;
                        node.add(next);
                    }
                }
            }
        }

        // Выводим результаты
        for (int i = 0; i < graph.length; i++) {
            System.out.println("Самый короткий путь из вершины " + start + " в вершину " + i + ": " + distance[i]);
        }
    }

    private static int getClosestNode(int[] distances, Set<Integer> unsettledNodes) {
        int minDistance = INFINITY;
        int closestNode = -1;
        for (int node : unsettledNodes) {
            if (distances[node] < minDistance) {
                minDistance = distances[node];
                closestNode = node;
            }
        }
        return closestNode;
    }
}
