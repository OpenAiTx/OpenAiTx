<div align="right">
  <details>
    <summary >🌐 Dil</summary>
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

## 📖 **Giriş**

> 📚 Projeler  —  seraJs

🔗(Portföy)[https://seraprogrammer.github.io/seraportfolio/] 

🔗(Demo blog)[https://seraprogrammer.github.io/serajsBlogsDemo/] 


```bash
npx degit sera-js/template my-app
cd my-app
```
**SeraJS**, dinamik kullanıcı arayüzleri oluşturmak için kullanılan hafif, **sinyal tabanlı reaktif bir JavaScript kütüphanesidir**.

Sadece **969 bayt gzipped** ve yalnızca **135 satır kod** ile, güçlü reaktiviteyi minimum ek yükle sunan son derece hafif bir reaktif UI kütüphanesidir.

> ⚡️ _SeraJS, geliştirici deneyiminden ödün vermeden **minimalizm** ve **performans**a odaklanır._


*Paket Boyutu Karşılaştırması (Minify + Gzipped)*

| Kütüphane | Boyut (gzipped) | Derleme Adımı Gerekli mi | Ana Amacı | Temel Özellikleri |
|-----------|------------------|-------------------------|-----------|-------------------|
| SeraJS | 1.25kb | Opsiyonel 😎 | Reaktif UI | 135 satır kod, son derece hafif |
| React | ~40kb | Evet | UI bileşenleri | Sanal DOM, bileşen tabanlı mimari, JSX |
| Vue | ~33kb | Opsiyonel | İlerlemeli framework | Reaktif veri bağlama, bileşen sistemi, tek dosya bileşenleri |
| Solid.js | ~7kb | Evet | Reaktif UI | Sanal DOM yok, derlenmiş şablonlar, ince taneli reaktivite |
| Alpine.js | ~7.1kb | Hayır | Hafif framework | Minimum DOM manipülasyonu, deklaratif sözdizimi, mevcut HTML ile çalışır |
| Preact | ~4kb | Evet | React alternatifi | React ile API uyumlu, daha küçük boyut, daha hızlı performans |
| htmx | ~14kb | Hayır | AJAX geliştirmeleri | AJAX için HTML öznitelikleri, minimum JavaScript, sunucu tarafı render dostu |



---

## ⚙️ **Temel Kavramlar**

### 🔄 **Sinyal Tabanlı Reaktivite**

SeraJS, verimli güncellemeler sağlayan modern bir durum yönetimi yaklaşımı olan **sinyal tabanlı bir reaktif sistem** kullanır:

- 🧠 **Sinyaller**  
  Değiştiklerinde aboneleri bilgilendiren, kendi başına yeterli reaktif değerlerdir.

- 🌀 **Effect'ler**  
  Bağımlı oldukları (sinyaller) değiştiğinde otomatik olarak tekrar çalışan fonksiyonlardır.

- 🧭 **Memo**  
  React'ın `useMemo` fonksiyonuna benzer bir önbellekleme yardımcısıdır; reaktif bağımlılıklara dayalı olarak bir hesaplamanın sonucunu gereksiz tekrar hesaplamayı önlemek için önbelleğe alır.

- 🔬 **İnce Taneli Güncellemeler**  
  Yalnızca durum değişikliklerinden etkilenen belirli DOM elemanları güncellenir, böylece minimum yeniden render ve yüksek performans sağlanır.

> 💡 **SeraJS, sezgisel, hızlı ve herhangi bir projeye entegre edilmesi kolay olacak şekilde tasarlanmıştır — modern frontend geliştirme için mükemmel bir tercih!**


## Neden SeraJS?

SeraJS, React, Solid ve Lit gibi kütüphanelerin en iyi yönlerini bir araya getirir — tanıdık kalıpları taze ve minimal bir yaklaşımla harmanlar.

Sadece 1.25KB gzipped ve 135 satır kod ile bu reaktif UI kütüphanesi, ultra hafif kalırken güçlü reaktivite sunar.

İster bir derleme sistemi kullanmak isteyin, ister derlemesiz bir iş akışını tercih edin, SeraJS ihtiyacınızı karşılar. Geliştirme tarzınıza uyacak kadar esnektir — onu *istediğiniz* gibi kullanın.


## 🌱 **Sera.js Temel Örneği**

Sera.js kullanarak bir Merhaba Dünya mesajı gösteren minimal bir örnek.

### 📄 App.jsx










```jsx
import { h } from "serajs";

export default function App() {
  return (
    <h1>Hello world</h1>
  );
}
```
## Derleme Yok, Bağımlılık Yok


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