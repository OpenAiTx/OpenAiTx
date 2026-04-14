# <img src="https://raw.githubusercontent.com/DJS91/HAMusicAssistantJukebox/main/logo.png" width="25" height="25"> Intégration Music Assistant Jukebox (Obsolète)

## Avis : cette intégration n'est plus activement maintenue.

Music Assistant dispose désormais d'un plugin qui doit être utilisé à la place et offre beaucoup des mêmes fonctionnalités.  
Voir https://beta.music-assistant.io/plugins/party-mode/

---

Une intégration Home Assistant qui fournit un système de demande de chansons basé sur le web et qui s'intègre avec Music Assistant pour créer une expérience de jukebox interactive pour les invités !

![Interface Jukebox](https://raw.githubusercontent.com/DJS91/HAMusicAssistantJukebox/main/showcase.avifs)

## Fonctionnalités
- Recherche de chansons en temps réel sur tous les fournisseurs Music Assistant connectés  
- Design minimaliste et réactif avec affichage de la pochette d'album  
- Vérifiez ce qui est en cours de lecture et ce qui suit en temps réel.  
- Pas de connexion requise pour les invités, il suffit de partager l'URL  
- Gestion de la file d'attente via les entités Home Assistant  
- Mise en file automatique d'une playlist de fête par défaut lorsque la file de demandes est vide  
- Contrôle de la fréquence de mise en file (limiter le spam de la file)  
- Contrôle d'accès via Home Assistant  
- Création/révocation automatique des jetons d'accès pour la sécurité

Rendez-vous sur [Discussions / FeatureRequests](https://github.com/DJS91/HAMusicAssistantJukebox/discussions) si vous souhaitez demander de nouvelles fonctionnalités ou participer à la discussion générale !

## Prérequis

Avant d'installer cette intégration, assurez-vous d'avoir :  
- Une instance Home Assistant avec l'intégration [Music Assistant](https://github.com/music-assistant/hass-music-assistant)  
- Le module complémentaire Music Assistant Server dans Home Assistant (les instances HA/MA hébergées séparément peuvent ne pas fonctionner)  
- Un fournisseur de musique pris en charge configuré dans Music Assistant (par exemple Spotify, Apple Music, etc.)  
- Une entité lecteur multimédia configurée dans Home Assistant

## Installation

### HACS (recommandé)  
[![Ouvrez votre instance Home Assistant et ouvrez un dépôt dans le Home Assistant Community Store.](https://my.home-assistant.io/badges/hacs_repository.svg)](https://my.home-assistant.io/redirect/hacs_repository/?owner=DJS91&repository=HAMusicAssistantJukebox&category=Integration)

ou
1. Ajoutez ce dépôt à HACS en tant que dépôt personnalisé  
   - HACS > Menu > Dépôts personnalisés  
   - URL : `https://github.com/DJS91/HAMusicAssistantJukebox`  
   - Catégorie : Intégration  
2. Cliquez sur Installer  
3. Redémarrez Home Assistant  

### Installation manuelle  
1. Téléchargez la dernière version  
2. Copiez le dossier `custom_components/music_assistant_jukebox` dans votre dossier `custom_components` de Home Assistant  
3. Redémarrez Home Assistant  

## Configuration  

1. Allez dans Paramètres > Appareils & Services  
2. Cliquez sur "Ajouter une intégration"  
3. Recherchez "Music Assistant Jukebox"  
4. Sélectionnez votre instance Music Assistant et l’entité du lecteur média  
5. Allez dans Paramètres > Automatisations & Scènes > + Créer une automatisation  
6. Sélectionnez "Music Assistant Jukebox Controller" dans la liste.  
7. Entrez la même entité de lecteur média que l’étape 4 et saisissez le nom de votre playlist par défaut de Music Assistant, puis cliquez sur Enregistrer.  

## Utilisation  
Activez le juke-box en utilisant l’interrupteur "JukeBox : Autoriser l’accès".  

Accédez au juke-box via le nouveau panneau latéral "Music Assistant Jukebox" OU  

Scannez l’entité QR Code de votre choix OU  

Accédez directement à l’interface du juke-box à :
```
http://homeassistant:8123/local/jukebox/jukebox.html
```
## Entités
L’intégration ajoute ces entités à Home Assistant :

### Interrupteurs
- `switch.jukebox_queue` : Activer/désactiver la mise en file d’attente des chansons (Pas de contrôle manuel requis. Géré par l’automatisation.)
- `switch.jukebox_allow_access` : Activer/désactiver l’accès à l’interface du jukebox
- `switch.music_assistant_jukebox_jukebox_play_music_on_start` : Activer/désactiver la lecture automatique de la playlist par défaut au démarrage du jukebox.
  
### Nombre
- `number.jukebox_queue_length` : Affiche la longueur actuelle de la file d’attente (Pas d’ajustement manuel requis, géré par l’automatisation)
- `number.music_assistant_jukebox_jukebox_queuing_delay` : Définit un délai entre les demandes de chansons pour les invités (secondes) (0 = désactivé)
  
### Capteur
- `music_assistant_jukebox_external_qr_code` : Image du code QR d’accès externe à l’interface Jukebox pour un partage facile sur les tableaux de bord pour les utilisateurs hors de votre réseau
- `music_assistant_jukebox_internal_qr_code` : Image du code QR d’accès interne à l’interface Jukebox pour un partage facile pour les utilisateurs de votre réseau

## Modèle d’automatisation

L’intégration inclut un modèle d’automatisation qui gère :
- Le suivi de la longueur de la file d’attente
- La playlist par défaut en secours
- Le contrôle d’accès
- Le contrôle du lecteur média

Pour utiliser le modèle :
1. Allez dans Paramètres > Automatisations & Scènes
2. Cliquez sur « + Créer une automatisation »
3. Sélectionnez « Contrôleur Music Assistant Jukebox »
4. Configurez :
   - Lecteur média : Sélectionnez votre lecteur média Music Assistant
   - Playlist par défaut : Entrez le nom de votre playlist de secours

## Crédits
Un grand merci à :
- [OddPirate](https://github.com/TheOddPirate) pour ses contributions à la transformation de ceci en intégration.

- [PilaScat](https://github.com/PilaScat) pour ses contributions à l’assainissement, à la finition et aux améliorations de l’interface utilisateur.




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-14

---