# ML Training Reference Architectures & Tests <!-- omit from toc -->

> **Avviso**  
> Attualmente stiamo effettuando una grande ristrutturazione di questo repository, in particolare focalizzata sulla sezione dei casi di test. Se preferisci utilizzare la struttura di directory precedente e i casi di test deprecati, fai riferimento a [v1.1.0](https://github.com/aws-samples/awsome-distributed-training/releases/tag/v1.1.0).

Questo repository contiene architetture di riferimento e casi di test per l'addestramento distribuito di modelli con [Amazon SageMaker Hyperpod](https://docs.aws.amazon.com/sagemaker/latest/dg/sagemaker-hyperpod.html), [AWS ParallelCluster](https://docs.aws.amazon.com/parallelcluster/latest/ug/what-is-aws-parallelcluster.html), [AWS Batch](https://docs.aws.amazon.com/batch/latest/userguide/what-is-batch.html), e [Amazon EKS](https://docs.aws.amazon.com/eks/latest/userguide/getting-started-console.html). I casi di test coprono diversi tipi e dimensioni di modelli così come diversi framework e ottimizzazioni parallele (Pytorch DDP/FSDP, MegatronLM, NemoMegatron...).

I componenti principali di questa directory sono:

```bash
reference-architectures/
|-- 1.architectures/               # Modelli CloudFormation per architetture di riferimento
|-- 2.ami_and_containers/          # Script per creare AMI e immagini container
|-- 3.test_cases/                  # Casi di test di riferimento e/o script di benchmark
|-- 4.validation_observability/    # Strumenti per misurare le prestazioni o risolvere problemi
`-- ...
```

**NOTA**: le architetture sono progettate per funzionare con il bucket S3 e la VPC creati utilizzando i modelli di riferimento `1.architectures/0.s3/` e `1.architectures/1.vpc_network/`. _Si consiglia vivamente di distribuire questi due modelli **prima** di distribuire qualsiasi architettura di riferimento._

## 0. Workshop

Puoi seguire il workshop sottostante per addestrare modelli su AWS. Ognuno contiene esempi per diversi casi di test oltre a informazioni utili per gestire un cluster per l’addestramento LLM.

| Nome                                                                                   | Commenti                                                          |
| -------------------------------------------------------------------------------------- | ---------------------------------------------------------------- |
| [Amazon SageMaker HyperPod](https://catalog.workshops.aws/sagemaker-hyperpod/en-US)    | Workshop per SageMaker HyperPod, mostra come distribuirlo e monitorarlo |
| [AWS ParallelCluster](https://catalog.workshops.aws/ml-on-aws-parallelcluster)         | Workshop simile a HyperPod ma su ParallelCluster                  |
| [Amazon SageMaker HyperPod EKS](https://catalog.workshops.aws/sagemaker-hyperpod-eks)  | Workshop per SageMaker HyperPod EKS, mostra come distribuirlo e monitorarlo |

## 1. Architetture

Le architetture si trovano in `1.architectures` e comprendono utilità e architetture correlate ai servizi.

| Nome                                                               | Categoria | Uso                                               |
| ------------------------------------------------------------------ | -------- | ------------------------------------------------- |
| [`0.s3`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/0.s3)                                   | Storage  | Crea un bucket S3                                 |
| [`1.vpc_network`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/1.vpc_network)                 | Network  | Crea una VPC con subnet e risorse necessarie      |
| [`2.aws-parallelcluster`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/2.aws-parallelcluster) | Compute  | Modelli per cluster per addestramento GPU & custom silicon |
| [`3.aws-batch`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/3.aws-batch)                     | Compute  | Modello AWS Batch per addestramento distribuito    |
| [`4.amazon-eks`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/4.amazon-eks)                   | Compute  | File manifesto per addestrare con Amazon EKS       |
| [`5.sagemaker-hyperpod`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/5.sagemaker-hyperpod)   | Compute  | Modello SageMaker HyperPod per addestramento distribuito|

Ne arriveranno altri, sentiti libero di aggiungerne di nuovi (es. Ray?). Troverai anche la [documentazione](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/efa-cheatsheet.md) per EFA e le variabili d'ambiente consigliate.

## 2. Amazon Machine Images personalizzate

Le immagini macchina personalizzate possono essere create usando [Packer](www.packer.io) per AWS ParallelCluster, Amazon EKS e EC2 semplice. Queste immagini si basano su ruoli e playbook Ansible.

## 3. Casi di test

I casi di test sono organizzati per framework e coprono diversi scenari di addestramento distribuito. Ogni caso di test include gli script e le configurazioni necessarie per eseguire job di addestramento distribuito.

### Casi di test PyTorch
- [`FSDP/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/FSDP) - Esempi di addestramento Fully Sharded Data Parallel
- [`megatron-lm/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/megatron-lm) - Esempi di addestramento distribuito Megatron-LM
- [`nemo-launcher/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/nemo-launcher) - Esempi NeMo Launcher per addestramento distribuito. Questo caso di test è per NeMo versione 1.0 soltanto.
- [`nemo-run/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/nemo-run) - Esempi di addestramento distribuito con framework NeMo. Questo caso di test è per NeMo versione 2.0+.
- [`neuronx-distributed/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/neuronx-distributed) - Esempi di addestramento distribuito AWS Trainium
- [`mosaicml-composer/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/mosaicml-composer) - Esempi MosaicML Composer
- [`picotron/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/picotron) - Esempi di addestramento distribuito PicoTron
- [`torchtitan/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/torchtitan) - Esempi TorchTitan
- [`cpu-ddp/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/cpu-ddp) - Esempi Distributed Data Parallel su CPU
- [`bionemo/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/bionemo) - Esempi di addestramento distribuito BioNeMo

### Casi di test JAX
- [`jax/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/jax) - Esempi di addestramento distribuito basati su JAX usando PaxML

Ogni caso di test include:
- Script e configurazioni di addestramento
- Definizioni dei container (dove applicabile)
- Script di avvio per diversi tipi di cluster
- Strumenti di monitoraggio delle prestazioni e validazione

## 4. Script di validazione

Script di utilità ed esempi di micro-benchmark sono presenti in `4.validation_scripts/`. L'exporter Prometheus per EFA si trova in questa [directory](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/3.efa-node-exporter) 

| Nome                                                                                          | Commenti                                                       |
| --------------------------------------------------------------------------------------------- | -------------------------------------------------------------- |
| [`1.pytorch-env-validation`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/1.pytorch-env-validation) | Valida il tuo ambiente PyTorch                                |
| [`3.efa-node-exporter`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/3.efa-node-exporter)           | Node exporter con moduli di monitoraggio Amazon EFA           |
| [`4.prometheus-grafana`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/4.prometheus-grafana)         | Asset per il deployment per monitorare i cluster SageMaker Hyperpod |
| [`5.nsight`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/5.nsight)                                 | Mostra come eseguire Nvidia Nsight Systems per profilare il carico di lavoro |
| [`efa-versions.py`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/efa-versions.py)                                  | Ottieni le versioni delle librerie Nvidia, driver e driver EFA|

## 5. CI

I test di integrazione sono scritti in [pytest](https://docs.pytest.org). Basta eseguire:

```bash
pytest .
```

In alternativa puoi eseguire i test senza catturare stdout e mantenendo tutte le immagini docker e altri artifact.

```bash
pytest -s --keep-artifacts=t
```

## 6. Collaboratori

Grazie a tutti i collaboratori per la costruzione, revisione e test.

[![Collaboratori](https://contrib.rocks/image?repo=aws-samples/awsome-distributed-training)](https://github.com/aws-samples/awsome-distributed-training/graphs/contributors)

## 7. Storico Stelle

[![Grafico Storico Stelle](https://api.star-history.com/svg?repos=aws-samples/awsome-distributed-training&type=Date)](https://star-history.com/#aws-samples/awsome-distributed-training&Date)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---