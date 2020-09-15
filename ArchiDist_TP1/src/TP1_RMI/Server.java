package TP1_RMI;


import java.rmi.registry.LocateRegistry;
import java.rmi.registry.Registry;
//import java.security.*;

public class Server { 

	public static void main(String args[]) {

		try {
			CabinetVeterinaire obj = new CabinetVeterinaire();
			Registry registry = LocateRegistry.createRegistry(1099);
			//Registry registry = LocateRegistry.getRegistry();
			if (registry==null){
				System.err.println("RmiRegistry not found");
			}else{
				System.setProperty("java.security.policy","policy");
				System.setSecurityManager(new SecurityManager());
				registry.bind("CabinetVeterinaire", obj);
				System.out.println("Server cabinet ready");
				
				Animal chien = new Animal("Brutus", "Alex", "Francaise", "Bulldog");
				Animal chat = new Animal("Caramel", "Sophie", "Egyptien", "Angora");
				
				obj.addAPatient(chien);
				obj.addAPatient(chat);
				
			}
		} catch (Exception e) {
			System.err.println("Server exception: " + e.toString());
			e.printStackTrace();
		}
	}
	
}
