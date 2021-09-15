package Lab02;
import java.util.Scanner;

public class DoWhilePro {
    public static void main(String[] args){
        int number;
        int sum =0;
        int day =14,mounts=2;
        Scanner input=new Scanner(System.in);

        do{
            System.out.println("Вводите целое число (выход, если 0):");
            number=input.nextInt();
            if(number!=day && number!=mounts)
                sum+=number;
        }while (number!=0);
        System.out.println("Сумма введенных числе = "+sum);
    }
}
