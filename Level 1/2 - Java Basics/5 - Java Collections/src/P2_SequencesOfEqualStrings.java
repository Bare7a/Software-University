import java.util.Scanner;


public class P2_SequencesOfEqualStrings {
	public static void main(String[] args)
	{
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		String line = input.nextLine();
		String[] sequences = line.split(" ");
		for(int i=0;i<sequences.length;i++)
		{
			if(i==0)
			{
				System.out.print(sequences[i]);
			}
			else if(sequences[i].equals(sequences[i-1]))
			{
				System.out.print(" "+sequences[i]);
			}
			else
			{
				System.out.printf("\n"+sequences[i]);
			}
		}
	}

}
