
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parcial_Ing_Soft.Helpers
{
    interface IClosableViewModel
    {
        event EventHandler CloseWindowEvent;
    }
}
