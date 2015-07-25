import java.util.Scanner;


public class P5_DecimalToHexadecimal {
	public static void main(String[] args)
	{
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		int num = input.nextInt();
		System.out.println(Integer.toHexString(num).toUpperCase());
	}

}
