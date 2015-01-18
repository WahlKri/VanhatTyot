/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package kertausta;

/**
 *
 * @author kristianw
 */
public class Puu {

    int arvo;
    Puu vasen;
    Puu oikea;

    public Puu(int arvo, Puu vasen, Puu oikea) {
        this.arvo = arvo;
        this.vasen = vasen;
        this.oikea = oikea;
    }
}
