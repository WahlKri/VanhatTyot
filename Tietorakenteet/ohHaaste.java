package ohhaast;

// paras tulos 7; 88418 2s kutsuilla  112652526
import java.util.Arrays;

public class OhHaast {

    public static int maarat = 0;
    public static long kutsujaTehtiin = 0;
    public static int dimensio = 7;
    public static boolean[][] taulu;

    public static void main(String[] args) {
        kutsujaTehtiin = 0;
        maarat = 0;
        taulu = new boolean[dimensio + 2][dimensio + 2];
        for (int i = 0; i < dimensio + 2; i++) {
            taulu[0][i] = true;
            taulu[i][0] = true;
            taulu[dimensio + 1][i] = true;
            taulu[i][dimensio + 1] = true;
        }

//        for (boolean[] rivi : taulu) {
//            System.out.println(Arrays.toString(rivi));
//        }
        laskeAskeleet(1, 1, 1);
        System.out.println(maarat);
        System.out.println("...joka saatiin kutsuilla: " + kutsujaTehtiin);
    }

    private static void laskeAskeleet(int y, int x, int k) {

        kutsujaTehtiin++;

        if(taulu[y][x]){
            return;
        } 
        
        boolean onKayty = onKaytyKaikissaRuuduissa(k);
        boolean ollaanViimeisessa = onViimeisessa(x, y);
        
        if (ylempiTyhja(x, y) || (ollaanViimeisessa && !onKayty)) {
            return;
        }

        if (ollaanViimeisessa && onKayty) {
            maarat++;
            return;
        }

        taulu[y][x] = true;
        if (y < dimensio) {
            laskeAskeleet(y + 1, x, k + 1);
        }
        if (x < dimensio) {
            laskeAskeleet(y, x + 1, k + 1);
        }
        if (y != 1) {
            laskeAskeleet(y - 1, x, k + 1);
        }
        if (x != 1) {
            laskeAskeleet(y, x - 1, k + 1);
        }
        taulu[y][x] = false;

    }


    public static boolean onViimeisessa(int x, int y) {
        return (x == 1 & y == dimensio);
    }

    public static boolean onKaytyKaikissaRuuduissa(int k) {
        return k == (dimensio) * (dimensio);
    }

    private static boolean ylempiTyhja(int x, int y) {

        if (taulu[y - 1][x] && taulu[y + 1][x] && !taulu[y][x - 1] && !taulu[y][x + 1]) {
            return true;
        }
        else if (taulu[y][x - 1] && taulu[y][x + 1] && !taulu[y - 1][x] && !taulu[y + 1][x]) {
            return true;
        }

        return false;
    }

}
