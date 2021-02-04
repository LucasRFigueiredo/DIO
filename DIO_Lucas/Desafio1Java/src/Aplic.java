import java.util.Locale;
import java.util.Scanner;

public class Aplic {    
    public static void main(String[] args) {
        
        Locale.setDefault(Locale.US);
        Scanner sc = new Scanner(System.in);
        
        int num = sc.nextInt();
        
        for (int i = 2; i <= num; i += 2) {
            System.out.println(i);
        }
    }
}
