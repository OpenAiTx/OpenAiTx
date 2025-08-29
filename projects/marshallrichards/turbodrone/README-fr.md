# Turbodrone
API et client rétroconçus pour contrôler certains des drones "jouets" les plus vendus à environ 50 $ sur Amazon depuis un ordinateur, remplaçant les applications mobiles propriétaires fournies.

![S20 Drone Short Clip](https://raw.githubusercontent.com/marshallrichards/turbodrone/master/docs/images/s20-drone-short-clip-small.gif)

## Introduction
De nos jours, il existe des drones "jouets" incroyablement bon marché disponibles sur Amazon qui sont en fait des clones simplifiés des premiers DJI Mavic. Seulement environ 50 $ pour avoir une caméra 1080p pour le FPV et l'enregistrement, un petit capteur optique de flux vers le bas pour la position et le maintien de l'altitude, et un profil de vol bien réglé dès la sortie de la boîte. Le seul problème avec ces drones est qu'ils fonctionnent avec un firmware propriétaire et ne peuvent être contrôlés que par une application mobile personnalisée. J'ai pensé qu'il serait intéressant de libérer certains de ces drones de leur "prison" et d'écrire une API et un client pour accéder au flux vidéo et envoyer des commandes de contrôle au drone en rétroconcevant le fonctionnement des applications mobiles. Ainsi, vous pouvez transformer un drone "jouet" très performant à 50 $ en un appareil pouvant être contrôlé de manière programmatique et utilisé pour toutes sortes d'applications et d'expériences.

## Matériel
* Drone caméra WiFi (classés par ordre de recommandation) :

    | Marque      | Numéro(s) de modèle    | Compatibilité | Lien d'achat                                               | Notes |
    |------------|-----------------|---------------|-------------------------------------------------------------|-------|
    | Karuisrc | K417 | Testé | [Amazon](https://www.amazon.com/Electric-Adjustable-AIdrones-Quadcopter-Beginners/dp/B0CYPSJ34H/) | Mon préféré en ce moment. Le seul de la liste avec moteurs brushless ! La qualité de fabrication est fantastique. |
    | Loiley     | S29             | Testé    | [Amazon](https://www.amazon.com/Beginners-Altitude-Gestures-Adjustable-Batteries/dp/B0CFDVKJKC)                  | Meilleure qualité de fabrication, dispose d’un servo pour incliner la caméra (_pas encore implémenté dans l’API_)|
    | Hiturbo    | S20             | Testé    | [Amazon](https://www.amazon.com/dp/B0BBVZ849G), [Autre annonce Amazon](https://www.amazon.com/Beginners-Foldable-Quadcopter-Gestures-Batteries/dp/B0D8LK1KJ3)                  | Plateforme de test originale, excellente qualité de fabrication|
    | FlyVista | V88 | Testé | [Amazon](https://www.amazon.com/dp/B0D5CXY6X8) | |
    | ? | D16/GT3/V66 | Testé | le moins cher sur [Aliexpress](https://www.aliexpress.us/item/3256808590663347.html), [Amazon](https://www.amazon.com/THOAML-Batteries-Altitude-Headless-360%C2%B0Flip/dp/B0F1D6F62J/) | Clone DJI Neo 20 % plus petit. Vraiment adapté seulement pour vol intérieur. 
    | Plusieurs Marques | E58 | Testé | [Amazon](https://www.amazon.com/Foldable-Quadcopter-Beginners-Batteries-Waypoints/dp/B09KV8L7WN/) |  |
    | Plusieurs Marques | E88/E88 Pro | Suspecté | [Amazon](https://www.amazon.com/Foldable-Camera-Quadcopter-Altitude-Beginner/dp/B0DZCLFQXN) | |
    | Plusieurs Marques | E99/E99 Pro | Suspecté | [Amazon](https://www.amazon.com/LJN53-Foldable-Drone-Dual-Cameras/dp/B0DRH9C6RF) | |
    | Swifsen | A35 | Suspecté | [Amazon](https://a.co/d/bqKvloz) | Très petit drone "jouet"|
    | Inconnu | LSRC-S1S | Suspecté | | mentionné dans un autre travail de rétroconception pour l’application WiFi UAV|
    | Velcase    | S101            | À FAIRE | [Amazon](https://www.amazon.com/Foldable-Beginners-Quadcopter-Carrying-Positioning/dp/B0CH341G5F/)  | qualité de fabrication inférieure, batterie et hélices plus petites que S29 & S20|
    | Redrie | X29 | À FAIRE | [Amazon](https://www.amazon.com/Adults-1080P-Foldable-Altitude-Auto-Follow-Batteries/dp/B0CZQKNYL5) | En cours de travail sur celui-ci|

    _**Testé** signifie que le drone a été physiquement utilisé avec turbodrone pour assurer sa compatibilité._

  _**Suspecté** signifie que l’APK du drone semble utiliser les mêmes packages et bibliothèques qu’un des drones testés._

  _**À FAIRE** signifie que l’APK fonctionne avec des paquets et protocoles différents et devra être ajouté comme nouvelle implémentation dans l’API._

* Dongle WiFi ([recommandé ALFA Network AWUS036ACM](https://www.amazon.com/Network-AWUS036ACM-Long-Range-Wide-Coverage-High-Sensitivity/dp/B08BJS8FXD) ou similaire) 
  * Le drone diffuse son propre réseau WiFi, votre ordinateur devra s’y connecter.
  * Pas strictement nécessaire car vous pouvez utiliser la radio WiFi intégrée de votre ordinateur pour vous connecter au réseau du drone, mais c’est pratique pour rester connecté à Internet pendant le vol.


## Installation
Passez au répertoire `backend`
```
cd backend
```

Ajouter venv
```
python -m venv venv
source venv/bin/activate
```

Installer les dépendances
```
pip install -r requirements.txt
```
_Si_ vous êtes sous Windows, vous devrez installer manuellement la bibliothèque `curses`.

```
pip install windows-curses
```

Ouvrez une nouvelle fenêtre de terminal et installez les dépendances pour le frontend.  
_Assurez-vous d'avoir Node.js 20+ installé._
```
cd frontend
npm install
```

Assurez-vous que le dongle WiFi est branché, que le drone est allumé, et connectez-vous au réseau "BRAND-MODEL-XXXXXX" avant de continuer.

Créez un fichier `.env` dans le répertoire `backend`. Ajoutez un DRONE_TYPE en fonction du drone que vous possédez :
```
# For "com.vison.macrochip" (s2x) based drones like S20 and S29:
DRONE_TYPE=s2x
# For WiFi UAV-based drones like V88 and D16:
# DRONE_TYPE=wifi_uav 
```

Lancer le backend : 
```
uvicorn web_server:app
```

Dans un terminal séparé, lancez le client web frontend :
```
npm run dev
```

Ouvrez le client web qui sera accessible à `http://localhost:5173` et vous devriez voir le flux vidéo du drone et pouvoir le contrôler.

Pour contrôler via une manette de jeu, branchez-la et bougez les joysticks pour qu'elle soit détectée, puis appuyez sur le bouton de basculement pour passer du contrôle clavier à la manette.

Assurez-vous de voler dans une zone sûre, de préférence en extérieur avec peu de vent. Notez que le bouton "Atterrir" est _actuellement_ plutôt un bouton d'arrêt d'urgence qui arrête immédiatement les moteurs du drone.


## Statut
La logique de reconnexion a été résolue récemment.

Flux vidéo : stable.

Contrôles : grandement améliorés via le client web. L’implémentation pour les drones WiFi UAV pourrait nécessiter quelques ajustements.

Client Web : support pour diverses entrées comme clavier, manettes de jeu et souris ThinkPad TrackPoint (lol).

Travail en cours pour ajouter le support de plus de drones issus de la [liste des drones les plus vendus sur Amazon](https://www.amazon.com/best-selling-drones/s?k=best+selling+drones).


## Contribuer
Pour contribuer au support d’un nouveau drone "jouet", téléchargez l’APK que le drone utilise sur un site miroir et commencez le rétro-engineering en décompilant en fichiers Java avec [jadx](https://github.com/skylot/jadx).
Ensuite, regardez le `AndroidManifest.xml` et voyez si vous pouvez trouver les classes qui sont les points d’entrée de l’application. Cherchez l’utilisation de ports ou de protocoles explicitement mentionnés comme TCP ou UDP. La plupart de ces apps font la communication réelle et le traitement du flux vidéo dans des bibliothèques natives C++ embarquées dans l’APK. Vous pouvez utiliser un outil comme Ghidra pour décompiler les bibliothèques natives et voir si vous découvrez quelque chose d’utile. Pour le traitement du flux vidéo, vous devez déterminer quel format il utilise, par exemple JPEG, YUV, etc., et aussi s’il utilise une compression ainsi que la structure des octets lors de la reconstitution d’une image à partir de paquets.
De plus, Wireshark est votre allié pour comprendre les paquets de données brutes envoyés et reçus par l’app. Regardez cette [vidéo](https://x.com/marshallrichrds/status/1923165437698670818) pour un aperçu du processus de rétro-engineering utilisé pour ajouter le support du drone Hiturbo S20.

Une fois que vous avez compris les protocoles et le traitement pour la télécommande et la vidéo, créez un petit programme de test et ajoutez-le au répertoire `experimental` si vous souhaitez que d’autres puissent l’essayer.
Ensuite, vous pouvez travailler sur une implémentation compatible avec l’architecture back-end existante ; des exemples sont les implémentations rétro-conçues `s2x` et `wifi_uav`.


## Support Expérimental
Pour les drones et applications avec support limité qui ne sont pas encore pleinement intégrés à Turbodrone, consultez le répertoire `experimental`.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-29

---