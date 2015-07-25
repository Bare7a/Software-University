import java.util.Arrays;
import java.util.Scanner;
import java.util.Collections;


public class P6_RandomHandsOf5Cards {

	public static void main(String[] args)
	{
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		int n = input.nextInt();
		String[] card = new String[52];
		for(int i=0;i<52;i++)
		{
				switch (i%13)
				{
				case 9:  card[i] = "J" ;break;
				case 10: card[i] = "Q";break;
				case 11: card[i] = "K";break;
				case 12: card[i] = "A";break;
				default: card[i] = Integer.toString((i%13+2));break;
				}
				switch (i%4)
				{
				case 0: card[i] +="♣";break;
				case 1: card[i] +="♦";break;
				case 2: card[i] +="♥";break;
				case 3: card[i] +="♠";break;
				}
		}
		
		for(int i=0;i<n;i++)
		{
			Collections.shuffle(Arrays.asList(card));
			System.out.printf("%s %s %s %s %s",card[0],card[1],card[2],card[3],card[4]);
			System.out.println();
		}
	}
}