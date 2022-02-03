using System.Globalization;
namespace degiskenler{
    class Program{
 static void Main(string[] args)
    {
             Console.WriteLine("");

             byte b=5;    // 1 byte
             sbyte c=5;   // 1 byte
             short s=5;   // 2 byte
             ushort us=5;  // 2 byte

             Int16 i16=2; //2 byte
             int i=2;     //4 byte
             Int32 i32= 2; //4 byte
             Int64 i64=2;  //8 byte

             uint ui=2;  //4 byte
             long l=4;  //8 byte
             ulong ul=4;  //8 byte

             //reel sayılar
             float f = 5;  //4 byte
             double d= 5;  //8 byte
             decimal de=5; //16 byte

             char ch = '2'; //2 byte
             string str="Furkancan"; //sınırsız

             bool b1= true;
             bool b2= false;

             DateTime dt= DateTime.Now;
             Console.WriteLine(dt);

             object o1 = "a";
             object o2= 'f';
             object o3= 7;
             object o4 = 4.3;

             // string ifadeler

             string str1= ""; //string str1=null; - string str1= string.Empty;
             str1="Furkancan Bektaş";
             string ad="Furkancan";
             string soyad="Bektaş";
             string tamısım= ad + ""+ soyad;

             //integer tanımlama şekilleri
             
             int integer1=4;
             int integer2=5;
             int integer3=integer1 * integer2;

             //boolen
             bool bool1= 10<2; //false gelir
             bool bool2 =10>2; //true gelir
             
             //Değişken dönüşümleri
             string str20="20";
             int int20=22;            
             string yenideger=str20 + int20.ToString();
             Console.WriteLine(yenideger); // çıktısı 2022

             int int21 = int20 + Convert.ToInt32(str20);
             Console.WriteLine(int21); // çıktısı 42

             int int22 = int20 + int.Parse(str20); // çıktısı 42

             // datetime
             string datetime = DateTime.Now.ToString("dd.MM.yyyy");
             Console.WriteLine(datetime); //çıktısı noktalı şekilde gelir

              string datetime2 = DateTime.Now.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
              Console.WriteLine(datetime2); //çıktısı slash şekilde gelir

              string hour = DateTime.Now.ToString("HH:mm");
              Console.WriteLine(hour);



    }

 }
   
}