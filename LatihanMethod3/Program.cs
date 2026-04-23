int jumlahitem;
decimal hargaItem, diskon, totalhargabayar;

static decimal hitungDiskon(int jml_item)
{
    if (jml_item == 5) return 50000m;
    else if (jml_item == 10) return 75000m;
    else return 0;
}

static decimal hitungTotal(int jml_item, decimal hrg_item, decimal diskon_item)
{
    return jml_item * hrg_item - diskon_item;
}

Console.Write("Masukkan Jumlah Item: ");
jumlahitem = int.Parse(Console.ReadLine());

Console.Write("Masukkan Harga Per Item: Rp ");
hargaItem = decimal.Parse(Console.ReadLine());

diskon = hitungDiskon(jumlahitem);

totalhargabayar = hitungTotal(jumlahitem, hargaItem, diskon);

Console.WriteLine($"Total yang harus dibayar adalah Rp {totalhargabayar}");