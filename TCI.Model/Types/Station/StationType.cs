using System.Drawing;

namespace TCI.Model.Types.Station
{
    public abstract class StationType
    {
        public abstract bool HaveCableRoom { get; }
        public abstract bool HaveOcdf { get; }
        public abstract Image Image { get; }
    }
}