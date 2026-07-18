# mock

[![Referencia Go](https://pkg.go.dev/badge/github.com/dhuan/mock.svg)](https://pkg.go.dev/github.com/dhuan/mock)
[![Informe Go Report](https://goreportcard.com/badge/github.com/dhuan/mock)](https://goreportcard.com/report/github.com/dhuan/mock)

*mock* es una utilidad API - te permite:

- definir rutas de API fácilmente mediante archivos de configuración de API o mediante
  parámetros de línea de comandos.
- usar scripts shell como manejadores de respuestas. O cualquier otro tipo de programa puede actuar
  como manejador de respuestas.
- probar tu API - hacer aserciones sobre si se solicitó un endpoint.

[La manera más rápida de aprender y entender `mock` es ver la página de ejemplos.](https://dhuan.github.io/mock/latest/examples.html)

## Enlaces rápidos

- [Guía de usuario](https://dhuan.github.io/mock)
- [Guía de usuario (rama principal, aún no lanzada)](https://dhuan.github.io/mock/latest)
- [Cómo hacer y ejemplos](https://dhuan.github.io/mock/latest/examples.html)

## Comenzando

```sh
$ mock serve --port 3000 \
  --get "/time-now" \
  --exec 'printf "Now it is %s" $(date +"%H:%M") | mock write' \
  --post "/shut-down/{application}" \
  --exec 'killall $(mock get-route-param application)'
```

Vamos a probarlo:

```sh
$ curl localhost:3000/time-now
# Prints out:
Now it is 22:00

$ curl -X POST localhost:3000/shut-down/mock
# Shuts down the server!
```
*mock* también te permite extender otras API (o cualquier servicio HTTP, para el caso).
Supongamos que quieres añadir una nueva ruta a una API existente que se ejecuta en
``example.com``:


```sh
$ mock serve --port 3000 \
  --base example.com \
  --get 'some-new-route' \
  --exec 'printf "Hello, world!" | mock write' 
```
Con la opción ``--base example.com`` anterior, su API actuará como proxy
de ese otro sitio web, y lo ampliará con una ruta extra `GET /some-new-route`.
Consulte "APIs base" en la documentación para más detalles.

*[Hay muchas otras formas de personalizar aún más sus APIs con *mock*. Lea más en la guía para aprender.](https://dhuan.github.io/mock)*

## Instalación

mock se distribuye como un ejecutable de un solo archivo. Consulte la página de lanzamientos y descargue el último tarball.

## Licencia

**mock** está licenciado bajo MIT. Para más información consulte el [archivo LICENSE.](LICENSE)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-18

---