package model;

public class Krava
{
	private int idKrava;
	private String ime;
	private String datumRodjenja;
	private String datumDolaskaNaFarmu;
	private String jedinstveniVeterinarskiBroj;
	private int brojTeladi;
	private double prosjecnoLitaraMlijeka;
	private int pasminaId;
	
	public Krava()
	{
		
	}

	public int getIdKrava()
	{
		return idKrava;
	}

	public void setIdKrava(int idKrava)
	{
		this.idKrava = idKrava;
	}

	public String getIme()
	{
		return ime;
	}

	public void setIme(String ime)
	{
		this.ime = ime;
	}

	public String getDatumRodjenja()
	{
		return datumRodjenja;
	}

	public void setDatumRodjenja(String datumRodjenja)
	{
		this.datumRodjenja = datumRodjenja;
	}

	public String getDatumDolaskaNaFarmu()
	{
		return datumDolaskaNaFarmu;
	}

	public void setDatumDolaskaNaFarmu(String datumDolaskaNaFarmu)
	{
		this.datumDolaskaNaFarmu = datumDolaskaNaFarmu;
	}

	public String getJedinstveniVeterinarskiBroj()
	{
		return jedinstveniVeterinarskiBroj;
	}

	public void setJedinstveniVeterinarskiBroj(String jedinstveniVeterinarskiBroj)
	{
		this.jedinstveniVeterinarskiBroj = jedinstveniVeterinarskiBroj;
	}

	public int getBrojTeladi()
	{
		return brojTeladi;
	}

	public void setBrojTeladi(int brojTeladi)
	{
		this.brojTeladi = brojTeladi;
	}

	public double getProsjecnoLitaraMlijeka()
	{
		return prosjecnoLitaraMlijeka;
	}

	public void setProsjecnoLitaraMlijeka(double prosjecnoLitaraMlijeka)
	{
		this.prosjecnoLitaraMlijeka = prosjecnoLitaraMlijeka;
	}

	public int getPasminaId()
	{
		return pasminaId;
	}

	public void setPasminaId(int pasminaId)
	{
		this.pasminaId = pasminaId;
	}
}
