# Kubernetes (K8s)

[![CII Best Practices](https://bestpractices.coreinfrastructure.org/projects/569/badge)](https://bestpractices.coreinfrastructure.org/projects/569) [![Go Report Card](https://goreportcard.com/badge/github.com/kubernetes/kubernetes)](https://goreportcard.com/report/github.com/kubernetes/kubernetes) ![GitHub release (latest SemVer)](https://img.shields.io/github/v/release/kubernetes/kubernetes?sort=semver)

<img src="https://github.com/kubernetes/kubernetes/raw/master/logo/logo.png" width="100">

----

Kubernetes, también conocido como K8s, es un sistema de código abierto para gestionar [aplicaciones contenerizadas] en múltiples hosts. Proporciona mecanismos básicos para el despliegue, mantenimiento y escalado de aplicaciones.

Kubernetes se basa en una década y media de experiencia en Google ejecutando cargas de trabajo de producción a gran escala utilizando un sistema llamado [Borg], combinado con las mejores ideas y prácticas de la comunidad.

Kubernetes está alojado por la Cloud Native Computing Foundation ([CNCF]). Si tu empresa desea ayudar a dar forma a la evolución de tecnologías empaquetadas en contenedores, programadas dinámicamente y orientadas a microservicios, considera unirte a la CNCF. Para más detalles sobre quiénes participan y cómo Kubernetes juega un papel, lee el [anuncio] de la CNCF.

----

## Para empezar a usar K8s

Consulta nuestra documentación en [kubernetes.io].

Toma un curso gratuito sobre [Microservicios Escalables con Kubernetes].

Para utilizar el código de Kubernetes como una librería en otras aplicaciones, consulta la [lista de componentes publicados](https://git.k8s.io/kubernetes/staging/README.md). El uso del módulo `k8s.io/kubernetes` o los paquetes `k8s.io/kubernetes/...` como librerías no está soportado.

## Para empezar a desarrollar K8s

El [repositorio de la comunidad] alberga toda la información sobre cómo construir Kubernetes desde el código fuente, cómo contribuir con código y documentación, a quién contactar sobre qué, etc.

Si deseas construir Kubernetes de inmediato hay dos opciones:

##### Tienes un [entorno Go] funcional.

```
git clone https://github.com/kubernetes/kubernetes
cd kubernetes
make
```

##### Tienes un [entorno Docker] funcional.

```
git clone https://github.com/kubernetes/kubernetes
cd kubernetes
make quick-release
```

Para la información completa, dirígete a la [documentación para desarrolladores].

## Soporte

Si necesitas soporte, comienza con la [guía de solución de problemas] y sigue el proceso que hemos descrito.

Dicho esto, si tienes preguntas, comunícate con nosotros [de una u otra manera][comunicación].

[anuncio]: https://cncf.io/news/announcement/2015/07/new-cloud-native-computing-foundation-drive-alignment-among-container
[Borg]: https://research.google.com/pubs/pub43438.html?authuser=1
[CNCF]: https://www.cncf.io/about
[comunicación]: https://git.k8s.io/community/communication
[repositorio de la comunidad]: https://git.k8s.io/community
[aplicaciones contenerizadas]: https://kubernetes.io/docs/concepts/overview/what-is-kubernetes/
[documentación para desarrolladores]: https://git.k8s.io/community/contributors/devel#readme
[entorno Docker]: https://docs.docker.com/engine
[entorno Go]: https://go.dev/doc/install
[kubernetes.io]: https://kubernetes.io
[Microservicios Escalables con Kubernetes]: https://www.udacity.com/course/scalable-microservices-with-kubernetes--ud615
[guía de solución de problemas]: https://kubernetes.io/docs/tasks/debug/

## Reuniones de la Comunidad

El [Calendario](https://www.kubernetes.dev/resources/calendar/) tiene la lista de todas las reuniones de la comunidad de Kubernetes en un solo lugar.

## Adoptantes

El sitio web de [Estudios de Caso de Usuarios](https://kubernetes.io/case-studies/) presenta casos de uso reales de organizaciones de diferentes industrias que están desplegando o migrando a Kubernetes.

## Gobernanza

El proyecto Kubernetes se rige por un marco de principios, valores, políticas y procesos para ayudar a nuestra comunidad y sus miembros a alcanzar nuestros objetivos compartidos.

La [Comunidad de Kubernetes](https://github.com/kubernetes/community/blob/master/governance.md) es el punto de partida para aprender sobre cómo nos organizamos.

El [repositorio de la comunidad de Steering de Kubernetes](https://github.com/kubernetes/steering) es utilizado por el Comité de Dirección de Kubernetes, que supervisa la gobernanza del proyecto Kubernetes.

## Hoja de Ruta

El [repositorio de Mejoras de Kubernetes](https://github.com/kubernetes/enhancements) proporciona información sobre las versiones de Kubernetes, así como el seguimiento de características y pendientes.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---