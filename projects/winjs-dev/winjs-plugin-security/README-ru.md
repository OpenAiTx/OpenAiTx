
<div align="right">
  <details>
    <summary >🌐 Язык</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# winjs-plugin-security

Плагин, обеспечивающий расширенные функции безопасности для проектов WinJS, предназначенный в первую очередь для генерации атрибутов SRI (Subresource Integrity).

<p>
  <a href="https://npmjs.com/package/@winner-fed/plugin-security">
   <img src="https://img.shields.io/npm/v/@winner-fed/plugin-security?style=flat-square&colorA=564341&colorB=EDED91" alt="npm version" />
  </a>
  <img src="https://img.shields.io/badge/License-MIT-blue.svg?style=flat-square&colorA=564341&colorB=EDED91" alt="license" />
  <a href="https://npmcharts.com/compare/@winner-fed/plugin-security?minimal=true"><img src="https://img.shields.io/npm/dm/@winner-fed/plugin-security.svg?style=flat-square&colorA=564341&colorB=EDED91" alt="downloads" /></a>
</p>

## Особенности

- Автоматическая генерация атрибута SRI для тегов `<script>` и `<link>` в HTML-файлах
- Поддержка хеш-алгоритмов SHA-256, SHA-384, SHA-512 (настраивается)
- Автоматическое добавление атрибута `crossorigin="anonymous"` для корректной работы SRI
- Работает только в продакшн-режиме, в режиме разработки автоматически пропускается

## Установка

```bash
pnpm add @winner-fed/plugin-security
```
## Способ использования

Добавьте конфигурацию плагина в ваш файл настроек `.winrc.ts`:


```typescript
import { defineConfig } from '@winner-fed/winjs';

export default defineConfig({
  plugins: ['@winner-fed/plugin-security'],
  security: {
    sri: true // 启用 SRI 功能
  },
});
```
## Опции конфигурации

### `sri`

- **Тип**: `boolean | { algorithm: 'sha256' | 'sha384' | 'sha512' }`
- **Значение по умолчанию**: требуется ручная настройка
- **Описание**: включает или отключает функцию SRI (целостность подресурсов), а также позволяет выбрать алгоритм хеширования

Если указано значение `true` или `{}`, плагин выполнит следующие действия:

1. Сканирует сгенерированные HTML-файлы
2. Добавляет атрибут `integrity` ко всем тегам `<script>` с атрибутом `src`
3. Добавляет атрибут `integrity` ко всем тегам `<link>` с атрибутом `href`
4. Автоматически добавляет атрибут `crossorigin="anonymous"` (если он отсутствует)

Также можно явно указать алгоритм хеширования через объект:


```typescript
security: {
  sri: {
    algorithm: 'sha512' // 可选 'sha256' | 'sha384' | 'sha512'，默认 'sha512'
  }
}
```

## 示例

### 输入 HTML

```html
<!DOCTYPE html>
<html>
<head>
  <link rel="stylesheet" href="/assets/app.css">
</head>
<body>
  <script src="/assets/app.js"></script>
</body>
</html>
```
### Вывод HTML (после включения SRI)


```html
<!DOCTYPE html>
<html>
<head>
  <link rel="stylesheet" href="/assets/app.css" integrity="sha512-ABC123..." crossorigin="anonymous">
</head>
<body>
  <script src="/assets/app.js" integrity="sha512-XYZ789..." crossorigin="anonymous"></script>
</body>
</html>
```
## Инструкции по безопасности

SRI (целостность подресурсов) — это функция безопасности, которая позволяет браузеру проверять, не были ли загруженные ресурсы (например, ресурсы, полученные с CDN) злонамеренно изменены. Когда браузер загружает ресурс, он вычисляет хэш ресурса и сравнивает его с хэшем, указанным в атрибуте `integrity`. Если хэши не совпадают, браузер откажется загружать данный ресурс.

Для тега `<script>` это приводит к отказу в выполнении кода внутри; для CSS-ссылок — к отказу в загрузке соответствующих стилей.

Подробнее о SRI см. на странице [Subresource Integrity - MDN](https://developer.mozilla.org/zh-CN/docs/Web/Security/Subresource_Integrity).

## Важные замечания

1. Этот плагин работает только при продакшн-сборке, в режиме разработки он будет автоматически пропущен
2. Необходимо убедиться, что файлы ресурсов доступны в выходном каталоге сборки
3. Атрибут `integrity` должен использоваться совместно с атрибутом `crossorigin`, чтобы работать корректно

## Лицензия

MIT




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-06

---