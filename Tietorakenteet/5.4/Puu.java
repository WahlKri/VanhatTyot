public class Puu {

    Solmu root;

    public Puu() {
        root = null;
    }

    public void insert(int arvo) {
        root = lisaaSolmu(root, new Solmu(arvo));
    }

    private Solmu lisaaSolmu(Solmu nykyinen, Solmu lisattava) {

        if (nykyinen == null) {
            return lisattava;
        } else if (lisattava.arvo > nykyinen.arvo) {
            nykyinen.oikea = lisaaSolmu(nykyinen.oikea, lisattava);
        } else if (lisattava.arvo < nykyinen.arvo) {
            nykyinen.vasen = lisaaSolmu(nykyinen.vasen, lisattava);
        }

        return nykyinen;
    }

}
