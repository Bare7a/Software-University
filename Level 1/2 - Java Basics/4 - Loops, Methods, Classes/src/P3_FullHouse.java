
public class P3_FullHouse {
	private static void cardPrint(int cardNumber,int cardSymbol){
		
		switch (cardNumber)
		{
		case 9:  System.out.print("J");break;
		case 10: System.out.print("Q");break;
		case 11: System.out.print("K");break;
		case 12: System.out.print("A");break;
		default: System.out.print(cardNumber+2);break;
		}
		switch (cardSymbol)
		{
		case 0: System.out.print("♣ ");break;
		case 1: System.out.print("♦ ");break;
		case 2: System.out.print("♥ ");break;
		case 3: System.out.print("♠ ");break;
		}
	}
	public static void main(String[] args)
	{
		int count=0;
		int[][] card=new int[2][13];
		for(int i=0;i<13;i++)
		{
			for (int j = 0; j < 4; j++) 
			{
				card[0][i] = i;
				card[1][i] = j;
			}
		}

		for(int i=0;i<13;i++)
		{
			for(int i2=0;i2<13;i2++)
			{
				for (int l1 = 0; l1 < 4; l1++) {
					for (int l2 = l1 + 1; l2 < 4; l2++) {
						for (int l3 = l2 + 1; l3 < 4; l3++) {
							for (int r1 = 0; r1 < 4; r1++) {
								for (int r2 = r1 + 1; r2 < 4; r2++) {
									if (i != i2) {
										cardPrint(card[0][i],card[1][l1]);
										cardPrint(card[0][i],card[1][l2]);
										cardPrint(card[0][i],card[1][l3]);
										cardPrint(card[0][i2],card[1][r1]);
										cardPrint(card[0][i2],card[1][r2]);
										System.out.println();
										count++;
									}
								}
							}
						}
					}
				}
			}
		}
		System.out.println(count+" full houses");
	}

}