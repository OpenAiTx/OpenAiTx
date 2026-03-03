
<div align="right">
  <details>
    <summary >🌐 Language</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=zh-CN">Simplified Chinese</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=zh-TW">Traditional Chinese</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=ja">Japanese</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=ko">Korean</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=hi">Hindi</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=th">Thai</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=fr">French</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=de">German</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=es">Spanish</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=it">Italian</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=ru">Russian</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=pt">Portuguese</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=nl">Dutch</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=pl">Polish</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=ar">Arabic</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=fa">Persian</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=tr">Turkish</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=vi">Vietnamese</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=id">Indonesian</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=as">Assamese</
      </div>
    </div>
  </details>
</div>

# ouch.yazi

[ouch](https://github.com/ouch-org/ouch) plugin for [Yazi](https://github.com/sxyazi/yazi).

![ouch.yazi](https://github.com/ndtoan96/ouch.yazi/assets/33489972/946397ec-b37b-4bf4-93f1-c676fc8e59f2)

## Features
- Archive preview
- Compression

## Installation

### Yazi package manager
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

Make sure you have [ouch](https://github.com/ouch-org/ouch) installed and in your `PATH`.

## Usage

### Preview
For archive preview, add this to your `yazi.toml`:

```toml
[[plugin.prepend_previewers]]
mime = "application/{*zip,tar,bzip2,7z*,rar,xz,zstd,java-archive}"
run  = "ouch"
```

Now go to an archive on Yazi, you should see the archive's content in the preview pane. You can use `J` and `K` to scroll up and down the preview.

#### Customization

Previews can be customized by adding extra arguments in the `run` string:

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

### Compression
For compression, add this to your `keymap.toml`:

```toml
[[mgr.prepend_keymap]]
on = ["C"]
run = "plugin ouch"
desc = "Compress with ouch"
```

The plugin uses the `zip` format by default. You can change the format when you name the output file; `ouch` will detect the format based on the file extension.

And, for example, if you would like to set `7z` as the default format, you can use `plugin ouch 7z`.

### Decompression
This plugin does not provide a decompression feature because it is already supported by Yazi.
To decompress with `ouch`, configure the opener in `yazi.toml`.

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