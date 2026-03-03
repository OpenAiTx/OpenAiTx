
<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=zh-CN">簡體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=ko">韓國語</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=hi">印地語</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=th">泰語</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=fr">法語</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=de">德語</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=es">西班牙語</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=it">義大利語</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=ru">俄語</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=pt">葡萄牙語</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=nl">荷蘭語</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=pl">波蘭語</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=ar">阿拉伯語</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=fa">波斯語</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=tr">土耳其語</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=vi">越南語</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=id">印尼語</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=as">阿薩姆語</
      </div>
    </div>
  </details>
</div>

# ouch.yazi

[ouch](https://github.com/ouch-org/ouch) 插件，適用於 [Yazi](https://github.com/sxyazi/yazi)。

![ouch.yazi](https://github.com/ndtoan96/ouch.yazi/assets/33489972/946397ec-b37b-4bf4-93f1-c676fc8e59f2)

## 功能
- 壓縮檔預覽
- 壓縮

## 安裝

### Yazi 套件管理器
```bash
ya pkg add ndtoan96/ouch
```

### Git
```bash
# Linux/macOS
git clone https://github.com/ndtoan96/ouch.yazi.git ~/.config/yazi/plugins/ouch.yazi

# Windows with cmd
git clone https://github.com/ndtoan96/ouch.yazi.git %AppData%\yazi\config\plugins\ouch.yazi

# Windows with powershell
git clone https://github.com/ndtoan96/ouch.yazi.git "$($env:APPDATA)\yazi\config\plugins\ouch.yazi"
```

請確保您已安裝 [ouch](https://github.com/ouch-org/ouch)，並將其加入您的 `PATH`。

## 使用方式

### 預覽
若要預覽壓縮檔，請將以下內容加入您的 `yazi.toml`：

```toml
[[plugin.prepend_previewers]]
mime = "application/{*zip,tar,bzip2,7z*,rar,xz,zstd,java-archive}"
run  = "ouch"
```

現在進入 Yazi 上的某個壓縮檔案，你應該能在預覽窗格中看到該壓縮檔案的內容。你可以使用 `J` 和 `K` 來上下滾動預覽。

#### 自訂

你可以在 `run` 字串中新增額外參數來自訂預覽功能：

```toml
[plugin]
prepend_previewers = [
	# Change the top-level archive icon
	{ ..., run = "ouch --archive-icon='🗄️ '" },
	# Or remove it by setting it to ''
	{ ..., run = "ouch --archive-icon=''" },

	# Enable file icons
	{ ..., run = "ouch --show-file-icons" },

	# Disable tree view
	{ ..., run = "ouch --list-view" },

	# These can be combined
	{ ..., run = "ouch --archive-icon='🗄️ ' --show-file-icons --list-view" },
]
```

### 壓縮
若要進行壓縮，請將此內容加入您的 `keymap.toml`：

```toml
[[mgr.prepend_keymap]]
on = ["C"]
run = "plugin ouch"
desc = "Compress with ouch"
```

該插件預設使用 `zip` 格式。您可以在命名輸出檔案時更改格式，`ouch` 會根據檔案副檔名自動偵測格式。

例如，如果您想將預設格式設為 `7z`，可以使用 `plugin ouch 7z`。

### 解壓縮
此插件未提供解壓縮功能，因為 Yazi 已經支援該功能。
若要使用 `ouch` 進行解壓縮，請在 `yazi.toml` 中設定 opener。

```toml
[opener]
extract = [
	{ run = 'ouch d -y %*', desc = "Extract here with ouch", for = "windows" },
	{ run = 'ouch d -y "$@"', desc = "Extract here with ouch", for = "unix" },
]
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-03

---