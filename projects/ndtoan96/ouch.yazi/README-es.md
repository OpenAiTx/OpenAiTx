
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# ouch.yazi

[ouch](https://github.com/ouch-org/ouch) complemento para [Yazi](https://github.com/sxyazi/yazi).

![ouch.yazi](https://github.com/ndtoan96/ouch.yazi/assets/33489972/946397ec-b37b-4bf4-93f1-c676fc8e59f2)

## Características
- Vista previa de archivos comprimidos
- Compresión

## Instalación

### Gestor de paquetes Yazi
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

Asegúrate de tener instalado [ouch](https://github.com/ouch-org/ouch) y que esté en tu `PATH`.

## Uso

### Vista previa
Para la vista previa de archivos, añade esto a tu `yazi.toml`:

```toml
[[plugin.prepend_previewers]]
mime = "application/{*zip,tar,bzip2,7z*,rar,xz,zstd,java-archive}"
run  = "ouch"
```

Ahora ve a un archivo en Yazi, deberías ver el contenido del archivo en el panel de vista previa. Puedes usar `J` y `K` para desplazarte hacia arriba y abajo en la vista previa.

#### Personalización

Las vistas previas se pueden personalizar añadiendo argumentos adicionales en la cadena `run`:

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

### Compresión
Para la compresión, añade esto a tu `keymap.toml`:

```toml
[[mgr.prepend_keymap]]
on = ["C"]
run = "plugin ouch"
desc = "Compress with ouch"
```

El plugin utiliza el formato `zip` por defecto. Puedes cambiar el formato al nombrar el archivo de salida, `ouch` detectará el formato según la extensión del archivo.

Y, por ejemplo, si deseas establecer `7z` como formato predeterminado, puedes usar `plugin ouch 7z`.

### Descompresión
Este plugin no proporciona una función de descompresión porque ya está soportada por Yazi.
Para descomprimir con `ouch`, configura el abridor en `yazi.toml`.

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