import java.util.Scanner;

public class SumTwoNumbers {
	public static void main(String[] args){
		@SuppressWarnings("resource")
		Scanner sc = new Scanner(System.in);
		int a = sc.nextInt();
		int b = sc.nextInt();
		int sum = a + b;
		System.out.println(sum);
	}
}
