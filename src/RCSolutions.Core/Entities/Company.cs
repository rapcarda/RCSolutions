using RCSolutions.CommonCore.DomainObjects;

namespace RCSolutions.Core.Entities
{
    public class Company : EntityBase, IAggregateRoot
    {
        public Company(int code, string name, string tradeName)
        {
            Code=code;
            Name=name;
            TradeName=tradeName;
        }

        public int Code { get; private set; }
        public string Name { get; private set; }
        //Nome Fantasia
        public string TradeName { get; private set; }
    }
}
