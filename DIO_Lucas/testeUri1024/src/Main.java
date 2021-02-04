import java.io.IOException;
import java.util.ArrayList;
import java.util.Locale;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) throws IOException {
		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);
		ArrayList<String> senha = new ArrayList<>();
		int x = sc.nextInt();
		String sen;
		for (int i = 0; i < x; i++) {
			sen = sc.next();
			senha.add(sen);
		}
		for (int j = 0; j < senha.size(); j++) {
			System.out.println(senha.get(j));
		}

	}
}
