using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace PrograConcurrente
{
    internal class EfAsync
    {
        private readonly DbSet<Persona> Personas;

        public async Task<List<Persona>> Run()
        {
            return await Personas
                .Where(x => x.Name.StartsWith("F"))
                .OrderBy(x => x.Id)
                .ToListAsync();
        }
    }

    internal class Persona
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
