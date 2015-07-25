import java.util.Scanner;


public class P6_CountSpecifiedWord {
	public static void main(String[] args)
	{
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		String text = input.nextLine().toLowerCase();
		String word = input.nextLine().toLowerCase();
		String[] textStr = text.split("[^a-zA-Z]+");
		int counter=0;
		for(int i=0; i<textStr.length;i++)
		{
			if(textStr[i].equals(word))
			{
				counter++;
			}
		}
		System.out.println(counter);
	}

}
