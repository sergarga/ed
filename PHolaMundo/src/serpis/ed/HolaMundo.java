package serpis.ed;

import java.util.Scanner;


public class HolaMundo {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		String nom;
		System.out.println("Hola mundo");
		Scanner sc = new Scanner(System.in);
		System.out.print("Dime tu nombre: ");
		nom = sc.nextLine();
		int i,u;
		for (i=0;i<=10;i++){
			for (u=0;u<i;u++){
				if(i!=10)System.out.print("*");
				
			}
			if (i==10) System.out.print("--> "+nom+" <--");
			System.out.print("\n");
			}
		for (i=9;i>0;i--){
			for (u=0;u<i;u++){
				System.out.print("*");
			}
			System.out.print("\n");
			}
	}

}
