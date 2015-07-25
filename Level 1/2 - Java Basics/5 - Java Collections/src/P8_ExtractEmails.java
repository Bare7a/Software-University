import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class P8_ExtractEmails {
	public static void main(String[] args) {
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		String text = input.nextLine().toLowerCase();
		String regex = "([a-z0-9]+[._-]*[a-z0-9]+@+[a-z]+[.]*[a-z]+[.]*[a-z]+[.]*[a-z]+)";
		Pattern emailPattern = Pattern.compile(regex);
		Matcher matcher = emailPattern.matcher(text);
		
		while (matcher.find()) {
			System.out.println(matcher.group());
		}
	}

}
