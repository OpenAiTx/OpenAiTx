[English](https://raw.githubusercontent.com/appledragon/everythingByMdfind/master/README.md) | [中文](https://raw.githubusercontent.com/appledragon/everythingByMdfind/master/README_CN.md) | [한국어](https://raw.githubusercontent.com/appledragon/everythingByMdfind/master/README_KO.md) | [日本語](https://raw.githubusercontent.com/appledragon/everythingByMdfind/master/README_JP.md) | [Français](https://raw.githubusercontent.com/appledragon/everythingByMdfind/master/README_FR.md) | [Deutsch](https://raw.githubusercontent.com/appledragon/everythingByMdfind/master/README_DE.md) | [Español](https://raw.githubusercontent.com/appledragon/everythingByMdfind/master/README_ES.md)

<img width="3836" height="2026" alt="image" src="https://github.com/user-attachments/assets/d86c3d6b-6fd4-4cfe-b64f-67c465bb3d3c" /><img width="3832" height="2024" alt="image" src="https://github.com/user-attachments/assets/a91d2b13-07ac-4cae-ab33-506f1fa3bca6" />


# Everything par mdfind

Un outil de recherche de fichiers puissant et efficace pour macOS, exploitant le moteur natif Spotlight pour des résultats ultra-rapides.

## Fonctionnalités clés

*   **Recherche ultra-rapide :** Utilise l’index Spotlight de macOS pour une recherche de fichiers quasi instantanée.
*   **Options de recherche flexibles :** Recherche par nom de fichier ou contenu pour localiser rapidement les fichiers dont vous avez besoin.
*   **Filtrage avancé :** Affinez vos recherches avec une variété de filtres :
    *   Plage de taille de fichier (taille minimale et maximale en octets)
    *   Extensions de fichiers spécifiques (ex. `pdf`, `docx`)
    *   Correspondance sensible à la casse
    *   Options de correspondance totale ou partielle
*   **Recherche dans un répertoire spécifique :** Limitez votre recherche à un répertoire spécifique pour des résultats ciblés.
*   **Aperçu enrichi :** Prévisualisez différents types de fichiers directement dans l’application :
    *   Fichiers texte avec détection d’encodage
    *   Images (JPEG, PNG, GIF avec support d’animation, BMP, WEBP, HEIC)
    *   Fichiers SVG avec mise à l’échelle et centrage appropriés
    *   Fichiers vidéo avec contrôles de lecture
    *   Fichiers audio
*   **Lecteur multimédia intégré :**
    *   Lecture vidéo et audio avec contrôles standards
    *   Fenêtre de lecteur autonome pour les fichiers multimédias
    *   Mode lecture continue
    *   Contrôle du volume et option de mise en sourdine
*   **Signets :** Accès rapide aux recherches courantes :
    *   Gros fichiers (>50 Mo)
    *   Fichiers vidéo
    *   Fichiers audio
    *   Images
    *   Archives
    *   Applications
*   **Analyse de l’espace disque :** Analysez l’utilisation de l’espace disque pour n’importe quel répertoire :
    *   Analyse en un clic de l’espace du répertoire personnel
    *   Visualisation interactive sous forme de graphique à barres montrant les dossiers consommant le plus d’espace
    *   Cliquez avec le bouton droit sur n'importe quel dossier dans les résultats de recherche pour analyser son utilisation de l'espace
    *   Double-cliquez sur les barres du graphique pour explorer les sous-répertoires pour une analyse détaillée
    *   Répartition visuelle des tailles des sous-répertoires avec des graphiques codés par couleur
    *   Tri automatique par taille pour identifier les plus grands dossiers
*   **Résultats triables :** Organisez les résultats de recherche par nom, taille, date de modification ou chemin.
*   **Opérations multi-fichiers :** Effectuez des actions sur plusieurs fichiers simultanément :
    *   Sélection multiple de fichiers avec les touches Shift ou Commande (⌘)
    *   Opérations par lots : Ouvrir, Supprimer, Copier, Déplacer, Renommer
    *   Menu contextuel pour des opérations supplémentaires
*   **Interface de recherche multi-onglets :** Travaillez avec plusieurs sessions de recherche simultanément :
    *   Créez de nouveaux onglets pour différentes requêtes de recherche
    *   Fermez, réorganisez et gérez les onglets avec le menu contextuel au clic droit
    *   Résultats de recherche et paramètres indépendants par onglet
    *   Expérience d'onglets similaire à Chrome avec boutons de défilement pour de nombreux onglets
*   **Interface personnalisable :**
    *   6 thèmes magnifiques au choix :
        *   Clair & Sombre (par défaut système)
        *   Tokyo Night & Tokyo Night Storm
        *   Chinolor Dark & Chinolor Light (couleurs traditionnelles chinoises)
    *   Thématisation de la barre de titre système correspondant à votre thème sélectionné
    *   Afficher/masquer le panneau d'aperçu
    *   Historique de recherche configurable
*   **Export multi-format :** Exportez les résultats de recherche vers plusieurs formats :
    *   JSON - Format de données structuré
    *   Excel (.xlsx) - Tableur avec mise en forme
    *   HTML - Format de tableau prêt pour le web
    *   Markdown - Format adapté à la documentation
    *   CSV - Valeurs séparées par des virgules classiques
*   **Chargement paresseux :** Gère efficacement les grands ensembles de résultats en chargeant les éléments par lots au fur et à mesure du défilement.
*   **Glisser-déposer :** Glissez les fichiers directement vers des applications externes.
*   **Opérations sur les chemins :** Copiez le chemin du fichier, le chemin du répertoire ou le nom de fichier dans le presse-papiers.

## Installation

1.  **Prérequis :**
    *   Python 3.6+
    *   PyQt6

2.  **Clonez le dépôt :**

    ```bash
    git clone https://github.com/appledragon/everythingByMdfind
    cd everythingByMdfind
    ```
3.  **Installer les dépendances :**


    ```bash
    pip install -r requirements.txt
    ```

4.  **Exécutez l'application :**

    ```bash
    python everything.py
    ```
## Télécharger l'application pré-construite

Vous pouvez télécharger l'application macOS prête à l'emploi (.dmg) directement depuis la page [GitHub Releases](https://github.com/appledragon/everythingByMdfind/releases).

## Contribution

Les contributions sont les bienvenues ! N'hésitez pas à soumettre des pull requests ou à ouvrir des issues pour des corrections de bugs, des demandes de fonctionnalités ou des améliorations générales.

## Licence

Ce projet est sous licence Apache License 2.0 - voir le fichier [LICENSE.md](https://raw.githubusercontent.com/appledragon/everythingByMdfind/master/LICENSE.md) pour plus de détails.

## Auteur

Apple Dragon

## Version

1.4.2

## Remerciements

*   Merci à l'équipe PyQt6 pour avoir fourni un framework GUI puissant et polyvalent.
*   Inspiration tirée d'autres excellents outils de recherche de fichiers.





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-03

---