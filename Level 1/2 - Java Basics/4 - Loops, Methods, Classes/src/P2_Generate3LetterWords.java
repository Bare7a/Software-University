import java.util.Scanner;


public class P2_Generate3LetterWords {

	public static void main(String[] args)
	{
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		String word = input.nextLine();
		if(word.length()==1)
		{
			System.out.print(word+word+word);
		}
		else
		{
			if(word.length()==2)
			{
				for(int i=0;i<2;i++)
				{
					for(int j=0;j<2;j++)
					{
						System.out.print(word.charAt(i)+""+word.charAt(j)+" ");
					}
				}
			}
			else
			{
				for(int i=0;i<3;i++)
				{
					for(int j=0;j<3;j++)
					{
						for(int k=0;k<3;k++)
						{
							System.out.print(word.charAt(i)+""+word.charAt(j)+""+word.charAt(k)+" ");
						}
					}
				}
				
			}
		}
	}
}
