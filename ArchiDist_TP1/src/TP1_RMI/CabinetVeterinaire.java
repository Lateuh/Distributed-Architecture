package TP1_RMI;

import java.rmi.server.UnicastRemoteObject;
import java.rmi.RemoteException;
import java.util.HashMap;

public class CabinetVeterinaire extends UnicastRemoteObject implements ICabinetVeterinaire{
	
private HashMap<String, Animal> patients = new HashMap<String, Animal>();

public CabinetVeterinaire() throws RemoteException{}

public CabinetVeterinaire(String s, Animal a)throws RemoteException {
	patients.put(s, a);
}

public HashMap<String, Animal> getPatients() {
	return patients;
}

public void setPatients(HashMap<String, Animal> pat) {
	this.patients = pat;
}

public AnimalI getAPatient(String s) throws RemoteException {
	return this.patients.get(s);
}

public void addAPatient(Animal a) throws RemoteException{
	this.patients.put(a.getNom(), a);
}
}
