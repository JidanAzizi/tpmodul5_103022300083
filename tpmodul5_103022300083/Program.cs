class main {
    static void Main(String[] args) {
        haloGeneric nama = new haloGeneric();
        nama.sapaUser<String>("Jidan");

    }
}

class haloGeneric() {
    public void sapaUser<Z>(Z user ) {
        Console.WriteLine("Halo user " + user);
    }
}
