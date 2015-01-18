import java.util.*;

public class Main {

    public static int lyhinReitti(int[][] kartta) {

        // 1 seinä
        // 2 alkukohta
        // 3 loppukohta
        ArrayList<int[]> jono = new ArrayList<int[]>();
        int etaisyys[][] = new int[kartta.length][kartta[0].length];
        int dy[] = {1, 0, -1, 0};
        int dx[] = {0, 1, 0, -1};
        int y1 = 0, x1 = 0, y2 = 0, x2 = 0; // aloitus ja lopetuspaikat

        for (int i = 0; i < kartta.length; i++) {
            for (int j = 0; j < kartta[0].length; j++) {
                if (kartta[i][j] == 2) {
                    y1 = i;
                    x1 = j;
                }
                if (kartta[i][j] == 3) {
                    y2 = i;
                    x2 = j;
                }
            }
        }

        jono.add(new int[]{y1, x1});
        kartta[y1][x1] = 8;

        for (int i = 0; i < jono.size(); i++) {
            int[] koordit = jono.get(i);
            int y = koordit[0];
            int x = koordit[1];

            for (int j = 0; j < 4; j++) {
                int uy = y + dy[j];
                int ux = x + dx[j];
                if (kartta[uy][ux] == 1 || kartta[uy][ux] == 8) {
                    continue;
                }
                jono.add(new int[]{uy, ux});
                kartta[uy][ux] = 8;
                etaisyys[uy][ux] = etaisyys[y][x] + 1;
            }
        }
       // tulostaKartta(etaisyys);
        int pisin = etaisyys[y2][x2];
        if (pisin == 0) {
            return -1;
        } else {
            return etaisyys[y2][x2];
        }
    }

    public static void main(String[] args) {
        int[][] kartta = {{1, 1, 1, 1, 1, 1, 1, 1},
        {1, 0, 3, 1, 0, 0, 0, 1},
        {1, 0, 1, 1, 0, 1, 0, 1},
        {1, 0, 0, 0, 0, 2, 0, 1},
        {1, 1, 1, 1, 1, 1, 1, 1}};

        System.out.println(lyhinReitti(kartta));
    }

    private static void tulostaKartta(int[][] kartta) {
        for (int[] rivi : kartta) {
            System.out.println(Arrays.toString(rivi));
        }
        System.out.println("");
    }
}
