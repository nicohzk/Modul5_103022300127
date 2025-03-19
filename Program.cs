
class SimpleDataBase<T> { 
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        this.storedData = new List<T>();
        this.inputDates = new List<DateTime>();
    }

    public void AddNewData<T>(T data) {
        dynamic? temp1 = data;
        storedData.Add(temp1);
        inputDates.Add(DateTime.Now);
    }

    public void printAllData() {
        for (int i = 0; i < storedData.Count; i++) {
            Console.WriteLine("Data " + (i + 1) + " berisi: " + storedData[i] + ", yang disimpan pada waktu UTC: " + inputDates[i]);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {

        SimpleDataBase<int> database = new SimpleDataBase<int>();
        database.AddNewData(13);
        database.AddNewData(15);
        database.AddNewData(30);

        database.printAllData();
    }
}