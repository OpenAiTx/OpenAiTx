
<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
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

Ein Plugin zur Sicherheitsverbesserung für WinJS-Projekte, das hauptsächlich zur Generierung von SRI- (Subresource Integrity) Attributen dient.

<p>
  <a href="https://npmjs.com/package/@winner-fed/plugin-security">
   <img src="https://img.shields.io/npm/v/@winner-fed/plugin-security?style=flat-square&colorA=564341&colorB=EDED91" alt="npm version" />
  </a>
  <img src="https://img.shields.io/badge/License-MIT-blue.svg?style=flat-square&colorA=564341&colorB=EDED91" alt="license" />
  <a href="https://npmcharts.com/compare/@winner-fed/plugin-security?minimal=true"><img src="https://img.shields.io/npm/dm/@winner-fed/plugin-security.svg?style=flat-square&colorA=564341&colorB=EDED91" alt="downloads" /></a>
</p>

## Funktionsmerkmale

- Automatische Generierung von SRI-Attributen für `<script>`- und `<link>`-Tags in HTML-Dateien
- Unterstützung der Hash-Algorithmen SHA-256, SHA-384 und SHA-512 (konfigurierbar)
- Automatisches Hinzufügen des Attributes `crossorigin="anonymous"` zur Sicherstellung der ordnungsgemäßen Funktion von SRI
- Wirkt nur in Produktionsumgebungen, in Entwicklungsumgebungen wird automatisch übersprungen

## Installation

```bash
pnpm add @winner-fed/plugin-security
```
## Verwendung

Fügen Sie die Plugin-Konfiguration in Ihre `.winrc.ts` Konfigurationsdatei ein:


```typescript
import { defineConfig } from '@winner-fed/winjs';

export default defineConfig({
  plugins: ['@winner-fed/plugin-security'],
  security: {
    sri: true // 启用 SRI 功能
  },
});
```
## Konfigurationsoptionen

### `sri`

- **Typ**: `boolean | { algorithm: 'sha256' | 'sha384' | 'sha512' }`
- **Standardwert**: Muss manuell gesetzt werden
- **Beschreibung**: Aktiviert die SRI-Funktion (Subresource Integrity) und ermöglicht eine optionale Konfiguration des Hash-Algorithmus

Wenn auf `true` oder `{}` gesetzt, führt das Plugin folgende Schritte aus:

1. Scannt die nach dem Build erstellten HTML-Dateien
2. Fügt allen `<script>`-Tags mit `src`-Attribut das `integrity`-Attribut hinzu
3. Fügt allen `<link>`-Tags mit `href`-Attribut das `integrity`-Attribut hinzu
4. Fügt automatisch das Attribut `crossorigin="anonymous"` hinzu (falls nicht vorhanden)

Du kannst den Hash-Algorithmus auch über ein Objekt angeben:


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
### Ausgabe von HTML (nach Aktivierung von SRI)


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
## Sicherheitshinweise

SRI (Subresource Integrity) ist eine Sicherheitsfunktion, die es dem Browser ermöglicht zu überprüfen, ob abgerufene Ressourcen (z. B. von einem CDN) nicht böswillig verändert wurden. Beim Laden der Ressource berechnet der Browser den Hashwert der Ressource und vergleicht ihn mit dem im `integrity`-Attribut angegebenen Hashwert. Wenn die Hashwerte nicht übereinstimmen, verweigert der Browser das Laden dieser Ressource.

Für `<script>`-Tags bedeutet dies, dass der darin enthaltene Code nicht ausgeführt wird; für CSS-Links werden die darin enthaltenen Styles nicht geladen.

Weitere Informationen zu SRI finden Sie unter [Subresource Integrity - MDN](https://developer.mozilla.org/zh-CN/docs/Web/Security/Subresource_Integrity).

## Hinweise

1. Dieses Plugin ist nur beim Produktions-Build wirksam, die Entwicklungsumgebung wird automatisch übersprungen
2. Es muss sichergestellt werden, dass die Ressourcendateien im Build-Ausgabeverzeichnis zugänglich sind
3. Das `integrity`-Attribut muss zusammen mit dem `crossorigin`-Attribut verwendet werden, um ordnungsgemäß zu funktionieren

## Lizenz

MIT




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-06

---