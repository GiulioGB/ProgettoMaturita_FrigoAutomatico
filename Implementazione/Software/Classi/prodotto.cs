public class Prodotto
{
	private string nome;
	private string codice;
	private CData dataScadenza;
	
	Prodotto()
	{
		nome = " ";
		codice = " ";
		dataScadenza = ;
	}
	prodotto(string nome, string codice, CData dataScadenza)
	{
		this.nome = nome;
		this.codice = codice;
		this.dataScadenza = dataScadenza;
	}
	public string getNome()
	{
		return nome;
	}
	public string getCodice()
	{
		return codice;
	}
	public CData getDataScadenza()
	{
		return dataScadenza;
	}
	public void setNome(string nNome)
	{
		nome = nNome;
	}
	public void setCodice(string nCodice)
	{
		codice = nCodice;
	}
	public void setData(CData nData)
	{
		dataScadenza = nData;
	}
}