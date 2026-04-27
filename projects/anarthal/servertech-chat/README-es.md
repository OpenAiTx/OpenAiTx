# BoostServerTech Chat

Este repositorio contiene el código para una aplicación de chat escrita en C++.

Lee la documentación completa [aquí](https://anarthal.github.io/servertech-chat/).

| Build                                                                                              | Docs                                                                                                                                            | Servidor en vivo                |
| -------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------- |
| ![Estado de Build](https://github.com/anarthal/servertech-chat/actions/workflows/build.yml/badge.svg) | [![Estado de Build](https://github.com/anarthal/servertech-chat/actions/workflows/doc.yml/badge.svg)](https://anarthal.github.io/servertech-chat/) | [¡Pruébalo!](http://16.171.43.27/) |

## El proyecto BoostServerTech

Este es el primero de los [proyectos BoostServerTech](https://docs.google.com/document/d/1ZQrod1crs8EaNLLqSYIRMacwR3Rv0hC5l-gfL-jOp2M),
una colección de proyectos que muestran cómo C++ y Boost pueden usarse para código del lado del servidor.

## Arquitectura

El servidor está basado en Boost.Beast, es asíncrono (corutinas C++20)
y de un solo hilo. Requiere C++20 para compilar. Utiliza Redis y MySQL para
persistencia.

El cliente es basado en web y usa Next.js. Se comunica con el servidor
usando websockets.

Puedes leer más sobre la arquitectura
[en esta sección de la documentación](https://anarthal.github.io/servertech-chat/01-architecture.html).

## Desarrollo local

Puedes ejecutar rápidamente la aplicación de chat en localhost usando Docker Compose,
ejecutando en una terminal en la raíz del repositorio:

```
docker compose up --build
```

O puedes aprender cómo configurar un entorno de desarrollo tradicional
[aquí](https://anarthal.github.io/servertech-chat/02-local-dev.html).

## En vivo en minutos

Este proyecto cuenta con una canalización CI/CD que puede desplegar tu código en tu servidor en
minutos. Todo lo que necesitas es un servidor Linux con SSH habilitado, o una cuenta de AWS para crear uno.
Puedes encontrar más información [aquí](https://anarthal.github.io/servertech-chat/03-fork-modify-deploy.html).

## ¿Quieres contribuir?

¡Envíanos un mensaje en [el Slack de cpplang](https://cpplang.slack.com/archives/C06BRML5EFK)!
¡Los colaboradores son más que bienvenidos!


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-27

---