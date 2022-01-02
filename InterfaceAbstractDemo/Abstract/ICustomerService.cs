using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Abstract
{
    interface ICustomerService //temel interface görevi görecek
    {
        void Save(Customer customer);
    }
}
