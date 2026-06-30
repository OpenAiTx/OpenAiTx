# sveltekit-adapter-chrome-extension

[SvelteKit 适配器](https://kit.svelte.dev/docs#adapters)，将您的 SvelteKit 应用预渲染为一组静态文件，并移除内联脚本，以符合使用 manifest v3 的 Chrome 扩展内容安全策略。

> 基于 [@sveltekit/adapter-static](https://github.com/sveltejs/kit/blob/master/packages/adapter-static)。感谢 [这些人](https://github.com/sveltejs/kit/graphs/contributors) 的辛勤付出，让 Svelte 变得如此出色。

> 🚧 如果您使用的是 SvelteKit v1.0.0+，请确保为扩展引用的每个页面设置 `prerender=true`，以便 SvelteKit 生成 HTML 文件。（参见 Issue #27）

## 使用方法

通过 `npm i -D sveltekit-adapter-chrome-extension` 安装，然后将适配器添加到您的 `svelte.config.js`：

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
## 选项

### pages

写入预渲染页面的目录。默认值为 `build`。

### assets

写入静态资源的目录（包括 `static` 目录的内容，以及 SvelteKit 生成的客户端 JS 和 CSS）。通常应与 `pages` 相同，默认值为 `pages` 的值，但在极少数情况下，您可能需要将页面和资源输出到不同的位置。

### fallback

为 SPA 模式指定回退页面，例如 `index.html`、`200.html` 或 `404.html`。

### precompress

如果为 `true`，则使用 brotli 和 gzip 对文件进行预压缩。这将生成 `.br` 和 `.gz` 文件。

### manifest

如果您想为不同目标平台使用不同的清单文件，请指定清单文件名，例如 `chrome_manifest.json`、`firefox_manifest.json`。
此文件名必须与 `static` 目录（包含您的静态文件的目录）中存在的文件名匹配。所选的目标文件将在构建目录中重命名为 `manifest.json`，所有其他名称中包含 `manifest` 的 `.json` 文件将不会被复制。

## 许可证

[MIT](LICENSE)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-30

---