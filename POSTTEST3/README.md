# KartuKomunitas - VB.NET WinForms (POSTTEST 2)

## Cara Menjalankan

### Prasyarat
- **Visual Studio 2019 atau 2022** dengan workload ".NET desktop development"
- Atau **.NET 6 SDK** (https://dotnet.microsoft.com/download)

### Langkah
1. Ekstrak ZIP ini
2. Buka **Visual Studio**
3. `File > Open > Project/Solution`
4. Pilih file `KartuKomunitas.vbproj`
5. Tekan **F5** atau klik tombol ▶ Run

### Atau via Terminal/Command Prompt
```
cd KartuKomunitas
dotnet run
```

## Fitur Program

### Form 1 – Form Cetak
- Upload foto profil (Browse)
- Input **Nama** → hanya huruf
- Input **Umur** → hanya angka  
- Input **No. Telepon** → hanya angka
- Input **Alamat**
- **DateTimePicker** untuk tanggal lahir
- **GroupBox Jenis Kelamin** (RadioButton Laki-Laki / Perempuan)
- **GroupBox Hobby** (12 CheckBox: Gaming, Coding, Traveling, Menggambar, Menulis, Memancing, Membaca, Olahraga, Menyanyi, Menari, Memasak, Fotografi)
- Error handling semua inputan kosong
- Tombol **Cetak Kartu**

### Form 2 – Hasil Kartu
- Kartu bergaya dengan header gradient biru navy
- Foto profil di kartu
- Menampilkan semua data inputan
- Footer bergaya
- Tombol kembali

## Struktur File
```
KartuKomunitas/
├── KartuKomunitas.vbproj   ← File project
└── KartuKomunitas.vb       ← Semua kode (Form1, Form2, DataModule, Program)
```
