# Arquitecturas de Referencia y Pruebas de Entrenamiento de ML <!-- omit from toc -->

> **Advertencia**
> Actualmente estamos realizando una importante reestructuración de este repositorio, enfocada especialmente en la sección de casos de prueba. Si prefieres usar la estructura de directorios anterior y los casos de prueba obsoletos, por favor consulta [v1.1.0](https://github.com/aws-samples/awsome-distributed-training/releases/tag/v1.1.0).

Este repositorio contiene arquitecturas de referencia y casos de prueba para entrenamiento distribuido de modelos con [Amazon SageMaker Hyperpod](https://docs.aws.amazon.com/sagemaker/latest/dg/sagemaker-hyperpod.html), [AWS ParallelCluster](https://docs.aws.amazon.com/parallelcluster/latest/ug/what-is-aws-parallelcluster.html), [AWS Batch](https://docs.aws.amazon.com/batch/latest/userguide/what-is-batch.html) y [Amazon EKS](https://docs.aws.amazon.com/eks/latest/userguide/getting-started-console.html). Los casos de prueba cubren diferentes tipos y tamaños de modelos así como distintos frameworks y optimizaciones paralelas (Pytorch DDP/FSDP, MegatronLM, NemoMegatron...).

Los componentes principales de este directorio son:

```bash
reference-architectures/
|-- 1.architectures/               # Plantillas CloudFormation para arquitecturas de referencia
|-- 2.ami_and_containers/          # Scripts para crear AMIs e imágenes de contenedor
|-- 3.test_cases/                  # Casos de prueba de referencia y/o scripts de benchmark
|-- 4.validation_observability/    # Herramientas para medir rendimiento o resolver problemas
`-- ...
```

**NOTA**: las arquitecturas están diseñadas para funcionar con el bucket S3 y la VPC creados usando las plantillas de referencia `1.architectures/0.s3/` y `1.architectures/1.vpc_network/`. _Se recomienda encarecidamente desplegar estas dos plantillas **antes** de desplegar cualquiera de las arquitecturas de referencia._

## 0. Talleres

Puedes seguir los talleres a continuación para entrenar modelos en AWS. Cada uno contiene ejemplos para varios casos de prueba, así como información valiosa sobre la operación de un clúster para entrenamiento de LLM.

| Nombre                                                                           | Comentarios
| ------------------------------------------------------------------------------ | ------------------------------------------------------------------- |
| [Amazon SageMaker HyperPod](https://catalog.workshops.aws/sagemaker-hyperpod/en-US)   | Taller para SageMaker HyperPod, muestra cómo desplegarlo y monitorearlo |
| [AWS ParallelCluster](https://catalog.workshops.aws/ml-on-aws-parallelcluster) | Taller similar a HyperPod pero en ParallelCluster                 |
| [Amazon SageMaker HyperPod EKS](https://catalog.workshops.aws/sagemaker-hyperpod-eks)   | Taller para SageMaker HyperPod EKS, muestra cómo desplegarlo y monitorearlo |

## 1. Arquitecturas

Las arquitecturas se encuentran en `1.architectures` y consisten en utilidades y arquitecturas relacionadas con servicios.

| Nombre                                                               | Categoría | Uso                                               |
| ------------------------------------------------------------------ | -------- | --------------------------------------------------- |
| [`0.s3`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/0.s3)                                   | Almacenamiento  | Crear un bucket S3                                 |
| [`1.vpc_network`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/1.vpc_network)                 | Red  | Crear una VPC con subredes y recursos necesarios        |
| [`2.aws-parallelcluster`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/2.aws-parallelcluster) | Cómputo  | Plantillas de clúster para entrenamiento con GPU y silicio personalizado |
| [`3.aws-batch`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/3.aws-batch)                     | Cómputo  | Plantilla AWS Batch para entrenamiento distribuido         |
| [`4.amazon-eks`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/4.amazon-eks)                   | Cómputo  | Archivos manifiesto para entrenar con Amazon EKS             |
| [`5.sagemaker-hyperpod`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/5.sagemaker-hyperpod)   | Cómputo  | Plantilla SageMaker HyperPod para entrenamiento distribuido|

Vendrán más, siéntete libre de agregar nuevas (ej. Ray?). También encontrarás [documentación](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/efa-cheatsheet.md) para EFA y las variables de entorno recomendadas.

## 2. Imágenes Personalizadas de Amazon Machine

Las imágenes personalizadas pueden construirse usando [Packer](www.packer.io) para AWS ParallelCluster, Amazon EKS y EC2 simple. Estas imágenes se basan en roles y playbooks de Ansible.

## 3. Casos de prueba

Los casos de prueba están organizados por framework y cubren varios escenarios de entrenamiento distribuido. Cada caso incluye los scripts y configuraciones necesarias para ejecutar trabajos de entrenamiento distribuido.

### Casos de prueba PyTorch
- [`FSDP/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/FSDP) - Ejemplos de entrenamiento Fully Sharded Data Parallel
- [`megatron-lm/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/megatron-lm) - Ejemplos de entrenamiento distribuido Megatron-LM
- [`nemo-launcher/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/nemo-launcher) - Ejemplos de NeMo Launcher para entrenamiento distribuido. Este caso es solo para NeMo versión 1.0.
- [`nemo-run/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/nemo-run) - Ejemplos de entrenamiento distribuido con el framework NeMo. Este caso es para NeMo versión 2.0+.
- [`neuronx-distributed/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/neuronx-distributed) - Ejemplos de entrenamiento distribuido con AWS Trainium
- [`mosaicml-composer/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/mosaicml-composer) - Ejemplos de MosaicML Composer
- [`picotron/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/picotron) - Ejemplos de entrenamiento distribuido PicoTron
- [`torchtitan/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/torchtitan) - Ejemplos de TorchTitan
- [`cpu-ddp/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/cpu-ddp) - Ejemplos de Distributed Data Parallel basados en CPU
- [`bionemo/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/bionemo) - Ejemplos de entrenamiento distribuido BioNeMo

### Casos de prueba JAX
- [`jax/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/jax) - Ejemplos de entrenamiento distribuido basado en JAX usando PaxML

Cada caso incluye:
- Scripts y configuraciones de entrenamiento
- Definiciones de contenedores (cuando aplica)
- Scripts de lanzamiento para diferentes tipos de clúster
- Herramientas de monitoreo de rendimiento y validación

## 4. Scripts de Validación

Scripts utilitarios y ejemplos de micro-benchmarks están bajo `4.validation_scripts/`. El exportador Prometheus para EFA se encuentra en este [directorio](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/3.efa-node-exporter) 

| Nombre                                                                                    | Comentarios                                                        |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------- |
| [`1.pytorch-env-validation`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/1.pytorch-env-validation) | Valida tu entorno PyTorch                              |
| [`3.efa-node-exporter`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/3.efa-node-exporter)           | Exportador de nodo con módulos de monitoreo Amazon EFA                |
| [`4.prometheus-grafana`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/4.prometheus-grafana)         | Activos para despliegue para monitorear clústeres SageMaker Hyperpod        |
| [`5.nsight`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/5.nsight)                                 | Muestra cómo ejecutar Nvidia Nsight Systems para perfilar tu carga de trabajo |
| [`efa-versions.py`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/efa-versions.py)                                  | Obtiene las versiones de librerías Nvidia, drivers y drivers EFA   |

## 5. CI

Las pruebas de integración están escritas en [pytest](https://docs.pytest.org). Solo ejecuta:

```bash
pytest .
```

Alternativamente, puedes ejecutar las pruebas sin capturar stdout y manteniendo todas las imágenes docker y otros artefactos.

```bash
pytest -s --keep-artifacts=t
```

## 6. Contribuidores

Gracias a todos los colaboradores por construir, revisar y probar.

[![Contributors](https://contrib.rocks/image?repo=aws-samples/awsome-distributed-training)](https://github.com/aws-samples/awsome-distributed-training/graphs/contributors)

## 7.Historial de Estrellas

[![Star History Chart](https://api.star-history.com/svg?repos=aws-samples/awsome-distributed-training&type=Date)](https://star-history.com/#aws-samples/awsome-distributed-training&Date)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---