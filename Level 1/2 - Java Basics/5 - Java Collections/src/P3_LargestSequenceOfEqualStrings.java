import java.util.Scanner;


public class P3_LargestSequenceOfEqualStrings {
	public static void main(String[] args)
	{
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		String line = input.nextLine();
		String[] sequences = line.split(" ");
		int[] countMaxIndex = {0,-1,0};

		

		for(int i=0;i<sequences.length-1;i++)
		{
				if(sequences[i].equals(sequences[i+1]))
				{
					countMaxIndex[0]++;
				}
				else
				{
					countMaxIndex[0]=0;
				}
				if(countMaxIndex[0]>countMaxIndex[1])
				{
					countMaxIndex[1]=countMaxIndex[0];
					countMaxIndex[2] = i;
				}
		}
		for(int i=0;i<countMaxIndex[1]+1;i++)
		{
			System.out.print(sequences[countMaxIndex[2]]+" ");
		}
	}
}
