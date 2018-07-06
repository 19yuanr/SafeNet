

public class SafeNet {

	private int hundred;
	private int fifty;
	private int twenty;
	private int ten;
	private int five;
	private int one;

	public SafeNet() {
		hundred = 10;
		fifty = 10;
		twenty = 10;
		ten = 10;
		five = 10;
		one = 10;
	}

	public void R() {
		hundred = 10;
		fifty = 10;
		twenty = 10;
		ten = 10;
		five = 10;
		one = 10;
	}

	public void W(String line) {
		int xhundred = hundred;
		int xfifty = fifty;
		int xtwenty = twenty;
		int xten = ten;
		int xfive = five;
		int xone = one;
		int amount = Integer.parseInt(line.substring(3));
		if (amount >= 100) {
			if (amount / 100 > hundred) {
				amount -= hundred * 100;
				hundred = 0;
			} else {
				hundred -= amount / 100;
				amount = amount % 100;
			}

		}
		if (amount >= 50) {
			if (amount / 50 > fifty) {
				amount -= fifty * 50;
				fifty = 0;
			} else {
				fifty -= amount / 50;
				amount = amount % 50;
			}

		}
		if (amount >= 20) {

			if (amount / 20 > twenty) {
				amount -= twenty * 20;
				twenty = 0;
			} else {
				twenty -= amount / 20;
				amount = amount % 20;
			}

		}
		if (amount >= 10) {
			if (amount / 10 > ten) {
				amount -= ten * 10;
				ten = 0;
			} else {
				ten -= amount / 10;
				amount = amount % 10;
			}

		}
		if (amount >= 5) {
			if (amount / 5 > five) {
				amount -= five * 5;
				five = 0;
			} else {
				five -= amount / 5;
				amount = amount % 5;
			}

		}
		if (amount >= 1) {
			if (amount > 1) {
				amount -= one;
				one = 0;
			} else {
				one -= amount;
				amount = amount % 1;
			}

		}
		if (amount != 0) {
			Console.WriteLine("Failure: insufficient funds");
			hundred = xhundred;
			fifty = xfifty;
			twenty = xtwenty;
			ten = xten;
			five = xfive;
			one = xone;
		} else {
			Console.WriteLine("Success");
			Console.WriteLine("$100: " + hundred);
			Console.WriteLine("$50: " + fifty);
			Console.WriteLine("$20: " + twenty);
			Console.WriteLine("$10: " + ten);
			Console.WriteLine("$5: " + five);
			Console.WriteLine("$1: " + one);
		}
	}

	public void I(String line) {
		String[] lineData = line.substring(2).split("\\$");
		for (String each : lineData) {
			if (Integer.parseInt(each) == 100) {
				Console.WriteLine("$100: " + hundred);
			}
			if (Integer.parseInt(each) == 50) {
				Console.WriteLine("$50: " + fifty);
			}
			if (Integer.parseInt(each) == 20) {
				Console.WriteLine("$20: " + twenty);
			}
			if (Integer.parseInt(each) == 10) {
				Console.WriteLine("$10: " + ten);
			}
			if (Integer.parseInt(each) == 5) {
				Console.WriteLine("$5: " + five);
			}
			if (Integer.parseInt(each) == 1) {
				Console.WriteLine("$1: " + one);
			}

		}
	}

	public void Q() {
	}
	public void add1000() {
		one+=1000;
	}

}
