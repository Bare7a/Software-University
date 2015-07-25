import java.util.Scanner;

public class P9_PointsInsideTheHouse {
	public static void main(String[] args) {
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		String coordinates = input.nextLine();
		String[] point = coordinates.split(" ");
		float x = Float.parseFloat(point[0]);
		float y = Float.parseFloat(point[1]);
        double ABC = Math.abs((12.5 * (3.5 - 8.5) + 17.5 * (8.5 - 8.5) + 22.5
                        * (8.5 - 3.5)));
        double ABP = Math.abs((12.5 * (3.5 - y) + 17.5 * (y - 8.5) + x
                        * (8.5 - 3.5)));
        double APC = Math.abs((12.5 * (y - 8.5) + x * (8.5 - 8.5) + 22.5
                        * (8.5 - y)));
        double PBC = Math.abs((x * (3.5 - 8.5) + 17.5 * (8.5 - y) + 22.5
                        * (y - 3.5)));
        boolean isInsideTriangle = (ABC == ABP + APC + PBC);
		if ((((x >= 8.5 && x <= 17.5) || (x >= 20 && x <= 22.5)) && (y >= 8.5 && y <= 13.5))||isInsideTriangle) {
			System.out.println("Inside");
		} else {
			System.out.println("Outside");
		}
	}
}
