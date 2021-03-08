package program.app;

import program.app.program.models.Person;

public class Main {
    public static void main(String[] args)
    {
        Person person = new Person("Snow", "John", 10702119,
                "It's a strange kind of courage to admit your cowardice.");

        System.out.println(person.toString());
    }
}
