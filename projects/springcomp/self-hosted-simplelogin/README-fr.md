# SimpleLogin

Ceci est une configuration docker-compose auto-hébergée pour [SimpleLogin](https://simplelogin.io).

## Prérequis

- un serveur Linux (soit une VM ou un serveur dédié). Ce document montre l'installation pour Ubuntu 18.04 LTS mais les étapes peuvent être adaptées pour d'autres distributions Linux populaires. Comme la plupart des composants tournent dans des conteneurs Docker et que Docker peut être un peu gourmand, avoir au moins 2 Go de RAM est recommandé. Le serveur doit avoir les ports 25 (email), 80, 443 (pour l'application web), 22 (pour pouvoir s’y connecter en ssh) ouverts.

- un domaine pour lequel vous pouvez configurer le DNS. Cela peut être un sous-domaine. Dans le reste du document, disons que c’est `mydomain.com` pour l’email et `app.mydomain.com` pour l’application web SimpleLogin. Veuillez vous assurer de remplacer ces valeurs par votre nom de domaine et votre sous-domaine chaque fois qu’elles apparaissent dans le document. Une astuce que nous utilisons est de télécharger ce fichier README sur votre ordinateur et de remplacer toutes les occurrences de `mydomain.com` et `app.mydomain.com` par votre domaine.

À l’exception de la configuration DNS qui se fait généralement sur l’interface de votre registrar, toutes les étapes ci-dessous doivent être réalisées sur votre serveur. Les commandes sont à exécuter avec `bash` (ou tout shell compatible bash comme `zsh`). Si vous utilisez d’autres shells comme `fish`, veuillez adapter les commandes.

- Quelques paquets utilitaires utilisés pour vérifier la configuration. Installez-les en :

```bash
sudo apt update \
  && sudo apt install -y net-tools dnsutils
```

## Configuration DNS

_Consultez la [documentation de référence](https://github.com/springcomp/self-hosted-simplelogin/wiki/DNS-Configuration) pour plus de détails_

> **Veuillez noter** que les modifications DNS peuvent prendre jusqu'à 24 heures pour se propager. En pratique, c'est beaucoup plus rapide (~1 minute environ dans nos tests). Dans la configuration DNS, nous utilisons généralement un domaine avec un point final (`.`) pour forcer l'utilisation d'un domaine absolu.

Vous devrez configurer les enregistrements DNS suivants :

- **A** : Associe votre domaine à l'adresse IPv4 de votre serveur.
- **AAAA** : Associe votre domaine à l'adresse IPv6 de votre serveur.
- **MX** : Dirige les emails entrants vers votre serveur mail (y compris les jokers `*`).
- **PTR** : Associe l'adresse IP de votre serveur à votre nom de domaine.

Configurez les politiques de sécurité obligatoires :

- **DKIM** : Signe numériquement les emails sortants pour vérifier leur authenticité.
- **DMARC** : Définit comment les récepteurs d'emails doivent gérer les messages échouant à l'authentification.
- **SPF** : Autorise des serveurs mail spécifiques à envoyer des emails depuis votre domaine.

Étapes supplémentaires :

- **CAA** : Spécifie quelles autorités de certification sont autorisées à émettre des certificats SSL pour votre domaine.
- **MTA-STS** : Implore des connexions sécurisées et chiffrées entre serveurs mail.
- **TLS-RPT** : Signale les échecs de connexion TLS pour améliorer la sécurité de la livraison des emails.

**Attention** : la configuration d'un enregistrement CAA limitera les autorités de certification pouvant émettre des certificats SSL pour votre domaine.
Cela empêchera l'émission de certificats par les serveurs de pré-production de Let’s Encrypt. Vous pouvez différer cet enregistrement DNS jusqu'à ce que les certificats SSL soient émis avec succès pour votre domaine.

## Docker

Si Docker n'est pas encore installé sur votre serveur, veuillez suivre les étapes sur [Docker CE pour Ubuntu](https://docs.docker.com/v17.12/install/linux/docker-ce/ubuntu/) pour installer Docker.

Vous pouvez également installer Docker en utilisant le script [docker-install](https://github.com/docker/docker-install) qui est

```bash
curl -fsSL https://get.docker.com | sh
```

Activez IPv6 pour [le réseau pont par défaut](https://docs.docker.com/config/daemon/ipv6/#use-ipv6-for-the-default-bridge-network)

```json
{
  "ipv6": true,
  "fixed-cidr-v6": "2001:db8:1::/64",
  "experimental": true,
  "ip6tables": true
}
```

Cette procédure vous guidera pour exécuter l’ensemble de la pile en utilisant des conteneurs Docker.
Cela inclut :

- traefik
- Les conteneurs de l’[application SimpleLogin](https://github.com/simple-login/app)
- postfix

Exécuter SimpleLogin à partir de conteneurs Docker :

1. Clonez ce dépôt dans `/opt/simplelogin`
1. Copiez `.env.example` en `.env` et définissez les valeurs appropriées.

    - définissez la variable `DOMAIN` sur votre domaine.
    - définissez la variable `SUBDOMAIN` sur votre sous-domaine. La valeur par défaut est `app`.
    - définissez la variable `POSTGRES_USER` pour correspondre aux identifiants postgres (si vous partez de zéro, utilisez `simplelogin`).
    - définissez le `POSTGRES_PASSWORD` pour correspondre aux identifiants postgres (si vous partez de zéro, mettez une clé aléatoire).
    - définissez le `FLASK_SECRET` avec une clé secrète arbitraire.

### Postgres SQL

Ce dépôt exécute un Postgres SQL dans un conteneur Docker.

**Attention** : les versions précédentes de ce dépôt utilisaient la version `12.1`.
Veuillez consulter la [documentation de référence](https://github.com/springcomp/self-hosted-simplelogin/wiki/PostgreSQL) pour plus de détails et
les instructions de mise à niveau.

### Exécution de l’application

Exécutez l’application en utilisant les commandes suivantes :

```sh
docker compose up --detach --remove-orphans --build && docker compose logs -f
```

Vous pouvez vouloir configurer [Certificate Authority Authorization (CAA)](https://github.com/springcomp/self-hosted-simplelogin/wiki/dns-caa) à ce stade.

## Étapes suivantes

Si toutes les étapes ci-dessus sont réussies, ouvrez <https://app.mydomain.com/> et créez votre premier compte !

Par défaut, les nouveaux comptes ne sont pas premium et n'ont donc pas d'alias illimités. Pour rendre votre compte premium,
veuillez aller dans la base de données, table « users » et définir la colonne « lifetime » à « 1 » ou « TRUE » :

```bash
docker compose exec -it postgres psql -U myuser simplelogin
> UPDATE users SET lifetime = TRUE;
> \q
```

Une fois que vous avez créé tous les comptes de connexion souhaités, ajoutez ces lignes à `.env` pour désactiver les inscriptions supplémentaires :

```env
DISABLE_REGISTRATION=1
DISABLE_ONBOARDING=true
```

Ensuite, pour redémarrer l'application web, appliquez : `docker compose restart app`

## Divers

### Configuration de Postfix - Spamhaus

Le projet Spamhaus maintient une liste fiable d'adresses IP connues pour être à l'origine de SPAM.  
Vous pouvez vérifier si une adresse IP donnée figure dans cette liste en soumettant des requêtes à l'infrastructure DNS.

Comme Spamhaus bloque les requêtes provenant de résolveurs DNS publics (ouverts) (voir : <https://check.spamhaus.org/returnc/pub>) et que votre conteneur postfix peut utiliser  
par défaut un résolveur public, il est recommandé de s'inscrire au service gratuit  
[Spamhaus Data Query Service](https://www.spamhaus.com/free-trial/sign-up-for-a-free-data-query-service-account/)  
et d'obtenir une clé DQS Spamhaus.

Collez cette clé sous `SPAMHAUS_DQS_KEY` dans votre fichier `.env`

Si aucune clé DQS n'est fournie, votre conteneur postfix vérifiera si les miroirs publics de Spamhaus acceptent ses requêtes et les utilisera à la place.  
Si Spamhaus rejette les requêtes de votre conteneur postfix vers les miroirs publics, il sera entièrement désactivé.

### Configuration de Postfix - Alias virtuels

La configuration postfix prend en charge les alias virtuels via les fichiers `postfix/conf.d/virtual` et `postfix/conf.d/virtual-regexp`.  
Ces fichiers sont automatiquement créés au démarrage à partir des fichiers modèles correspondants  
[`postfix/templates/virtual.tpl`](https://raw.githubusercontent.com/springcomp/self-hosted-simplelogin/main/./postfix/templates/virtual.tpl)  
et [`postfix/templates/virtual-regexp.tpl`](https://raw.githubusercontent.com/springcomp/self-hosted-simplelogin/main/./postfix/templates/virtual-regexp.tpl).

La configuration par défaut est la suivante :

#### virtual.tpl

Le fichier `virtual` supporte les paramètres postfix `virtual_alias_maps`.  
Il inclut une règle qui redirige `unknown@mydomain.com` vers `contact@mydomain.com` pour démontrer la réception  
d'un email depuis une adresse spécifique qui ne correspond pas à un alias existant, vers une autre qui en correspond.
```postfix-conf
unknown@mydomain.com  contact@mydomain.com
```

#### virtual-regexp.tpl

Le fichier `virtual-regexp` prend en charge les paramètres postfix `virtual_alias_maps`.
Il inclut une règle qui réécrit les e-mails adressés à un sous-domaine arbitraire, qui ne correspond pas
à un alias existant, vers un nouvel alias appartenant à un répertoire dont le nom est tiré du sous-domaine.
Cet alias peut être créé à la volée s’il n’existe pas.

```postfix-conf
/^([^@]+)@([^.]+)\.mydomain.com/   $2/$1@mydomain.com
```

Par exemple, les e-mails envoyés à `someone@directory.mydomain.com` seront acheminés vers `directory/someone@mydomain.com` par postfix.

## Comment mettre à niveau depuis la version 3.4.0

_Cette section a été déplacée vers la [documentation de référence](https://github.com/springcomp/self-hosted-simplelogin/wiki/upgrade-sl)_

## Comment mettre à niveau depuis la configuration précédente basée sur NGinx

_Cette section a été déplacée vers la [documentation de référence](https://github.com/springcomp/self-hosted-simplelogin/wiki/upgrade-from-nginx)_


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-14

---