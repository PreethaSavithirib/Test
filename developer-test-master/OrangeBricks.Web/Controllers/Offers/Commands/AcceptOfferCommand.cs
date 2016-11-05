namespace OrangeBricks.Web.Controllers.Offers.Commands
{
    public class AcceptOfferCommand
    {
        public int PropertyId { get; set; }

        public int OfferId { get; set; }

        public string OfferedBy { get; set; }
    }
}