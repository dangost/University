package Lab01;
import java.util.Scanner;

public class ConsoleInput {
    public static void main(String[] args){
        Scanner input = new Scanner(System.in);
        System.out.println("Enter a number for radius: ");
        double radius=input.nextDouble();
        double length=2*3.14159*radius;
        System.out.println("The length for the circle of radius "+radius+
                " is "+length);

        System.out.println("Input double:\n");
        double DValue=input.nextDouble();

        System.out.println("Input int:\n");
        int IValue = input.nextInt();

        System.out.println("Input float:\n");
        float FValue = input.nextFloat();

        System.out.println("Input string:\n");
        String SValue = input.next();

        System.out.println("Input bool:\n");
        boolean BValue = input.nextBoolean();
        System.out.println("DValue = "+DValue+" IValue = "+IValue+
                " FValue = "+FValue+" SValue = "+SValue+" BValue = "+BValue);

    }
}
