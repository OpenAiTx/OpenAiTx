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

Un complemento para Prettier que ajusta nombres de clases verbosos según la opción `printWidth`.

![Un caso de uso para este complemento.](https://raw.githubusercontent.com/ony3000/prettier-plugin-classnames/master/.github/banner.png)

## Instalación[^1]

```sh
npm install -D prettier prettier-plugin-classnames
```

[^1]: Si su versión de `prettier-plugin-classnames` es inferior a `0.4.0`, también necesitará instalar `@prettier/sync`.

## Configuración

Ejemplo en JSON:

```json
{
  "plugins": ["prettier-plugin-classnames"]
}
```

Ejemplo de JS (módulo CommonJS):

```javascript
module.exports = {
  plugins: ['prettier-plugin-classnames'],
  customAttributes: ['myClassProp'],
  customFunctions: ['clsx'],
};
```

Ejemplo JS (módulo ES):

```javascript
export default {
  plugins: ['prettier-plugin-classnames'],
  endingPosition: 'absolute',
};
```

## Opciones

### Atributos Personalizados

Lista de atributos que encierran nombres de clase.<br>
Los atributos `class` y `className` siempre son compatibles, incluso si no se especifican opciones.

<!-- prettier-ignore -->
Predeterminado | Anulación CLI&nbsp; | Anulación API&nbsp;
--- | --- | ---
`[]` | `--custom-attributes <string>` | `customAttributes: ["<string>"]`

### Funciones Personalizadas

Lista de funciones que encierran nombres de clase.<br>
La función `classNames` siempre es compatible, incluso si no se especifican opciones.

<!-- prettier-ignore -->
Predeterminado | Anulación CLI&nbsp; | Anulación API&nbsp;
--- | --- | ---
`[]` | `--custom-functions <string>` | `customFunctions: ["<string>"]`

### Posición de Finalización

Disponible por primera vez en v0.5.0.<br>
`absolute-with-indent` se agregó en v0.6.0.<br>
`absolute-with-indent` se eliminó en v0.8.0, pero puede obtener la misma salida con `absolute`.<br>
El valor predeterminado cambió de `relative` a `absolute` en v0.8.0.

Este es el criterio para terminar el nombre de clase en cada línea al reemplazar el nombre de clase original con un nombre de clase de varias líneas.

- Ejemplo de `absolute`:

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

- Ejemplo de `relative`:

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
Por defecto | Anulación CLI&nbsp; | Anulación API&nbsp;
--- | --- | ---
`"absolute"` | `--ending-position <absolute\|relative>` | `endingPosition: "<absolute\|relative>"`

### Transformación de sintaxis

Disponible por primera vez en v0.7.7.

Si ocurre un salto de línea en un nombre de clase escrito en sintaxis no expresión, se transforma en sintaxis de expresión. Esta transformación no soporta un formato reversible.

<!-- prettier-ignore -->
Por defecto | Anulación CLI&nbsp; | Anulación API&nbsp;
--- | --- | ---
`false` | `--syntax-transformation` | `syntaxTransformation: <boolean>`

## Correlación de versiones con plugins hermanos

A partir de `0.6.0`, cuando hay una versión menor en un lado, planeo reflejar ese cambio en el otro lado también si es posible.

![Correlación de versiones.](https://raw.githubusercontent.com/ony3000/prettier-plugin-classnames/master/.github/correlation.png)

## Compatibilidad con otros plugins de Prettier

Si más de un plugin de Prettier puede manejar el texto que quieres formatear, Prettier usará solo el último de esos plugins.

En este caso, puedes configurarlo como sigue añadiendo [prettier-plugin-merge](https://github.com/ony3000/prettier-plugin-merge) para aplicar esos plugins secuencialmente.

Ejemplo JSON:

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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-28

---