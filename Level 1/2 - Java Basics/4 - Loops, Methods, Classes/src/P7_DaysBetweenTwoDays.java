import java.time.LocalDate;
import java.time.format.DateTimeFormatter;
import java.time.temporal.ChronoUnit;
import java.util.Scanner;


public class P7_DaysBetweenTwoDays {
	public static void main(String[] args)
	{
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		String startDate = input.nextLine();
		String endDate = input.nextLine();

		LocalDate d1 = LocalDate.parse(startDate, DateTimeFormatter.ofPattern("d-MM-yyyy"));
		LocalDate d2 = LocalDate.parse(endDate, DateTimeFormatter.ofPattern("d-MM-yyyy"));

		System.out.println(ChronoUnit.DAYS.between(d1, d2));
		
	}

}
