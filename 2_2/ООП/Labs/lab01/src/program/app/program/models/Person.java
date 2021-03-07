package program.app.program.models;

public class Person {
    // Ф.И.О. студента, номер группы, основной
    //вид деятельности, увлечения и главный жизненный лозунг

    public Person(String surname, String name, Integer group, String mainLifeLyric) {
        this.Surname = surname;
        this.Name = name;
        this.Group = group;
        this.MainLifeLyric = mainLifeLyric;
    }

    public String Surname;

    public String Name;

    public Integer Group;

    public String MainLifeLyric;

    public String ToString()
    {
        return this.Name + "\t" + this.Surname + "\t" + this.Name + "\t" + this.Group.toString() + "\t" + this.MainLifeLyric;
    }

}
