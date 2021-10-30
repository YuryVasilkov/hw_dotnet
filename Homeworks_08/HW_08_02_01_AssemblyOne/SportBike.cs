using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_08_02_01_AssemblyOne
{
    public class SportBike : Motorcycle
    {
        //Const
        ushort nameProtected = Motorcycle.speedProtected;
        ushort nameProtectedPrivate = Motorcycle.speedProtectedPrivate;
        //ushort namePrivate = Motorcycle.speedPrivate; доступ только в самом классе
    }
}