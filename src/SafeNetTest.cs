
public class SafeNetTest {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		SafeNetProblem bob = new SafeNetProblem();
		String something = " ";
		do {
		something = Console.ReadLine();
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
