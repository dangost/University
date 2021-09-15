package Lab02;

/**
 * while –оператор цикла
 * на примере вычисления суммы чисел от 0 до xMax
 *
 * @author Kreydich E. M.
 * @version 1.1
 */

public class WhileTest {
    public static void main(String[] args){
        int sum=0;
        int i=1;
        int xMax=10;

        while (i<xMax){
            sum+=i;
            i++;
        }
        System.out.println("sum= "+sum);
        System.out.println("last i= "+i);
    }
}
