public class Prodotti
{
	Prodotto prodotti[];
	private int numEl;
	
	Prodotti()
	{
		for(int i=0; i<numEl; i++)
		{
			prodotti[i]= Prodotto();
		}
	}
	public int getNumEl()
	{
		return numEl;
	}
	public void aggiungi(Prodotto nProdotto)
	{
		prodotti[numEl] = nProdotto;
		numEl++;
	}	
	public void elimina(string nome)
	{
		for(int i=0; i<numEl; i++)
		{
			if(prodotti[i].getNome() == nome)
			{
				prodotti[i] = Prodotto();
				numEl--;
			}
		}
	}
	public Prodotto ricerca(string nome)
	{
		for(int i=0; i<numEl; i++)
		{
			if(prodotti[i].getNome() == nome)
			{
				return prodotti[i];
			}
		}
	}
	public void visualizza()
	{
		for(int i=0; i<numEl; i++)
		{
			prodotti[i].getNome() + prodotti[i].getCodice() + prodotti[i].getDataScadenza();
		}
	}
}