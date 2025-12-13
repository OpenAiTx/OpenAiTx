# Moteur Luz

[![Licence : MIT](https://img.shields.io/badge/License-MIT-green.svg)](LICENSE)
[![Windows](https://github.com/hadryansalles/Luz/actions/workflows/Windows.yml/badge.svg)](https://github.com/hadryansalles/Luz/actions/workflows/Windows.yml)
[![Ubuntu](https://github.com/hadryansalles/Luz/actions/workflows/Ubuntu.yml/badge.svg)](https://github.com/hadryansalles/Luz/actions/workflows/Ubuntu.yml)

Un moteur Vulkan que je développe pour étudier et implémenter des techniques de rendu modernes utilisées par les jeux AAA.
- [Vidéos sur Youtube](https://www.youtube.com/user/HadryanSalles/videos)
- [Fonctionnalités](#features)
- [Comment compiler et exécuter](#build)
- [Références et crédits](#references)

<a name="features"/>

## Fonctionnalités
- Wrapper Vulkan complet (incluant la création de BLAS et TLAS)
- 3 Approches pour la lumière volumétrique : Froxels, maillage polygonal et espace écran
- Anti-aliasing temporel
- Cartes d'ombres
- Diffusion atmosphérique
- Sérialisation de scène (JSON)
- Rendu différé
- Ombres et occlusion ambiante tracées en temps réel par lancer de rayons
- Ombrage PBR avec métallisé, rugosité, normal, occlusion ambiante et émission
- Ressources Vulkan sans liaison
- Caméra viewport avec projections perspective et orthographique, contrôles de vol et d'orbite
- Interface utilisateur dockable ImGui

## Galerie
- Lumière volumétrique basée sur Froxel
![froxel](https://github.com/user-attachments/assets/28efe343-f5be-45db-a3ac-246aee47faa4)

- Lumière volumétrique par maillage polygonal
![polygonal](https://github.com/user-attachments/assets/c2113f1b-9081-4a1d-8b8a-516c6d81281f)

- Lumière volumétrique en espace écran
![ssvl](https://github.com/user-attachments/assets/fcbd3fd5-881f-4640-a887-565d7190da23)

- Rendu différé (Lumière, Albedo, Normale, Matériau, Émissif et Profondeur)
![deferred](https://user-images.githubusercontent.com/37905502/154867586-7dfa15d1-faf7-4eab-8337-c578831c9044.gif)
- Ombres tracées par lancer de rayons et occlusion ambiante  
![raytraced](https://user-images.githubusercontent.com/37905502/144621461-52f1ab97-ff6b-4f6f-a83a-cc6f67f5ead6.gif)

- Éclairage PBR et modèles glTF  
![pbr](https://user-images.githubusercontent.com/37905502/144612584-1d752a16-c978-4f43-93d6-2e2362b2804b.gif)

- Glisser-déposer des textures  
![dragndrop](https://user-images.githubusercontent.com/37905502/144619247-737d37c1-ba67-4f9a-abf4-63e4d2f965d6.gif)

<a name="build"/>

## Exigences  
- Un GPU prenant en charge l'extension VK_KHR_ray_query ([liste des GPU supportés](https://vulkan.gpuinfo.org/listdevicescoverage.php?extension=VK_KHR_ray_query&platform=all))  
- Compilateur C++17. Testé avec ``Visual Studio 2019``, ``Clang`` et ``GCC``  
- [CMake 3.7](https://cmake.org/download/) ou supérieur  
- [Vulkan SDK](https://vulkan.lunarg.com/sdk/home)

### Pour Linux

Ce projet utilise la bibliothèque GLFW, pour le compiler sous Linux avec X11 (comme sous Ubuntu 20.04 par défaut) vous aurez besoin de :


```sh
sudo apt-get install xorg-dev
```

Si vous utilisez un autre gestionnaire de fenêtres (comme Wayland), vous pouvez vérifier les dépendances [ici](https://www.glfw.org/docs/latest/compile.html#compile_deps).

## Compiler et exécuter
```sh
git clone --recursive https://github.com/hadryansalles/Luz
cd Luz
mkdir build
cmake . -Bbuild
cmake --build build --parallel 4
./bin/Luz
```
- Visual Studio : ouvrez ``build/Luz.sln`` et compilez/exécutez le projet ``Luz``.

<a name="references"/>

## Références et Crédits

- [GLFW](https://github.com/glfw/glfw) utilisé pour ouvrir la fenêtre de l'application
- [glm](https://github.com/g-truc/glm) utilisé comme bibliothèque mathématique
- [ImGui](https://github.com/ocornut/imgui) utilisé pour créer l'interface utilisateur
- [ImGuizmo](https://github.com/CedricGuillemet/ImGuizmo) utilisé pour créer des gizmos 3D
- [spdlog](https://github.com/gabime/spdlog) utilisé comme bibliothèque de journalisation
- [stb_image](https://github.com/nothings/stb) utilisé pour charger les fichiers image
- [tiny_obj_loader](https://github.com/tinyobjloader/tinyobjloader) utilisé pour charger les fichiers wavefront .obj
- [optick](https://github.com/bombomby/optick) utilisé pour profiler le moteur
- [pbr-sky](https://www.shadertoy.com/view/slyBDG) utilisé comme référence pour le modèle atmosphérique du ciel



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-13

---