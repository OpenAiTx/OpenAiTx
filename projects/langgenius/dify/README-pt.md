![cover-v5-optimized](./images/GitHub_README_if.png)

<p align="center">
  📌 <a href="https://dify.ai/blog/introducing-dify-workflow-file-upload-a-demo-on-ai-podcast">Apresentando o Upload de Arquivos no Workflow do Dify: Recrie o Podcast do Google NotebookLM</a>
</p>

<p align="center">
  <a href="https://cloud.dify.ai">Dify Cloud</a> ·
  <a href="https://docs.dify.ai/getting-started/install-self-hosted">Auto-hospedagem</a> ·
  <a href="https://docs.dify.ai">Documentação</a> ·
  <a href="https://dify.ai/pricing">Visão geral das edições Dify</a>
</p>

<p align="center">
    <a href="https://dify.ai" target="_blank">
        <img alt="Static Badge" src="https://img.shields.io/badge/Product-F04438"></a>
    <a href="https://dify.ai/pricing" target="_blank">
        <img alt="Static Badge" src="https://img.shields.io/badge/free-pricing?logo=free&color=%20%23155EEF&label=pricing&labelColor=%20%23528bff"></a>
    <a href="https://discord.gg/FngNHpbcY7" target="_blank">
        <img src="https://img.shields.io/discord/1082486657678311454?logo=discord&labelColor=%20%235462eb&logoColor=%20%23f5f5f5&color=%20%235462eb"
            alt="chat on Discord"></a>
    <a href="https://reddit.com/r/difyai" target="_blank">  
        <img src="https://img.shields.io/reddit/subreddit-subscribers/difyai?style=plastic&logo=reddit&label=r%2Fdifyai&labelColor=white"
            alt="join Reddit"></a>
    <a href="https://twitter.com/intent/follow?screen_name=dify_ai" target="_blank">
        <img src="https://img.shields.io/twitter/follow/dify_ai?logo=X&color=%20%23f5f5f5"
            alt="follow on X(Twitter)"></a>
    <a href="https://www.linkedin.com/company/langgenius/" target="_blank">
        <img src="https://custom-icon-badges.demolab.com/badge/LinkedIn-0A66C2?logo=linkedin-white&logoColor=fff"
            alt="follow on LinkedIn"></a>
    <a href="https://hub.docker.com/u/langgenius" target="_blank">
        <img alt="Docker Pulls" src="https://img.shields.io/docker/pulls/langgenius/dify-web?labelColor=%20%23FDB062&color=%20%23f79009"></a>
    <a href="https://github.com/langgenius/dify/graphs/commit-activity" target="_blank">
        <img alt="Commits last month" src="https://img.shields.io/github/commit-activity/m/langgenius/dify?labelColor=%20%2332b583&color=%20%2312b76a"></a>
    <a href="https://github.com/langgenius/dify/" target="_blank">
        <img alt="Issues closed" src="https://img.shields.io/github/issues-search?query=repo%3Alanggenius%2Fdify%20is%3Aclosed&label=issues%20closed&labelColor=%20%237d89b0&color=%20%235d6b98"></a>
    <a href="https://github.com/langgenius/dify/discussions/" target="_blank">
        <img alt="Discussion posts" src="https://img.shields.io/github/discussions/langgenius/dify?labelColor=%20%239b8afb&color=%20%237a5af8"></a>
</p>

<p align="center">
  <a href="./README.md"><img alt="README in English" src="https://img.shields.io/badge/English-d9d9d9"></a>
  <a href="./README_TW.md"><img alt="繁體中文文件" src="https://img.shields.io/badge/繁體中文-d9d9d9"></a>
  <a href="./README_CN.md"><img alt="简体中文版自述文件" src="https://img.shields.io/badge/简体中文-d9d9d9"></a>
  <a href="./README_JA.md"><img alt="日本語のREADME" src="https://img.shields.io/badge/日本語-d9d9d9"></a>
  <a href="./README_ES.md"><img alt="README en Español" src="https://img.shields.io/badge/Español-d9d9d9"></a>
  <a href="./README_FR.md"><img alt="README en Français" src="https://img.shields.io/badge/Français-d9d9d9"></a>
  <a href="./README_KL.md"><img alt="README tlhIngan Hol" src="https://img.shields.io/badge/Klingon-d9d9d9"></a>
  <a href="./README_KR.md"><img alt="README in Korean" src="https://img.shields.io/badge/한국어-d9d9d9"></a>
  <a href="./README_AR.md"><img alt="README بالعربية" src="https://img.shields.io/badge/العربية-d9d9d9"></a>
  <a href="./README_TR.md"><img alt="Türkçe README" src="https://img.shields.io/badge/Türkçe-d9d9d9"></a>
  <a href="./README_VI.md"><img alt="README Tiếng Việt" src="https://img.shields.io/badge/Ti%E1%BA%BFng%20Vi%E1%BB%87t-d9d9d9"></a>
  <a href="./README_DE.md"><img alt="README in Deutsch" src="https://img.shields.io/badge/German-d9d9d9"></a>
  <a href="./README_BN.md"><img alt="README in বাংলা" src="https://img.shields.io/badge/বাংলা-d9d9d9"></a>
</p>

Dify é uma plataforma open-source para desenvolvimento de aplicativos com LLM. Sua interface intuitiva combina fluxo de trabalho agentico de IA, pipeline RAG, capacidades de agente, gerenciamento de modelos, recursos de observabilidade, e muito mais, permitindo que você avance rapidamente do protótipo à produção.

## Início rápido

> Antes de instalar o Dify, certifique-se de que sua máquina atenda aos seguintes requisitos mínimos do sistema:
>
> - CPU >= 2 Núcleos
> - RAM >= 4 GiB

</br>

A maneira mais fácil de iniciar o servidor Dify é através do [docker compose](docker/docker-compose.yaml). Antes de executar o Dify com os comandos abaixo, certifique-se de que o [Docker](https://docs.docker.com/get-docker/) e o [Docker Compose](https://docs.docker.com/compose/install/) estejam instalados em sua máquina:

```bash
cd dify
cd docker
cp .env.example .env
docker compose up -d
```

Após a execução, você pode acessar o painel do Dify em seu navegador pelo endereço [http://localhost/install](http://localhost/install) e iniciar o processo de inicialização.

#### Procurando ajuda

Consulte nosso [FAQ](https://docs.dify.ai/getting-started/install-self-hosted/faqs) se encontrar problemas ao configurar o Dify. Entre em contato com [a comunidade e conosco](#community--contact) caso ainda tenha dificuldades.

> Se deseja contribuir com o Dify ou realizar desenvolvimento adicional, consulte nosso [guia de deploy a partir do código-fonte](https://docs.dify.ai/getting-started/install-self-hosted/local-source-code)

## Principais recursos

**1. Workflow**:
Crie e teste poderosos fluxos de trabalho de IA em um canvas visual, aproveitando todos os recursos a seguir e muito mais.

**2. Suporte abrangente a modelos**:
Integração perfeita com centenas de LLMs proprietários/open-source de dezenas de provedores de inferência e soluções auto-hospedadas, abrangendo GPT, Mistral, Llama3 e qualquer modelo compatível com a API OpenAI. Uma lista completa dos provedores de modelos suportados pode ser encontrada [aqui](https://docs.dify.ai/getting-started/readme/model-providers).

![providers-v5](https://github.com/langgenius/dify/assets/13230914/5a17bdbe-097a-4100-8363-40255b70f6e3)

**3. Prompt IDE**:
Interface intuitiva para criação de prompts, comparação de desempenho entre modelos e adição de recursos extras como texto para fala em apps baseados em chat.

**4. Pipeline RAG**:
Capacidades RAG extensas, abrangendo desde a ingestão até a recuperação de documentos, com suporte nativo para extração de texto de PDFs, PPTs e outros formatos comuns.

**5. Capacidades de agente**:
Você pode definir agentes baseados em LLM Function Calling ou ReAct, além de adicionar ferramentas pré-construídas ou personalizadas para o agente. O Dify oferece mais de 50 ferramentas integradas para agentes de IA, como Google Search, DALL·E, Stable Diffusion e WolframAlpha.

**6. LLMOps**:
Monitore e analise logs e desempenho das aplicações ao longo do tempo. Você pode aprimorar continuamente prompts, conjuntos de dados e modelos com base nos dados de produção e anotações.

**7. Backend-como-Serviço**:
Todas as ofertas do Dify vêm com APIs correspondentes, para que você possa integrar facilmente o Dify à sua lógica de negócios.

## Comparação de recursos

<table style="width: 100%;">
  <tr>
    <th align="center">Recurso</th>
    <th align="center">Dify.AI</th>
    <th align="center">LangChain</th>
    <th align="center">Flowise</th>
    <th align="center">OpenAI Assistants API</th>
  </tr>
  <tr>
    <td align="center">Abordagem de Programação</td>
    <td align="center">API + Foco em Aplicações</td>
    <td align="center">Código Python</td>
    <td align="center">Foco em Aplicações</td>
    <td align="center">Foco em API</td>
  </tr>
  <tr>
    <td align="center">LLMs Suportados</td>
    <td align="center">Grande Variedade</td>
    <td align="center">Grande Variedade</td>
    <td align="center">Grande Variedade</td>
    <td align="center">Somente OpenAI</td>
  </tr>
  <tr>
    <td align="center">Motor RAG</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
  </tr>
  <tr>
    <td align="center">Agente</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
    <td align="center">✅</td>
  </tr>
  <tr>
    <td align="center">Workflow</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
  </tr>
  <tr>
    <td align="center">Observabilidade</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
    <td align="center">❌</td>
  </tr>
  <tr>
    <td align="center">Recursos Corporativos (SSO/Controle de acesso)</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
    <td align="center">❌</td>
    <td align="center">❌</td>
  </tr>
  <tr>
    <td align="center">Deploy Local</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
  </tr>
</table>

## Usando o Dify

- **Cloud </br>**
  Mantemos um serviço [Dify Cloud](https://dify.ai) para qualquer pessoa experimentar sem configuração. Ele oferece todas as capacidades da versão auto-hospedada e inclui 200 chamadas gratuitas ao GPT-4 no plano sandbox.

- **Auto-hospedagem Dify Community Edition</br>**
  Coloque o Dify para rodar rapidamente em seu ambiente com este [guia inicial](#quick-start).
  Use nossa [documentação](https://docs.dify.ai) para referências adicionais e instruções mais detalhadas.

- **Dify para empresas / organizações</br>**
  Oferecemos recursos adicionais focados em empresas. [Envie suas perguntas para nós através deste chatbot](https://udify.app/chat/22L1zSxg6yW1cWQg) ou [envie um e-mail](mailto:business@dify.ai?subject=[GitHub]Business%20License%20Inquiry) para discutir necessidades empresariais. </br>
  > Para startups e pequenas empresas que usam AWS, confira o [Dify Premium na AWS Marketplace](https://aws.amazon.com/marketplace/pp/prodview-t22mebxzwjhu6) e faça o deploy em sua própria AWS VPC com um clique. É uma oferta AMI acessível com a opção de criar apps com logo e marca personalizados.

## Mantenha-se atualizado

Dê uma estrela ao Dify no GitHub para ser notificado instantaneamente sobre novos lançamentos.

![star-us](https://github.com/langgenius/dify/assets/13230914/b823edc1-6388-4e25-ad45-2f6b187adbb4)

## Configuração avançada

Se precisar personalizar a configuração, consulte os comentários em nosso arquivo [.env.example](docker/.env.example) e atualize os valores correspondentes no seu arquivo `.env`. Além disso, você pode precisar ajustar o próprio arquivo `docker-compose.yaml`, como trocar versões de imagens, mapeamento de portas ou montagem de volumes, de acordo com o seu ambiente de deploy e requisitos. Após qualquer alteração, execute novamente `docker-compose up -d`. Você pode encontrar a lista completa de variáveis de ambiente disponíveis [aqui](https://docs.dify.ai/getting-started/install-self-hosted/environments).

Se quiser configurar um ambiente altamente disponível, há [Helm Charts](https://helm.sh/) e arquivos YAML contribuídos pela comunidade que permitem o deploy do Dify no Kubernetes.

- [Helm Chart por @LeoQuote](https://github.com/douban/charts/tree/master/charts/dify)
- [Helm Chart por @BorisPolonsky](https://github.com/BorisPolonsky/dify-helm)
- [Helm Chart por @magicsong](https://github.com/magicsong/ai-charts)
- [Arquivo YAML por @Winson-030](https://github.com/Winson-030/dify-kubernetes)
- [Arquivo YAML por @wyy-holding](https://github.com/wyy-holding/dify-k8s)

#### Usando Terraform para Deploy

Faça o deploy do Dify em plataformas Cloud com um clique usando [terraform](https://www.terraform.io/)

##### Azure Global

- [Azure Terraform por @nikawang](https://github.com/nikawang/dify-azure-terraform)

##### Google Cloud

- [Google Cloud Terraform por @sotazum](https://github.com/DeNA/dify-google-cloud-terraform)

#### Usando AWS CDK para Deploy

Faça o deploy do Dify na AWS com [CDK](https://aws.amazon.com/cdk/)

##### AWS

- [AWS CDK por @KevinZhao](https://github.com/aws-samples/solution-for-deploying-dify-on-aws)

## Contribuindo

Para quem deseja contribuir com código, veja nosso [Guia de Contribuição](https://github.com/langgenius/dify/blob/main/CONTRIBUTING.md).
Ao mesmo tempo, considere apoiar o Dify compartilhando-o nas redes sociais, eventos e conferências.

> Estamos buscando colaboradores para ajudar a traduzir o Dify para outros idiomas além do mandarim e inglês. Se você tem interesse, veja o [README i18n](https://github.com/langgenius/dify/blob/main/web/i18n/README.md) para mais informações, e deixe um comentário no canal `global-users` do nosso [Servidor da Comunidade no Discord](https://discord.gg/8Tpq4AcN9c).

## Comunidade & contato

- [Discussão no GitHub](https://github.com/langgenius/dify/discussions). Ideal para: compartilhar feedback e tirar dúvidas.
- [Issues no GitHub](https://github.com/langgenius/dify/issues). Ideal para: bugs encontrados no uso do Dify.AI e propostas de recursos. Veja nosso [Guia de Contribuição](https://github.com/langgenius/dify/blob/main/CONTRIBUTING.md).
- [Discord](https://discord.gg/FngNHpbcY7). Ideal para: compartilhar suas aplicações e interagir com a comunidade.
- [X(Twitter)](https://twitter.com/dify_ai). Ideal para: compartilhar suas aplicações e interagir com a comunidade.

**Contribuidores**

<a href="https://github.com/langgenius/dify/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=langgenius/dify" />
</a>

## Histórico de estrelas

[![Star History Chart](https://api.star-history.com/svg?repos=langgenius/dify&type=Date)](https://star-history.com/#langgenius/dify&Date)

## Divulgação de segurança

Para proteger sua privacidade, evite postar questões de segurança no GitHub. Em vez disso, envie suas perguntas para security@dify.ai e forneceremos uma resposta mais detalhada.

## Licença

Este repositório está disponível sob a [Licença Open Source Dify](LICENSE), que é essencialmente Apache 2.0 com algumas restrições adicionais.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---