# 更新 Browserslist 数据库

<img width="120" height="120" alt="Browserslist logo by Anton Popov"
     src="https://browsersl.ist/logo.svg" align="right">

命令行工具，用于根据 [Browserslist](https://github.com/browserslist/browserslist/) 配置文件，更新 `caniuse-lite` 中的浏览器数据库。

某些查询（如 `last 2 versions` 或 `>1%`）依赖于 `caniuse-lite` 中的实际数据。

```sh
npx update-browserslist-db@latest
```

<a href="https://evilmartians.com/?utm_source=update-browserslist-db">
  <img src="https://evilmartians.com/badges/sponsored-by-evil-martians.svg"
       alt="Sponsored by Evil Martians" width="236" height="54">
</a>

## 为什么需要定期运行该命令

`npx update-browserslist-db@latest` 会在你的 npm、yarn 或 pnpm lock 文件中更新 `caniuse-lite` 的版本。

此更新会为 Autoprefixer 或 Babel 等 polyfill 工具带来新的浏览器数据，并减少已不必要的 polyfill。

你需要定期执行该操作，原因有三：

1. 在 `last 2 versions` 或 `>1%` 等查询中，使用最新的浏览器版本和统计信息。例如，如果你在 2 年前创建了项目并且未更新依赖，`last 1 version` 返回的将是 2 年前的浏览器。
2. 实时的浏览器数据将减少 polyfill 的使用，从而减小 JS 和 CSS 文件的体积，提高网站性能。
3. `caniuse-lite` 去重：用于同步不同工具中的版本。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---