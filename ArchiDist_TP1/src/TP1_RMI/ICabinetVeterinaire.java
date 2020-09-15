package TP1_RMI;

import java.rmi.Remote;
import java.rmi.RemoteException;

public interface ICabinetVeterinaire extends Remote {
	AnimalI getAPatient(String s) throws RemoteException;
	void addAPatient(Animal a) throws RemoteException;
}
