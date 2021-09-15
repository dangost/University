package Lab01;
import java.util.Scanner;

public class ConditionalOperators {
    public static void main(String[] args){
        int x = 1;
        int y = 3;

        if(x > y)
            y = 1;
        else y =- 1;

        System.out.println("Первый вариант x= "+x+" y= "+y);

        y=(x > 0)?1:-1;
        System.out.println("Первый вариант x= "+x+" y= "+y);

        int number =3;
        System.out.println(number%2 == 0? "четное" : "нечетное");

        double num1 = 3.4, num2 = 8.24;
        double max= (num1>num2)? num1:num2;
        System.out.println("Наибольшее = "+max);

        Scanner input =new Scanner(System.in);
        System.out.println("Первое число:");
        int value1=input.nextInt();
        System.out.println("Второе число:");
        int value2=input.nextInt();
        int min=0;
        if(value1<value2) {
            min = value1;
        }
        else min=value2;

        System.out.println("min = "+min);
    }
}
