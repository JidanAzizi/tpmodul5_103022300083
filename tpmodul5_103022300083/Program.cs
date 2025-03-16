class main {
    static void Main(String[] args) {
        dataGeneric<String> z = new dataGeneric<string>("103022300083");
        z.printData();
    }
}

class dataGeneric<Z> {
    Z data;

    public dataGeneric(Z data) {
        this.data = data;
    }

    public void printData() {
        Console.WriteLine("Data yang tersimpan adalah: " + data);
    }
}
