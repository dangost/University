package Lab02;
import java.util.Scanner;

public class MathPro {
    public static void main(String[] args){
        Scanner input=new Scanner(System.in);
        int a=input.nextInt();
        int b=input.nextInt();
        int c=input.nextInt();

        double D=Math.pow(b,2)-4*a*c;
        double x1=(-b+Math.sqrt(D))/2*a;
        double x2=(-b-Math.sqrt(D))/2*a;
        System.out.println("a= "+a+" b= "+b+" c= "+c+"\nx1= "+x1+"\nx2= "+x2);
    }
}