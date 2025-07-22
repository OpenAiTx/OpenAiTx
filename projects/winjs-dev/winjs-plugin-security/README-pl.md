<div align="right">
  <details>
    <summary >🌐 Język</summary>
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

Wtyczka zapewniająca ulepszone funkcje bezpieczeństwa dla projektów WinJS, głównie służąca do generowania atrybutu SRI (Subresource Integrity).

## Funkcje

- Automatyczne generowanie atrybutu SRI dla tagów `<script>` i `<link>` w plikach HTML
- Obsługa algorytmów haszujących SHA-256, SHA-384, SHA-512 (konfigurowalne)
- Automatyczne dodawanie atrybutu `crossorigin="anonymous"` w celu zapewnienia prawidłowego działania SRI
- Działa tylko w środowisku produkcyjnym, środowisko deweloperskie jest automatycznie pomijane

## Instalacja


```bash
pnpm add @winner-fed/plugin-security
```
## Sposób użycia

Dodaj konfigurację wtyczki do swojego pliku konfiguracyjnego `.winrc.ts`:


```typescript
import { defineConfig } from '@winner-fed/winjs';

export default defineConfig({
  plugins: ['@winner-fed/plugin-security'],
  security: {
    sri: true // 启用 SRI 功能
  },
});
```
## Opcje konfiguracyjne

### `sri`

- **Typ**: `boolean | { algorithm: 'sha256' | 'sha384' | 'sha512' }`
- **Wartość domyślna**: wymaga ręcznego ustawienia
- **Opis**: Czy włączyć funkcję SRI (integralność podzasobów) oraz opcjonalnie skonfigurować algorytm haszujący

Gdy ustawione na `true` lub `{}`, wtyczka wykona:

1. Skanowanie zbudowanych plików HTML
2. Dodanie atrybutu `integrity` do wszystkich tagów `<script>` posiadających atrybut `src`
3. Dodanie atrybutu `integrity` do wszystkich tagów `<link>` posiadających atrybut `href`
4. Automatyczne dodanie atrybutu `crossorigin="anonymous"` (jeśli nie istnieje)

Możesz także określić algorytm haszujący poprzez przekazanie obiektu:


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
### Wyjście HTML (po włączeniu SRI)


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
## Informacje dotyczące bezpieczeństwa

SRI (Subresource Integrity – integralność podzasobów) to funkcja bezpieczeństwa, która pozwala przeglądarce zweryfikować, czy pobierany zasób (np. zasób pobierany z CDN) nie został złośliwie zmodyfikowany. Gdy przeglądarka ładuje zasób, oblicza jego wartość skrótu (hash) i porównuje ją z wartością określoną w atrybucie `integrity`. Jeśli wartości skrótu nie są zgodne, przeglądarka odmówi załadowania tego zasobu.

W przypadku tagu `<script>` skutkuje to odmową wykonania kodu; w przypadku linków do CSS skutkuje to niezaładowaniem stylów.

Więcej informacji na temat SRI można znaleźć na stronie [Subresource Integrity - MDN](https://developer.mozilla.org/zh-CN/docs/Web/Security/Subresource_Integrity).

## Uwagi

1. Ta wtyczka działa tylko podczas budowania wersji produkcyjnej; środowisko deweloperskie jest automatycznie pomijane
2. Należy upewnić się, że pliki zasobów są dostępne w katalogu wyjściowym po zbudowaniu
3. Atrybut `integrity` musi być używany razem z atrybutem `crossorigin`, aby działał poprawnie

## Licencja

MIT




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-22

---