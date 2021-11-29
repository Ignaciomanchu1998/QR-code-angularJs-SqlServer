namespace QRCode.Dao.Utils
{
    public class StructureResponse
    {
        public string code { get; set; } = "";
        public string message { get; set; } = "";
        public string messageTitle { get; set; } = "";
        public dynamic payload { get; set; }
    }
}
