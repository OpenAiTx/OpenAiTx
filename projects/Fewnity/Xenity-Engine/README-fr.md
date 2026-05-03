# Xenity Engine

Xenity Engine est un moteur de jeu multiplateforme basé sur des GameObjects et des Composants pour PlayStation Portable, PsVita, PS3 et Windows.

[Documentation de script Xenity](https://fewnity.github.io/Xenity-Engine/script_api_reference/scripting_api_reference.html)

Je prévois de travailler sur un nouveau moteur, pour corriger la plupart des gros problèmes de ce moteur.<br>
Donc je ne vais probablement pas ajouter de nouvelles fonctionnalités à ce moteur.<br>
Mais les pull requests sont toujours les bienvenues, nouvelles fonctionnalités, refactorisation, corrections de bugs, optimisations ou amélioration de la documentation, tout est bon à prendre !
Si vous voulez améliorer le moteur, voici la [liste TODO](https://github.com/Fewnity/Xenity-Engine/blob/crossplatform/TODO.md).

![image](https://github.com/Fewnity/Xenity-Engine/assets/39272935/df59e12e-b989-4b0d-93b1-4f95fac7c91f)

![gif](https://github.com/user-attachments/assets/7568e868-e41c-4495-bde7-56bb7b6bc54d)

[Exemples de jeux](https://fewnity.github.io/Xenity-Engine/game_project_samples/game_project_samples.html) disponibles en téléchargement !

### Plates-formes supportées :<br>
✔️ Supporté<br>
🚧 En cours de développement<br>

| Statut | Plate-forme |
|-|-|
✔️ | Windows
✔️ | PlayStation Portable
✔️ | PlayStation Vita
✔️ | PlayStation 3
🚧 | Linux (L’interface est un peu instable, audio manquant et système de build)

Fonctionnalités :

- [X] 2D de base
- [X] 3D de base
- [X] Audio 2D
- [ ] Audio 3D
- [X] Skyboxes
- [X] Scènes
- [ ] Animations
- [X] Physique 3D
- [ ] Physique 2D
- [X] Rechargement à chaud C++

> [!WARNING]
> Le moteur n'est pas parfait. Vous pouvez donc rencontrer des problèmes lors du développement du jeu comme :
> - La suppression des fichiers Meta aura des répercussions sur votre projet. Les variables qui référencent ces fichiers seront vidées.
> - La duplication d'un fichier meta causera des problèmes, chaque fichier meta contient un identifiant de fichier unique.
> - L'audio fonctionne "correctement" avec 44100Hz mais sur PS3 vous devez utiliser de l'audio à 48000Hz.

> [!NOTE]
> Si vous souhaitez compiler un jeu dans l'éditeur, vous devez définir le `Chemin du compilateur` dans le menu `Paramètres du moteur` (Fenêtre->Paramètres du moteur).<br>
> Le `Chemin du compilateur` est par défaut `C:\Program Files\Microsoft Visual Studio\2022\Community\VC\Auxiliary\Build`, changez-le si votre installation/version de Visual Studio est différente.<br>
> Vous pouvez définir la `Localisation de PPSSPP` pour Construire et Exécuter pour les builds PSP.

## Comment utiliser l'éditeur
### Comment jouer au jeu dans l'éditeur
- Compilez le jeu dans "Jeu->Compiler le jeu"
- Cliquez sur le bouton lecture
### Comment construire le jeu
- Ouvrez le menu Paramètres de construction dans "Fichier->Paramètres de construction"
- Sélectionnez la plateforme
- Cliquez sur construire
(Pour PSP, PS3 et PsVita, vous devrez avoir Docker Desktop installé et configuré).

## Configuration Docker
Docker Desktop est nécessaire pour compiler les jeux PSP, PS3 et PsVita.<br>
Téléchargez Docker Desktop : https://www.docker.com/products/docker-desktop/

Puis terminez l'installation de Docker dans Xenity. Allez dans "Fenêtre->Configuration Docker", le processus peut prendre plusieurs minutes surtout si vous avez un ordinateur lent ou une connexion internet lente. (L'éditeur va se figer).

## Fichiers compatibles
Images : `.png .jpg .bmp, .tga`

Audio : `.wav .mp3` (Veuillez utiliser de l'audio 44100Hz sauf sur PS3, où vous devez utiliser de l'audio 48000Hz)

Mesh : `.obj .fbx`

Police : `.ttf`

## Comment compiler le moteur dans Visual Studio
- Définissez le projet `Xenity_Engine_Executable` comme projet de démarrage.
- Compiler la configuration `Engine` puis `Editor` pour générer tous les fichiers dll.

## Comment le moteur fonctionne en interne

Lorsqu'un projet/jeu est chargé, le moteur crée une liste de tous les fichiers existants. Chaque fichier a un Id unique.  
Les classes qui correspondent initialement à un fichier comme `Texture`, `Audio Clip`, `Mesh Data` et autres, héritent de `File Reference` pour avoir un pointeur vers leur fichier.

Certaines classes comme `Component`, `GameObject`, `Vector3` et autres, héritent de `Reflective`. Cela permet d’accéder à leurs variables sans connaître la classe de base. Ceci est utilisé par l’Inspecteur pour voir et modifier les données et pour sauvegarder/charger leurs données dans/depuis un fichier.

## Contact  
Si vous avez besoin d’aide, vous pouvez ouvrir un Issue ou me contacter.

Email : `fewnity@gmail.com`<br>
Discord : `fewnity`

## Licence

Le code de ce dépôt est sous licence MIT.

## SDK des consoles de jeu

https://github.com/Fewnity/Xenity-Engine-SDK

## Bibliothèques utilisées  
Stb (utilisé : stb_image 2.23 (les versions ultérieures ne fonctionnent pas sur PSP), stb_image_resize 0.97, stb_image_write 1.16) : https://github.com/nothings/stb

drmp3 v0.6.40 & drwav v0.13.17 : https://github.com/mackron/dr_libs

JSON for Modern C++ v3.11.3 : https://github.com/nlohmann/json

GLM (légèrement modifié pour PS2) : https://github.com/g-truc/glm

Bullet 2.82 (légèrement modifié pour corriger la compilation) : https://code.google.com/archive/p/bullet/downloads

### Spécifique à Windows :  
Assimp (79d451b) : https://github.com/assimp/assimp/  
<br>`cmake CMakeLists.txt -DASSIMP_BUILD_ZLIB=ON -DASSIMP_NO_EXPORT=ON -DASSIMP_BUILD_ALL_EXPORTERS_BY_DEFAULT=OFF -DASSIMP_BUILD_TESTS=OFF -DASSIMP_BUILD_ASSIMP_VIEW=OFF -DASSIMP_INJECT_DEBUG_POSTFIX=OFF -DASSIMP_INSTALL=OFF -DASSIMP_BUILD_ALL_IMPORTERS_BY_DEFAULT=OFF -DASSIMP_BUILD_OBJ_IMPORTER=ON -DASSIMP_BUILD_FBX_IMPORTER=ON -DCMAKE_BUILD_TYPE=Release`  
`cmake --build . --config Release`

FreeType (v2.13.2) : https://github.com/ubawurinna/freetype-windows-binaries/

Branche ImGui Docking (1.91.8 WIP) : https://github.com/ocornut/imgui

SDL (3.2) : https://github.com/libsdl-org/SDL

Glad v2.0.8 (mode compatibilité gl 4.6) : https://gen.glad.sh/

### Spécifique PsVita : 
VitaGL (029ddbe) : (Compilé avec le flag HAVE_GLSL_SUPPORT=1 activé, NO_DEBUG=1 pour la version release et HAVE_SHARK_LOG=1 LOG_ERRORS=2 pour le debug) https://github.com/Rinnegatamante/vitaGL


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-03

---