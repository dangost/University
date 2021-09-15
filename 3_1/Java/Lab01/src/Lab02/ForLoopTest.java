package Lab02;

public class ForLoopTest {
    public static void main(String[] args){
        float sum=0;
        for (float x=0.01f;x<=1.0f;x=x+0.01f){
            sum+=x;
        }
        System.out.println("The sum = "+sum);

        for (int i=0, j=3;(i+j)<10;i++,j++){
            System.out.println("\nТекущее значение i = "+i+" j= "+j);
            System.out.println("\tСумма i+j=  "+ (i+j));
        }
        //Самостоятельная часть
        int day=14, month=2;
        sum =0;
        for (int i=0,j=200;i<500;i++,j++){
            if (i % (day+month)==0 && i<100){
                sum+=i;
            }
            if (j%(day+month)==0 && j<500){
                sum+=j;
            }

        }
        System.out.println();
        System.out.println("sum= "+sum);
    }
}