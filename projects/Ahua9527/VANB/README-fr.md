# VANB (Pont Réseau Vidéo Audio)
# VANB (Pont NDI Assistant Vidéo)
# VANB (哇!! NB)

VANB est un outil de conversion de flux vidéo/audio basé sur GStreamer, prenant en charge la conversion bidirectionnelle entre les protocoles NDI et RTMP. Il permet de diffuser une source NDI vers un serveur RTMP ou de convertir un flux RTMP en sortie NDI.

Ce projet est open source sous licence [GPL-3.0](https://www.gnu.org/licenses/gpl-3.0.html).

## Plateformes prises en charge

Actuellement, les plateformes principalement prises en charge sont :
- macOS (Apple Silicon)

## Prérequis

### Dépendances système
- [GStreamer 1.24+](https://gstreamer.freedesktop.org)
- [NewTek NDI SDK](https://www.ndi.tv/sdk/)

### Étapes d'installation
1. Installer le [NewTek NDI SDK](https://www.ndi.tv/sdk/)

2. Installer GStreamer via Homebrew
```bash
brew install --cask --zap gstreamer-development
```

3. Cloner le dépôt du projet
```bash
git clone https://github.com/Ahua9527/VANB.git
cd VANB
```

4. Installer les dépendances Python
```bash
pip install -r requirements.txt
```

5. Configurer les variables d'environnement (voir le fichier .env pour référence)
```bash
# Configurer le chemin du NDI SDK
export NDI_SDK_PATH=/Library/NDI SDK for Apple
# Configurer le chemin des plugins GStreamer
export GST_PLUGIN_PATH=/opt/homebrew/lib/gstreamer-1.0:${NDI_SDK_PATH}/lib/macOS
export DYLD_LIBRARY_PATH=/opt/homebrew/lib:${NDI_SDK_PATH}/lib/macOS
export GI_TYPELIB_PATH=/opt/homebrew/lib/girepository-1.0:/usr/local/lib/girepository-1.0
```

## Mode d'emploi

### NDI vers RTMP (émetteur)
```bash
python vanb_tx.py
```
Le programme va automatiquement scanner les sources NDI disponibles et demander l'adresse de diffusion RTMP à saisir.

### RTMP vers NDI (récepteur)
```bash
python vanb_rx.py
```
Après avoir saisi l'adresse RTMP à recevoir, le programme créera automatiquement une nouvelle sortie NDI.

## État de développement

### Fonctionnalités réalisées
- ✓ Conversion NDI vers RTMP
- ✓ Conversion RTMP vers NDI
- ✓ Adaptation automatique du framerate et de la résolution
- ✓ Synchronisation audio/vidéo
- ✓ Scan automatique des sources NDI
- ✓ Nom automatique pour la sortie NDI
- ✓ Encodage/décodage matériel VideoToolbox

### Fonctionnalités à venir
- ⨯ Prise en charge des fichiers de configuration (Profile/config.json)
  - Contrôle des paramètres d'entrée/sortie via un fichier de configuration
  - Prise en charge de plusieurs profils de transcodage prédéfinis
  - Configuration possible de la taille des buffers et des paramètres de latence
  - Prise en charge de l'équilibre qualité/performance du transcodage
- ⨯ Traitement simultané de multiples flux

## Déclaration de licence

⚠️ **Avertissement important : Licence et conformité**

### Licence logicielle

Ce projet est sous licence [GNU General Public License v3.0](https://www.gnu.org/licenses/gpl-3.0.html).

Raisons du choix de la licence GPL-3.0 :
1. Ce projet utilise plusieurs plugins GStreamer sous licence GPL :
   - `x264` : encodeur vidéo H.264 (GPL)
   - `x265` : encodeur vidéo HEVC/H.265 (GPL)
   - `faad` : décodeur audio AAC (GPL)
2. Selon la clause de viralité de la GPL, tout logiciel utilisant des composants GPL doit également être sous licence GPL
3. Le choix de la GPL-3.0 garantit la compatibilité avec toutes les licences des dépendances

### Exigences de la licence

Lors de l'utilisation de ce projet, vous devez respecter les exigences suivantes :
1. **Code source ouvert** : Si vous modifiez le code de ce projet ou l’intégrez dans votre propre projet, vous devez publier l'intégralité de votre code source
2. **Maintien de la licence** : Votre projet doit continuer d’utiliser la licence GPL-3.0
3. **Mention du copyright** : Vous devez conserver les mentions de copyright et de licence originales
4. **Notification claire** : Si vous modifiez le code, vous devez indiquer clairement les modifications apportées
5. **Autorisation de brevet** : La GPL-3.0 comprend des clauses explicites d'autorisation de brevets

### Licence des composants GStreamer
1. Ce projet est uniquement destiné à des fins de développement et de test
2. NDI® est une marque déposée de NewTek, Inc.
3. L’utilisation de ce projet nécessite le respect de la licence du NewTek NDI® SDK
4. Avant toute utilisation en production, assurez-vous d’avoir obtenu toutes les licences et autorisations nécessaires

## Retour de problèmes

En cas de problème, veuillez :
1. Vérifier que les variables d’environnement sont correctement configurées
2. Confirmer que les plugins GStreamer sont correctement installés
3. Consulter les journaux pour des informations d'erreur détaillées
4. Remonter les problèmes via Issues en joignant les journaux et les informations d’environnement

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-17

---