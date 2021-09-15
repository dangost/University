package Lab02;
import java.util.Scanner;

public class Grade {
    public static void main(String[] args){
        Scanner input =new Scanner(System.in);
        int number = input.nextInt();
        number/=10;
        switch (number){
            case 10:
                System.out.println("Ваш рейтин А");
                break;
            case 9:
                System.out.println("Ваш рейтин А");
                break;
            case 8:
                System.out.println("Ваш рейтин B");
                break;
            case 7:
                System.out.println("Ваш рейтин C");
                break;
            case 6:
                System.out.println("Ваш рейтин D");
                break;
            default:
                System.out.println("Ваш рейтин F");
        }
    }
}
