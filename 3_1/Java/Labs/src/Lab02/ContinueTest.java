package Lab02;

public class ContinueTest {
    public static void main(String[]args){
        int sum=0;
        int number =0;

        while (number<20){
            number++;
            if (number==2 || number==14) continue;
            sum+=number;
            System.out.println("number= "+number+" sum= "+sum);
        }
        System.out.println("sum= "+sum);
    }
}
