package TP1_RMI;

import java.rmi.Remote;
import java.rmi.RemoteException;

public interface IDossierSuivi extends Remote{
String getSuivi() throws RemoteException;
void setSuivi(String s) throws RemoteException;
}