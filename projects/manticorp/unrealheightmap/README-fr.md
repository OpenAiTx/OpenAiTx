# Générateur de cartes de hauteur PNG/EXR en niveaux de gris 16/32 bits

Un outil basé sur navigateur pour générer des cartes de hauteur PNG en niveaux de gris 16 bits ou des cartes de hauteur EXR 16/32 bits à partir de données de terrain réelles.

Parfait pour créer des paysages réalistes dans Unreal Engine 5 et d'autres moteurs de jeu ou logiciels 3D, tels que Terrain3d, Godot4 et Blender.

🌐 **Site en direct :** [https://manticorp.github.io/unrealheightmap/](https://manticorp.github.io/unrealheightmap/)

[![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/L4L212G6M7)

## ⚠️ Avis important

Nous avons commencé à atteindre les limites du niveau gratuit de certains services de cartographie, donc le site *peut ne pas fonctionner* jusqu'à ce que nous obtenions des financements pour augmenter ces limites. Si vous trouvez cet outil utile, merci de soutenir le projet !

## ✨ Fonctionnalités

- **Sortie haute qualité 16/32 bits** - Génère des cartes de hauteur avec 65 536/4 294 967 296 niveaux de détail (contre seulement 256 en 8 bits)
- **Données de terrain réelles** - Utilise des données d'élévation de haute qualité provenant du [service global d'élévation de Mapzen](https://www.mapzen.com/blog/elevation/)
- **Interface cartographique interactive** - Sélection visuelle des zones de terrain via une interface cartographique intuitive
- **Modes de normalisation multiples** - Choisissez entre Aucun, Régulier ou Intelligent pour optimiser vos données de carte de hauteur
- **Tailles de sortie flexibles** - Tailles prédéfinies pour Unreal Engine ou dimensions personnalisées jusqu’à 8129×8129 pixels
- **Basé sur navigateur** - Aucune installation requise, fonctionne entièrement dans votre navigateur web
- **Aperçu en temps réel** - Visualisez la zone que vous exportez avec une superposition sur la carte
- **Copier & Coller les coordonnées** - Prise en charge de plusieurs formats de coordonnées, y compris DMS et degrés décimaux

## 🎯 Cas d’utilisation

- Création de terrains réalistes pour les paysages Unreal Engine 5/Blender/Terrain3D
- Développement de jeux avec une topographie réelle précise
- Projets de modélisation 3D et de visualisation
- Applications de systèmes d'information géographique (SIG)
- Visualisation éducative et scientifique

## 🚀 Démarrage rapide

1. Rendez-vous sur [https://manticorp.github.io/unrealheightmap/](https://manticorp.github.io/unrealheightmap/)
2. Utilisez la carte pour naviguer vers l’emplacement souhaité ou saisissez les coordonnées manuellement
3. Ajustez le zoom et la taille de sortie pour définir votre zone d’exportation (affichée comme un rectangle orange)
4. Sélectionnez un mode de normalisation adapté à votre cas d’utilisation
5. Cliquez sur « Générer » pour créer et télécharger votre carte de hauteur
Pour des instructions détaillées, visitez la page [Documentation](https://manticorp.github.io/unrealheightmap/instructions.html).

## 📖 Documentation

- **[Instructions](https://manticorp.github.io/unrealheightmap/instructions.html)** - Guide complet sur l'utilisation de l'outil  
- **[Exemples](https://manticorp.github.io/unrealheightmap/examples.html)** - Galerie de cartes d'altitude créées avec l'outil  
- **[Infos sur la licence](https://manticorp.github.io/unrealheightmap/rights.html)** - Informations sur les sources de données et les licences  

## 🛠️ Pile technologique

- **TypeScript** - Code applicatif typé  
- **Leaflet** - Interface de carte interactive  
- **jQuery** - Manipulation du DOM et interactions UI  
- **UPNG.js** - Encodage/décodage PNG  
- **Pako** - Compression de données  
- **Webpack** - Regroupement de modules  
- **Bulma** - Framework CSS  
- **SASS** - Préprocesseur CSS  

## 💻 Configuration du développement

### Prérequis

- Node.js (v14 ou supérieur recommandé)  
- npm (fourni avec Node.js)  

### Installation


```bash
# Clone the repository
git clone https://github.com/manticorp/unrealheightmap.git
cd unrealheightmap

# Install dependencies
npm install
```

### Commandes de construction

```bash
# Development build
npm run build

# Production build
npm run author

# Watch mode (auto-rebuild on changes)
npm run watch

# Run unit tests
npm test
```

### Structure du projet

```
├── src/                   # Source TypeScript and SASS files
│   ├── app.ts             # Main application logic
│   ├── main.ts            # Entry point
│   ├── png.ts             # PNG processing
│   ├── processor.ts       # Web worker for image processing
│   ├── sass/              # Stylesheets
│   └── templates/         # HTML templates
├── public/                # Static assets and build output
│   ├── dist/              # Built JavaScript and CSS
│   ├── im/                # Images
│   └── examples/          # Example heightmaps
├── index.html             # Main application page
├── instructions.html      # Documentation page
├── examples.html          # Examples page
└── webpack.config.js      # Webpack configuration
```

## 🎨 Exemples

### Grand Canyon (64km)
[Voir dans l'outil](https://manticorp.github.io/unrealheightmap/#latitude/36.18111652966563/longitude/-112.021/zoom/10/outputzoom/14/width/8129/height/8129)

![Exemple Grand Canyon](https://raw.githubusercontent.com/manticorp/unrealheightmap/main/public/im/grand_canyon_desserty.png)

Pour plus d'exemples, visitez la [page des exemples](https://manticorp.github.io/unrealheightmap/examples.html).

## 🔧 Modes de Normalisation

### Aucun
Aucune normalisation effectuée. Les valeurs des pixels représentent directement la hauteur en mètres (les valeurs négatives sont mises à 0).

### Régulier
Met à l'échelle les valeurs de hauteur pour utiliser toute la plage 16 bits (0-65535), maximisant les détails sur toute la carte de hauteur.

### Intelligent
Un mode avancé qui gère les erreurs de données et les valeurs aberrantes. Utilise une fenêtre de 99,9 % pour filtrer les valeurs extrêmes tout en préservant les valeurs min/max authentiques dans 1 écart-type.

## 📊 Format de Sortie

- **Format :** PNG Niveaux de gris 16 bits, EXR 16 bits ou EXR 32 bits
- **Profondeur de bits :** 65 536 niveaux de détail (2^16) ou 4 294 967 296 (2^32)
- **Précision :** Capable de représenter le Mont Everest (8 849 m) avec des intervalles d'environ 13 cm (16 bits)
- **Données sources :** Données d'altitude Mapzen (précision 24 bits, fidélité ~4 mm)

## 🤝 Contribution

Les contributions sont les bienvenues ! N'hésitez pas à soumettre des problèmes, forker le dépôt et créer des pull requests.

## 📄 Licence

Ce projet est sous licence MIT - voir le fichier [LICENSE](LICENSE) pour plus de détails.

Les données d'altitude sont fournies par [Mapzen](https://www.mapzen.com/blog/elevation/) et peuvent avoir leurs propres conditions de licence.

## 💖 Support

Si vous trouvez cet outil utile, veuillez envisager de soutenir le projet :

- ☕ [Offrez-moi un café sur Ko-fi](https://ko-fi.com/harrymustoeplayfair)
- ⭐ Mettez une étoile à ce dépôt
- 🐦 Partagez-le avec d'autres qui pourraient le trouver utile

## 🙏 Remerciements

- [Mapzen](https://www.mapzen.com/) pour la fourniture de données d'élévation mondiale de haute qualité
- [Unreal Engine](https://www.unrealengine.com/) communauté pour l'inspiration et les cas d'utilisation
- Tous les contributeurs et utilisateurs de cet outil

## 📞 Contact

- **Auteur :** Harry Mustoe-Playfair
- **Email :** harry.mustoeplayfair@gmail.com
- **GitHub :** [manticorp](https://github.com/manticorp)

---

Fait avec ❤️ pour la communauté Unreal Engine, 3D et développement de jeux


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-10

---