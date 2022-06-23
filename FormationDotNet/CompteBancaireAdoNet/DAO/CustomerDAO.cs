using CompteBancaireAdoNet.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompteBancaireAdoNet.DAO
{
    public class CustomerDAO : BaseDAO<Customer>
    {
        public override Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public override List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public override bool Save(Customer element)
        {
            throw new NotImplementedException();
        }
    }
}
