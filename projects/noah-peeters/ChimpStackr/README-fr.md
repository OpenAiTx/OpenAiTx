# ChimpStackr

![GitHub all releases](https://img.shields.io/github/downloads/noah-peeters/ChimpStackr/total) ![GitHub release (latest by date)](https://img.shields.io/github/downloads/noah-peeters/ChimpStackr/latest/total) ![GitHub](https://img.shields.io/github/license/noah-peeters/ChimpStackr) ![GitHub commits since latest release (by date)](https://img.shields.io/github/commits-since/noah-peeters/ChimpStackr/latest)

<p align="center">
  <img src="https://raw.githubusercontent.com/noah-peeters/ChimpStackr/master/packaging/icons/chimpstackr_icon.png" width="200"/>
</p>

Application open-source de focus stacking pour Windows, macOS et Linux.

## Fonctionnalités

- **4 algorithmes d'empilement :** Pyramide Laplacienne, Moyenne Pondérée, Carte de Profondeur, Fusion d'Exposition (HDR)
- **Alignement automatique :** Correction par translation uniquement ou rotation + échelle (respiration de la mise au point)
- **Pipeline 16 bits :** Conservation complète de la profondeur de bit du RAW à la sortie
- **Recadrage automatique :** Supprime les bords noirs dus aux décalages d’alignement
- **Auto-ajustement :** Paramètres détectés automatiquement selon la résolution de l'image
- **GUI + CLI :** Interface graphique complète et outil en ligne de commande sans interface
- **Multi-plateforme :** Builds natifs pour Windows, macOS, Linux
- **Pause/reprise/annulation :** Contrôle des piles longues
- **Comparaison avant/après :** Visualiseur avec curseur pour comparer entrée et sortie
- **Glisser-déposer :** Déposez les fichiers ou dossiers images directement dans l’application

## Téléchargement

Les paquets précompilés sont disponibles sur la page [Releases](https://github.com/noah-peeters/ChimpStackr/releases) :

| Plateforme | Téléchargement | Notes |
|---|---|---|
| **Windows** | `ChimpStackr-Windows.zip` | Extraire et lancer `chimpstackr.exe` |
| **macOS** | `ChimpStackr-macOS.dmg` | Ouvrir le DMG, glisser dans Applications |
| **Linux** | `ChimpStackr-Linux-x86_64.AppImage` | `chmod +x` puis lancer |

## Utilisation CLI

La CLI permet un focus stacking sans interface graphique :

```bash
# Basic stack
chimpstackr-cli --input images/*.jpg --output result.tif

# Align + stack with auto parameters
chimpstackr-cli -i images/*.jpg -o result.tif --align --auto --auto-crop

# Full options
chimpstackr-cli -i images/*.jpg -o result.png \
  --align \
  --method laplacian \
  --rotation-scale \
  --kernel-size 6 \
  --pyramid-levels 8 \
  --auto-crop \
  --quality-report
```

**Méthodes disponibles :** `laplacian` (par défaut), `weighted_average`, `depth_map`

## Algorithmes d'empilement

| Méthode | Idéal pour | Fonctionnement |
|---|---|---|
| **Pyramide** | Détails fins (cheveux, poils, bords) | Décomposition en pyramide laplacienne, sélection du contraste max par bande de fréquence, mappage local des tons |
| **Pondéré** | Sujets lisses, bonne couleur | Pondération du contraste par pixel avec accumulation appropriée |
| **Carte de profondeur** | Surfaces opaques, meilleure fidélité des couleurs | Netteté multi-échelle avec lissage bilatéral sensible aux bords |
| **HDR** | Exposition/éclairage variable | Fusion d'exposition de Mertens (pas pour l'empilement de mise au point) |

## Compilation depuis la source

Nécessite Python 3.9-3.13.

```bash
git clone https://github.com/noah-peeters/ChimpStackr.git
cd ChimpStackr
python -m venv .venv
source .venv/bin/activate  # or .venv\Scripts\activate on Windows
pip install -r requirements.txt

# Run GUI
python src/run.py

# Run CLI
python -m src.cli --help

# Run tests
pip install pytest
pytest tests/ -v
```

## Emballage

Les builds utilisent PyInstaller avec un post-traitement spécifique à la plateforme. Vous ne pouvez construire que pour votre plateforme actuelle.

```bash
# Install build tools
pip install pyinstaller

# Build (creates dist/chimpstackr/ and dist/ChimpStackr.app on macOS)
pyinstaller chimpstackr.spec --noconfirm

# Or use the platform scripts:
./scripts/build_macos.sh        # macOS → .dmg
./scripts/build_linux.sh        # Linux → .AppImage
.\scripts\build_windows.ps1     # Windows → .zip or installer
```

CI/CD construit automatiquement toutes les plateformes lors des versions taguées via GitHub Actions.

## Galerie

Les piles suivantes ont été prises à environ 4x de grossissement sur un support légèrement instable (~150 images chacune), empilées avec ChimpStackr et post-traitées dans [darktable](https://www.darktable.org/).

![Bij_TranslationAlignment](https://user-images.githubusercontent.com/17707805/196990942-413ea35c-2abb-4bce-9807-3f3d6b3de3c5.jpg)
![Edited](https://user-images.githubusercontent.com/17707805/196991117-dc4f1c76-cc87-4ef1-92ee-9a7484c7ff07.jpg)
![Bewerkt](https://user-images.githubusercontent.com/17707805/196996295-9fb6c365-ef10-4ef5-b451-1a7269156e53.jpg)

## Sources

- Algorithme d'empilement de mise au point basé sur : Wang, W., & Chang, F. (2011). A Multi-focus Image Fusion Method Based on Laplacian Pyramid. *Journal of Computers*, 6(12).
- Alignement d'images par DFT adapté de : [imreg_dft](https://github.com/matejak/imreg_dft)
- Fusion d'exposition de Mertens : Mertens, T., Kautz, J., & Van Reeth, F. (2007). Exposure Fusion.
- Mesure de mise au point Sum Modified Laplacian : Nayar, S.K., & Nakagawa, Y. (1994).

## Licence

GPL-3.0 - voir [LICENSE](LICENSE) pour les détails.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-29

---