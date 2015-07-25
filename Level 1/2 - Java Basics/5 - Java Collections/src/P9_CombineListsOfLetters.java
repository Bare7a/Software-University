import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Scanner;


public class P9_CombineListsOfLetters {
	public static void main(String[] args)
	{
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		char[] word1 = input.nextLine().replace(" ", "").toCharArray();
		char[] word2 = input.nextLine().replace(" ", "").toCharArray();
		ArrayList<Character> l1 = new ArrayList();
		ArrayList<Character> l2 = new ArrayList();
		for(char c: word1)
		{
			l1.add(c);
		}
		for(char c: word2)
		{
			l2.add(c);
		}
		for (int i = 0; i < l1.size(); i++) {
			System.out.print(l1.get(i)+" ");
			for(int j=0;j<l2.size();j++)
			{
				if(l1.get(i).equals(l2.get(j)))
				{
					l2.remove(j);
				}
			}
			for(int j=0;j<l2.size();j++)
			{
				if(l1.get(i).equals(l2.get(j)))
				{
					l2.remove(j);
				}
			}
		}
		for(int i=0;i<l2.size();i++)
		{
			System.out.print(l2.get(i)+" ");
		}
	}

}
