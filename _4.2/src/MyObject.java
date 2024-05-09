public class MyObject {

    private String name;

    private String yearOfCreation;

    private Integer number;

    public MyObject(String name, String yearOfCreation, int number){
        this.number = number;
        this.name = name;
        this.yearOfCreation = yearOfCreation;
    }

    public Integer getNumber(){
        return number;
    }

    public String getName(){
        return name;
    }

    public String getYearOfCreation(){
        return yearOfCreation;
    }

}
