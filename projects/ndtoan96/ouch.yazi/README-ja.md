# ouch.yazi

[ouch](https://github.com/ouch-org/ouch) の [Yazi](https://github.com/sxyazi/yazi) プラグインです。

![ouch.yazi](https://github.com/ndtoan96/ouch.yazi/assets/33489972/946397ec-b37b-4bf4-93f1-c676fc8e59f2)

## 特徴
- アーカイブプレビュー
- 圧縮

## インストール

### Yazi パッケージマネージャー
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

[ouch](https://github.com/ouch-org/ouch) がインストールされ、`PATH` に含まれていることを確認してください。

## 使い方

### プレビュー
アーカイブのプレビューには、`yazi.toml` に次の内容を追加してください：

```toml
[[plugin.prepend_previewers]]
mime = "application/{*zip,tar,bzip2,7z*,rar,xz,zstd,java-archive}"
run  = "ouch"
```

次にYaziのアーカイブに移動すると、プレビューペインにアーカイブの内容が表示されます。プレビューを上下にスクロールするには `J` と `K` を使用できます。

#### カスタマイズ

プレビューは `run` 文字列に追加の引数を加えることでカスタマイズ可能です：

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

### 圧縮
圧縮には、これを `keymap.toml` に追加してください:

```toml
[[mgr.prepend_keymap]]
on = ["C"]
run = "plugin ouch"
desc = "Compress with ouch"
```

プラグインはデフォルトで `zip` 形式を使用します。出力ファイルの名前を変更すると、`ouch` はファイル拡張子に基づいて形式を検出します。

例えば、`7z` をデフォルト形式に設定したい場合は、`plugin ouch 7z` を使用できます。

### 解凍
このプラグインは解凍機能を提供していません。なぜなら、すでに Yazi が対応しているためです。
`ouch` で解凍するには、`yazi.toml` でオープナーを設定してください。

```toml
[opener]
extract = [
	{ run = 'ouch d -y %*', desc = "Extract here with ouch", for = "windows" },
	{ run = 'ouch d -y "$@"', desc = "Extract here with ouch", for = "unix" },
]
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-28

---