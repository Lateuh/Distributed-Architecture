package TP1_RMI;


import java.rmi.Remote;
import java.rmi.RemoteException;

public interface AnimalI extends Remote {
String getID() throws RemoteException;
void affiche() throws RemoteException;
IDossierSuivi getDossierSuivi() throws RemoteException;
Espece getinstEspece() throws RemoteException;
}
