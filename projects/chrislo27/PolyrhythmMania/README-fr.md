# Polyrhythm Mania
Un jeu qui recrée fidèlement le mini-jeu *Polyrhythm* de Rhythm Tengoku (リズム天国), avec un 
éditeur de niveaux intégré et des modes annexes.

![Polyrhythm Mania thumbnail](https://user-images.githubusercontent.com/6299069/144956042-654ff2b3-aeba-4486-810e-f26aa1b33bff.png)
![Polyrhythm: Assemble side mode thumbnail](https://user-images.githubusercontent.com/6299069/140859874-0552bb9a-c6dc-460b-a4a2-e35f99648ea9.png)

[![Downloads](https://img.shields.io/github/downloads/chrislo27/PolyrhythmMania/total.svg)](https://github.com/chrislo27/PolyrhythmMania/releases/latest)
[![GitHub license](https://img.shields.io/github/license/chrislo27/PolyrhythmMania.svg)](https://github.com/chrislo27/PolyrhythmMania/blob/dev/LICENSE.txt)
[![Donate to the project maintainer](https://img.shields.io/badge/Donate-PayPal-blue.svg?logo=paypal)](https://www.paypal.com/donate?hosted_button_id=9JLGHKZNWLLQ8)

[Bande originale sur YouTube par GENERIC](https://www.youtube.com/playlist?list=PLt_3dgnFrUPwcA6SdTfi0RapEBdQV64v_)

## Fonctionnalités
* Recréation complète du mini-jeu Polyrhythm de Rhythm Tengoku, *et plus encore !*
* Un mode *Histoire* complet avec plus de 40 niveaux
* Trier et organiser vos niveaux personnalisés grâce à la fonction Bibliothèque
* Créez des niveaux personnalisés avec un éditeur de niveaux intégré et intuitif
* Effets de niveaux tels que changement de palette de couleurs, ajout de zones de texte, placement d'Étoiles de Compétence, et plus
* Basculez entre textures classiques GBA, HD modernes, et arcade, ou ajoutez votre propre pack de textures personnalisé
* Modes d'entraînement pour améliorer vos compétences Polyrhythm avec des niveaux du jeu GBA original
* Mode Infini qui vous tient en haleine avec des motifs générés procéduralement sans fin
* Mode Défi Quotidien avec une série de motifs absents du mode Infini classique, avec classements en ligne
* Modes annexes supplémentaires comme _Polyrhythm : Dunk_, _Polyrhythm : Assemble_, et _Built to Scale : Solitaire_ pour encore plus de fun Polyrhythm

[Découvrez la bande-annonce de la mise à jour v1.2 sur YouTube !](https://www.youtube.com/watch?v=I4BXu7sNj-M)  
[Découvrez la bande-annonce de l’annonce sur YouTube !](https://www.youtube.com/watch?v=A3ZUBIy_MAQ)  
[Découvrez la bande-annonce des fonctionnalités d’août 2021 !](https://www.youtube.com/watch?v=k9PtPI1-tDo)  


## Configuration requise pour jouer
**Systèmes d’exploitation officiellement supportés :** Windows 10 ou plus récent, Linux (x86-64 et ARM). 

> macOS n’est pas officiellement supporté (c’est-à-dire que nous n’acceptons pas les rapports de bugs depuis macOS) mais vous pouvez tenter de le faire fonctionner selon [le problème #29](https://github.com/chrislo27/PolyrhythmMania/issues/29).

**Spécifications système :** [Exigences similaires à *Minecraft : Java Edition*](https://help.minecraft.net/hc/en-us/articles/4409225939853-Minecraft-Java-Edition-Installation-Issues-FAQ#h_01FFJMSQWJH31CH16H63GX4YKE)
sont utilisées, puisque la même bibliothèque graphique sous-jacente (GLFW avec OpenGL 4.4) est employée.

### Configuration minimale
* CPU : Intel Core i3-3210 3.2 GHz / AMD A8-7600 APU 3.1 GHz ou équivalent
* RAM : 4 Go  
* GPU (intégrée) : Intel HD Graphics 4000 (Ivy Bridge) ou AMD Radeon série R5 (ligne Kaveri) avec OpenGL 4.4  
* GPU (discrète) : NVIDIA GeForce série 400 ou AMD Radeon série HD 7000 avec OpenGL 4.4  
* HDD : Au moins 1 Go pour le jeu et les niveaux  
* OS : Windows 10 et supérieur, distributions Linux 64 bits à partir de 2018  
* Écran : résolution 1280x720  

### Configuration recommandée  
* CPU : Intel Core i5-4690 3,5 GHz / AMD A10-7800 APU 3,5 GHz ou équivalent  
* RAM : 8 Go  
* GPU : NVIDIA GeForce série 700 ou AMD Radeon Rx série 200 (excluant les chipsets intégrés) avec OpenGL 4.5  
* HDD : 2 Go (SSD recommandé)  
* OS : Windows 10 et plus récent (64 bits), distributions Linux 64 bits à partir de 2020 (ex : Ubuntu 20.04)  
* Écran : résolution 1920x1080  

## Instructions d'installation  
Ces instructions sont les mêmes que vous téléchargiez le jeu pour la première fois ou que vous effectuiez une mise à jour vers une nouvelle version.  
Assurez-vous de respecter les exigences système ci-dessus.  

__Windows (64 bits uniquement, pas d'installation Java requise) :__  
1. Rendez-vous sur la [dernière version ici](https://github.com/chrislo27/PolyrhythmMania/releases/latest) dans un nouvel onglet ou une nouvelle fenêtre.  
2. Téléchargez la version correcte du jeu dans la section Assets nommée `PolyrhythmMania_VERSION_win64.zip`, où VERSION est le nom de la version de la release. **Notez le "win64" dans le nom du fichier.** Ne téléchargez pas le "Source code".  
3. Trouvez le fichier zip téléchargé dans l'Explorateur de fichiers. Extrayez le fichier zip : clic droit sur le fichier zip téléchargé, cliquez sur "Extraire tout...", puis extrayez le contenu dans un dossier.  
4. Ouvrez le dossier nouvellement extrait et entrez dans le dossier `PolyrhythmMania_win64`.  
5. Double-cliquez sur l’exécutable `LaunchPolyrhythmMania.exe` pour lancer le jeu ! (Vous n’avez pas besoin d’avoir Java Runtime Environment déjà installé, le jeu en est fourni avec une copie.)  
6. Si Windows Defender affiche "Windows Defender SmartScreen a empêché le démarrage d’une application non reconnue", vous pouvez l’ignorer en cliquant sur "Plus d’infos" puis "Exécuter quand même".  

__Autres plateformes (ou pour utilisateurs avancés disposant déjà de Java)__  
1. **(Pré-requis)** Assurez-vous que le Java Runtime Environment (JRE 17 recommandé, JRE 11 minimum) est déjà installé et accessible dans votre chemin en tant que commande `java`.  
2. Rendez-vous sur la [dernière version ici](https://github.com/chrislo27/PolyrhythmMania/releases/latest) dans un nouvel onglet ou une nouvelle fenêtre.  
3. Téléchargez la version correcte du jeu dans la section Assets nommée `PolyrhythmMania_VERSION.zip`, où VERSION est le nom de la version de la release. Ne téléchargez pas le "Source code".  
4. Extrayez le fichier zip à un emplacement connu.  
5. Ouvrez le répertoire nouvellement extrait et entrez dans le dossier `PolyrhythmMania_platform_agnostic`.  
6. Exécutez le script de lancement approprié : sous Windows, double-cliquez sur `play_windows.bat`. Sous Linux, exécutez le fichier `play_linux.sh` (vous devrez peut-être faire `chmod +x play_linux.sh` d’abord).  
7. Si vous préférez ne pas utiliser de script de lancement, vous pouvez exécuter `java -jar bin/PolyrhythmMania.jar` avec vos paramètres préférés.  

## Instructions de compilation  
Ces instructions s’adressent aux personnes souhaitant modifier le code source du jeu.  

1. Assurez-vous que le JDK 17 ou plus récent est installé.
2. `chmod +x gradlew`
3. `./gradlew :desktop:run`

## Autres informations
Rhythm Heaven est la propriété intellectuelle de Nintendo.
Ce programme n'est **PAS** approuvé ni sponsorisé de quelque manière que ce soit par Nintendo.
Toutes les propriétés utilisées de Nintendo (telles que noms, audio, graphismes, etc.) dans ce logiciel ne visent pas à enfreindre malicieusement les droits de marque.
Toutes les autres marques et actifs sont la propriété de leurs détenteurs respectifs.
Ceci est un projet communautaire et est disponible pour que d'autres l'utilisent
conformément à la [licence GPL-3.0](LICENSE), sans frais.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-31

---