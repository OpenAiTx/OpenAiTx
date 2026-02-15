> [!ASTUCE]
> Vous cherchez une solution de navigation intérieure plus avancée ?
> Essayez [OpenIndoorMaps](https://github.com/openindoormap/openindoormaps) - avec édition de cartes, vues 3D et intégration de cartes extérieures.

# Pathpal : Guide d’intérieur basé sur le web

Pathpal est une application web innovante conçue pour révolutionner la navigation intérieure. Grâce à des cartes interactives et des algorithmes de recherche de chemin efficaces, elle offre une solution intuitive pour se repérer dans des espaces intérieurs complexes.
<br>
**Démo :** [Visitez Pathpal](https://indoor-wayfinder.vercel.app)

## Table des matières :

- [Pathpal : Guide d’intérieur basé sur le web](#pathpal-web-based-indoor-wayfinder)
  - [Table des matières :](#table-of-content)
  - [À propos de l’application](#about-the-app)
  - [Captures d’écran](#screenshots)
  - [Fonctionnalités](#features)
  - [Technologies](#technologies)
  - [Installation](#setup)
  - [Informations techniques](#technical-insights)
    - [Technologie de la carte](#map-technology)
    - [Recherche de chemin](#pathfinding)
    - [Technologie principale de la carte](#core-map-technology)
    - [Tracé de chemin et guidage](#path-drawing-and-wayfinding)
    - [Personnalisation de la carte](#customizing-the-map)
  - [Crédits](#credits)
  - [Licence](#license)

## À propos de l’application

Ce projet est une variation de mon projet de diplôme, axé sur une carte interactive pour le guidage et la navigation intérieure. Il propose une carte SVG interactive et utilise l’algorithme de Dijkstra pour calculer le chemin le plus court vers les points d’intérêt (POI). À l’origine, l’application expérimentait la localisation intérieure via la technologie BLE, mais en raison du caractère expérimental de l’API Web Bluetooth, cette fonctionnalité a été omise dans cette version.

> [!ATTENTION]  
> Le backend de ce projet a été supprimé. Toutes les données sont stockées dans un fichier JSON. Ce projet est un prototype et ne doit pas être utilisé en production. Veuillez consulter mon nouveau projet [OpenIndoorMaps](https://github.com/yourusername/OpenIndoorMaps) pour une solution plus complète.

## Captures d’écran

<table style="border-radius: 10px;  border: 1px solid gray;">
  <tr >
    <td align="center"><img src="https://raw.githubusercontent.com/KnotzerIO/indoor-wayfinder/main/media/indoor-map-details.png"/></td>
   <td align="center"><h3 >Affichage des informations sur l'objet au clic</h3></td>
  </tr>
    <tr>
    <td align="center"><img src="https://raw.githubusercontent.com/KnotzerIO/indoor-wayfinder/main/media/indoor-wayfinding.png"/></td>
    <td align="center"><h3>Démonstration du calcul du chemin le plus court</h3></td>
  </tr>
</table>

## Fonctionnalités

- **Cartes SVG interactives** : Naviguez facilement dans des espaces intérieurs complexes.
- **Recherche de chemin Dijkstra** : Calcule le chemin le plus court vers votre destination.
- **Design réactif** : Optimisé pour tout appareil et toute taille d’écran.
- **POI personnalisables** : Modifiez les noms et catégories des points d’intérêt.
- **Pincer pour zoomer** : Zoomez et dézoomez aisément sur les cartes avec des gestes tactiles.

## Technologies

Pathpal est construit avec les dernières technologies web pour la rapidité, l’efficacité et l’adaptabilité :

- React
- Vite
- TypeScript
- TailwindCSS
- SVG
- Algorithme de Dijkstra

## Installation

Suivez ces étapes pour lancer le projet :

1. **Cloner le dépôt** : Utilisez votre client Git préféré pour cloner ce dépôt sur votre machine locale.

2. **Installer Node.js** : Ce projet nécessite Node.js. Si vous n’avez pas la version 21 de Node.js installée, vous pouvez la télécharger et l’installer depuis [nodejs.org](https://nodejs.org/).

3. **Installer les dépendances** : Naviguez dans le répertoire du projet via votre terminal et exécutez la commande suivante pour installer les dépendances nécessaires :

   ```bash
   npm install
   ```

4. **Démarrer l'Application** : Une fois les dépendances installées, vous pouvez démarrer l'application en exécutant la commande suivante dans votre terminal :

   ```bash
   npm run dev
   ```

Après avoir exécuté ces commandes, votre navigateur web par défaut devrait s’ouvrir automatiquement et se connecter à `localhost:5173`, où vous pourrez voir l’application en cours d’exécution.

## Informations techniques

### Technologie de la carte

- **Format SVG** : La carte est principalement en SVG pour sa flexibilité et ses capacités interactives, idéal pour une navigation détaillée.
- **Support des formats d’image** : Prend en charge divers formats comme PNG et JPEG pour les fonds de carte, avec des fonctionnalités interactives mieux adaptées au SVG.

### Recherche de chemin

- **Définition des itinéraires** : Les chemins sur la carte représentent des itinéraires navigables, essentiels pour que l’algorithme de Dijkstra calcule des trajets efficaces.
- **Algorithme de Dijkstra** : Assure une navigation précise et rapide entre les points d’intérêt (POI).

### Technologie centrale de la carte

- **SVG comme format par défaut** : L’application utilise principalement un fichier SVG (Scalable Vector Graphics) pour la carte en raison de sa mise à l’échelle et de sa facilité de manipulation. Les SVG permettent un rendu interactif et dynamique des espaces intérieurs, ce qui les rend idéaux pour des parcours de navigation détaillés.
- **Support de différents formats d’image** : Bien que le SVG soit le format par défaut, le système est conçu pour accepter n’importe quel format d’image (par exemple PNG, JPEG) comme fond de carte. Cette flexibilité permet aux développeurs d’utiliser des plans d’étage ou des cartes existants sans avoir à les convertir en SVG. Cependant, les principales fonctionnalités interactives et de navigation sont optimisées pour le SVG.

### Tracé de chemin et guidage

- **Tracé de chemin** : Pour que la navigation fonctionne, les chemins doivent être définis dans la carte. Ces chemins représentent des itinéraires praticables et sont cruciaux pour l’algorithme de guidage. Dans les fichiers SVG, les chemins peuvent être tracés et édités directement, permettant un contrôle précis des itinéraires de navigation.
- **Algorithme de guidage** : L’application utilise l’algorithme de Dijkstra pour calculer le chemin le plus court entre les points d’intérêt (POI) sur la carte. Cet algorithme opère sur le réseau de chemins tracés sur la carte, garantissant une navigation efficace et précise.

### Personnalisation de la carte

- **Outils d’édition** : Les développeurs ont la possibilité d’utiliser des outils d’édition de graphiques vectoriels tels qu’Adobe Illustrator ou Boxy SVG pour modifier la carte SVG. Cette modification peut inclure la mise à jour des plans, l’ajout ou la suppression de points d’intérêt (POI) et l’ajustement des chemins. Reportez-vous à la capture d’écran ci-dessous pour voir un exemple d’édition de carte avec Boxy SVG. Pour convertir un SVG en JSX, [Transform Tools](https://transform.tools/) peut être une ressource utile.

![Exemple d’édition IndoorMap](https://raw.githubusercontent.com/KnotzerIO/indoor-wayfinder/main/media/map-editing-preview.png)

## Crédits

Ce projet a été inspiré par mon travail de diplôme et a été fortement influencé par le soutien des mentors, pairs et ressources telles que [l’application de recherche de chemin de maciejb2k](https://github.com/maciejb2k/pathfinding_app).

## Licence

Pathpal est un projet open-source sous licence MIT. Contributions et retours sont les bienvenus !


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-15

---