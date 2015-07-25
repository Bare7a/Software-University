import com.itextpdf.text.BaseColor;
import com.itextpdf.text.Document;
import com.itextpdf.text.Font;
import com.itextpdf.text.FontFactory;
import com.itextpdf.text.Paragraph;
import com.itextpdf.text.pdf.BaseFont;
import com.itextpdf.text.pdf.PdfPTable;
import com.itextpdf.text.pdf.PdfWriter;

import java.io.*;

public class Deck {

	public static void main(String[] args) {

		try {
			String card;
			String number;
			char symbol;
			Document document = new Document();
			FontFactory.defaultEmbedding = true;
			Font blackFont = FontFactory.getFont("lib/Arial.ttf",
				    BaseFont.IDENTITY_H, BaseFont.EMBEDDED, 20f, Font.NORMAL, BaseColor.BLACK);
			Font redFont = FontFactory.getFont("lib/Arial.ttf",
				    BaseFont.IDENTITY_H, BaseFont.EMBEDDED, 20f, Font.NORMAL, BaseColor.RED);
			PdfPTable table = new PdfPTable(13);
			table.setWidthPercentage(100F);
			table.getDefaultCell().setFixedHeight(50F);
			for (int i = 0; i < 4; i++) {
				for (int j = 0; j < 13; j++) {
					switch (j) {
					case 0:
						number = "A";
						break;
					case 10:
						number = "J";
						break;
					case 11:
						number = "Q";
						break;
					case 12:
						number = "K";
						break;
					default:
						number = Integer.toString(j + 1);
						break;
					}

					switch (i) {
					case 0:
						symbol = '\u2663';
						break;
					case 1:
						symbol = '\u2666';
						break;
					case 2:
						symbol = '\u2665';
						break;
					case 3:
						symbol = '\u2660';
						break;
					default: symbol = 'Z';
					break;
					}
					card = number + symbol;
					if (i == 0 || i == 3) {
						table.addCell(new Paragraph(card, blackFont));
					} else {
						table.addCell(new Paragraph(card, redFont));
					}
				}
			}
			PdfWriter.getInstance(document, new FileOutputStream(
					"Dec-Of-Cards.pdf"));
			document.open();
			document.add(table);
			document.close();
		} catch (Exception e) {
			e.printStackTrace();
		}
	}
}