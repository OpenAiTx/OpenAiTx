# ML Training Reference Architectures & Tests <!-- omit from toc -->

> **Внимание**
> В настоящее время мы проводим масштабный рефакторинг этого репозитория, особенно раздела с тестовыми случаями. Если вы предпочитаете использовать прежнюю структуру каталогов и устаревшие тестовые случаи, пожалуйста, обратитесь к [v1.1.0](https://github.com/aws-samples/awsome-distributed-training/releases/tag/v1.1.0).


Этот репозиторий содержит эталонные архитектуры и тестовые случаи для распределенного обучения моделей с использованием [Amazon SageMaker Hyperpod](https://docs.aws.amazon.com/sagemaker/latest/dg/sagemaker-hyperpod.html), [AWS ParallelCluster](https://docs.aws.amazon.com/parallelcluster/latest/ug/what-is-aws-parallelcluster.html), [AWS Batch](https://docs.aws.amazon.com/batch/latest/userguide/what-is-batch.html) и [Amazon EKS](https://docs.aws.amazon.com/eks/latest/userguide/getting-started-console.html). Тестовые случаи охватывают различные типы и размеры моделей, а также разные фреймворки и параллельные оптимизации (Pytorch DDP/FSDP, MegatronLM, NemoMegatron...).

Основные компоненты этого каталога:

```bash
reference-architectures/
|-- 1.architectures/               # CloudFormation шаблоны эталонных архитектур
|-- 2.ami_and_containers/          # Скрипты для создания AMI и контейнерных образов
|-- 3.test_cases/                  # Эталонные тестовые случаи и/или скрипты бенчмарков
|-- 4.validation_observability/    # Инструменты для измерения производительности или отладки
`-- ...
```

**ПРИМЕЧАНИЕ**: архитектуры разработаны для работы с S3 бакетом и VPC, созданными с помощью эталонных шаблонов из `1.architectures/0.s3/` и `1.architectures/1.vpc_network/`. _Настоятельно рекомендуется развернуть эти два шаблона **до** развертывания любых эталонных архитектур._

## 0. Воркшопы

Вы можете пройти приведённые ниже воркшопы для обучения моделей на AWS. Каждый содержит примеры нескольких тестовых случаев, а также полезную информацию по эксплуатации кластера для обучения LLM.

| Название                                                                        | Комментарии                                                      |
| ------------------------------------------------------------------------------ | ---------------------------------------------------------------- |
| [Amazon SageMaker HyperPod](https://catalog.workshops.aws/sagemaker-hyperpod/en-US)   | Воркшоп по SageMaker HyperPod, показывает, как развернуть и мониторить |
| [AWS ParallelCluster](https://catalog.workshops.aws/ml-on-aws-parallelcluster) | Аналогичный воркшоп, но для ParallelCluster                      |
| [Amazon SageMaker HyperPod EKS](https://catalog.workshops.aws/sagemaker-hyperpod-eks)   | Воркшоп по SageMaker HyperPod EKS, показывает, как развернуть и мониторить |

## 1. Архитектуры

Архитектуры расположены в `1.architectures` и включают утилиты и сервисные архитектуры.

| Название                                                             | Категория | Назначение                                            |
| ------------------------------------------------------------------ | -------- | --------------------------------------------------- |
| [`0.s3`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/0.s3)                                   | Хранение  | Создание S3 бакета                                 |
| [`1.vpc_network`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/1.vpc_network)                 | Сеть  | Создание VPC с подсетями и необходимыми ресурсами        |
| [`2.aws-parallelcluster`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/2.aws-parallelcluster) | Вычисления  | Шаблоны кластеров для обучения на GPU и кастомных процессорах |
| [`3.aws-batch`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/3.aws-batch)                     | Вычисления  | Шаблон AWS Batch для распределенного обучения         |
| [`4.amazon-eks`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/4.amazon-eks)                   | Вычисления  | Манифесты для обучения с Amazon EKS             |
| [`5.sagemaker-hyperpod`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/5.sagemaker-hyperpod)   | Вычисления  | Шаблон SageMaker HyperPod для распределенного обучения|

Будут добавлены новые, не стесняйтесь предлагать (например, Ray?). Также вы найдете [документацию](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/efa-cheatsheet.md) по EFA и рекомендуемым переменным окружения.

## 2. Кастомные образы Amazon Machine Images

Кастомные образы можно создавать с помощью [Packer](www.packer.io) для AWS ParallelCluster, Amazon EKS и обычных EC2. Эти образы основаны на ролях и плейбуках Ansible.

## 3. Тестовые случаи

Тестовые случаи организованы по фреймворкам и охватывают различные сценарии распределенного обучения. Каждый тестовый случай включает необходимые скрипты и конфигурации для запуска заданий распределенного обучения.

### Тестовые случаи PyTorch
- [`FSDP/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/FSDP) - Примеры обучения с Fully Sharded Data Parallel
- [`megatron-lm/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/megatron-lm) - Примеры распределенного обучения Megatron-LM
- [`nemo-launcher/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/nemo-launcher) - Примеры NeMo Launcher для распределенного обучения. Этот тестовый случай для версии NeMo 1.0.
- [`nemo-run/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/nemo-run) - Примеры распределенного обучения на фреймворке NeMo. Этот тестовый случай для версии NeMo 2.0+.
- [`neuronx-distributed/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/neuronx-distributed) - Примеры распределенного обучения AWS Trainium
- [`mosaicml-composer/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/mosaicml-composer) - Примеры MosaicML Composer
- [`picotron/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/picotron) - Примеры распределенного обучения PicoTron
- [`torchtitan/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/torchtitan) - Примеры TorchTitan
- [`cpu-ddp/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/cpu-ddp) - Примеры распределенного обучения на CPU с Distributed Data Parallel
- [`bionemo/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/bionemo) - Примеры распределенного обучения BioNeMo

### Тестовые случаи JAX
- [`jax/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/jax) - Примеры распределенного обучения на JAX с использованием PaxML

Каждый тестовый случай включает:
- Скрипты и конфигурации для обучения
- Определения контейнеров (где применимо)
- Скрипты запуска для различных типов кластеров
- Инструменты мониторинга производительности и валидации

## 4. Скрипты валидации

Утилиты и примеры микро-бенчмарков находятся в `4.validation_scripts/`. Экспортер EFA для Prometheus можно найти в этом [каталоге](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/3.efa-node-exporter) 


| Название                                                                                  | Комментарии                                                       |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------- |
| [`1.pytorch-env-validation`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/1.pytorch-env-validation) | Проверка вашей среды PyTorch                                      |
| [`3.efa-node-exporter`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/3.efa-node-exporter)           | Node exporter с модулями мониторинга Amazon EFA                  |
| [`4.prometheus-grafana`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/4.prometheus-grafana)         | Ресурсы для развертывания мониторинга кластеров SageMaker Hyperpod        |
| [`5.nsight`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/5.nsight)                                 | Инструкция по запуску Nvidia Nsight Systems для профилирования нагрузки |
| [`efa-versions.py`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/efa-versions.py)                                  | Получение версий библиотек Nvidia, драйверов и драйверов EFA      |


## 5. CI

Интеграционные тесты написаны с использованием [pytest](https://docs.pytest.org). Просто выполните:

```bash
pytest .
```

Альтернативно можно запускать тесты без захвата stdout и с сохранением всех docker образов и других артефактов.

```bash
pytest -s --keep-artifacts=t
```

## 6. Участники

Спасибо всем участникам за создание, рецензирование и тестирование.

[![Contributors](https://contrib.rocks/image?repo=aws-samples/awsome-distributed-training)](https://github.com/aws-samples/awsome-distributed-training/graphs/contributors)

## 7. История звёзд

[![Star History Chart](https://api.star-history.com/svg?repos=aws-samples/awsome-distributed-training&type=Date)](https://star-history.com/#aws-samples/awsome-distributed-training&Date)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---