
namespace Intro.Entities
{
    public class CoorporateCustomer:BaseCustomer
    {
        public string Name { get; set; }
        public string TextNumber { get; set; }

        public static implicit operator CoorporateCustomer(IndividualCustomer v)
        {
            throw new NotImplementedException();
        }
    }
}
