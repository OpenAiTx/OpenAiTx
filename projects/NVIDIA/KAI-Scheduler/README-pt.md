[![License](https://img.shields.io/badge/License-Apache_2.0-blue.svg)](LICENSE) [![Coverage](https://github.com/NVIDIA/KAI-Scheduler/raw/coverage-badge/badges/coverage.svg)](https://github.com/NVIDIA/KAI-Scheduler/blob/main/.github/workflows/update-coverage-badge.yaml)
# KAI Scheduler
O KAI Scheduler é um [agendador do Kubernetes](https://kubernetes.io/docs/concepts/scheduling-eviction/kube-scheduler/) robusto, eficiente e escalável que otimiza a alocação de recursos de GPU para cargas de trabalho de IA e aprendizado de máquina.

Projetado para gerenciar grandes clusters de GPUs, incluindo milhares de nós e alto throughput de workloads, o KAI Scheduler é ideal para ambientes extensos e exigentes.
O KAI Scheduler permite que administradores de clusters Kubernetes aloque recursos de GPU dinamicamente para as cargas de trabalho.

O KAI Scheduler suporta todo o ciclo de vida da IA, desde pequenos jobs interativos que requerem recursos mínimos até grandes treinamentos e inferência, tudo dentro do mesmo cluster.
Garante a alocação ótima dos recursos enquanto mantém a justiça de recursos entre os diferentes consumidores.
Pode ser executado juntamente com outros agendadores instalados no cluster.

## Principais Funcionalidades
* [Agendamento em Lote](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/batch/README.md): Garante que todos os pods em um grupo sejam agendados simultaneamente ou nenhum seja.
* Bin Packing & Agendamento Distribuído: Otimiza o uso dos nós, minimizando a fragmentação (bin-packing) ou aumentando a resiliência e o balanceamento de carga (agendamento distribuído).
* [Prioridade de Workload](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/priority/README.md): Prioriza as workloads de forma eficaz dentro das filas.
* [Filas Hierárquicas](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/queues/README.md): Gerencia workloads com hierarquias de filas de dois níveis para controle organizacional flexível.
* [Distribuição de Recursos](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/fairness/README.md#resource-division-algorithm): Personalize cotas, pesos de sobrecota, limites e prioridades por fila.
* [Políticas de Justiça](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/fairness/README.md#reclaim-strategies): Garante a distribuição equitativa de recursos usando Dominant Resource Fairness (DRF) e recuperação de recursos entre filas.
* Consolidação de Workloads: Realoca workloads em execução de forma inteligente para reduzir a fragmentação e aumentar a utilização do cluster.
* [Workloads Elásticas](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/elastic/README.md): Escala dinamicamente workloads dentro dos limites mínimos e máximos de pods definidos.
* Alocação Dinâmica de Recursos (DRA): Suporte a recursos de hardware específicos de fornecedores via ResourceClaims do Kubernetes (ex: GPUs NVIDIA ou AMD).
* [Compartilhamento de GPU](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/gpu-sharing/README.md): Permite que múltiplas workloads compartilhem eficientemente uma ou mais GPUs, maximizando a utilização dos recursos.
* Suporte em Nuvem & On-premise: Totalmente compatível com infraestruturas dinâmicas de nuvem (incluindo auto-scalers como o Karpenter) assim como implantações estáticas on-premise.

## Pré-requisitos
Antes de instalar o KAI Scheduler, certifique-se de que você tenha:

- Um cluster Kubernetes em execução
- [Helm](https://helm.sh/docs/intro/install) CLI instalado
- [NVIDIA GPU-Operator](https://github.com/NVIDIA/gpu-operator) instalado para agendar workloads que requisitem recursos de GPU

## Instalação
O KAI Scheduler será instalado no namespace `kai-scheduler`. Ao submeter workloads, utilize um namespace dedicado.

### Métodos de Instalação
O KAI Scheduler pode ser instalado:

- **A partir da Produção (Recomendado)**
- **A partir do Código Fonte (Construa Você Mesmo)**

#### Instalar a partir da Produção
Encontre a versão de release mais recente na página de [releases](https://github.com/NVIDIA/KAI-Scheduler/releases).
Execute o seguinte comando após substituir `<VERSION>` pela versão desejada:
```sh
helm upgrade -i kai-scheduler oci://ghcr.io/nvidia/kai-scheduler/kai-scheduler -n kai-scheduler --create-namespace --version <VERSION>
```
#### Construir a partir do Código Fonte
Siga as instruções [aqui](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/developer/building-from-source.md)

## Início Rápido
Para começar a agendar workloads com o KAI Scheduler, continue para o [exemplo de Início Rápido](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/quickstart/README.md)

## Roadmap

### Visão geral de alto nível das principais prioridades para 2025
* Refatorar o código para aumentar a neutralidade de fornecedores
* Suporte a Scheduling Gates https://github.com/NVIDIA/KAI-Scheduler/issues/63
* Pesquisar possível integração com Kueue https://github.com/NVIDIA/KAI-Scheduler/issues/68
* Adicionar suporte a Topology Aware Scheduling para pod-group https://github.com/NVIDIA/KAI-Scheduler/issues/66
* Suporte a Tempo Mínimo de Execução por workload
* Suporte a Tempo Máximo de Execução por workload (com reenvio atrasado para a fila)
* Adicionar mais PriorityClasses como parte da instalação padrão do KAI
* Suporte a JobSet
* Suporte a LWS (LeaderWorkerSet)
* Adicionar métricas para preempção de pod e pod-group
* Desacoplar Prioridade e Preempção

### Objetivos de longo prazo
* Suporte a decaimento temporal por fila
* Melhorias para hiperescala
* Suporte à Consolidação de workloads de Inferência para desfragmentação do cluster
* Suporte a n-níveis de filas hierárquicas
* Rollout suave de workloads de Inferência (nova atualização de revisão usando fila temporariamente acima da cota)

## Comunidade, Discussão e Suporte

Adoraríamos ouvir você! Aqui estão as melhores formas de contato:

### Slack
Entre no [Slack da CNCF](https://communityinviter.com/apps/cloud-native/cncf) primeiro e visite o canal [#kai-scheduler](https://cloud-native.slack.com/archives/kai-scheduler).

### Reunião Comunitária Quinzenal  
**Quando:** Segunda-feira alternada às 17:00 CEST  
[Converta para seu fuso horário](https://dateful.com/time-zone-converter?t=17&tz2=Germany) | [Adicione ao seu calendário](https://calendar.google.com/calendar/event?action=TEMPLATE&tmeid=N2Q2bjhoNXAzMGc0cWpnZTQ4OGtpdXFhanFfMjAyNTA2MDlUMTUwMDAwWiAxZjQ2OTZiOWVlM2JiMWE1ZWIzMTAwODBkNDZiZmMwMDZjNTUxYWFiZmU1YTM3ZGM2YTc0NTFhYmNhMmE1ODk0QGc&tmsrc=1f4696b9ee3bb1a5eb310080d46bfc006c551aabfe5a37dc6a7451abca2a5894%40group.calendar.google.com&scp=ALL)  | [Notas e agenda da reunião](https://docs.google.com/document/d/13K7NGdPebOstlrsif1YLjGz1x-aJafMXeIgqbO7WghI/edit?usp=sharing)

### Lista de E-mails  
Entre para a [lista de e-mails do kai-scheduler](https://groups.google.com/g/kai-scheduler) para receber atualizações sobre reuniões quinzenais.

### Problemas Técnicos & Solicitações de Funcionalidades  
Por favor, abra uma [issue no GitHub](https://github.com/NVIDIA/KAI-Scheduler/issues/new/choose) para bugs, sugestões de funcionalidades ou ajuda técnica. Isso nos ajuda a acompanhar as solicitações e responder de forma eficaz.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---