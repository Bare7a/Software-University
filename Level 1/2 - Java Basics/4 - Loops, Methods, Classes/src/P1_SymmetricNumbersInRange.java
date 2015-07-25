import java.util.Scanner;


public class P1_SymmetricNumbersInRange {

	public static void main(String[] args)
	{
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		int start = input.nextInt();
		int end = input.nextInt();
		for(int i = start; i<=end; i++)
		{
			if(i>=0&&i<=9)
			{
				System.out.print(i + " ");
			}
			else
			{
				if(i>=10&&i<=99)
				{
					if(i%10==i/10)
					{
						System.out.print(i + " ");
					}
				}
				else
				{
					if(i>=100&&i<=999)
					{
						if(i%10==i/100)
						{
							System.out.print(i + " ");
						}
					}
				}
			}
		}
	}

}
