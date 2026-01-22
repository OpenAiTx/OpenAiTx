# BeamerQt  
BeamerQT est une interface graphique conviviale conçue pour faciliter la création de présentations Beamer sans éditer manuellement le code LaTeX associé aux diapositives. Il offre un ensemble complet de fonctionnalités permettant aux utilisateurs de définir des mises en page, d’insérer du contenu (y compris du texte, des blocs et des images), et de configurer certains paramètres avancés du thème. BeamerQT permet aussi bien aux débutants qu’aux utilisateurs avancés de LaTeX de créer des présentations impressionnantes en se concentrant sur le contenu plutôt que sur le code.

### Bibliothèques requises :  
* PyQt6  

* PyMuPDF  

<img src="https://github.com/user-attachments/assets/b123f050-dff5-4584-b40d-c2fd581c2f16" width="600">  


# Fonctionnalités  
BeamerQT propose une interface graphique qui donne un accès facile à la plupart des fonctionnalités Beamer/LaTeX désirées sans avoir à ajouter du code LaTeX.  

## Éditeur de thème (Nouvelle fonctionnalité !)  
Modifier le code source des modèles.  

* Prise en charge de l’attachement de fichiers inclus.  
* Extraction des fichiers attachés lors de la génération LaTeX.  
* Partage facile du fichier .xml personnalisé.  
* Nouvelles fonctionnalités à venir prochainement.  

## Sélection de la mise en page  
BeamerQT propose une gamme de schémas de mise en page prédéfinis inspirés des outils de présentation courants tels que PowerPoint ou LibreOffice Impress. Au lieu d’écrire manuellement le code LaTeX pour les colonnes et les blocs, l’utilisateur peut simplement sélectionner une mise en page et BeamerQT insérera et gérera automatiquement les colonnes et blocs Beamer requis.  

Les principales capacités incluent :  

* Création automatique des colonnes et des blocs selon la mise en page choisie.  
* Un contrôle par curseur pour ajuster dynamiquement la largeur des colonnes, sans modification manuelle du code.  
* Reconfiguration fluide de la mise en page des diapositives avec une intervention utilisateur minimale.  

<img src="https://github.com/user-attachments/assets/1c313ed2-337c-4925-aaef-b18aa718bd0e" width="600">  

<img src="https://github.com/user-attachments/assets/305af2c5-7726-43bd-b457-fe68d8ff3fd9" width="600">  


## Diapositives  

Chaque diapositive peut contenir un titre, un sous-titre, et un ensemble de blocs pour le contenu. De plus, les diapositives peuvent être configurées comme une nouvelle section ou sous-section, permettant l’insertion automatique des titres de section ou sous-section correspondants dans la présentation.

Caractéristiques principales : 

* Saisie facile du titre et du sous-titre de la diapositive. 
* Marquage d’une diapositive comme section ou sous-section pour structurer la présentation. 
* Ajustement automatique des options de formatage au niveau de la diapositive.

## Liste des diapositives

La Liste des diapositives offre une vue d’ensemble de toute la présentation, affichant la position, le numéro et le titre de chaque diapositive. Les sections et sous-sections sont clairement indiquées, facilitant la navigation et l’organisation. Les utilisateurs peuvent réorganiser, dupliquer, copier ou supprimer des diapositives selon leurs besoins, garantissant une gestion efficace des diapositives.

## Blocs

Les blocs sont les unités fondamentales de contenu dans BeamerQT. L’outil prend en charge différents types de blocs — tels que Bloc, Alerte, Exemple, ou blocs de texte simple — via une interface à boutons radio simple. Cette approche élimine la nécessité d’écrire manuellement des commandes LaTeX.

Les fonctionnalités principales des blocs incluent : 

* Sélection du type de bloc (Bloc, Alerte, Exemple, ou texte simple). 
* Contrôles de position pour réarranger les blocs dans la mise en page. 
* Un bouton dédié pour supprimer le bloc de la diapositive. 
* Un champ de titre et une zone de saisie de texte pour chaque bloc, avec support multilignes. 
* Retours à la ligne automatiques ou conservation des retours manuels selon la saisie de l’utilisateur.
* Plusieurs sous-blocs
<img src="https://github.com/user-attachments/assets/5b914c96-e691-4fdf-af42-faba89b2c8f4" width="600">


## Sous-blocs

Les sous-blocs permettent une organisation plus granulaire du contenu à l’intérieur d’un bloc. Chaque bloc contient au moins un sous-bloc (généralement basé sur du texte), et les utilisateurs peuvent ajouter plusieurs sous-blocs selon leurs besoins.

Fonctionnalités des sous-blocs : 

* Disposition en jusqu’à quatre colonnes, avec boutons de navigation horizontale pour réorganiser les sous-blocs. 
* Un curseur pour ajuster la largeur des colonnes, offrant une personnalisation flexible de la mise en page. 
* Contrôles d’alignement pour chaque sous-bloc (gauche, centre, droite, ou par défaut).

## Sous-bloc image

Le sous-bloc image est un type spécialisé de sous-bloc pour insérer des images. BeamerQT prend en charge les fichiers bitmap (ex. .jpg, .png), images vectorielles (.svg) et fichiers .pdf. Pour les images .svg, BeamerQT utilise Inkscape pour les convertir en format .pdf, assurant une intégration fluide dans la présentation finale (testé uniquement sur systèmes Linux).

Fonctionnalités du sous-bloc image : 
* Taille d'image ajustable en pourcentage de la largeur du sous-bloc.  
* Adaptation automatique aux changements de mise en page pour des visuels toujours bien proportionnés.  
* Compatibilité avec plusieurs formats d'image, garantissant une flexibilité dans la conception de la présentation.  

## Front-matter  

La section front-matter permet une configuration facile des paramètres globaux de la présentation. Les utilisateurs peuvent définir le titre de la présentation, les noms des auteurs, et personnaliser le préambule LaTeX. De plus, des fonctionnalités avancées peuvent être activées pour affiner davantage l'apparence et la structure globale de la présentation, telles que :  

* Modification du format d'image (4:3 à 16:9).  
* Création de cadres de titre pour chaque section.  
* Génération automatique d'un cadre de plan pour chaque section.  
<img src="https://github.com/user-attachments/assets/07629d96-ba38-4e5b-87ff-c1648598ad9f" width="600">  

<img src="https://github.com/user-attachments/assets/bb47ffe5-7d92-408e-a42d-1cd734f53d51" width="600">  

<img src="https://github.com/user-attachments/assets/9149eb46-020a-4f02-b3fe-9959fb231fd3" width="600">  

## Génération LaTeX  

Lorsque l'utilisateur est satisfait du contenu et de la mise en page, cliquer sur le bouton **Generate LaTeX** exporte la présentation au format LaTeX et lance pdflatex pour compiler un PDF. Le PDF résultant est alors affiché, permettant une révision immédiate.  

Le bouton **LaTeX folder** ouvre le répertoire de sortie, permettant une personnalisation supplémentaire ou une intégration avec d'autres outils. Notez que chaque génération LaTeX écrase les fichiers dans le dossier de sortie.  

## Format de fichier  

BeamerQT utilise un format de fichier .bqt, qui est essentiellement un répertoire compressé contenant toutes les métadonnées nécessaires, telles que :  

* Un fichier XML avec les détails de la présentation.  
* Des images d'aperçu des diapositives.  
* (Fonction future) Images intégrées et thèmes personnalisés pour garantir la portabilité.  

Cette approche garantit que les fichiers .bqt peuvent être facilement partagés, sauvegardés et édités sur différents systèmes sans perte de données essentielles.  

## Installation







* Windows

  Installer MikTex :
  
  https://miktex.org/download

  Installer BeamerQT :
  
  https://sourceforge.net/projects/beamerqt/

* Linux
  Installer python3, TexLive et Inkscape, selon votre distribution :
  

  Basé sur Debian :
  ```
  apt-get install python3 texlive-beamer inkscape 
  ```
  Installer PyQt6 et PyMuPDF :
  ```
  pip install pyqt6 pymupdf
  ```
  
  Exécuter BeamerQT :

  Téléchargez le code source de BeamerQT depuis ce dépôt.
  
  Ouvrez un terminal dans le répertoire contenant le fichier main.py

  ```
  python3 main.py
  ```


## Vidéo exemple :

https://www.youtube.com/watch?v=XQKJbuT8q1g

## Captures d’écran :
### Interface BeamerQT
<img src="https://github.com/user-attachments/assets/cf332d4e-9962-4251-9619-67e146af9851" width="600">

### Sortie PDF
<img src="https://github.com/user-attachments/assets/be7b2e0c-20a4-41f0-b09d-93131973c4d4" width="600">


## Faire un don
Veuillez faire un don pour m’aider à développer ce logiciel. Lien de don Paypal :

https://www.paypal.com/donate/?business=2PP5H8Z8L5E8E&no_recurring=0&item_name=Support+the+development+of+BeamerQT&currency_code=USD


## Livre de science-fiction
Si cela vous a plu, vous aimerez peut-être aussi mon livre de science-fiction, Synapses : Le chaos de l’ordre.

http://synapsesbook.wordpress.com/

Jorge Guerrero


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-22

---