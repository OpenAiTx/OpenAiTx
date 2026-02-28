# ouch.yazi

Plugin [ouch](https://github.com/ouch-org/ouch) pour [Yazi](https://github.com/sxyazi/yazi).

![ouch.yazi](https://github.com/ndtoan96/ouch.yazi/assets/33489972/946397ec-b37b-4bf4-93f1-c676fc8e59f2)

## Fonctionnalités
- Aperçu des archives
- Compression

## Installation

### Gestionnaire de paquets Yazi
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

Assurez-vous d'avoir [ouch](https://github.com/ouch-org/ouch) installé et dans votre `PATH`.

## Utilisation

### Aperçu
Pour l'aperçu des archives, ajoutez ceci à votre `yazi.toml`:

```toml
[[plugin.prepend_previewers]]
mime = "application/{*zip,tar,bzip2,7z*,rar,xz,zstd,java-archive}"
run  = "ouch"
```

Allez maintenant dans une archive sur Yazi, vous devriez voir le contenu de l'archive dans le volet d'aperçu. Vous pouvez utiliser `J` et `K` pour faire défiler l'aperçu vers le bas et vers le haut.

#### Personnalisation

Les aperçus peuvent être personnalisés en ajoutant des arguments supplémentaires dans la chaîne `run` :

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
Pour la compression, ajoutez ceci à votre `keymap.toml` :

```toml
[[mgr.prepend_keymap]]
on = ["C"]
run = "plugin ouch"
desc = "Compress with ouch"
```

Le plugin utilise le format `zip` par défaut. Vous pouvez changer le format en nommant le fichier de sortie, `ouch` détectera le format en fonction de l'extension du fichier.

Et, par exemple, si vous souhaitez définir `7z` comme format par défaut, vous pouvez utiliser `plugin ouch 7z`.

### Décompression
Ce plugin ne fournit pas de fonction de décompression car elle est déjà prise en charge par Yazi.
Pour décompresser avec `ouch`, configurez l'ouvre-fichier dans `yazi.toml`.

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