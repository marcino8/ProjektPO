using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPO
{
    class Zadanie
    {
        DateTime _czasRozpoczecia;
        DateTime _czasZakonczenia;
        string _temat;
        string _tresc;
        bool _wykonane;
        bool opoznienie;
        List<Pracownik> _wykonawcy;
        List<Uwaga> _uwagi;

    }
}
