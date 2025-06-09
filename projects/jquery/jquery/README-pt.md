# [jQuery](https://jquery.com/) — Novo JavaScript da Nova Geração

As reuniões atualmente são realizadas na [plataforma matrix.org](https://matrix.to/#/#jquery_meeting:gitter.im).

As atas das reuniões podem ser encontradas em [meetings.jquery.org](https://meetings.jquery.org/category/core/).

A versão mais recente do jQuery está disponível em [https://jquery.com/download/](https://jquery.com/download/).

## Suporte de Versão

| Versão  | Branch     | Status   |
| ------- | ---------- | -------- |
| 4.x     | main       | Beta     |
| 3.x     | 3.x-stable | Ativo    |
| 2.x     | 2.x-stable | Inativo  |
| 1.x     | 1.x-stable | Inativo  |

Assim que a versão final 4.0.0 for lançada, o branch 3.x continuará recebendo atualizações por tempo limitado. Os branches 2.x e 1.x não são mais suportados.

O suporte comercial para versões inativas está disponível através da [HeroDevs](https://herodevs.com/nes).

Saiba mais sobre nosso [suporte de versões](https://jquery.com/support/).

## Guias de Contribuição

No espírito do desenvolvimento de software open source, o jQuery sempre incentiva a contribuição de código pela comunidade. Para ajudar você a começar e antes de começar a escrever código, certifique-se de ler atentamente estas diretrizes importantes de contribuição:

1. [Envolva-se](https://contribute.jquery.org/)
2. [Guia de Estilo Core](https://contribute.jquery.org/style-guide/js/)
3. [Escrevendo Código para Projetos jQuery](https://contribute.jquery.org/code/)

### Referências a issues/PRs

Issues/PRs no GitHub geralmente são referenciados via `gh-NÚMERO`, onde `NÚMERO` é o ID numérico do issue/PR. Você pode encontrar esse issue/PR em `https://github.com/jquery/jquery/issues/NÚMERO`.

O jQuery já utilizou um rastreador de bugs diferente – baseado em Trac – no passado, disponível em [bugs.jquery.com](https://bugs.jquery.com/). Ele está mantido em modo somente leitura para que seja possível consultar discussões passadas. Quando o código fonte do jQuery faz referência a um desses issues, ele utiliza o padrão `trac-NÚMERO`, onde `NÚMERO` é o ID numérico do issue. Você pode encontrar esse issue em `https://bugs.jquery.com/ticket/NÚMERO`.

## Ambientes em que usar o jQuery

- [Suporte a navegadores](https://jquery.com/browser-support/)
- O jQuery também oferece suporte a Node, extensões de navegador e outros ambientes fora do navegador.

## O que você precisa para compilar seu próprio jQuery

Para compilar o jQuery, você precisa da versão mais recente do Node.js/npm e do git 1.7 ou posterior. Versões anteriores podem funcionar, mas não são suportadas.

Para Windows, você deve baixar e instalar [git](https://git-scm.com/downloads) e [Node.js](https://nodejs.org/en/download/).

Usuários de macOS devem instalar o [Homebrew](https://brew.sh/). Uma vez que o Homebrew esteja instalado, execute `brew install git` para instalar o git,
e `brew install node` para instalar o Node.js.

Usuários de Linux/BSD devem usar os gerenciadores de pacotes apropriados para instalar git e Node.js, ou compilar a partir do código fonte
se preferirem. Muito fácil.

## Como compilar seu próprio jQuery

Primeiro, [clone o repositório git do jQuery](https://help.github.com/en/github/creating-cloning-and-archiving-repositories/cloning-a-repository).

Depois, entre no diretório do jquery, instale as dependências e execute o script de build:

```bash
cd jquery
npm install
npm run build
```

A versão compilada do jQuery será colocada no diretório `dist/`, junto com uma cópia minificada e o arquivo de mapa associado.

## Compilar todos os arquivos de lançamento do jQuery

Para compilar todas as variantes do jQuery, execute o seguinte comando:

```bash
npm run build:all
```

Isso criará todas as variantes que o jQuery inclui em um lançamento, incluindo `jquery.js`, `jquery.slim.js`, `jquery.module.js` e `jquery.slim.module.js` junto com seus respectivos arquivos minificados e sourcemaps.

`jquery.module.js` e `jquery.slim.module.js` são [módulos ECMAScript](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Guide/Modules) que exportam `jQuery` e `$` como exports nomeados e são colocados no diretório `dist-module/` em vez do diretório `dist/`.

## Compilando um jQuery Personalizado

O script de build pode ser usado para criar uma versão personalizada do jQuery que inclua apenas os módulos de que você precisa.

Qualquer módulo pode ser excluído, exceto o `core`. Ao excluir `selector`, ele não é removido, mas substituído por um pequeno wrapper em torno do nativo `querySelectorAll` (veja abaixo para mais informações).

### Ajuda do Script de Build

Para ver a lista completa de opções disponíveis para o script de build, execute o seguinte:

```bash
npm run build -- --help
```

### Módulos

Para excluir um módulo, passe seu caminho relativo à pasta `src` (sem a extensão `.js`) para a opção `--exclude`. Ao usar a opção `--include`, as inclusões padrão são removidas e um build é criado somente com os módulos especificados.

Alguns exemplos de módulos que podem ser excluídos ou incluídos são:

- **ajax**: Toda a funcionalidade AJAX: `$.ajax()`, `$.get()`, `$.post()`, `$.ajaxSetup()`, `.load()`, transports e atalhos de eventos ajax como `.ajaxStart()`.
- **ajax/xhr**: Apenas o transporte AJAX XMLHTTPRequest.
- **ajax/script**: Apenas o transporte AJAX `<script>`; usado para recuperar scripts.
- **ajax/jsonp**: Apenas o transporte AJAX JSONP; depende do transporte ajax/script.
- **css**: O método `.css()`. Também remove **todos** os módulos que dependem de css (incluindo **effects**, **dimensions** e **offset**).
- **css/showHide**: `.show()`, `.hide()` e `.toggle()` não animados; pode ser excluído se você usar classes ou chamadas explícitas de `.css()` para definir a propriedade `display`. Também remove o módulo **effects**.
- **deprecated**: Métodos documentados como obsoletos, mas ainda não removidos.
- **dimensions**: Os métodos `.width()` e `.height()`, incluindo as variações `inner-` e `outer-`.
- **effects**: O método `.animate()` e seus atalhos como `.slideUp()` ou `.hide("slow")`.
- **event**: Os métodos `.on()` e `.off()` e toda a funcionalidade de eventos.
- **event/trigger**: Os métodos `.trigger()` e `.triggerHandler()`.
- **offset**: Os métodos `.offset()`, `.position()`, `.offsetParent()`, `.scrollLeft()` e `.scrollTop()`.
- **wrap**: Os métodos `.wrap()`, `.wrapAll()`, `.wrapInner()` e `.unwrap()`.
- **core/ready**: Exclua o módulo ready se você colocar seus scripts no final do body. Quaisquer callbacks de ready vinculados com `jQuery()` serão simplesmente chamados imediatamente. No entanto, `jQuery(document).ready()` não será uma função e `.on("ready", ...)` ou similares não serão disparados.
- **deferred**: Exclua jQuery.Deferred. Isso também exclui todos os módulos que dependem de Deferred, incluindo **ajax**, **effects** e **queue**, mas substitui **core/ready** por **core/ready-no-deferred**.
- **exports/global**: Exclui o anexo das variáveis globais do jQuery ($ e jQuery) ao window.
- **exports/amd**: Exclui a definição AMD.

- **selector**: O mecanismo de seleção completo do jQuery. Quando este módulo é excluído, ele é substituído por um mecanismo de seleção rudimentar baseado no método `querySelectorAll` do navegador, que não oferece suporte a extensões de seletores do jQuery ou semânticas aprimoradas. Veja o arquivo [selector-native.js](https://github.com/jquery/jquery/blob/main/src/selector-native.js) para detalhes.

*Nota*: Excluir o módulo `selector` completo também excluirá todas as extensões de seletores do jQuery (como `effects/animatedSelector` e `css/hiddenVisibleSelectors`).

##### Nome AMD

Você pode definir o nome do módulo para a definição AMD do jQuery. Por padrão, é definido como "jquery", o que funciona bem com plugins e bibliotecas de terceiros, mas pode haver casos em que você queira alterar isso. Passe-o para o parâmetro `--amd`:

```bash
npm run build -- --amd="nome-personalizado"
```

Ou, para definir de forma anônima, deixe o nome em branco.

```bash
npm run build -- --amd
```

##### Nome e diretório do arquivo

O nome padrão para o arquivo jQuery compilado é `jquery.js`; ele é colocado no diretório `dist/`. É possível alterar o nome do arquivo usando `--filename` e o diretório usando `--dir`. `--dir` é relativo ao diretório raiz do projeto.

```bash
npm run build -- --slim --filename="jquery.slim.js" --dir="/tmp"
```

Isso criaria uma versão slim do jQuery e a colocaria em `tmp/jquery.slim.js`.

##### Modo ECMAScript Module (ESM)

Por padrão, o jQuery gera um arquivo JavaScript de script regular. Você também pode gerar um módulo ECMAScript exportando `jQuery` como exportação padrão usando o parâmetro `--esm`:

```bash
npm run build -- --filename=jquery.module.js --esm
```

##### Modo Factory

Por padrão, o jQuery depende de um `window` global. Para ambientes que não possuem um, você pode gerar um build factory que expõe uma função que aceita `window` como parâmetro que você pode fornecer externamente (veja o [`README` do pacote publicado](build/fixtures/README.md) para instruções de uso). Você pode gerar esse factory usando o parâmetro `--factory`:

```bash
npm run build -- --filename=jquery.factory.js --factory
```

Esta opção pode ser combinada com outras como `--esm` ou `--slim`:

```bash
npm run build -- --filename=jquery.factory.slim.module.js --factory --esm --slim --dir="/dist-module"
```

#### Exemplos de Build Personalizado

Crie um build personalizado usando `npm run build`, listando os módulos a serem excluídos. Excluir um módulo de nível superior também exclui seu diretório correspondente de módulos.

Exclua toda a funcionalidade **ajax**:

```bash
npm run build -- --exclude=ajax
```

Excluir **css** remove os módulos dependentes de CSS: **effects**, **offset**, **dimensions**.

```bash
npm run build -- --exclude=css
```

Exclua vários módulos (`-e` é um alias para `--exclude`):

```bash
npm run build -- -e ajax/jsonp -e css -e deprecated -e dimensions -e effects -e offset -e wrap
```

Existe um alias especial para gerar um build com a mesma configuração do build oficial jQuery Slim:

```bash
npm run build -- --filename=jquery.slim.js --slim
```

Ou, para criar o build slim como um módulo esm:

```bash
npm run build -- --filename=jquery.slim.module.js --slim --esm
```
```

*Builds personalizados não oficiais não são testados regularmente. Use por sua própria conta e risco.*

## Executando os Testes Unitários

Certifique-se de ter as dependências necessárias:

```bash
npm install
```

Inicie `npm start` para compilar o jQuery automaticamente enquanto trabalha:

```bash
npm start
```

Execute os testes unitários com um servidor local que suporte PHP. Certifique-se de executar o site a partir do diretório raiz, e não do diretório "test". Não é necessário banco de dados. Servidores locais PHP pré-configurados estão disponíveis para Windows e Mac. Aqui estão algumas opções:

- Windows: [Download do WAMP](https://www.wampserver.com/en/)
- Mac: [Download do MAMP](https://www.mamp.info/en/downloads/)
- Linux: [Configurando o LAMP](https://www.linux.com/training-tutorials/easy-lamp-server-installation/)
- [Mongoose (várias plataformas)](https://code.google.com/p/mongoose/)

## Git Essencial

Como o código-fonte é gerenciado pelo sistema de controle de versão Git, é útil conhecer alguns recursos utilizados.

### Limpeza

Se você deseja restaurar seu diretório de trabalho para o status do upstream, os seguintes comandos podem ser usados (lembre-se de que tudo o que você trabalhou será perdido após estes comandos):

```bash
git reset --hard upstream/main
git clean -fdx
```

### Rebase

Para branches de funcionalidades/tópicos, você deve sempre usar o parâmetro `--rebase` ao executar `git pull`, ou se você costuma lidar com vários branches temporários "para serem enviados em um pull request no github", execute o seguinte para automatizar isso:

```bash
git config branch.autosetuprebase local
```

(consulte `man git-config` para mais informações)

### Lidando com conflitos de merge

Se você encontrar conflitos de merge ao mesclar, ao invés de editar manualmente os arquivos em conflito, pode usar o recurso
`git mergetool`. Embora a ferramenta padrão `xxdiff` pareça feia/antiga, ela é bastante útil.

A seguir estão alguns comandos que podem ser usados nela:

- `Ctrl + Alt + M` - mesclar automaticamente o máximo possível
- `b` - pular para o próximo conflito de merge
- `s` - alterar a ordem das linhas em conflito
- `u` - desfazer uma mesclagem
- `botão esquerdo do mouse` - marcar um bloco como vencedor
- `botão do meio do mouse` - marcar uma linha como vencedora
- `Ctrl + S` - salvar
- `Ctrl + Q` - sair

## Referência do [QUnit](https://api.qunitjs.com)

### Métodos de teste

```js
expect( numAssertions );
stop();
start();
```

*Nota*: A adição eventual de um argumento ao stop/start do QUnit é ignorada nesta suíte de testes para que start e stop possam ser passados como callbacks sem preocupação com seus parâmetros.

### Asserções de teste

```js
ok( value, [message] );
equal( actual, expected, [message] );
notEqual( actual, expected, [message] );
deepEqual( actual, expected, [message] );
notDeepEqual( actual, expected, [message] );
strictEqual( actual, expected, [message] );
notStrictEqual( actual, expected, [message] );
throws( block, [expected], [message] );
```

## Referência dos Métodos Convenientes da Suíte de Testes

Veja [test/data/testinit.js](https://github.com/jquery/jquery/blob/main/test/data/testinit.js).

### Retorna um array de elementos com os IDs fornecidos

```js
q( ... );
```

Exemplo:

```js
q( "main", "foo", "bar" );

=> [ div#main, span#foo, input#bar ]
```

### Asserta que uma seleção corresponde aos IDs fornecidos

```js
t( testName, selector, [ "array", "of", "ids" ] );
```

Exemplo:

```js
t("Verificar algo", "//[a]", ["foo", "bar"]);
```

### Dispara um evento DOM nativo sem passar pelo jQuery

```js
fireNative( node, eventType );
```

Exemplo:

```js
fireNative( jQuery( "#elem" )[ 0 ], "click" );
```

### Adiciona número aleatório à url para evitar cache

```js
url( "some/url" );
```

Exemplo:

```js
url( "index.html" );

=> "data/index.html?10538358428943"


url( "mock.php?foo=bar" );

=> "data/mock.php?foo=bar&10538358345554"
```

### Executa testes em um iframe

Alguns testes podem exigir um documento diferente do fixture padrão de teste, e
estes podem ser executados em um iframe separado. O código real do teste e as asserções
permanecem nos arquivos principais de teste do jQuery; apenas o markup mínimo do fixture de teste
e o código de configuração devem ser colocados no arquivo do iframe.

```js
testIframe( testName, fileName,
  function testCallback(
      assert, jQuery, window, document,
	  [ additional args ] ) {
	...
  } );
```

Isso carrega uma página, construindo uma url com fileName `"./data/" + fileName`.
A página no iframe determina quando o callback ocorre no teste ao
incluir o script "/test/data/iframeTest.js" e chamar
`startIframeTest( [ additional args ] )` quando apropriado. Muitas vezes isso
ocorre após o ready do documento ou o disparo do `window.onload`.

O `testCallback` recebe o objeto QUnit `assert` criado por `testIframe`
para este teste, seguido pelo global `jQuery`, `window` e `document` do
iframe. Se o código do iframe passar quaisquer argumentos para `startIframeTest`,
eles seguem o argumento `document`.

## Dúvidas?

Se você tiver alguma dúvida, sinta-se à vontade para perguntar no
[Fórum Developing jQuery Core](https://forum.jquery.com/developing-jquery-core) ou no #jquery em [libera](https://web.libera.chat/).
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---