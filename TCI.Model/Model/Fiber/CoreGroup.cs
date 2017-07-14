namespace TCI.Model
{
    public class CoreGroup : BaseModel
    {
        public Core FirstCore { get; set; }
        public Core SecondCore { get; set; }
        public string Number => FirstCore.Number + "," + SecondCore.Number;
    }
}
