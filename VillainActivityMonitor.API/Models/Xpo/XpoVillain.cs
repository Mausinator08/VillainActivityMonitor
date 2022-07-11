using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevExpress.Xpo;

namespace VillainActivityMonitor.API.Models.Xpo
{
    public class XpoVillain : XPObject
    {
        public XpoVillain(Session session) : base(session) {}

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        string name = string.Empty;
        string firstName = string.Empty;
        string lastName = string.Empty;
        string alias = string.Empty;

        public string Name 
        { 
            get { return name; } 
            set { SetPropertyValue(nameof(Name), ref name, value); } 
        }

        public string FirstName
        {
            get { return firstName; }
            set { SetPropertyValue(nameof(FirstName), ref firstName, value); }
        }

        public string LastName
        {
            get { return lastName; }
            set { SetPropertyValue(nameof(LastName), ref lastName, value); }
        }

        public string Alias
        {
            get { return alias; }
            set { SetPropertyValue(nameof(Alias), ref alias, value); }
        }
    }
}