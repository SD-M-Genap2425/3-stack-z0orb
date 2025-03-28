[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/moeBIgL-)
# ds-stack-csharp

## Sub Capaian Pembelajaran

1. Mahasiswa mampu mengimplementasikan konsep struktur data stack
2. Mahasiswa mampu menggunakan struktur data stack buatan sendiri untuk studi kasus tertentu
3. Mahasiswa mampu menggunakan struktur data Stack<> bawaan framework .NET untuk studi kasus tertentu

## Lingkungan Pengembangan

1. Platform: .NET 6.0
2. Bahasa: C# 10
3. IDE: Visual Studio 2022

## Cara membuka project menggunakan Visual Studio

1. Clone repositori project `ds-stack-csharp` ke direktori lokal git Anda.
2. Buka Visual Studio, pilih menu File > Open > Project/Solution > Pilih file *.sln.
3. Tekan tombol Open untuk  untuk membuka solusi.
4. Baca soal dengan seksama. Buat implementasi kode sesuai dengan petunjuk.
6. Jalankan unit test di project *.Tests

> PERINGATAN: Push kode program ke remote repository jika hanya seluruh test case sudah lolos/passed (bertanda hijau).

## Soal-soal

### Soal: Browser History

Buat solusi dari soal ini di project `Solution` folder `BrowserHistory` dengan namespace `Solution.BrowserHistory`.

Anda diminta untuk membuat sistem manajemen history browser sederhana menggunakan konsep Stack tanpa menggunakan kelas Stack bawaan dari .NET library. Sistem ini harus memungkinkan pengguna untuk:

1. Menambahkan URL halaman web yang dikunjungi.
2. Kembali ke halaman sebelumnya.
3. Melihat URL halaman web saat ini tanpa mengubah history.

#### Persyaratan:

1. **Kelas Halaman**: Buat kelas publik `Halaman` yang memiliki satu properti publik: `URL` (string). Kelas ini akan merepresentasikan setiap halaman web yang dikunjungi. Sediakan konstruktor yang menginisialisasi properti `URL`.

2. **Implementasi Stack Manual**: Implementasikan struktur data Stack manual menggunakan linked list untuk menyimpan objek `Halaman`.

3. **Menambahkan Halaman**: Buat metode `KunjungiHalaman` yang menerima parameter `url` (string) dan menambahkannya ke dalam history sebagai halaman terbaru yang dikunjungi.

4. **Kembali ke Halaman Sebelumnya**: Buat metode `Kembali` yang menghapus entri terakhir dari history (halaman saat ini) dan mengembalikan URL halaman sebelumnya. Jika tidak ada halaman sebelumnya, kembalikan nilai `null` atau pesan bahwa tidak ada halaman sebelumnya.

5. **Melihat Halaman Saat Ini**: Buat metode `LihatHalamanSaatIni` yang mengembalikan URL halaman saat ini tanpa mengubah isi dari history.

6. **Tampilkan History**: Opsional, buat metode `TampilkanHistory` yang menampilkan seluruh URL dalam history, dimulai dari yang paling baru dikunjungi.

7. Buat kelas publik `Program` yang berisi metode `Main`. Di dalam `Main`, demonstrasikan penggunaan sistem manajemen history browser ini dengan beberapa skenario, seperti mengunjungi beberapa halaman, kembali ke halaman sebelumnya, dan melihat halaman saat ini.

#### Contoh Implementasi:

Misal, pengguna mengunjungi halaman "google.com", kemudian "example.com", dan terakhir "stackoverflow.com". Sistem harus dapat menangani aksi kembali ke halaman sebelumnya dan menampilkan halaman saat ini dengan benar.

#### Contoh Output:

```
Mengunjungi halaman: google.com
Mengunjungi halaman: example.com
Mengunjungi halaman: stackoverflow.com
Halaman saat ini: stackoverflow.com
Kembali ke halaman sebelumnya...
Halaman saat ini: example.com
Menampilkan history:
1. example.com
2. google.com
```

### Soal: Validasi Kurung dalam Ekspresi

Buat solusi dari soal ini di project `Solution` dalam folder `BracketValidation` dengan namespace `Solution.BracketValidation`.

Anda diminta untuk membuat sistem validasi kurung dalam ekspresi string menggunakan konsep Stack tanpa menggunakan kelas Stack bawaan dari .NET library. Sistem ini harus dapat memvalidasi kurung buka dan tutup dalam ekspresi dan menentukan apakah ekspresi tersebut valid. Ekspresi dapat mengandung kurung `()`, kurawal `{}`, dan siku `[]`.

#### Persyaratan:

1. **Implementasi Stack Manual**: Buat kelas publik `BracketValidator` sebagai stack dan implementasikan struktur data Stack manual menggunakan linked list atau array untuk menyimpan karakter kurung dalam ekspresi.

2. **Validasi Ekspresi**: Di dalam kelas publik `BracketValidator` buat metode `ValidasiEkspresi` yang menerima parameter `ekspresi` (string) dan mengembalikan nilai bertipe `bool`. Metode ini akan mengecek apakah semua jenis kurung dalam ekspresi memiliki pasangan yang benar dan terurut.

3. **Logika Validasi**:
   - Jika karakter adalah kurung buka `(`, kurawal `{`, atau siku `[`, dorong ke dalam stack.
   - Jika karakter adalah kurung tutup `)`, kurawal `}`, atau siku `]`, pop item dari stack dan cek apakah item yang di-pop cocok dengan kurung tutup tersebut.
   - Jika di akhir ekspresi, stack tidak kosong atau ada kurung tutup yang tidak cocok, ekspresi dianggap tidak valid.

4. **Contoh Ekspresi Valid**: `"[{}](){}"`, `"([]{[]})[]{{}()}"`.
5. **Contoh Ekspresi Tidak Valid**: `"(]", "([)]"`, `"{[}"`.

6. Buat kelas publik `Program` yang berisi metode `Main`. Di dalam `Main`, demonstrasikan penggunaan metode `ValidasiEkspresi` dengan beberapa ekspresi sebagai contoh.

#### Contoh Implementasi:

```csharp
public class Program
{
    public static void Main(string[] args)
    {
        string ekspresiValid = "[{}](){}";
        string ekspresiInvalid = "(]";

        Console.WriteLine($"Ekspresi '{ekspresiValid}' valid? {ValidasiEkspresi(ekspresiValid)}");
        Console.WriteLine($"Ekspresi '{ekspresiInvalid}' valid? {ValidasiEkspresi(ekspresiInvalid)}");
    }
}
```

#### Contoh Output:

```
Ekspresi '[{}](){}' valid? True
Ekspresi '(]' valid? False
```

### Soal: Pengecekan Palindrom dengan Stack

Buat solusi dari soal ini di project `Solution` dalam folder `Palindrome` dengan namespace `Solution.Palindrome`.

Anda diminta untuk membuat program yang dapat memeriksa apakah sebuah string adalah palindrom menggunakan konsep Stack dengan memanfaatkan kelas Stack bawaan dari .NET library. Sebuah string dianggap palindrom jika string tersebut dibaca sama dari depan maupun belakang, mengabaikan spasi, tanda baca, dan kapitalisasi.

#### Persyaratan:

1. **Implementasi Stack**: Gunakan kelas Stack bawaan .NET untuk menyimpan karakter-karakter dari string input.

2. **Fungsi Pengecekan Palindrom**: Buat kelas public static `PalindromeChecker` yang didalamnya terdapat fungsi static `CekPalindrom` yang menerima parameter string dan mengembalikan nilai boolean. Fungsi ini harus mengembalikan `true` jika string merupakan palindrom dan `false` jika bukan.

3. **Normalisasi String**: Sebelum melakukan pengecekan, string input harus dinormalisasi dengan menghilangkan spasi, tanda baca, dan mengubah semua huruf menjadi huruf kecil.

4. **Proses Pengecekan**: Gunakan Stack untuk mengecek palindrom. Masukkan setiap karakter dari string yang sudah dinormalisasi ke dalam Stack. Kemudian, gunakan karakter yang di-pop dari Stack untuk membandingkan dengan karakter di string asli (yang telah dinormalisasi). Jika semua karakter cocok, maka string tersebut adalah palindrom.

5. **Demo Program**: Buat kelas `Program` dengan metode `Main` untuk mendemonstrasikan penggunaan fungsi `CekPalindrom`. Coba fungsi tersebut dengan beberapa contoh string palindrom dan bukan palindrom.

#### Contoh Input dan Output:

- Input: "Kasur ini rusak"
  - Output: `true`
- Input: "Ibu Ratna antar ubi"
  - Output: `true`
- Input: "Hello World"
  - Output: `false`

Dalam contoh di atas, kedua string pertama adalah palindrom setelah dinormalisasi dan diabaikan spasi, tanda baca, dan kapitalisasi, sedangkan string terakhir bukan palindrom.

#### Catatan:

- Anda dapat menggunakan fungsi `Replace()`, `ToLower()`, dan `IsLetter()` yang ada pada kelas `String` dan `Char` untuk membantu normalisasi string.
- Demonstrasi program harus mencakup pengujian dengan string palindrom dan bukan palindrom untuk memastikan fungsi bekerja dengan benar.

=== Selesai ===


