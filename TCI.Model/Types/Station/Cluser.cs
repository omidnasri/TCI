using System.Drawing;
using TCI.Model.Resource;

namespace TCI.Model.Types.Station
{
    public class Cluser : StationType
    {
        public override bool HaveCableRoom => false;
        public override bool HaveOcdf => false;
        public override Image Image => ImageResource.Cluser;
    }
}
