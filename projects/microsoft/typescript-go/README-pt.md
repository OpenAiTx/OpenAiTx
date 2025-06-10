# TypeScript 7

[Não tem certeza do que é isso? Leia o post de anúncio!](https://devblogs.microsoft.com/typescript/typescript-native-port/)

## Preview

Uma build de preview está disponível no npm como `@typescript/native-preview`.

```sh
npm install @typescript/native-preview
npx tsgo # Use isso como usaria o tsc.
```

Uma extensão de preview para o VS Code está [disponível no marketplace do VS Code](https://marketplace.visualstudio.com/items?itemName=TypeScriptTeam.native-preview).

Para usar isso, defina o seguinte nas configurações do VS Code:

```json
{
    "typescript.experimental.useTsgo": true
}
```

## Como Construir e Rodar

Este repositório utiliza [Go 1.24 ou superior](https://go.dev/dl/), [Rust 1.85 ou superior](https://www.rust-lang.org/tools/install), [Node.js com npm](https://nodejs.org/) e [`hereby`](https://www.npmjs.com/package/hereby).

Para testes e geração de código, este repositório contém um submódulo git para o repositório principal do TypeScript apontando para o commit que está sendo portado.
Ao clonar, você vai querer clonar com submódulos:

```sh
git clone --recurse-submodules https://github.com/microsoft/typescript-go.git
```

Se você já clonou o repositório, pode inicializar o submódulo com:

```sh
git submodule update --init --recursive
```

Com o submódulo no lugar e `npm ci`, você pode rodar tarefas via `hereby`, similar ao repositório do TypeScript:

```sh
hereby build          # Verifica se o projeto compila
hereby test           # Roda todos os testes
hereby install-tools  # Instala ferramentas adicionais como linters
hereby lint           # Roda todos os linters
hereby format         # Formata todo o código
hereby generate       # Gera todo o código Go (ex: diagnostics, commitado no repo)
```

Tarefas adicionais estão em desenvolvimento.

`hereby` não é obrigatório para trabalhar no repositório; as ferramentas padrão do `go` (ex: `go build`, `go test ./...`) funcionarão normalmente.
As tarefas do `hereby` são oferecidas como conveniência para quem está familiarizado com o repositório do TypeScript.

### Rodando o `tsgo`

Após rodar `hereby build`, você pode executar `built/local/tsgo`, que se comporta de maneira muito semelhante ao `tsc`.

### Rodando o Protótipo do LSP

Para depurar e rodar a extensão do VS Code sem instalá-la globalmente:

* Execute o VS Code no workspace do repositório (`code .`)
* Copie `.vscode/launch.template.json` para `.vscode/launch.json`
* <kbd>F5</kbd> (ou `Debug: Start Debugging` no palette de comando)

Isso irá abrir uma nova instância do VS Code que usa o Corsa LS como backend. Se estiver corretamente configurado, você verá "tsgo" na barra de status ao abrir um arquivo TypeScript ou JavaScript:

![LSP Prototype Screenshot](https://raw.githubusercontent.com/microsoft/typescript-go/main/.github/ls-screenshot.png)


## O Que Funciona Até Agora?

Este projeto ainda está em andamento e ainda não possui paridade total de funcionalidades com o TypeScript. Podem existir bugs. Por favor, verifique esta lista cuidadosamente antes de registrar um novo problema ou assumir que uma mudança foi intencional.

| Funcionalidade | Status | Observações |
|----------------|--------|-------------|
| Criação de programa | done | Mesmos arquivos e resolução de módulos que TS5.8. Nem todos os modos de resolução suportados ainda. |
| Parsing/scanning | done | Mesmos erros de sintaxe do TS5.8 |
| Linha de comando e parsing de `tsconfig.json` | mostly done | Ponto de entrada um pouco diferente por enquanto |
| Resolução de tipos | done | Mesmos tipos que TS5.8 |
| Checagem de tipos | done | Mesmos erros, localizações e mensagens que TS5.8. Impressão de tipos em erros pode ser diferente (em andamento) |
| Inferência específica de JavaScript e JS Doc | not ready | - |
| JSX | done | - |
| Emissão de declarações | in progress | A maioria dos recursos comuns está implementada, mas alguns casos extremos e flags ainda não tratados |
| Emissão (saída JS) | in progress | `target: esnext` bem suportado, outros targets podem ter lacunas |
| Modo watch | prototype | Observa arquivos e recompila, mas sem rechecagem incremental |
| Modo build / referências de projeto | not ready | - |
| Build incremental | not ready | - |
| Serviço de linguagem (LSP) | prototype | Funcionalidade mínima (erros, hover, go to def). Mais recursos em breve |
| API | not ready | - |

Definições:

 * **done** ou "acreditamos concluído": Não estamos cientes de déficits ou grandes tarefas pendentes. Pode registrar bugs
 * **in progress**: em desenvolvimento; alguns recursos podem funcionar e outros não. Pode registrar panics, mas nada além disso, por favor
 * **prototype**: apenas prova de conceito; não registre bugs
 * **not ready**: ainda nem começamos, ou está longe o suficiente de pronto para não valer a pena mexer ainda

## Outras Observações

A longo prazo, esperamos que este repositório e seu conteúdo sejam mesclados no `microsoft/TypeScript`.
Como resultado, o repositório e o rastreador de issues do typescript-go eventualmente serão fechados, então trate discussões/issues de acordo.

Para uma lista de mudanças intencionais em relação ao TypeScript 5.7, veja CHANGES.md.

## Contribuindo

Este projeto aceita contribuições e sugestões. A maioria das contribuições exige que você concorde com um
Contrato de Licença de Contribuidor (CLA) declarando que você tem o direito e realmente concede a nós
os direitos de usar sua contribuição. Para detalhes, visite [Contratos de Licença de Contribuidor](https://cla.opensource.microsoft.com).

Ao enviar um pull request, um bot CLA irá determinar automaticamente se você precisa fornecer
um CLA e marcar o PR apropriadamente (ex: verificação de status, comentário). Siga as instruções
fornecidas pelo bot. Você só precisará fazer isso uma vez para todos os repositórios que usam nosso CLA.

Este projeto adotou o [Código de Conduta de Código Aberto da Microsoft](https://opensource.microsoft.com/codeofconduct/).
Para mais informações, veja o [FAQ do Código de Conduta](https://opensource.microsoft.com/codeofconduct/faq/) ou
entre em contato com [opencode@microsoft.com](mailto:opencode@microsoft.com) para dúvidas ou comentários adicionais.

## Marcas Registradas

Este projeto pode conter marcas registradas ou logotipos de projetos, produtos ou serviços. O uso autorizado de marcas registradas ou logotipos da Microsoft está sujeito e deve seguir as
[Diretrizes de Marca & Marca Registrada da Microsoft](https://www.microsoft.com/legal/intellectualproperty/trademarks/usage/general).
O uso de marcas registradas ou logotipos da Microsoft em versões modificadas deste projeto não deve causar confusão ou sugerir patrocínio da Microsoft.
Qualquer uso de marcas registradas ou logotipos de terceiros está sujeito às políticas desses terceiros.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---