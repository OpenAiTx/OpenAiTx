# RaySplats : Splatting Gaussien basé sur le Ray Tracing
Krzysztof Byrski, Marcin Mazur, Jacek Tabor, Tadeusz Dziarmaga, Marcin Kądziołka, Dawid Baran, Przemysław Spurek <br>

| arXiv |
| :---- |
| RaySplats : Splatting Gaussien basé sur le Ray Tracing [https://arxiv.org/pdf/2501.19196.pdf](http://arxiv.org/abs/2501.19196)|

<img src=assets/gif1.gif height="300" class="center"> 
<br>

<table align="center" cellspacing="0" cellpadding="0">
  <tr class="center">
    <td><img src=assets/screenshot1.png height="200" width="300" class="center"></td>
    <td><img src=assets/screenshot92.png height="200" width="300" class="center"></td>
    <td><img src=assets/screenshot10.png height="200" width="300" class="center"> </td>
  </tr>
  </tr class="center">
  <tr class="center">
    <td><img src=assets/screenshot7.png height="200" width="300" ></td>
    <td><img src=assets/screenshot82.png height="200" width="300" ></td>
    <td><img src=assets/screenshot4.png height="200" width="300" class="center"> </td>
  </tr>
</table>

# Fonctionnalités
- Support des harmoniques sphériques jusqu'au degré **4**.
- Application interactive Windows de visualisation / optimisation permettant de prévisualiser l'état du modèle entraîné en temps réel.
- Support du format de sortie du modèle entraîné **PLY**.
- Rendu Gaussien pur très efficace (sans approximation par maillage primitif).
- Optimiseur hautement configurable basé sur un fichier de configuration texte pratique.
- Support des ensembles de données **Blender** et **COLMAP** (après un prétraitement par le 3DGS).
- Évaluation intégrée du modèle et visualisation dans un fichier *.bmp avec une fréquence configurable.

# Contrôles dans l'application interactive Windows de visualisation / optimisation

<img src="https://raw.githubusercontent.com/KByrski/RaySplatting/master/assets/app_main_window.png">

- **Double clic gauche** : Basculer entre la caméra **statique** et le mode **libre**.
- **Mouvement de la souris** : Faire pivoter la caméra en mode **libre**.
- **W / S** : Avancer / reculer.
- **A / D** : Pas à gauche / droite.  
- **Barre d’espace / C** : Se déplacer vers le haut / bas.  
- **[ / ]** : Passer à la pose d’entraînement précédente / suivante de la caméra.  
- **Impr écran** : Faire une capture d’écran et l’enregistrer dans un fichier *.bmp 24 bits.  

# Prérequis :  

- Visual Studio 2019 Enterprise ;  
- CUDA Toolkit 12.4.1 ;  
- NVIDIA OptiX SDK 8.0.0 ;  

# Construction de l’application interactive Windows viewer / optimizer  

- Créez un nouveau projet d’application Windows Desktop et nommez-le "RaySplats" ;  
- Supprimez le fichier RaySplats.cpp nouvellement généré contenant le modèle de code ;  
- Dans **Build Dependencies** -> **Build Customizations...** cochez la case correspondant à votre version CUDA installée. Sur notre système de test, nous avons dû sélectionner la case suivante :  

  **CUDA 12.4(.targets, .props)**  
  
- Ajoutez tous les fichiers du répertoire "RaySplats" au projet ;  
- Dans les propriétés du projet, définissez **Configuration** sur **"Release"** et **Platform** sur **"x64"** ;  
- Dans **Properties** -> **Configuration Properties** -> **CUDA C/C++** -> **Common** -> **Generate Relocatable Device Code**, sélectionnez **Yes (-rdc=true)** ;  
- Pour le fichier "shaders.cuh" dans **Properties** -> **Configuration Properties** -> **General** -> **Item Type**, sélectionnez **"CUDA C/C++"** ;  
- Pour les fichiers : "shaders.cuh", "shaders_SH0.cu", "shaders_SH1.cu", "shaders_SH2.cu", "shaders_SH3.cu" et "shaders_SH4.cu" dans **Properties** -> **Configuration Properties** -> **CUDA C/C++** -> **Common** :  
  - Changez le suffixe de **Compiler Output (obj/cubin)** de **".obj"** en **".ptx"** ;  
  - Dans **Generate Relocatable Device Code**, sélectionnez **No** ;  
  - Dans **NVCC Compilation Type**, sélectionnez **Generate device-only .ptx file (-ptx)"** ;  
- Dans **Properties** -> **Configuration Properties** -> **VC++ Directories** -> **Include Directories**, ajoutez le chemin du répertoire "include" d’OptiX. Sur notre système de test, nous avons dû ajouter le chemin suivant :
  ```plaintext
  "C:\ProgramData\NVIDIA Corporation\OptiX SDK 8.0.0\include"
  ```
- Dans **Propriétés** -> **Propriétés de la configuration** -> **CUDA C/C++** -> **Appareil** -> **Génération de code**, saisissez la capacité de calcul et la version de microarchitecture de votre GPU. Sur notre système de test avec GPU RTX 4070, nous avons saisi :
  ```plaintext
  "compute_89,sm_89"
  ```
- Dans **Propriétés** -> **Propriétés de configuration** -> **Éditeur de liens** -> **Entrée** -> **Dépendances supplémentaires**, ajoutez trois nouvelles lignes contenant :
  ```plaintext
  "cuda.lib"
  ```
  ```plaintext
  "cudart.lib"
  ```
  ```plaintext
  "cufft.lib"
  ```
- Dans chacun des deux blocs de code différents du fichier InitializeOptiXRenderer.cu :
  ```plaintext
  if      constexpr (SH_degree == 0) f = fopen("C:/Users/pc/source/repos/RaySplats/RaySplats/x64/Release/shaders_SH0.cu.ptx", "rb");
  else if constexpr (SH_degree == 1) f = fopen("C:/Users/pc/source/repos/RaySplats/RaySplats/x64/Release/shaders_SH1.cu.ptx", "rb");
  else if constexpr (SH_degree == 2) f = fopen("C:/Users/pc/source/repos/RaySplats/RaySplats/x64/Release/shaders_SH2.cu.ptx", "rb");
  else if constexpr (SH_degree == 3) f = fopen("C:/Users/pc/source/repos/RaySplats/RaySplats/x64/Release/shaders_SH3.cu.ptx", "rb");
  else if constexpr (SH_degree == 4) f = fopen("C:/Users/pc/source/repos/RaySplats/RaySplats/x64/Release/shaders_SH4.cu.ptx", "rb");
  ```
  and
  ```plaintext
  if      constexpr (SH_degree == 0) f = fopen("C:/Users/pc/source/repos/RaySplats/RaySplats/x64/Release/shaders_SH0.cu.ptx", "rt");
  else if constexpr (SH_degree == 1) f = fopen("C:/Users/pc/source/repos/RaySplats/RaySplats/x64/Release/shaders_SH1.cu.ptx", "rt");
  else if constexpr (SH_degree == 2) f = fopen("C:/Users/pc/source/repos/RaySplats/RaySplats/x64/Release/shaders_SH2.cu.ptx", "rt");
  else if constexpr (SH_degree == 3) f = fopen("C:/Users/pc/source/repos/RaySplats/RaySplats/x64/Release/shaders_SH3.cu.ptx", "rt");
  else if constexpr (SH_degree == 4) f = fopen("C:/Users/pc/source/repos/RaySplats/RaySplats/x64/Release/shaders_SH4.cu.ptx", "rt");
  ```
  remplacez le chemin fourni par le chemin vers les fichiers shaders compilés *.ptx sur votre disque dur.

# Entraînement de votre premier modèle (jeu de données Blender) :

- Entraînez le modèle avec 3DGS pour un petit nombre d’itérations (par exemple 100) sur un jeu de données Blender (par exemple : « lego » de l’ensemble « NeRF synthetic ») ;
- Convertissez tous les fichiers des sous-répertoires : « train » et « test » situés dans le répertoire principal du jeu de données au format fichier *.bmp 24 bits sans changer leurs noms ;
- Copiez le fichier de configuration « config.txt » dans le répertoire principal du projet. Sur notre système de test, nous l’avons copié dans le répertoire suivant :
  ```plaintext
  "C:\Users\<Windows username>\source\repos\RaySplats\RaySplats"
  ```
- Dans les lignes : 4 et 5 du fichier de configuration, spécifiez l'emplacement du répertoire principal du jeu de données et le fichier 3DGS *.ply de sortie obtenu après le pré-entraînement court du modèle (**Important !** Le degré des harmoniques sphériques utilisé pour le pré-entraînement et celui cible spécifié à la ligne 7 du fichier de configuration ne doivent pas nécessairement correspondre) ;
- Dans les lignes : 13-15 du fichier de configuration, spécifiez la couleur de fond qui correspond à la couleur de fond utilisée pour le pré-entraînement en utilisant la formule suivante :
  
  R' = (R + 0,5) / 256<br>
  G' = (G + 0,5) / 256<br>
  B' = (B + 0,5) / 256<br>

  où R, G et B sont les coordonnées entières non négatives de la couleur de fond dans la plage 0-255.
- Lancez le projet "RaySplats" depuis l'IDE Visual Studio ;

# Visionneuse RaySplatting
![image](https://github.com/user-attachments/assets/9a9d61cb-f54a-4301-8a52-4c2d0ce2cc72)
![](https://raw.githubusercontent.com/KByrski/RaySplatting/master/assets/tutorial.mp4)

Ceci est une visionneuse légère et conviviale pour visualiser **RaySplatting** avec des objets supplémentaires chargés par l'utilisateur qui supportent le lancer de rayons. La visionneuse permet une intégration fluide des fichiers **OBJ** et **PLY (format ASCII)** dans la scène.  

Le système de matériaux actuel est optimisé pour les modèles conçus pour être **réfléchissants** ou **semblables au verre**, ce qui le rend idéal pour le rendu de visuels de haute qualité avec des interactions lumineuses réalistes.  

## Configuration requise  

Pour utiliser cette visionneuse, assurez-vous que votre système répond aux exigences suivantes :  

- **Système d'exploitation** : Windows  
- **GPU** : NVIDIA RTX série 20xx ou supérieure (**RTX 30xx+ recommandé**)  
- **Version CUDA** : 12.4 ou ultérieure  
- **DLL requises** : Placez les fichiers suivants dans le répertoire :  
  ```plaintext
  C:\Program Files\NVIDIA GPU Computing Toolkit\CUDA\v12.4\bin
  ```
  - `cudart64_12.dll`  
  - `cufft64_11.dll`  

## Installation & Utilisation  

1. Téléchargez le **fichier ZIP** fourni.  [Télécharger ZIP](https://drive.google.com/file/d/1XPivZb6-dVtuwQ3T9UrxOF2gTTnerGhp/view?usp=sharing)
2. Extrayez le contenu.  
3. Lancez le **fichier exe**—aucune configuration supplémentaire requise !  
4. Modifiez les propriétés du maillage dans **mesh_config.txt**.  
5. Changez la scène de base en modifiant le **chemin du fichier PLY** dans `config.txt`.  

## Contrôles  

- Exactement les mêmes que dans l’application interactive de visualisation / optimisation Windows.

## Fonctionnalités futures  

Nous développons activement de nouvelles fonctionnalités, notamment :  
- **Transformations améliorées du maillage** (mise à l’échelle, rotation, modification de position au-delà de `mesh_config.txt`)  
- **Capture d’écran** pour les scènes rendues  
- **Préréglages de vue** pour permettre un changement fluide entre différentes perspectives  
- **Et bien plus encore !**  

Restez à l’écoute pour les mises à jour et améliorations !





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-26

---