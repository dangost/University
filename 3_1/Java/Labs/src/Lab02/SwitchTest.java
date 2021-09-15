package Lab02;
import javax.swing.*;


public class SwitchTest {
    public static void main(String[] args){
        String answer = JOptionPane.showInputDialog(null,
                "Введите вариант ответа от одного до трех",
                "Вариант ответа", JOptionPane.OK_CANCEL_OPTION);

        int variant = Integer.parseInt(answer);

        switch (variant){
            case 1:
                System.out.println("Вы выбрали первый вариант");
                break;
            case 2:
                System.out.println("Вы выбрали второй вариант");
                break;
            case 3:
                System.out.println("Вы выбрали третий вариант");
                break;
            default:
                System.out.println("Ваш выбор не соответсвует заданному");
        }
    }
}
