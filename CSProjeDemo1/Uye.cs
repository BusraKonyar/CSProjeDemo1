using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1
{
    public class Uye : IUye
    {
        
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int UyeNo { get; set; }

        public List<Kitap> OduncKitaplar { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public void OduncAl(Kitap kitap)
        {
            throw new NotImplementedException();
        }

        public void OduncVer(Kitap kitap)
        {
            throw new NotImplementedException();
        }
    }
}
