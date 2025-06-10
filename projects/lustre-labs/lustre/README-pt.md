<h1 align="center">Lustre</h1>

<div align="center">
  ✨ <strong>Faça seu frontend brilhar</strong> ✨
</div>

<div align="center">
  Um framework para construir aplicativos Web em Gleam!
</div>

<br />

<div align="center">
  <a href="https://hex.pm/packages/lustre">
    <img src="https://img.shields.io/hexpm/v/lustre"
      alt="Disponível no Hex" />
  </a>
  <a href="https://hexdocs.pm/lustre">
    <img src="https://img.shields.io/badge/hex-docs-ffaff3"
      alt="Documentação" />
  </a>
</div>

<div align="center">
  <h3>
    <!--
    <a href="https://lustre.build">
      Website
    </a>
    <span> | </span>
    -->
    <a href="https://hexdocs.pm/lustre/guide/01-quickstart.html">
      Guia Rápido
    </a>
    <span> | </span>
    <a href="https://hexdocs.pm/lustre">
      Referência
    </a>
    <span> | </span>
    <a href="https://discord.gg/Fm8Pwmy">
      Discord
    </a>
  </h3>
</div>

<div align="center">
  <sub>Criado com ❤︎ por
  <a href="https://twitter.com/hayleighdotdev">Hayleigh Thompson</a> e
  <a href="https://github.com/lustre-labs/lustre/graphs/contributors">
    contribuintes
  </a>
</div>

---

## Índice

- [Recursos](#features)
- [Exemplo](#example)
- [Filosofia](#philosophy)
- [Instalação](#installation)
- [Próximos passos](#where-next)
- [Suporte](#support)

## Recursos {#features}

- Uma API **declarativa** e funcional para construir HTML. Sem templates, sem macros,
  apenas Gleam.

- Uma arquitetura inspirada em Erlang e Elm para **gerenciamento de estado**.

- **Efeitos colaterais gerenciados** para um código previsível e testável.

- Componentes universais. **Escreva uma vez, execute em qualquer lugar**. Elm encontra Phoenix LiveView.

- Um **CLI completo** que torna a criação de projetos e a construção de apps muito fácil.

- **Renderização do lado do servidor** para criação de templates HTML estáticos.

## Exemplo {#example}

O Lustre vem com [mais de 20 exemplos](https://hexdocs.pm/lustre/reference/examples.html)!
Veja como é:

```gleam
import gleam/int
import lustre
import lustre/element.{text}
import lustre/element/html.{div, button, p}
import lustre/event.{on_click}

pub fn main() {
  let app = lustre.simple(init, update, view)
  let assert Ok(_) = lustre.start(app, "#app", Nil)

  Nil
}

fn init(_flags) {
  0
}

type Msg {
  Incr
  Decr
}

fn update(model, msg) {
  case msg {
    Incr -> model + 1
    Decr -> model - 1
  }
}

fn view(model) {
  let count = int.to_string(model)

  div([], [
    button([on_click(Incr)], [text(" + ")]),
    p([], [text(count)]),
    button([on_click(Decr)], [text(" - ")])
  ])
}
```

## Filosofia {#philosophy}

Lustre é um framework _opinionado_ para construir aplicações Web de pequeno a médio porte.
O desenvolvimento de frontend moderno é difícil e complexo. Parte dessa complexidade é necessária, mas muito disso é acidental ou vem do excesso de opções disponíveis. O Lustre compartilha a filosofia de design do Gleam: sempre que possível, deve haver apenas uma maneira de fazer as coisas.

Isso significa fornecer um único sistema de gerenciamento de estado pronto para uso, modelado a partir do Elm e do Erlang/OTP. Abra qualquer aplicação Lustre e você deve se sentir em casa.

Isso também significa que encorajamos abordagens simples para a construção de views ao invés de soluções complexas. Lustre _tem_ uma forma de criar componentes encapsulados com estado próprio (algo que sentimos muita falta no Elm), mas isso não deve ser o padrão. Prefira funções simples a componentes com estado.

Onde componentes _forem_ necessários, aproveite o fato de que componentes Lustre podem rodar _em qualquer lugar_. Lustre fornece as ferramentas para você escrever componentes que podem rodar dentro de uma aplicação Lustre existente, exportá-los como um Web Component independente, ou executá-los no servidor com um runtime mínimo para atualizar o DOM. Lustre chama esses de **componentes universais** e eles são escritos pensando nos múltiplos alvos do Gleam.

## Instalação {#installation}

Lustre está publicado no [Hex](https://hex.pm/packages/lustre)! Você pode adicioná-lo aos seus projetos Gleam pela linha de comando:

```sh
gleam add lustre
```

Lustre também possui um pacote complementar com ferramentas de desenvolvimento que você pode querer instalar:

> **Nota**: o servidor de desenvolvimento lustre_dev_tools monitora seu sistema de arquivos para alterações no seu código gleam e pode recarregar o navegador automaticamente. Para usuários Linux, é necessário ter o [inotify-tools]() instalado

```sh
gleam add --dev lustre_dev_tools
```

## Próximos passos {#where-next}

Para aprender rapidamente sobre Lustre, confira o [guia rápido](https://hexdocs.pm/lustre/guide/01-quickstart.html).
Se você prefere ver código, o diretório de [exemplos](https://github.com/lustre-labs/lustre/tree/main/examples)
contém diversos aplicativos pequenos que demonstram diferentes aspectos do framework.

Você também pode ler a documentação e a referência da API em
[HexDocs](https://hexdocs.pm/lustre).

## Suporte {#support}

Lustre é desenvolvido principalmente por mim, [Hayleigh](https://github.com/hayleigh-dot-dev),
conciliando com dois empregos. Se você quiser apoiar meu trabalho, pode [me patrocinar no GitHub](https://github.com/sponsors/hayleigh-dot-dev).

Contribuições também são muito bem-vindas! Se você encontrou um bug ou gostaria de sugerir uma funcionalidade, por favor abra uma issue ou um pull request.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---