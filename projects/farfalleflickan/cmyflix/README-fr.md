# cmyflix
*Un clone de Netflix, maintenant en C !*

cmyflix est aussi une réécriture complète de mon original ![Myflix](https://github.com/farfalleflickan/Myflix/) utilisant le C, donc il est environ 30x **plus rapide** que l’original tout en conservant presque toutes les fonctionnalités.

cmyflix essaie d’être un "Netflix DIY" assez simple et léger, similaire à Plex, streama ou Emby, pour votre NAS, particulièrement destiné à l’écosystème Raspberry Pi/Odroid/etc. Il n’est pas **destiné** ni **conçu** pour être sophistiqué (si vous avez le matériel et voulez plein de fonctionnalités, optez pour d’autres solutions :) ), mais le strict minimum pour être à peu près joli, rapide et utilisable. Le programme crée des bases de données json qui stockent la localisation des fichiers et les métadonnées, ces bases sont ensuite utilisées pour créer des pages web statiques pouvant être servies depuis n’importe quel serveur web !    

Un grand merci aux bibliothèques suivantes : ![cwalk](https://github.com/likle/cwalk), ![cjson](https://github.com/DaveGamble/cJSON).   
Si vous souhaitez protéger vos fichiers cmyflix par mot de passe, vous voudrez peut-être regarder ![cela](https://github.com/farfalleflickan/JSONlogin) !  

Vous aimez mon travail ? N’hésitez pas à faire un don :)  
[<img src="https://raw.githubusercontent.com/andreostrovsky/donate-with-paypal/master/dark.svg" alt="donation" width="150"/>](https://www.paypal.com/donate?hosted_button_id=YEAQ4WGKJKYQQ)

# Captures d’écran :  
Page des séries TV  
![Séries TV](https://github.com/farfalleflickan/Myflix/blob/master/screenshots/ec53e53f252f908bc8bac7f8c4486790.jpg)   

Modal saison/épisode de série TV  
![Épisodes de série TV](https://github.com/farfalleflickan/Myflix/blob/master/screenshots/fb31129a22d81b732ce88f02cae27fea.jpg)  


Lecteur d’épisode de série TV  
![Lecteur d’épisode de série TV](https://github.com/farfalleflickan/Myflix/blob/master/screenshots/102b3df4924efeae7476d6ceee79bec9.png)

Page des films  
![Films](https://github.com/farfalleflickan/Myflix/blob/master/screenshots/d4271907a9af78d8dd84f3941ca1e56a.jpg)  

Lecteur de films  
![Lecteur de films](https://github.com/farfalleflickan/Myflix/blob/master/screenshots/2eb41c935d1c11e19adb66466bcdf97e.png)

# Comment compiler :  
Compilez simplement en lançant make, les bibliothèques requises sont (sous Ubuntu) `libbsd-dev libcjson-dev libcurl4-openssl-dev`.

# Comment installer :  
Installez soit depuis les sources avec make install OU utilisez un paquet précompilé depuis l’onglet release.

Attention, le fichier `deb` précompilé est construit avec le backend `libcurl4-openssl-dev` par défaut.

# Prérequis pour lancer :  
cmyflix utilise libcjson(>=1.7.15), libcurl(>=7.68), imagemagick, ffmpeg et une clé API TMDB. Notez également que cmyflix recherche des fichiers `mp4`, `mkv`, `ogv` et `webm` en raison de l’utilisation de HTML5 et des formats supportés.
# Configuration & utilisation :
Pour commencer, cmyflix cherche d'abord `cmyflix.cfg` dans le même dossier que le binaire, puis dans `$HOME/.config/cmyflix/` et enfin dans `/etc/cmyflix/`. Il en va de même pour le dossier `html` et son contenu.

Pour plus d'options et d'informations, consultez le fichier de configuration ou le menu d'aide, accessible via l'option `--help`.

# Structure des dossiers attendue
cmyflix est un peu exigeant dans le sens où il attend que tout soit organisé en dossiers.
Pour les séries TV, il attend que chaque série soit dans son propre dossier, avec un sous-dossier pour chaque saison (plus un "Season.Extras" pour tout le reste). Exemple : `/path/to/files/Name.of.TV.show/Season.1/Name.Of.TV.show.S01E01.mp4`.
Pour les films, ils devraient idéalement être dans un sous-dossier pour chaque film, exemple : `/path/to/files/Name.of.Movie/Name.Of.Movie.mp4`. Notez que plusieurs films peuvent techniquement être dans le même sous-dossier, comme dans `/path/to/files/Movies/Star.Wars/Revenge.of.The.Sith.mp4` et `/path/to/files/Movies/Star.Wars/Empire.Strikes.Back.mp4`.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-27

---