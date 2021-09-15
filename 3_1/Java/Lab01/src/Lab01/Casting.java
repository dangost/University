package Lab01;

public class Casting {
    public static void main(String[] args){
        short age =20;
        char sex ='M';
        byte iq =80;
        int height =64;
        long distance =300;
        float price = 99.99f;
        double money = 500.00;

        System.out.println("age = "+age);
        System.out.println("sex = "+sex);
        System.out.println("iq = "+iq);
        System.out.println("height = "+height);
        System.out.println("distance = "+distance);
        System.out.println("price = "+price);
        System.out.println("money = "+money);

        iq =(byte) height;
        distance=height;
        sex=(char) money;

        System.out.println("age = "+age);
        System.out.println("sex = "+sex);
        System.out.println("iq = "+iq);
        System.out.println("height = "+height);
        System.out.println("distance = "+distance);
        System.out.println("price = "+price);
        System.out.println("money = "+money);

        double b=3413,c=324325;
        float sum= (float) b+(float) c;
        System.out.println("sum = "+sum);
    }
}
