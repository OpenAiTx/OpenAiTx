
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
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

Un complemento que proporciona funciones de mejora de seguridad para proyectos WinJS, utilizado principalmente para generar atributos SRI (Subresource Integrity).

<p>
  <a href="https://npmjs.com/package/@winner-fed/plugin-security">
   <img src="https://img.shields.io/npm/v/@winner-fed/plugin-security?style=flat-square&colorA=564341&colorB=EDED91" alt="npm version" />
  </a>
  <img src="https://img.shields.io/badge/License-MIT-blue.svg?style=flat-square&colorA=564341&colorB=EDED91" alt="license" />
  <a href="https://npmcharts.com/compare/@winner-fed/plugin-security?minimal=true"><img src="https://img.shields.io/npm/dm/@winner-fed/plugin-security.svg?style=flat-square&colorA=564341&colorB=EDED91" alt="downloads" /></a>
</p>

## Características

- Genera automáticamente atributos SRI para las etiquetas `<script>` y `<link>` en archivos HTML
- Soporta los algoritmos hash SHA-256, SHA-384 y SHA-512 (configurable)
- Añade automáticamente el atributo `crossorigin="anonymous"` para garantizar el funcionamiento adecuado de SRI
- Solo funciona en entorno de producción, en desarrollo se omite automáticamente

## Instalación

```bash
pnpm add @winner-fed/plugin-security
```
## Método de uso

Agrega la configuración del complemento en tu archivo de configuración `.winrc.ts`:


```typescript
import { defineConfig } from '@winner-fed/winjs';

export default defineConfig({
  plugins: ['@winner-fed/plugin-security'],
  security: {
    sri: true // 启用 SRI 功能
  },
});
```
## Opciones de configuración

### `sri`

- **Tipo**: `boolean | { algorithm: 'sha256' | 'sha384' | 'sha512' }`
- **Valor por defecto**: Requiere configuración manual
- **Descripción**: Indica si se habilita la función SRI (Integridad de Subrecursos) y permite configurar opcionalmente el algoritmo hash

Cuando se establece en `true` o `{}`, el complemento realizará:

1. Escanear los archivos HTML generados después de la compilación
2. Añadir el atributo `integrity` a todas las etiquetas `<script>` que tengan atributo `src`
3. Añadir el atributo `integrity` a todas las etiquetas `<link>` que tengan atributo `href`
4. Añadir automáticamente el atributo `crossorigin="anonymous"` (si no existe)

También puedes especificar el algoritmo hash utilizando un objeto:


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
### Salida HTML (después de habilitar SRI)


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
## Instrucciones de seguridad

SRI (Integridad de Subrecursos) es una característica de seguridad que permite al navegador verificar que los recursos obtenidos (por ejemplo, desde un CDN) no han sido modificados maliciosamente. Cuando el navegador carga un recurso, calcula el valor hash del recurso y lo compara con el valor hash especificado en el atributo `integrity`. Si los valores hash no coinciden, el navegador rechazará la carga de ese recurso.

Para la etiqueta `<script>`, el resultado es que se rechaza la ejecución del código; para los enlaces de CSS, el resultado es que no se cargan los estilos.

Para obtener más información sobre SRI, puede consultar [Subresource Integrity - MDN](https://developer.mozilla.org/zh-CN/docs/Web/Security/Subresource_Integrity)。

## Advertencias

1. Este plugin solo tiene efecto en la compilación de producción, el entorno de desarrollo se omite automáticamente
2. Debe asegurarse de que los archivos de recursos sean accesibles en el directorio de salida de la compilación
3. El atributo `integrity` debe usarse junto con el atributo `crossorigin` para funcionar correctamente

## Licencia

MIT




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-06

---