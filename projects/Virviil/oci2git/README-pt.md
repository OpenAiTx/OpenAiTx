
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=as">অসমীয়া</a>
      </div>
    </div>
  </details>
</div>

<div align="center">
<img src="https://raw.githubusercontent.com/Virviil/oci2git/main/assets/logo.png" width="140px" />

# OCI2Git

[![Documentação](https://docs.rs/oci2git/badge.svg)][documentation]
[![Crates.io](https://img.shields.io/crates/v/oci2git.svg)](https://crates.io/crates/oci2git)
[![Licença](https://img.shields.io/crates/l/oci2git.svg)](https://github.com/Virviil/oci2git/blob/master/LICENSE)
[![Downloads](https://img.shields.io/crates/d/oci2git.svg)](https://crates.io/crates/oci2git)

[//]: # (mock para o futuro test.yaml)
[//]: # ([![Test Status]&#40;https://img.shields.io/github/actions/workflow/status/Virviil/oci2git/rust.yml?branch=master&event=push&label=Test&#41;]&#40;https://github.com/Virviil/oci2git/actions&#41;)

<div align="left"> </div>  
</div>

Um aplicativo Rust que converte imagens de contêiner (Docker, etc.) em repositórios Git, e gera uma lista de materiais do sistema de arquivos (fsbom) em YAML. Cada camada do contêiner é representada como um commit Git, preservando o histórico e a estrutura da imagem original.

![Demo do OCI2Git convertendo a imagem do nginx](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/nginx.gif)

## Funcionalidades

- Analisa imagens Docker e extrai informações das camadas
- Cria um repositório Git onde cada camada da imagem é representada como um commit
- Gera uma lista de materiais do sistema de arquivos (fsbom) em YAML com arquivos por camada
- Suporte para camadas vazias (ENV, WORKDIR, etc.) como commits vazios
- Extração completa de metadados para o formato Markdown
- Arquitetura extensível para suportar diferentes engines de contêiner

## Casos de Uso

### Diferença de Camadas
Ao solucionar problemas de contêiner, você pode usar os recursos avançados de comparação do Git para identificar exatamente o que mudou entre quaisquer duas camadas. Ao executar `git diff` entre commits, engenheiros podem ver precisamente quais arquivos foram adicionados, modificados ou excluídos, facilitando a compreensão do impacto de cada instrução Dockerfile e a localização de mudanças problemáticas.
![Exemplo de diferença de camada](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/layer-diff.png)

### Rastreamento de Origem
Utilizando `git blame`, desenvolvedores podem rapidamente determinar qual camada introduziu um arquivo ou linha de código específica. Isso é especialmente valioso ao diagnosticar problemas com arquivos de configuração ou dependências. Em vez de inspecionar manualmente cada camada, você pode imediatamente rastrear a origem de qualquer arquivo até sua camada de origem e a instrução correspondente do Dockerfile.

### Rastreamento do Ciclo de Vida de Arquivos
OCI2Git permite que você acompanhe a trajetória de um arquivo específico ao longo do histórico da imagem do contêiner. É possível observar quando um arquivo foi criado, como foi modificado nas camadas e se/quando foi eventualmente removido. Essa visão abrangente ajuda a entender a evolução dos arquivos sem precisar rastrear manualmente as mudanças em dezenas de camadas.

Para rastrear o histórico de um arquivo na sua imagem de contêiner — incluindo quando ele apareceu, foi alterado ou excluído — você pode usar estes comandos Git após a conversão:

```bash
# Full history of a file (including renames)
git log --follow -- /rootfs/my/file/path

# First appearance (i.e. creation) - see which layer introduced the file
git log --diff-filter=A -- /rootfs/my/file/path

# All changes made to the file (with diffs)
git log -p --follow -- /rootfs/my/file/path

# When the file was deleted
git log --diff-filter=D -- /rootfs/my/file/path

# Show short commit info (concise layer history)
git log --follow --oneline -- /rootfs/my/file/path
```

Esses comandos tornam simples rastrear o histórico completo de qualquer arquivo através das camadas de contêiner, sem a complexidade de extrair e comparar manualmente os arquivos tar das camadas.

### Análise Multi-Camadas
Às vezes, as comparações mais reveladoras vêm da análise de mudanças em múltiplas camadas não consecutivas. Com o OCI2Git, você pode usar as ferramentas de comparação do Git para analisar como os componentes evoluíram ao longo de vários estágios de build, identificando padrões que podem ser invisíveis ao observar apenas camadas adjacentes.

### Exploração de Camadas
Ao utilizar `git checkout` para mover para qualquer commit específico, você pode examinar o sistema de arquivos do contêiner exatamente como ele existia naquela camada. Isso permite que desenvolvedores inspecionem o estado preciso dos arquivos e diretórios em qualquer ponto do processo de criação da imagem, fornecendo um contexto valioso para depuração ou análise do comportamento do contêiner.
![Checkout para commit anterior](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/checkout.png)

### Análise Multi-Imagens

Ao trabalhar com múltiplas imagens de contêiner que compartilham uma ancestralidade comum, o OCI2Git cria inteligentemente branches apenas quando as imagens realmente divergem. Isso permite que você analise múltiplas imagens relacionadas em um único repositório, preservando seu histórico comum.

```bash
# Convert first image to create the base repository
oci2git postgres:16.9-alpine3.21 -o alp

# Convert second image to the same output folder
oci2git nginx:1.28.0-alpine-slim -o alp
```
O OCI2Git detecta automaticamente camadas compartilhadas entre imagens e cria uma estrutura de ramificação que reflete sua base comum. O histórico do Git mostrará:
- Um tronco comum contendo todas as camadas compartilhadas
- Ramificações separadas que divergem apenas quando as imagens realmente diferem
- Visualização clara de onde as imagens compartilham ancestralidade comum versus onde se tornam únicas
- Manipulação inteligente de duplicatas: se exatamente a mesma imagem for processada duas vezes, o algoritmo detecta isso antes do commit final de metadados e evita criar uma ramificação duplicada

Esta abordagem é particularmente valiosa para:
- **Análise de Família de Imagens**: Entender como diferentes variantes de uma imagem (diferentes versões, arquiteturas ou configurações) se relacionam entre si
- **Impacto da Imagem Base**: Ver exatamente como alterações em uma imagem base afetam múltiplas imagens derivadas
- **Oportunidades de Otimização**: Identificar componentes compartilhados que poderiam ser melhor aproveitados entre variantes de imagens

![Estrutura de repositório multi-imagem mostrando base compartilhada e ramificações divergentes](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/multiimage.png)

### Casos de Uso Adicionais

- **Auditoria de Segurança**: Identificar exatamente quando pacotes ou configurações vulneráveis foram introduzidos e rastreá-los até instruções de build específicas.
- **Otimização de Imagem**: Analisar estruturas de camadas para encontrar operações redundantes ou arquivos grandes que poderiam ser consolidados, ajudando a reduzir o tamanho da imagem.
- **Gerenciamento de Dependências**: Monitorar quando dependências foram adicionadas, atualizadas ou removidas ao longo do histórico da imagem.
- **Aprimoramento do Processo de Build**: Examinar a composição das camadas para otimizar instruções do Dockerfile visando melhor cache e menor tamanho de imagem.
- **Comparação Entre Imagens**: Converter múltiplas imagens relacionadas em repositórios Git e usar as ferramentas de comparação do Git para analisar suas diferenças e semelhanças.

## Instalação

### Gerenciadores de Pacotes

#### macOS / Linux (Homebrew)


```bash
brew tap virviil/oci2git
brew install oci2git
```

#### Debian / Ubuntu

Baixe e instale o pacote .deb da [versão mais recente](https://github.com/virviil/oci2git/releases/latest):

```bash
# For amd64 (x86_64)
wget https://github.com/virviil/oci2git/releases/latest/download/oci2git_VERSION_amd64.deb
sudo dpkg -i oci2git_VERSION_amd64.deb

# For arm64
wget https://github.com/virviil/oci2git/releases/latest/download/oci2git_VERSION_arm64.deb
sudo dpkg -i oci2git_VERSION_arm64.deb
```

#### Arch Linux (AUR)

```bash
# Using yay
yay -S oci2git-bin

# Using paru
paru -S oci2git-bin

# Manual installation
git clone https://aur.archlinux.org/oci2git-bin.git
cd oci2git-bin
makepkg -si
```

### Binários Pré-compilados

Baixe o binário apropriado para sua plataforma na [última versão](https://github.com/virviil/oci2git/releases/latest):

```bash
# Linux x86_64
wget https://github.com/virviil/oci2git/releases/latest/download/oci2git-linux-x86_64.tar.gz
tar xzf oci2git-linux-x86_64.tar.gz
sudo mv oci2git-linux-x86_64 /usr/local/bin/oci2git
chmod +x /usr/local/bin/oci2git

# macOS (Apple Silicon)
wget https://github.com/virviil/oci2git/releases/latest/download/oci2git-darwin-aarch64.tar.gz
tar xzf oci2git-darwin-aarch64.tar.gz
sudo mv oci2git-darwin-aarch64 /usr/local/bin/oci2git
chmod +x /usr/local/bin/oci2git
```

### Do Crates.io

```bash
cargo install oci2git
```

### Da Fonte

```bash
# Clone the repository
git clone https://github.com/virviil/oci2git.git
cd oci2git

# Install locally
cargo install --path .
```

## Uso

```
oci2git [OPTIONS] <IMAGE>
oci2git convert [OPTIONS] <IMAGE>
oci2git fsbom [OPTIONS] <IMAGE>
```

### `convert` — Imagem OCI → Repositório Git

```bash
oci2git convert [OPTIONS] <IMAGE>
# or simply:
oci2git <IMAGE>
```

Opções:
  `-o, --output <OUTPUT>`  Diretório de saída para o repositório Git [padrão: ./container_repo]
  `-e, --engine <ENGINE>`  Motor de container a ser usado (docker, nerdctl, tar) [padrão: docker]
  `-v, --verbose`          Modo verboso (-v para info, -vv para debug, -vvv para trace)

### `fsbom` — Lista de materiais do sistema de arquivos

```bash
oci2git fsbom [OPTIONS] <IMAGE>
```
Opções:
  `-o, --output <OUTPUT>`  Caminho de saída para o arquivo YAML BOM [padrão: ./fsbom.yml]
  `-e, --engine <ENGINE>`  Motor de contêiner a ser usado (docker, nerdctl, tar) [padrão: docker]
  `-v, --verbose`          Modo detalhado (-v para info, -vv para debug, -vvv para trace)

Variáveis de Ambiente:
  `TMPDIR`  Defina esta variável de ambiente para alterar o local padrão usado para processamento intermediário de dados. Isso depende da plataforma (por exemplo, `TMPDIR` em Unix/macOS, `TEMP` ou `TMP` no Windows).

## Exemplos

### Converter

Usando o motor Docker (padrão):

```bash
oci2git ubuntu:latest
# or explicitly:
oci2git convert ubuntu:latest -o ./ubuntu-repo
```
Usando um tarball de imagem já baixado:

```bash
oci2git convert -e tar -o ./ubuntu-repo /path/to/ubuntu-latest.tar
```
O mecanismo tar espera um arquivo tarball válido no formato OCI, que normalmente é criado com `docker save`:

```bash
# Create a tarball from a local Docker image
docker save -o ubuntu-latest.tar ubuntu:latest

# Convert the tarball to a Git repository
oci2git convert -e tar -o ./ubuntu-repo ubuntu-latest.tar
```

Isso criará um repositório Git em `./ubuntu-repo` contendo:
- `Image.md` - Metadados completos sobre a imagem em formato Markdown
- `rootfs/` - O conteúdo do sistema de arquivos do container

O histórico do Git reflete o histórico de camadas do container:
- O primeiro commit contém apenas o arquivo `Image.md` com metadados completos
- Cada commit subsequente representa uma camada da imagem original
- Os commits incluem o comando do Dockerfile como mensagem do commit

### Lista de Materiais do Sistema de Arquivos (fsbom)

Gere um YAML listando cada arquivo introduzido ou modificado por camada:
```bash
oci2git fsbom ubuntu:latest -o ubuntu.yml
```
Usando um tarball:

```bash
oci2git fsbom -e tar image.tar -o image-bom.yml
```

O YAML de saída lista cada camada com suas entradas marcadas por tipo (`arquivo`, `hardlink`, `symlink`, `diretório`) e status (`n:uid:gid` para novo, `m:uid:gid` para modificado). Arquivos deletados (whiteouts OCI) são excluídos.

```yaml
layers:
  - index: 0
    command: "ADD rootfs.tar.gz / # buildkit"
    digest: "sha256:45f3ea58..."
    entries:
      - type: file
        path: "bin/busybox"
        size: 919304
        mode: 493
        stat: "n:0:0"
      - type: hardlink
        path: "bin/sh"
        target: "bin/busybox"
        stat: "n:0:0"
      - type: symlink
        path: "lib64"
        target: "lib"
        stat: "n:0:0"
  - index: 1
    command: "RUN apk add --no-cache curl"
    digest: "sha256:..."
    entries:
      - type: file
        path: "usr/bin/curl"
        size: 204800
        mode: 493
        stat: "n:0:0"
      - type: file
        path: "etc/apk/world"
        size: 32
        mode: 420
        stat: "m:0:0"
```

## Estrutura do Repositório

```
repository/
├── .git/
├── Image.md     # Complete image metadata
└── rootfs/      # Filesystem content from the container
```
## Requisitos

- Rust edição 2021
- Docker CLI (para suporte ao mecanismo Docker)
- Git

## Licença

MIT

[documentação]: https://docs.rs/oci2git/




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-02

---