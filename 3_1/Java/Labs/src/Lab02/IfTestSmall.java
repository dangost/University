package Lab02;
import java.util.Scanner;
/**
 * Ввод данных с консоли с использование Scanner.
 * условные конструкции
 * @author Kreydich E. M.
 * @version 1.1
 */

public class IfTestSmall {
    public static void main(String[] args){
        Scanner input = new Scanner(System.in);

        System.out.println("Введите целое число х:");
        int x=input.nextInt();

        System.out.println("Введите целое число y:");
        int y=input.nextInt();

        if(x>y)
            System.out.println("х больше у");

        if(x>y){
            System.out.println("х больше у");
            System.out.println("х-у= "+ (x-y));
        }

        if(x>y){
            System.out.println("х больше у");
            System.out.println("х-у= "+ (x-y));
        }else {
            System.out.println("х меньше или равно у");
        }
    }
}
