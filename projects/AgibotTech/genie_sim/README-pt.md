![image.png](https://raw.githubusercontent.com/AgibotTech/genie_sim/main/./docs/image.jpg)
<div align="center">
  <a href="https://github.com/AgibotTech/genie_sim">
    <img src="https://img.shields.io/badge/GitHub-grey?logo=GitHub" alt="GitHub">
  </a>
  <a href="https://huggingface.co/datasets/agibot-world/GenieSimAssets">
    <img src="https://img.shields.io/badge/HuggingFace-yellow?logo=HuggingFace" alt="HuggingFace">
  </a>
  <a href="https://agibot-world.com/sim-evaluation">
    <img src="https://img.shields.io/badge/Genie%20Sim%20Benchmark-blue?style=plastic" alt="Genie Sim Benchmark">
  </a>
  <a href="https://genie.agibot.com/en/geniestudio">
    <img src="https://img.shields.io/badge/Genie_Studio-green?style=flat" alt="Genie Studio">
  </a>
</div>

# 1. Genie Sim Benchmark
Genie Sim é o framework de simulação da AgiBot, que fornece aos desenvolvedores capacidades eficientes de geração de dados e benchmarks de avaliação para acelerar o desenvolvimento de inteligência incorporada. O Genie Sim estabeleceu um pipeline fechado abrangente, abrangendo geração de trajetórias, treinamento de modelos, benchmarking e validação de implantação. Os usuários podem validar rapidamente o desempenho dos algoritmos e otimizar modelos através desta cadeia de ferramentas de simulação eficiente. Seja para tarefas simples de preensão ou operações complexas de longo alcance, o Genie Sim pode fornecer um ambiente de simulação altamente realista e métricas de avaliação precisas, permitindo que os desenvolvedores concluam de forma eficiente o desenvolvimento e a iteração de tecnologias robóticas.

O Genie Sim Benchmark, como a versão de avaliação open-source do Genie Sim, é dedicado a fornecer testes de desempenho precisos e suporte à otimização para modelos de IA incorporada.

# 2. Funcionalidades
- Configuração de simulação flexível e interface amigável ao usuário
- Benchmarks de simulação e tarefas de avaliação para mais de 10 tarefas de manipulação
- Capacidade de teleoperação baseada em VR e teclado
- Gravação e reprodução de todas as juntas e pose do efetuador final
- Mais de 550 ambientes e ativos 3D de alta fidelidade e fisicamente precisos
- Métricas de avaliação padronizadas para quantificar o desempenho de modelos de IA incorporada
- Resultados de avaliação alcançam menos de 5% de erro sim para real no modelo GO-1
- Suporte ao modelo baseline UniVLA na avaliação em simulação

# 3. Atualizações
- [25/06/2025] v2.1
  - Adicionadas mais 10 tarefas de manipulação para o Agibot World Challenge 2025, incluindo todos os ativos de simulação
  - Open-source de conjuntos de dados sintéticos para 10 tarefas de manipulação no Huggingface
  https://huggingface.co/datasets/agibot-world/AgiBotWorldChallenge-2025/tree/main/Manipulation-SimData
  - Integração da política UniVLA e suporte à avaliação de inferência de modelo em simulação
  - Atualização do SDK do solucionador IK, que suporta a resolução de IK entre diferentes robôs
  - Otimização do framework de comunicação e melhoria da velocidade de execução da simulação em 2x
  - Atualização do framework de avaliação automática para tarefas de longo alcance mais complexas

# 4. Conteúdo

## 4.1 Introdução
Os benchmarks de simulação de inteligência incorporada no Genie Sim são projetados para avaliar e avançar o desenvolvimento de modelos de IA incorporada. Esses benchmarks fornecem ambientes realistas, tarefas diversas e métricas padronizadas para medir o desempenho de sistemas de IA robótica, reduzindo a necessidade de hardware físico caro e testes no mundo real, evitando cenários de teste arriscados e perigosos e acelerando o processo de treinamento e avaliação de agentes de IA.

## 4.2 Primeiros Passos
Por favor, consulte [esta página](https://agibot-world.com/sim-evaluation/docs/#/v2) para instalação, guia do usuário e referência de API

## 4.3 Suporte
<img src="https://raw.githubusercontent.com/AgibotTech/genie_sim/main/./docs/wechat.JPEG" width="30%"/>

## 4.4 Lista de Tarefas (TODO)
- [x] Lançar mais tarefas de manipulação de longo horizonte para benchmark
- [x] Mais cenários e ativos para cada tarefa de benchmark
- [x] Suporte ao modelo baseline do Agibot World Challenge
- [ ] Ferramentas de generalização de layout de cenário e trajetória de manipulação

## 4.5 Perguntas Frequentes (FAQ)
- Como desligar o servidor isaac sim quando ocorrem erros, fazendo com que o processo não responda?
  Mate o processo no terminal usando `pkill -9 -f raise_standalone_sim`
- Como escolher diferentes modos de renderização?
  O modo de renderização padrão é `RaytracedLighting(RealTime)`. Para tarefas que contenham objetos transparentes, use `RealTimePathTracing(RealTime-2.0)` para relação de perspectiva dos objetos

## 4.6 Licença e Citação
Todos os dados e códigos deste repositório estão sob a Licença Pública Mozilla 2.0
Por favor, considere citar nosso trabalho de uma das formas abaixo se ele ajudar sua pesquisa.
```
@misc{2025geniesim,
  title={GenieSim},
  author={GenieSim Team},
  year={2025},
  url={https://github.com/AgibotTech/genie_sim}
}
```

## 4.7 Referências
1. PDDL Parser (2020). Versão 1.1. [Código fonte]. https://github.com/pucrs-automated-planning/pddl-parser.
2. BDDL. Versão 1.x.x [Código fonte]. https://github.com/StanfordVL/bddl
3. CUROBO [Código fonte]. https://github.com/NVlabs/curobo
4. Isaac Lab [Código fonte]. https://github.com/isaac-sim/IsaacLab
5. Omni Gibson [Código fonte]. https://github.com/StanfordVL/OmniGibson

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-04

---