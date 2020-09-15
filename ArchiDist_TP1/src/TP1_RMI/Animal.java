package TP1_RMI;


import java.rmi.RemoteException;
import java.rmi.server.UnicastRemoteObject;



public class Animal extends UnicastRemoteObject implements AnimalI{
private String nom, nomMaitre,race;
private DossierSuivi ds;
private Espece esp;

public Animal(String nom_, String nomMaitre_, String race_, String esp_ )throws RemoteException{
	nom=nom_;
	nomMaitre=nomMaitre_;
	race=race_;

	esp=new Espece(esp_, 10);
	ds=new DossierSuivi(" --SUIVI-- "+nom+" - "+nomMaitre);
}

public String getNom() throws RemoteException{
	return nom;
}

public void setNom(String nom) throws RemoteException {
	this.nom = nom;
}

public String getNomMaitre()throws RemoteException {
	return nomMaitre;
}

public void setNomMaitre(String nomMaitre) throws RemoteException{
	this.nomMaitre = nomMaitre;
}


public String getRace() throws RemoteException{
	return race;
}

public void setRace(String race) throws RemoteException{
	this.race = race;
}

public String getID()throws RemoteException{
		return "Cet animal s'appelle "+this.getNom()+" et son maître "+nomMaitre+
		", il est de race "+race+" et d'espece "+this.esp.getEspece()+"||"+this.ds.getSuivi();
	}

public void affiche()throws RemoteException{
	System.out.println(this.getID());
}

public IDossierSuivi getDossierSuivi() throws RemoteException{
	return this.ds;
}

public Espece getinstEspece() throws RemoteException{
	return this.esp;
}

}
