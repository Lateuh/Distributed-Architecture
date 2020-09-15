package TP1_RMI;


import java.io.*;

public class Espece implements Serializable{
private String nomEspece;
private int dureeVie;

public Espece(String s, int d){
	nomEspece = s;
	dureeVie = d;
}

public String getNomEspece(){
	return nomEspece;
}

public int getDureeViee(){
	return dureeVie;
}

public String getEspece(){
	return "ESPECE : "+nomEspece+" ("+dureeVie+") ";
}

public void setEspece(String s, int d){
	nomEspece = s;
	dureeVie = d;
}
}