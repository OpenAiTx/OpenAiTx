
<div align="right">
  <details>
    <summary >🌐 Язык</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# prettier-plugin-classnames

Плагин Prettier, который переносит длинные имена классов в соответствии с опцией `printWidth`.

![Пример использования этого плагина.](https://raw.githubusercontent.com/ony3000/prettier-plugin-classnames/master/.github/banner.png)

## Установка[^1]

```sh
npm install -D prettier prettier-plugin-classnames
```

[^1]: Если версия вашего `prettier-plugin-classnames` меньше `0.4.0`, вам также потребуется установить `@prettier/sync`.

## Конфигурация

Пример JSON:

```json
{
  "plugins": ["prettier-plugin-classnames"]
}
```

Пример JS (модуль CommonJS):

```javascript
module.exports = {
  plugins: ['prettier-plugin-classnames'],
  customAttributes: ['myClassProp'],
  customFunctions: ['clsx'],
};
```

Пример JS (ES-модуль):

```javascript
export default {
  plugins: ['prettier-plugin-classnames'],
  endingPosition: 'absolute',
};
```

## Опции

### Пользовательские атрибуты

Список атрибутов, которые охватывают имена классов.<br>
Атрибуты `class` и `className` всегда поддерживаются, даже если опции не указаны.

<!-- prettier-ignore -->
По умолчанию | CLI&nbsp;Переопределение | API&nbsp;Переопределение
--- | --- | ---
`[]` | `--custom-attributes <string>` | `customAttributes: ["<string>"]`

### Пользовательские функции

Список функций, которые охватывают имена классов.<br>
Функция `classNames` всегда поддерживается, даже если опции не указаны.

<!-- prettier-ignore -->
По умолчанию | CLI&nbsp;Переопределение | API&nbsp;Переопределение
--- | --- | ---
`[]` | `--custom-functions <string>` | `customFunctions: ["<string>"]`

### Позиция окончания

Впервые доступно в v0.5.0.<br>
`absolute-with-indent` был добавлен в v0.6.0.<br>
`absolute-with-indent` был удалён в v0.8.0, но тот же результат можно получить с помощью `absolute`.<br>
Значение по умолчанию изменено с `relative` на `absolute` в v0.8.0.

Это критерий для окончания имени класса на каждой строке при замене оригинального имени класса на многострочное имя класса.

- пример для `absolute`:

  ```
  --------------------------------------------------| printWidth=50
  export function Callout({ children }) {
    return (
      <div
        className="bg-gray-100/50 border
          border-zinc-400/30 dark:bg-neutral-900/50
          dark:border-neutral-500/30 px-4 py-4
          rounded-xl"
      >
        {children}
      </div>
    );
  }
  ```

- пример `relative`:

  ```
  --------------------------------------------------| printWidth=50
  export function Callout({ children }) {
    return (
      <div
                  |--------------------------------------------------|
        className="bg-gray-100/50 border border-zinc-400/30
         |--------------------------------------------------|
          dark:bg-neutral-900/50 dark:border-neutral-500/30
          px-4 py-4 rounded-xl"
      >
        {children}
      </div>
    );
  }
  ```

<!-- prettier-ignore -->
По умолчанию | Переопределение в CLI&nbsp; | Переопределение в API&nbsp;
--- | --- | ---
`"absolute"` | `--ending-position <absolute\|relative>` | `endingPosition: "<absolute\|relative>"`

### Трансформация синтаксиса

Впервые доступно в v0.7.7.

Если перенос строки происходит в имени класса, написанном не в синтаксисе выражения, оно преобразуется в синтаксис выражения. Эта трансформация не поддерживает обратимое форматирование.

<!-- prettier-ignore -->
По умолчанию | Переопределение в CLI&nbsp; | Переопределение в API&nbsp;
--- | --- | ---
`false` | `--syntax-transformation` | `syntaxTransformation: <boolean>`

## Корреляция версий с сопутствующими плагинами

Начиная с версии `0.6.0`, при выпуске минорного обновления на одной стороне я планирую, по возможности, отражать это изменение и на другой стороне.

![Корреляция версий.](https://raw.githubusercontent.com/ony3000/prettier-plugin-classnames/master/.github/correlation.png)

## Совместимость с другими плагинами Prettier

Если более одного плагина Prettier может обработать текст, который вы хотите отформатировать, Prettier использует только последний из этих плагинов.

В этом случае вы можете настроить последовательное применение этих плагинов, добавив [prettier-plugin-merge](https://github.com/ony3000/prettier-plugin-merge).

Пример JSON:

<!-- prettier-ignore -->
```json
{
  "plugins": [
    "prettier-plugin-tailwindcss",
    "prettier-plugin-classnames",
    "prettier-plugin-merge"
  ]
}
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-09

---