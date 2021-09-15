package Lab02;

public class BreakPro {
    public static void main(String[] args){
        int day=14,mounts=2,yer=2001;
        int i=14;
        double pr=1;
        while (i<(day+mounts+yer)){
            pr*=i;
            i++;
            if(pr%79==0) break;
        }
        System.out.println("pr= "+pr);
    }
}
