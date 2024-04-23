//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
public class Main {
    public static void main(String[] args) {
        HashTable myTable = new HashTable(10); // Создаем хэш-таблицу размером 10

        myTable.insert("Oleg", "Mangol");
        myTable.insert("Kristina", "Old");
        myTable.insert("Tamara", "Kirieshki");

        String value = myTable.get("Oleg"); // Получаем значение по ключу "banana"
        System.out.println("Значение по ключу 'Oleg': " + value);
    }
}