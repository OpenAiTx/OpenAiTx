<p align="right">
   <strong>English</strong> | <a href="https://raw.githubusercontent.com/Portkey-AI/gateway/main/.github/README.cn.md">中文</a> | <a href="https://raw.githubusercontent.com/Portkey-AI/gateway/main/.github/README.jp.md">日本語</a>
</p>

<div align="center">

<a href="https://portkey.sh/report-github"><img src="https://raw.githubusercontent.com/siddharthsambharia-portkey/Portkey-Product-Images/refs/heads/main/LLM%20Report%20Campaign%20Frame.png"></img></a>
<br>

# AI Gateway
#### Roteie para mais de 250 LLMs com 1 API rápida e amigável

<img src="https://cfassets.portkey.ai/sdk.gif" width="550px" alt="Demonstração do Portkey AI Gateway mostrando capacidades de roteamento de LLM" style="margin-left:-35px">

[Documentação](https://portkey.wiki/gh-1) | [Enterprise](https://portkey.wiki/gh-2) | [Gateway Hospedado](https://portkey.wiki/gh-3) | [Changelog](https://portkey.wiki/gh-4) | [Referência da API](https://portkey.wiki/gh-5)


[![Licença](https://img.shields.io/github/license/Ileriayo/markdown-badges)](https://raw.githubusercontent.com/Portkey-AI/gateway/main/LICENSE)
[![Discord](https://img.shields.io/discord/1143393887742861333)](https://portkey.wiki/gh-6)
[![Twitter](https://img.shields.io/twitter/url/https/twitter/follow/portkeyai?style=social&label=Follow%20%40PortkeyAI)](https://portkey.wiki/gh-7)
[![npm version](https://badge.fury.io/js/%40portkey-ai%2Fgateway.svg)](https://portkey.wiki/gh-8)
[![Better Stack Badge](https://uptime.betterstack.com/status-badges/v1/monitor/q94g.svg)](https://portkey.wiki/gh-9)

<a href="https://us-east-1.console.aws.amazon.com/cloudformation/home?region=us-east-1#/stacks/quickcreate?stackName=portkey-gateway&templateURL=https://portkey-gateway-ec2-quicklaunch.s3.us-east-1.amazonaws.com/portkey-gateway-ec2-quicklaunch.template.yaml"><img src="https://img.shields.io/badge/Deploy_to_EC2-232F3E?style=for-the-badge&logo=amazonwebservices&logoColor=white" alt="Deploy to AWS EC2" width="105"/></a> [![Ask DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/Portkey-AI/gateway)
</div>

<br/>

O [**AI Gateway**](https://portkey.wiki/gh-10) foi projetado para roteamento rápido, confiável e seguro para mais de 1600 modelos de linguagem, visão, áudio e imagem. É uma solução leve, open-source e pronta para empresas que permite integrar com qualquer modelo de linguagem em menos de 2 minutos.

- [x] **Extremamente rápido** (<1ms de latência) com footprint minúsculo (122kb)
- [x] **Testado em produção**, com mais de 10 bilhões de tokens processados por dia
- [x] **Pronto para empresas** com segurança aprimorada, escala e implantações personalizadas

<br>

#### O que você pode fazer com o AI Gateway?
- Integre com qualquer LLM em menos de 2 minutos - [Quickstart](#quickstart-2-mins)
- Previna indisponibilidades através de **[retries automáticos](https://portkey.wiki/gh-11)** e **[fallbacks](https://portkey.wiki/gh-12)**
- Escale aplicativos de IA com **[balanceamento de carga](https://portkey.wiki/gh-13)** e **[roteamento condicional](https://portkey.wiki/gh-14)**
- Proteja seus deploys de IA com **[guardrails](https://portkey.wiki/gh-15)**
- Vá além do texto com **[capacidades multimodais](https://portkey.wiki/gh-16)**
- Por fim, explore integrações com **[fluxo agentic](https://portkey.wiki/gh-17)**

<br><br>

> [!TIP]
> Favoritar este repositório ajuda mais desenvolvedores a descobrirem o AI Gateway 🙏🏻
>
> ![star-2](https://github.com/user-attachments/assets/53597dce-6333-4ecc-a154-eb05532954e4)
> 
<br>


<br>

## Início Rápido (2 minutos)

### 1. Configure seu AI Gateway

```bash
# Execute o gateway localmente (necessita Node.js e npm)
npx @portkey-ai/gateway
```
> O Gateway está rodando em `http://localhost:8787/v1`
> 
> O Console do Gateway está rodando em `http://localhost:8787/public/`

<sup>
Guias de implantação:
&nbsp; <a href="https://portkey.wiki/gh-18"><img height="12" width="12" src="https://cfassets.portkey.ai/logo/dew-color.svg" /> Portkey Cloud (Recomendado)</a>
&nbsp; <a href="https://raw.githubusercontent.com/Portkey-AI/gateway/main/docs/installation-deployments.md#docker"><img height="12" width="12" src="https://cdn.simpleicons.org/docker/3776AB" /> Docker</a>
&nbsp; <a href="https://raw.githubusercontent.com/Portkey-AI/gateway/main/docs/installation-deployments.md#nodejs-server"><img height="12" width="12" src="https://cdn.simpleicons.org/node.js/3776AB" /> Node.js</a>
&nbsp; <a href="https://raw.githubusercontent.com/Portkey-AI/gateway/main/docs/installation-deployments.md#cloudflare-workers"><img height="12" width="12" src="https://cdn.simpleicons.org/cloudflare/3776AB" /> Cloudflare</a>
&nbsp; <a href="https://raw.githubusercontent.com/Portkey-AI/gateway/main/docs/installation-deployments.md#replit"><img height="12" width="12" src="https://cdn.simpleicons.org/replit/3776AB" /> Replit</a>
&nbsp; <a href="https://raw.githubusercontent.com/Portkey-AI/gateway/main/docs/installation-deployments.md"> Outros...</a>

</sup>

### 2. Faça sua primeira requisição

<!-- <details open>
<summary>Exemplo em Python</summary> -->
```python
# pip install -qU portkey-ai

from portkey_ai import Portkey

# Cliente compatível com OpenAI
client = Portkey(
    provider="openai", # ou 'anthropic', 'bedrock', 'groq', etc
    Authorization="sk-***" # a chave de API do provedor
)

# Faça uma requisição pelo seu AI Gateway
client.chat.completions.create(
    messages=[{"role": "user", "content": "Como está o tempo?"}],
    model="gpt-4o-mini"
)
```



<sup>Bibliotecas suportadas:
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/javascript/3776AB" /> JS](https://portkey.wiki/gh-19)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/python/3776AB" /> Python](https://portkey.wiki/gh-20)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/gnubash/3776AB" /> REST](https://portkey.sh/gh-84)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/openai/3776AB" /> SDKs OpenAI](https://portkey.wiki/gh-21)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/langchain/3776AB" /> Langchain](https://portkey.wiki/gh-22)
&nbsp; [LlamaIndex](https://portkey.wiki/gh-23)
&nbsp; [Autogen](https://portkey.wiki/gh-24)
&nbsp; [CrewAI](https://portkey.wiki/gh-25)
&nbsp; [Mais..](https://portkey.wiki/gh-26)
</sup>

No Console do Gateway (`http://localhost:8787/public/`) você pode ver todos os seus logs locais em um só lugar.

<img src="https://github.com/user-attachments/assets/362bc916-0fc9-43f1-a39e-4bd71aac4a3a" width="400" />


### 3. Roteamento & Guardrails
`Configs` no gateway LLM permitem criar regras de roteamento, adicionar confiabilidade e configurar guardrails.
```python
config = {
  "retry": {"attempts": 5},

  "output_guardrails": [{
    "default.contains": {"operator": "none", "words": ["Apple"]},
    "deny": True
  }]
}

# Anexe a configuração ao cliente
client = client.with_options(config=config)

client.chat.completions.create(
    model="gpt-4o-mini",
    messages=[{"role": "user", "content": "Responda aleatoriamente com Apple ou Bat"}]
)

# Isso sempre responderá com "Bat", pois o guardrail bloqueia todas as respostas contendo "Apple". A configuração de retry tentará 5 vezes antes de desistir.
```
<div align="center">
<img src="https://portkey.ai/blog/content/images/size/w1600/2024/11/image-15.png" width=600 title="Fluxo de requisição pelo AI gateway da Portkey com retries e guardrails" alt="Fluxo de requisição pelo AI gateway da Portkey com retries e guardrails"/>
</div>

Você pode fazer muito mais coisas com configs no seu AI gateway. [Veja exemplos  →](https://portkey.wiki/gh-27)

<br/>

### Versão Enterprise (Implantações privadas)

<sup>

[<img height="12" width="12" src="https://cfassets.portkey.ai/amazon-logo.svg" /> AWS](https://portkey.wiki/gh-28)
&nbsp; [<img height="12" width="12" src="https://cfassets.portkey.ai/azure-logo.svg" /> Azure](https://portkey.wiki/gh-29)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/googlecloud/3776AB" /> GCP](https://portkey.wiki/gh-30)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/redhatopenshift/3776AB" /> OpenShift](https://portkey.wiki/gh-31)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/kubernetes/3776AB" /> Kubernetes](https://portkey.wiki/gh-85)

</sup>

A [versão enterprise](https://portkey.wiki/gh-86) do LLM Gateway oferece capacidades avançadas para **gestão organizacional**, **governança**, **segurança** e [mais](https://portkey.wiki/gh-87) prontos para uso. [Veja comparação de recursos →](https://portkey.wiki/gh-32)

A arquitetura de implantação enterprise para plataformas suportadas está disponível aqui - [**Deployments Privados em Nuvem Enterprise**](https://portkey.wiki/gh-33)

<a href="https://portkey.sh/demo-13"><img src="https://portkey.ai/blog/content/images/2024/08/Get-API-Key--5-.png" height=50 alt="Agende uma demonstração do gateway enterprise de IA" /></a><br/>


<br>

<hr>

### AI Engineering Hours

Participe das chamadas semanais da comunidade toda sexta-feira (8h PT) para impulsionar sua implementação do AI Gateway! [Ocorre toda sexta-feira](https://portkey.wiki/gh-35)

<a href="https://portkey.wiki/gh-35"><img width="500" src="https://github.com/user-attachments/assets/c2885699-f197-4289-b819-21eb839fbae1" /></a>

Atas das reuniões [publicadas aqui](https://portkey.wiki/gh-36).


<hr>

### LLMs em Produção 2025

Insights da análise de mais de 2 trilhões de tokens, em mais de 90 regiões e 650 equipes em produção. O que esperar deste relatório:
- Tendências que moldam a adoção de IA e o crescimento dos provedores de LLM.
- Benchmarks para otimizar velocidade, custo e confiabilidade.
- Estratégias para escalar sistemas de IA em produção.

<a href="https://portkey.sh/report-github"><img width="500" src="https://raw.githubusercontent.com/siddharthsambharia-portkey/Portkey-Product-Images/refs/heads/main/LLM%20Report%20Campaign%20Image.png" /></a>

<a href="https://portkey.sh/report-github">**Baixe o Relatório**</a>
<hr>


## Recursos Principais
### Roteamento Confiável
- <a href="https://portkey.wiki/gh-37">**Fallbacks**</a>: Fallback para outro provedor ou modelo em solicitações com falha usando o gateway LLM. Você pode especificar os erros que acionam o fallback. Melhora a confiabilidade da sua aplicação.
- <a href="https://portkey.wiki/gh-38">**Repetições Automáticas**</a>: Repetição automática de solicitações com falha até 5 vezes. Uma estratégia de backoff exponencial espaça as tentativas para evitar sobrecarga na rede.
- <a href="https://portkey.wiki/gh-39">**Balanceamento de Carga**</a>: Distribua solicitações LLM entre várias chaves de API ou provedores de IA com pesos para garantir alta disponibilidade e desempenho ideal.
- <a href="https://portkey.wiki/gh-40">**Timeouts de Solicitação**</a>: Gerencie LLMs indisciplinados e latências configurando timeouts granulares de solicitação, permitindo o término automático das requisições que excedem uma duração especificada.
- <a href="https://portkey.wiki/gh-41">**Gateway Multi-modal LLM**</a>: Chame modelos de visão, áudio (texto para fala & fala para texto) e geração de imagens de vários provedores — tudo usando a já conhecida assinatura OpenAI.
- <a href="https://portkey.wiki/gh-42">**APIs em Tempo Real**</a>: Chame APIs em tempo real lançadas pela OpenAI por meio do servidor de integração via websockets.

### Segurança & Precisão
- <a href="https://portkey.wiki/gh-88">**Guardrails**</a>: Verifique as entradas e saídas do seu LLM para aderir às verificações especificadas. Escolha entre mais de 40 guardrails pré-construídos para garantir conformidade com padrões de segurança e precisão. Você pode <a href="https://portkey.wiki/gh-43">trazer seus próprios guardrails</a> ou escolher entre nossos <a href="https://portkey.wiki/gh-44">diversos parceiros</a>.
- [**Gerenciamento Seguro de Chaves**](https://portkey.wiki/gh-45): Use suas próprias chaves ou gere chaves virtuais em tempo real.
- [**Controle de acesso baseado em papéis**](https://portkey.wiki/gh-46): Controle de acesso granular para seus usuários, workspaces e chaves de API.
- <a href="https://portkey.wiki/gh-47">**Conformidade & Privacidade de Dados**</a>: O gateway de IA é compatível com SOC2, HIPAA, GDPR e CCPA.

### Gestão de Custos
- [**Cache inteligente**](https://portkey.wiki/gh-48): Faça cache das respostas dos LLMs para reduzir custos e melhorar a latência. Suporta cache simples e semântico*.
- [**Análise de uso**](https://portkey.wiki/gh-49): Monitore e analise o uso da sua IA e LLM, incluindo volume de solicitações, latência, custos e taxas de erro.
- [**Otimização de Provedor***](https://portkey.wiki/gh-89): Troca automática para o provedor mais econômico com base nos padrões de uso e modelos de precificação.

### Colaboração & Fluxos de Trabalho
- <a href="https://portkey.ai/docs/integrations/agents">**Suporte a Agentes**</a>: Integre-se facilmente com frameworks de agentes populares para construir aplicações de IA complexas. O gateway integra-se perfeitamente com [Autogen](https://portkey.wiki/gh-50), [CrewAI](https://portkey.wiki/gh-51), [LangChain](https://portkey.wiki/gh-52), [LlamaIndex](https://portkey.wiki/gh-53), [Phidata](https://portkey.wiki/gh-54), [Control Flow](https://portkey.wiki/gh-55) e até [Agentes Personalizados](https://portkey.wiki/gh-56).
- [**Gerenciamento de Templates de Prompt***](https://portkey.wiki/gh-57): Crie, gerencie e versiona seus templates de prompt colaborativamente através de um playground universal de prompts.
<br/><br/>

<sup>
*&nbsp;Disponível nas versões hospedada e corporativa
</sup>

<br>

## Cookbooks

### ☄️ Em Alta
- Use modelos da [Nvidia NIM](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/providers/nvidia.ipynb) com o AI Gateway
- Monitore [Agentes CrewAI](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/monitoring-agents/CrewAI_with_Telemetry.ipynb) com o Portkey!
- Comparando [Top 10 Modelos LMSYS](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/use-cases/LMSYS%20Series/comparing-top10-LMSYS-models-with-Portkey.ipynb) com o AI Gateway.

### 🚨 Mais Recentes
* [Crie Datasets Sintéticos usando Nemotron](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/use-cases/Nemotron_GPT_Finetuning_Portkey.ipynb)
* [Use o LLM Gateway com o AI SDK da Vercel](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/integrations/vercel-ai.md)
* [Monitore Agentes Llama com o LLM Gateway do Portkey](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/monitoring-agents/Llama_Agents_with_Telemetry.ipynb)

[Veja todos os cookbooks →](https://portkey.wiki/gh-58)
<br/><br/>

## Provedores Suportados

Explore integrações do Gateway com [45+ provedores](https://portkey.wiki/gh-59) e [8+ frameworks de agentes](https://portkey.wiki/gh-90).

|                                                                                                                            | Provedor                                                                                      | Suporte | Stream |
| -------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | ------- | ------ |
| <img src="docs/images/openai.png" width=35 />                                                                              | [OpenAI](https://portkey.wiki/gh-60)                           | ✅       | ✅      |
| <img src="docs/images/azure.png" width=35>                                                                                 | [Azure OpenAI](https://portkey.wiki/gh-61)               | ✅       | ✅      |
| <img src="docs/images/anyscale.png" width=35>                                                                              | [Anyscale](https://portkey.wiki/gh-62) | ✅       | ✅      |
| <img src="https://upload.wikimedia.org/wikipedia/commons/2/2d/Google-favicon-2015.png" width=35>                           | [Google Gemini](https://portkey.wiki/gh-63)             | ✅       | ✅      |
| <img src="docs/images/anthropic.png" width=35>                                                                             | [Anthropic](https://portkey.wiki/gh-64)                     | ✅       | ✅      |
| <img src="docs/images/cohere.png" width=35>                                                                                | [Cohere](https://portkey.wiki/gh-65)                           | ✅       | ✅      |
| <img src="https://assets-global.website-files.com/64f6f2c0e3f4c5a91c1e823a/654693d569494912cfc0c0d4_favicon.svg" width=35> | [Together AI](https://portkey.wiki/gh-66)                 | ✅       | ✅      |
| <img src="https://www.perplexity.ai/favicon.svg" width=35>                                                                 | [Perplexity](https://portkey.wiki/gh-67)                | ✅       | ✅      |
| <img src="https://docs.mistral.ai/img/favicon.ico" width=35>                                                               | [Mistral](https://portkey.wiki/gh-68)                      | ✅       | ✅      |
| <img src="https://docs.nomic.ai/img/nomic-logo.png" width=35>                                                              | [Nomic](https://portkey.wiki/gh-69)                             | ✅       | ✅      |
| <img src="https://files.readme.io/d38a23e-small-studio-favicon.png" width=35>                                              | [AI21](https://portkey.wiki/gh-91)                                    | ✅       | ✅      |
| <img src="https://platform.stability.ai/small-logo-purple.svg" width=35>                                                   | [Stability AI](https://portkey.wiki/gh-71)               | ✅       | ✅      |
| <img src="https://deepinfra.com/_next/static/media/logo.4a03fd3d.svg" width=35>                                            | [DeepInfra](https://portkey.sh/gh-92)                               | ✅       | ✅      |
| <img src="https://ollama.com/public/ollama.png" width=35>                                                                  | [Ollama](https://portkey.wiki/gh-72)                           | ✅       | ✅      |
| <img src="https://novita.ai/favicon.ico" width=35>                                                                         | [Novita AI](https://portkey.wiki/gh-73)                              | ✅       | ✅      | `/chat/completions`, `/completions` |


> [Veja a lista completa de mais de 200 modelos suportados aqui](https://portkey.wiki/gh-74)
<br>

<br>

## Agentes
O Gateway integra-se perfeitamente com frameworks de agentes populares. [Leia a documentação aqui](https://portkey.wiki/gh-75).


| Framework | Chame 200+ LLMs | Roteamento Avançado | Cache | Logging & Tracing* | Observabilidade* | Gestão de Prompts* |
|------------------------------|--------|--------------------|---------|------|---------------|-------------------|
| [Autogen](https://portkey.wiki/gh-93)    | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [CrewAI](https://portkey.wiki/gh-94)             | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [LangChain](https://portkey.wiki/gh-95)             | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [Phidata](https://portkey.wiki/gh-96)             | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [Llama Index](https://portkey.wiki/gh-97)             | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [Control Flow](https://portkey.wiki/gh-98) | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [Construa seus próprios agentes](https://portkey.wiki/gh-99) | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |

<br>

*Disponível no [app hospedado](https://portkey.wiki/gh-76). Para documentação detalhada [clique aqui](https://portkey.wiki/gh-100).


## Versão Empresarial do Gateway
Torne seu app de IA mais <ins>confiável</ins> e <ins>compatível com o futuro</ins>, garantindo total <ins>segurança</ins> e <ins>privacidade</ins> de dados.

✅&nbsp; Gerenciamento Seguro de Chaves - para controle de acesso baseado em papéis e rastreamento <br>
✅&nbsp; Cache Simples & Semântico - para atender consultas repetidas mais rápido e economizar custos <br>
✅&nbsp; Controle de Acesso & Regras de Entrada - para controlar quais IPs e regiões podem conectar-se aos seus deployments <br>
✅&nbsp; Redação de PII - para remover automaticamente dados sensíveis das suas solicitações, prevenindo exposição acidental <br>
✅&nbsp; Conformidade SOC2, ISO, HIPAA, GDPR - para melhores práticas de segurança <br>
✅&nbsp; Suporte Profissional - junto com priorização de funcionalidades <br>

[Agende uma chamada para discutir implantações empresariais](https://portkey.sh/demo-13)

<br>


## Contribuindo

A forma mais fácil de contribuir é escolher uma issue com a tag `good first issue` 💪. Leia as diretrizes de contribuição [aqui](https://raw.githubusercontent.com/Portkey-AI/gateway/main/.github/CONTRIBUTING.md).

Relatar Bug? [Registre aqui](https://portkey.wiki/gh-78) | Sugerir Funcionalidade? [Registre aqui](https://portkey.wiki/gh-78)


### Começando com a Comunidade
Participe das nossas AI Engineering Hours semanais toda sexta-feira (8h PT) para:
- Conhecer outros colaboradores e membros da comunidade
- Aprender recursos avançados do Gateway e padrões de implementação
- Compartilhar experiências e obter ajuda
- Ficar atualizado com as prioridades de desenvolvimento

[Participe da próxima sessão →](https://portkey.wiki/gh-101) | [Notas das reuniões](https://portkey.wiki/gh-102)

<br>

## Comunidade

Junte-se à nossa comunidade em crescimento ao redor do mundo para obter ajuda, ideias e discutir IA.

- Veja nosso [Blog oficial](https://portkey.wiki/gh-78)
- Converse conosco no [Discord](https://portkey.wiki/community)
- Siga-nos no [Twitter](https://portkey.wiki/gh-79)
- Conecte-se conosco no [LinkedIn](https://portkey.wiki/gh-80)
- Leia a documentação em [Japonês](https://raw.githubusercontent.com/Portkey-AI/gateway/main/.github/README.jp.md)
- Visite-nos no [YouTube](https://portkey.wiki/gh-103)
- Participe da nossa [Comunidade Dev](https://portkey.wiki/gh-82)
<!-- - Perguntas com a tag #portkey no [Stack Overflow](https://stackoverflow.com/questions/tagged/portkey) -->

![Rubeus Social Share (4)](https://github.com/Portkey-AI/gateway/assets/971978/89d6f0af-a95d-4402-b451-14764c40d03f)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---