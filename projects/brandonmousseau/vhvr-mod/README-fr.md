# VHVR-Mod  
Ceci est un mod expérimental pour le jeu PC Valheim qui ajoute un support VR natif utilisant Unity et SteamVR avec OpenVR.  

Téléchargez le mod sur [Nexus Mods](https://www.nexusmods.com/valheim/mods/847) !  

Consultez le journal de développement des progrès sur [YouTube](https://www.youtube.com/playlist?list=PL9EDvRwka57-swWbcOAq0lhIp5jSFPg-u).  

Rejoignez le [Discord Flatscreen to VR Modding](https://discord.gg/ZFSCSDe)  

## Que contient ce package ?  
### Projet Unity  
Ce projet existe principalement comme générateur d’assets pour produire les AssetBundles nécessaires utilisés par le mod ainsi que comme moyen de construire les bibliothèques SteamVR et Unity XR dans l’environnement approprié.  

Plusieurs assets sont générés dans le package Unity, mais les plus importants incluent :  
* Préfabriqué SteamVR Player : Ce préfabriqué est une hiérarchie d’objets Unity GameObject qui inclut tous les scripts nécessaires pour utiliser correctement SteamVR. Il comprend une caméra dans la hiérarchie qui sera remplacée par celle du jeu principal. La caméra est configurée pour utiliser la 3D stéréoscopique affichée dans le HMD.  
* Assets Unity et OpenVR : Ce sont des assets requis pour démarrer correctement le moteur XR de Unity lors du lancement du jeu.  
* [Amplify Occlusion](https://github.com/AmplifyCreations/AmplifyOcclusion) post-processeur graphique : Utilisé comme substitut plus performant à l’effet graphique SSAO intégré au jeu.  

### Projet C# ValheimVRMod  
Ce projet contient la majeure partie du code du mod. Il inclut des classes/scripts Unity MonoBehaviour qui implémentent les fonctionnalités suivantes :  
* initialiser le moteur XR Unity/OpenVR  
* instancier les préfabriqués SteamVR à partir des AssetBundles  
* remplacer la caméra principale du jeu par la caméra VR et la positionner correctement  
* traduire l’interface graphique du jeu en VR  
* implémenter les contrôles de mouvement (en cours)  

### Exigences  
Ce mod nécessite [BepInExPack Valheim](https://valheim.thunderstore.io/package/denikson/BepInExPack_Valheim/). BepInEx est un framework de modding pour les jeux Unity qui permet aux moddeurs d’injecter leur code dans le runtime du jeu. Il inclut également [Harmony](https://harmony.pardeike.net/articles/intro.html), un outil utilisé pour patcher les méthodes existantes dans les bibliothèques C#.  

De plus, vous avez besoin d’un HMD compatible OpenVR/SteamVR.  

### Autres informations  
Ceci est un mod expérimental et contiendra presque certainement de nombreux bugs et glitches. De plus, Valheim est actuellement un jeu en accès anticipé, il y a donc une forte probabilité que des patchs soient publiés pour le jeu et cassent ce mod. Merci de faire preuve de patience pendant que les correctifs sont développés et n’hésitez pas à signaler tout problème que vous rencontrez :)  

Comme Valheim n’a pas été conçu pour la VR, cette implémentation ne sera pas aussi confortable qu’un jeu conçu pour la VR. Si la VR a tendance à vous rendre nauséeux, alors ce mod n’est probablement pas fait pour vous.  


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-12

---