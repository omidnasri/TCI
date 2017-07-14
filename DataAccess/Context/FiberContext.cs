using System.Data.Entity;
using TCI.DataAccess.Interface;
using TCI.Domain;

namespace TCI.DataAccess.Context
{
    public class FiberContext : TciContext, IFiberUnitOfWork
    {
        public FiberContext()
            : base("FiberConnectionString")
        {
        }

        public DbSet<Station> Stations { get; set; }
        public DbSet<CableRoom> CableRooms { get; set; }
        public DbSet<OcdfRoom> OcdfRooms { get; set; }
        public DbSet<Cable> Cables { get; set; }
        public DbSet<Loz> Lozes { get; set; }
        public DbSet<Core> Cores { get; set; }
        public DbSet<Ocdf> Ocdfs { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Cassette> Cassettes { get; set; }
        public DbSet<Odf> Odfs { get; set; }
        public DbSet<OdfItem> OdfItems { get; set; }
        public DbSet<LineSystem> LineSystems { get; set; }
        public DbSet<LineSystemItem> LineSystemItems { get; set; }
    }
}
