# ouch.yazi

[ouch](https://github.com/ouch-org/ouch) 的 [Yazi](https://github.com/sxyazi/yazi) 插件。

![ouch.yazi](https://github.com/ndtoan96/ouch.yazi/assets/33489972/946397ec-b37b-4bf4-93f1-c676fc8e59f2)

## 功能
- 归档预览
- 压缩

## 安装

### Yazi 包管理器
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
确保你已经安装了 [ouch](https://github.com/ouch-org/ouch) 并且将其加入到你的 `PATH` 中。

## 使用方法

### 预览
对于归档预览，将以下内容添加到你的 `yazi.toml` 中：


```toml
[[plugin.prepend_previewers]]
mime = "application/{*zip,tar,bzip2,7z*,rar,xz,zstd,java-archive}"
run  = "ouch"
```
现在转到 Yazi 上的一个存档，你应该能在预览窗格中看到存档的内容。你可以使用 `J` 和 `K` 向上或向下滚动预览。

#### 自定义

可以通过在 `run` 字符串中添加额外参数来自定义预览：


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

### 压缩
对于压缩，将此添加到您的 `keymap.toml`：

```toml
[[mgr.prepend_keymap]]
on = ["C"]
run = "plugin ouch"
desc = "Compress with ouch"
```

该插件默认使用 `zip` 格式。您可以通过命名输出文件来更改格式，`ouch` 将根据文件扩展名检测格式。

例如，如果您想将 `7z` 设为默认格式，可以使用 `plugin ouch 7z`。

### 解压
该插件不提供解压功能，因为 Yazi 已经支持该功能。
要使用 `ouch` 进行解压，请在 `yazi.toml` 中配置打开器。

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