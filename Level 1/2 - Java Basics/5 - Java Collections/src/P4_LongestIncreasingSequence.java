import java.util.Scanner;


public class P4_LongestIncreasingSequence {
	public static void main(String[] args)
	{
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		String line = input.nextLine();
		String[] numberString = line.split(" ");
		String[] longestSequence = new String[2];
		int counter=0;
		int max=-1;
		int[] numberInt = new int [numberString.length];
		for(int i=0;i<numberInt.length;i++)
		{
			numberInt[i] = Integer.parseInt(numberString[i]);
		}
		for(int i=0;i<numberInt.length;i++)
		{
			if(i==0)
			{
				counter++;
				System.out.print(numberInt[0]);
				longestSequence[0]=numberInt[0]+" ";
				if(counter>max)
				{
					max=counter;
					longestSequence[1]=longestSequence[0];
				}
			}
			else if(numberInt[i]>numberInt[i-1])
			{
				counter++;
				System.out.print(" "+numberInt[i]);
				longestSequence[0]+=numberInt[i]+" ";
				if(counter>max)
				{
					max=counter;
					longestSequence[1]=longestSequence[0];
				}
			}
			else
			{
				System.out.print("\n"+numberInt[i]);
				longestSequence[0]=numberInt[i]+" ";
				counter=1;
			}
		}
		System.out.printf("\nLongest: "+ longestSequence[1]);
	}
}
