
# Sammie-Roto
**S**egmenter **A**nything **M**odel avec **M**atting **I**ntégré **E**légamment

![Capture d'écran de Sammie-Roto](https://raw.githubusercontent.com/Zarxrax/Sammie-Roto/main/sammie/sammie_screenshot.webp)

Sammie-Roto est conçu pour être un outil convivial d'assistance par IA pour le masquage de clips vidéo. Il sert d'alternative gratuite aux solutions commerciales telles que le Roto Brush d'Adobe ou le Magic Mask de DaVinci Resolve. Il est généralement moins précis que le rotoscoping manuel, mais peut généralement donner un très bon résultat avec peu d'effort.

## Découvrez le nouveau [Sammie-Roto 2](https://github.com/Zarxrax/Sammie-Roto-2) !

### Mises à jour
- [31/10/2025] [Sammie-Roto 2](https://github.com/Zarxrax/Sammie-Roto-2) est maintenant disponible ! Toutes les futures mises à jour seront sur cette version.
- [22/09/2025] Ajout de l'export PNG, import de séquences d'images, correction de bugs dans l'export de matting, et chargement de vidéos via CLI.
- [23/08/2025] Ajout d'options dans l'onglet export pour insérer diverses informations dans le nom de fichier.
- [16/08/2025] Ajout d'un curseur de correction de bord pour aider à corriger les masques autour du bord de l'image. Réduction de la VRAM utilisée durant le matting.
- [03/08/2025] Ajout de la déduplication pour réduire le bruit autour des contours sur le contenu animé.
- [10/05/2025] Ajout du support pour l'import/export d'images uniques. Les réglages d'export sont désormais mémorisés.
- [23/04/2025] Ajout d'un installateur pour Linux/Mac, réduction de la consommation de VRAM, plusieurs améliorations et corrections de bugs.
- [04/04/2025] Ajout de quelques curseurs de réglage à la page Matting.
- [26/02/2025] Ajout du support de matting vidéo humain via [MatAnyone](https://github.com/pq-yang/MatAnyone), ainsi que de nombreuses autres améliorations.
- [26/01/2025] Première version

### Fonctionnalités
- Supporte Windows, Linux et Mac
- Installateur simple télécharge automatiquement toutes les dépendances et modèles
- Peut fonctionner avec seulement 4 Go de VRAM ou même sur CPU (mais un GPU Nvidia de 6 Go est recommandé)
- Comprend 3 modèles de segmentation : Sam 2.1 Large, Sam 2.1 Base+, et EfficientTAM_s_512x512.
- Supporte le modèle MatAnyone pour le matting vidéo humain.
- Interface facile à utiliser.
- Support multi-objets.
- Plusieurs options de post-traitement des masques, incluant le lissage des bords.
- Supporte la déduplication pour réduire le bruit autour des bords sur le contenu animé.
- Plusieurs options d'export : masque noir et blanc, canal alpha et écran vert.

### Installation (Windows) :
- Téléchargez la dernière version Windows depuis les [releases](https://github.com/Zarxrax/Sammie-Roto/releases)
- Extrayez l'archive zip.
- Lancez 'install_dependencies.bat' et suivez les instructions.
- Lancez 'run_sammie.bat' pour démarrer le logiciel.

Tout est autonome dans le dossier Sammie-Roto. Si vous souhaitez supprimer l’application, il suffit de supprimer ce dossier. Vous pouvez également déplacer le dossier.

### Installation (Linux, Mac)
- Assurez-vous que [Python](https://www.python.org/) est installé (version 3.10 ou supérieure)
- Téléchargez la dernière version Linux/Mac depuis les [releases](https://github.com/Zarxrax/Sammie-Roto/releases)
- Extrayez l’archive zip.
- Ouvrez un terminal et naviguez jusqu’au dossier Sammie-Roto que vous venez d’extraire du zip.
- Exécutez la commande suivante : `bash install_dependencies.sh` puis suivez les instructions.
- Utilisateurs MacOS : double-cliquez sur "run_sammie.command" pour lancer le programme. Utilisateurs Linux : `bash run_sammie.command` ou exécutez le fichier comme vous préférez.

### Tutoriel
[![Tutoriel Sammie-Roto](https://img.youtube.com/vi/042uKTqlJ_c/0.jpg)](https://www.youtube.com/watch?v=042uKTqlJ_c)

### Remerciements
* [SAM 2](https://github.com/facebookresearch/sam2)
* [EfficientTAM](https://github.com/yformer/EfficientTAM)
* [MatAnyone](https://github.com/pq-yang/MatAnyone)
* [Wan2GP](https://github.com/deepbeepmeep/Wan2GP) (pour MatAnyone optimisé)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-28

---