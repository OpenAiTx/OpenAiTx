# Action Hero

## ¿Qué es Action Hero?

Action Hero es una utilidad estilo sidecar para ayudar a crear políticas IAM de mínimo privilegio para AWS.

## ¿Por qué es necesario?

Comúnmente, los desarrolladores comienzan a crear infraestructura como código con roles más permisivos que tienen acceso administrativo para iterar rápidamente. Sin embargo, tratar de crear un conjunto de permisos más finamente delimitado puede ser doloroso y consumir mucho tiempo.

Action Hero proporciona un medio para capturar todos los permisos requeridos durante las iteraciones más permisivas para facilitar la creación de un rol IAM con solo los permisos necesarios.

## ¿Cómo funciona?

Action Hero utiliza una característica del SDK de AWS conocida como Monitoreo del Lado del Cliente (Client Side Monitoring). Esta característica envía llamadas a la API de AWS a un puerto UDP local (31000 por defecto).

Summit Route discute la característica en esta [publicación](https://summitroute.com/blog/2020/05/25/client_side_monitoring/) (que fue la inspiración para esta herramienta).

## Requisitos previos

Como se discute en la publicación anterior, se debe ejecutar ``export AWS_CSM_ENABLED=true`` en la terminal o establecerse en un perfil donde se ejecute la herramienta que use el SDK. Por ejemplo, si usas terraform, debería exportarse en la terminal desde donde se ejecute el plan/apply.

La variable de entorno ``AWS_CSM_PORT`` también puede usarse para sobrescribir el puerto al que se envían las acciones CSM y en el que Action Hero escucha. Esto debería exportarse en ambas terminales si se usa.

## Instalación

Los binarios están disponibles en la página de [lanzamientos](https://github.com/princespaghetti/actionhero/releases).

También hay una imagen docker disponible en [docker hub](https://hub.docker.com/r/princespaghetti/actionhero).

## Ejecutando Action Hero

En una terminal separada de donde estés usando el SDK, ejecuta el binario

``./actionhero``

Alternativamente, puedes usar un comando docker run

``docker run -e "IN_DOCKER=True" -p 127.0.0.1:31000:31000/udp --rm princespaghetti/actionhero:latest``

Ctrl+C se puede usar para terminar el proceso de forma segura

## Guía

Por favor, consulte este [artículo del blog](https://dev.to/prince_of_pasta/action-hero-to-the-rescue-creating-least-privilege-aws-iam-policies-53o2) para un uso de ejemplo de la herramienta.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-08

---