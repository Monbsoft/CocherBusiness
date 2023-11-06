using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Monbsoft.CocherBusiness.Application.Domain;

namespace Monbsoft.CocherBusiness.Infrastructure.Data;

public class CocherDbContext : IdentityDbContext
{
	public CocherDbContext(DbContextOptions<CocherDbContext> options)
		: base(options)
	{

	}

	public DbSet<Project> Projects { get; set; }


}
