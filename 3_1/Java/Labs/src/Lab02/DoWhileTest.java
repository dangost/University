package Lab02;
import java.util.Scanner;


public class DoWhileTest {
    public static void main(String[] args){
        int data;
        int sum =0;
        Scanner input=new Scanner(System.in);

        do{
            System.out.println("Вводите целое значение (выход, если 0):");
            data=input.nextInt();
            sum+=data;
        }while (data!=0);
        System.out.println("Сумма введенных числе = "+sum);
    }
}
