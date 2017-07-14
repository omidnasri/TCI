namespace TCI.Model
{
    public class OdfItemGroup : BaseModel
    {
        public OdfItem FirstOdfItem { get; set; }
        public OdfItem SecondOdfItem { get; set; }

        public string Number => FirstOdfItem.Number + "," + SecondOdfItem.Number;
    }
}
