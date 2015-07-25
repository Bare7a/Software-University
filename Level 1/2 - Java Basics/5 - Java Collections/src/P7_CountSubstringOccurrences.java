import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class P7_CountSubstringOccurrences {
	public static void main(String[] args) {
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		String text = input.nextLine().toLowerCase();
		String word = input.nextLine();

		Pattern stringPattern = Pattern.compile(word);
		Matcher matcher = stringPattern.matcher(text);

		int count = 0;
		while (matcher.find()) {
			count++;
			int firstIndex = matcher.start();
			matcher.region(firstIndex + 1, text.length());
		}

		System.out.println(count);
	}
}
