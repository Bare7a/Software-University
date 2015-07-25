import java.util.Scanner;

public class P1_SortArrayOfNumbers {
	public static void main(String[] args) {
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		int n = input.nextInt();
		int[] numbers = new int[n];
		int swap;
		for (int i = 0; i < n; i++) {
			numbers[i] = input.nextInt();
		}
		for (int i = 0; i < n; i++) {
			for (int j = 0; j < n; j++) {
				if (j > 0) {
					if (numbers[j - 1] > numbers[j]) {
						swap = numbers[j];
						numbers[j] = numbers[j - 1];
						numbers[j - 1] = swap;
					}
				}
			}

		}
		for (int i = 0; i < n; i++) {
			System.out.printf(numbers[i] + " ");
		}
	}
}
