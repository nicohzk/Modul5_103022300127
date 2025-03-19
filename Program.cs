using System.Runtime;

class PemrosesData {

    public T DapatkanNilaiTerbesar<T>(T inp,T inp2,T inp3) {
        dynamic temp1 = (dynamic)inp;
        dynamic temp2 = (dynamic)inp2;
        dynamic temp3 = (dynamic)inp3;

        dynamic? Largest = temp1;
        if (Largest < temp2) {
            Largest = temp2;
        }
        if(Largest < temp3) {
            Largest = temp3;
        }
        return Largest;

    }
}

class Program
{
    static void Main(string[] args)
    {
        PemrosesData data = new PemrosesData();
        int x = data.DapatkanNilaiTerbesar<int>(10, 11, 12);
        Console.WriteLine(x);
    }
}