<div align="right">
  <details>
    <summary >🌐 Język</summary>
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

## 📖 **Wprowadzenie**

> 📚 Projekty  —  seraJs

🔗(Portfolio)[https://seraprogrammer.github.io/seraportfolio/] 

🔗(Demo blog)[https://seraprogrammer.github.io/serajsBlogsDemo/] 


```bash
npx degit sera-js/template my-app
cd my-app
```
**SeraJS** to lekka, **sygnałowa biblioteka reaktywna JavaScript** do
tworzenia dynamicznych interfejsów użytkownika.

Waży zaledwie **969 bajtów po spakowaniu gzip** i ma tylko **135 linii kodu**, co czyni ją niezwykle lekką biblioteką do reaktywnych UI — oferującą potężną reaktywność przy minimalnym narzucie.

> ⚡️ _SeraJS stawia na **minimalizm** i **wydajność** bez poświęcania
> doświadczenia dewelopera._


*Porównanie wielkości paczek (zminimalizowane + spakowane gzip)*

| Biblioteka | Rozmiar (gzip) | Wymagany build step | Główne zastosowanie | Kluczowe cechy |
|------------|----------------|---------------------|---------------------|----------------|
| SeraJS | 1.25kb | Opcjonalnie 😎 | Reaktywne UI | 135 linii kodu, ekstremalnie lekka |
| React | ~40kb | Tak | Komponenty UI | Wirtualny DOM, architektura oparta na komponentach, JSX |
| Vue | ~33kb | Opcjonalnie | Progresywny framework | Reaktywne wiązanie danych, system komponentów, komponenty SFC |
| Solid.js | ~7kb | Tak | Reaktywne UI | Bez wirtualnego DOM, kompilowane szablony, precyzyjna reaktywność |
| Alpine.js | ~7.1kb | Nie | Lekki framework | Minimalna manipulacja DOM, deklaratywna składnia, współpraca z HTML |
| Preact | ~4kb | Tak | Alternatywa React | API kompatybilne z React, mniejszy rozmiar, szybsze działanie |
| htmx | ~14kb | Nie | Ulepszenia AJAX | Atrybuty HTML do AJAX, minimalny JavaScript, przyjazny SSR |



---

## ⚙️ **Podstawowe Koncepcje**

### 🔄 **Reaktywność Oparta na Sygnałach**

SeraJS używa **systemu reaktywnego opartego na sygnałach**, nowoczesnego podejścia do zarządzania stanem, które umożliwia wydajne aktualizacje:

- 🧠 **Sygnały**  
  Samodzielne wartości reaktywne, które powiadamiają subskrybentów o zmianach.

- 🌀 **Efekty**  
  Funkcje, które automatycznie wykonują się ponownie, gdy ich zależności (sygnały)  
  się zmienią.

- 🧭 **Memo**  
  Pomocnik do memoizacji podobny do Reactowego `useMemo`, używany do cache'owania  
  wyniku obliczeń w oparciu o zależności reaktywne, by unikać zbędnych
  przeliczeń.

- 🔬 **Precyzyjne Aktualizacje**  
  Aktualizowane są tylko te elementy DOM, które są dotknięte zmianami stanu,  
  co prowadzi do minimalnych re-renderów i wysokiej wydajności.

> 💡 **SeraJS został zaprojektowany tak, aby był intuicyjny, szybki i łatwy do integracji z dowolnym projektem — czyniąc go doskonałym wyborem do nowoczesnego frontendu.**


## Dlaczego SeraJS?

SeraJS łączy najlepsze cechy bibliotek takich jak React, Solid i Lit — łącząc znane wzorce z nowym, minimalistycznym podejściem.

Dzięki zaledwie 1.25KB po spakowaniu gzip i 135 liniom kodu, ta reaktywna biblioteka UI pozostaje ultra-lekka, oferując jednocześnie potężną reaktywność.

Czy wolisz system budowania, czy workflow bez kompilacji — SeraJS jest gotowy na obie opcje. Jest wystarczająco elastyczny, by dopasować się do Twojego stylu — używaj go tak, jak *Ty* chcesz.


## 🌱 **Podstawowy przykład Sera.js**

Minimalny przykład wyświetlający komunikat Hello World za pomocą Sera.js.

### 📄 App.jsx




```jsx
import { h } from "serajs";

export default function App() {
  return (
    <h1>Hello world</h1>
  );
}
```
## Brak kompilacji, brak zależności


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





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-16

---