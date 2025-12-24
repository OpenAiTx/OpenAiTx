# 👋 Aperçu
![Colonnes Simples](https://drive.google.com/uc?export=view&id=1Q4Vrx3FpE14U_6RtGkmfQg9UnsNJKx-j)

- [👋 Aperçu](#-aperçu)
  - [📝 Description](#-description)
  - [⚙️ Comment Utiliser](#️-comment-utiliser)
    - [Exemple : Création de Colonnes avec des Blocs de Code](#exemple-création-de-colonnes-avec-des-blocs-de-code)
    - [Exemple : Spécification des Largeurs de Colonnes via YAML](#exemple-spécification-des-largeurs-de-colonnes-via-yaml)
  - [✨ Fonctionnalités](#-fonctionnalités)
  - [🔧 Paramètres Globaux](#-paramètres-globaux)
    - [Bordures du Conteneur](#bordures-du-conteneur)
    - [Paramètres du Redimensionneur](#paramètres-du-redimensionneur)
    - [Paramètres Avancés](#paramètres-avancés)
  - [⚡️ Paramètres Locaux](#️-paramètres-locaux)
    - [Paramètres Locaux Disponibles :](#paramètres-locaux-disponibles-)
  - [🚀 Travaux Futurs](#-travaux-futurs)


## 📝 Description
Le plugin **Colonnes Simples** pour Obsidian vous permet de créer des colonnes facilement redimensionnables et personnalisables dans vos notes. Que vous organisiez des tâches, décomposiez du contenu ou visualisiez des idées, ce plugin offre une syntaxe markdown simple pour ajuster et structurer rapidement vos mises en page.

## ⚙️ Comment Utiliser 
Pour créer une mise en page simple en colonnes, vous pouvez soit :
- Faire un clic droit dans votre note et sélectionner l’option dans le sous-menu.

![Sous-menu](https://drive.google.com/uc?export=view&id=1Nu2tmvENJFtsnbDIqnk4XqT05WSJexN_)

- Utiliser la palette de commandes pour insérer directement des colonnes. Par exemple, tapez « Ajouter 2 colonnes » pour insérer une mise en page à deux colonnes dans votre note.

Lorsque vous créez des colonnes, le plugin génère le markdown suivant avec un ID unique pour chaque colonne :

```columns
id: b52707b0-ce15-6458-825d-32615b4b7h85
===
Column 1

===
Column 2
```
### Exemple : Création de colonnes avec des blocs de code  
Pour créer une mise en page avec des blocs de code à l'intérieur des colonnes, utilisez la syntaxe suivante (commencez et terminez par 4 accents graves : ````) :


`````
````colonnes
id: b52707b0-ce15-6458-825d-32615b4b7h85
===
Colonne 1
```javascript
console.log("Hello world")
```
===
Colonne 2
````
`````

### Exemple : Spécification des largeurs de colonnes via YAML

Vous pouvez définir des largeurs personnalisées pour des colonnes spécifiques en utilisant YAML. Les colonnes avec un ratio spécifié auront la priorité, et toutes les colonnes sans ratio défini partageront également l’espace restant.

```
id: b52707b0-ce15-6458-825d-32615b4b7h85
column-1-ratio: 60%
===
Column 1
hello
===
Column 2
```

Explication :
- column-1-ratio : 60 % → La colonne 1 prend 60 % de la largeur du conteneur.
- La colonne 2 (non spécifiée) remplit automatiquement les 40 % restants.
- Vous pouvez définir des ratios pour plusieurs colonnes (column-2-ratio, column-3-ratio, etc.), jusqu’à 4 colonnes.

## ✨ Fonctionnalités
- **Identifiants uniques de colonnes** : Chaque colonne est générée avec un identifiant unique, garantissant que vous pouvez styliser ou référencer les colonnes de manière indépendante.
- **Colonnes facilement redimensionnables** : Les colonnes sont entièrement redimensionnables, vous offrant un contrôle total sur la mise en page de votre contenu.
- **Mises en page réactives** : Les colonnes s’ajustent automatiquement en fonction de la taille de votre écran, offrant une mise en page propre et adaptable.
- **Fortement personnalisables** : Les colonnes sont entièrement ajustables, vous permettant de contrôler facilement leur taille, leur espacement et leur alignement selon vos besoins.

## 🔧 Paramètres globaux

Les **paramètres globaux** vous permettent de définir des styles et comportements par défaut pour toutes les colonnes dans votre coffre Obsidian. Ces paramètres peuvent être consultés et configurés dans les réglages du plugin.

![Paramètres globaux](https://drive.google.com/uc?export=view&id=1WPBg0Y3pffL5pw1dVRUC81TMMlaod-eK)

### Bordures du conteneur
Vous pouvez personnaliser l’apparence des conteneurs de colonnes avec des bordures pour une meilleure visibilité.

- **Afficher les bordures du conteneur** : Activez ce paramètre pour afficher les bordures autour de chaque conteneur de colonne.
- **Largeur de la bordure** : Définissez la largeur des bordures des conteneurs de colonnes.
- **Couleur de la bordure** : Choisissez la couleur des bordures.
- **Transparence de la bordure** : Ajustez la transparence des bordures en utilisant des codes de couleur RGBA. La valeur alpha (dernier chiffre) contrôle la transparence.

### Paramètres du redimensionneur
Vous pouvez également personnaliser l’apparence et le comportement du redimensionneur de colonnes.

- **Afficher le redimensionneur** : Activez ce paramètre pour afficher ou masquer le redimensionneur entre les colonnes. Le redimensionneur n’apparaîtra que lorsque vous survolerez la division des colonnes.
- **Largeur du redimensionneur** : Définissez la largeur de l’élément redimensionneur.
- **Couleur du redimensionneur** : Choisissez la couleur du redimensionneur.
- **Transparence du redimensionneur** : Ajustez la transparence du redimensionneur en utilisant des codes de couleur RGBA.

### Paramètres avancés
- **Réinitialiser les styles** : Cela rétablira tous les styles de colonnes, y compris les réglages des bordures et du redimensionneur, à leurs valeurs par défaut.
- **Effacer le stockage local** : Cela supprimera tous les réglages personnalisés et restaurera le plugin à son état initial. Utilisez cette option si vous rencontrez des problèmes ou souhaitez repartir à zéro.


## ⚡️ Paramètres locaux
Les **Paramètres Locaux** vous permettent d'appliquer des **personnalisations plus précises** aux colonnes individuelles de vos notes.

![Paramètres Locaux](https://drive.google.com/uc?export=view&id=1q11NA49CeizEAozavC1YAiiSI7J7oe5U)

### Paramètres Locaux Disponibles :
- **Réinitialiser Tous les Styles** : Ramener tous les styles personnalisés de la colonne à leurs paramètres par défaut.
- **Afficher la Bordure**
- **Définir la Couleur et la Transparence de la Bordure**
- **Afficher le Redimensionneur** : Activer ou désactiver l'affichage du redimensionneur de colonne. Le redimensionneur n'apparaît qu'au survol.
- **Définir la Couleur et la Transparence du Redimensionneur**
- **Définir la Couleur du Texte**
- **Définir la Couleur et la Transparence de l'Arrière-plan**
- **Définir l'Alignement du Texte** : Aligner le texte dans la colonne (par exemple, `gauche`, `centre`, `droite`).

## 📦 Installation
Ce plugin est désormais disponible dans les Plugins Communautaires d'Obsidian ! 🎉

1. Dans Obsidian, allez dans Réglages > Plugins Communautaires.
2. Cliquez sur Parcourir et cherchez Simple Columns.
3. Cliquez sur Installer, puis Activez le plugin.

## 🚀 Travaux Futurs
1. Ajouter une image d'arrière-plan aux colonnes individuelles
2. Permettre les colonnes imbriquées


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-24

---