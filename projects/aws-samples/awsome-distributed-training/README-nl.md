# ML Training Referentie Architecturen & Tests <!-- omit from toc -->

> **Waarschuwing**
> We ondergaan momenteel een grote herstructurering van deze repository, met name gericht op de sectie met testgevallen. Als je de vorige mappenstructuur en verouderde testgevallen wilt gebruiken, raadpleeg dan [v1.1.0](https://github.com/aws-samples/awsome-distributed-training/releases/tag/v1.1.0).

Deze repository bevat referentiearchitecturen en testgevallen voor gedistribueerde modeltraining met [Amazon SageMaker Hyperpod](https://docs.aws.amazon.com/sagemaker/latest/dg/sagemaker-hyperpod.html), [AWS ParallelCluster](https://docs.aws.amazon.com/parallelcluster/latest/ug/what-is-aws-parallelcluster.html), [AWS Batch](https://docs.aws.amazon.com/batch/latest/userguide/what-is-batch.html), en [Amazon EKS](https://docs.aws.amazon.com/eks/latest/userguide/getting-started-console.html). De testgevallen behandelen verschillende typen en groottes van modellen evenals verschillende frameworks en parallelle optimalisaties (Pytorch DDP/FSDP, MegatronLM, NemoMegatron...).

De belangrijkste onderdelen van deze directory zijn:

```bash
reference-architectures/
|-- 1.architectures/               # CloudFormation-sjablonen voor referentie-architecturen
|-- 2.ami_and_containers/          # Scripts om AMI's en containerimages te maken
|-- 3.test_cases/                  # Referentie testgevallen en/of benchmark scripts
|-- 4.validation_observability/    # Hulpmiddelen om prestaties te meten of problemen op te lossen
`-- ...
```

**OPMERKING**: de architecturen zijn ontworpen om te werken met de S3-bucket en VPC die zijn aangemaakt met de referentiesjablonen `1.architectures/0.s3/` en `1.architectures/1.vpc_network/`. _Het wordt sterk aanbevolen om deze twee sjablonen **te deployen voordat** je een van de referentiearchitecturen uitrolt._

## 0. Workshops

Je kunt onderstaande workshops volgen om modellen te trainen op AWS. Elke workshop bevat voorbeelden voor verschillende testgevallen evenals nuttige informatie over het beheren van een cluster voor LLM-training.

| Naam                                                                             | Opmerkingen                                                        |
| -------------------------------------------------------------------------------- | ----------------------------------------------------------------- |
| [Amazon SageMaker HyperPod](https://catalog.workshops.aws/sagemaker-hyperpod/en-US)   | Workshop voor SageMaker HyperPod, laat zien hoe je het uitrolt en monitort |
| [AWS ParallelCluster](https://catalog.workshops.aws/ml-on-aws-parallelcluster)   | Vergelijkbare workshop als HyperPod maar voor ParallelCluster     |
| [Amazon SageMaker HyperPod EKS](https://catalog.workshops.aws/sagemaker-hyperpod-eks) | Workshop voor SageMaker HyperPod EKS, laat zien hoe je het uitrolt en monitort |

## 1. Architecturen

Architecturen bevinden zich in `1.architectures` en bestaan uit hulpmiddelen en service-gerelateerde architecturen.

| Naam                                                               | Categorie | Gebruik                                              |
| ------------------------------------------------------------------ | --------- | --------------------------------------------------- |
| [`0.s3`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/0.s3)                                   | Opslag    | Maak een S3-bucket                                   |
| [`1.vpc_network`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/1.vpc_network)                 | Netwerk   | Maak een VPC met subnets en vereiste resources       |
| [`2.aws-parallelcluster`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/2.aws-parallelcluster) | Compute   | Clustersjablonen voor GPU- & custom silicon training |
| [`3.aws-batch`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/3.aws-batch)                     | Compute   | AWS Batch sjabloon voor gedistribueerde training     |
| [`4.amazon-eks`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/4.amazon-eks)                   | Compute   | Manifestbestanden om te trainen met Amazon EKS       |
| [`5.sagemaker-hyperpod`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/5.sagemaker-hyperpod)   | Compute   | SageMaker HyperPod sjabloon voor gedistribueerde training |

Er zullen meer volgen, voel je vrij om nieuwe toe te voegen (bijv. Ray?). Je vindt ook [documentatie](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/efa-cheatsheet.md) voor EFA en de aanbevolen omgevingsvariabelen.

## 2. Aangepaste Amazon Machine Images

Aangepaste machine images kunnen worden gebouwd met behulp van [Packer](www.packer.io) voor AWS ParallelCluster, Amazon EKS en gewone EC2. Deze images zijn gebaseerd op Ansible-rollen en playbooks.

## 3. Testgevallen

Testgevallen zijn georganiseerd per framework en behandelen diverse scenario's voor gedistribueerde training. Elk testgeval bevat de benodigde scripts en configuraties om gedistribueerde trainingsjobs uit te voeren.

### PyTorch Testgevallen
- [`FSDP/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/FSDP) - Voorbeelden van Fully Sharded Data Parallel training
- [`megatron-lm/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/megatron-lm) - Megatron-LM gedistribueerde training voorbeelden
- [`nemo-launcher/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/nemo-launcher) - NeMo Launcher voorbeelden voor gedistribueerde training. Dit testgeval is alleen voor NeMo versie 1.0.
- [`nemo-run/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/nemo-run) - NeMo framework gedistribueerde training voorbeelden. Dit testgeval is voor NeMo versie 2.0+.
- [`neuronx-distributed/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/neuronx-distributed) - AWS Trainium gedistribueerde training voorbeelden
- [`mosaicml-composer/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/mosaicml-composer) - MosaicML Composer voorbeelden
- [`picotron/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/picotron) - PicoTron gedistribueerde training voorbeelden
- [`torchtitan/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/torchtitan) - TorchTitan voorbeelden
- [`cpu-ddp/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/cpu-ddp) - CPU-gebaseerde Distributed Data Parallel voorbeelden
- [`bionemo/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/bionemo) - BioNeMo gedistribueerde training voorbeelden

### JAX Testgevallen
- [`jax/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/jax) - JAX-gebaseerde gedistribueerde training voorbeelden met PaxML

Elk testgeval bevat:
- Trainingsscripts en configuraties
- Containerdefinities (indien van toepassing)
- Startscripts voor verschillende clustertypen
- Prestatiemonitoring en validatiehulpmiddelen

## 4. Validatiescripts

Hulpmiddelen scripts en micro-benchmark voorbeelden zijn te vinden onder `4.validation_scripts/`. De EFA Prometheus exporter is te vinden in deze [directory](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/3.efa-node-exporter) 

| Naam                                                                                     | Opmerkingen                                                    |
| ---------------------------------------------------------------------------------------- | -------------------------------------------------------------- |
| [`1.pytorch-env-validation`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/1.pytorch-env-validation) | Valideert je PyTorch omgeving                                 |
| [`3.efa-node-exporter`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/3.efa-node-exporter)           | Node exporter met Amazon EFA monitoring modules                |
| [`4.prometheus-grafana`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/4.prometheus-grafana)         | Deployment assets om SageMaker Hyperpod Clusters te monitoren  |
| [`5.nsight`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/5.nsight)                                 | Toont hoe je Nvidia Nsight Systems kunt draaien om je workload te profileren |
| [`efa-versions.py`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/efa-versions.py)                                  | Haal de versies op van Nvidia libraries, drivers en EFA drivers|

## 5. CI

Integratietests zijn geschreven in [pytest](https://docs.pytest.org). Voer simpelweg uit:

```bash
pytest .
```

Alternatief kun je tests uitvoeren zonder stdout vast te leggen en alle docker images en andere artefacten bewaren.

```bash
pytest -s --keep-artifacts=t
```

## 6. Bijdragers

Dank aan alle bijdragers voor het bouwen, reviewen en testen.

[![Contributors](https://contrib.rocks/image?repo=aws-samples/awsome-distributed-training)](https://github.com/aws-samples/awsome-distributed-training/graphs/contributors)

## 7. Sterren Geschiedenis

[![Star History Chart](https://api.star-history.com/svg?repos=aws-samples/awsome-distributed-training&type=Date)](https://star-history.com/#aws-samples/awsome-distributed-training&Date)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---