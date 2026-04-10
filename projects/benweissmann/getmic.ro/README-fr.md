# getmic.ro

![Test](https://github.com/benweissmann/getmic.ro/workflows/Test/badge.svg)

La manière la plus rapide d'installer [Micro](https://micro-editor.github.io/)

```Bash
# local install just for your user
curl https://getmic.ro | bash
```

Ou, en utilisant `wget` à la place de `curl` et n'importe quel interpréteur `sh` à la place de `bash` :

```Bash
# local install just for your user
wget -O- https://getmic.ro | sh
```

Ce script installera micro dans le répertoire dans lequel vous vous trouvez. Pour installer ailleurs (par exemple /usr/local/bin), allez dans ce répertoire et assurez-vous d'y avoir les droits d'écriture, par exemple `cd /usr/local/bin; curl https://getmic.ro | sudo sh` comme ceci :

```Bash
# global install for all users
cd /usr/bin
curl https://getmic.ro | sudo sh
```

Ce script peut également utiliser update-alternatives pour enregistrer micro en tant qu'éditeur de texte système.
Par exemple, cela permettra à `crontab -e` d'ouvrir le fichier cron avec micro.

Pour activer cette fonctionnalité, définissez la variable `GETMICRO_REGISTER` ou utilisez l'URL
`https://getmic.ro/r`. Notez que vous devez installer micro dans un répertoire
accessible à tous les utilisateurs lors de cette opération, typiquement /usr/bin :

```Bash
# global install for all users, registering with update-alternatives
cd /usr/bin
curl https://getmic.ro/r | sudo sh
```

> Vous ne comprenez pas l'anglais? vous parlez français? **Regardez le [*LISEZ-MOI* français](https://raw.githubusercontent.com/benweissmann/getmic.ro/master/./README.fr.md)!**

## Utilisation avancée

Il y a quelques autres choses que vous pouvez faire avec getmic.ro. Voici une liste de variables d'environnement que vous pouvez choisir :

* `GETMICRO_HTTP=<COMMANDE ...ARG>`
    + Utilisez cette commande avec des arguments délimités par des espaces pour télécharger des fichiers sur internet.
        - Elle DOIT suivre les redirections (via les en-têtes HTTP Location).
        - Elle DOIT afficher le contenu du fichier résultant sur stdout.
        - Elle DOIT accepter que l'argument suivant soit l'URL du fichier à télécharger.
        - Il EST OPTIONNEL que la commande accepte aussi un paramètre `--header` utilisé pour un shim de secours d'authentification GitHub non essentiel.
    + Par exemple, pour forcer l'utilisation de `curl`, faites : `curl https://getmic.ro | GETMICRO_HTTP="curl -L" sh`
    + Par exemple, pour forcer l'utilisation de `wget`, faites : `wget -O- https://getmic.ro | GETMICRO_HTTP="wget -O-" sh`
* `GETMICRO_PLATFORM=[freebsd32 | freebsd64 linux-arm | linux-arm64 | linux32 | linux64 | linux64-static | macos-arm64 | netbsd32 | netbsd64 | openbsd32 | openbsd64 | osx | win32 | win64]`
    + Ceci remplace manuellement le mécanisme de détection de plateforme et télécharge les binaires pour la plateforme que vous spécifiez.
    + Un usage de ceci est de spécifier `https://getmic.ro | GETMICRO_PLATFORM=linux64-static sh` lorsque vous utilisez une implémentation libc incompatible telle que musl.
* `GETMICRO_REGISTER=[y | n]`
    + Indique s'il faut enregistrer micro avec `update-alternatives` pour pouvoir utiliser micro comme éditeur de texte système de manière transparente.
        - y => oui
        - n => non (par défaut)
    + Si GETMICRO_REGISTER est défini mais que le système ne supporte pas `update-alternatives`, cette option est ignorée silencieusement.
    + Lorsqu'activé, getmicro doit être exécuté avec des privilèges suffisants (typiquement l'utilisateur root) pour utiliser `update-alternatives`, sinon getmicro quittera avec une erreur.
    + Par souci de simplicité, vous pouvez utiliser `https://getmic.ro/r` qui définit `GETMICRO_REGISTER=y`.

Pour tout mettre ensemble, la ligne de commande suivante utiliserait toujours wget, installerait toujours les binaires linux32, et enregistrerait toujours avec `update-alternatives` :

```Bash
wget -O- https://getmic.ro | GETMICRO_HTTP="wget -O-" GETMICRO_PLATFORM=linux32 GETMICRO_REGISTER=y sh
```

### Vérifier la somme de contrôle du script

Pour vérifier le script, vous pouvez le télécharger et calculer sa somme de contrôle. La somme de contrôle sha256 est `d041f51b97871dc7de1f01879c12a978b074a5acdb6528e884ce8f4c05d2ad35`.

```Bash
gmcr="$(curl https://getmic.ro)" && [ $(echo "$gmcr" | shasum -a 256 | cut -d' ' -f1) = d041f51b97871dc7de1f01879c12a978b074a5acdb6528e884ce8f4c05d2ad35 ] && echo "$gmcr" | sh
```

Alternativement, vous pouvez utiliser la méthode manuelle suivante.

```Bash
# 1. Manually verify that this outputs d041f51b97871dc7de1f01879c12a978b074a5acdb6528e884ce8f4c05d2ad35
curl https://getmic.ro | shasum -a 256

# 2. If #1 was successful, then execute getmicro
curl https://getmic.ro | sh
```

## Contribution

Merci pour votre contribution ! Nous utilisons le workflow de pull request Github : forkez ce dépôt, apportez vos modifications, puis soumettez une pull request. Il y a quelques étapes à suivre pour que votre PR soit fusionnée :

- Assurez-vous que tous les tests réussissent. Github Actions signalera les échecs des tests sur la page de la PR une fois que vous l’aurez ouverte.

- Si vous introduisez un nouveau comportement, mettez à jour les tests Github Actions (dans [`.github/workflows/test.yml`](https://github.com/benweissmann/getmic.ro/blob/master/.github/workflows/test.yml)) pour tester ce comportement.

- Si vous introduisez de nouvelles options ou comportements destinés aux utilisateurs, mettez à jour les fichiers README pour documenter ce comportement (ne traduisez pas si vous ne connaissez pas la langue du fichier de destination).

Si vous ne savez pas comment faire l’une de ces choses, n’hésitez pas à ouvrir une PR avec votre travail en cours et les questions que vous avez !

## Remerciements :

- Micro, bien sûr : https://micro-editor.github.io/

- Librement inspiré du Chef curl|bash : https://docs.chef.io/install_omnibus.html

- Art ASCII gracieusement fourni par figlet : http://www.figlet.org/

<!--shasum=d041f51b97871dc7de1f01879c12a978b074a5acdb6528e884ce8f4c05d2ad35-->


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-10

---