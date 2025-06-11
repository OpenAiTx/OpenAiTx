# Arquiteturas de Referência e Testes de Treinamento de ML <!-- omit from toc -->

> **Aviso**
> Atualmente estamos passando por uma grande refatoração deste repositório, com foco especial na seção de casos de teste. Se preferir usar a estrutura de diretórios anterior e casos de teste depreciados, por favor consulte [v1.1.0](https://github.com/aws-samples/awsome-distributed-training/releases/tag/v1.1.0).

Este repositório contém arquiteturas de referência e casos de teste para treinamento distribuído de modelos com [Amazon SageMaker Hyperpod](https://docs.aws.amazon.com/sagemaker/latest/dg/sagemaker-hyperpod.html), [AWS ParallelCluster](https://docs.aws.amazon.com/parallelcluster/latest/ug/what-is-aws-parallelcluster.html), [AWS Batch](https://docs.aws.amazon.com/batch/latest/userguide/what-is-batch.html) e [Amazon EKS](https://docs.aws.amazon.com/eks/latest/userguide/getting-started-console.html). Os casos de teste cobrem diferentes tipos e tamanhos de modelos, bem como diferentes frameworks e otimizações paralelas (Pytorch DDP/FSDP, MegatronLM, NemoMegatron...).

Os principais componentes deste diretório são:

```bash
reference-architectures/
|-- 1.architectures/               # Templates CloudFormation para arquitetura de referência
|-- 2.ami_and_containers/          # Scripts para criar AMIs e imagens de container
|-- 3.test_cases/                  # Casos de teste de referência e/ou scripts de benchmark
|-- 4.validation_observability/    # Ferramentas para medir desempenho ou solucionar problemas
`-- ...
```

**NOTA**: as arquiteturas são projetadas para funcionar com o bucket S3 e VPC criados usando os templates de referência `1.architectures/0.s3/` e `1.architectures/1.vpc_network/`. _É fortemente recomendado implantar esses dois templates **antes** de implantar qualquer uma das arquiteturas de referência._

## 0. Workshops

Você pode seguir os workshops abaixo para treinar modelos na AWS. Cada um contém exemplos para vários casos de teste, bem como informações importantes para operar um cluster para treinamento de LLM.

| Nome                                                                           | Comentários
| ------------------------------------------------------------------------------ | ------------------------------------------------------------------- |
| [Amazon SageMaker HyperPod](https://catalog.workshops.aws/sagemaker-hyperpod/en-US)   | Workshop para SageMaker HyperPod, mostra como implantar e monitorar |
| [AWS ParallelCluster](https://catalog.workshops.aws/ml-on-aws-parallelcluster) | Workshop similar ao HyperPod, mas para ParallelCluster              |
| [Amazon SageMaker HyperPod EKS](https://catalog.workshops.aws/sagemaker-hyperpod-eks)   | Workshop para SageMaker HyperPod EKS, mostra como implantar e monitorar |

## 1. Arquiteturas

As arquiteturas estão localizadas em `1.architectures` e consistem em utilitários e arquiteturas relacionadas a serviços.

| Nome                                                               | Categoria | Uso                                                  |
| ------------------------------------------------------------------ | -------- | ---------------------------------------------------- |
| [`0.s3`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/0.s3)                                   | Armazenamento  | Criar um bucket S3                                  |
| [`1.vpc_network`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/1.vpc_network)                 | Rede     | Criar uma VPC com sub-redes e recursos necessários   |
| [`2.aws-parallelcluster`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/2.aws-parallelcluster) | Computação | Templates de cluster para treinamento com GPU e silício customizado |
| [`3.aws-batch`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/3.aws-batch)                     | Computação | Template AWS Batch para treinamento distribuído      |
| [`4.amazon-eks`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/4.amazon-eks)                   | Computação | Arquivos de manifesto para treinar com Amazon EKS    |
| [`5.sagemaker-hyperpod`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/5.sagemaker-hyperpod)   | Computação | Template SageMaker HyperPod para treinamento distribuído|

Mais virão, sinta-se à vontade para adicionar novos (ex. Ray?). Você também encontrará [documentação](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/efa-cheatsheet.md) para EFA e as variáveis de ambiente recomendadas.

## 2. Imagens Personalizadas da Amazon Machine

Imagens personalizadas podem ser construídas usando [Packer](www.packer.io) para AWS ParallelCluster, Amazon EKS e EC2 padrão. Essas imagens são baseadas em roles e playbooks Ansible.

## 3. Casos de teste

Os casos de teste são organizados por framework e cobrem vários cenários de treinamento distribuído. Cada caso de teste inclui os scripts e configurações necessárias para executar trabalhos de treinamento distribuído.

### Casos de Teste PyTorch
- [`FSDP/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/FSDP) - Exemplos de treinamento Fully Sharded Data Parallel
- [`megatron-lm/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/megatron-lm) - Exemplos de treinamento distribuído Megatron-LM
- [`nemo-launcher/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/nemo-launcher) - Exemplos NeMo Launcher para treinamento distribuído. Este caso é para a versão 1.0 do NeMo apenas.
- [`nemo-run/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/nemo-run) - Exemplos de treinamento distribuído do framework NeMo. Este caso é para NeMo versão 2.0+.
- [`neuronx-distributed/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/neuronx-distributed) - Exemplos de treinamento distribuído AWS Trainium
- [`mosaicml-composer/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/mosaicml-composer) - Exemplos MosaicML Composer
- [`picotron/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/picotron) - Exemplos de treinamento distribuído PicoTron
- [`torchtitan/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/torchtitan) - Exemplos TorchTitan
- [`cpu-ddp/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/cpu-ddp) - Exemplos Distributed Data Parallel baseados em CPU
- [`bionemo/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/bionemo) - Exemplos de treinamento distribuído BioNeMo

### Casos de Teste JAX
- [`jax/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/jax) - Exemplos de treinamento distribuído baseados em JAX usando PaxML

Cada caso de teste inclui:
- Scripts e configurações de treinamento
- Definições de container (quando aplicável)
- Scripts de lançamento para diferentes tipos de cluster
- Ferramentas de monitoramento de desempenho e validação

## 4. Scripts de Validação

Scripts utilitários e exemplos de micro-benchmarks estão em `4.validation_scripts/`. O exportador Prometheus para EFA pode ser encontrado neste [diretório](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/3.efa-node-exporter) 

| Nome                                                                                    | Comentários                                                        |
| --------------------------------------------------------------------------------------- | ----------------------------------------------------------------- |
| [`1.pytorch-env-validation`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/1.pytorch-env-validation) | Valida seu ambiente PyTorch                                       |
| [`3.efa-node-exporter`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/3.efa-node-exporter)           | Node exporter com módulos de monitoramento Amazon EFA            |
| [`4.prometheus-grafana`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/4.prometheus-grafana)         | Assets de implantação para monitorar clusters SageMaker Hyperpod |
| [`5.nsight`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/5.nsight)                                 | Demonstra como executar Nvidia Nsight Systems para perfil do workload |
| [`efa-versions.py`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/efa-versions.py)                                  | Obtém as versões das bibliotecas Nvidia, drivers e drivers EFA   |


## 5. CI

Testes de integração são escritos em [pytest](https://docs.pytest.org). Basta executar:

```bash
pytest .
```

Alternativamente, você pode executar os testes sem capturar stdout e mantendo todas as imagens docker e outros artefatos.

```bash
pytest -s --keep-artifacts=t
```

## 6. Contribuidores

Obrigado a todos os contribuintes por construir, revisar e testar.

[![Contributors](https://contrib.rocks/image?repo=aws-samples/awsome-distributed-training)](https://github.com/aws-samples/awsome-distributed-training/graphs/contributors)

## 7. Histórico de Estrelas

[![Star History Chart](https://api.star-history.com/svg?repos=aws-samples/awsome-distributed-training&type=Date)](https://star-history.com/#aws-samples/awsome-distributed-training&Date)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---