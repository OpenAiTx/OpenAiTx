<div align="right">
  <details>
    <summary >🌐 Язык</summary>
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

## 📖 **Введение**

> 📚 Проекты — seraJs

🔗(Портфолио)[https://seraprogrammer.github.io/seraportfolio/] 

🔗(Демо блог)[https://seraprogrammer.github.io/serajsBlogsDemo/] 


```bash
npx degit sera-js/template my-app
cd my-app
```
**SeraJS** — это легковесная, **сигнально-реактивная библиотека JavaScript** для создания динамических пользовательских интерфейсов.

Всего лишь **969 байт в сжатом виде (gzipped)** и только **135 строк кода** — это удивительно лёгкая реактивная библиотека для UI, предлагающая мощную реактивность с минимальными издержками.

> ⚡️ _SeraJS делает упор на **минимализм** и **производительность**, не жертвуя удобством для разработчика._


*Сравнение размера бандла (Минифицированный + Gzipped)*

| Библиотека | Размер (gzipped) | Требуется сборка | Основное назначение | Ключевые особенности |
|------------|------------------|------------------|---------------------|---------------------|
| SeraJS | 1.25kb | Необязательно 😎 | Реактивный UI | 135 строк кода, крайне легковесна |
| React | ~40kb | Да | UI-компоненты | Виртуальный DOM, компонентная архитектура, JSX |
| Vue | ~33kb | Необязательно | Прогрессивный фреймворк | Реактивное связывание данных, система компонентов, однострочные компоненты |
| Solid.js | ~7kb | Да | Реактивный UI | Без виртуального DOM, компилируемые шаблоны, детальная реактивность |
| Alpine.js | ~7.1kb | Нет | Легковесный фреймворк | Минимальная работа с DOM, декларативный синтаксис, работает с существующим HTML |
| Preact | ~4kb | Да | Альтернатива React | Совместимость API с React, меньший размер, высокая производительность |
| htmx | ~14kb | Нет | Улучшения AJAX | HTML-атрибуты для AJAX, минимум JavaScript, дружественность к серверному рендерингу |



---

## ⚙️ **Основные концепции**

### 🔄 **Сигнально-реактивный подход**

SeraJS использует **сигнально-реактивную систему**, современный подход к управлению состоянием, обеспечивающий эффективные обновления:

- 🧠 **Сигналы**  
  Автономные реактивные значения, уведомляющие подписчиков при изменении.

- 🌀 **Эффекты**  
  Функции, которые автоматически выполняются повторно при изменении их зависимостей (сигналов).

- 🧭 **Memo**  
  Вспомогательная функция мемоизации, похожая на React `useMemo`, используется для кеширования результата вычисления на основе реактивных зависимостей, чтобы избежать лишних пересчётов.

- 🔬 **Точные обновления**  
  Обновляются только конкретные элементы DOM, затронутые изменениями состояния, что приводит к минимальному повторному рендерингу и высокой производительности.

> 💡 **SeraJS создана так, чтобы быть интуитивной, быстрой и лёгкой для интеграции в любой проект — идеальный выбор для современного фронтенд-разработчика.**


## Почему SeraJS?

SeraJS объединяет лучшие черты таких библиотек, как React, Solid и Lit — сочетая знакомые паттерны с новым минималистичным подходом.

Всего 1,25КБ в сжатом виде и только 135 строк кода — эта реактивная библиотека для UI остаётся ультралёгкой, но при этом обеспечивает мощную реактивность.

Хотите использовать сборщик или предпочитаете workflow без сборки — SeraJS подходит под оба стиля. Она достаточно гибкая, чтобы соответствовать вашему стилю разработки — используйте так, как *вам* нужно.


## 🌱 **Базовый пример Sera.js**

Минимальный пример с выводом сообщения Hello World с помощью Sera.js.

### 📄 App.jsx










```jsx
import { h } from "serajs";

export default function App() {
  return (
    <h1>Hello world</h1>
  );
}
```
## Без сборки, без зависимостей


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