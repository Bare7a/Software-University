import java.util.Scanner;


public class P4_TheSmallerOf3Numbers {
	public static void main(String[] args) {
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		float[] number = new float[4];
		number[3] = Float.MAX_VALUE;
		for(int i=0;i<3;i++)
		{
			number[i] = input.nextFloat();
			if(number[3]>number[i])
			{
				number[3] = number[i];
			}
		}
		System.out.println(number[3]);
	}

}
