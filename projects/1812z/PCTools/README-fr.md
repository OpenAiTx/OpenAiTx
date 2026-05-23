# 🖥️ PCTools

> Un programme Python simple pour une intégration transparente entre Windows et Home Assistant, permettant la surveillance matérielle, le contrôle à distance, et plus encore.

[![GitHub Release](https://img.shields.io/github/v/release/1812z/PCTools?style=flat-square&logo=github)](https://github.com/1812z/PCTools/releases/latest)
[![GitHub Downloads](https://img.shields.io/github/downloads/1812z/PCTools/total?style=flat-square&logo=github&label=Downloads)](https://github.com/1812z/PCTools/releases)
[![GitHub Stars](https://img.shields.io/github/stars/1812z/PCTools?style=flat-square&logo=github)](https://github.com/1812z/PCTools)
[![License](https://img.shields.io/github/license/1812z/PCTools?style=flat-square)](LICENSE)

---

## ✨ Fonctionnalités

| Fonction | Description |
|------|------|
| 📊 **Surveillance Aida64** | Mise à jour périodique des données des capteurs sélectionnés |
| 🎮 **Commandes à distance** | Synchronisation automatique des fichiers `.bat` et `.lnk` dans le dossier `commands` vers HA |
| 📸 **Surveillance Web** | Capture d'écran / Caméra / Streaming vidéo en temps réel |
| 💬 **Notifications** | Écoute des entrées texte HA, affichage en messages Toast |
| 🌐 **Barre latérale web** | Raccourci pour afficher la barre latérale web de HA |
| ⌨️ **Raccourcis clavier associés** | Activation d’un capteur binaire HA via raccourci clavier |
| 📱 **Retour d’application au premier plan** | Rapport automatique du nom de l’application active, compatible avec [Runtime Tracker](https://github.com/1812z/RunTime_Tracker) |
| 🖥️ **Contrôle des écrans** | Luminosité / mise en marche / arrêt des moniteurs multiples via commandes DDC-CI |
| 🔊 **Contrôle du volume** | Gestion du volume système Windows |
| 🌙 **Mode sombre** | Basculer le système et les applications en mode sombre |
| 📶 **Contrôle Bluetooth** | Activation / désactivation du Bluetooth système |
| ⚡ **Ligne de commande** | Exécution de commandes CMD/PowerShell personnalisées |
| 🎨 **Wallpaper Engine** | Contrôle de Wallpaper Engine |
| ⌨️ **Simulation de touches** | Simulation de frappes clavier (y compris touches multimédia) |
| 🔗 **Lanceur d’URL** | Ouverture d’URL personnalisées |

**Points d’accès Web de surveillance :**
- Capture d’écran : `http://127.0.0.1:5000/screenshot.jpg`
- Caméra : `http://127.0.0.1:5000/video_feed`
- Vidéo en temps réel : `http://127.0.0.1:5000/screen`

---

## 📷 Captures d’écran démonstratives

<details>
<summary>🖼️ Interface logicielle</summary>
<img src="https://raw.githubusercontent.com/1812z/PCTools/main/.github/images/gui.png" alt="GUI" width="600"/>
</details>

<details>
<summary>📱 Interface HA</summary>

**Écran secondaire alternatif** (recommandé avec [HA_Helper](https://github.com/1812z/Ha_Helper))

<img src="https://raw.githubusercontent.com/1812z/PCTools/main/.github/images/1743859715274.jpg" alt="Écran secondaire" width="400"/>

**Page principale**

<img src="https://raw.githubusercontent.com/1812z/PCTools/main/.github/images/image.png" alt="Page principale" height="500"/>

</details>

---

## 🚀 Démarrage rapide

### 1️⃣ Installation de l’environnement

**Méthode 1** : Télécharger l’archive dans les [Releases](https://github.com/1812z/PCTools/releases/latest) (environnement d’exécution intégré)

**Méthode 2** : Configuration manuelle
```bash
# Python 3.12
pip install -r requirements.txt
```

### 2️⃣ Installation des dépendances tierces (optionnel)

| Dépendance | Usage |
|------------|-------|
| Serveur MQTT | Connexion à Home Assistant |
| [Aida64](https://github.com/1812z/PCTools/releases) | Surveillance des informations matérielles |
| [Twinkle Tray](https://github.com/xanderfrangos/twinkle-tray/releases) | Réglage de la luminosité de l’écran |

### 3️⃣ Configuration des dépendances

1. **Aida64** : activer le partage mémoire et cocher les données des capteurs nécessaires
2. **Twinkle Tray** : s’assurer que les informations de l’écran sont correctement lues
3. **Wallpaper Engine** : lancer pour supporter les opérations associées

> 💡 Après ajout/modification des capteurs, en cas de conflit, supprimer les appareils dans HA/MQTT et redémarrer le logiciel

### 4️⃣ Exécution du programme

1. Exécuter `打开GUI.bat` pour lancer l’interface
2. Accéder aux paramètres de configuration (**appuyez sur Entrée pour sauvegarder**)
3. Activer les plugins nécessaires (**redémarrage du programme recommandé**)
4. Cliquer sur démarrer, consulter les nouveaux appareils dans l’intégration MQTT de HA

### 5️⃣ Démarrage automatique (optionnel)

Cliquer sur **Démarrage automatique** dans les paramètres, le programme tournera en arrière-plan, icône visible dans la barre système

---

## 📋 Plan de développement

- [x] Liaison par raccourcis clavier
- [x] Optimisation du code
- [x] Optimisation de la logique des plugins
- [ ] Contrôle du ventilateur du PC
- [ ] Callback multi-boutons pour Toast
- [ ] Marché des plugins
- [ ] Contrôle média
- [ ] Synchronisation des paroles NetEase Cloud

---

## 💡 Combinaisons recommandées

| Logiciel | Description |
|------|------|
| [OpenRGB](https://openrgb.org/) | Contrôle des éclairages RGB, compatible avec l'intégration HA |
| [HASS.Agent](https://github.com/hass-agent/HASS.Agent) | Outil similaire plus stable |

---

## Remerciements

- [python_aida64](https://github.com/gwy15/python_aida64) - Lecture des données Aida64

---

## 📝 Autres

- Support du mode sans tête : `python core.py`
- Certaines pages nécessitent un changement pour se rafraîchir


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-23

---