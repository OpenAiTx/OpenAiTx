# ML Training Reference Architectures & Tests <!-- omit from toc -->

> **Ostrzeżenie**
> Obecnie przeprowadzamy gruntowną refaktoryzację tego repozytorium, szczególnie koncentrując się na sekcji testów. Jeśli wolisz korzystać z poprzedniej struktury katalogów i przestarzałych przypadków testowych, odwołaj się do [v1.1.0](https://github.com/aws-samples/awsome-distributed-training/releases/tag/v1.1.0).


To repozytorium zawiera referencyjne architektury i przypadki testowe do rozproszonego trenowania modeli z użyciem [Amazon SageMaker Hyperpod](https://docs.aws.amazon.com/sagemaker/latest/dg/sagemaker-hyperpod.html), [AWS ParallelCluster](https://docs.aws.amazon.com/parallelcluster/latest/ug/what-is-aws-parallelcluster.html), [AWS Batch](https://docs.aws.amazon.com/batch/latest/userguide/what-is-batch.html) oraz [Amazon EKS](https://docs.aws.amazon.com/eks/latest/userguide/getting-started-console.html). Przypadki testowe obejmują różne typy i rozmiary modeli oraz różne frameworki i optymalizacje równoległe (Pytorch DDP/FSDP, MegatronLM, NemoMegatron...).

Główne składniki tego katalogu to:

```bash
reference-architectures/
|-- 1.architectures/               # Szablony CloudFormation dla architektur referencyjnych
|-- 2.ami_and_containers/          # Skrypty do tworzenia AMI i obrazów kontenerów
|-- 3.test_cases/                  # Referencyjne przypadki testowe i/lub skrypty benchmarkowe
|-- 4.validation_observability/    # Narzędzia do pomiaru wydajności lub rozwiązywania problemów
`-- ...
```

**UWAGA**: architektury zostały zaprojektowane do pracy z bucketem S3 i VPC utworzonymi przy użyciu szablonów referencyjnych `1.architectures/0.s3/` oraz `1.architectures/1.vpc_network/`. _Zalecamy zdecydowanie wdrożenie tych dwóch szablonów **przed** wdrożeniem jakiejkolwiek architektury referencyjnej._

## 0. Warsztaty

Możesz skorzystać z poniższych warsztatów, aby trenować modele na AWS. Każdy zawiera przykłady dla kilku przypadków testowych oraz cenne informacje dotyczące obsługi klastra do trenowania LLM.

| Nazwa                                                                           | Komentarze
| ------------------------------------------------------------------------------ | ------------------------------------------------------------------- |
| [Amazon SageMaker HyperPod](https://catalog.workshops.aws/sagemaker-hyperpod/en-US)   | Warsztat dla SageMaker HyperPod, pokazuje jak go wdrożyć i monitorować |
| [AWS ParallelCluster](https://catalog.workshops.aws/ml-on-aws-parallelcluster) | Podobny warsztat jak HyperPod, ale na ParallelCluster                |
| [Amazon SageMaker HyperPod EKS](https://catalog.workshops.aws/sagemaker-hyperpod-eks)   | Warsztat dla SageMaker HyperPod EKS, pokazuje jak go wdrożyć i monitorować |

## 1. Architektury

Architektury znajdują się w `1.architectures` i składają się z narzędzi oraz architektur powiązanych z usługami.

| Nazwa                                                               | Kategoria | Zastosowanie                                         |
| ------------------------------------------------------------------ | -------- | --------------------------------------------------- |
| [`0.s3`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/0.s3)                                   | Storage  | Tworzenie bucketu S3                                 |
| [`1.vpc_network`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/1.vpc_network)                 | Network  | Tworzenie VPC z podsieciami i potrzebnymi zasobami  |
| [`2.aws-parallelcluster`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/2.aws-parallelcluster) | Compute  | Szablony klastra dla GPU i niestandardowego silikonu |
| [`3.aws-batch`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/3.aws-batch)                     | Compute  | Szablon AWS Batch do trenowania rozproszonego       |
| [`4.amazon-eks`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/4.amazon-eks)                   | Compute  | Pliki manifestu do trenowania z Amazon EKS           |
| [`5.sagemaker-hyperpod`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/5.sagemaker-hyperpod)   | Compute  | Szablon SageMaker HyperPod do trenowania rozproszonego|

Więcej wkrótce, zachęcamy do dodawania nowych (np. Ray?). Znajdziesz tu także [dokumentację](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/efa-cheatsheet.md) dla EFA oraz zalecane zmienne środowiskowe.

## 2. Niestandardowe Amazon Machine Images

Niestandardowe obrazy maszyn można budować za pomocą [Packer](https://www.packer.io) dla AWS ParallelCluster, Amazon EKS oraz zwykłych EC2. Obrazy te bazują na rolach i playbookach Ansible.

## 3. Przypadki testowe

Przypadki testowe są zorganizowane według frameworków i obejmują różne scenariusze trenowania rozproszonego. Każdy przypadek testowy zawiera niezbędne skrypty i konfiguracje do uruchomienia zadań trenowania rozproszonego.

### Przypadki testowe PyTorch
- [`FSDP/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/FSDP) - Przykłady trenowania Fully Sharded Data Parallel
- [`megatron-lm/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/megatron-lm) - Przykłady rozproszonego trenowania Megatron-LM
- [`nemo-launcher/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/nemo-launcher) - Przykłady NeMo Launcher dla trenowania rozproszonego. Ten przypadek testowy dotyczy tylko wersji NeMo 1.0.
- [`nemo-run/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/nemo-run) - Przykłady trenowania rozproszonego w frameworku NeMo. Ten przypadek testowy dotyczy wersji NeMo 2.0+.
- [`neuronx-distributed/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/neuronx-distributed) - Przykłady trenowania rozproszonego na AWS Trainium
- [`mosaicml-composer/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/mosaicml-composer) - Przykłady MosaicML Composer
- [`picotron/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/picotron) - Przykłady trenowania rozproszonego PicoTron
- [`torchtitan/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/torchtitan) - Przykłady TorchTitan
- [`cpu-ddp/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/cpu-ddp) - Przykłady Distributed Data Parallel na CPU
- [`bionemo/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/bionemo) - Przykłady trenowania rozproszonego BioNeMo

### Przypadki testowe JAX
- [`jax/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/jax) - Przykłady trenowania rozproszonego opartego na JAX z użyciem PaxML

Każdy przypadek testowy zawiera:
- Skrypty i konfiguracje trenowania
- Definicje kontenerów (jeśli dotyczy)
- Skrypty uruchamiające dla różnych typów klastrów
- Narzędzia do monitoringu wydajności i walidacji

## 4. Skrypty walidacyjne

Skrypty narzędziowe oraz przykłady mikrobenchmarków znajdują się w katalogu `4.validation_scripts/`. Eksporter Prometheus dla EFA znajduje się w tym [katalogu](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/3.efa-node-exporter) 


| Nazwa                                                                                    | Komentarze                                                        |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------- |
| [`1.pytorch-env-validation`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/1.pytorch-env-validation) | Waliduje środowisko PyTorch                                      |
| [`3.efa-node-exporter`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/3.efa-node-exporter)           | Eksporter node z modułami monitoringu Amazon EFA                |
| [`4.prometheus-grafana`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/4.prometheus-grafana)         | Zasoby do wdrożenia monitoringu klastrów SageMaker Hyperpod    |
| [`5.nsight`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/5.nsight)                                 | Pokazuje jak uruchomić Nvidia Nsight Systems do profilowania pracy |
| [`efa-versions.py`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/efa-versions.py)                                  | Pobiera wersje bibliotek Nvidia, sterowników i sterowników EFA  |


## 5. CI

Testy integracyjne napisane są w [pytest](https://docs.pytest.org). Wystarczy uruchomić:

```bash
pytest .
```

Alternatywnie możesz uruchomić testy bez przechwytywania stdout i zachowując wszystkie obrazy dockera oraz inne artefakty.

```bash
pytest -s --keep-artifacts=t
```

## 6. Współtwórcy

Dziękujemy wszystkim współtwórcom za budowanie, przegląd i testowanie.

[![Contributors](https://contrib.rocks/image?repo=aws-samples/awsome-distributed-training)](https://github.com/aws-samples/awsome-distributed-training/graphs/contributors)

## 7. Historia Gwiazdek

[![Star History Chart](https://api.star-history.com/svg?repos=aws-samples/awsome-distributed-training&type=Date)](https://star-history.com/#aws-samples/awsome-distributed-training&Date)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---