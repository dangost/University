package Lab02;
import java.util.Scanner;

public class Rating {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        System.out.println("Введите бал:");
        int number = input.nextInt();

        if(number>=90){
            System.out.println("Ваш рейтинг А");
        } else if(number>=80 && number<90){
            System.out.println("Ваш рейтинг B");
        }else if(number>=70 && number<80){
            System.out.println("Ваш рейтинг C");
        }else  if (number>=60 && number<70){
            System.out.println("Ваш рейтинг D");
        } else {
            System.out.println("Ваш рейтинг F");
        }
    }
}
