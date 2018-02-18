using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransActionApplication
{
    public interface ITransaction
    {
        string ShowTransaction();
        float GetAmount();
    }
}
