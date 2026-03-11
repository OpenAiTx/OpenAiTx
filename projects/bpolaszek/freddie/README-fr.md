[![Application](https://github.com/bpolaszek/mercure-x/actions/workflows/app.yml/badge.svg)](https://github.com/bpolaszek/mercure-x/actions/workflows/app.yml)
[![Coverage](https://codecov.io/gh/bpolaszek/freddie/branch/main/graph/badge.svg?token=uB4gRHyS6r)](https://codecov.io/gh/bpolaszek/freddie)

# Freddie

Freddie est une implémentation PHP de la [spécification Mercure Hub](https://mercure.rocks/spec).

Il est ultra-rapide, construit sur les épaules de géants :
- [PHP](https://www.php.net/releases/8.1/en.php) 8.1
- [Framework X](https://framework-x.org/) et [ReactPHP](https://reactphp.org/)
- [Symfony](https://symfony.com/) 6
- [Redis](https://redis.io/) (optionnellement).

Voyez quelles fonctionnalités sont couvertes et lesquelles ne le sont pas (encore) [ici](#feature-coverage).

## Installation

PHP 8.1+ est requis pour exécuter le hub.

### En tant que hub Mercure autonome

```bash
composer create-project freddie/mercure-x freddie && cd freddie
bin/freddie
```

Cela démarrera une instance Freddie sur `127.0.0.1:8080`, avec les abonnements anonymes activés.

Vous pouvez publier des mises à jour sur le hub en générant un JWT valide signé avec la clé `!ChangeMe!` utilisant l’algorithme `HMAC SHA256`.

Pour modifier ces valeurs, voir [Sécurité](#security).

### En tant que bundle de votre application Symfony existante

```bash
composer req freddie/mercure-x
```

Vous pouvez ensuite démarrer le hub en faisant :

```bash
bin/console freddie:serve
```

Vous pouvez remplacer les variables d'environnement pertinentes dans votre `.env.local`  
et les services dans votre `config/services.yaml` comme d'habitude.

Ensuite, vous pouvez injecter `Freddie\Hub\HubInterface` dans vos services afin de pouvoir appeler `$hub->publish($update)`,  
ou écouter les mises à jour dispatchées dans un contexte CLI 👍

Gardez à l'esprit que cela ne fonctionne que lorsque vous utilisez le transport Redis.

⚠️ **Freddie** utilise son propre système de routage/authentification (à cause de l'async / boucle d'événements).  

Les contrôleurs qu'il expose ne peuvent pas être importés dans votre `routes.yaml`, et sortent du périmètre de votre `security.yaml`.

## Utilisation

```bash
./bin/freddie
```
Il démarrera un nouveau hub Mercure sur `127.0.0.1:8080`.  
Pour changer cette adresse, utilisez la variable d'environnement `X_LISTEN` :


```bash
X_LISTEN="0.0.0.0:8000" ./bin/freddie
```

### Sécurité

La clé JWT par défaut est `!ChangeMe!` avec une signature `HS256`.

Vous pouvez définir différentes valeurs en modifiant les variables d'environnement (dans `.env.local` ou au niveau du système d'exploitation) :
`X_LISTEN`, `JWT_SECRET_KEY`, `JWT_ALGORITHM`, `JWT_PUBLIC_KEY` et `JWT_PASSPHRASE` (lors de l'utilisation de RS512 ou ECDSA)

Veuillez vous référer à la section [autorisation](https://mercure.rocks/spec#authorization) de la spécification Mercure pour vous authentifier en tant qu'éditeur et/ou abonné.

### Transport PHP (par défaut)

Par défaut, le hub fonctionnera comme un simple dispatcher d'événements, dans un seul processus PHP.

Cela peut convenir aux besoins courants pour un usage basique, mais l'utilisation de ce transport empêche la scalabilité,
car ouvrir un autre processus ne partagera pas le même émetteur d'événements.

Il est néanmoins parfaitement utilisable dès lors que :
- Vous ne prévoyez pas plus de quelques centaines de mises à jour par seconde
- Votre application est servie depuis un seul serveur.

### Transport Redis

En revanche, vous pouvez lancer le hub sur **plusieurs ports** et/ou **plusieurs serveurs** avec un transport Redis
(dès lors qu'ils partagent la même instance Redis), et utiliser éventuellement un load-balancer pour répartir le trafic.

La [version officielle open-source](https://mercure.rocks/docs/hub/install) du hub ne permet pas la montée en charge
en raison des restrictions de concurrence sur le transport _bolt_.

Pour lancer le hub avec le transport Redis, modifiez la variable d'environnement `TRANSPORT_DSN` :

```bash
TRANSPORT_DSN="redis://127.0.0.1:6379" ./bin/freddie
```

Paramètres optionnels que vous pouvez passer dans la chaîne de requête du DSN :
- `pingInterval` - ping régulier de la connexion Redis, ce qui aidera à détecter les pannes (par défaut `2.0`)
- `readTimeout` - durée maximale en secondes d'une requête ping ou publication (par défaut `0.0` : considéré comme désactivé)

_Alternativement, vous pouvez définir cette variable dans `.env.local`._

## Avantages et limitations

Cette implémentation ne fournit ni SSL ni terminaison HTTP2, il est donc préférable de placer un proxy inverse devant.

### Exemple de configuration Nginx

```nginx
upstream freddie {
    # Example with a single node
    server 127.0.0.1:8080;

    # Example with several nodes (they must share the same Redis instance)
    # 2 instances on 10.1.2.3
    server 10.1.2.3:8080;
    server 10.1.2.3:8081;

    # 2 instances on 10.1.2.4
    server 10.1.2.4:8080;
    server 10.1.2.4:8081;
}

server {
    
    listen 443 ssl http2;
    listen [::]:443 ssl http2;
    server_name example.com;

    ssl_certificate /etc/ssl/certs/example.com/example.com.cert;
    ssl_certificate_key /etc/ssl/certs/example.com/example.com.key;
    ssl_ciphers EECDH+CHACHA20:EECDH+AES128:RSA+AES128:EECDH+AES256:RSA+AES256:EECDH+3DES:RSA+3DES:!MD5;

    location /.well-known/mercure {
        proxy_pass http://freddie;
        proxy_read_timeout 24h;
        proxy_http_version 1.1;
        proxy_set_header Connection "";
        proxy_set_header X-Forwarded-For $proxy_add_x_forwarded_for;
        proxy_set_header X-Forwarded-Host $host;
        proxy_set_header X-Forwarded-Proto $scheme;
    }
}
```

### Exemple de configuration Caddy

#### Nœud unique

```caddy
example.com

reverse_proxy 127.0.0.1:8080
```

#### Avec plusieurs nœuds

```caddy
example.com

reverse_proxy 10.1.2.3:8080 10.1.2.3:8081 10.1.2.4:8080 10.1.2.4:8081
```

### Limitations de la charge utile
⚠ Il existe une limite connue dans [Framework-X](https://framework-x.org/docs/api/request/) qui empêche les corps de requête de dépasser [64 Ko](https://github.com/reactphp/http/issues/412). 
Au moment de la rédaction, cette limite ne peut pas être augmentée en raison de l'encapsulation de l'instanciation du serveur HTTP par Framework-X.

Publier des mises à jour plus volumineuses à Freddie (au moins via HTTP) pourrait entraîner des erreurs 400.

## Couverture des fonctionnalités

| Fonctionnalité                              | Couvert                               |
|---------------------------------------------|---------------------------------------|
| JWT via l'en-tête `Authorization`           | ✅                                     |
| JWT via le cookie `mercureAuthorization`    | ✅                                     |
| Autoriser les abonnés anonymes              | ✅                                     |
| Sujets alternatifs                          | ✅️                                    |
| Mises à jour privées                        | ✅                                     |
| Modèles d'URI pour les sujets               | ✅                                     |
| Signatures JWT HMAC SHA256                  | ✅                                     |
| Signatures JWT RS512                        | ✅                                     |
| Configuration par variables d'environnement | ✅                                     |
| IDs de message personnalisés                | ✅                                     |
| Dernier ID d'événement (y compris `earliest`) | ✅️                                    |
| Type d'événement personnalisable            | ✅️                                    |
| Directive `retry` personnalisable           | ✅️                                    |
| CORS                                        | ❌ (à configurer sur votre serveur web) |
| Point de contrôle de santé                   | ❌ (PR bienvenue)                      |
| Journalisation                              | ❌ (PR bienvenue))️                    |
| Métriques                                   | ❌ (PR bienvenue)️                     |
| JWT différents pour abonnés / éditeurs      | ❌ (PR bienvenue)                      |
| API d'abonnement                            | ❌️ (À FAIRE)                         |


## Tests

Ce projet est couvert à 100 % par des tests [Pest](https://pestphp.com/). 

```bash
composer tests:run
```

## Contribuer

Si vous souhaitez améliorer ce projet, n'hésitez pas à soumettre des PR :

- Le CI criera si vous ne respectez pas les [standards de codage PSR-12](https://www.php-fig.org/psr/psr-12/)
- En cas de nouvelle fonctionnalité, elle doit être accompagnée de tests
- L'analyse [PHPStan](https://phpstan.org/) doit réussir au niveau 8

Vous pouvez exécuter la commande suivante avant de valider pour vous assurer que toutes les exigences du CI sont bien respectées :

```bash
composer ci:check
```

## Licence

Licence publique générale GNU version 3.0.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-11

---