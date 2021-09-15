package Lab01;


public class ShortHandOperator {
    public static void main(String[] args){
        //for int
        int x=10,y=15;
        System.out.println("x = "+ x);
        System.out.println("y = "+ y);
        System.out.println("++x = "+ ++x);
        System.out.println("y++ = "+ y++);
        System.out.println("x = "+ x);
        System.out.println("y = "+ y);

        x = 4;
        y = 8;
        int z=++x + y;
        System.out.println("x = " + x);
        System.out.println("y = " + y);
        System.out.println("z = ++x +y "+z);

        x = 4;
        y = 8;
        z=x++ + y;
        System.out.println("x = " + x);
        System.out.println("y = " + y);
        System.out.println("z = x++ +y "+z);

        x = 4;
        y = 8;
        z=--x + y;
        System.out.println("x = " + x);
        System.out.println("y = " + y);
        System.out.println("z = --x +y "+z);

        x = 4;
        y = 8;
        z=x-- + y;
        System.out.println("x = " + x);
        System.out.println("y = " + y);
        System.out.println("z = x-- +y "+z);

        int i = 3, j = 5, k = 7, m =9, n=-11;
        i+=8;
        j-=2;
        k*=4;
        m/=3;
        n%=2;
        System.out.println("i += 8 получается " + i);
        System.out.println("j -= 2 получается " + j);
        System.out.println("k *= 4 получается "  + k);
        System.out.println("m /= 3 получается " + m);
        System.out.println("n %= 2 получается " + n);

        System.out.println(Math.pow(2,3));
        System.out.println(Math.sin(2));

        //for char
        char a = 'd', b = 'D';
        System.out.println("a+=8 получается "+(a+=8));
        System.out.println("b+=1 получается "+(b+=1));

        x=1;
        y=x++ + x;
        System.out.println("-----y"+y);

        System.out.println('3' - '2' + 'm' / 'n');

        x=10;
        y=10;
        boolean zz = (y > 10) && (x++ >10);
        System.out.println("x = "+x);

        x=10;
        y=10;
        zz= (y>10) || (x++ >10);
        System.out.println("||x = "+x);

        System.out.println("-24/-5 ="+(-24%-5));
        System.out.println("-24.2/-5.5 ="+(-24.2/-5.5));

        System.out.println("'A'+1 = "+('A'+1));

        double w =34.22;
        double v=++w;
        System.out.println("++w = "+ v);
        w =34.22;
        v=w++;
        System.out.println("--w = "+ --v);
    }
}