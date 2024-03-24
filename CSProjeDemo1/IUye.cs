using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1
{
    public interface IUye
    {
        
        List<Kitap> OduncKitaplar { get; set; }

        void OduncAl(Kitap kitap);
        void OduncVer(Kitap kitap);
    }
}
