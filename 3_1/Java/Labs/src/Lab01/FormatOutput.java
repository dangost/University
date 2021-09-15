package Lab01;

public class FormatOutput {
    public static void main(String[] args){
        boolean ans = true;
        char letter = 'b';
        float sum =45.4789f;
        System.out.printf("\nЭто пример 1 \n ans = %8b",ans);
        System.out.printf("\nЭто пример 2 \n letter = %4c",letter);
        System.out.printf("\nЭто пример 3 \n sum = %5.2f",sum);
        System.out.printf("\nЭто пример 4" + "\n ans = %8b \n " +
                "letter =%4c \n sum = %5.2f",ans,letter,sum);
        double disc = 2343462.90673498;
        String text ="this is my text!";
        System.out.printf("\nЭто пример 5 \n disc = %4.4f",disc);
        System.out.printf("\nЭто пример 6 \n text = %15s",text);
    }
}
