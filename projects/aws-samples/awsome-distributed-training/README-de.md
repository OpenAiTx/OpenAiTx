# ML Training Referenzarchitekturen & Tests <!-- omit from toc -->

> **Warnung**
> Wir führen derzeit eine umfassende Umstrukturierung dieses Repositories durch, insbesondere im Bereich der Testfälle. Wenn Sie die vorherige Verzeichnisstruktur und veraltete Testfälle verwenden möchten, siehe bitte [v1.1.0](https://github.com/aws-samples/awsome-distributed-training/releases/tag/v1.1.0).


Dieses Repository enthält Referenzarchitekturen und Testfälle für verteiltes Modelltraining mit [Amazon SageMaker Hyperpod](https://docs.aws.amazon.com/sagemaker/latest/dg/sagemaker-hyperpod.html), [AWS ParallelCluster](https://docs.aws.amazon.com/parallelcluster/latest/ug/what-is-aws-parallelcluster.html), [AWS Batch](https://docs.aws.amazon.com/batch/latest/userguide/what-is-batch.html) und [Amazon EKS](https://docs.aws.amazon.com/eks/latest/userguide/getting-started-console.html). Die Testfälle decken verschiedene Typen und Größen von Modellen sowie unterschiedliche Frameworks und parallele Optimierungen ab (Pytorch DDP/FSDP, MegatronLM, NemoMegatron...).

Die Hauptkomponenten dieses Verzeichnisses sind:

```bash
reference-architectures/
|-- 1.architectures/               # CloudFormation-Vorlagen für Referenzarchitektur
|-- 2.ami_and_containers/          # Skripte zur Erstellung von AMIs und Container-Images
|-- 3.test_cases/                  # Referenz-Testfälle und/oder Benchmark-Skripte
|-- 4.validation_observability/    # Tools zur Leistungsüberwachung oder Fehlerbehebung
`-- ...
```

**HINWEIS**: Die Architekturen sind so konzipiert, dass sie mit dem S3-Bucket und VPC funktionieren, die mit den Referenzvorlagen `1.architectures/0.s3/` und `1.architectures/1.vpc_network/` erstellt wurden. _Es wird dringend empfohlen, diese beiden Vorlagen **vor** der Bereitstellung einer der Referenzarchitekturen zu deployen._

## 0. Workshops

Sie können dem untenstehenden Workshop folgen, um Modelle auf AWS zu trainieren. Jeder enthält Beispiele für mehrere Testfälle sowie wichtige Informationen zum Betrieb eines Clusters für LLM-Training.

| Name                                                                           | Kommentare
| ------------------------------------------------------------------------------ | ------------------------------------------------------------------- |
| [Amazon SageMaker HyperPod](https://catalog.workshops.aws/sagemaker-hyperpod/en-US)   | Workshop für SageMaker HyperPod, zeigt, wie man es bereitstellt und überwacht |
| [AWS ParallelCluster](https://catalog.workshops.aws/ml-on-aws-parallelcluster) | Ähnlicher Workshop wie HyperPod, aber für ParallelCluster          |
| [Amazon SageMaker HyperPod EKS](https://catalog.workshops.aws/sagemaker-hyperpod-eks)   | Workshop für SageMaker HyperPod EKS, zeigt, wie man es bereitstellt und überwacht |

## 1. Architekturen

Architekturen befinden sich in `1.architectures` und bestehen aus Dienst- und Hilfsarchitekturen.

| Name                                                               | Kategorie | Verwendung                                         |
| ------------------------------------------------------------------ | -------- | ------------------------------------------------- |
| [`0.s3`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/0.s3)                                   | Speicher  | Erstellen eines S3-Buckets                         |
| [`1.vpc_network`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/1.vpc_network)                 | Netzwerk  | Erstellen eines VPC mit Subnetzen und erforderlichen Ressourcen |
| [`2.aws-parallelcluster`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/2.aws-parallelcluster) | Compute  | Clustervorlagen für GPU- und benutzerdefiniertes Silizium-Training |
| [`3.aws-batch`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/3.aws-batch)                     | Compute  | AWS Batch Vorlage für verteiltes Training         |
| [`4.amazon-eks`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/4.amazon-eks)                   | Compute  | Manifestdateien für Training mit Amazon EKS        |
| [`5.sagemaker-hyperpod`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/5.sagemaker-hyperpod)   | Compute  | SageMaker HyperPod Vorlage für verteiltes Training|

Weitere werden folgen, Sie können gerne neue hinzufügen (z.B. Ray?). Sie finden auch [Dokumentation](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/efa-cheatsheet.md) zu EFA und den empfohlenen Umgebungsvariablen.

## 2. Benutzerdefinierte Amazon Machine Images

Benutzerdefinierte Machine Images können mit [Packer](www.packer.io) für AWS ParallelCluster, Amazon EKS und einfache EC2-Instanzen erstellt werden. Diese Images basieren auf Ansible-Rollen und Playbooks.

## 3. Testfälle

Testfälle sind nach Framework organisiert und decken verschiedene Szenarien des verteilten Trainings ab. Jeder Testfall enthält die notwendigen Skripte und Konfigurationen für verteilte Trainingsjobs.

### PyTorch Testfälle
- [`FSDP/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/FSDP) - Vollständig geshardete Data Parallel Trainingsbeispiele
- [`megatron-lm/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/megatron-lm) - Megatron-LM verteilte Trainingsbeispiele
- [`nemo-launcher/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/nemo-launcher) - NeMo Launcher Beispiele für verteiltes Training. Dieser Testfall ist nur für NeMo Version 1.0.
- [`nemo-run/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/nemo-run) - NeMo Framework verteilte Trainingsbeispiele. Dieser Testfall ist für NeMo Version 2.0+.
- [`neuronx-distributed/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/neuronx-distributed) - AWS Trainium verteilte Trainingsbeispiele
- [`mosaicml-composer/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/mosaicml-composer) - MosaicML Composer Beispiele
- [`picotron/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/picotron) - PicoTron verteilte Trainingsbeispiele
- [`torchtitan/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/torchtitan) - TorchTitan Beispiele
- [`cpu-ddp/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/cpu-ddp) - CPU-basierte Distributed Data Parallel Beispiele
- [`bionemo/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/bionemo) - BioNeMo verteilte Trainingsbeispiele

### JAX Testfälle
- [`jax/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/jax) - JAX-basierte verteilte Trainingsbeispiele mit PaxML

Jeder Testfall enthält:
- Trainingsskripte und Konfigurationen
- Container-Definitionen (wenn anwendbar)
- Startskripte für verschiedene Clustertypen
- Leistungsüberwachungs- und Validierungstools

## 4. Validierungsskripte

Hilfsskripte und Micro-Benchmark-Beispiele sind unter `4.validation_scripts/` zu finden. Der EFA Prometheus Exporter befindet sich in diesem [Verzeichnis](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/3.efa-node-exporter) 


| Name                                                                                    | Kommentare                                                      |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------- |
| [`1.pytorch-env-validation`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/1.pytorch-env-validation) | Validiert Ihre PyTorch Umgebung                                 |
| [`3.efa-node-exporter`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/3.efa-node-exporter)           | Node Exporter mit Amazon EFA Monitoring-Modulen                |
| [`4.prometheus-grafana`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/4.prometheus-grafana)         | Bereitstellungs-Assets zur Überwachung von SageMaker Hyperpod Clustern |
| [`5.nsight`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/5.nsight)                                 | Zeigt, wie Nvidia Nsight Systems ausgeführt wird, um Ihre Workloads zu profilieren |
| [`efa-versions.py`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/efa-versions.py)                                  | Ermittelt die Versionen der Nvidia-Bibliotheken, Treiber und EFA-Treiber |


## 5. CI

Integrationstests sind in [pytest](https://docs.pytest.org) geschrieben. Einfach ausführen:

```bash
pytest .
```

Alternativ können Sie Tests ohne stdout-Capturing ausführen und alle Docker-Images sowie andere Artefakte behalten.

```bash
pytest -s --keep-artifacts=t
```

## 6. Beitragende

Vielen Dank an alle Beitragenden für den Aufbau, die Überprüfung und das Testen.

[![Beitragende](https://contrib.rocks/image?repo=aws-samples/awsome-distributed-training)](https://github.com/aws-samples/awsome-distributed-training/graphs/contributors)

## 7. Sternverlauf

[![Sternverlauf Diagramm](https://api.star-history.com/svg?repos=aws-samples/awsome-distributed-training&type=Date)](https://star-history.com/#aws-samples/awsome-distributed-training&Date)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---