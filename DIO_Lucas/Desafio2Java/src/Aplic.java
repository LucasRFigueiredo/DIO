import java.util.Locale;
import java.util.Scanner;

public class Aplic {    
    public static void main(String[] args) {
        Scanner leitor = new Scanner(System.in);
        int idadeDias = leitor.nextInt();
        int anos = idadeDias/365;
        idadeDias = idadeDias - (anos * 365);
        int mes = (idadeDias / 30);
        idadeDias =  idadeDias-(mes * 30);
        int dias = idadeDias;
        System.out.println(anos + " ano(s)");
        System.out.println(mes + " mes(es)");
        System.out.println(dias + " dia(s)");        
    }
}