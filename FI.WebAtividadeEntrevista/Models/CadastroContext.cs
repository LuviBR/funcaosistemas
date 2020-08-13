using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebAtividadeEntrevista.Models
{
	public class CadastroContext : DbContext
	{
		public CadastroContext() : base("BancoDeDados")
		{
		}

		public DbSet<ClienteModel> Clientes { get; set; }
	}
}