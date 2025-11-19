# Flares 🔥

Flares es una herramienta de respaldo DNS de CloudFlare, que muestra tu tabla DNS en pantalla o la exporta como archivos de zona en formato BIND.

[![Licencia BSD](https://img.shields.io/badge/license-BSD-blue.svg?style=flat)](LICENSE)
[![Estado FOSSA](https://app.fossa.io/api/projects/git%2Bgithub.com%2Flfaoro%2Fflares.svg?type=shield)](https://app.fossa.io/projects/git%2Bgithub.com%2Flfaoro%2Fflares?ref=badge_shield)
[![Informe Go](https://goreportcard.com/badge/github.com/lfaoro/flares)](https://goreportcard.com/report/github.com/lfaoro/flares)

![Descargas Docker](https://img.shields.io/docker/pulls/lfaoro/flares.svg?logo=docker&style=popout-square)
[![PayPal](https://img.shields.io/badge/paypal-contribute-blue.svg?style=popout-square&logo=paypal)](https://www.paypal.com/pools/c/8fm4OKBYMa)

## Inicio Rápido

### [Tutorial en Video](https://asciinema.org/a/NLVa6TyQzvTEhnzZDdH1q79lO)

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

### Desarrolladores
> Instalador de Go: https://golang.org/dl/
```bash
go get -u github.com/lfaoro/flares
make install
flares -h

make test
```

## Ejemplos

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

## Automatización

### GitLab CI/CD

- Copia [.gitlab-ci.yml](.gitlab-ci.yml) dentro de tu repositorio
- Usa la función de [programación de pipelines](https://gitlab.com/help/user/project/pipelines/schedules)
- Cada ejecución de la tarea generará una copia de seguridad DNS almacenada como un artefacto descargable

# Contribuyendo

> Cualquier ayuda y sugerencia son muy bienvenidas y apreciadas. Comienza abriendo un [issue](https://github.com/lfaoro/flares/issues/new).

- Haz un fork del proyecto
- Crea tu rama de función `git checkout -b my-new-feature`
- Confirma tus cambios `git commit -am 'Add my feature'`
- Envía la rama `git push origin my-new-feature`
- Crea un nuevo pull request contra la rama master


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-19

---