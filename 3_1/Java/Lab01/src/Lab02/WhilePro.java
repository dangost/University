package Lab02;

public class WhilePro {
    public static void main(String[] args){
        int sum=0,xMax=14,xMin=2;
        while (xMin<xMax){
            if(xMin%2!=0){
                sum+=xMin;
            }
            xMin++;
        }
        System.out.println("sum= "+sum);
    }
}