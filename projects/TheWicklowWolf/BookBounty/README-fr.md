# BookBounty

![Build Status](https://github.com/TheWicklowWolf/BookBounty/actions/workflows/main.yml/badge.svg)
![Docker Pulls](https://img.shields.io/docker/pulls/thewicklowwolf/bookbounty.svg)

<img src="/src/static/bookbounty.png" alt="image">


BookBounty is a tool for finding missing Readarr books.


## Run using docker-compose

```yaml
services:
  bookbounty:
    image: thewicklowwolf/bookbounty:latest
    container_name: bookbounty
    ports:
      - 5000:5000
    volumes:
      - /path/to/config:/bookbounty/config
      - /path/to/downloads:/bookbounty/downloads
      - /etc/localtime:/etc/localtime:ro
    restart: unless-stopped

```
---

## Configuration via des variables d'environnement

Certaines valeurs peuvent être définies via des variables d'environnement :

* __PUID__ : L'ID utilisateur pour exécuter l'application. Par défaut `1000`. 
* __PGID__ : L'ID groupe pour exécuter l'application. Par défaut `1000`.
* __readarr_address__ : L'URL pour Readarr. Par défaut `http://192.168.1.2:8787`.
* __readarr_api_key__ : La clé API pour Readarr. Par défaut ` `.
* __libgen_address__ : L'URL pour Library Genesis. L'URL supportée actuellement est `http://libgen.is`.
* __sleep_interval__ : Intervalle de pause entre les téléchargements (secondes). Par défaut `0`.
* __sync_schedule__ : Heures planifiées pour lancer la synchronisation par ex. 14 pour 14h (valeurs séparées par des virgules en format 24h). Par défaut ` `.
* __minimum_match_ratio__ : Pourcentage minimum pour une correspondance. Par défaut `90`.
* __selected_path_type__ : Sélectionnez la structure de téléchargement (fichier ou dossier). Par défaut `file`.
* __search_type__ : Sélectionnez le type de recherche (fiction ou non-fiction). Par défaut `fiction`.
* __library_scan_on_completion__ : Scanner la bibliothèque Readarr à la fin. Par défaut `True`.
* __request_timeout__ : Délai d’attente pour les requêtes (secondes). Par défaut `120`.
* __thread_limit__ : Nombre maximal de threads à utiliser. Par défaut `1`.
* __selected_language__ : Filtrer les téléchargements par langues (langues spécifiques ou toutes). Par défaut `English`. Utilisé si BookBounty ne peut pas obtenir les langues depuis le profil de métadonnées Readarr.
* __preferred_extensions_fiction__ : Filtrer les téléchargements fiction par extension (séparées par des virgules). Par défaut `.epub, .mobi, .azw3, .djvu`.
* __preferred_extensions_non_fiction__ : Filtrer les téléchargements non-fiction par extension (séparées par des virgules). Par défaut `.pdf .epub, .mobi, .azw3, .djvu`.
* __search_last_name_only__ : Utiliser uniquement le nom de famille de l’auteur dans les recherches. Par défaut `False`.
* __search_shortened_title__ : Utiliser un titre raccourci lors de la recherche (supprimer tout après `:`). Par défaut `False`.


## Planification de la synchronisation

Utilisez une liste d’heures séparées par des virgules pour démarrer la synchronisation (ex. `2, 20` lancera une synchronisation à 2h et 20h).
> Note : Il existe une marge de tolérance jusqu’à 10 minutes à partir de l’heure prévue de démarrage.


## Intégration Readarr

Vous avez deux options pour intégrer BookBounty avec Readarr :

1. Mapper directement `/bookbounty/downloads` vers votre dossier principal Readarr et configurer `selected_path_type=folder`.   
   Cette méthode tentera de créer la structure de dossiers correcte (`/author/book/filename.ext`, etc.) avant de télécharger les fichiers directement dans leurs dossiers respectifs.

2. Alternativement, mapper `/bookbounty/downloads` vers un dossier `_unprocessed` et définir `selected_path_type=file`.
   This method downloads all files into a single folder. After a library scan in Readarr, some files may remain unmapped and require manual import.  
   After importing, you can use the "**Rename Files**" function in Readarr to organize the files into the correct folders.

For both methods, setting `library_scan_on_completion=True` automates the import process in Readarr.

**Note:** Readarr does not automatically rename files upon import.


---


<img src="/src/static/dark.png" alt="image">


---


<img src="/src/static/light.png" alt="image">


---

https://hub.docker.com/r/thewicklowwolf/bookbounty



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-14

---