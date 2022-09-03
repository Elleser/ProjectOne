using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Notes.Domain.Models;

namespace Notes.Application.Interfaces
{
    public interface INotesDbContext
    {

        DbSet<Note> Notes { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);

    }
}
