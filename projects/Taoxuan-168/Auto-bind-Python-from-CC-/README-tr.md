
<div align="right">
  <details>
    <summary >🌐 Dil</summary>
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

CC++'dan Python'a Otomatik Bağlama
===================

> C/C++ kodlarından Python koduna otomatik olarak bağlama ve whl paketi oluşturma için yeterince basit, kullanışlı ve yapılandırılabilir bir proje

> Bu proje şu depodan çatallanmıştır:
https://github.com/Neutree/c_cpp_project_framework
ve derleme kodu kısmı orijinal depo ile tamamen uyumludur

> pybind11 otomatik bağlama kısmı için referans kodu:
https://github.com/sipeed/MaixPy/tree/main/components/maix


## Hızlı Başlangıç

* 1. Bu depoyu klonlayın ve /examples/demo dizinine girin
python project.py menuconfig komutunu kullanarak grafik arayüzde derleyici zinciri ve whl dosyası paketleme yapılandırmasını yapın
![alt text](https://raw.githubusercontent.com/Taoxuan-168/Auto-bind-Python-from-CC-/main/./assets/image.png)
> Burada x86 yerel makinede derleme içindir, arm64 MaixCam2 için derleme içindir, RISCV64 ise MaiCam/Pro için derleme içindir
![alt text](https://raw.githubusercontent.com/Taoxuan-168/Auto-bind-Python-from-CC-/main/./assets/image-1.png)
* 2. Bir C/C++ fonksiyonu ve hpp başlık dosyası yazın, dosya adı whl paket adıyla aynı olmalıdır, böylece otomatik olarak tanınabilir:
```C++
namespace add::test
{
    int add(int a, int b) 
    {
        return a + b;
    }
}
```
İlgili fonksiyon için @modul açıklamasını yazın, ardından fonksiyon yolunu ekleyin:
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
İlk satır fonksiyon tanıtımıdır, @param parametre tanıtımıdır, @return ise dönüş değeri tanıtımıdır (boş olabilir)
Sadece derleme ve whl dosyası olarak paketleme gerekiyorsa main.cpp dosyasını değiştirmenize gerek yoktur
python project build komutunu kullanarak derleme ve whl dosyası paketleme işlemini başlatabilirsiniz
Derleme sonrası whl dosyasını kurduktan sonra doğrudan çağırabilirsiniz:
```Python
import add
add.test.add(1,1)
```
Dikkat:
-   Bir başlık dosyası bir modül adını temsil eder, içe aktarılacak modülü belirtir, örneğin add.hpp dosyası import add ile eşleşir, modül adı mutlaka add ile başlamalıdır
-   cpp_bind_python.py doğrudan çalıştırılırsa sadece bağlanmış cpp dosyası oluşturulur, --doc DOC parametresi eklenirse açıklamalardan otomatik olarak dokümantasyon oluşturulabilir

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-06

---