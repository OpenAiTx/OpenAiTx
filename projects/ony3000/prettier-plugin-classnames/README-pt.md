<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
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

Um plugin do Prettier que quebra nomes de classes extensos com base na opção `printWidth`.

![Um caso de uso para este plugin.](https://raw.githubusercontent.com/ony3000/prettier-plugin-classnames/master/.github/banner.png)

## Instalação[^1]

```sh
npm install -D prettier prettier-plugin-classnames
```

[^1]: Se sua versão do `prettier-plugin-classnames` for inferior a `0.4.0`, você também precisará instalar o `@prettier/sync`.

## Configuração

Exemplo de JSON:

```json
{
  "plugins": ["prettier-plugin-classnames"]
}
```

Exemplo de JS (módulo CommonJS):

```javascript
module.exports = {
  plugins: ['prettier-plugin-classnames'],
  customAttributes: ['myClassProp'],
  customFunctions: ['clsx'],
};
```

Exemplo JS (módulo ES):

```javascript
export default {
  plugins: ['prettier-plugin-classnames'],
  endingPosition: 'absolute',
};
```

### Substituição de Markdown/MDX

Este plugin não suporta Markdown e MDX, mas se este plugin suportar um idioma dentro de blocos de código (por exemplo, Vue), pode ocorrer formatação indesejada dentro dos blocos de código.

Para evitar formatação indesejada, você pode usar substituições de configuração para Markdown e MDX.

Exemplo de JSON:

```json
{
  "plugins": ["prettier-plugin-classnames"],
  "customFunctions": ["clsx"],
  "overrides": [
    {
      "files": ["*.md", "*.mdx"],
      "options": {
        "plugins": []
      }
    }
  ]
}
```

## Opções

### Atributos Personalizados

Lista de atributos que envolvem nomes de classe.<br>
Os atributos `class` e `className` são sempre suportados, mesmo que nenhuma opção seja especificada.

<!-- prettier-ignore -->
Padrão | Substituição&nbsp;CLI | Substituição&nbsp;API
--- | --- | ---
`[]` | `--custom-attributes <string>` | `customAttributes: ["<string>"]`

### Funções Personalizadas

Lista de funções que envolvem nomes de classe.<br>
A função `classNames` é sempre suportada, mesmo que nenhuma opção seja especificada.

<!-- prettier-ignore -->
Padrão | Substituição&nbsp;CLI | Substituição&nbsp;API
--- | --- | ---
`[]` | `--custom-functions <string>` | `customFunctions: ["<string>"]`

### Posição Final

Disponível pela primeira vez na v0.5.0.<br>
`absolute-with-indent` foi adicionada na v0.6.0.<br>
`absolute-with-indent` foi removida na v0.8.0, mas você pode obter o mesmo resultado com `absolute`.<br>
O valor padrão mudou de `relative` para `absolute` na v0.8.0.

Este é o critério para terminar o nome da classe em cada linha ao substituir o nome de classe original por um nome de classe multilinha.

- Exemplo de `absolute`:

  ```
  ------------------------------------------------------------| printWidth=60
  export function Callout({ children }) {
    return (
      <div
        className="bg-gray-100/50 dark:bg-neutral-900/50
          border border-zinc-400/30 dark:border-neutral-500/30
          rounded-xl px-4 py-4"
      >
        {children}
      </div>
    );
  }
  ```

- Exemplo de `relative`:

  ```
  ------------------------------------------------------------| printWidth=60
  export function Callout({ children }) {
    return (
      <div
       |------------------------------------------------------------|
        className="bg-gray-100/50 dark:bg-neutral-900/50 border
         |------------------------------------------------------------|
          border-zinc-400/30 dark:border-neutral-500/30 rounded-xl
          px-4 py-4"
      >
        {children}
      </div>
    );
  }
  ```

<!-- prettier-ignore -->
Padrão | Substituição&nbsp;CLI | Substituição&nbsp;API
--- | --- | ---
`"absolute"` | `--ending-position <absolute\|relative>` | `endingPosition: "<absolute\|relative>"`

### Transformação de Sintaxe

Disponível pela primeira vez na v0.7.7.

Se ocorrer quebra de linha em um nome de classe escrito em sintaxe não-expressão, ele é transformado em sintaxe de expressão. Essa transformação não suporta formatação reversível.

<!-- prettier-ignore -->
Padrão | Substituição&nbsp;CLI | Substituição&nbsp;API
--- | --- | ---
`false` | `--syntax-transformation` | `syntaxTransformation: <boolean>`

### Largura de Impressão dos Classnames

Disponível pela primeira vez na v0.10.0.

Especifica a largura de impressão do nome da classe. Se nenhum valor for fornecido, o valor de `printWidth` é usado como padrão.

<!-- prettier-ignore -->
Padrão | Substituição&nbsp;CLI | Substituição&nbsp;API
--- | --- | ---
`undefined` | `--classnames-print-width <number>` | `classnamesPrintWidth: <number>`

## Correlação de versão com plugins irmãos

A partir da versão `0.6.0`, quando houver um lançamento secundário de um lado, planejo refletir essa alteração do outro lado também, se possível.

![Correlação de versão.](https://raw.githubusercontent.com/ony3000/prettier-plugin-classnames/master/.github/correlation.png)

## Compatibilidade com outros plugins do Prettier

Se mais de um plugin Prettier puder lidar com o texto que você deseja formatar, o Prettier usará apenas o último desses plugins.

Neste caso, você pode configurar da seguinte forma, adicionando o [prettier-plugin-merge](https://github.com/ony3000/prettier-plugin-merge) para aplicar esses plugins sequencialmente.

Exemplo de JSON:

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

## Stargazers over time

[![Stargazers over time](https://starchart.cc/ony3000/prettier-plugin-classnames.svg?variant=adaptive)](https://starchart.cc/ony3000/prettier-plugin-classnames)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-03

---