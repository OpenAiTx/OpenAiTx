![Envoy Logo](https://github.com/envoyproxy/artwork/blob/main/PNG/Envoy_Logo_Final_PANTONE.png)

[Proxy de borda/meio/serviço de alto desempenho e nativo em nuvem](https://www.envoyproxy.io/)

O Envoy é hospedado pela [Cloud Native Computing Foundation](https://cncf.io) (CNCF). Se você é uma
empresa que deseja ajudar a moldar a evolução de tecnologias que são empacotadas em containers,
agendadas dinamicamente e orientadas a microsserviços, considere aderir à CNCF. Para detalhes sobre quem está
envolvido e como o Envoy desempenha um papel, leia o
[anúncio](https://www.cncf.io/blog/2017/09/13/cncf-hosts-envoy/) da CNCF.

[![CII Best Practices](https://bestpractices.coreinfrastructure.org/projects/1266/badge)](https://bestpractices.coreinfrastructure.org/projects/1266)
[![OpenSSF Scorecard](https://api.securityscorecards.dev/projects/github.com/envoyproxy/envoy/badge)](https://securityscorecards.dev/viewer/?uri=github.com/envoyproxy/envoy)
[![CLOMonitor](https://img.shields.io/endpoint?url=https://clomonitor.io/api/projects/cncf/envoy/badge)](https://clomonitor.io/projects/cncf/envoy)
[![Azure Pipelines](https://dev.azure.com/cncf/envoy/_apis/build/status/11?branchName=main)](https://dev.azure.com/cncf/envoy/_build/latest?definitionId=11&branchName=main)
[![Fuzzing Status](https://oss-fuzz-build-logs.storage.googleapis.com/badges/envoy.svg)](https://bugs.chromium.org/p/oss-fuzz/issues/list?sort=-opened&can=1&q=proj:envoy)
[![Jenkins](https://powerci.osuosl.org/buildStatus/icon?job=build-envoy-static-master&subject=ppc64le%20build)](https://powerci.osuosl.org/job/build-envoy-static-master/)
[![Jenkins](https://ibmz-ci.osuosl.org/buildStatus/icon?job=Envoy_IBMZ_CI&subject=s390x%20build)](https://ibmz-ci.osuosl.org/job/Envoy_IBMZ_CI/)

## Documentação

* [Documentação oficial](https://www.envoyproxy.io/)
* [FAQ](https://www.envoyproxy.io/docs/envoy/latest/faq/overview)
* [Documentação de exemplos](https://github.com/envoyproxy/examples/)
* [Blog](https://medium.com/@mattklein123/envoy-threading-model-a8d44b922310) sobre o modelo de threading
* [Blog](https://medium.com/@mattklein123/envoy-hot-restart-1d16b14555b5) sobre hot restart
* [Blog](https://medium.com/@mattklein123/envoy-stats-b65c7f363342) sobre arquitetura de estatísticas
* [Blog](https://medium.com/@mattklein123/the-universal-data-plane-api-d15cec7a) sobre a universal data plane API
* [Blog](https://medium.com/@mattklein123/lyfts-envoy-dashboards-5c91738816b1) sobre os dashboards do Envoy da Lyft

## Relacionados

* [data-plane-api](https://github.com/envoyproxy/data-plane-api): Definições da API v2 em um repositório
  independente. Este é um espelho somente leitura de [api](https://raw.githubusercontent.com/envoyproxy/envoy/main/api/).
* [envoy-perf](https://github.com/envoyproxy/envoy-perf): Framework de testes de desempenho.
* [envoy-filter-example](https://github.com/envoyproxy/envoy-filter-example): Exemplo de como adicionar novos filtros
  e linkar ao repositório principal.

## Contato

* [envoy-announce](https://groups.google.com/forum/#!forum/envoy-announce): Lista de e-mails de baixa
  frequência onde enviaremos apenas anúncios.
* [envoy-security-announce](https://groups.google.com/forum/#!forum/envoy-security-announce): Lista de e-mails de baixa
  frequência onde enviaremos apenas anúncios relacionados à segurança.
* [envoy-users](https://groups.google.com/forum/#!forum/envoy-users): Discussão geral de usuários.
* [envoy-dev](https://groups.google.com/forum/#!forum/envoy-dev): Discussão de desenvolvedores do Envoy (APIs,
  design de funcionalidades, etc.).
* [envoy-maintainers](https://groups.google.com/forum/#!forum/envoy-maintainers): Use esta lista
  para entrar em contato com todos os mantenedores principais do Envoy.
* [Twitter](https://twitter.com/EnvoyProxy/): Siga-nos no Twitter!
* [Slack](https://envoyproxy.slack.com/): Slack, para ser convidado acesse [aqui](https://communityinviter.com/apps/envoyproxy/envoy).
  * NOTA: As respostas a perguntas de usuários são feitas conforme disponibilidade no Slack. Para uma resposta "garantida" envie um e-mail
    para envoy-users@ conforme orientação no tópico do link abaixo.

Consulte [este](https://groups.google.com/forum/#!topic/envoy-announce/l9zjYsnS3TY) tópico de e-mail
para informações sobre o uso das listas de e-mail.

## Contribuindo

Contribuir com o Envoy é divertido e C++ moderno é muito menos assustador do que você pode pensar se não
tiver experiência prévia. Para começar:

* [Guia de contribuição](https://raw.githubusercontent.com/envoyproxy/envoy/main/CONTRIBUTING.md)
* [Issues para iniciantes](https://github.com/envoyproxy/envoy/issues?q=is%3Aopen+is%3Aissue+label%3Abeginner)
* [Início rápido de build/test usando docker](https://raw.githubusercontent.com/envoyproxy/envoy/main/ci#building-and-running-tests-as-a-developer)
* [Guia do desenvolvedor](https://raw.githubusercontent.com/envoyproxy/envoy/main/DEVELOPER.md)
* Considere instalar a [ferramenta de suporte ao desenvolvimento do Envoy](https://github.com/envoyproxy/envoy/blob/main/support/README.md), que ajuda a automatizar partes do processo de desenvolvimento, principalmente aquelas envolvendo revisão de código.
* Por favor, nos informe se você está trabalhando em uma issue para evitar trabalho duplicado!

## Reunião da Comunidade

A equipe do Envoy tem uma reunião agendada duas vezes por mês, às terças-feiras, às 9h PT. O calendário público
do Google está [aqui](https://goo.gl/PkDijT).  A reunião só será realizada
se houver itens de pauta listados na [ata da reunião](https://goo.gl/5Cergb).  Qualquer membro da comunidade pode
propor itens de pauta adicionando à ata.  Os mantenedores irão confirmar
as adições à pauta, ou cancelarão a reunião dentro de 24 horas da data agendada caso não haja pauta confirmada.

## Segurança

### Auditoria de Segurança

Houve várias avaliações de terceiros focadas na segurança do Envoy:
* Em 2018, a Cure53 realizou uma auditoria de segurança, [relatório completo](https://raw.githubusercontent.com/envoyproxy/envoy/main/docs/security/audit_cure53_2018.pdf).
* Em 2021, a Ada Logics realizou uma auditoria em nossa infraestrutura de fuzzing, com recomendações de melhorias, [relatório completo](https://raw.githubusercontent.com/envoyproxy/envoy/main/docs/security/audit_fuzzer_adalogics_2021.pdf).

### Relatando vulnerabilidades de segurança

Se você encontrou uma vulnerabilidade ou uma possível vulnerabilidade no Envoy, por favor, nos informe em
[envoy-security](mailto:envoy-security@googlegroups.com). Enviaremos um e-mail de confirmação
para reconhecer seu relatório e um e-mail adicional quando identificarmos a questão
positiva ou negativamente.

Para mais detalhes, consulte nosso [processo completo de divulgação de segurança](https://raw.githubusercontent.com/envoyproxy/envoy/main/SECURITY.md).

### Builds ppc64le

Builds para a arquitetura ppc64le ou usando aws-lc não são cobertos pela política de segurança do Envoy. A arquitetura ppc64le atualmente é best-effort e não é mantida pelos mantenedores do Envoy.

## Lançamentos

Para mais detalhes, consulte nosso [processo de lançamento](https://github.com/envoyproxy/envoy/blob/main/RELEASES.md).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-12

---