public class Utente
{
	private string nome;
	private string cognome;
	private char sesso;
	private float peso;
	private float altezza;
	
	Utente()
	{
		nome = " ";
		cognome = " ";
		sesso = ' ';
		peso = 0; 
		altezza = 0;
	}
	Utente(string nome, string cognome, char sesso, float peso, float altezza)
	{
		this.nome = nome;
		this.cognome = cognome;
		this.sesso = sesso;
		this.peso = peso;
		this.altezza = altezza;
	}
	public string getNome()
	{
		return nome;
	}
	public string getCognome()
	{
		return cognome;
	}
	public char getSesso()
	{
		return sesso;
	}
	public float getPeso()
	{
		return peso;
	}
	public float getAltezza()
	{
		return altezza;
	}
	public void setNome(string nNome)
	{
		nome = nNome;
	}
	public void setCognoem(string nCognome)
	{
		cognome = nCognome;
	}
	public void setSesso(char nSesso)
	{
		sesso = nSesso;
	}
	public void setPeso(float nPeso)
	{
		peso = nPeso;
	}
	public void setAltezza(float nAltezza)
	{
		altezza = nAltezza;
	}
}
