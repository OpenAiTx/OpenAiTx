
<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

Auto bind Python dari CC++
===================

> Proyek yang cukup sederhana, mudah digunakan, dan dapat dikonfigurasi untuk secara otomatis mengikat kode C/C++ menjadi kode Python serta menghasilkan paket whl

> Proyek ini dikloning dari:
https://github.com/Neutree/c_cpp_project_framework
dan bagian kompilasi kode tetap sama persis dengan repositori aslinya

> Referensi kode untuk binding otomatis pybind11:
https://github.com/sipeed/MaixPy/tree/main/components/maix

## Mulai Cepat

* 1. Kloning repositori ini, masuk ke direktori /examples/demo
Gunakan python project.py menuconfig untuk masuk ke antarmuka grafis konfigurasi toolchain kompilasi dan apakah ingin membuat file whl
![alt text](https://raw.githubusercontent.com/Taoxuan-168/Auto-bind-Python-from-CC-/main/./assets/image.png)
> x86 adalah untuk kompilasi di mesin lokal, arm64 untuk kompilasi MaixCam2, RISCV64 untuk kompilasi MaiCam/Pro
![alt text](https://raw.githubusercontent.com/Taoxuan-168/Auto-bind-Python-from-CC-/main/./assets/image-1.png)
* 2. Tulis sebuah fungsi C/C++, dan file header hpp, nama file harus sesuai dengan nama paket whl, agar mudah dikenali secara otomatis:

```C++
namespace add::test
{
    int add(int a, int b) 
    {
        return a + b;
    }
}
```
Tuliskan komentar @modul untuk fungsi terkait, diikuti dengan jalur fungsi:
```C++
namespace add::test
{
    /**
     * My function, add two integer.
     * @param a arg a, int type
     * @param b arg b, int type
     * @return int type, will a + b
     * @module add.test.add
     */
    int add(int a, int b);
}
```
Baris pertama adalah pengenalan fungsi, @param adalah pengenalan parameter, @return adalah pengenalan nilai kembali (boleh kosong)
Jika hanya perlu mengompilasi dan membungkus menjadi file whl maka tidak perlu mengubah main.cpp
Gunakan python project build untuk mulai mengompilasi dan membungkus file whl
Setelah mengompilasi dan menginstal file whl, dapat langsung dipanggil:
```Python
import add
add.test.add(1,1)
```
Catatan:
-   Satu file header mewakili satu nama modul, menunjukkan modul yang akan di-import, misalnya add.hpp sesuai dengan import add, nama modulnya harus diawali dengan add
-   Menjalankan cpp_bind_python.py secara langsung hanya akan menghasilkan file cpp yang sudah di-bind, tambahkan parameter --doc DOC untuk secara otomatis menghasilkan dokumentasi dari komentar

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-06

---