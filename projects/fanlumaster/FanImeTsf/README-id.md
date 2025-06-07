## FanImeTsf

Ini adalah TSF dari [FanImeServer](https://github.com/fanlumaster/FanImeServer).

Catatan: saat ini hanya mendukung aplikasi 64-bit.

## Cara membangun

### Prasyarat

- Visual Studio 2022
- CMake
- vcpkg
- Python3
- gsudo

Pastikan vcpkg dan gsudo telah terinstal melalui **Scoop**.

## Langkah Build

### Build

Pertama, clone repository,

```powershell
git clone --recursive https://github.com/fanlumaster/FanImeTsf.git
```

Kemudian, siapkan lingkungan,

```powershell
cd FanImeTsf
python .\scripts\prepare_env.py
```

Lalu, build,

```powershell
.\scripts\lcompile.ps1
```

### Instalasi

Jalankan Powershell sebagai administrator, pastikan Anda telah mengaktifkan opsi sistem `Enable sudo`.

![](https://i.postimg.cc/zJCn9Cnn/image.png)

Kemudian, buat folder di `C:\Program Files\` dengan nama `FanImeTsf`, dan salin `FanImeTsf.dll` ke dalamnya,

```powershell
gsudo
Copy-Item -Path ".\FanImeTsf\build64\Debug\FanImeTsf.dll" -Destination "C:\Program Files\FanImeTsf"
```

Selanjutnya, instal,

```powershell
cd "C:\Program Files\FanImeTsf"
sudo regsvr32 .\FanImeTsf.dll
```

### Uninstalasi

```powershell
cd "C:\Program Files\FanImeTsf"
sudo regsvr32 /u .\FanImeTsf.dll
```

## Tangkapan Layar

![](https://i.postimg.cc/v8Bpx6Gf/image.png)

![](https://i.postimg.cc/ssBgtM5M/image.png)

![](https://i.postimg.cc/ryDqXH0B/image.png)

![](https://i.postimg.cc/2m9WJTgR/image.png)

![](https://i.postimg.cc/L96qQZT8/image.png)

![](https://i.postimg.cc/FNcz9QTv/image.png)

## Roadmap

Saat ini hanya mendukung Xiaohe Shuangpin.

### Bahasa Tionghoa

- Xiaohe Shuangpin
- Quanpin
- Kode bantu dalam penggunaan Komponen Hanzi
- Kamus yang dapat dikustomisasi
- Mesin IME yang dapat dikustomisasi
- Skin yang dapat dikustomisasi
- Beralih antara Bahasa Mandarin Sederhana dan Tradisional
- Autocomplete Bahasa Inggris
- API Cloud IME sumber terbuka
- Beralih tampilan jendela kandidat antara mode vertikal dan horizontal
- Sakelar fitur: sebagian besar fitur harus dapat diubah atau dikustomisasi oleh pengguna

### Dukungan Bahasa Jepang

Mungkin menjadi proyek lain.

Dan mungkin juga dukungan untuk beberapa bahasa lainnya.

### Referensi

- [MS-TSF-IME-Demo](https://github.com/microsoft/Windows-classic-samples/tree/main/Samples/IME/cpp/SampleIME)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---