<img src="https://github.com/Sanju0910/Sanju0910/blob/main/images/of_logo.png" width=100 height=100 align="left" />  
<img src="https://github.com/Sanju0910/Sanju0910/blob/main/images/oneplus_logo.png" align="right"/>

## Projet OrangeFox Recovery pour la série Oneplus 8 & 9R 
## Journal des modifications

# 18-Jan-2026 R11.3 V33
  -  Synchronisé avec les derniers changements de la version Orangefox R11.3
  -  Devrait fonctionner sur tous les ROMs personnalisés Android 13 - Android 16
  -  Magisk mis à jour vers la dernière version

# 19-Feb-2025 R12.1 V32
  -  Synchronisé avec les derniers changements du code source Orangefox

# 29-Sep-2024 R12.1 V31
  -  Synchronisé avec les derniers changements du code source Orangefox

# 22-May-2024 R12.1 V30
  -  Synchronisé avec les derniers changements du code source Orangefox

# 03-Mar-2024 R12.1 V29
  -  Synchronisé avec les derniers changements du code source Orangefox
  -  Orangefox se reflashera lui-même si un ROM est flashé depuis une version déjà flashée d’Orangefox V28 ou plus récente sur le téléphone !
  -  Revenu aux paramètres du Kernel qui causaient des problèmes sur Orangefox V28
  -  Addon Magisk mis à jour vers Magisk v27.0
  
# 02-Feb-2024 R12.1 V28
  - Synchronisé avec les derniers changements du code source Orangefox
  - Désormais Orangefox se reflashera lui-même si un ROM est flashé depuis une version 
    déjà flashée d’Orangefox V28 sur le téléphone !

# 15-Dec-2023 R12.1 V27
  - Synchronisé avec les derniers changements du code source Orangefox
  - Addon Magisk mis à jour vers Magisk 26.4

# 03-Nov-2023 R12.1 V26
  - Synchronisé avec les derniers changements du code source Orangefox
  - Configuration des propriétés de l’appareil lors du démarrage depuis la base OOS11

# 18-Oct-2023 R12.1 V25
 - Synchronisé avec les dernières modifications de la source Orangefox  
 - Ajout du déchiffrement des données pour Android 14  
 - Correction du problème du module Magisk  
 - Petites corrections de bugs  

# 11-Oct-2023 R12.1 V24  
 - Synchronisé avec les dernières modifications de la source Orangefox  
 - Mise à jour du module Magisk vers Magisk 26.3  

# 19-Sep-2023 R12.1 V23  
 - Ajustement des paramètres de résolution d’écran  
 - Mise à jour avec le dernier noyau Meteoric basé sur OOS13.1  
 - Synchronisé avec les dernières modifications de la source Orangefox  

# 09-Sep-2023 R12.1 V22  
 - Synchronisé avec les dernières modifications de la source Orangefox  

# 02-Aug-2023 R12.1 V21  
 - Synchronisé avec les dernières modifications de la source Orangefox  

# 01-Jul-2023 R12.1 V20   
 - Synchronisé avec les dernières modifications de la source Orangefox  

# 05-Jun-2023 R12.1 V19   
 - Synchronisé avec les dernières modifications de la source Orangefox  

# 19-May-2023 R12.1 V18   
 - Synchronisé avec les dernières modifications de la source Orangefox  

# 01-Apr-2023 R12.1 V17   
 - Passage de Fastboot v1.0 à v1.1  
 - Correction des problèmes d’autorisations lors de la création de fichiers dans Orangefox  
   
# 20-Mar-2023 R12.1 V16   
 - Basé sur OOS13 (devrait fonctionner avec les ROMs ext4 et EROFS)  
 - Correction de la détection du dispositif pour Oneplus9R  
 - Modifications et ajustements divers  
 - Synchronisé avec les dernières modifications de la source Orangefox  
 - Mise à jour avec le dernier noyau Meteoric  

# 02-Fév-2023 R12.1 V15 
 - Mise à jour de mon système de build qui semble avoir corrigé certains bugs dans Orangefox maintenant
   (nettoyage des anciens fichiers zip de logs, désactivation du reflash de l'Orangefox actuel, etc.) tout cela devrait fonctionner maintenant
 - Synchronisé avec les derniers changements fox_12.1
 - Suppression du flag pour TW_USE_FSCRYPT_POLICY car Orangefox devrait désormais le détecter automatiquement
 - Passage au noyau Meteoric (pour Orangefox basé sur OOS13)
 - Correction du transfert de fichiers USB

# 16-Jan-2023 R12.1 V14
 - Correction du formatage des fichiers de Windows à Linux qui causait des problèmes dans l’arbre de périphériques
 - Ajout d’un module flashable Magisk pour Orangefox (merci à MeHigh.G)

# 15-Jan-2023 R12.1 V14 beta 
 - Version mise à jour avec noyau OOS13 F19 OP9R
 - Synchronisé avec les derniers changements fox_12.1
 - Correction des paramètres props pour les différents appareils Kona

# 21-Nov-2022 OrangeFox R12.1 V14 beta
 - Ajustement du script unifié pour OP8 et 8Pro
 - Version mise à jour avec noyau OOS12 c36
 - Version mise à jour avec noyau OOS13 F13
 - Version mise à jour avec mise à jour du noyau EROFS

# 12-Nov-2022 OrangeFox R12.1 V13
 - Synchronisé avec les derniers changements fox_12.1
 - Ajout du support pour Oneplus 8 et Oneplus 8 Pro (le déchiffrement des données ne fonctionne que lors de l’utilisation d’un ROM FBEv2 !)
 - Quelques ajustements de la version EROFS d’Orangefox
 - Ajustement de la longueur du nom de fichier Orangefox pour une meilleure visibilité sur les appareils mobiles
 - Désactivation de la fonction de reflash dans Orangefox
 - Désactivation du changement de l’écran de démarrage
 - Changement de la couleur de fond de l’écran de démarrage en noir
 - Exclusion de /data/fonts de la sauvegarde pour éviter les erreurs lors de la sauvegarde

# 18-Oct-2022 OrangeFox R12.1 V12
 - Synchronisé avec les derniers changements fox_12.1
 - Version mise à jour avec noyau OOS13 OB1
 - Version mise à jour avec noyau OOS12 c35

# 05-Oct-2022 OrangeFox R12.1 V11
 - Synchronisé avec les derniers changements fox_12.1
 - Correction de la non-détection du stockage depuis l’ordinateur sur la version EROFS
 - Mise à jour du module Magisk vers Magisk 25.2

# 02-Oct-2022 OrangeFox R12.1 V10
 - Synchronisé avec les derniers changements de fox_12.1
 - Création d’une version Orangefox séparée pour les ROMs avec système de fichiers EROFS

# 25-Sep-2022 OrangeFox R12.1 V9
 - Synchronisé avec les derniers changements de fox_12.1
 - Mise à jour vers le noyau OOS12 c33

# 13-Sep-2022 OrangeFox R12.1 V8
 - Synchronisé avec les derniers changements de fox_12.1

# 02-Sep-2022 OrangeFox R12.1 V7
 - Synchronisé avec les derniers changements de fox_12.1
 
# 23-Aug-2022 OrangeFox R12.1 V6
 - Cette version d’Orangefox ne doit être flashée en recovery que sur un firmware OOS12 !
 - Synchronisé avec les derniers changements de fox_12.1
 - Ajout du déchiffrement pour Android 13
 - Correction du flash OOS depuis le recovery
 - Suppression du délai d’attente de l’écran de verrouillage
 - Réduction de la luminosité d’écran par défaut

# 18-Aug-2022 OrangeFox R12.1 V5
 - Correction de l’adb sideload

# 15-Aug-2022 OrangeFox R12.1 V4
 - Mise à jour avec les derniers changements de fox_12.1

# 03-Aug-2022 OrangeFox R12.1 V3
 - Corrections et modifications mineures
 - Mise à jour du noyau OOS12
 - Fusion des derniers changements TWRP 12.1

# 27-July-2022 OrangeFox R12.1 V2
 - Cette version devrait maintenant être unifiée pour fonctionner sur Oneplus 8t et 9r
 - Mise à jour avec les changements de la nouvelle version TWRP 3.6.2-12
 - Basée désormais sur OOS12
 - correction du déchiffrement des données sous Android 12

# 17-July-2022 OrangeFox R12.1 
 - Ajout du support pour Android 12 et synchronisation avec les dernières sources TWRP 12.1


##### Crédits
- ApexLegend007 pour l'arbre de périphérique Android 12.1
- The-Incognito pour les arbres de récupération du Oneplus 8T
- YumeMichi pour l'implémentation d'Erofs et autres divers
- bigbiff pour le déchiffrement
- Pranav Talmale pour le déchiffrement
- Systemad pour l'arbre original
- CaptainThrowback pour l'arbre original
- mauronofrio pour l'arbre original
- équipe TWRP
- équipe OrangeFox
- Qnorsten pour la correction OOS




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-19

---