# Arpégiateur à Gestes de la Main

Arpégiateur contrôlé par les mains, boîte à rythmes et visualiseur audio-réactif. Levez les mains pour faire monter l’ambiance !

Une application web interactive construite avec threejs, la vision par ordinateur mediapipe, rosebud AI et tone.js.

- La main #1 contrôle les arpèges (levez la main pour augmenter la hauteur, pincez pour changer le volume)
- La main #2 contrôle la batterie (levez différents doigts pour changer le motif)

[Vidéo](https://youtu.be/JepIs-DTBgk?si=4Y-FrQDF6KNy662C) | [Démo en direct](https://collidingscopes.github.io/arpeggiator/) | [Plus de code & tutoriels](https://funwithcomputervision.com/)

<img src="https://raw.githubusercontent.com/collidingScopes/arpeggiator/main/assets/demo.png">

## Prérequis

- Navigateur web moderne avec support WebGL
- Accès à la caméra activé pour le suivi des mains

## Technologies

- **MediaPipe** pour le suivi des mains et la reconnaissance des gestes
- **Three.js** pour le rendu visuel audio-réactif
- **Tone.js** pour les sons du synthétiseur
- **HTML5 Canvas** pour le retour visuel
- **JavaScript** pour l’interaction en temps réel
## Configuration pour le développement

```bash
# Clonez ce dépôt
git clone https://github.com/collidingScopes/arpeggiator

# Accédez au répertoire du projet
cd arpeggiator

# Servez avec votre méthode préférée (exemple avec Python)
python -m http.server
```

Ensuite, accédez à `http://localhost:8000` dans votre navigateur.

## Licence

Licence MIT

## Crédits
- Three.js - https://threejs.org/
- MediaPipe - https://mediapipe.dev/
- Rosebud AI - https://rosebud.ai/
- Tone.js - https://tonejs.github.io/

## Projets connexes

J'ai publié plusieurs projets de vision par ordinateur (avec code + tutoriels) ici :
[Fun With Computer Vision](https://www.funwithcomputervision.com/)

Vous pouvez acheter un accès à vie et recevoir l'ensemble des fichiers du projet ainsi que les tutoriels. J'ajoute régulièrement du nouveau contenu 🪬

Vous pourriez également apprécier certains de mes autres projets open source :

- [3D Model Playground](https://collidingScopes.github.io/3d-model-playground) - contrôler des modèles 3D avec la voix et les gestes de la main
- [Tutoriel de suivi de main avec Threejs](https://collidingScopes.github.io/threejs-handtracking-101) - Configuration basique du suivi de main avec threejs et la vision par ordinateur MediaPipe
- [Particular Drift](https://collidingScopes.github.io/particular-drift) - Transformez vos photos en animations de particules fluides
- [Vidéo en ASCII](https://collidingScopes.github.io/ascii) - Convertir des vidéos en art pixel ASCII
## Contact

- Instagram : [@stereo.drift](https://www.instagram.com/stereo.drift/)
- Twitter/X : [@measure_plan](https://x.com/measure_plan)
- Email : [stereodriftvisuals@gmail.com](https://raw.githubusercontent.com/collidingScopes/arpeggiator/main/mailto:stereodriftvisuals@gmail.com)
- GitHub : [collidingScopes](https://github.com/collidingScopes)

## Dons

Si vous avez trouvé cet outil utile, n'hésitez pas à m'offrir un café.

Je m'appelle Alan et j'aime développer des logiciels open source pour la vision par ordinateur, les jeux, et bien plus encore. Ce serait grandement apprécié lors de mes sessions de codage tard dans la nuit !

[![Buy Me A Coffee](https://www.buymeacoffee.com/assets/img/custom_images/yellow_img.png)](https://www.buymeacoffee.com/stereoDrift)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-11

---