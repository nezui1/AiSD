import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.Optional;


public class MyForm {


    public JFrame newWindow;

    public JTextField namePanel, yearOfCreationPanel, numberPanel, newNamePanel, newNumberPanel, newYearOfCreationPanel,searchText;

    public JPanel panelInf;

    Font font1,font2;

    static ObjectList objList = new ObjectList();
    AddObj aObj = new AddObj();

    EdObj edObj = new EdObj();

    Search src = new Search();



    public static void main(String[] args) {
        new MyForm();



    }

    public MyForm() {
        createUI();
        createFont();

    }
    public void createFont(){
        font1 = new Font("DAMN",Font.BOLD, 32);
        font2= new Font("DAMN",Font.BOLD, 15);
    }


    public void createUI() {

        JFrame window = new JFrame();
        window.setSize(800, 500);
        window.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        window.getContentPane().setBackground(Color.WHITE);
        window.setLayout(null);


        JPanel button = new JPanel();
        button.setBounds(0, 0, 800, 50);
        button.setBackground(Color.WHITE);
        window.add(button);

        JPanel aSearch = new JPanel();
        aSearch.setBounds(0, 50, 800, 50);
        aSearch.setBackground(Color.WHITE);
        window.add(aSearch);


        JButton addObj = new JButton("Добавить");
        addObj.setBackground(Color.WHITE);
        addObj.setPreferredSize(new Dimension(100, 30));
        addObj.addActionListener(aObj);
        button.add(addObj);

        JButton search = new JButton("Поиск");
        search.setBackground(Color.WHITE);
        search.setPreferredSize(new Dimension(100, 30));
        search.addActionListener(src);
        aSearch.add(search);

        searchText = new JTextField("Поиск по номеру");
        searchText.setBackground(Color.WHITE);
        searchText.setPreferredSize(new Dimension(120, 30));
        aSearch.add(searchText);

        namePanel = new JTextField("Имя");
        namePanel.setBackground(Color.WHITE);
        namePanel.setPreferredSize(new Dimension(100, 30));
        button.add(namePanel);

        yearOfCreationPanel = new JTextField("Год создания");
        yearOfCreationPanel.setBackground(Color.WHITE);
        yearOfCreationPanel.setPreferredSize(new Dimension(100, 30));
        button.add(yearOfCreationPanel);

        numberPanel = new JTextField("Номер");
        numberPanel.setBackground(Color.WHITE);
        numberPanel.setPreferredSize(new Dimension(100, 30));
        button.add(numberPanel);


        panelInf = new JPanel();
        panelInf.setBounds(0, 100, 800, 400);
        panelInf.setBackground(Color.GRAY);
        window.add(panelInf);


        window.setVisible(true);
    }

    public void createNewUI(MyObject obj) {
        newWindow = new JFrame("Изменить");
        newWindow.setSize(400, 100);
        newWindow.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        newWindow.getContentPane().setBackground(Color.WHITE);
        newWindow.setLayout(new FlowLayout()); // Используйте менеджер компоновки


        newNamePanel = new JTextField(obj.getName());
        newNamePanel.setBackground(Color.WHITE);
        newNamePanel.setPreferredSize(new Dimension(90, 30));
        newWindow.add(newNamePanel); // Добавьте панель на окно

        newNumberPanel = new JTextField(Integer.toString(obj.getNumber()));
        newNumberPanel.setBackground(Color.WHITE);
        newNumberPanel.setPreferredSize(new Dimension(90, 30));
        newWindow.add(newNumberPanel); // Добавьте панель на окно

        newYearOfCreationPanel = new JTextField(obj.getYearOfCreation());
        newYearOfCreationPanel.setBackground(Color.WHITE);
        newYearOfCreationPanel.setPreferredSize(new Dimension(90, 30));
        newWindow.add(newYearOfCreationPanel); // Добавьте панель на окно

        JButton edditObj = new JButton("Изменить");
        edditObj.setBackground(Color.WHITE);
        edditObj.setPreferredSize(new Dimension(90, 30));
        edditObj.addActionListener(edObj);
        newWindow.add(edditObj);

        newWindow.setVisible(true);
    }

    private void updatePanelInf() {
        panelInf.removeAll();
        for (MyObject obj : objList.getObjList()) {
            JLabel label = new JLabel("Number: " + obj.getNumber() +
                    ", Name: " + obj.getName() +
                    ", Year of Creation: " + obj.getYearOfCreation());
            label.setFont(font2);
            panelInf.add(label);

            // Создайте кнопку удаления для каждого объекта
            JButton deleteButton = new JButton("Удалить");
            deleteButton.addActionListener(new ActionListener() {
                @Override
                public void actionPerformed(ActionEvent e) {
                    objList.remObj(obj);
                    updatePanelInf();
                }
            });
            panelInf.add(deleteButton);

            JButton editButton = new JButton("Изменить");
            editButton.addActionListener(new ActionListener() {
                @Override
                public void actionPerformed(ActionEvent e) {
                    objList.edObj(obj);

                    createNewUI(obj);

                    updatePanelInf();
                }
            });
            panelInf.add(editButton);
        }
        panelInf.revalidate();
        panelInf.repaint();
    }

    public class AddObj implements ActionListener {
        @Override
        public void actionPerformed(ActionEvent e) {
            String name = namePanel.getText();
            String yearOfCreation = yearOfCreationPanel.getText();
            String numberInput = numberPanel.getText();

            try {
                int number = Integer.parseInt(numberInput);
                MyObject myObject = new MyObject(name, yearOfCreation, number);
                if (number == (int) number) {
                    objList.addObj(myObject);
                    updatePanelInf();

                } else {
                    JOptionPane.showMessageDialog(null, "Ошибка при вводе данных");
                }
            } catch (NumberFormatException ex) {
                JOptionPane.showMessageDialog(null, "Ошибка при вводе данных");
            }
        }
    }

    public class EdObj implements ActionListener {
        @Override
        public void actionPerformed(ActionEvent e) {
            String name = newNamePanel.getText();
            String yearOfCreation = newYearOfCreationPanel.getText();
            String numberInput = newNumberPanel.getText();

            try {
                int number = Integer.parseInt(numberInput);
                MyObject myObject = new MyObject(name, yearOfCreation, number);
                if (number == (int) number) {
                    objList.eAddObj(myObject);
                    updatePanelInf();
                    newWindow.dispose();
                } else {
                    JOptionPane.showMessageDialog(null, "Ошибка при вводе данных");
                }
            } catch (NumberFormatException ex) {
                JOptionPane.showMessageDialog(null, "Ошибка при вводе данных");
            }


        }
    }

    public class Search implements ActionListener {
        @Override
        public void actionPerformed(ActionEvent e) {
            String numberInput = searchText.getText();

            try {
                int number = Integer.parseInt(numberInput);
                if (number == (int) number) {
                    for (MyObject obj : objList.getObjList()) {
                        Optional<MyObject> foundObject = objList.getObjList().stream()
                                .filter(myObj -> myObj.getNumber() == number)
                                .findFirst();

                        if (foundObject.isPresent()) {
                            MyObject myObject = foundObject.get();
                            JOptionPane.showMessageDialog(null,"\tНайден объект \nИмя: " + myObject.getName() + "\nГод создания: " + myObject.getYearOfCreation());
                            break;
                        } else {
                            JOptionPane.showMessageDialog(null,"Объект не найден.");
                        }
                    }
                } else {
                    JOptionPane.showMessageDialog(null, "Ошибка при вводе данных");
                }
            } catch (NumberFormatException ex) {
                JOptionPane.showMessageDialog(null, "Ошибка при вводе данных");
            }
        }
    }


}


