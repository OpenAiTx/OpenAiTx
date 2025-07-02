<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=it">Itapano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>
</div>

![](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/logo-no-background.png)
# Scheme-langserver
[![Ask DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/ufo5260987423/scheme-langserver)

Você pode ler meu [artigo](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/paper.pdf) e citar assim
> WANG, Z. (2025, 12 de maio). Scheme-langserver: Treat Scheme Code Editing as the First-Class Concern. The 18th European Lisp Symposium (ELS`25), Zurique. https://doi.org/10.5281/zenodo.15384882

Devido ao fato de o GitHub poder bloquear endereços IP chineses, tive que copiar este repositório para [aqui](https://codeberg.org/ufo5260987423/scheme-langserver) e [aqui](https://gitee.com/ufo5260987423/scheme-langserver). Continuarei atualizando todos os repositórios, mas não posso garantir. Agora também colaboro com [XmacsLabs](https://github.com/XmacsLabs), você também pode encontrar um fork [aqui](https://github.com/XmacsLabs/scheme-langserver).

<video src="https://github.com/user-attachments/assets/893bba98-6709-4fac-a4d3-dc7b6aab46fb" controls="controls" width="500" height="300"></video>

**Agora, o VSCode pode usar o scheme-langserver!** Por favor, consulte [AQUI](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md).

>NOTA: Existem muitos e muitos bugs no scheme-langserver. Estou corrigindo e pedindo ajuda à comunidade. Por favor, seja paciente.

>NOTA: você pode encontrar as informações de tipo geradas automaticamente [aqui](https://ufo5260987423.github.io/scheme-langserver/doc/analysis/type-inference-result). Atualmente, é usado principalmente para desenvolvimento de próxima etapa (talvez incluindo AKKU) e depuração.

Implementar suporte como autocompletar, ir para definição ou documentação ao passar o mouse é um esforço significativo para programação. No entanto, em comparação com outras linguagens como java, python, javascript e c, implementações do protocolo de servidor de linguagem para linguagens lisp são feitas praticamente no vácuo. [Geiser](https://gitlab.com/emacs-geiser), [racket langserver](https://github.com/jeapostrophe/racket-langserver) e [swish-lint](https://github.com/becls/swish-lint), etc., seus trabalhos são todos baseados em `repl` (Read-Eval-Print Loop) ou tokenizador de palavras-chave em vez de programação. Por exemplo, se um programador estiver codificando em um projeto inacabado, no qual os códigos não estejam totalmente executáveis, [Geiser](https://gitlab.com/emacs-geiser) ou outros apenas completariam identificadores de binding de nível superior listados pelo procedimento `environment-symbols` (para [Chez](https://cisco.github.io/ChezScheme/)), ou completariam símbolos em vez de identificadores. Isso significa que, para bindings locais e códigos inacabados, embora o esforço na programação devesse ser o mais importante, [Geiser](https://gitlab.com/emacs-geiser) e seus equivalentes não ajudam em nada no reconhecimento do escopo válido do identificador. Casos semelhantes ocorrem com ir para definição e muitas outras funcionalidades.

Uma causa principal é que, para scheme e outros dialetos lisp, seus abundantes conjuntos de dados e estruturas de controle flexíveis tornam a análise de programas um grande desafio. Especialmente o macro, parece que scheme é usado principalmente para programação de gênios e meta/macro. Mas eu digo que não. Scheme pode fazer muitas coisas interessantes se um ambiente de programação melhor for provido. E agora você pode [**COMEÇAR AQUI**](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md).

Este pacote é uma implementação do protocolo de servidor de linguagem para auxiliar a programação em scheme. Ele oferece completamento, definição e inferência de tipo. Essas funcionalidades são estabelecidas em análise estática de código com o [padrão r6rs](http://www.r6rs.org/) e algumas regras óbvias para códigos inacabados. Este pacote em si e bibliotecas relacionadas são publicados ou serão publicados com o [Akku](https://akkuscm.org/), que é um gerenciador de pacotes para Scheme.

Este pacote também foi testado com [Chez Scheme](https://cisco.github.io/ChezScheme/) versões 9.4 e 9.5. Um teste detalhado na versão 10.0.0 será feito após a atualização do sistema operacional do meu notebook para uma versão mais recente.

Faço este trabalho de código aberto apenas no meu tempo livre e posso contribuir com muitas ideias brilhantes para a comunidade, como incorporar análise de fluxo de dados no scheme-langserver ou muitas outras coisas. E estou continuamente pedindo mais doações ou financiamento. Você pode doar através [desta página no patreon](https://www.patreon.com/PoorProgrammer/membership) ou [爱发电](https://afdian.com/a/ufo5260987423).


## Compilação, Instalação & Configuração estão [AQUI](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md)

## Status Recente
Continuarei corrigindo bugs, analisando o código e coletando informações para meu grande livro sobre sistema de inferência de tipos caseiro. Isso vai me levar cerca de 1 ano. Desenvolvimentos futuros incluem um plugin para [VScode](https://code.visualstudio.com/) e análise de fluxo de dados. Mas, na verdade, agora estou tratando este trabalho de código aberto como um emprego de meio período, e não posso garantir um cronograma.

## Lançamento
1.2.9 Agora, aproveite a inferência de tipo!

Para lançamentos anteriores, consulte [este arquivo](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/release-log.md).

### Funcionalidades
1. Completamento de binding de identificadores de nível superior e local.
![Top-level and local identifiers binding](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/auto-completion.png "Top-level and local identifiers binding")
2. Ir para definição.
![Goto definition with telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/definition.png "Goto Definition with telescope.nvim")
3. Compatível com gerenciador de pacotes: Akku.
4. Sincronização de alterações de arquivos e alteração de índice correspondente.
5. Hover.
6. Referências e destaque de documento (referências no escopo do documento).
![Find references with telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/find-references.png "Find references with telescope.nvim")
7. Símbolo de documento.
![Find document symbols with telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/document-symbol.png "find document symbols with telescope.nvim")
8. Captura de *-syntax (define-syntax, let-syntax, etc.) para binding local de identificadores.
9. Indexação paralela multiplataforma.
10. Anotador de código-fonte próprio para ser compatível com arquivos .sps.
11. Otimização peephole para requisições de API com tarefa suspendível.
12. Inferência de tipo com um interpretador DSL caseiro (estou muito orgulhoso disso!). E agora foi incorporada ao autocompletar. Como a figura a seguir indica, "length-b" e "length-a" com tipo "integer?" estão na frente das opções recomendadas porque podem corresponder ao tipo de parâmetro requerido por "<=".
![Autocompletion with type inference](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/auto-completion-with-type-inference.png "Autocompletion with type inference")
Um teste pode provar este resultado, basta executar `scheme --script tests/protocol/apis/test-completion.sps` e o arquivo de log `scheme-langserver.log` conterá resultados como este:
```bash
send-message
2023 11 21 11 26 41 967266866
{"jsonrpc":"2.0","id":"3","result":[{"label":"length-a"},{"label":"length-b"},{"label":"lambda"},{"label":"latin-1-codec"},{"label":"lcm"},{"label":"least-fixnum"},{"label":"length"},{"label":"let"},{"label":"let*"},{"label":"let*-values"},{"label":"let-syntax"},{"label":"let-values"},{"label":"letrec"},{"label":"letrec*"},{"label":"letrec-syntax"},{"label":"lexical-violation?"},{"label":"list"},{"label":"list->string"},{"label":"list->vector"},{"label":"list-ref"},{"label":"list-sort"},{"label":"list-tail"},{"label":"list?"},{"label":"log"},{"label":"lookahead-char"},{"label":"lookahead-u8"}]}
```
13. Interpretador abstrato para captura de identificadores entre diferentes extensões de arquivo como scm, ss, sps, sls e sld.

### A FAZER
14. Renomeação.
15. Totalmente compatível com o [padrão r6rs](http://www.r6rs.org/).
16. Expansor de macro passo a passo: bem, eu realmente implementei um e queria torná-lo uma etapa chave para capturar binding de identificador em macros definidas pelo usuário. Agora, vejo que essa captura é muito mais difícil do que pensei, e o expansor não sei onde poderia funcionar.
17. Avaliação de código.
18. Diagnóstico de código.
19. Adicionar suporte semântico entre linguagens. Bem, seria possível suportar Java, C, Python e muitas outras linguagens com um transformador de AST?
20. Extrair expressões/comandos em um procedimento.

## TODO:Contribuindo

## Depuração

### Como Depurar
https://www.scheme.com/debug/debug.html#g1

### Log de Saída
Seguindo as dicas de [Compilação](#building), [Instalação para Lunar Vim](#installation-for-lunarvim) e [Instalação para VScode](#todo-installation-for-vscode), se alguém quiser desenvolver e registrar logs, será conveniente adicionar `path-to-log-file` e reescrever o arquivo `~/.local/share/lunarvim/site/pack/packer/start/nvim-lspconfig/lua/lspconfig/server_configurations/scheme_langserver.lua` como segue:
```lua
local util = require 'lspconfig.util'
local bin_name = '{path-to-run}'
local cmd = { bin_name ,"path-to-log-file"}

return {
  default_config = {
    cmd = cmd,
    filetypes = { 'scheme' },
    root_dir = util.find_git_ancestor,
    single_file_support = true,
  },
  docs = {
    description = [[
https://github.com/ufo5260987423/scheme-langserver
`scheme-langserver`, uma implementação do protocolo de servidor de linguagem para scheme
]]   ,
  },
}
```
### Execução Recorrente com Log
Com o [log de saída](#output-log) acima, você pode usar `tests/log-debug.sps` para reproduzir bugs:
1. Renomeie `{path-to-log}` (geralmente `~/scheme-langserver.log`) para `~/ready-for-analyse.log`;
2. execute `scheme --script tests/log-debug.sps`. Se quiser reproduzir o ambiente multi-thread, também é possível executar `scheme --script tests/log-debug.sps`.

## Teste
Quase todos os procedimentos e APIs principais são testados. Meu trabalho é meio grosseiro, mas útil; talvez você queira ver o que fiz no diretório `tests` ou apenas rodar o comando a seguir no `{scheme-langserver-root-directory}`
``` bash
bash test.sh
```
>NOTA
É difícil testar em ambiente com threads. Portanto, os testes atuais focam em thread única.

## Usando o Scheme-langserver para Outros Propósitos
### Script-Fu no GIMP
Script-Fu é baseado em uma linguagem interpretada chamada Scheme e funciona usando funções que interagem com as funções internas do GIMP. Tomando como exemplo o script desta [página](https://dalelane.co.uk/blog/?p=628), você pode aplicar o scheme-langserver em arquivos de script com extensão "SCM".

### Outros

Bem, também me interesso por [OMN (Opusmodus Notation)](https://opusmodus.com/) e AutoLisp. Mas ainda tenho muitas coisas para fazer.

## Contagem de Código
```bash
find . -name "*.sls" ! -path "./.akku/*" |xargs wc -l
```
## Documentação Detalhada
1. [Scheme-langserver: Tratando a Edição de Código Scheme como uma Preocupação de Primeira Classe](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/paper.pdf).
2. [Capturando ligações de identificadores](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/identifier.md)
3. [Sincronizando](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/util/synchronize.md)
4. [Inferência de tipo](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/type-inference.md),~~[类型推断](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/type-inference.cn.md)~~(Obsoleto, e estou escrevendo um livro em chinês sobre isso)
5. [Análise de API](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/protocol/analysis.md)
6. [Deepwiki](https://deepwiki.com/ufo5260987423/scheme-langserver)

## Histórico de Estrelas

[![Star History Chart](https://api.star-history.com/svg?repos=ufo5260987423/scheme-langserver&type=Date)](https://star-history.com/#ufo5260987423/scheme-langserver)

## Contribuidores

![Contribuidores](https://contrib.rocks/image?repo=ufo5260987423/scheme-langserver)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---