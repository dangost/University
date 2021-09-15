package Lab02;

public class LabelTest {
    public static void main(String[] args){
        int[] scores={3,5,10,9,9,10,7,1,9,8};
        outer:
        for (int i=0;i<10;i++){
            if(scores[i]<=0) break outer;
            if(scores[i]>5){
                inner:
                for (int j=0;j<3;j++){
                    if(scores[i]==10){
                        System.out.println(scores[i]+" Хороший результат!");
                        continue inner;
                    }
                    System.out.println(scores[i]+" неплохо!");
                    continue outer;
                }
            }
            if (scores[i]<=5 && scores[i]>3)
                System.out.println(scores[i]+" больше практики!");
            if (scores[i]<=3)
                System.out.println(scores[i]+" Начни сначала!");
        }
    }
}
