import java.util.Scanner;


public class P5_CountAllWords {
	public static void main(String[] args){
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		String line = input.nextLine();
		String[] words = line.split("[^a-zA-Z]+");
		System.out.println(words.length);
	}
}
