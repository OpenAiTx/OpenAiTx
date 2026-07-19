# notify

[![référence go.dev](https://img.shields.io/badge/go.dev-reference-007d9c?logo=go&logoColor=white&style=flat-square)](https://pkg.go.dev/github.com/esiqveland/notify?tab=doc)
[![Go Report Card](https://goreportcard.com/badge/github.com/esiqveland/notify)](https://goreportcard.com/report/github.com/esiqveland/notify)
![Build](https://github.com/esiqveland/notify/actions/workflows/go.yml/badge.svg?branch=master)

Notify est une bibliothèque go pour interagir avec le service de notification dbus défini par freedesktop.org :
https://specifications.freedesktop.org/notification/latest/

`notify` peut délivrer des notifications de bureau via dbus, à la manière de libnotify.

Veuillez noter que `notify` est encore en cours de développement et que les API ne sont pas figées tant qu’une version 1.0 n’est pas publiée.

Plus de testeurs sont les bienvenus =)

Dépend de :
 - [godbus](https://github.com/godbus/dbus).

## Changelog
- v0.11.2 : introduction des aides ExpireTimeoutSetByNotificationServer, ExpireTimeoutNever
- v0.11.1 : correction d’une condition de course lors de Close() #11
- v0.11.0 : nouvelle publication sous licence BSD
- v0.10.0 : types plus stricts : [quelques modifications incompatibles](https://github.com/esiqveland/notify/releases/tag/v0.10.0)
- v0.9.0 : [quelques modifications incompatibles](https://github.com/esiqveland/notify/releases/tag/v0.9.0)
- v0.2.1 : dbus : gomod : verrouillage sur dbus v5
- v0.2.0 : `Notifier.Close()` n’appelle plus `.Close()` sur la `dbus.Conn` sous-jacente

## Introduction rapide
Voir exemple : [main.go](https://github.com/esiqveland/notify/blob/master/example/main.go).

Cloner le dépôt et aller dans le dossier examples :

``` go run main.go ```


## À FAIRE

- [x] Ajouter le support des callbacks, c'est-à-dire les signaux dbus.
- [ ] Tests. Je suis très intéressé par toutes idées pour écrire des tests (utiles) pour cela.

## Voir aussi

La spécification des notifications Gnome https://developer.gnome.org/notification-spec/.


## Contributeurs
Merci à l'utilisateur [emersion](https://github.com/emersion) pour d'excellentes idées sur la réception des signaux.

Merci à [Merovius](https://github.com/Merovius) pour avoir corrigé une condition de concurrence lors de Close().

## Licence

BSD 3-Clause



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-19

---