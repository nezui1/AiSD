import java.util.LinkedList;

class HashTable<K, V> {
    private final int arraySize;
    private final LinkedList<Pair<K, V>>[] table;

    public HashTable(int size) {
        arraySize = size;
        table = new LinkedList[arraySize];
        for (int i = 0; i < arraySize; i++) {
            table[i] = new LinkedList<>();
        }
    }

    public void put(K key, V value) {
        int index = hash(key);
        table[index].add(new Pair<>(key, value));
    }

    public V get(K key) {
        int index = hash(key);
        for (Pair<K, V> pair : table[index]) {
            if (pair.getKey().equals(key)) {
                return pair.getValue();
            }
        }
        return null;
    }

    public void remove(K key) {
        int index = hash(key);
        table[index].removeIf(pair -> pair.getKey().equals(key));
    }

    private int hash(K key) {
        return key.hashCode() % arraySize;
    }

    private static class Pair<K, V> {
        private final K key;
        private final V value;

        public Pair(K key, V value) {
            this.key = key;
            this.value = value;
        }

        public K getKey() {
            return key;
        }

        public V getValue() {
            return value;
        }
    }
}
