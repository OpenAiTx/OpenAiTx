# mock

[![Go Reference](https://pkg.go.dev/badge/github.com/dhuan/mock.svg)](https://pkg.go.dev/github.com/dhuan/mock)
[![Go Report Card](https://goreportcard.com/badge/github.com/dhuan/mock)](https://goreportcard.com/report/github.com/dhuan/mock)

*mock* est un utilitaire d’API - il vous permet de :

- définir facilement des routes API via des fichiers de configuration API ou via
  des paramètres en ligne de commande.
- utiliser des scripts shell comme gestionnaires de réponses. Ou tout autre type de programme peut agir
  comme gestionnaire de réponses.
- tester votre API - faire des assertions sur le fait qu’un point de terminaison a été sollicité.

[Le moyen le plus rapide d’apprendre et de comprendre `mock` est de consulter la page des exemples.](https://dhuan.github.io/mock/latest/examples.html)

## Liens rapides

- [Guide utilisateur](https://dhuan.github.io/mock)
- [Guide utilisateur (branche principale, non encore publiée)](https://dhuan.github.io/mock/latest)
- [Tutoriels & Exemples](https://dhuan.github.io/mock/latest/examples.html)

## Pour commencer

```sh
$ mock serve --port 3000 \
  --get "/time-now" \
  --exec 'printf "Now it is %s" $(date +"%H:%M") | mock write' \
  --post "/shut-down/{application}" \
  --exec 'killall $(mock get-route-param application)'
```
Testons-le :


```sh
$ curl localhost:3000/time-now
# Prints out:
Now it is 22:00

$ curl -X POST localhost:3000/shut-down/mock
# Shuts down the server!
```
*mock* vous permet également d’étendre d’autres API (ou tout service HTTP, d’ailleurs).  
Supposons que vous souhaitiez ajouter une nouvelle route à une API existante fonctionnant sur  
``example.com`` :  


```sh
$ mock serve --port 3000 \
  --base example.com \
  --get 'some-new-route' \
  --exec 'printf "Hello, world!" | mock write' 
```

Avec l'option ``--base example.com`` ci-dessus, votre API agira comme un proxy vers
ce site web, et l'étendra avec une route supplémentaire `GET /some-new-route`.
Consultez "Base APIs" dans la documentation pour plus de détails.

*[Il existe de nombreuses autres façons de personnaliser davantage vos API avec *mock*. Lisez la suite du guide pour en savoir plus.](https://dhuan.github.io/mock)*

## Installation

mock est distribué sous forme d'exécutable monofichier. Consultez la page des releases et téléchargez le dernier tarball.

## Licence

**mock** est sous licence MIT. Pour plus d'informations, consultez le [fichier LICENSE.](LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-18

---