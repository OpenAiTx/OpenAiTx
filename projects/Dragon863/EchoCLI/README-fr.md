> [!IMPORTANT]  
> Si vous cherchez à rooter votre echo, ce projet est désormais obsolète ; veuillez utiliser la solution documentée [ici](https://xdaforums.com/t/unlock-root-twrp-unbrick-amazon-echo-dot-2nd-gen-2016-biscuit.4761416/) à la place. Un grand merci à tous ceux qui ont rendu cela possible, ça a été un vrai plaisir de travailler sur ce projet ! :)  

# EchoCLI  
Une solution de root tethered pour votre echo dot 2ème génération.  
Pour commencer, lancez `main.py`  
<br>  

[<kbd> <br> Comment ça marche ? <br> </kbd>](https://dragon863.github.io/blog/echoroot.html)  

## Avis  
- En raison des mises à jour logicielles poussées constamment, je ne peux pas garantir que cela fonctionnera pour votre echo. Si vous rencontrez des problèmes, n’hésitez pas à me contacter, et si vous trouvez un bug, les pull requests sont les bienvenues.  
- Il est **fortement** recommandé d’exécuter ceci sur une machine Linux, car je ne peux pas le tester sous Windows et il n’y a aucune garantie qu’il n’y ait pas de bugs spécifiques à Windows.  

> **Avertissement**  
>  
> **Ceci est une solution de root TETHERED** Il est _recommandé_ de bloquer les serveurs OTA d’amazon (https://d1s31zyz7dcc2d.cloudfront.net et https://d1s31zyz7dcc2d.cloudfront.prod.ota-cloudfront.net) afin d’éviter que les mises à jour ne corrompent ou ne suppriment le root sur votre appareil. Je ne suis pas responsable des dommages causés à votre appareil.  

## Fonctionnalités  
- Shell ADB rooté via USB ou Wi-Fi  
- Enregistrer l’audio depuis l’appareil  
- Utiliser votre Echo comme indicateur pour Home Assistant sans internet  
- Restaurer votre appareil à la configuration d’usine  

## Installation  
- Ce projet nécessite python 3.  
- Je recommande d’utiliser Linux pour exécuter ce programme. Veuillez vous assurer que ModemManager est désactivé si vous l’avez installé.  
Installez les dépendances avec `pip` :
```sh
pip install -r requirements.txt
```
- Vous aurez également besoin de fastboot et ADB, il existe un bon guide pour installer ces outils [ici](https://wiki.lineageos.org/adb_fastboot_guide). Après les avoir téléchargés, vous pouvez définir le chemin exécutable dans le fichier config.json.  
- Veuillez vous assurer que le câble micro USB que vous utilisez pour connecter votre echo dot est un câble de données et non une variante uniquement pour l'alimentation.  

## Documentation  
Vous pouvez trouver comment cet outil fonctionne sur [mon site web](https://dragon863.github.io/blog/echoroot.html).  

Une fois que vous avez rooté l'appareil, un fichier appelé `preloader_no_hdr.bin` sera généré. Pour démarrer l'appareil, vous devrez installer [mtkclient](https://github.com/bkerler/mtkclient), copier le fichier dans son répertoire et exécuter `python mtk plstage --ptype=kamakiri2 --preloader=preloader_no_hdr.bin`. Remplacez `python` par `python3` selon la version de python que vous avez installée.  

## Indicateur Home assistant  
Lors de l'utilisation de la fonction indicateur home assistant, je recommande d'utiliser un raspberry pi zero w ou un autre petit SBC pour exécuter le serveur python flask, et démarrer l'appareil. Vous pouvez utiliser crontab pour automatiser cela au démarrage en utilisant mtkclient.  

## Echo briqué ?  
Suivez le guide [ici](https://github.com/Dragon863/EchoCLI/blob/main/debrick.md) pour utiliser mtkclient afin de débriquer un echo rooté ou partiellement rooté.  

## Remerciements  

Ce projet n'aurait pas été possible sans :  
- [j10hx40r](https://forum.xda-developers.com/m/j10hx40r.11878441/) - Pour m'avoir aidé à rooter initialement mon appareil, repenser le système de patch et m'avoir montré comment utiliser fos_flags en combinaison et, de manière générale, m'avoir orienté vers les bonnes ressources.  
- [Amonet de xyzz](https://github.com/xyzz/amonet) - C'est l'exploit que j'ai adapté pour cet appareil, y compris l'exploit bootrom.  
- [chaosmaster](https://github.com/chaosmaster) - A écrit beaucoup de code amonet utile dont j'ai utilisé plusieurs extraits, notamment pour corriger mon GPT.  

## Contactez-moi  
- Vous pouvez m'envoyer un email à dragon863.dev@gmail.com  
- Vous pouvez démarrer une conversation sur [XDA](https://forum.xda-developers.com/m/lemon86.12487447/)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-14

---