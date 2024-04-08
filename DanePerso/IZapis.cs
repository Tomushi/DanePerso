using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanePerso
{
    public interface IZapis
    {
        void ZapisRasy(List<Rasa> rasas);
        List<Rasa> ZaladujRasy { get; }

        void ZapiszRasy(List<Rasa> rasas);
    }
}
