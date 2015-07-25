import java.util.Scanner;


public class P12_CardsFrequencies {
	public static void main (String[] args)
	{
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		String[] cards = input.nextLine().split("[^a-zA-Z0-9]+");
		int[] count = new int[cards.length];
		for(int i=0;i<count.length;i++)
		{
			count[i] = 1;
		}
		for(int i=0;i<cards.length;i++)
		{
			for(int j=i+1;j<cards.length;j++)
			{
				if(cards[i].equals(cards[j])&&(count[i]!=-1))
				{
					count[i]++;
					count[j]=-1;
				}
			}
		}
		for(int i=0;i<cards.length;i++)
		{
			if(count[i]!=-1)
			{
				System.out.printf("%s -> %.2f\n",cards[i],((float)count[i]/cards.length)*100);
			}
		}
	}

}
