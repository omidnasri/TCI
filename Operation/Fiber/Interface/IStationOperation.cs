namespace TCI.Operation.Fiber.Interface
{
    public interface IStationOperation:IBaseOperation<Domain.Station,Model.Station>
    {
        Model.Station GetDetails(int id);
    }
}