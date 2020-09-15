package TP1_RMI;


import java.rmi.registry.LocateRegistry;
import java.rmi.registry.Registry;

public class Client {

	private Client() {}

	public static void main(String[] args) {

		String host = (args.length < 1) ? null : args[0];
		try {
			System.setProperty("java.security.policy","policy");
			Registry registry = LocateRegistry.getRegistry(host);
			ICabinetVeterinaire stub = (ICabinetVeterinaire) registry.lookup("CabinetVeterinaire");
			

			/*AnimalI chien = stub.getAPatient("Brutus");
			String reponse = chien.getID();
			System.out.println("réponse: " + reponse); // affiche cote client

			chien.affiche(); // affiche cote serveur


			AnimalI chat = stub.getAPatient("Caramel");
			reponse = chat.getID();
			System.out.println("réponse: " + reponse); // affiche cote client

			chat.affiche(); // affiche cote serveur*/
			
			/*Animal tortue = new Animal("Griezi", "Massi","Inde", "Terre");
			stub.addAPatient(tortue);
			reponse = tortue.getID();
			System.out.println("réponse: " + reponse); // affiche cote client*/

			/*IDossierSuivi stub2 = stub.getDossierSuivi(); // on recup l'instance de IDossier suivi

			stub2.setSuivi("coucou"); // on modifie le suivi de l'animal
			response = stub.getID(); // on recup ID de l'animal
			System.out.println("reponse: " + response); // affiche cote client

			stub.affiche(); //affiche cote serveur



			Espece espece = stub.getinstEspece();
		
			espece.setEspece("bouftou", 10);
	
			response = stub.getID(); // on recup ID de l'animal
			System.out.println("reponse: " + response); // affiche cote client

			stub.affiche(); //affiche cote serveur

			*/
		} catch (Exception e) {
			System.err.println("Client exception: " + e.toString());
			e.printStackTrace();
		}
	}
	
}
