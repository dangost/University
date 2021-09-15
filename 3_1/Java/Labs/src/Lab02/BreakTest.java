package Lab02;

public class BreakTest {
    public static void main(String[] args){
        int sum=0;
        int number=0;

        while (number<20){
            number++;
            sum+=number;
            if(sum>=100) break;
        }

        System.out.println("number= "+number);
        System.out.println("sum= "+sum);
    }
}
