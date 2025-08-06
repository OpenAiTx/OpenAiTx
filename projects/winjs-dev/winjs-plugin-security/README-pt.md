
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

Um plugin que fornece funcionalidades de segurança aprimoradas para projetos WinJS, principalmente para geração de atributos SRI (Subresource Integrity).

<p>
  <a href="https://npmjs.com/package/@winner-fed/plugin-security">
   <img src="https://img.shields.io/npm/v/@winner-fed/plugin-security?style=flat-square&colorA=564341&colorB=EDED91" alt="npm version" />
  </a>
  <img src="https://img.shields.io/badge/License-MIT-blue.svg?style=flat-square&colorA=564341&colorB=EDED91" alt="license" />
  <a href="https://npmcharts.com/compare/@winner-fed/plugin-security?minimal=true"><img src="https://img.shields.io/npm/dm/@winner-fed/plugin-security.svg?style=flat-square&colorA=564341&colorB=EDED91" alt="downloads" /></a>
</p>

## Funcionalidades

- Geração automática do atributo SRI para as tags `<script>` e `<link>` em arquivos HTML
- Suporta algoritmos de hash SHA-256, SHA-384, SHA-512 (configurável)
- Adiciona automaticamente o atributo `crossorigin="anonymous"` para garantir o funcionamento correto do SRI
- Ativo somente em ambiente de produção, sendo automaticamente ignorado em ambiente de desenvolvimento

## Instalação

```bash
pnpm add @winner-fed/plugin-security
```
## Como usar

Adicione a configuração do plugin no seu arquivo de configuração `.winrc.ts`:


```typescript
import { defineConfig } from '@winner-fed/winjs';

export default defineConfig({
  plugins: ['@winner-fed/plugin-security'],
  security: {
    sri: true // 启用 SRI 功能
  },
});
```
## Opções de Configuração

### `sri`

- **Tipo**: `boolean | { algorithm: 'sha256' | 'sha384' | 'sha512' }`
- **Valor padrão**: Precisa ser configurado manualmente
- **Descrição**: Indica se o recurso SRI (Subresource Integrity) está habilitado e permite configurar opcionalmente o algoritmo de hash

Quando definido como `true` ou `{}`, o plugin irá:

1. Escanear os arquivos HTML gerados após a build
2. Adicionar o atributo `integrity` a todas as tags `<script>` que possuam o atributo `src`
3. Adicionar o atributo `integrity` a todas as tags `<link>` que possuam o atributo `href`
4. Adicionar automaticamente o atributo `crossorigin="anonymous"` (caso não exista)

Você também pode especificar o algoritmo de hash utilizando um objeto:


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
### Saída HTML (após ativar SRI)


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
## Instruções de Segurança

SRI (Integridade de Sub-recurso) é um recurso de segurança que permite ao navegador verificar se os recursos obtidos (por exemplo, recursos carregados de um CDN) não foram modificados maliciosamente. Quando o navegador carrega um recurso, ele calcula o hash desse recurso e o compara com o hash especificado no atributo `integrity`. Se os hashes não coincidirem, o navegador recusará o carregamento desse recurso.

Para tags `<script>`, isso resulta na recusa de execução do código; para links de CSS, o resultado é a não aplicação dos estilos contidos.

Para saber mais sobre SRI, consulte [Subresource Integrity - MDN](https://developer.mozilla.org/zh-CN/docs/Web/Security/Subresource_Integrity).

## Observações

1. Este plugin só é efetivo em builds de produção, o ambiente de desenvolvimento é automaticamente ignorado
2. É necessário garantir que os arquivos de recursos estejam acessíveis no diretório de saída da build
3. O atributo `integrity` deve ser usado junto com o atributo `crossorigin` para funcionar corretamente

## Licença

MIT




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-06

---