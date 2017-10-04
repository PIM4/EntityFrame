using Model.Entity;

namespace Model.Entity
{
	public class Endereco : Pessoa
	{
		private string logradouro;

		private int numero;

		private string complemento;

		private string bairro;

		private string cep;

		private string cidade;

		private string estado;

		private Pessoa pessoa;

		private string descricao;

		public Endereco(string cep, string log, int n, string b, string c, Pessoa p)
		{

		}

		public string getLogradouro()
		{
			return null;
		}

		public void setNumero(int n)
		{

		}

		public int getNumero()
		{
			return 0;
		}

		public void setComplemento(string comp)
		{

		}

		public string getComplemento()
		{
			return null;
		}

		public string getBairro()
		{
			return null;
		}

		public string getCep()
		{
			return null;
		}

		public void getCidade():string()
		{

		}

		public Pessoa getPessoa()
		{
			return null;
		}

	}

}

