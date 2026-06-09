# Tailwindからインラインスタイルへの変換ツール

Tailwind CSSクラスをメール対応のHTMLテンプレート用のインラインスタイルに変換します。

### [オンラインで試す](https://tailwind-to-inline.vercel.app)

### インストール
`npm install tailwind-to-inline`


### 使い方

#### ファイルパスから変換する場合

```js
import { makeStylesInline } from 'tailwind-to-inline';

const htmlTemplate = await makeStylesInline('templates/welcome-email.html', {
  name: 'John',
  cta_text: 'Complete Profile'
});
```

**パラメータ:**

- `templatePath` — テンプレートファイルへのパス。
- `placeholderValues` *(オプション)* — テンプレート内の動的コンテンツを置き換えるためのキーと値のペアのオブジェクト。

#### 生のHTML文字列から

```js
import { makeStylesInlineFromString } from 'tailwind-to-inline';

const html = `<div class="pt-10 text-yellow-300">Hello, {{name}}</div>`;
const htmlTemplate = await makeStylesInlineFromString(html, {
  name: 'John',
});
```

**パラメータ:**

- `templateString` — Tailwind CSSクラスを含む生のHTML文字列。
- `data` *(オプション)* — テンプレート内の動的コンテンツを置換するためのキーと値のペアのオブジェクト。


### 例
#### 元のテンプレート `welcome-email.html`:

```html
<html>
  <body class="bg-gray-800">
    <div class="pt-10 mb-4 pl-4 max-w-[512px] relative z-20">
      <span class="mr-5 text-yellow-300">Welcome, {{name}}</span>
    </div>
    <div>
      <a href="https://example.com/complete-profile" class="bg-blue-500">
        {{cta_text}}
      </a>
    </div>
  </body>
</html>
```

#### 変換結果:

```html
<html>
  <body style="background-color: #1f2937;">
    <div style="position: relative; z-index: 20; max-width: 512px; margin-bottom: 1rem; padding-left: 1rem; padding-top: 2.5rem;">
      <span style="margin-right: 1.25rem; color: #fde047;">Welcome, John</span>
    </div>
    <div>
      <a href="https://example.com/complete-profile" style="background-color: #3b82f6;">
        Complete Profile
      </a>
    </div>
  </body>
</html>
```
### 貢献について

貢献、問題報告、機能リクエストを歓迎します！

### コントリビューター

<a href="https://github.com/vardan-arm"><img src="https://github.com/vardan-arm.png" width="50" height="50" alt="vardan-arm" /></a>
<a href="https://github.com/diogomoretti"><img src="https://github.com/diogomoretti.png" width="50" height="50" alt="diogomoretti" /></a>
<a href="https://github.com/markosmk"><img src="https://github.com/markosmk.png" width="50" height="50" alt="markosmk" /></a>

### ライセンス

このプロジェクトはMITライセンスの下で提供されています。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-09

---