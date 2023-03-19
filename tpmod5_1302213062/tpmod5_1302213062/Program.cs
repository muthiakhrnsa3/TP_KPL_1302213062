using tpmod5_1302213062;

String Nama = Console.ReadLine();
HaloGeneric hg = new HaloGeneric();
hg.SapaUser(Nama);

DataGeneric<String> dg = new DataGeneric<String>("1302213062");
dg.PrintData();