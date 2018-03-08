package main;

import java.util.InputMismatchException;
import java.util.List;
import java.util.Scanner;
import dll.Repozitorij;
import model.Krava;

public class Main
{
	public static void main(String[] args)
	{
		Scanner scanner = new Scanner(System.in);
		Repozitorij repozitorij = new Repozitorij();
		
		System.out.print("Upišite godinu: ");
		int godina = 0;
		
		try
		{
			godina = scanner.nextInt();
			
			if(godina < 0)
			{
				System.out.println("Godina ne može biti negativna!");
			}
			
			System.out.println();
			double prosjecnaDnevnaKolicinaMlijeka = repozitorij.dohvatiProsjecnuDnevnuKolicinuMlijeka(godina);
			List<Krava> krave = repozitorij.dohvatiKraveSaViseOdDvadesetLitaraMlijeka(godina);
			
			System.out.println("Prosjecna dnevna kolicina mlijeka u " + godina + ". godini: " + String.format("%.2f", prosjecnaDnevnaKolicinaMlijeka));
			System.out.println("Krave koje su prosjecno dale vise od 20 litara mlijeka u " +  godina + ". godini: ");
			System.out.println();
			
			for(Krava krava : krave)
			{
				System.out.println("Ime: " + krava.getIme() + ", prosjecno litara mlijeka: " + krava.getProsjecnoLitaraMlijeka());
			}			
		}
		
		catch(InputMismatchException ex)
		{
			System.out.println("Unešena vrijednost nije broj!");
		}
	}
}