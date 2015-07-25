import java.io.BufferedReader;
import java.io.FileReader;


public class P8_SumNumbersFromTextFile {
	public static void main (String[] args)
	{
		try {
			BufferedReader reader = new BufferedReader(new FileReader(
			"P8_input.txt"));
			int sum = 0;
			String inputNumbers = "";
			while ((inputNumbers = reader.readLine()) != null) {
			sum += Integer.parseInt(inputNumbers);
			}
			System.out.println(sum);
			reader.close();
			} catch (Exception e) {
			System.out.println("Error");
			}
	}

}
