
<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=en">Engels</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=zh-CN">Vereenvoudigd Chinees</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=zh-TW">Traditioneel Chinees</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=ja">Japans</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=ko">Koreaans</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=hi">Hindi</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=th">Thai</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=fr">Frans</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=de">Duits</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=es">Spaans</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=it">Italiaans</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=pt">Portugees</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=pl">Pools</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=ar">Arabisch</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=fa">Perzisch</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=tr">Turks</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=vi">Vietnamees</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=id">Indonesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=as">Assamees</a>
      </div>
    </div>
  </details>
</div>

# ouch.yazi

[ouch](https://github.com/ouch-org/ouch) plugin voor [Yazi](https://github.com/sxyazi/yazi).

![ouch.yazi](https://github.com/ndtoan96/ouch.yazi/assets/33489972/946397ec-b37b-4bf4-93f1-c676fc8e59f2)

## Functies
- Voorvertoning van archieven
- Compressie

## Installatie

### Yazi pakketbeheerder
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

Zorg ervoor dat je [ouch](https://github.com/ouch-org/ouch) hebt geïnstalleerd en dat deze in je `PATH` staat.

## Gebruik

### Voorbeeld
Voor een voorbeeld van een archief, voeg dit toe aan je `yazi.toml`:

```toml
[[plugin.prepend_previewers]]
mime = "application/{*zip,tar,bzip2,7z*,rar,xz,zstd,java-archive}"
run  = "ouch"
```

Ga nu naar een archief op Yazi, je zou de inhoud van het archief in het voorbeeldvenster moeten zien. Je kunt `J` en `K` gebruiken om omhoog en omlaag te scrollen in het voorbeeld.

#### Aanpassing

Voorbeelden kunnen worden aangepast door extra argumenten toe te voegen in de `run`-regel:

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

### Compressie
Voor compressie, voeg dit toe aan je `keymap.toml`:

```toml
[[mgr.prepend_keymap]]
on = ["C"]
run = "plugin ouch"
desc = "Compress with ouch"
```

De plugin gebruikt standaard het `zip`-formaat. Je kunt het formaat wijzigen door de uitvoerbestandsnaam aan te passen; `ouch` detecteert het formaat op basis van de bestandsextensie.

En, bijvoorbeeld, als je `7z` als standaardformaat wilt instellen, kun je `plugin ouch 7z` gebruiken.

### Uitpakken
Deze plugin biedt geen uitpakfunctie omdat dit al wordt ondersteund door Yazi.
Om uit te pakken met `ouch`, configureer de opener in `yazi.toml`.

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