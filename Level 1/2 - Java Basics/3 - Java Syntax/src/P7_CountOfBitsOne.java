import java.util.Scanner;


public class P7_CountOfBitsOne {
	public static void main(String[] args)
	{
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		int number = input.nextInt();
		int counter=0;
		String numberBin = Integer.toBinaryString(number);
		for(int i=0;i<numberBin.length();i++)
		{
			if(numberBin.charAt(i)=='1')
			{
				counter++;
			}
		}
		System.out.println(counter);
	}

}
