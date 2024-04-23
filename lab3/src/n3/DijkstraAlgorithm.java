package n3;
import java.util.*;

public class DijkstraAlgorithm {
    private static final int INFINITY = Integer.MAX_VALUE;

    public static void main(String[] args) {
        // Пример графа с весами рёбер
        int[][] graph = {
                {0, 10, 0, 0, 0},
                {10, 0, 5, 0, 0},
                {0, 5, 0, 15, 20},
                {0, 0, 15, 0, 5},
                {0, 0, 20, 5, 0}
        };

        int start = 0; // Начальная вершина

        int[] distances = new int[graph.length];
        Arrays.fill(distances, INFINITY);
        distances[start] = 0;

        Set<Integer> unsettledNodes = new HashSet<>();
        unsettledNodes.add(start);

        while (!unsettledNodes.isEmpty()) {
            int currentNode = getClosestNode(distances, unsettledNodes);
            unsettledNodes.remove(currentNode);

            for (int next = 0; next < graph.length; next++) {
                if (graph[currentNode][next] != 0) {
                    int newDistance = distances[currentNode] + graph[currentNode][next];
                    if (newDistance < distances[next]) {
                        distances[next] = newDistance;
                        unsettledNodes.add(next);
                    }
                }
            }
        }

        // Выводим результаты
        for (int i = 0; i < graph.length; i++) {
            System.out.println("Самый короткий путь из вершины " + start + " в вершину " + i + ": " + distances[i]);
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