using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ScriptureJournal.Models;

namespace ScripturesJournal.Models
{
    public class ScripturesJournalContext : DbContext
    {
        public ScripturesJournalContext (DbContextOptions<ScripturesJournalContext> options)
            : base(options)
        {
        }

        public DbSet<ScriptureJournal.Models.Scripture> Scripture { get; set; }
    }
}
