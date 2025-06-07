# OCI AI Blueprints

**Implemente, dimensione e monitore cargas de trabalho de IA com a plataforma OCI AI Blueprints e reduza o tempo de integração de GPU de semanas para minutos.**

OCI AI Blueprints é uma solução simplificada e sem necessidade de código para implantar e gerenciar cargas de trabalho de IA Generativa no Kubernetes Engine (OKE). Ao fornecer recomendações de hardware orientadas, stacks de software pré-empacotados e ferramentas de observabilidade prontas para uso, o OCI AI Blueprints ajuda você a colocar suas aplicações de IA em funcionamento de forma rápida e eficiente—sem lidar com as complexidades de decisões de infraestrutura, compatibilidade de software e melhores práticas de MLOps.

[![Instalar OCI AI Blueprints](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/refs/heads/main/docs/images/install.svg)](./GETTING_STARTED_README.md)

## Índice

**Primeiros Passos**

- [Instalar AI Blueprints](./GETTING_STARTED_README.md)
- [Acessar o Portal e API do AI Blueprints](docs/usage_guide.md)

**Sobre o OCI AI Blueprints**

- [O que é OCI AI Blueprints?](docs/about.md)
- [Por que usar OCI AI Blueprints?](docs/about.md)
- [Funcionalidades](docs/about.md)
- [Lista de Blueprints](#blueprints)
- [FAQ](docs/about.md)
- [Suporte & Contato](https://github.com/oracle-quickstart/oci-ai-blueprints/blob/vkammari/doc_improvements/docs/about/README.md#frequently-asked-questions-faq)

**Referência da API**

- [Documentação da Referência da API](docs/api_documentation.md)

**Recursos Adicionais**

- [Publicar Blueprints Personalizados](./docs/custom_blueprints)
- [Instalando Atualizações](docs/installing_new_updates.md)
- [Políticas IAM](docs/iam_policies.md)
- [Conteúdo do Repositório](docs/about.md)
- [Problemas Conhecidos](docs/known_issues.md)

## Primeiros Passos

Instale o OCI AI Blueprints clicando no botão abaixo:

[![Instalar OCI AI Blueprints](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/refs/heads/main/docs/images/install.svg)](./GETTING_STARTED_README.md)

## Blueprints

Blueprints vão além de templates básicos do Terraform. Cada blueprint:

- Oferece sugestões de hardware validadas (ex: shapes ideais, configurações de CPU/GPU),
- Inclui stacks de aplicações ponta-a-ponta customizadas para diferentes casos de uso de GenAI, e
- Vem com monitoramento, logging e auto-escalonamento configurados automaticamente.

Após instalar o OCI AI Blueprints em um cluster OKE na sua tenancy, você pode implantar estes blueprints pré-construídos:

| Blueprint                                                                                     | Descrição                                                                                                                                |
| --------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------- |
| [**LLM & VLM Inferência com vLLM**](docs/sample_blueprints/llm_inference_with_vllm/README.md) | Implante modelos Llama 2/3/3.1 7B/8B usando shapes NVIDIA GPU e o mecanismo de inferência vLLM com auto-escalonamento.                   |
| [**Benchmark de Fine-Tuning**](./docs/sample_blueprints/lora-benchmarking)                    | Execute fine-tuning LoRA quantizado do Llama-2 70B do MLCommons em A100 para benchmark de desempenho.                                    |
| [**Fine-Tuning com LoRA**](./docs/sample_blueprints/lora-fine-tuning)                         | Fine-tuning LoRA de modelos personalizados ou HuggingFace usando qualquer conjunto de dados. Inclui ajuste flexível de hiperparâmetros.  |
| [**Health Check**](./docs/sample_blueprints/gpu-health-check)                                 | Avaliação abrangente do desempenho da GPU para garantir a prontidão ideal do hardware antes de iniciar cargas de trabalho intensivas.     |
| [**Inferência em CPU**](./docs/sample_blueprints/cpu-inference)                               | Utilize o Ollama para testar inferência baseada em CPU com modelos como Mistral, Gemma e outros.                                         |
| [**Inferência Multi-nó com RDMA e vLLM**](./docs/sample_blueprints/multi-node-inference/)     | Implemente LLMs do tamanho Llama-405B em múltiplos nós com RDMA usando nós H100 com vLLM e LeaderWorkerSet.                              |
| [**Inferência com Auto-escalonamento usando vLLM**](./docs/sample_blueprints/auto_scaling/)   | Sirva LLMs com auto-escalonamento usando KEDA, que escala para múltiplas GPUs e nós com métricas como latência de inferência.            |
| [**Inferência LLM com MIG**](./docs/sample_blueprints/mig_multi_instance_gpu/)                | Implemente LLMs em uma fração de GPU com as GPUs multi-instância da Nvidia e sirva-os com vLLM.                                          |
| [**Fila de Jobs**](./docs/sample_blueprints/teams)                                            | Aproveite filas de jobs e imponha cotas de recursos e compartilhamento justo entre equipes.                                              |

## Suporte & Contato

Se você tiver dúvidas, problemas ou feedback, entre em contato com [vishnu.kammari@oracle.com](mailto:vishnu.kammari@oracle.com) ou [grant.neuman@oracle.com](mailto:grant.neuman@oracle.com).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---