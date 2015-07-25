import java.util.Scanner;


public class P6_FormattingNumbers {
	public static void main(String[] args)
	{
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		int a = input.nextInt();
		String aHex = Integer.toHexString(a).toUpperCase();
		String aBin = String.format("%10s",Integer.toBinaryString(a)).replace(' ', '0');
		float b = input.nextFloat();
		float c = input.nextFloat();
		System.out.printf("|%-10s|%s|%10.2f|%-10.3f|",aHex,aBin,b,c);
	}

}
