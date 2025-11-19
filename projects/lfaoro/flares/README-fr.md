# Flares 🔥

Flares est un outil de sauvegarde DNS CloudFlare, il affiche votre table DNS à l'écran ou l'exporte au format zones BIND.

[![Licence BSD](https://img.shields.io/badge/license-BSD-blue.svg?style=flat)](LICENSE)
[![Statut FOSSA](https://app.fossa.io/api/projects/git%2Bgithub.com%2Flfaoro%2Fflares.svg?type=shield)](https://app.fossa.io/projects/git%2Bgithub.com%2Flfaoro%2Fflares?ref=badge_shield)
[![Go Report Card](https://goreportcard.com/badge/github.com/lfaoro/flares)](https://goreportcard.com/report/github.com/lfaoro/flares)

![Téléchargements Docker](https://img.shields.io/docker/pulls/lfaoro/flares.svg?logo=docker&style=popout-square)
[![PayPal](https://img.shields.io/badge/paypal-contribute-blue.svg?style=popout-square&logo=paypal)](https://www.paypal.com/pools/c/8fm4OKBYMa)

## Démarrage rapide

### [Tutoriel vidéo](https://asciinema.org/a/NLVa6TyQzvTEhnzZDdH1q79lO)

### Docker

```bash
# Fetch your CloudFlare API token from here:
# https://dash.cloudflare.com/profile/api-tokens
# -> Create Token
# -> Edit zone DNS
# -> Permission: read
# -> Zone resources: Include -> All zones

$ export CF_API_TOKEN="KClp4y8BgD2LQiz2..."

$ docker run -it --rm \
-e CF_API_TOKEN="$CF_API_TOKEN" \
lfaoro/flares domain1.tld domain2.tld
```

### macOS
```bash
brew install lfaoro/tap/flares
```

### Linux/BSD
```bash
curl https://raw.githubusercontent.com/lfaoro/flares/master/install.sh | bash
```

### Développeurs
> Installateur Go : https://golang.org/dl/
```bash
go get -u github.com/lfaoro/flares
make install
flares -h

make test
```

## Exemples

```bash
$ make install
$ flares -h

$ flares domain1.tld
;;
;; Domain:     domain1.tld
;; Exported:   2019-06-03 06:31:29
...continued

$ flares --export domain1.tld domain2.tld
BIND table for domain1.tld successfully exported
BIND table for domain2.tld successfully exported
$ ls
domain1.tld domain2.tld
```

## Automatisation

### GitLab CI/CD

- Copiez le fichier [.gitlab-ci.yml](.gitlab-ci.yml) dans votre dépôt
- Utilisez la fonctionnalité [planifications de pipeline](https://gitlab.com/help/user/project/pipelines/schedules)
- Chaque exécution de la tâche générera une sauvegarde DNS stockée comme un artefact téléchargeable

# Contribution

> Toute aide et suggestion sont les bienvenues et appréciées. Commencez par ouvrir une [issue](https://github.com/lfaoro/flares/issues/new).

- Forkez le projet
- Créez votre branche de fonctionnalité `git checkout -b my-new-feature`
- Validez vos modifications `git commit -am 'Add my feature'`
- Poussez vers la branche `git push origin my-new-feature`
- Créez une nouvelle pull request vers la branche master


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-19

---