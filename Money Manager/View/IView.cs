using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money_Manager.View
{
    internal interface IView
    {  
        decimal InputBudget { get; }
        event EventHandler<EventArgs> GetBudget;
        void SetBudget(decimal value);
    }
}
