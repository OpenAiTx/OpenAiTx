<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=en">Engels</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=fr">Frans</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=de">Duits</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=es">Spaans</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=it">Italiaans</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=pt">Portugees</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=pl">Pools</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=tr">Turks</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=vi">Vietnamees</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# winjs-plugin-security

Een plugin die beveiligingsverbeteringen biedt voor WinJS-projecten, voornamelijk gebruikt voor het genereren van SRI (Subresource Integrity) attributen.

## Functies

- Genereert automatisch SRI-attributen voor `<script>` en `<link>` tags in HTML-bestanden
- Ondersteunt SHA-256, SHA-384, SHA-512 hash-algoritmen (configureerbaar)
- Voegt automatisch het attribuut `crossorigin="anonymous"` toe om correcte werking van SRI te garanderen
- Alleen actief in productieomgevingen, wordt automatisch overgeslagen in ontwikkelomgevingen

## Installatie


```bash
pnpm add @winner-fed/plugin-security
```
## Gebruiksmethode

Voeg de pluginconfiguratie toe aan je `.winrc.ts` configuratiebestand:


```typescript
import { defineConfig } from '@winner-fed/winjs';

export default defineConfig({
  plugins: ['@winner-fed/plugin-security'],
  security: {
    sri: true // 启用 SRI 功能
  },
});
```
## Configuratie-opties

### `sri`

- **Type**: `boolean | { algorithm: 'sha256' | 'sha384' | 'sha512' }`
- **Standaardwaarde**: Moet handmatig worden ingesteld
- **Beschrijving**: Of de SRI-functie (Subresource Integrity) wordt ingeschakeld en optionele hash-algoritmeconfiguratie

Wanneer ingesteld op `true` of `{}` zal de plugin:

1. De na het bouwen gegenereerde HTML-bestanden scannen
2. Aan alle `<script>`-tags met een `src`-attribuut een `integrity`-attribuut toevoegen
3. Aan alle `<link>`-tags met een `href`-attribuut een `integrity`-attribuut toevoegen
4. Automatisch het attribuut `crossorigin="anonymous"` toevoegen (indien niet aanwezig)

Je kunt ook het hash-algoritme specificeren via een object:


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
### HTML-uitvoer (na inschakelen van SRI)


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
## Veiligheidsinstructies

SRI (Subresource Integrity) is een beveiligingsfunctie waarmee browsers kunnen verifiëren dat opgehaalde bronnen (zoals bronnen van een CDN) niet kwaadaardig zijn gewijzigd. Wanneer de browser een bron laadt, wordt de hashwaarde van de bron berekend en vergeleken met de hashwaarde die is opgegeven in het `integrity`-attribuut. Als de hashwaarden niet overeenkomen, weigert de browser de bron te laden.

Voor `<script>`-tags betekent dit dat de code binnenin niet zal worden uitgevoerd; voor CSS-links betekent dit dat de stijlen niet worden geladen.

Voor meer informatie over SRI, zie [Subresource Integrity - MDN](https://developer.mozilla.org/zh-CN/docs/Web/Security/Subresource_Integrity).

## Opmerkingen

1. Deze plugin is alleen van kracht bij productie-builds, in de ontwikkelomgeving wordt deze automatisch overgeslagen
2. Zorg ervoor dat de bronbestanden toegankelijk zijn in de outputmap van de build
3. Het `integrity`-attribuut moet samen met het `crossorigin`-attribuut worden gebruikt om goed te kunnen werken

## Licentie

MIT




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-22

---