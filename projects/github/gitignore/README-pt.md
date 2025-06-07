# Uma coleção de modelos `.gitignore`

Esta é a coleção de modelos de arquivos [`.gitignore`][man] do GitHub.
Usamos esta lista para preencher os seletores de modelos `.gitignore` disponíveis
na interface do GitHub.com ao criar novos repositórios e arquivos.

Para mais informações sobre como funcionam os arquivos `.gitignore` e como usá-los,
os seguintes recursos são um ótimo ponto de partida:

- O [capítulo Ignorando Arquivos][chapter] do livro [Pro Git][progit].
- O [artigo Ignorando Arquivos][help] no site de Ajuda do GitHub.
- A página do manual [gitignore(5)][man].

[man]: https://git-scm.com/docs/gitignore
[help]: https://help.github.com/articles/ignoring-files
[chapter]: https://git-scm.com/book/en/v2/Git-Basics-Recording-Changes-to-the-Repository#_ignoring
[progit]: https://git-scm.com/book

## Estrutura de pastas

Nós mantemos uma coleção de modelos, organizados da seguinte forma:

- A pasta raiz contém modelos de uso comum, para ajudar as pessoas a começarem
  com linguagens de programação e tecnologias populares. Estes definem um conjunto
  significativo de regras para ajudar a iniciar, garantindo que você não estará
  incluindo arquivos desnecessários no seu repositório.
- [`Global`](./Global) contém modelos para vários editores, ferramentas e
  sistemas operacionais que podem ser usados em diferentes situações. Recomenda-se
  que você [adicione estes ao seu modelo global](https://docs.github.com/en/get-started/getting-started-with-git/ignoring-files#configuring-ignored-files-for-all-repositories-on-your-computer)
  ou mescle essas regras nos modelos específicos do seu projeto se quiser usá-las
  permanentemente.
- [`community`](./community) contém modelos especializados para outras linguagens,
  ferramentas e projetos populares, que atualmente não pertencem aos modelos
  principais. Estes devem ser adicionados aos modelos específicos do seu projeto
  quando você decidir adotar o framework ou ferramenta.

## O que faz um bom modelo?

Um modelo deve conter um conjunto de regras para ajudar repositórios Git a funcionarem com uma
linguagem de programação, framework, ferramenta ou ambiente específico.

Se não for possível criar um pequeno conjunto de regras úteis para essa situação,
então o modelo não é adequado para esta coleção.

Se um modelo consiste principalmente em uma lista de arquivos instalados por uma versão
específica de algum software (por exemplo, um framework PHP), ele pode ficar na pasta
`community`. Veja [modelos versionados](#versioned-templates) para mais detalhes.

Se você possui um pequeno conjunto de regras, ou deseja dar suporte a uma tecnologia que não é
amplamente utilizada, e ainda acredita que isso será útil para outros, leia a
seção sobre [modelos especializados](#specialized-templates) para mais detalhes.

Inclua detalhes ao abrir um pull request se o modelo for importante e visível. Nós
podemos não aceitá-lo imediatamente, mas podemos promovê-lo para a raiz futuramente
com base no interesse.

Por favor, também entenda que não podemos listar todas as ferramentas que já existiram.
Nosso objetivo é organizar uma coleção dos modelos _mais comuns e úteis_,
não garantir que cobriremos todos os projetos possíveis. Se decidirmos não
incluir sua linguagem, ferramenta ou projeto, não é porque ela não é excelente.

## Diretrizes para contribuição

Adoraríamos que você nos ajudasse a melhorar este projeto. Para ajudar a manter esta coleção
com alta qualidade, pedimos que as contribuições sigam as seguintes diretrizes.

- **Forneça um link para a página inicial do aplicativo ou projeto**. A menos que seja
  extremamente popular, pode ser que os mantenedores não conheçam ou usem a
  linguagem, framework, editor, aplicativo ou projeto ao qual sua alteração se aplica.

- **Forneça links para a documentação** que apoie a alteração que você está fazendo.
  Documentação atual e canônica mencionando os arquivos ignorados é o ideal.
  Se a documentação não estiver disponível para apoiar sua alteração, explique da melhor forma
  possível para que servem os arquivos ignorados.

- **Explique por que você está fazendo uma alteração**. Mesmo que pareça óbvio, por favor
  escreva uma ou duas frases explicando por que sua alteração ou adição deve ser feita.
  É especialmente útil explicar por que essa alteração se aplica a _todos_
  que trabalham com a tecnologia aplicável, e não apenas a você ou seu time.

- **Considere o escopo de sua alteração**. Se sua alteração é específica de uma
  determinada linguagem ou framework, certifique-se de que a alteração seja feita no
  modelo dessa linguagem ou framework, e não no modelo de um editor, ferramenta ou sistema operacional.

- **Por favor, modifique apenas _um modelo_ por pull request**. Isso ajuda a manter os
  pull requests e o feedback focados em um projeto ou tecnologia específica.

Em geral, quanto mais você puder nos ajudar a entender a alteração que está fazendo,
mais rapidamente poderemos aceitar sua contribuição.

## Modelos versionados

Alguns modelos podem mudar bastante entre versões, e se você quiser contribuir
para este repositório precisamos seguir este fluxo específico:

- o modelo na raiz deve ser a versão atualmente suportada
- o modelo na raiz não deve ter a versão no nome do arquivo (ou seja,
  "permanente")
- versões anteriores dos modelos devem ficar na pasta `community/`
- versões anteriores do modelo devem ter a versão no nome do arquivo,
  para facilitar a leitura

Isso garante que os usuários obtenham a versão mais recente (pois usarão o que está
na raiz), mas permite que os mantenedores deem suporte a versões antigas ainda em uso.

## Modelos especializados

Se você possui um modelo que gostaria de contribuir, mas ele não é exatamente
mainstream, considere adicioná-lo ao diretório `community` em uma
pasta que melhor se encaixe.

As regras do seu modelo especializado devem ser específicas para o framework ou
ferramenta, e quaisquer modelos adicionais devem ser mencionados em um comentário
no cabeçalho do modelo.

Por exemplo, este modelo pode estar em `community/DotNet/InforCRM.gitignore`:

```
# modelo gitignore para InforCRM (anteriormente SalesLogix)
# site: https://www.infor.com/product-summary/cx/infor-crm/
#
# Recomendado: VisualStudio.gitignore

# Ignorar arquivos de modelo que são gerados automaticamente
ModelIndex.xml
ExportedFiles.xml

# Ignorar arquivos de implantação
[Mm]odel/[Dd]eployment

# Forçar inclusão dos arquivos SupportFiles do portal
!Model/Portal/*/SupportFiles/[Bb]in/
!Model/Portal/PortalTemplates/*/SupportFiles/[Bb]in
```

## Fluxo de contribuição

Veja como sugerimos que você proponha uma alteração neste projeto:

1. [Faça um fork deste projeto][fork] para sua conta.
2. [Crie um branch][branch] para a alteração que pretende fazer.
3. Faça suas alterações no seu fork.
4. [Envie um pull request][pr] do branch do seu fork para o nosso branch `main`.

Usar a interface web para fazer alterações também é válido, e irá ajudá-lo
fazendo o fork automaticamente e sugerindo o envio do pull request.

[fork]: https://help.github.com/articles/fork-a-repo/
[branch]: https://help.github.com/articles/creating-and-deleting-branches-within-your-repository
[pr]: https://help.github.com/articles/using-pull-requests/

## Licença

[CC0-1.0](./LICENSE).

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---