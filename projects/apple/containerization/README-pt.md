# Containerization

O pacote Containerization permite que aplicações usem containers Linux.
Containerization é escrito em [Swift](https://www.swift.org) e usa o [Virtualization.framework](https://developer.apple.com/documentation/virtualization) em Apple silicon.

Containerization fornece APIs para:

- [Gerenciar imagens OCI](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationOCI/).
- [Interagir com registries remotos](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationOCI/Client/).
- [Criar e popular sistemas de arquivos ext4](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationEXT4/).
- [Interagir com a família de sockets Netlink](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationNetlink/).
- [Criar um kernel Linux otimizado para tempos rápidos de boot](https://raw.githubusercontent.com/apple/containerization/main/kernel/).
- [Iniciar máquinas virtuais leves e gerenciar o ambiente de runtime](https://raw.githubusercontent.com/apple/containerization/main/Sources/Containerization/LinuxContainer.swift).
- [Iniciar e interagir com processos containerizados](https://raw.githubusercontent.com/apple/containerization/main/Sources/Containerization/LinuxProcess.swift).
- Usar Rosetta 2 para executar containers linux/amd64 em Apple silicon.

Por favor, consulte a [documentação da API](https://apple.github.io/containerization/documentation/) para informações sobre os pacotes Swift que Containerization fornece.

## Design

Containerization executa cada container Linux dentro de sua própria máquina virtual leve. Os clientes podem criar endereços IP dedicados para cada container, eliminando a necessidade de encaminhamento de portas individual. Os containers alcançam tempos de inicialização abaixo de um segundo usando uma [configuração de kernel Linux otimizada](https://raw.githubusercontent.com/apple/containerization/main/kernel) e um sistema de arquivos root minimalista com um sistema init leve.

[vminitd](https://raw.githubusercontent.com/apple/containerization/main/vminitd) é um pequeno sistema init, que é um subprojeto dentro do Containerization.
`vminitd` é iniciado como o processo inicial dentro da máquina virtual e fornece uma API GRPC sobre vsock.
A API permite configurar o ambiente de runtime e iniciar processos containerizados.
`vminitd` fornece I/O, sinais e eventos para o processo chamador quando um processo é executado.

## Requisitos

Você precisa de um Mac com Apple silicon para compilar e rodar o Containerization.

Para compilar o pacote Containerization, seu sistema precisa de um dos seguintes:

- macOS 15 ou mais recente e Xcode 26 beta
- macOS 26 beta ou mais recente

Aplicações construídas usando o pacote rodarão no macOS 15 ou posterior, mas os seguintes recursos não estão disponíveis no macOS 15:

- Rede de containers não isolada - com macOS 15, containers na mesma rede vmnet não podem se comunicar entre si

## Exemplo de Uso

Para exemplos de como usar algumas das bibliotecas disponíveis, o executável cctl é um bom ponto de partida. A principal função dessa ferramenta é servir como um playground para experimentar a API. Ela contém comandos que exercitam algumas das funcionalidades centrais dos vários produtos, como:

1. [Manipulação de imagens OCI](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/ImageCommand.swift)
2. [Login em registries de container](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/LoginCommand.swift)
3. [Criação de blocos do sistema de arquivos root](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/RootfsCommand.swift)
4. [Execução de containers Linux simples](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/RunCommand.swift)

## Kernel Linux

Um kernel Linux é necessário para iniciar máquinas virtuais leves no macOS.
Containerization fornece uma configuração de kernel otimizada localizada no diretório [kernel](https://raw.githubusercontent.com/apple/containerization/main/kernel).

Este diretório inclui um ambiente de build containerizado para compilar facilmente um kernel para uso com Containerization.

A configuração do kernel é um conjunto mínimo de recursos para suportar tempos rápidos de inicialização e um ambiente leve.

Embora esta configuração funcione para a maioria das cargas de trabalho, entendemos que algumas podem precisar de recursos extras.
Para resolver isso, Containerization fornece APIs de primeira classe para usar diferentes configurações e versões de kernel por container.
Isso permite que containers sejam desenvolvidos e validados em diferentes versões de kernel.

Veja o [README](https://raw.githubusercontent.com/apple/containerization/main/kernel/README.md) no diretório kernel para instruções de como compilar o kernel otimizado.

### Kernel pré-compilado

Se desejar usar um kernel pré-compilado, ele deve ter drivers `VIRTIO` compilados diretamente no kernel, não como módulos.

O projeto [Kata Containers](https://github.com/kata-containers/kata-containers) fornece um kernel otimizado para containers com todas as opções de configuração necessárias habilitadas, disponível na página de [releases](https://github.com/kata-containers/kata-containers/releases/).

Uma imagem de kernel chamada `vmlinux.container` pode ser encontrada no diretório `/opt/kata/share/kata-containers/` dos artefatos da release.

## Preparar para compilar o pacote

Instale Swiftly, [Swift](https://www.swift.org), e o [Static Linux SDK](https://www.swift.org/documentation/articles/static-linux-getting-started.html):

```bash
make cross-prep
```

Se você usa um aplicativo de terminal personalizado, talvez precise mover este comando de `.zprofile` para `.zshrc` (substitua `<USERNAME>`):

```bash
# Adicionado pelo swiftly
. "/Users/<USERNAME>/.swiftly/env.sh"
```

Reinicie o aplicativo de terminal. Certifique-se de que este comando retorne `/Users/<USERNAME>/.swiftly/bin/swift` (substitua `<USERNAME>`):

```bash
which swift
```

Se você instalou ou usou um Static Linux SDK anteriormente, pode ser necessário remover versões antigas do SDK do sistema (substitua `<SDK-ID>`):

```bash
swift sdk list
swift sdk remove <SDK-ID>
```

## Compilar o pacote

Compile o Containerization a partir do código fonte:

```bash
make all
```

## Testar o pacote

Após compilar, execute testes básicos e de integração:

```bash
make test integration
```

Um kernel é necessário para rodar testes de integração.
Se você não possui um kernel local, um kernel padrão pode ser obtido usando o alvo `make fetch-default-kernel`.

Buscar o kernel padrão só precisa ser feito após uma compilação inicial ou após um `make clean`.

```bash
make fetch-default-kernel
make all test integration
```

## Protobufs

Containerization depende de versões específicas de `grpc-swift` e `swift-protobuf`. Você pode instalá-los e regenerar as interfaces RPC com:

```bash
make protos
```

## Documentação

Gere a documentação da API para visualização local com:

```bash
make docs
make serve-docs
```

Visualize a documentação executando em outro terminal:

```bash
open http://localhost:8000/documentation/
```

## Contribuindo

Contribuições para Containerization são bem-vindas e incentivadas. Por favor, veja [CONTRIBUTING.md](https://raw.githubusercontent.com/apple/containerization/main/CONTRIBUTING.md) para mais informações.

## Status do Projeto

A versão 0.1.0 é o primeiro lançamento oficial do Containerization. Versões anteriores não garantem estabilidade da fonte.

Como a biblioteca Containerization está em desenvolvimento ativo, a estabilidade da fonte é garantida apenas dentro de versões menores (por exemplo, entre 0.1.1 e 0.1.2). Se você não quiser atualizações que possam quebrar a fonte, pode especificar a dependência do pacote usando .upToNextMinorVersion(from: "0.1.0") em vez disso.

Futuras versões menores do pacote podem introduzir mudanças nessas regras conforme necessário.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---