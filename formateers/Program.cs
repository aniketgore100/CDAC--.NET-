using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Formateers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinaryFormatterSerialize();
        }

        private static void BinaryFormatterSerialize()
        {
            Class1 o = new Class1();
            o.i = 100;
            o.p1 = "aaa";
            o.P2 = 200;
            BinaryFormatter bf = new BinaryFormatter();
            Stream s = new FileStream("d:\\aniket\\ani.dat", FileMode.Create);
#pragma warning disable SYSLIB0011

            bf.Serialize(s, o);
#pragma warning restore SYSLIB0011
            s.Close();
        }

       
    }

    [Serializable]
    public class Class1
    {
        private int private_data;
        public int i;
        [XmlElement]
        public string p1
        {
            get;
            set;
        }
        private int mP2;
        [XmlAttribute]
        public int P2
        {
            get { return mP2; }
            set { mP2 = value; }
        }
    }
}