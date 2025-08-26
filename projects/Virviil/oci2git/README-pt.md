
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
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# OCI2Git

Uma aplicação Rust que converte imagens de contêiner (Docker, etc.) em repositórios Git. Cada camada do contêiner é representada como um commit do Git, preservando o histórico e a estrutura da imagem original.

![Demonstração do OCI2Git convertendo a imagem nginx](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/nginx.gif)

## Funcionalidades

- Analise imagens Docker e extraia informações das camadas
- Crie um repositório Git onde cada camada de imagem é representada como um commit
- Suporte para camadas vazias (ENV, WORKDIR, etc.) como commits vazios
- Extração completa de metadados para o formato Markdown
- Arquitetura extensível para suportar diferentes motores de contêiner

## Casos de Uso

### Diferenciação de Camadas
Ao solucionar problemas de contêiner, você pode usar as poderosas capacidades de diferenciação do Git para identificar exatamente o que mudou entre duas camadas. Ao executar `git diff` entre commits, os engenheiros podem ver precisamente quais arquivos foram adicionados, modificados ou excluídos, tornando muito mais fácil entender o impacto de cada instrução do Dockerfile e localizar alterações problemáticas.
![Exemplo de diff de camada](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/layer-diff.png)

### Rastreamento de Origem
Utilizando `git blame`, os desenvolvedores podem rapidamente determinar qual camada introduziu um arquivo ou linha de código específico. Isso é particularmente valioso ao diagnosticar problemas com arquivos de configuração ou dependências. Em vez de inspecionar manualmente cada camada, você pode rastrear imediatamente a origem de qualquer arquivo até sua camada fonte e instrução correspondente no Dockerfile.

### Rastreamento do Ciclo de Vida de Arquivo
O OCI2Git permite que você acompanhe a trajetória de um arquivo específico ao longo da história da imagem do contêiner. É possível observar quando um arquivo foi criado inicialmente, como foi modificado ao longo das camadas e se/quando foi eventualmente removido. Essa visão abrangente ajuda a entender a evolução do arquivo sem precisar rastrear manualmente as mudanças através de dezenas de camadas.

Para rastrear o histórico de um arquivo em sua imagem de contêiner — incluindo quando ele apareceu pela primeira vez, foi alterado ou excluído — você pode usar estes comandos Git após a conversão:

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
- Ramos separados que divergem apenas quando as imagens realmente diferem
- Visualização clara de onde as imagens compartilham ancestralidade comum versus onde se tornam únicas
- Manipulação inteligente de duplicatas: se exatamente a mesma imagem for processada duas vezes, o algoritmo detecta isso antes do commit final dos metadados e evita criar um ramo duplicado

Esta abordagem é especialmente valiosa para:
- **Análise de Família de Imagens**: Entender como diferentes variantes de uma imagem (diferentes versões, arquiteturas ou configurações) se relacionam entre si
- **Impacto da Imagem Base**: Ver exatamente como alterações em uma imagem base afetam várias imagens derivadas
- **Oportunidades de Otimização**: Identificar componentes compartilhados que podem ser melhor aproveitados entre variantes de imagens

![Estrutura de repositório multiimagem mostrando base compartilhada e ramos divergentes](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/multiimage.png)

### Casos de Uso Adicionais

- **Auditoria de Segurança**: Identifique exatamente quando pacotes vulneráveis ou configurações foram introduzidos e rastreie-os até instruções específicas de build.
- **Otimização de Imagem**: Analise estruturas de camadas para encontrar operações redundantes ou arquivos grandes que possam ser consolidados, ajudando a reduzir o tamanho da imagem.
- **Gerenciamento de Dependências**: Monitore quando dependências foram adicionadas, atualizadas ou removidas ao longo do histórico da imagem.
- **Melhoria do Processo de Build**: Examine a composição das camadas para otimizar instruções do Dockerfile visando melhor cache e tamanho menor de imagem.
- **Comparação Entre Imagens**: Converta múltiplas imagens relacionadas em repositórios Git e use as ferramentas de comparação do Git para analisar suas diferenças e similaridades.

## Instalação

### A Partir do Código-Fonte

```bash
# Clone the repository
git clone https://github.com/virviil/oci2git.git
cd oci2git

# Install locally
cargo install --path .
```

### Do Crates.io

```bash
cargo install oci2git
```

## Uso

```bash
oci2git [OPTIONS] <IMAGE>
```

Argumentos:
  `<IMAGEM>`  Nome da imagem para converter (ex.: 'ubuntu:latest') ou caminho para o arquivo tar ao usar o motor tar

Opções:
  `-o, --output <o>`  Diretório de saída para o repositório Git [padrão: ./container_repo]
  `-e, --engine <ENGINE>`  Motor de container a ser usado (docker, nerdctl, tar) [padrão: docker]
  `-h, --help`            Exibe informações de ajuda
  `-V, --version`         Exibe informações de versão

Variáveis de Ambiente:
  `TMPDIR`  Defina esta variável de ambiente para alterar o local padrão usado para processamento de dados intermediários. Isso depende da plataforma (ex.: `TMPDIR` no Unix/macOS, `TEMP` ou `TMP` no Windows).

## Exemplos

Usando o motor Docker (padrão):
```bash
oci2git -o ./ubuntu-repo ubuntu:latest
```
Usando um tarball de imagem já baixado:

```bash
oci2git -e tar -o ./ubuntu-repo /path/to/ubuntu-latest.tar
```
O mecanismo tar espera um arquivo tarball válido no formato OCI, que normalmente é criado com `docker save`:

```bash
# Create a tarball from a local Docker image
docker save -o ubuntu-latest.tar ubuntu:latest

# Convert the tarball to a Git repository
oci2git -e tar -o ./ubuntu-repo ubuntu-latest.tar
```

Isso criará um repositório Git em `./ubuntu-repo` contendo:
- `Image.md` - Metadados completos sobre a imagem em formato Markdown
- `rootfs/` - O conteúdo do sistema de arquivos do contêiner

O histórico do Git reflete o histórico de camadas do contêiner:
- O primeiro commit contém apenas o arquivo `Image.md` com todos os metadados
- Cada commit subsequente representa uma camada da imagem original
- Os commits incluem o comando do Dockerfile como mensagem do commit

## Estrutura do Repositório

```
repository/
├── .git/
├── Image.md     # Complete image metadata
└── rootfs/      # Filesystem content from the container
```


## Requisitos

- Edição Rust 2021
- Docker CLI (para suporte ao mecanismo Docker)
- Git

## Licença

MIT

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-26

---