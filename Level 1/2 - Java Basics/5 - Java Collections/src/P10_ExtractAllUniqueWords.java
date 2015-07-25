import java.util.Scanner;
import java.util.Set;
import java.util.TreeSet;

public class P10_ExtractAllUniqueWords {
	public static void main(String[] args) {
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		String[] text = input.nextLine().toLowerCase().split("\\W+");
		Set<String> textTree = new TreeSet<String>();
		for (String s : text) {
			if (!textTree.contains(s)) {
				textTree.add(s);
			}
		}
		for(String s : textTree)
		{
			System.out.print(s+" ");
		}
	}

}
