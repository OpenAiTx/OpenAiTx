<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>


![serajs (2)](https://github.com/user-attachments/assets/7ccff260-491d-420b-8e22-4579f9bad50a)

## 📖 **Pendahuluan**

> 📚 Proyek  —  seraJs

🔗(Portofolio)[https://seraprogrammer.github.io/seraportfolio/] 

🔗(Demo blog)[https://seraprogrammer.github.io/serajsBlogsDemo/] 


```bash
npx degit sera-js/template my-app
cd my-app
```
**SeraJS** adalah **library JavaScript reaktif berbasis sinyal** yang ringan
untuk membangun antarmuka pengguna dinamis.

Dengan hanya **969 byte setelah gzip** dan hanya **135 baris kode**, ini adalah library UI reaktif yang sangat ringan — menawarkan reaktivitas yang kuat dengan overhead minimal.

> ⚡️ _SeraJS berfokus pada **minimalisme** dan **performa** tanpa mengorbankan
> pengalaman pengembang._


*Perbandingan Ukuran Bundle (Minified + Gzipped)*

| Library | Ukuran (gzipped) | Butuh Build Step | Tujuan Utama | Fitur Utama |
|---------|------------------|------------------|--------------|-------------|
| SeraJS | 1.25kb | Opsional 😎 | UI Reaktif | 135 baris kode, sangat ringan |
| React | ~40kb | Ya | Komponen UI | Virtual DOM, arsitektur berbasis komponen, JSX |
| Vue | ~33kb | Opsional | Framework progresif | Data binding reaktif, sistem komponen, single-file components |
| Solid.js | ~7kb | Ya | UI Reaktif | Tanpa virtual DOM, template terkompilasi, reaktivitas detail |
| Alpine.js | ~7.1kb | Tidak | Framework ringan | Manipulasi DOM minimal, sintaks deklaratif, bekerja dengan HTML yang ada |
| Preact | ~4kb | Ya | Alternatif React | API kompatibel React, ukuran lebih kecil, performa lebih cepat |
| htmx | ~14kb | Tidak | Peningkatan AJAX | Atribut HTML untuk AJAX, JavaScript minimal, ramah render server |



---

## ⚙️ **Konsep Inti**

### 🔄 **Reaktivitas Berbasis Sinyal**

SeraJS menggunakan **sistem reaktif berbasis sinyal**, pendekatan modern untuk
manajemen state yang memungkinkan pembaruan yang efisien:

- 🧠 **Signal**  
  Nilai reaktif mandiri yang memberi tahu subscriber ketika nilainya berubah.

- 🌀 **Effect**  
  Fungsi yang secara otomatis dijalankan ulang ketika dependensi (signal)  
  mereka berubah.

- 🧭 **Memo**  
  Pembantu memoization mirip dengan React `useMemo`, digunakan untuk menyimpan  
  hasil komputasi berdasarkan dependensi reaktif guna menghindari kalkulasi ulang yang tidak perlu.

- 🔬 **Pembaruan Detail**  
  Hanya elemen DOM spesifik yang terpengaruh oleh perubahan state yang diperbarui,  
  menghasilkan render ulang minimal dan performa tinggi.

> 💡 **SeraJS dirancang agar intuitif, cepat, dan mudah diintegrasikan ke proyek
> mana pun — menjadikannya pilihan sempurna untuk pengembangan frontend modern.**


## Mengapa SeraJS?

SeraJS menggabungkan bagian terbaik dari library seperti React, Solid, dan Lit — memadukan pola yang sudah dikenal dengan pendekatan baru yang minimalis.

Dengan hanya 1,25KB setelah gzip dan 135 baris kode, library UI reaktif ini tetap sangat ringan sekaligus menghadirkan reaktivitas yang kuat.

Apakah Anda ingin sistem build atau lebih suka workflow tanpa build, SeraJS menyediakan keduanya. Cukup fleksibel untuk menyesuaikan gaya kerja Anda — gunakan sesuai *keinginan Anda*.


## 🌱 **Contoh Dasar Sera.js**

Contoh minimal yang menampilkan pesan Hello World menggunakan Sera.js.

### 📄 App.jsx



```jsx
import { h } from "serajs";

export default function App() {
  return (
    <h1>Hello world</h1>
  );
}
```
## Tanpa Build, Tanpa Ketergantungan


```html
<!DOCTYPE html>
<html>
  <head>
    <title>Sera js 😎</title>
  </head>
  <body>
    <script type="module">
      import { h, setSignal, setEffect } from "//unpkg.com/serajs";

      function Hello() {
        const [count, setCount] = setSignal(0);

        setEffect(() => {
          console.log(count());
        });

        return h(
          "div",
          null,
          h("h1", null, "Hello World!"),
          h("p", { style: { color: "red" } }, "Do you Like Serajs?"),
          h("h1", null, () => `Count: ${count()}`),
          h(
            "button",
            { onclick: () => setCount(count() + 1) },
            "Increase Count"
          )
        );
      }

      const root = document.body;
      root.appendChild(Hello());
    </script>
  </body>
</html>
```
<translate-content>
</translate-content>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-16

---