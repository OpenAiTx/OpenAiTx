# Kubernetes Da Maneira Difícil

Este tutorial orienta você na configuração do Kubernetes da maneira difícil. Este guia não é destinado a quem procura uma ferramenta totalmente automatizada para criar um cluster Kubernetes. Kubernetes Da Maneira Difícil é otimizado para aprendizado, o que significa seguir o caminho mais longo para garantir que você compreenda cada tarefa necessária para inicializar um cluster Kubernetes.

> Os resultados deste tutorial não devem ser considerados prontos para produção e podem receber suporte limitado da comunidade, mas não deixe que isso o impeça de aprender!

## Direitos Autorais

<a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/"><img alt="Licença Creative Commons" style="border-width:0" src="https://i.creativecommons.org/l/by-nc-sa/4.0/88x31.png" /></a><br />Este trabalho está licenciado sob uma <a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/">Licença Creative Commons Atribuição-NãoComercial-CompartilhaIgual 4.0 Internacional</a>.


## Público-Alvo

O público-alvo deste tutorial é alguém que deseja entender os fundamentos do Kubernetes e como os componentes principais se encaixam.

## Detalhes do Cluster

Kubernetes Da Maneira Difícil orienta você na inicialização de um cluster Kubernetes básico com todos os componentes do plano de controle rodando em um único nó, e dois nós de trabalho, o que é suficiente para aprender os conceitos principais.

Versões dos componentes:

* [kubernetes](https://github.com/kubernetes/kubernetes) v1.32.x
* [containerd](https://github.com/containerd/containerd) v2.1.x
* [cni](https://github.com/containernetworking/cni) v1.6.x
* [etcd](https://github.com/etcd-io/etcd) v3.6.x

## Laboratórios

Este tutorial requer quatro (4) máquinas virtuais ou físicas baseadas em ARM64 ou AMD64 conectadas à mesma rede.

* [Pré-requisitos](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/01-prerequisites.md)
* [Configurando o Jumpbox](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/02-jumpbox.md)
* [Provisionando Recursos de Computação](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/03-compute-resources.md)
* [Provisionando a CA e Gerando Certificados TLS](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/04-certificate-authority.md)
* [Gerando Arquivos de Configuração do Kubernetes para Autenticação](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/05-kubernetes-configuration-files.md)
* [Gerando a Configuração e a Chave de Criptografia de Dados](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/06-data-encryption-keys.md)
* [Inicializando o Cluster etcd](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/07-bootstrapping-etcd.md)
* [Inicializando o Plano de Controle do Kubernetes](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/08-bootstrapping-kubernetes-controllers.md)
* [Inicializando os Nós de Trabalho do Kubernetes](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/09-bootstrapping-kubernetes-workers.md)
* [Configurando o kubectl para Acesso Remoto](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/10-configuring-kubectl.md)
* [Provisionando Rotas de Rede de Pod](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/11-pod-network-routes.md)
* [Teste de Fumaça](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/12-smoke-test.md)
* [Limpando](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/13-cleanup.md)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-28

---