package model;

public class DnevnaProizvodnjaMlijeka
{
	private int idDnevnaProizvodnjaMlijeka;
	private int kolicinaMlijekaLitre;
	private double prosjecniPostotakMasnoce;
	private double posjecniPostotakMikroorganizama;
	private int kravaId;
	
	public DnevnaProizvodnjaMlijeka()
	{
		
	}

	public int getIdDnevnaProizvodnjaMlijeka()
	{
		return idDnevnaProizvodnjaMlijeka;
	}

	public void setIdDnevnaProizvodnjaMlijeka(int idDnevnaProizvodnjaMlijeka)
	{
		this.idDnevnaProizvodnjaMlijeka = idDnevnaProizvodnjaMlijeka;
	}

	public int getKolicinaMlijekaLitre()
	{
		return kolicinaMlijekaLitre;
	}

	public void setKolicinaMlijekaLitre(int kolicinaMlijekaLitre)
	{
		this.kolicinaMlijekaLitre = kolicinaMlijekaLitre;
	}

	public double getProsjecniPostotakMasnoce()
	{
		return prosjecniPostotakMasnoce;
	}

	public void setProsjecniPostotakMasnoce(double prosjecniPostotakMasnoce)
	{
		this.prosjecniPostotakMasnoce = prosjecniPostotakMasnoce;
	}

	public double getPosjecniPostotakMikroorganizama()
	{
		return posjecniPostotakMikroorganizama;
	}

	public void setPosjecniPostotakMikroorganizama(double posjecniPostotakMikroorganizama)
	{
		this.posjecniPostotakMikroorganizama = posjecniPostotakMikroorganizama;
	}

	public int getKravaId()
	{
		return kravaId;
	}

	public void setKravaId(int kravaId)
	{
		this.kravaId = kravaId;
	}
}
