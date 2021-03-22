package program.app;

import program.utils.Converter;

import java.util.Scanner;

public class Program {
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);

        System.out.println("=======Task==1=======");
        System.out.println("Input grams");

        Integer grams = in.nextInt();

        System.out.println("Kilograms: " + Converter.toKilograms(grams));
        System.out.println("Centers: " + Converter.toCenters(grams));
        System.out.println("Tons: " + Converter.toTons(grams));
        System.out.println("=====================\n");

        System.out.println("=======Task==2=======");
        System.out.println("Input bytes");

        Integer bytes = in.nextInt();

        System.out.println("Kilobytes: " + Converter.toKilobytes(bytes));
        System.out.println("Megabytes: " + Converter.toMegabytes(bytes));
        System.out.println("Gigabytes: " + Converter.toGigabytes(bytes));
        System.out.println("=====================\n");

        System.out.println("=======Task==4=======");
        int a = 10;
        int b = 20;

        System.out.println("a: " + a);
        System.out.println("a: " + b);
        System.out.println("==swap==");

        int c = a;
        a = b;
        b = c;

        System.out.println("a: " + a);
        System.out.println("a: " + b);
        System.out.println("==swap==");

        a = a ^ b;
        b = a ^ b;
        a = a ^ b;

        System.out.println("a: " + a);
        System.out.println("a: " + b);
        System.out.println("=====================\n");

        System.out.println("=======Task==5=======");

        System.out.println("Sweets count:\n");
        int sweetsCount = in.nextInt();
        System.out.println("Sweets cost:\n");
        int sweetsCost = in.nextInt();

        System.out.println("Gelatin count:\n");
        int gelatinCount = in.nextInt();
        System.out.println("Gelatin cost:\n");
        int gelatinCost = in.nextInt();

        double sweetPrice = sweetsCost / sweetsCount;
        double gelatinPrice = gelatinCost / gelatinCount;

        double cof = sweetPrice / gelatinPrice;
        if(cof > 1.0){
            System.out.println("Sweets more expensive then gelatin");
        }

        else if (cof < 1.0){
            System.out.println("Gelatin more expensive then sweets");
        }

        else {
            System.out.println("Prices are equal");
        }

        System.out.println("=====================\n");
    }
}
