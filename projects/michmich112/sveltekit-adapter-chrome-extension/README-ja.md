# sveltekit-adapter-chrome-extension

SvelteKitアプリ向けの[アダプター](https://kit.svelte.dev/docs#adapters)で、サイトを静的ファイルのコレクションとしてプリレンダリングし、Manifest v3を使用するChrome拡張機能のコンテンツセキュリティポリシーに準拠するためにインラインスクリプトを削除します。

> [@sveltekit/adapter-static](https://github.com/sveltejs/kit/blob/master/packages/adapter-static)をベースにしています。Svelteを素晴らしいものにするために尽力してくださった[これらの方々](https://github.com/sveltejs/kit/graphs/contributors)に感謝します。

> 🚧 SvelteKit v1.0.0+を使用している場合は、拡張機能が参照するすべてのページで`prerender=true`を設定し、SvelteKitがHTMLファイルを生成するようにしてください。（参照：Issue #27）

## 使い方

`npm i -D sveltekit-adapter-chrome-extension`でインストールし、`svelte.config.js`にアダプターを追加します：

```js
// svelte.config.js
import adapter from "sveltekit-adapter-chrome-extension";

export default {
  kit: {
    adapter: adapter({
      // default options are shown
      pages: "build",
      assets: "build",
      fallback: null,
      precompress: false,
      manifest: "manifest.json",
    }),
    appDir: "app",
  },
};
```
## オプション

### pages

事前レンダリングされたページを書き出すディレクトリ。デフォルトは `build` です。

### assets

静的アセットを書き出すディレクトリ（`static` の内容に加え、SvelteKit によって生成されたクライアントサイドのJSおよびCSS）。通常は `pages` と同じにすべきで、デフォルトも `pages` の値に従いますが、稀にページとアセットを別々の場所に出力する必要がある場合があります。

### fallback

SPAモードのフォールバックページを指定します。例えば `index.html` や `200.html`、`404.html` など。

### precompress

`true` の場合、ファイルをbrotliおよびgzipで事前圧縮します。これにより `.br` と `.gz` ファイルが生成されます。

### manifest

異なるターゲットプラットフォーム用に異なるマニフェストを使用したい場合に、マニフェストファイル名を指定します。例：`chrome_manifest.json`、`firefox_manifest.json`。
このファイル名は `static` ディレクトリ（静的ファイルを含むディレクトリ）に存在する必要があります。選択されたターゲットファイルはビルドディレクトリで `manifest.json` にリネームされ、その他の `manifest` を含む `.json` ファイルはコピーされません。

## ライセンス

[MIT](LICENSE)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-30

---