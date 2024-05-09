import javax.swing.*;
import java.util.ArrayList;
import java.util.List;

public class ObjectList {

    private List<MyObject> obj;

    public ObjectList(){ obj = new ArrayList<>();}

    public void addObj(MyObject newObj) {
        boolean exists = false;
        for (MyObject existingObj : obj) {
            if (existingObj.getNumber().equals(newObj.getNumber())) {
                exists = true;
                break;
            }
        }
        if (!exists) {
            obj.add(newObj);
            JOptionPane.showMessageDialog(null,"Объект успешно добавлен.");
        } else {
            JOptionPane.showMessageDialog(null,"Объект с таким number уже существует.");
        }
    }

    public void remObj(MyObject newObj){
        boolean exists = false;
        for (MyObject existingObj : obj) {
            if (existingObj.getNumber().equals(newObj.getNumber())) {
                exists = true;
                break;
            }
        }
        if (exists) {
            obj.remove(newObj);
            JOptionPane.showMessageDialog(null,"Объект успешно удален.");
        } else {
            JOptionPane.showMessageDialog(null,"Объект с таким number не существует.");
        }
    }

    public void edObj(MyObject newObj){
        boolean exists = false;
        for (MyObject existingObj : obj) {
            if (existingObj.getNumber().equals(newObj.getNumber())) {
                exists = true;
                break;
            }
        }
        if (exists) {
            obj.remove(newObj);
        } else {
            JOptionPane.showMessageDialog(null,"Объект с таким number не существует.");
        }
    }

    public void eAddObj(MyObject newObj) {
        boolean exists = false;
        for (MyObject existingObj : obj) {
            if (existingObj.getNumber().equals(newObj.getNumber())) {
                exists = true;
                break;
            }
        }
        if (!exists) {
            obj.add(newObj);
            JOptionPane.showMessageDialog(null,"Объект успешно изменен.");
        } else {
            JOptionPane.showMessageDialog(null,"Объект с таким number уже существует.");
        }
    }

    public List<MyObject> getObjList() {
        return obj;
    }


}
