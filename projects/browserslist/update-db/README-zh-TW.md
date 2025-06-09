# 更新 Browserslist 資料庫

<img width="120" height="120" alt="Browserslist logo by Anton Popov"
     src="https://browsersl.ist/logo.svg" align="right">

CLI 工具，用於從 [Browserslist](https://github.com/browserslist/browserslist/) 設定檔
更新 `caniuse-lite` 的瀏覽器資料庫。

有些查詢如 `last 2 versions` 或 `>1%` 會依賴
`caniuse-lite` 的實際資料。

```sh
npx update-browserslist-db@latest
```

<a href="https://evilmartians.com/?utm_source=update-browserslist-db">
  <img src="https://evilmartians.com/badges/sponsored-by-evil-martians.svg"
       alt="Sponsored by Evil Martians" width="236" height="54">
</a>

## 為什麼需要定期執行

`npx update-browserslist-db@latest` 會更新你 npm、yarn 或 pnpm
lock 檔案中的 `caniuse-lite` 版本。

這個更新會帶來新瀏覽器的資料給像 Autoprefixer 或 Babel 這類
Polyfill 工具，並減少已經不需要的 polyfill。

你需要定期執行，理由如下：

1. 在 `last 2 versions` 或 `>1%` 等查詢中，使用最新的瀏覽器版本與統計資料。例如，如果你在 2 年前建立專案且未更新依賴，`last 1 version` 會回傳 2 年前的瀏覽器版本。
2. 實際的瀏覽器資料會減少 polyfill 的使用。這可以減小 JS 和 CSS 檔案的大小，提升網站效能。
3. `caniuse-lite` 去重複：同步不同工具中的版本。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---