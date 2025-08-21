
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Rosetta Stonks

- [Introdução](#introducao)
- [Instalar](#instalar)
  - [Chrome](#navegadores-baseados-no-chrome)
    - [Guia Visual](#navegadores-baseados-no-chrome)
  - [Firefox](#navegadores-baseados-no-firefox)
- [Como usar](#como-usar)
  - [Adicionando tempo](#adding-time)
    - [Fundamentos](#adding-time-in-foundations)
    - [Construtor de fluência](#adding-time-in-fluency-builder)
  - [Validando lição](#validating-lesson)
    - [Fundamentos](#validating-lesson-in-foundations)
    - [Construtor de fluência](#validating-lesson-in-fluency-builder)

## Introdução

RosettaStonks é uma extensão de navegador que permite adicionar tempo e validar
lições na plataforma de aprendizagem de idiomas rosetta stone.

> RosettaStonks, e sua rosetta stone fica stonks.

## Instalação

### Navegadores baseados em Chrome

➡️ **Novo na instalação manual de extensões no Chrome?** Veja o [Guia Visual Passo a Passo](https://raw.githubusercontent.com/m1dugh/RosettaStonks/master/INSTALL_GUI.md) — inclui capturas de tela úteis! 🖼️

#### 1. Usando o GitHub Release

Para usar a extensão em um navegador baseado em Chrome, você precisa:

- baixar o arquivo `rosettastonks-chrome.tar.gz` da versão mais recente para
  sua máquina.
- criar uma pasta chamada `rosettastonks` em algum lugar do seu computador para armazenar a
  extensão
- execute o seguinte comando na pasta `rosettastonks`.

```bash
$ tar xvzf /path/to/rosettastonks-chrome.tar.gz
```

2. Usando o gerenciador de pacotes nix

Em vez dos comandos anteriores, se você estiver em um sistema nix **que suporta
flakes**, pode executar os comandos abaixo, que irão instalar uma pasta
no caminho `/tmp/rosettastonks` com todos os arquivos.

```bash
$ nix build --out-link "/tmp/rosettastonks" github:m1dugh/RosettaStonks#chrome
```

A pasta agora está instalada em `/tmp/rosettastonks/`

**Esta parte é para todos os usuários, independentemente de estarem usando o método github
ou o método nix.**

No seu navegador:

- vá para `chrome://extensions`
- marque a opção `Modo de desenvolvedor`
- clique em `Carregar sem compactação`
- Selecione sua pasta `rosettastonks`

### Navegadores baseados no Firefox

- baixe o arquivo `rosettastonks.xpi` da última versão.
- alternativamente, se estiver usando o gerenciador de pacotes nix com suporte a flake, você pode executar
  o seguinte comando.

```bash
$ nix build --out-link "/tmp/rosettatonks.xpi" github:m1dugh/RosettaStonks#mozilla
```
- vá para `about:addons` no seu navegador
- clique no botão de configurações e vá para `Depurar addons`.
- clique em `Carregar Add-On Temporário`
- selecione o arquivo `/tmp/rosettastonks.xpi` no seletor de arquivos.

_Atenção: Este método instala a extensão temporariamente, ou seja, se
você fechar o navegador, o addon será desinstalado. Isso ocorre devido às
políticas do Firefox que não permitem o uso de extensões não verificadas._

## Como usar

### Adicionando tempo

#### Adicionando tempo no Foundations

Para adicionar tempo no produto `foundations`, você precisa acessar seus exercícios e
clicar em ignorar ou resolver pelo menos uma questão. Feito isso, um campo de tempo
deve aparecer na página da extensão, onde você poderá adicionar seu tempo.

#### Adicionando tempo no Fluency builder

Para adicionar tempo no produto `fluency builder`, você precisa acessar seus exercícios e
responder pelo menos um exercício. Se o campo para adicionar tempo não aparecer, isso
significa que nenhuma solicitação de tempo foi capturada; você precisa atualizar a questão e respondê-la
novamente. Para que o tempo seja adicionado, é necessário finalizar a lição que você utilizou para
adicionar o tempo.

_Nota: Se você não vê o campo para adicionar tempo, significa que as ações realizadas
no site da Rosetta Stone não levaram ao registro de tempo legítimo, portanto,
você precisa responder outras questões._

### Validando lição

#### Validando lição no Foundations

Para validar uma lição, é necessário iniciar uma lição e passar por todas as
questões usando o botão `ignorar` no canto inferior direito. Assim que todas as
questões forem vistas, clicar no botão `validar lição` deve validar
a lição. Caso contrário, volte para a sua página inicial, clique na mesma lição, ela

deve perguntar `Você deseja continuar ou reiniciar?`, você pode escolher ambos, e
validar a lição novamente até que funcione. Deve funcionar após no máximo 3/4 tentativas.

#### Validando a lição no Fluency builder

No momento, o recurso de validação de lição não está disponível no rosetta stonks.

## Compilando o aplicativo

### Compilando o worker

O worker pode ser empacotado usando o seguinte comando

```
$ deno task build:worker
```

Que cria o arquivo empacotado `/dist/worker.esm.js`, que é o arquivo empacotado
para o worker.

### Construindo o frontend

O worker pode ser empacotado usando o seguinte comando

```
$ deno task build:frontend
```

Que cria o arquivo empacotado `/dist/frontend.esm.js`, que é o arquivo empacotado
para o frontend.

## Empacotando a extensão

### Chrome

Para empacotar a extensão para o Chrome, o seguinte comando pode ser executado:

```
$ make chrome
```

### Firefox

Para empacotar a extensão para o Firefox, o seguinte comando pode ser executado:

```
$ make firefox
```

O que irá produzir `rosettastonks.xpi`, o arquivo da extensão que pode ser
carregado no firefox.

📸 Prefere visuais? Confira o [Guia de Instalação do Chrome com Imagens](https://raw.githubusercontent.com/m1dugh/RosettaStonks/master/INSTALL_GUI.md)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-21

---