# 🐋 Qwen Image Integrated KSampler

[![GitHub](https://img.shields.io/badge/GitHub-luguoli-orange)](https://github.com/luguoli)
[![ComfyUI](https://img.shields.io/badge/ComfyUI-CustomNode-blue)](https://github.com/comfyanonymous/ComfyUI)

[English](https://raw.githubusercontent.com/luguoli/ComfyUI-Qwen-Image-Integrated-KSampler/main/README-en.md) | **[简体中文](https://raw.githubusercontent.com/luguoli/ComfyUI-Qwen-Image-Integrated-KSampler/main/README-zh.md)**

QwenImageIntegratedKSampler

Ceci est un nœud sampler intégré pour la génération d’images ComfyUI Qwen-Image, supportant Z-Image. Comparé à l’utilisation du KSampler officiel, il élimine le câblage désordonné, supporte la génération texte-à-image et image-à-image, résout les problèmes de décalage des nœuds officiels, et intègre la boîte de saisie de prompt, le redimensionnement automatique des images, le nettoyage automatique de la mémoire/VRAM, la génération par lots, la sauvegarde automatique et d’autres fonctionnalités d’optimisation complètes, ainsi maman n’a plus à s’inquiéter de mon câblage désordonné~~~~

#### Si ce projet vous aide, merci de lui donner une étoile ⭐Star — cela me montre qu’il y a des humains qui l’utilisent !

## 🏆 Fonctionnalités

### 🎨 Modes de génération supportés
- **Z-Image** : Support du modèle Z-Image
- **Texte-à-Image** : Génération d’images à partir de prompts textuels
- **Image-à-Image** : Génération basée sur des images de référence, édition d’image, supporte jusqu’à 5 images

### ⚡ Optimisations avancées
- **Optimisation des problèmes de décalage** : Résout les problèmes de décalage des nœuds officiels, et suit mieux les instructions
- **Intégration de l’algorithme d’échantillonnage (AuraFlow)** : Intègre le nœud d’algorithme d’échantillonnage (AuraFlow), aucun câblage supplémentaire nécessaire
- **Intégration CFGNorm** : Intègre le nœud CFGNorm, aucun câblage supplémentaire nécessaire

### 🖼️ Traitement d’image
- **Boîte de saisie de prompt intégrée** : Intègre la boîte de saisie de prompt, aucun câblage supplémentaire nécessaire
- **Images de référence multiples** : Supporte jusqu’à 5 images de référence pour la génération conditionnelle
- **Redimensionnement automatique des images** : Maintient le ratio d’aspect tout en redimensionnant aux dimensions cibles

- **Support du contrôle ControlNet** : Connexion supplémentaire au [🐋 Qwen ControlNet Integrated Loader] pour le contrôle de pose, profondeur et autres

### 🔧 Amélioration de la productivité
- **Génération par lots** : Génère plusieurs images en une seule opération
- **Nettoyage automatique de la VRAM** : Options de nettoyage automatique pour la mémoire GPU/VRAM
- **Nettoyage automatique de la RAM** : Options de nettoyage automatique pour la mémoire RAM
- **Sauvegarde automatique des résultats** : Sauvegarde automatique des images générées dans le dossier spécifié
- **Notification sonore de fin** : Joue un rappel audio à la fin de la génération

## 🍧 Affichage comparatif
### 🔄 Comparaison de la complexité des workflows  
- **❌ Workflow sans utiliser [Qwen Image Integrated KSampler] (compliqué, trop de nœuds, trop de câbles)**  
![alt text](https://raw.githubusercontent.com/luguoli/ComfyUI-Qwen-Image-Integrated-KSampler/main/images/1-1-en.png)  
- **✅ Workflow utilisant [Qwen Image Integrated KSampler] (extrêmement simple, un seul nœud, presque pas de câbles)**  
![alt text](https://raw.githubusercontent.com/luguoli/ComfyUI-Qwen-Image-Integrated-KSampler/main/images/1-2-en.png)  

### 🖼️ Comparaison de l’effet sur l’image générée  
- **❌ Workflow sans utiliser [Qwen Image Integrated KSampler] (décalage et mise à l’échelle évidents)**  
![alt text](https://raw.githubusercontent.com/luguoli/ComfyUI-Qwen-Image-Integrated-KSampler/main/images/2-1.png)  
- **✅ Workflow utilisant [Qwen Image Integrated KSampler] (aucun décalage ni mise à l’échelle)**  
![alt text](https://raw.githubusercontent.com/luguoli/ComfyUI-Qwen-Image-Integrated-KSampler/main/images/2-2.png)  

## 📦 Méthode d’installation  

### Méthode 1 : Via ComfyUI Manager (Recommandé)  
1. Ouvrez ComfyUI Manager dans l’interface de ComfyUI  
2. Recherchez "ComfyUI-Qwen-Image-Integrated-KSampler"  
3. Cliquez sur Installer  

### Méthode 2 : Installation manuelle  
1. Rendez-vous dans votre répertoire des nœuds personnalisés de ComfyUI :
   ```bash
   cd /path/to/ComfyUI/custom_nodes
   ```

2. Clonez le dépôt :
   ```bash
   git clone https://github.com/luguoli/ComfyUI-Qwen-Image-Integrated-KSampler.git
   or gitee repository:
   git clone https://gitee.com/luguoli/ComfyUI-Qwen-Image-Integrated-KSampler.git
   ```

3. Installer les dépendances :
   ```bash
   pip install -r requirements.txt
   ```
4. Redémarrer ComfyUI

## 🚀 Méthode d'utilisation

### [Exemple de flux de travail](https://raw.githubusercontent.com/luguoli/ComfyUI-Qwen-Image-Integrated-KSampler/main/workflow_example.json)

### Génération basique de texte en image

1. Ajouter le nœud "🐋 Qwen Image Integrated KSampler" au flux de travail
2. Régler `generation_mode` sur "text-to-image"
3. Connecter les entrées requises :
   - Modèle (🤖 Model)
   - CLIP (🟡 Clip)
   - VAE (🎨 Vae)
4. Entrer les invites positives et négatives
5. Définir la largeur et la hauteur (requis pour texte en image)
6. Configurer les paramètres d’échantillonnage (steps, CFG, sampler, scheduler)
7. Exécuter le flux de travail

### Génération image à image

1. Ajouter le nœud au flux de travail
2. Régler `generation_mode` sur "image-to-image"
3. Connecter au moins une image de référence (🖼️ Image1)
4. Ajouter éventuellement jusqu’à 4 autres images de référence
5. Entrer les invites et instructions positives/négatives
6. Définir largeur/hauteur cible pour redimensionnement (optionnel)
7. Configurer les autres paramètres selon besoin
8. Exécuter le flux de travail

### Contrôle ControlNet

1. Ajouter le nœud [🐋 Qwen ControlNet Integrated Loader], connecter à [📦 ControlNet Data]

2. Connecter les images de contrôle pose, profondeur

3. Sélectionner le modèle ControlNet, régler type et force de contrôle

4. Exécuter le flux de travail


![alt text](https://raw.githubusercontent.com/luguoli/ComfyUI-Qwen-Image-Integrated-KSampler/main/images/3-en.png)

### Fonctionnalités Avancées

- **Gestion de la Mémoire** : Activez les options de nettoyage GPU/CPU pour améliorer l'efficacité des ressources  
- **Traitement par Lots** : Définissez batch_size > 1 pour générer plusieurs images  
- **Sauvegarde Automatique** : Spécifiez un dossier de sortie pour la sauvegarde automatique  
- **Réglage AuraFlow** : Ajustez auraflow_shift pour équilibrer vitesse et qualité  
- **Amélioration CFG** : Stabilisateur pour CFG  

## ⚠️ Notes

### 📝 Exigences d'Utilisation  
- **Mode Texte-à-Image** : Doit définir la largeur (Width) et la hauteur (Height), ce sont des paramètres obligatoires  
- **Mode Image-à-Image** : Doit fournir au moins une image de référence (Image1), supporte jusqu'à 5 images de référence (Image1-Image5)  

### 🎛️ Suggestions de Réglage des Paramètres  
- **Taille du Lot** : Choisissez entre 1-10, ajustez selon la mémoire GPU, il est recommandé de commencer les tests à 1  
- **Résolution (Largeur/Hauteur)** : Doit être multiple de 8, plage 0-16384, il est conseillé de commencer les tests à des résolutions plus basses (comme 512x512)  
- **Étapes d'Échantillonnage** : Les modèles Qwen recommandent 4-20 étapes, trop élevé peut augmenter le temps de calcul sans forcément améliorer la qualité  
- **Valeur CFG** : Plage 0-100, défaut 1.0, recommandé entre 1.0 et 7.0  
- **Force de Dénoyage** : Plage 0-1, défaut 1.0, peut être abaissée de façon appropriée en mode image-à-image  
- **Décalage AuraFlow** : Plage 0-100, défaut 3.0, utilisé pour équilibrer vitesse et qualité de génération  
- **Force de Normalisation CFG** : Plage 0-100, défaut 1.0, stabilisateur pour CFG  

### 🔧 Traitement des Images  
- **Mise à l'Échelle Automatique** : En texte-à-image, il faut entrer les paramètres largeur et hauteur, en image-à-image, ces paramètres permettent la mise à l’échelle automatique des images de référence tout en conservant le ratio d’aspect, définir soit la largeur soit la hauteur à 0 désactive la mise à l’échelle  
- **Ordre des Images de Référence** : Supporte jusqu’à 5 images de référence, traitées dans l’ordre Image1-Image5, Image1 est l’image principale  
- **Format d’Image** : Supporte les formats standards d'entrée d'image, gère automatiquement les dimensions de lot  

### 💾 Gestion de la Mémoire  
- **Nettoyage Mémoire GPU** : Activez l’option enable_clean_gpu_memory, nettoie automatiquement la VRAM avant/après génération  
- **Nettoyage Mémoire CPU** : Activez enable_clean_cpu_memory_after_finish, nettoie la RAM après la génération (incluant cache fichiers, processus, bibliothèques dynamiques)  
- Pour une génération continue à grande échelle, il est recommandé d’activer systématiquement les options de nettoyage mémoire pour éviter les débordements  

### 💾 Sauvegarde Automatique  
- **Dossier de Sortie** : Définissez auto_save_output_folder pour activer la fonction de sauvegarde automatique, laissez vide pour désactiver, supporte les chemins absolus et relatifs  
- **Nom de Fichier** : output_filename_prefix préfixe personnalisé, par défaut "auto_save"  
- Le format de sauvegarde est PNG, le nom de fichier inclut la graine et le numéro du lot (ex. : auto_save_123456_00000.png)

### 🔊 Fonction de Notification
- **Notification Sonore** : Supportée uniquement sur les systèmes Windows

## 📝 Historique des Mises à Jour
### v1.0.6 :
- **Ajout du Script de Localisation :** À partir de ComfyUI v0.3.68, les fichiers de langue chinoise sont devenus invalides. Ajout d’un script de localisation automatique, double-cliquez sur [自动汉化节点.bat] et redémarrez ComfyUI, nécessite l’installation du plugin ComfyUI-DD-Translation


## 📞 Contact pour Personnalisation Spéciale 📞
- Auteur : @luguoli（墙上的向日葵）
- Email de l’Auteur : luguoli@vip.qq.com


---

**Fait avec ❤️ pour la communauté ComfyUI**


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-25

---