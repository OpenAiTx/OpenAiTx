# Architectures de référence & tests pour l'entraînement ML <!-- omit from toc -->

> **Avertissement**  
> Nous procédons actuellement à une refonte majeure de ce dépôt, en particulier sur la section des cas de test. Si vous préférez utiliser l’ancienne structure de répertoires et les cas de test obsolètes, veuillez vous référer à [v1.1.0](https://github.com/aws-samples/awsome-distributed-training/releases/tag/v1.1.0).

Ce dépôt contient des architectures de référence et des cas de test pour l'entraînement distribué de modèles avec [Amazon SageMaker Hyperpod](https://docs.aws.amazon.com/sagemaker/latest/dg/sagemaker-hyperpod.html), [AWS ParallelCluster](https://docs.aws.amazon.com/parallelcluster/latest/ug/what-is-aws-parallelcluster.html), [AWS Batch](https://docs.aws.amazon.com/batch/latest/userguide/what-is-batch.html) et [Amazon EKS](https://docs.aws.amazon.com/eks/latest/userguide/getting-started-console.html). Les cas de test couvrent différents types et tailles de modèles ainsi que différents frameworks et optimisations parallèles (Pytorch DDP/FSDP, MegatronLM, NemoMegatron...).

Les composants principaux de ce répertoire sont :

```bash
reference-architectures/
|-- 1.architectures/               # Templates CloudFormation pour architectures de référence
|-- 2.ami_and_containers/          # Scripts pour créer des AMI et images conteneurs
|-- 3.test_cases/                  # Cas de test de référence et/ou scripts de benchmark
|-- 4.validation_observability/    # Outils pour mesurer la performance ou dépanner
`-- ...
```

**NOTE** : les architectures sont conçues pour fonctionner avec le bucket S3 et le VPC créés via les templates de référence `1.architectures/0.s3/` et `1.architectures/1.vpc_network/`. _Il est fortement recommandé de déployer ces deux templates **avant** de déployer toute architecture de référence._

## 0. Ateliers

Vous pouvez suivre les ateliers ci-dessous pour entraîner des modèles sur AWS. Chacun contient des exemples pour plusieurs cas de test ainsi que des conseils sur l’exploitation d’un cluster pour l’entraînement de LLM.

| Nom                                                                                  | Commentaires                                                      |
| ------------------------------------------------------------------------------------ | ---------------------------------------------------------------- |
| [Amazon SageMaker HyperPod](https://catalog.workshops.aws/sagemaker-hyperpod/en-US)  | Atelier pour SageMaker HyperPod, montre comment le déployer et le surveiller |
| [AWS ParallelCluster](https://catalog.workshops.aws/ml-on-aws-parallelcluster)       | Atelier similaire à HyperPod mais sur ParallelCluster            |
| [Amazon SageMaker HyperPod EKS](https://catalog.workshops.aws/sagemaker-hyperpod-eks) | Atelier pour SageMaker HyperPod EKS, montre comment le déployer et le surveiller |

## 1. Architectures

Les architectures sont situées dans `1.architectures` et comprennent des utilitaires et des architectures liées aux services.

| Nom                                                                 | Catégorie | Usage                                               |
| ------------------------------------------------------------------ | -------- | --------------------------------------------------- |
| [`0.s3`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/0.s3)                       | Stockage  | Créer un bucket S3                                 |
| [`1.vpc_network`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/1.vpc_network)       | Réseau    | Créer un VPC avec sous-réseaux et ressources requises |
| [`2.aws-parallelcluster`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/2.aws-parallelcluster) | Calcul    | Templates de cluster pour entraînement GPU & silicium personnalisé |
| [`3.aws-batch`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/3.aws-batch)           | Calcul    | Template AWS Batch pour entraînement distribué         |
| [`4.amazon-eks`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/4.amazon-eks)           | Calcul    | Fichiers manifeste pour entraîner avec Amazon EKS     |
| [`5.sagemaker-hyperpod`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/5.sagemaker-hyperpod) | Calcul    | Template SageMaker HyperPod pour entraînement distribué |

D’autres viendront, n’hésitez pas à en ajouter de nouveaux (ex. Ray ?). Vous trouverez aussi la [documentation](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/efa-cheatsheet.md) pour EFA et les variables d’environnement recommandées.

## 2. Images Amazon Machine personnalisées

Des images machines personnalisées peuvent être construites avec [Packer](www.packer.io) pour AWS ParallelCluster, Amazon EKS et EC2 simple. Ces images sont basées sur des rôles et playbooks Ansible.

## 3. Cas de test

Les cas de test sont organisés par framework et couvrent divers scénarios d'entraînement distribué. Chaque cas de test inclut les scripts et configurations nécessaires pour exécuter des jobs d'entraînement distribués.

### Cas de test PyTorch
- [`FSDP/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/FSDP) - Exemples d'entraînement Fully Sharded Data Parallel
- [`megatron-lm/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/megatron-lm) - Exemples d'entraînement distribué Megatron-LM
- [`nemo-launcher/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/nemo-launcher) - Exemples NeMo Launcher pour entraînement distribué. Cas de test pour NeMo version 1.0 uniquement.
- [`nemo-run/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/nemo-run) - Exemples d'entraînement distribué framework NeMo. Cas de test pour NeMo version 2.0+.
- [`neuronx-distributed/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/neuronx-distributed) - Exemples d'entraînement distribué AWS Trainium
- [`mosaicml-composer/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/mosaicml-composer) - Exemples MosaicML Composer
- [`picotron/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/picotron) - Exemples d'entraînement distribué PicoTron
- [`torchtitan/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/torchtitan) - Exemples TorchTitan
- [`cpu-ddp/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/cpu-ddp) - Exemples Distributed Data Parallel sur CPU
- [`bionemo/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/bionemo) - Exemples d'entraînement distribué BioNeMo

### Cas de test JAX
- [`jax/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/jax) - Exemples d'entraînement distribué basé sur JAX avec PaxML

Chaque cas de test inclut :  
- Scripts et configurations d’entraînement  
- Définitions de conteneurs (le cas échéant)  
- Scripts de lancement pour différents types de clusters  
- Outils de surveillance de performance et de validation  

## 4. Scripts de validation

Les scripts utilitaires et exemples de micro-benchmarks sont placés sous `4.validation_scripts/`. L’exportateur Prometheus EFA se trouve dans ce [répertoire](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/3.efa-node-exporter) 

| Nom                                                                                              | Commentaires                                                     |
| ------------------------------------------------------------------------------------------------ | ---------------------------------------------------------------- |
| [`1.pytorch-env-validation`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/1.pytorch-env-validation) | Valide votre environnement PyTorch                              |
| [`3.efa-node-exporter`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/3.efa-node-exporter)         | Exportateur de nœud avec modules de surveillance Amazon EFA     |
| [`4.prometheus-grafana`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/4.prometheus-grafana)         | Actifs de déploiement pour surveiller les clusters SageMaker Hyperpod |
| [`5.nsight`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/5.nsight)                                 | Montre comment utiliser Nvidia Nsight Systems pour profiler votre charge de travail |
| [`efa-versions.py`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/efa-versions.py)                                   | Récupère les versions des bibliothèques Nvidia, drivers et drivers EFA |

## 5. CI

Les tests d’intégration sont écrits en [pytest](https://docs.pytest.org). Il suffit d’exécuter :

```bash
pytest .
```

Alternativement, vous pouvez lancer les tests sans capturer la sortie stdout et en conservant toutes les images docker et autres artefacts.

```bash
pytest -s --keep-artifacts=t
```

## 6. Contributeurs

Merci à tous les contributeurs pour leur travail de construction, revue et test.

[![Contributeurs](https://contrib.rocks/image?repo=aws-samples/awsome-distributed-training)](https://github.com/aws-samples/awsome-distributed-training/graphs/contributors)

## 7. Historique des étoiles

[![Graphique historique des étoiles](https://api.star-history.com/svg?repos=aws-samples/awsome-distributed-training&type=Date)](https://star-history.com/#aws-samples/awsome-distributed-training&Date)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---