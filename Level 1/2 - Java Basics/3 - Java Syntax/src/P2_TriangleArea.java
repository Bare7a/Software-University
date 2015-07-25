import java.util.Scanner;


public class P2_TriangleArea {
	public static void main (String[] args)
	{
		@SuppressWarnings({"resource"})
		Scanner input = new Scanner(System.in);
		int xA = input.nextInt();
		int yA = input.nextInt();
		int xB = input.nextInt();
		int yB = input.nextInt();
		int xC = input.nextInt();
		int yC = input.nextInt();
		double triangleArea = Math.abs((xA * (yB - yC) + xB * (yC - yA) + xC * (yA - yB)) / 2);
		System.out.printf("%d", (int)triangleArea);
	}
}
