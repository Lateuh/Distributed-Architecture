package TP1_RMI;


import java.rmi.RemoteException;
import java.rmi.server.UnicastRemoteObject;

public class DossierSuivi extends UnicastRemoteObject implements IDossierSuivi{
	private String suivi;
	
	public DossierSuivi(String s) throws RemoteException{
		suivi=s;
	}

	public String getSuivi() throws RemoteException{
		return suivi;
	}

	public void setSuivi(String suivi) throws RemoteException{
		this.suivi = suivi;
	}
	
	
}
