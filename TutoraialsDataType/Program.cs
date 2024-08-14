namespace TutoraialsDataType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //C# programlama dilinde veri tipleri, programların verileri nasıl sakladığını, işlediğini ve manipüle ettiğini belirler. C#'ta veri tipleri, hem performans hem de hafıza yönetimi açısından önemli bir rol oynar.

            #region TamSayılar (Integer Types)
            //Tam sayılar, ondalık kısımdan yoksun sayılardır ve genellikle çeşitli büyüklüklerde saklanabilirler. 

            //Byte
            Console.WriteLine(nameof(Byte));
            Console.WriteLine($"Alt Limit       : {Byte.MinValue,20}");
            Console.WriteLine($"Üst Limit       : {Byte.MaxValue,20}");
            Console.WriteLine($"Boyut           : {sizeof(Byte),20}");

            Console.WriteLine(new string('*',40));

            //SByte
            Console.WriteLine(nameof(SByte));
            Console.WriteLine($"Alt Limit       : {SByte.MinValue,20}");
            Console.WriteLine($"Üst Limit       : {SByte.MaxValue,20}");
            Console.WriteLine($"Boyut           : {sizeof(SByte),20}");

            Console.WriteLine(new string('*', 40));

            //Short
            Console.WriteLine(nameof(Int16));
            Console.WriteLine($"Alt Limit       : {short.MinValue,20}");
            Console.WriteLine($"Üst Limit       : {short.MaxValue,20}");
            Console.WriteLine($"Boyut           : {sizeof(short),20}");

            Console.WriteLine(new string('*', 40));

            //UShort
            Console.WriteLine(nameof(UInt16));
            Console.WriteLine($"Alt Limit       : {ushort.MinValue,20}");
            Console.WriteLine($"Üst Limit       : {ushort.MaxValue,20}");
            Console.WriteLine($"Boyut           : {sizeof(ushort),20}");

            Console.WriteLine(new string('*', 40));

            //Int
            Console.WriteLine(nameof(Int32));
            Console.WriteLine($"Alt Limit       : {int.MinValue,20}");
            Console.WriteLine($"Üst Limit       : {int.MaxValue,20}");
            Console.WriteLine($"Boyut           : {sizeof(int),20}");

            Console.WriteLine(new string('*', 40));

            //UInt
            Console.WriteLine(nameof(UInt32));
            Console.WriteLine($"Alt Limit       : {uint.MinValue,20}");
            Console.WriteLine($"Üst Limit       : {uint.MaxValue,20}");
            Console.WriteLine($"Boyut           : {sizeof(uint),20}");

            Console.WriteLine(new string('*', 40));

            //Long
            Console.WriteLine(nameof(Int64));
            Console.WriteLine($"Alt Limit       : {long.MinValue,20}");
            Console.WriteLine($"Üst Limit       : {long.MaxValue,20}");
            Console.WriteLine($"Boyut           : {sizeof(long),20}");

            Console.WriteLine(new string('*', 40));

            //ULong
            Console.WriteLine(nameof(UInt64));
            Console.WriteLine($"Alt Limit       : {ulong.MinValue,20}");
            Console.WriteLine($"Üst Limit       : {ulong.MaxValue,20}");
            Console.WriteLine($"Boyut           : {sizeof(ulong),20}");

            Console.WriteLine(new string('*', 40));
            #endregion

            #region OndalıklıSayılar (Floating Point Types)
            Console.WriteLine(nameof(Single));
            Console.WriteLine($"Alt Limit       : {float.MinValue,20}");
            Console.WriteLine($"Alt Limit       : {float.MaxValue,20}");
            Console.WriteLine($"Boyut           : {sizeof(float),20}");

            Console.WriteLine(new string('*', 40));

            Console.WriteLine(nameof(Double));
            Console.WriteLine($"Alt Limit       : {double.MinValue,20}");
            Console.WriteLine($"Alt Limit       : {double.MaxValue,20}");
            Console.WriteLine($"Boyut           : {sizeof(double),20}");

            Console.WriteLine(new string('*', 40));

            Console.WriteLine(nameof(Decimal));
            Console.WriteLine($"Alt Limit       : {decimal.MinValue,20}");
            Console.WriteLine($"Alt Limit       : {decimal.MaxValue,20}");
            Console.WriteLine($"Boyut           : {sizeof(decimal),20}");

            Console.WriteLine(new string('*', 40));
            #endregion

            #region Karakterler (Character Type)
            Console.WriteLine(nameof(Char));
            Console.WriteLine($"Limit           : {1,20}");
            Console.WriteLine($"Boyut           : {sizeof(char),20}");

            Console.WriteLine(new string('*', 40));

            Console.WriteLine(nameof(String));
            Console.WriteLine($"Limit           : {'-',20}");
            Console.WriteLine($"Boyut           : {'-',20}");

            Console.WriteLine(new string('*', 40));
            #endregion

            #region Booleans (Boolean Type)
            Console.WriteLine(nameof(Boolean));
            Console.WriteLine($"Alt Limit       : {false,20}");
            Console.WriteLine($"Üst Limit       : {true,20}");
            Console.WriteLine($"Boyut           : {1,20}");
            #endregion

        }
    }
}
