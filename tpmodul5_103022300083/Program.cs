class main {
    static void Main(String[] args) {
        haloGeneric nama = new haloGeneric();
        nama.sapaUser<String>("Jidan");
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


class haloGeneric()
{
    public void sapaUser<Z>(Z user)
    {
        Console.WriteLine("Halo user " + user);
    }
}

