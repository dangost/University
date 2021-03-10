package program.app.program.models;

public class Person {
    // Ф.И.О. студента, номер группы, основной
    //вид деятельности, увлечения и главный жизненный лозунг

    public Person(String Surname, String Name, Integer Group, String MainLifeLyric) {
        this.surname = Surname;
        this.name = Name;
        this.group = Group;
        this.mainLifeLyric = MainLifeLyric;
    }

    public String surname;

    public String name;

    public Integer group;

    public String mainLifeLyric;

//    @Override
//    public String toString()
//    {
//        return this.name + "\t" + this.surname +  "\t" + this.group.toString() + "\t" + this.mainLifeLyric;
//    }

}
