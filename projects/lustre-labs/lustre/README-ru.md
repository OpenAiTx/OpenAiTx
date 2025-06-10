<h1 align="center">Lustre</h1>

<div align="center">
  ✨ <strong>Сделайте ваш фронтенд ярче</strong> ✨
</div>

<div align="center">
  Фреймворк для создания веб-приложений на Gleam!
</div>

<br />

<div align="center">
  <a href="https://hex.pm/packages/lustre">
    <img src="https://img.shields.io/hexpm/v/lustre"
      alt="Доступно на Hex" />
  </a>
  <a href="https://hexdocs.pm/lustre">
    <img src="https://img.shields.io/badge/hex-docs-ffaff3"
      alt="Документация" />
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
      Быстрый старт
    </a>
    <span> | </span>
    <a href="https://hexdocs.pm/lustre">
      Справочник
    </a>
    <span> | </span>
    <a href="https://discord.gg/Fm8Pwmy">
      Discord
    </a>
  </h3>
</div>

<div align="center">
  <sub>Создано с ❤︎
  <a href="https://twitter.com/hayleighdotdev">Hayleigh Thompson</a> и
  <a href="https://github.com/lustre-labs/lustre/graphs/contributors">
    участниками проекта
  </a>
</div>

---

## Оглавление

- [Возможности](#features)
- [Пример](#example)
- [Философия](#philosophy)
- [Установка](#installation)
- [Что дальше](#where-next)
- [Поддержка](#support)

## Возможности {#features}

- **Декларативный**, функциональный API для построения HTML. Без шаблонов, без макросов, только Gleam.

- Архитектура, вдохновленная Erlang и Elm, для **управления состоянием**.

- **Управляемые побочные эффекты** для предсказуемого и тестируемого кода.

- Универсальные компоненты. **Пиши один раз, запускай везде**. Elm встречает Phoenix LiveView.

- **CLI с батарейками**, который делает шаблонизацию и сборку приложений простыми и быстрыми.

- **Рендеринг на стороне сервера** для статических HTML-шаблонов.

## Пример {#example}

Lustre поставляется с [более чем 20 примерами](https://hexdocs.pm/lustre/reference/examples.html)!
Вот как это выглядит:

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

## Философия {#philosophy}

Lustre — _мнениевый_ фреймворк для создания небольших и средних веб-приложений.
Современная фронтенд-разработка сложна и запутанна. Часть этой сложности необходима, но многое — случайно или появляется из-за слишком большого количества вариантов. У Lustre та же философия, что и у Gleam: по возможности должен быть только один способ сделать что-либо.

Это означает, что из коробки поставляется только одна система управления состоянием, основанная на Elm и Erlang/OTP. Откройте любое приложение Lustre, и вы сразу почувствуете себя как дома.

Это также означает, что мы поощряем простые подходы к построению представлений вместо сложных. В Lustre _есть_ способ создавать инкапсулированные компоненты с состоянием (чего нам так не хватало в Elm), но это не должно быть по умолчанию. Предпочитайте простые функции компонентам с состоянием.

Там, где компоненты _действительно_ нужны, используйте тот факт, что компоненты Lustre можно запускать _везде_. Lustre предоставляет инструменты для написания компонентов, которые можно запускать внутри существующего приложения Lustre, экспортировать как отдельный Web Component или запускать на сервере с минимальным рантаймом для патчинга DOM. Lustre называет их **универсальными компонентами**, и они пишутся с учетом многотаргетности Gleam.

## Установка {#installation}

Lustre опубликован на [Hex](https://hex.pm/packages/lustre)! Вы можете добавить его в свои проекты Gleam из командной строки:

```sh
gleam add lustre
```

У Lustre также есть сопутствующий пакет с инструментами для разработки, который вы можете установить:

> **Примечание**: сервер разработки lustre_dev_tools следит за изменениями в вашем коде на gleam и может автоматически перезагружать браузер. Для пользователей Linux требуется установить [inotify-tools]()

```sh
gleam add --dev lustre_dev_tools
```

## Что дальше {#where-next}

Чтобы быстро освоиться с Lustre, ознакомьтесь с [руководством по быстрому старту](https://hexdocs.pm/lustre/guide/01-quickstart.html).
Если вы предпочитаете посмотреть на код, каталог [examples](https://github.com/lustre-labs/lustre/tree/main/examples)
содержит несколько небольших приложений, демонстрирующих различные аспекты фреймворка.

Вы также можете ознакомиться с документацией и справочником API на
[HexDocs](https://hexdocs.pm/lustre).

## Поддержка {#support}

Lustre в основном разрабатывается мной, [Hayleigh](https://github.com/hayleigh-dot-dev), в перерывах между двумя работами. Если вы хотите поддержать мою работу, вы можете [спонсировать меня на GitHub](https://github.com/sponsors/hayleigh-dot-dev).

Вклад приветствуется! Если вы нашли баг или хотите предложить новую функцию, пожалуйста, откройте issue или pull request.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---