import java.util.Scanner;

public class SortArrayOfStrings {
	public static void main(String[] args) {
		@SuppressWarnings("resource")
		Scanner sc = new Scanner(System.in);
		int n = sc.nextInt();
		String[] towns = new String[n];
		String swap;
		for (int i = 0; i < n; i++) {
			towns[i] = sc.next();
		}
		for (int i = 0; i < n; i++) {
			for (int j = 0; j < n; j++) {
				if (towns[i].compareTo(towns[j]) < 0&&i!=j) {
					swap = towns[i];
					towns[i] = towns[j];
					towns[j] = swap;
				}
			}
		}
		for(int i=0;i<n;i++)
		{
			System.out.println(towns[i]);
		}
	}
}
