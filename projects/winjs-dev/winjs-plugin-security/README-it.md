<div align="right">
  <details>
    <summary >🌐 Lingua</summary>
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

Un plugin che offre funzionalità di sicurezza avanzate per progetti WinJS, principalmente utilizzato per generare attributi SRI (Subresource Integrity).

## Caratteristiche

- Generazione automatica degli attributi SRI per i tag `<script>` e `<link>` nei file HTML
- Supporto per algoritmi di hash SHA-256, SHA-384, SHA-512 (configurabili)
- Aggiunta automatica dell'attributo `crossorigin="anonymous"` per garantire il corretto funzionamento di SRI
- Attivo solo in ambiente di produzione, in sviluppo viene automaticamente ignorato

## Installazione


```bash
pnpm add @winner-fed/plugin-security
```
## Metodo di utilizzo

Aggiungi la configurazione del plugin nel tuo file di configurazione `.winrc.ts`:


```typescript
import { defineConfig } from '@winner-fed/winjs';

export default defineConfig({
  plugins: ['@winner-fed/plugin-security'],
  security: {
    sri: true // 启用 SRI 功能
  },
});
```
## Opzioni di configurazione

### `sri`

- **Tipo**: `boolean | { algorithm: 'sha256' | 'sha384' | 'sha512' }`
- **Valore predefinito**: deve essere impostato manualmente
- **Descrizione**: indica se abilitare la funzionalità SRI (Subresource Integrity) e permette di configurare opzionalmente l’algoritmo di hash

Quando impostato su `true` o `{}`, il plugin esegue le seguenti operazioni:

1. Scansiona i file HTML generati dopo la build
2. Aggiunge l’attributo `integrity` a tutti i tag `<script>` con attributo `src`
3. Aggiunge l’attributo `integrity` a tutti i tag `<link>` con attributo `href`
4. Aggiunge automaticamente l’attributo `crossorigin="anonymous"` (se non già presente)

Puoi anche specificare l’algoritmo di hash tramite oggetto:


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
### Output HTML (dopo aver abilitato SRI)


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
## Avvertenze di sicurezza

SRI (Subresource Integrity) è una funzionalità di sicurezza che consente al browser di verificare che le risorse ottenute (ad esempio, quelle prelevate da un CDN) non siano state modificate in modo dannoso. Quando il browser carica una risorsa, calcola il valore hash della risorsa e lo confronta con quello specificato nell'attributo `integrity`. Se gli hash non corrispondono, il browser rifiuta di caricare la risorsa.

Per i tag `<script>`, il risultato è il rifiuto di eseguire il codice al suo interno; per i link CSS, il risultato è che gli stili non verranno caricati.

Per ulteriori informazioni su SRI, è possibile consultare [Subresource Integrity - MDN](https://developer.mozilla.org/zh-CN/docs/Web/Security/Subresource_Integrity).

## Avvertenze

1. Questo plugin è efficace solo durante la build di produzione, l'ambiente di sviluppo verrà automaticamente ignorato
2. È necessario assicurarsi che i file delle risorse siano accessibili nella directory di output della build
3. L'attributo `integrity` deve essere utilizzato insieme all'attributo `crossorigin` per funzionare correttamente

## Licenza

MIT




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-22

---