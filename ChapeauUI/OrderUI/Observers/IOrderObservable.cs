using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauUI.OrderUI.Observers
{
    public interface IOrderObservable
    {
        void SetObserver(IOrderObserver observer);
        void NotifyObserver();
    }
}
