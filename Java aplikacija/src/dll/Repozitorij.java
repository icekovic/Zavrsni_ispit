package dll;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;
import javax.sql.DataSource;
import com.microsoft.sqlserver.jdbc.SQLServerDataSource;
import model.Krava;

public class Repozitorij
{
	public Repozitorij()
	{
		
	}
	
	private static DataSource kreirajDataSource()
	{
		SQLServerDataSource dataSource = new SQLServerDataSource();
		dataSource.setServerName("localhost");
		dataSource.setDatabaseName("ZavrsniIspit");
		dataSource.setUser("sa");
		dataSource.setPassword("SQL");
		
		return dataSource;
	}
	
	public double dohvatiProsjecnuDnevnuKolicinuMlijeka(int godina)
	{
		DataSource dataSource = kreirajDataSource();
		double prosjecnaDnevnaKolicinaMlijeka = 0;
		
		try
		{
			Connection connection = dataSource.getConnection();
			CallableStatement statement = connection.prepareCall("{call DnevnaProsjecnaKolicinaMlijeka(?)}");
			statement.setInt("godina", godina);
			
			ResultSet resultSet = statement.executeQuery();
			if(resultSet.next())
			{
				prosjecnaDnevnaKolicinaMlijeka = resultSet.getFloat(1);
			}
		}
		catch (SQLException e)
		{
			e.printStackTrace();
		}
		
		return prosjecnaDnevnaKolicinaMlijeka;
	}
	
	public List<Krava> dohvatiKraveSaViseOdDvadesetLitaraMlijeka(int godina)
	{
		DataSource dataSource = kreirajDataSource();
		List<Krava> krave = new ArrayList<>();
		
		try
		{
			Connection connection = dataSource.getConnection();
			CallableStatement statement = connection.prepareCall("{call KraveZadanaGodinaViseOdDvadesetLitaraMlijeka(?)}");
			statement.setInt("godina", godina);
			ResultSet resultSet = statement.executeQuery();
			
			while(resultSet.next())
			{
				Krava krava = new Krava();
				krava.setIme(resultSet.getString("Krava"));	//za nazive stupaca su upisani onako kako se vracaju (npr Ime as Krava - upisuje se Krava)
				krava.setDatumRodjenja(resultSet.getString("Datum rodjenja"));
				krava.setDatumDolaskaNaFarmu(resultSet.getString("Datum dolaska na farmu"));
				krava.setJedinstveniVeterinarskiBroj(resultSet.getString("Jedinstveni veterinarski broj"));
				krava.setBrojTeladi(resultSet.getInt("Broj teladi"));
				krava.setProsjecnoLitaraMlijeka(resultSet.getFloat("Prosjecna kolicina mlijeka"));
				krave.add(krava);
			}
		}
		catch (SQLException e)
		{
			e.printStackTrace();
		}
		
		return krave;
	}
}
