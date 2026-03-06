# Letterboxd-to-IMDb

[![GitHub stars](https://img.shields.io/github/stars/TobiasPankner/Letterboxd-to-IMDb.svg?style=social&label=Star)](https://GitHub.com/TobiasPankner/Letterboxd-to-IMDb/stargazers/)
[![Donate](https://img.shields.io/badge/Donate-PayPal-green.svg)](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=3TU2XDBK2JFU4&source=url)

- [Prérequis](#prérequis)
- [Exécuter le script](#exécuter-le-script)
- [Obtenir le cookie IMDb](#obtenir-le-cookie-imdb)
- [Cas d'utilisation courants](#cas-dutilisation-courants)
- [Options en ligne de commande](#options-en-ligne-de-commande)

Script Python pour importer vos films Letterboxd dans IMDb.  

Comment ça fonctionne :  
Le script "visite" d'abord tous les liens Letterboxd dans votre fichier zip et récupère la page IMDb correspondante. De cette façon, on s'assure que le bon film est noté.  
Ensuite, votre cookie est utilisé pour authentifier une requête vers l'API interne IMDb GraphQL de notation.  

**Tutoriel vidéo** sur comment l'utiliser : <https://www.youtube.com/watch?v=KF7cfdUTEgw>

## Exécuter ce script en ligne (Python non requis)

[![Run Script](https://simple-script.com/api/badge/letterboxd-to-imdb)](https://simple-script.com/app/letterboxd-to-imdb)

## Prérequis  
  
- Python 3 ([Télécharger](https://www.python.org/downloads/))
- Compte [Letterboxd](https://letterboxd.com/)
- Compte [IMDb](https://www.imdb.com/)

## Exécuter le script

 1. Exportez vos notes et votre liste de suivi Letterboxd ([Comment faire](https://listy.is/help/how-to-export-letterboxd-watchlists-reviews/))
 2. [Obtenez le cookie IMDb](#obtenir-le-cookie-imdb) et enregistrez-le sous "cookie.txt" dans le dossier du script
 3. Installez les dépendances : `pip install -r requirements.txt`
 4. Lancez letterboxd2imdb.py : `python letterboxd2imdb.py -f <VOTRE FICHIER ZIP>.zip`

[Cas d'utilisation courants](#cas-dutilisation-courants)

## Obtenir le cookie IMDb

**Traitez ce cookie comme votre mot de passe !**

  1. Connectez-vous à votre compte IMDb
  2. Ouvrez les outils de développement Chrome -> Réseau
  3. Filtrez par Fetch/XHR
  4. Actualisez la page
  5. Copiez le cookie de l’une des requêtes (clic droit -> Copier la valeur)
  
  ![Exemple](https://imgur.com/chRo9wj.jpg)  

## Cas d’utilisation courants

**Transférez vos notes et votre liste de suivi :**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -w`

**Transférez vos films vus avec une note de 5/10 :**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -r 5`

**Créez une liste IMDb pour les films vus non notés :**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -l`

**Créez une liste IMDb personnalisée pour les films vus non notés :**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -l --list-name "Mes films Letterboxd"`

## Options en ligne de commande

```
usage: letterboxd2imdb.py [-h] -f ZIPFILE [-p PARALLEL] [-c] [-r RATING] [-w] [-l] [--list-name LIST_NAME]

Imports your Letterboxd ratings and watchlist into IMDb. Can also create custom lists for unrated movies.

required arguments:
  -f ZIPFILE            The exported zip file from letterboxd

options:
  -h, --help            show this help message and exit
  -p PARALLEL           Urls to be processed in parallel (valid: 1 to 20)
  -c                    Add this flag to disable the history
  -r RATING             The rating to give watched but unrated movies. By default they are ignored (valid: 1 to 10)
  -w                    Add this flag to also transfer your watchlist
  -l                    Create an IMDb list for watched but unrated movies instead of rating them
  --list-name LIST_NAME Name for the IMDb list to create for unrated movies (default: 'Watched on Letterboxd - Unrated')
```
`-p` : Peut être utilisé si vous souhaitez accélérer le processus, si vous le réglez trop haut, vous risquez d’être limité par le taux. Par défaut : 5  
`-c` : Si l’historique pose problème, vous pouvez ajouter ce flag pour le désactiver.  
`-r` : Peut être utilisé pour noter les films vus mais non notés. Comme IMDb n’a pas d’option pour « juste regardé », une note par défaut doit être spécifiée  
`-w` : Sert aussi à transférer votre liste de surveillance  
`-l` : Crée une liste IMDb pour les films vus mais non notés au lieu de leur attribuer des notes arbitraires. Cela préserve des données de notation propres tout en suivant les films vus.  
`--list-name` : Spécifie un nom personnalisé pour la liste IMDb créée avec l’option `-l`. Par défaut : « Watched on Letterboxd - Unrated »

**Remarque :** Les options `-r` et `-l` sont mutuellement exclusives. Vous pouvez soit attribuer des notes par défaut aux films non notés (`-r`), soit créer une liste pour eux (`-l`), mais pas les deux.
  
## Exemples d’utilisation  
  
**Import basique (notes uniquement) :**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip`  
*Importe uniquement vos films notés de Letterboxd vers IMDb. Les films non notés sont ignorés.*  
  
**Importer notes et liste de surveillance :**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -w`  
*Transfère à la fois vos notes de films et votre liste de surveillance de Letterboxd vers IMDb.*  
  
**Attribuer une note par défaut aux films non notés :**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -r 7`  
*Importe vos notes et attribue une note par défaut de 7/10 à tous les films vus mais non notés.*  
  
**Créer une liste pour les films non notés :**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -l`  
*Crée une liste IMDb appelée « Watched on Letterboxd - Unrated » pour les films que vous avez vus mais que vous n’avez pas notés.*  
  
**Créer une liste personnalisée pour les films non notés :**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -l --list-name "My Letterboxd Backlog"`  
*Crée une liste IMDb avec un nom personnalisé pour vos films vus non notés.*  
  
**Traitement rapide avec parallélisation accrue :**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -p 15`  
*Traite 15 films en parallèle pour une exécution plus rapide (attention aux limitations de taux).*  
  
**Transfert complet avec paramètres personnalisés :**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -p 10 -r 5 -w`  
*Traitement rapide (10 en parallèle), importe les notes et la liste de surveillance, attribue une note de 5/10 aux films non notés.*  
  

**Créer une liste personnalisée avec watchlist et traitement rapide :**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -p 10 -l --list-name "Mes films Letterboxd" -w`  
*Traitement rapide, importe la watchlist, et crée une liste personnalisée pour les films non notés.*  
  
**Désactiver l'historique (dépannage) :**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -c`  
*Exécute sans utiliser la fonction historique, utile si vous rencontrez des problèmes avec le fichier historique.*  
  
**Approche conservatrice (lent mais sûr) :**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -p 1 -w`  
*Traite un film à la fois pour éviter tout problème de limitation de débit lors de l’import des notes et de la watchlist.*


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-06

---