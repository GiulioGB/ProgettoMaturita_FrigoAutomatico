namespace Frigo
{
    public class Prodotto
    {
        private string nome;
        private string codice;
        private string dataScadenza;

        public Prodotto()
        {
            nome = " ";
            codice = " ";
            dataScadenza = "";
        }
        public Prodotto(string nome, string codice, string dataScadenza)
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
        public string getDataScadenza()
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
        public void setData(string nData)
        {
            dataScadenza = nData;
        }
    }
}