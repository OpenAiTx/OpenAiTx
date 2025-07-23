<div align="right">
  <details>
    <summary >🌐 Langue</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# ComfyUI_Fill-ChatterBox

Si vous appréciez ce projet, pensez à me soutenir sur Patreon !
<p align="left">
  <a href="https://www.patreon.com/c/Machinedelusions">
    <img src="https://raw.githubusercontent.com/filliptm/ComfyUI_Fill-ChatterBox/main/assets/Patreon.png" width="150px" alt="Patreon">
  </a>
</p>

Une extension de nœud personnalisée pour ComfyUI qui ajoute des fonctionnalités de synthèse vocale (TTS) et de conversion de voix (VC) en utilisant la bibliothèque Chatterbox.
Supporte un MAXIMUM de 40 secondes. J'ai essayé de supprimer cette limitation, mais le modèle se détériore vraiment pour des durées plus longues, donc elle reste en place.

![ChatterBox Example](https://raw.githubusercontent.com/filliptm/ComfyUI_Fill-ChatterBox/main/web/image.png)

## Installation

1. Clonez ce dépôt dans le répertoire custom_nodes de votre installation ComfyUI :

   ```bash
   cd /path/to/ComfyUI/custom_nodes
   git clone https://github.com/filliptm/ComfyUI_Fill-ChatterBox.git
   ```
2. Installez les dépendances de base :

   ```bash
   pip install -r ComfyUI_Fill-ChatterBox/requirements.txt
   ```
3. (Facultatif) Installez la prise en charge du filigrane :

   ```bash
   pip install resemble-perth
   ```
**Remarque** : Le package `resemble-perth` peut présenter des problèmes de compatibilité avec Python 3.12+. Si vous rencontrez des erreurs d’importation, les nœuds fonctionneront toujours sans filigrane.


## Utilisation

### Nœud Text-to-Speech (FL Chatterbox TTS)
- Ajoutez le nœud "FL Chatterbox TTS" à votre workflow
- Configurez l’entrée texte et les paramètres (exagération, cfg_weight, temperature)
- Fournissez éventuellement une invite audio pour le clonage de voix

### Nœud Conversion de Voix (FL Chatterbox VC)
- Ajoutez le nœud "FL Chatterbox VC" à votre workflow
- Connectez l’audio d’entrée et la voix cible
- Les deux nœuds prennent en charge le basculement sur CPU en cas d’erreur CUDA

## Journal des modifications

### 24/06/2025
- Ajout du paramètre seed aux nœuds TTS et VC pour une génération reproductible
- Plage de seed : 0 à 4 294 967 295 (entier 32 bits)
- Permet une sortie audio cohérente pour le débogage et le contrôle du workflow
- Marquage Perth rendu optionnel pour résoudre les problèmes de compatibilité Python 3.12+
- Les nœuds fonctionnent désormais sans filigrane si l’import de resemble-perth échoue

### 31/05/2025
- Ajout du chargement persistant des modèles, et d’une barre de chargement
- Ajout du support Mac (nécessite des tests donc contactez-moi)
- Suppression de la bibliothèque chatterbox-tts et implémentation du code d’inférence natif.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-23

---