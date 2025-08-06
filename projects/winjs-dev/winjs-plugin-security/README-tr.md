
<div align="right">
  <details>
    <summary >🌐 Dil</summary>
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

WinJS projeleri için güvenlik artırma işlevleri sağlayan, özellikle SRI (Subresource Integrity) özniteliği üretmek için kullanılan bir eklenti.

<p>
  <a href="https://npmjs.com/package/@winner-fed/plugin-security">
   <img src="https://img.shields.io/npm/v/@winner-fed/plugin-security?style=flat-square&colorA=564341&colorB=EDED91" alt="npm version" />
  </a>
  <img src="https://img.shields.io/badge/License-MIT-blue.svg?style=flat-square&colorA=564341&colorB=EDED91" alt="license" />
  <a href="https://npmcharts.com/compare/@winner-fed/plugin-security?minimal=true"><img src="https://img.shields.io/npm/dm/@winner-fed/plugin-security.svg?style=flat-square&colorA=564341&colorB=EDED91" alt="downloads" /></a>
</p>

## Özellikler

- HTML dosyalarındaki `<script>` ve `<link>` etiketlerine otomatik olarak SRI özniteliği ekler
- SHA-256, SHA-384, SHA-512 karma algoritmalarını destekler (yapılandırılabilir)
- SRI'nin düzgün çalışmasını sağlamak için otomatik olarak `crossorigin="anonymous"` özniteliği ekler
- Sadece üretim ortamında etkilidir, geliştirme ortamında otomatik olarak atlanır

## Kurulum

```bash
pnpm add @winner-fed/plugin-security
```
## Kullanım Yöntemi

`.winrc.ts` yapılandırma dosyanıza eklenti yapılandırmasını ekleyin:


```typescript
import { defineConfig } from '@winner-fed/winjs';

export default defineConfig({
  plugins: ['@winner-fed/plugin-security'],
  security: {
    sri: true // 启用 SRI 功能
  },
});
```
## Yapılandırma Seçenekleri

### `sri`

- **Tür**: `boolean | { algorithm: 'sha256' | 'sha384' | 'sha512' }`
- **Varsayılan Değer**: Elle ayarlanması gerekir
- **Açıklama**: SRI (Alt Kaynak Bütünlüğü) özelliğinin etkinleştirilip etkinleştirilmeyeceği ve isteğe bağlı olarak kullanılacak karma algoritması yapılandırması

`true` veya `{}` olarak ayarlandığında, eklenti:

1. Oluşturulan HTML dosyalarını tarar
2. `src` niteliğine sahip tüm `<script>` etiketlerine `integrity` niteliği ekler
3. `href` niteliğine sahip tüm `<link>` etiketlerine `integrity` niteliği ekler
4. Otomatik olarak `crossorigin="anonymous"` niteliği ekler (eğer yoksa)

Karma algoritmasını nesne biçiminde de belirtebilirsiniz:


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
### HTML çıktısı (SRI etkinleştirildikten sonra)


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
## Güvenlik Açıklaması

SRI (Alt Kaynak Bütünlüğü), tarayıcıların alınan bir kaynağın (örneğin CDN'den alınan bir kaynağın) kötü niyetli olarak değiştirilmediğini doğrulamasını sağlayan bir güvenlik özelliğidir. Tarayıcı, kaynağı yüklerken, kaynağın bir hash değerini hesaplar ve bu değeri `integrity` özniteliğinde belirtilen hash değeriyle karşılaştırır. Eğer hash değerleri eşleşmezse, tarayıcı o kaynağı yüklemeyi reddeder.

`<script>` etiketi için, sonuç olarak içindeki kodun çalıştırılması reddedilir; CSS bağlantıları için ise, sonuç olarak içindeki stiller yüklenmez.

SRI hakkında daha fazla bilgi için [Alt Kaynak Bütünlüğü - MDN](https://developer.mozilla.org/zh-CN/docs/Web/Security/Subresource_Integrity) adresine bakabilirsiniz.

## Dikkat Edilmesi Gerekenler

1. Bu eklenti yalnızca üretim yapısında etkilidir, geliştirme ortamında otomatik olarak atlanır
2. Kaynak dosyaların yapı çıktı dizininde erişilebilir olduğundan emin olunmalıdır
3. `integrity` özniteliğinin düzgün çalışması için `crossorigin` özniteliği ile birlikte kullanılması gerekmektedir

## Lisans

MIT




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-06

---