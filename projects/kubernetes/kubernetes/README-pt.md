# Kubernetes (K8s)

[![CII Best Practices](https://bestpractices.coreinfrastructure.org/projects/569/badge)](https://bestpractices.coreinfrastructure.org/projects/569) [![Go Report Card](https://goreportcard.com/badge/github.com/kubernetes/kubernetes)](https://goreportcard.com/report/github.com/kubernetes/kubernetes) ![GitHub release (latest SemVer)](https://img.shields.io/github/v/release/kubernetes/kubernetes?sort=semver)

<img src="https://github.com/kubernetes/kubernetes/raw/master/logo/logo.png" width="100">

----

Kubernetes, também conhecido como K8s, é um sistema de código aberto para gerenciar [aplicações conteinerizadas] em múltiplos hosts. Ele fornece mecanismos básicos para implantação, manutenção e escalabilidade de aplicações.

O Kubernetes é resultado de uma década e meia de experiência do Google executando cargas de trabalho em produção em grande escala usando um sistema chamado [Borg], combinado com as melhores ideias e práticas da comunidade.

O Kubernetes é hospedado pela Cloud Native Computing Foundation ([CNCF]). Se sua empresa deseja ajudar a moldar a evolução de tecnologias empacotadas em containers, dinamicamente agendadas e orientadas a microsserviços, considere juntar-se à CNCF. Para detalhes sobre quem está envolvido e como o Kubernetes desempenha seu papel, leia o [anúncio] da CNCF.

----

## Para começar a usar o K8s

Veja nossa documentação em [kubernetes.io].

Faça um curso gratuito sobre [Microsserviços Escaláveis com Kubernetes].

Para usar o código do Kubernetes como biblioteca em outras aplicações, veja a [lista de componentes publicados](https://git.k8s.io/kubernetes/staging/README.md). O uso do módulo `k8s.io/kubernetes` ou dos pacotes `k8s.io/kubernetes/...` como bibliotecas não é suportado.

## Para começar a desenvolver no K8s

O [repositório da comunidade] hospeda todas as informações sobre como construir o Kubernetes a partir do código-fonte, como contribuir com código e documentação, quem contatar para cada assunto, etc.

Se você quiser construir o Kubernetes imediatamente, existem duas opções:

##### Você possui um [ambiente Go] funcional.

```
git clone https://github.com/kubernetes/kubernetes
cd kubernetes
make
```

##### Você possui um [ambiente Docker] funcional.

```
git clone https://github.com/kubernetes/kubernetes
cd kubernetes
make quick-release
```

Para informações completas, acesse a [documentação do desenvolvedor].

## Suporte

Se você precisa de suporte, comece com o [guia de solução de problemas], e siga o processo que delineamos.

Dito isso, se você tiver dúvidas, entre em contato conosco [de uma forma ou de outra][comunicação].

[anúncio]: https://cncf.io/news/announcement/2015/07/new-cloud-native-computing-foundation-drive-alignment-among-container
[Borg]: https://research.google.com/pubs/pub43438.html?authuser=1
[CNCF]: https://www.cncf.io/about
[comunicação]: https://git.k8s.io/community/communication
[repositório da comunidade]: https://git.k8s.io/community
[aplicações conteinerizadas]: https://kubernetes.io/docs/concepts/overview/what-is-kubernetes/
[documentação do desenvolvedor]: https://git.k8s.io/community/contributors/devel#readme
[ambiente Docker]: https://docs.docker.com/engine
[ambiente Go]: https://go.dev/doc/install
[kubernetes.io]: https://kubernetes.io
[Microsserviços Escaláveis com Kubernetes]: https://www.udacity.com/course/scalable-microservices-with-kubernetes--ud615
[guia de solução de problemas]: https://kubernetes.io/docs/tasks/debug/

## Reuniões da Comunidade

O [Calendário](https://www.kubernetes.dev/resources/calendar/) possui a lista de todas as reuniões da comunidade Kubernetes em um único local.

## Adotantes

O site de [Estudos de Caso de Usuários](https://kubernetes.io/case-studies/) apresenta casos reais de organizações de diversos setores que estão implantando/migrando para o Kubernetes.

## Governança

O projeto Kubernetes é regido por um conjunto de princípios, valores, políticas e processos para ajudar nossa comunidade e participantes a atingir objetivos comuns.

A [Comunidade Kubernetes](https://github.com/kubernetes/community/blob/master/governance.md) é o ponto de partida para aprender como nos organizamos.

O [repositório da Steering Committee do Kubernetes](https://github.com/kubernetes/steering) é utilizado pelo Comitê de Direção do Kubernetes, que supervisiona a governança do projeto.

## Roteiro

O [repositório de Melhorias do Kubernetes](https://github.com/kubernetes/enhancements) fornece informações sobre lançamentos do Kubernetes, além do acompanhamento de funcionalidades e backlogs.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---