## Apache RocketMQ

[![Estado de la compilación][maven-build-image]][maven-build-url]
[![CodeCov][codecov-image]][codecov-url]
[![Maven Central][maven-central-image]][maven-central-url]
[![Lanzamiento][release-image]][release-url]
[![Licencia][license-image]][license-url]
[![Tiempo promedio para resolver un problema][percentage-of-issues-still-open-image]][percentage-of-issues-still-open-url]
[![Porcentaje de problemas aún abiertos][average-time-to-resolve-an-issue-image]][average-time-to-resolve-an-issue-url]
[![Seguir en Twitter][twitter-follow-image]][twitter-follow-url]

**[Apache RocketMQ](https://rocketmq.apache.org) es una plataforma distribuida de mensajería y streaming con baja latencia, alto rendimiento y fiabilidad, capacidad a nivel de billones y escalabilidad flexible.**


Ofrece una variedad de características:

* Patrones de mensajería que incluyen publicar/suscribir, solicitud/respuesta y streaming
* Mensajes transaccionales de grado financiero
* Opciones integradas de tolerancia a fallos y alta disponibilidad basadas en [DLedger Controller](https://raw.githubusercontent.com/apache/rocketmq/develop/docs/en/controller/quick_start.md)
* Capacidad integrada de rastreo de mensajes, también soporta opentracing
* Integración versátil con ecosistemas de big data y streaming
* Retroactividad de mensajes por tiempo o desplazamiento
* Mensajería FIFO confiable y orden estricta en la misma cola
* Modelo eficiente de consumo pull y push
* Capacidad de acumulación de mensajes a nivel de millones en una sola cola
* Múltiples protocolos de mensajería como gRPC, MQTT, JMS y OpenMessaging
* Arquitectura flexible de despliegue distribuido y escalable
* Sistema de intercambio de mensajes por lotes ultrarrápido
* Diversos mecanismos de filtrado de mensajes como SQL y Tag
* Imágenes Docker para pruebas aisladas y clústeres aislados en la nube
* Panel administrativo completo para configuración, métricas y monitoreo
* Autenticación y autorización
* Conectores libres y de código abierto, tanto para fuentes como para destinos
* Computación en tiempo real ligera
----------


## Inicio Rápido

Este párrafo te guía a través de los pasos para instalar RocketMQ de diferentes maneras.
Para el desarrollo y pruebas locales, solo se creará una instancia para cada componente.

### Ejecutar RocketMQ localmente

RocketMQ funciona en todos los principales sistemas operativos y solo requiere que se instale una versión de Java JDK 8 o superior.
Para verificar, ejecute `java -version`:
```shell
$ java -version
java version "1.8.0_121"
```

Para usuarios de Windows, haga clic [aquí](https://dist.apache.org/repos/dist/release/rocketmq/5.3.3/rocketmq-all-5.3.3-bin-release.zip) para descargar la versión binaria 5.3.3 de RocketMQ,  
descomprímala en su disco local, por ejemplo en `D:\rocketmq`.  
Para usuarios de macOS y Linux, ejecute los siguientes comandos:  

```shell
# Download release from the Apache mirror
$ wget https://dist.apache.org/repos/dist/release/rocketmq/5.3.3/rocketmq-all-5.3.3-bin-release.zip

# Unpack the release
$ unzip rocketmq-all-5.3.3-bin-release.zip
```

Prepare un terminal y cambie al directorio `bin` extraído:
```shell
$ cd rocketmq-all-5.3.3-bin-release/bin
```

**1) Iniciar NameServer**

NameServer estará escuchando en `0.0.0.0:9876`, asegúrese de que el puerto no esté siendo utilizado por otros en la máquina local, y luego haga lo siguiente.

Para usuarios de macOS y Linux:
```shell
### start Name Server
$ nohup sh mqnamesrv &

### check whether Name Server is successfully started
$ tail -f ~/logs/rocketmqlogs/namesrv.log
The Name Server boot success...
```

Para usuarios de Windows, primero debe configurar las variables de entorno:
- Desde el escritorio, haga clic derecho en el icono de Equipo.
- Elija Propiedades en el menú contextual.
- Haga clic en el enlace Configuración avanzada del sistema.
- Haga clic en Variables de entorno.
- Agregue la variable de entorno `ROCKETMQ_HOME="D:\rocketmq"`. 

Luego cambie al directorio rocketmq, escriba y ejecute:
```shell
$ mqnamesrv.cmd
The Name Server boot success...
```

**2) Iniciar Broker**

Para usuarios de macOS y Linux:
```shell
### start Broker
$ nohup sh bin/mqbroker -n localhost:9876 &

### check whether Broker is successfully started, eg: Broker's IP is 192.168.1.2, Broker's name is broker-a
$ tail -f ~/logs/rocketmqlogs/broker.log
The broker[broker-a, 192.169.1.2:10911] boot success...
```

Para usuarios de Windows:
```shell
$ mqbroker.cmd -n localhost:9876
The broker[broker-a, 192.169.1.2:10911] boot success...
```

### Ejecutar RocketMQ en Docker

Puedes ejecutar RocketMQ en tu propia máquina dentro de contenedores Docker,  
se utilizará la red `host` para exponer el puerto de escucha en el contenedor.

**1) Iniciar NameServer**

```shell
$ docker run -it --net=host apache/rocketmq ./mqnamesrv
```

**2) Iniciar el Broker**

```shell
$ docker run -it --net=host --mount type=bind,source=/tmp/store,target=/home/rocketmq/store apache/rocketmq ./mqbroker -n localhost:9876
```

### Ejecutar RocketMQ en Kubernetes

También puedes ejecutar un clúster de RocketMQ dentro de un clúster de Kubernetes usando [RocketMQ Operator](https://github.com/apache/rocketmq-operator).  
Antes de tus operaciones, asegúrate de que `kubectl` y el archivo kubeconfig relacionado estén instalados en tu máquina.

**1) Instalar CRDs**
```shell
### install CRDs
$ git clone https://github.com/apache/rocketmq-operator
$ cd rocketmq-operator && make deploy

### check whether CRDs is successfully installed
$ kubectl get crd | grep rocketmq.apache.org
brokers.rocketmq.apache.org                 2022-05-12T09:23:18Z
consoles.rocketmq.apache.org                2022-05-12T09:23:19Z
nameservices.rocketmq.apache.org            2022-05-12T09:23:18Z
topictransfers.rocketmq.apache.org          2022-05-12T09:23:19Z

### check whether operator is running
$ kubectl get pods | grep rocketmq-operator
rocketmq-operator-6f65c77c49-8hwmj   1/1     Running   0          93s
```

**2) Crear instancia de clúster**
```shell
### create RocketMQ cluster resource
$ cd example && kubectl create -f rocketmq_v1alpha1_rocketmq_cluster.yaml

### check whether cluster resources is running
$ kubectl get sts
NAME                 READY   AGE
broker-0-master      1/1     107m
broker-0-replica-1   1/1     107m
name-service         1/1     107m
```

---
## Comunidad Apache RocketMQ
* [RocketMQ Streams](https://github.com/apache/rocketmq-streams): Un motor de computación en flujo ligero basado en Apache RocketMQ.
* [RocketMQ Flink](https://github.com/apache/rocketmq-flink): El conector de Apache RocketMQ para Apache Flink que soporta conectores fuente y sumidero en flujo de datos y Tabla.
* [RocketMQ APIs](https://github.com/apache/rocketmq-apis): Protocolo protobuf de RocketMQ.
* [RocketMQ Clients](https://github.com/apache/rocketmq-clients): Clientes RocketMQ basados en gRPC/protobuf.
* Clientes basados en RocketMQ Remoting
	 - [RocketMQ Client CPP](https://github.com/apache/rocketmq-client-cpp)
	 - [RocketMQ Client Go](https://github.com/apache/rocketmq-client-go)
	 - [RocketMQ Client Python](https://github.com/apache/rocketmq-client-python)
	 - [RocketMQ Client Nodejs](https://github.com/apache/rocketmq-client-nodejs)
* [RocketMQ Spring](https://github.com/apache/rocketmq-spring): Un proyecto que ayuda a los desarrolladores a integrar rápidamente Apache RocketMQ con Spring Boot.
* [RocketMQ Exporter](https://github.com/apache/rocketmq-exporter): Un exportador de Apache RocketMQ para Prometheus.
* [RocketMQ Operator](https://github.com/apache/rocketmq-operator): Proporciona una forma de ejecutar un clúster de Apache RocketMQ en Kubernetes.
* [RocketMQ Docker](https://github.com/apache/rocketmq-docker): El repositorio Git de la imagen Docker para Apache RocketMQ.
* [RocketMQ Dashboard](https://github.com/apache/rocketmq-dashboard): Consola de operación y mantenimiento de Apache RocketMQ.
* [RocketMQ Connect](https://github.com/apache/rocketmq-connect): Una herramienta para transmitir datos de forma escalable y confiable entre Apache RocketMQ y otros sistemas.
* [RocketMQ MQTT](https://github.com/apache/rocketmq-mqtt): Un nuevo modelo de arquitectura de protocolo MQTT, sobre el cual Apache RocketMQ puede soportar mejor mensajes de terminales como dispositivos IoT y aplicaciones móviles.
* [RocketMQ EventBridge](https://github.com/apache/rocketmq-eventbridge): EventBridge facilita la construcción de una aplicación orientada a eventos.
* [Proyectos de la Comunidad en Incubación de RocketMQ](https://github.com/apache/rocketmq-externals): Proyectos comunitarios incubados de Apache RocketMQ, incluyendo [logappender](https://github.com/apache/rocketmq-externals/tree/master/logappender), [rocketmq-ansible](https://github.com/apache/rocketmq-externals/tree/master/rocketmq-ansible), [rocketmq-beats-integration](https://github.com/apache/rocketmq-externals/tree/master/rocketmq-beats-integration), [rocketmq-cloudevents-binding](https://github.com/apache/rocketmq-externals/tree/master/rocketmq-cloudevents-binding), etc.
* [Sitio RocketMQ](https://github.com/apache/rocketmq-site): El repositorio para el sitio web de Apache RocketMQ.
* [RocketMQ E2E](https://github.com/apache/rocketmq-e2e): Un proyecto para probar Apache RocketMQ, incluyendo pruebas de extremo a extremo, rendimiento y compatibilidad.


----------
## Aprende y contáctanos
* Listas de correo: <https://rocketmq.apache.org/about/contact/>
* Inicio: <https://rocketmq.apache.org>
* Documentación: <https://rocketmq.apache.org/docs/quick-start/>
* Problemas: <https://github.com/apache/rocketmq/issues>
* Propuestas: <https://github.com/apache/rocketmq/wiki/RocketMQ-Improvement-Proposal>
* Pregunta: <https://stackoverflow.com/questions/tagged/rocketmq>
* Slack: <https://rocketmq-invite-automation.herokuapp.com/>


----------



## Contribuir
Siempre damos la bienvenida a nuevas contribuciones, ya sea para limpiezas triviales, [grandes nuevas funcionalidades](https://github.com/apache/rocketmq/wiki/RocketMQ-Improvement-Proposal) u otras recompensas materiales, más detalles véase [aquí](http://rocketmq.apache.org/docs/how-to-contribute/).

----------
## Licencia
[Licencia Apache, Versión 2.0](http://www.apache.org/licenses/LICENSE-2.0.html) Copyright (C) Fundación Apache Software


----------
## Aviso de Control de Exportación
Esta distribución incluye software criptográfico. El país en el que actualmente reside puede tener
restricciones sobre la importación, posesión, uso y/o reexportación a otro país, de software de cifrado.
ANTES de usar cualquier software de cifrado, por favor revise las leyes, regulaciones y políticas de su país
respecto a la importación, posesión, uso y reexportación de software de cifrado, para verificar si está permitido.
Consulte <http://www.wassenaar.org/> para más información.

El Departamento de Comercio del Gobierno de EE.UU., Oficina de Industria y Seguridad (BIS), ha clasificado este
software como Número de Control de Exportación de Mercancías (ECCN) 5D002.C.1, que incluye software de seguridad
informática que usa o realiza funciones criptográficas con algoritmos asimétricos. La forma y manera de esta
distribución de la Fundación Apache Software la hace elegible para exportación bajo la Excepción de Licencia ENC
Tecnología Software Sin Restricciones (TSU) (ver las Regulaciones de Administración de Exportaciones del BIS,
Sección 740.13) tanto para código objeto como para código fuente.

A continuación se proporcionan más detalles sobre el software criptográfico incluido:

Este software usa Apache Commons Crypto (https://commons.apache.org/proper/commons-crypto/) para
soportar autenticación, y encriptación y desencriptación de datos enviados a través de la red entre
servicios.

[maven-build-image]: https://github.com/apache/rocketmq/actions/workflows/maven.yaml/badge.svg
[maven-build-url]: https://github.com/apache/rocketmq/actions/workflows/maven.yaml
[codecov-image]: https://codecov.io/gh/apache/rocketmq/branch/master/graph/badge.svg
[codecov-url]: https://codecov.io/gh/apache/rocketmq
[maven-central-image]: https://maven-badges.herokuapp.com/maven-central/org.apache.rocketmq/rocketmq-all/badge.svg
[maven-central-url]: http://search.maven.org/#search%7Cga%7C1%7Corg.apache.rocketmq
[release-image]: https://img.shields.io/badge/release-download-orange.svg
[release-url]: https://www.apache.org/licenses/LICENSE-2.0.html
[license-image]: https://img.shields.io/badge/license-Apache%202-4EB1BA.svg
[license-url]: https://www.apache.org/licenses/LICENSE-2.0.html
[average-time-to-resolve-an-issue-image]: http://isitmaintained.com/badge/resolution/apache/rocketmq.svg
[average-time-to-resolve-an-issue-url]: http://isitmaintained.com/project/apache/rocketmq
[percentage-of-issues-still-open-image]: http://isitmaintained.com/badge/open/apache/rocketmq.svg
[percentage-of-issues-still-open-url]: http://isitmaintained.com/project/apache/rocketmq
[twitter-follow-image]: https://img.shields.io/twitter/follow/ApacheRocketMQ?style=social
[twitter-follow-url]: https://twitter.com/intent/follow?screen_name=ApacheRocketMQ


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-21

---