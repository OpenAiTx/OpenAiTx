<table><tr width=64px><td><img height=64px src="https://user-images.githubusercontent.com/526829/169241046-3087a41d-9606-43ab-90ae-ee0055bef039.png"/></td><td><h1>godot-version-manager</h1></td></tr></table>
  
Téléchargez, installez et gérez n'importe quelle version de Godot Engine à partir d'une application simple. 

<img alt="capture d'écran avec thème clair" src="https://github.com/user-attachments/assets/5b504fa3-59ea-46c8-bb78-6a743759d984" />
<img alt="capture d'écran avec thème sombre" src="https://github.com/user-attachments/assets/08ff0100-fbd5-40be-a8a4-80bbb186d37e" />

## Installation
### Windows :
Décompressez et double-cliquez. (Sur Windows XP, veuillez vous assurer que Powershell est installé)
### Linux :
Décompressez et double-cliquez. L'extraction des versions téléchargées nécessite `unzip` qui, s'il n'est pas installé, devrait être disponible dans le dépôt de votre distribution
### OSX :
- Devrait s'extraire automatiquement après téléchargement
- Vous devez exécuter `sudo xattr -r -d com.apple.quarantine chemin/vers/Godot Version Manager.app` car les binaires non signés sont marqués comme non fiables sinon. N'hésitez pas à compiler vous-même le projet si vous ne faites pas confiance aux binaires précompilés
- Double-cliquez sur Godot Version Manager.app

## Fonctionnalités
- Téléchargez et installez automatiquement n'importe quelle version de Godot depuis un menu déroulant. (nécessite powershell pour l'extraction)
- Affichez ou masquez les versions alpha, beta, rc et dev dans le menu déroulant de téléchargement. 
- Ajoutez vos propres binaires n'importe où sur votre système de fichiers. 
- Icônes colorées pour distinguer facilement les versions stables, rc, beta, alpha et master. 
- Clic droit pour supprimer une entrée de la liste
- Glisser-déposer pour réorganiser les entrées
- Glissez-déposez un fichier project.godot ou un dossier de projet Godot pour ajouter un projet et le lancer avec une version spécifique
- Fil d'actualités depuis godotengine.org./news

## F.A.Q
**Q : Où sont enregistrés les binaires téléchargés ?**

R : Ils sont enregistrés dans `user://versions` qui varie selon votre plateforme. Sous Windows, c'est %appdata%/Godot/app_userdata/Godot Version Manager/versions

**Q : En quoi cela diffère-t-il de Hourglass ou Godot Manager ?**

R :
 - [Hourglass](https://hourglass.jwestman.net/) est un projet beaucoup plus mature et riche en fonctionnalités avec un meilleur support de la gestion de projets. Peut-être que le seul avantage de GVM est qu'il télécharge aussi des extraits d'actualités depuis le site officiel :)
 - [Godot Manager](https://github.com/eumario/godot-manager) semble être une alternative assez mature et riche en fonctionnalités également.
 - [Godots](https://github.com/MakovWait/godots) est une nouvelle alternative (août 2023) qui semble plaire à beaucoup de monde.
 - [GodotEnv](https://github.com/chickensoft-games/GodotEnv) et [godot-version-manager](https://github.com/gaheldev/godot-version-manager) sont des alternatives uniquement en CLI.
 - [Godot Launcher](https://github.com/sebastianoboem/godot-launcher) est une alternative basée sur python avec support pour les extensions et la gestion du cache.
 - [gdvm](https://github.com/adalinesimonian/gdvm) est un autre gestionnaire de versions en ligne de commande développé avec Rust.

## LICENCE
Sous licence MIT (voir LICENSE.md)
Droits d'auteur ©️2022 Lisandro Lorea et contributeurs

Police Lilita One ©️2011 Juan Montoreano
<a href="https://www.flaticon.com/free-icons/exe" title="exe icons">Icônes Exe créées par Freepik - Flaticon</a>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-16

---