import java.util.Scanner;


public class SafeNetTest {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner input = new Scanner(System.in);
		SafeNet bob = new SafeNet();
		String something = " ";
		do {
		something = input.nextLine();
		if ((something.substring(0, 1).equals("W"))){
			bob.W(something);
		}
		if ((something.substring(0,1)).equals("I")) {
			bob.I(something);
		}
		if ((something.substring(0,1)).equals("Q")) {
			bob.Q();
		}
		}
		while (!(something.substring(0,1)).equals("Q"));
		

		

	}

}