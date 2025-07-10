<p align="center">
    <img src="https://raw.githubusercontent.com/basketoengine/Basketo/main/readmeimgs/logo.png" alt="Logo du moteur de jeu Basketo" width="200"/>
</p>

<h2 align="center">Créez, Jouez, Inspirez. Les jeux prennent vie. ✨</h2>

<h1 align="center">Moteur de jeu Basketo</h1>

<div align="center">

[![Discord](https://img.shields.io/discord/1373185493742911609?logo=discord&label=Discord&color=5B5BD6&logoColor=white)](https://discord.gg/F3DswRMW) <!-- Remplacez your_discord_server_id par l'ID réel de votre serveur -->
[![GitHub stars](https://img.shields.io/github/stars/basketoengine/Basketo?style=social)](https://github.com/basketoengine/Basketo)
[![X (anciennement Twitter)](https://img.shields.io/twitter/follow/BaslaelWorkneh?style=social&logo=x)](https://x.com/BaslaelWorkneh)

</div>

<p align="center">
Bienvenue dans le moteur Basketo - un projet passion où nous mettons tout en œuvre pour créer un moteur performant et exceptionnel, avec le projet ambitieux d’en faire un moteur de jeu natif IA. Doté d’une interface éditeur similaire à Unity, d’une intégration Gemini AI, d’un système avancé d’effets sonores multiples et d’une puissante architecture ECS. Que vous soyez ici pour contribuer, proposer des idées ou simplement observer son évolution, vous faites partie du voyage ! 🚀
</p>
## 🚀 État actuel du moteur
<p align="center">
  <img src="https://raw.githubusercontent.com/basketoengine/Basketo/main/readmeimgs/image3.png" alt="État actuel du moteur Basketo" width="700"/>
</p>

<p align="center">
  <em>Découvrez les derniers développements et fonctionnalités en action !</em> 🎮
</p>

## ✨ Fonctionnalités clés

### 🎮 **Interface d’éditeur similaire à Unity**
- **Configuration à double fenêtre** : éditeur de scène et vue du jeu côte à côte
- **Édition en direct** : modifiez les scènes pendant l’exécution du jeu
- **Panneau d’inspection** : édition visuelle des composants par glisser-déposer
- **Vue hiérarchique** : organisez et gérez les entités
- **Navigateur d’actifs** : gestion facile des textures et de l’audio

### 🤖 **Développement natif IA**
- **Intégration Gemini AI** : commandes en langage naturel pour le développement de jeux
- **Génération intelligente de scripts** : création de scripts Lua assistée par IA
- **Modification d’entités** : décrivez les changements en anglais courant
- **Configuration facile de l’API** : configuration intégrée de la clé API Gemini
### 🔊 **Système Audio Avancé**
- **Effets sonores multiples** : Plusieurs sons nommés par entité (marche, saut, attaque, etc.)
- **Audio traditionnel** : Musique de fond et sons d'ambiance
- **Intégration Lua** : Déclenchez des sons depuis les scripts avec `PlaySound(entity, "action")`
- **Éditeur visuel** : Gérez les effets sonores via l'inspecteur

### 🎯 **Entity-Component-System (ECS)**
- **Haute performance** : Optimisé pour un grand nombre d'entités
- **Conception modulaire** : Combinez les composants selon les besoins
- **Intégration de scripts** : Script Lua avec accès complet à l'ECS
- **Mises à jour en temps réel** : Modification des composants en direct

### 🎨 **Graphismes & Animation**
- **Rendu de sprites** : Pipeline graphique 2D efficace
- **Système d'animation** : Animations image par image avec boucle
- **Système de transformation** : Position, rotation et mise à l'échelle
- **Système de caméra** : Prise en charge de plusieurs caméras

### ⚡ **Physique & Collision**
- **Détection de collision** : Collision AABB avec optimisation spatiale
- **Physique des corps rigides** : Gravité, vélocité et forces
- **Rappels de collision** : Événements de collision accessibles par script
- **Partitionnement spatial** : Optimisation par quadtree pour la performance
## 🎬 Cliquez sur l'image ci-dessous pour voir une démonstration vidéo :
<p align="center">
  <a href="https://x.com/BaslaelWorkneh/status/1922713614697288096">
    <img src="https://raw.githubusercontent.com/basketoengine/Basketo/main/readmeimgs/image2.png" alt="Démonstration du moteur Basketo" width="500"/>
  </a>
</p>

## � Guide de démarrage rapide

### 1. **Obtenez votre clé API Gemini** (Optionnel mais recommandé)
- Rendez-vous sur [Google AI Studio](https://aistudio.google.com/app/apikey)
- Connectez-vous et créez une clé API gratuite
- Cela active des fonctionnalités alimentées par l'IA comme les commandes en langage naturel

### 2. **Construisez et exécutez**
```bash
git clone --recurse-submodules git@github.com:basketoengine/Basketo.git
cd Basketo && mkdir build && cd build
cmake .. && make -j$(nproc)
./BasketoGameEngine
```
### 3. **Configurer les fonctionnalités IA**
- Dans le moteur, allez dans le panneau de commandes IA (en bas)
- Cherchez "🤖 Configuration Gemini IA"
- Entrez votre clé API et cliquez sur "Enregistrer"

### 4. **Commencez à créer**
- Essayez les commandes IA : `"create a player at 100 200"`
- Ajoutez des effets sonores aux entités dans l’inspecteur
- Écrivez des scripts Lua ou laissez l’IA les générer
- Utilisez l’éditeur à double fenêtre pour le développement en direct

## �🛠️ Compilation du moteur (Linux) 🐧

### Prérequis
- CMake 3.26.0 ou version supérieure requis.
- SDL2, SDL2_image, SDL2_ttf, SDL2_mixer
- Lua 5.4
- g++ (C++17)
- libcurl (pour les fonctionnalités IA)
- nlohmann/json (inclus en tant que sous-module)
- ImGui (inclus en tant que sous-module)

### Étapes de compilation
```bash
# Cloner le dépôt
git clone --recurse-submodules git@github.com:basketoengine/Basketo.git

cd Basketo

mkdir build && cd build

cmake ..

make -j$(nproc)

```

### Exécution
```bash
./BasketoGameEngine

```
Si vous souhaitez exécuter le test de physique :
```bash
./PhysicsTest

```

## 🛠️ Compilation du moteur (Windows) 💻

### Prérequis

1. **Visual Studio 2022 (Édition Communautaire ou supérieure)**  
   Installez avec les charges de travail suivantes :
   - Développement de bureau avec C++
   - Outils CMake pour C++ sous Windows
   - SDK Windows 10 ou 11

2. **CMake** (inclus avec Visual Studio ou à télécharger depuis https://cmake.org/download/)

3. **vcpkg** (utilisé pour installer les dépendances)


---
### Installer les dépendances

```bash
# Ouvrez une invite de commande développeur pour VS 2022 ou PowerShell

# Clonez vcpkg

git clone https://github.com/microsoft/vcpkg.git
cd vcpkg

.\bootstrap-vcpkg.bat

# Installez les bibliothèques requises
.\vcpkg install sdl2 sdl2-image sdl2-ttf sdl2-mixer lua curl

```

---

### Étapes de compilation
```bash
# Cloner le dépôt Basketo
git clone --recurse-submodules git@github.com:basketoengine/Basketo.git
cd Basketo
mkdir build && cd build

# Configurer avec CMake
cmake .. -DCMAKE_TOOLCHAIN_FILE=C:/path/to/vcpkg/scripts/buildsystems/vcpkg.cmake -DCMAKE_BUILD_TYPE=Release

# Remplacez "C:/path/to/vcpkg" par le chemin complet vers votre répertoire vcpkg

# Compiler le moteur
cmake --build . --config Release
```

---

### Exécution

```bash
# Depuis le répertoire build/Release
```
./BasketoGameEngine.exe

# Pour exécuter le test de physique
./PhysicsTest.exe
```

## 📚 Documentation

### Fonctionnalités principales
- **[Système d'effets sonores](https://raw.githubusercontent.com/basketoengine/Basketo/main/docs/SoundEffectsSystem.md)** : Guide complet sur les effets sonores multiples
- **[Configuration de l'API Gemini](https://raw.githubusercontent.com/basketoengine/Basketo/main/docs/GeminiAPIKeySetup.md)** : Configuration étape par étape de l'IA
- **[Scripts Lua](assets/Scripts/)** : Exemples de scripts et référence API

### Exemple d'utilisation

#### Développement assisté par IA
```bash
# Commandes en langage naturel
"créer un personnage joueur à la position 100 200"
"ajouter un comportement de saut au joueur"
"rendre l'ennemi plus rapide"

# Génération de script
gemini_script créer un contrôleur de plateforme avec double saut
```

#### Effets sonores multiples
```lua
-- Dans vos scripts Lua
PlaySound(entity, "jump")    -- Jouer le son de saut
PlaySound(entity, "walk")    -- Jouer le son de marche
PlaySound(entity, "attack")  -- Jouer le son d'attaque

-- Vérifier si le son existe
if HasSoundEffect(entity, "jump") then
    PlaySound(entity, "jump")
end
```

#### Système de composants
- **Transform** : Position, rotation, échelle
- **Sprite** : Rendu de textures
- **Animation** : Animations basées sur les images
- **Script** : Scripts de comportement Lua
- **Collider** : Collision physique
- **Rigidbody** : Simulation physique
- **Audio** : Musique de fond
- **SoundEffects** : Plusieurs sons nommés
- **Camera** : Gestion de la vue

## 🤝 Participez

Nous adorons les contributions de notre communauté ❤️. Pour plus de détails sur la contribution ou pour exécuter le projet en mode développement, consultez notre [Guide de Contribution](https://raw.githubusercontent.com/basketoengine/Basketo/main/ContributionGuidline.md). <!-- En supposant que vous disposez de ce fichier -->

- 🐛 Vous avez trouvé un bug ? Ouvrez une issue !
- ✨ Vous avez une idée de fonctionnalité géniale ? Partagez-la avec nous !
- 💻 Vous voulez contribuer ? Forkez, codez, et créez une pull request !

Construisons ce moteur ensemble et rendons le développement de jeux amusant et facile pour tous. 🌍

## 👥 Communauté
Bienvenue avec une énorme accolade 🤗. Nous sommes super enthousiastes à propos des contributions de la communauté, quelle qu’en soit la nature - que ce soit des améliorations du code 📝, des mises à jour de la documentation 📚, des rapports de bugs 🐞, des demandes de fonctionnalités 💡, ou des discussions sur notre Discord 🗣️.

Rejoignez notre communauté ici :

- 👋 [Rejoignez notre communauté Discord](https://discord.gg/F3DswRMW)
- ⭐ [Ajoutez-nous en favori sur GitHub](https://github.com/basketoengine/Basketo)

## 🙏 Soutenez-nous :
Nous nous améliorons constamment, et de nouvelles fonctionnalités ainsi que des exemples arriveront bientôt 🌟. Si vous aimez ce projet, laissez-nous une étoile ⭐ sur le dépôt GitHub [![GitHub](https://img.shields.io/github/stars/basketoengine/Basketo?color=5B5BD6)](https://github.com/basketoengine/Basketo) pour rester informé et nous aider à grandir. 🌱

---

Bon codage et bon développement de jeux ! 🎉🎮

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-10

---