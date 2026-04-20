# 🗺️ Pathfinder

<div align="center">
  <img src="https://raw.githubusercontent.com/shadowoff09/pathfinder/master/public/banner-readme.png" alt="Pathfinder Banner" width="1280"/>
  
  Une application de cartographie moderne et interactive construite avec Next.js 15, MapboxGL et TypeScript. Pathfinder offre une expérience cartographique fluide avec des fonctionnalités telles que les données météo en temps réel, la recherche de localisation et des styles de carte personnalisables.

  [Démo](https://link.shadowdev.xyz/r/m3tydbf12hb) · [Signaler un bug](https://github.com/shadowoff09/pathfinder/issues) · [Demander une fonctionnalité](https://github.com/shadowoff09/pathfinder/issues)
</div>

## ✨ Fonctionnalités

- 🌓 Support mode sombre/clair
- 🏢 Visualisation de bâtiments 3D
- 🔍 Recherche de localisation avec autocomplétion
- 🌤️ Informations météorologiques en temps réel
- 📍 Détection de la localisation actuelle
- 🛰️ Bascule vue rue/satellite
- 📱 Design entièrement responsive
- ⌨️ Support des raccourcis clavier
- 🎨 Interface moderne avec Tailwind CSS et shadcn/ui

## 🚀 Pour commencer

### Prérequis

- Node.js 22+ 
- Une clé API Mapbox (à obtenir sur [Mapbox](https://www.mapbox.com/))
- Une clé API OpenWeather (à obtenir sur [OpenWeather](https://openweathermap.org/api))
- npm ou yarn

### Installation

1. Cloner le dépôt :
```bash
git clone https://github.com/shadowoff09/pathfinder.git
cd pathfinder
```

2. Installer les dépendances :
```bash
npm install
# or
yarn install
```

3. Configurez les variables d'environnement :
   - Copiez le fichier `.env.example` vers `.env.local` :
     ```bash
     cp .env.example .env.local
     ```
   - Ouvrez `.env.local` et ajoutez votre clé API Mapbox :
     ```env
     NEXT_PUBLIC_MAPBOX_ACCESS_TOKEN=your_mapbox_token_here
     NEXT_PUBLIC_WEATHER_API_KEY=your_weather_api_key_here
     ```
   - Obtenez vos clés API depuis :
     - [Mapbox](https://www.mapbox.com/) - pour la fonctionnalité de carte
     - [OpenWeather](https://openweathermap.org/api) - pour les données météorologiques

4. Démarrez le serveur de développement :
```bash
npm run dev
# or
yarn dev
```

5. Ouvrez [http://localhost:3000](http://localhost:3000) dans votre navigateur.

## 🎮 Utilisation

### Navigation sur la carte
- Panoramique : Cliquez et faites glisser
- Zoom : Faites défiler ou utilisez les contrôles de zoom
- Rotation : Clic droit et faites glisser
- Réinitialiser la vue : Appuyez sur Ctrl+Q

### Fonctionnalités
- Recherchez des emplacements avec la barre de recherche
- Basculez entre la vue rue et satellite
- Affichez les bâtiments 3D en mode vue rue (niveau de zoom 15+)
- Consultez les informations météo (niveau de zoom 14+)
- Obtenez la position actuelle en un clic
- Copiez les coordonnées dans le presse-papiers

## 🛠️ Construit avec

- [Next.js 15](https://nextjs.org/) - Framework React
- [TypeScript](https://www.typescriptlang.org/) - Sécurité des types
- [Mapbox GL JS](https://www.mapbox.com/mapbox-gl-js) - API de cartes
- [Tailwind CSS](https://tailwindcss.com/) - Stylisation
- [shadcn/ui](https://ui.shadcn.com/) - Composants UI
- [React Map GL](https://visgl.github.io/react-map-gl/) - Wrapper React pour Mapbox GL

## 🤝 Contribution

Les contributions sont les bienvenues ! N’hésitez pas à soumettre une Pull Request. Pour les changements majeurs, veuillez d’abord ouvrir une issue pour discuter des modifications souhaitées.

1. Forkez le projet
2. Créez votre branche de fonctionnalité (`git checkout -b feature/AmazingFeature`)
3. Commitez vos changements (`git commit -m 'Add some AmazingFeature'`)
4. Poussez sur la branche (`git push origin feature/AmazingFeature`)
5. Ouvrez une Pull Request

## 📝 Licence

Ce projet est sous licence MIT - voir le fichier [LICENSE](LICENSE) pour plus de détails.

## 🙏 Remerciements

- [Mapbox](https://www.mapbox.com/) pour leur excellente plateforme cartographique
- [shadcn/ui](https://ui.shadcn.com/) pour les magnifiques composants UI
- [Vercel](https://vercel.com) pour l'hébergement et le déploiement

## 📫 Contact

X - [@shadowdev09](https://twitter.com/shadowdev09)

Portfolio - [https://shadowdev.xyz](https://shadowdev.xyz)

## 💖 Soutenez le projet

Si vous aimez utiliser Pathfinder et souhaitez soutenir son développement, envisagez de faire un don :

- [Faire un don via PayPal](https://paypal.me/diogogaspar123)
- [Faire un don via Ko-Fi](ko-fi.com/shadowoff09)
- [GitHub Sponsors](https://github.com/sponsors/shadowoff09)


Vos contributions aident à maintenir le projet en vie et à améliorer ses fonctionnalités ! Merci pour votre soutien !

---
<a href="https://www.producthunt.com/posts/pathfinder-11?embed=true&utm_source=badge-featured&utm_medium=badge&utm_souce=badge-pathfinder&#0045;11" target="_blank"><img src="https://api.producthunt.com/widgets/embed-image/v1/featured.svg?post_id=915601&theme=dark&t=1740532963013" alt="Pathfinder - Naviguez&#0032;dans&#0032;Votre&#0032;Monde&#0044;&#0032;Magnifiquement | Product Hunt" style="width: 250px; height: 54px;" width="250" height="54" /></a>

⭐️ Si vous aimez ce projet, merci de lui donner une étoile !

[![Stargazers over time](https://starchart.cc/shadowoff09/pathfinder.svg?variant=adaptive)](https://starchart.cc/shadowoff09/pathfinder)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-20

---