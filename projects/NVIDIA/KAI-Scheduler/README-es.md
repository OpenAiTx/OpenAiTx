[![Licencia](https://img.shields.io/badge/License-Apache_2.0-blue.svg)](LICENSE) [![Cobertura](https://github.com/NVIDIA/KAI-Scheduler/raw/coverage-badge/badges/coverage.svg)](https://github.com/NVIDIA/KAI-Scheduler/blob/main/.github/workflows/update-coverage-badge.yaml)
# KAI Scheduler
KAI Scheduler es un [planificador de Kubernetes](https://kubernetes.io/docs/concepts/scheduling-eviction/kube-scheduler/) robusto, eficiente y escalable que optimiza la asignación de recursos GPU para cargas de trabajo de IA y aprendizaje automático.

Diseñado para gestionar clústeres de GPU a gran escala, incluidos miles de nodos y un alto rendimiento de cargas de trabajo, el KAI Scheduler es ideal para entornos extensos y exigentes.
KAI Scheduler permite a los administradores de clústeres de Kubernetes asignar dinámicamente recursos GPU a las cargas de trabajo.

KAI Scheduler admite todo el ciclo de vida de la IA, desde trabajos pequeños e interactivos que requieren recursos mínimos hasta grandes procesos de entrenamiento e inferencia, todo dentro del mismo clúster.
Garantiza una asignación óptima de recursos mientras mantiene la equidad de recursos entre los diferentes consumidores.
Puede ejecutarse junto con otros planificadores instalados en el clúster.

## Características principales
* [Planificación por lotes](docs/batch/README.md): Garantiza que todos los pods en un grupo se programen simultáneamente o ninguno.
* Empaquetado y distribución de pods: Optimiza el uso de nodos minimizando la fragmentación (empaquetado) o aumentando la resiliencia y el balanceo de carga (planificación de distribución).
* [Prioridad de cargas de trabajo](docs/priority/README.md): Prioriza las cargas de trabajo de manera efectiva dentro de las colas.
* [Colas jerárquicas](docs/queues/README.md): Gestiona cargas de trabajo con jerarquías de colas de dos niveles para un control organizacional flexible.
* [Distribución de recursos](docs/fairness/README.md#resource-division-algorithm): Personaliza cuotas, pesos de sobrecuota, límites y prioridades por cola.
* [Políticas de equidad](docs/fairness/README.md#reclaim-strategies): Garantiza una distribución equitativa de recursos utilizando Dominant Resource Fairness (DRF) y la recuperación de recursos entre colas.
* Consolidación de cargas de trabajo: Realoca cargas de trabajo en ejecución de manera inteligente para reducir la fragmentación y aumentar la utilización del clúster.
* [Cargas de trabajo elásticas](docs/elastic/README.md): Escala dinámicamente cargas de trabajo dentro de un conteo mínimo y máximo de pods definido.
* Asignación dinámica de recursos (DRA): Soporta recursos de hardware específicos de proveedores a través de ResourceClaims de Kubernetes (por ejemplo, GPUs de NVIDIA o AMD).
* [Compartición de GPU](docs/gpu-sharing/README.md): Permite que múltiples cargas de trabajo compartan eficiente una o varias GPUs, maximizando la utilización de recursos.
* Soporte en la nube y en local: Totalmente compatible con infraestructuras dinámicas en la nube (incluyendo autoescaladores como Karpenter) así como implementaciones estáticas en local.

## Requisitos previos
Antes de instalar KAI Scheduler, asegúrese de tener:

- Un clúster de Kubernetes en funcionamiento
- [Helm](https://helm.sh/docs/intro/install) CLI instalado
- [NVIDIA GPU-Operator](https://github.com/NVIDIA/gpu-operator) instalado para poder programar cargas de trabajo que requieran recursos GPU

## Instalación
KAI Scheduler se instalará en el espacio de nombres `kai-scheduler`. Al enviar cargas de trabajo, asegúrese de usar un espacio de nombres dedicado.

### Métodos de instalación
KAI Scheduler puede instalarse:

- **Desde Producción (Recomendado)**
- **Desde el código fuente (Compílalo tú mismo)**

#### Instalar desde Producción
Ubique la última versión en la página de [lanzamientos](https://github.com/NVIDIA/KAI-Scheduler/releases).
Ejecute el siguiente comando después de reemplazar `<VERSION>` con la versión de lanzamiento deseada:
```sh
helm upgrade -i kai-scheduler oci://ghcr.io/nvidia/kai-scheduler/kai-scheduler -n kai-scheduler --create-namespace --version <VERSION>
```
#### Compilar desde el código fuente
Siga las instrucciones [aquí](docs/developer/building-from-source.md)

## Inicio rápido
Para comenzar a programar cargas de trabajo con KAI Scheduler, continúe con el [ejemplo de inicio rápido](docs/quickstart/README.md)

## Hoja de ruta

### Descripción general de las principales prioridades para 2025
* Refactorizar la base de código para mejorar la neutralidad de proveedores
* Soportar Scheduling Gates https://github.com/NVIDIA/KAI-Scheduler/issues/63
* Investigar la posible integración con Kueue https://github.com/NVIDIA/KAI-Scheduler/issues/68
* Añadir soporte de Planificación Consciente de la Topología para pod-group https://github.com/NVIDIA/KAI-Scheduler/issues/66
* Soportar tiempo mínimo de ejecución por carga de trabajo
* Soportar tiempo máximo de ejecución por carga de trabajo (con reencolado diferido)
* Añadir más PriorityClasses como parte de la instalación predeterminada de KAI
* Soportar JobSet
* Soportar LWS (LeaderWorkerSet)
* Añadir métricas para preempciones de pod y pod-group
* Desacoplar Prioridad y Preempción

### Objetivos a largo plazo
* Soportar decaimiento temporal por cola
* Mejoras para hiperescalabilidad
* Soportar consolidación de cargas de trabajo de inferencia para la desfragmentación del clúster
* Soportar n-niveles de colas jerárquicas
* Despliegue gradual de cargas de trabajo de inferencia (nueva actualización de revisión usando sobrecuota temporal en la cola)

## Comunidad, discusión y soporte

¡Nos encantaría saber de ti! Aquí tienes las mejores formas de conectar:

### Slack
Únete primero a [CNCF Slack](https://communityinviter.com/apps/cloud-native/cncf) y visita el canal [#kai-scheduler](https://cloud-native.slack.com/archives/kai-scheduler).

### Llamada comunitaria quincenal  
**Cuándo:** Cada dos lunes a las 17:00 CEST  
[Convierte a tu zona horaria](https://dateful.com/time-zone-converter?t=17&tz2=Germany) | [Agrega a tu calendario](https://calendar.google.com/calendar/event?action=TEMPLATE&tmeid=N2Q2bjhoNXAzMGc0cWpnZTQ4OGtpdXFhanFfMjAyNTA2MDlUMTUwMDAwWiAxZjQ2OTZiOWVlM2JiMWE1ZWIzMTAwODBkNDZiZmMwMDZjNTUxYWFiZmU1YTM3ZGM2YTc0NTFhYmNhMmE1ODk0QGc&tmsrc=1f4696b9ee3bb1a5eb310080d46bfc006c551aabfe5a37dc6a7451abca2a5894%40group.calendar.google.com&scp=ALL)  | [Notas y agenda de la reunión](https://docs.google.com/document/d/13K7NGdPebOstlrsif1YLjGz1x-aJafMXeIgqbO7WghI/edit?usp=sharing)

### Lista de correo  
Únete a la [lista de correo de kai-scheduler](https://groups.google.com/g/kai-scheduler) para recibir actualizaciones sobre las reuniones quincenales.

### Problemas técnicos y solicitudes de funcionalidades  
Por favor, abre un [issue de GitHub](https://github.com/NVIDIA/KAI-Scheduler/issues/new/choose) para bugs, sugerencias de funcionalidades o ayuda técnica. Esto nos ayuda a hacer seguimiento de las solicitudes y responder de manera efectiva.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---