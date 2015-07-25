import java.util.Scanner;


public class P5_AngleUnitConverter {
	private static void convert(double value, String type)
	{
		
		if(type.equals(" rad"))
		{
			System.out.printf("%.6f deg\n",Math.toDegrees(value));
		}
		else
		{
			System.out.printf("%.6f rad\n",Math.toRadians(value));
		}
	}
	public static void main(String[] args)
	{
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		int n = input.nextInt();
		double[] value = new double[n];
		String[] type = new String[n];
		for(int i = 0; i<n;i++)
		{
			value[i] = input.nextDouble();
			type[i] = input.nextLine();
		}
		for (int i = 0; i < n; i++) 
		{
			convert(value[i], type[i]);
		}
	}

}
