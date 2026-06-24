<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=gautam84&project=Foodike&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=gautam84&project=Foodike&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=gautam84&project=Foodike&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=gautam84&project=Foodike&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=gautam84&project=Foodike&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=gautam84&project=Foodike&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=gautam84&project=Foodike&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=gautam84&project=Foodike&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=gautam84&project=Foodike&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=gautam84&project=Foodike&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=gautam84&project=Foodike&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=gautam84&project=Foodike&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=gautam84&project=Foodike&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=gautam84&project=Foodike&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=gautam84&project=Foodike&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=gautam84&project=Foodike&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=gautam84&project=Foodike&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=gautam84&project=Foodike&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=gautam84&project=Foodike&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=gautam84&project=Foodike&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=gautam84&project=Foodike&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

![Visualização do Cartão GitHub](https://github.com/gautam84/Foodike/blob/master/art/FoodikeIntrouctionMockUp.jpg?raw=true)

# 🍔 Foodike
Foodike é um aplicativo de entrega de comida simples e fácil de usar. Ele é desenvolvido usando Android-Jetpack Compose e baseado no princípio MVVM com Componentes Modernos de Arquitetura Android.

## Demonstração 
![](https://github.com/gautam84/Foodike/blob/master/art/demo.gif)


## Capturas de Tela 📱 
Onboarding | Login | Início | Detalhes | Histórico | Carrinho | Perfil
--- | --- | --- | --- |--- |--- |--- 
![](https://github.com/gautam84/Foodike/blob/master/screenshots/onboarding.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/login.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/home.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/details.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/history.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/cart.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/profile.jpeg) 


## Construído com 🛠

- [Kotlin](https://kotlinlang.org/) - Linguagem de programação oficial e de primeira classe para o desenvolvimento Android.
- [Jetpack Compose](https://developer.android.com/jetpack/compose) - Jetpack Compose é o toolkit moderno do Android para construir UI nativa.
- [Coroutines](https://kotlinlang.org/docs/reference/coroutines-overview.html) - Uma coroutine é um padrão de design de concorrência que pode ser usado no Android para simplificar código que executa de forma assíncrona.
- [Flow](https://kotlinlang.org/docs/reference/coroutines/flow.html) - Um flow é uma versão assíncrona de uma Sequence, um tipo de coleção cujos valores são produzidos sob demanda.
- [Componentes de Arquitetura Android](https://developer.android.com/topic/libraries/architecture) - Coleção de bibliotecas que ajudam a projetar apps robustos, testáveis e fáceis de manter.
  - [Stateflow](https://developer.android.com/kotlin/flow/stateflow-and-sharedflow) - StateFlow é um flow observável que mantém o estado, emitindo atualizações do estado atual e novos estados para seus coletores.
  - [Flow](https://kotlinlang.org/docs/reference/coroutines/flow.html) - Um flow é uma versão assíncrona de uma Sequence, um tipo de coleção cujos valores são produzidos sob demanda.
  - [ViewModel](https://developer.android.com/topic/libraries/architecture/viewmodel) - Armazena dados relacionados à UI que não são destruídos em mudanças de interface.
  - [Jetpack Compose Navigation](https://developer.android.com/jetpack/compose/navigation) - O componente Navigation fornece suporte para aplicações Jetpack Compose.
  - [DataStore](https://developer.android.com/topic/libraries/architecture/datastore) - Jetpack DataStore é uma solução de armazenamento de dados que permite guardar pares chave-valor ou objetos tipados com protocol buffers. DataStore usa coroutines e Flow do Kotlin para armazenar dados de forma assíncrona, consistente e transacional.
- [Dagger-Hilt](https://developer.android.com/training/dependency-injection/hilt-android) - Hilt é uma biblioteca de injeção de dependência para Android que reduz o código repetitivo da injeção manual de dependências no seu projeto. Fazer injeção manual de dependências exige construir manualmente cada classe e suas dependências, além de usar contêineres para reutilizar e gerenciar dependências.
  
- [Splash API](https://developer.android.com/develop/ui/views/launch/splash-screen) - A partir do Android 12, a SplashScreen API permite que apps sejam lançados com animação, incluindo uma transição ao abrir, uma tela splash mostrando o ícone do app e uma transição para o próprio app. Uma SplashScreen é uma Janela e, portanto, cobre uma Activity.
- [Material Components for Android](https://github.com/material-components/material-components-android)
  - Componentes de UI do Material Design modulares e personalizáveis para Android.
- [Figma](https://figma.com/) - Figma é um editor de gráficos vetoriais e ferramenta de prototipagem baseada principalmente na web.

## Arquitetura 🗼















Este aplicativo utiliza a arquitetura [***MVVM (Model View
View-Model)***](https://developer.android.com/jetpack/docs/guide#recommended-app-arch).

![](https://github.com/gautam84/Foodike/blob/master/art/mvvm.png)

## Ferramenta de Build 🧰
Você precisa ter o [Android Studio Beta 3 ou superior](https://developer.android.com/studio/preview) para compilar este projeto.

## Contato 📩

Quer entrar em contato comigo? Me mande uma mensagem 👇

Envie um e-mail para:- gautamhazarika01@gmail.com

Meu Portfólio:- www.gautamhz.com

## Doação 💰

Se este projeto te ajudar a economizar tempo de desenvolvimento, você pode me oferecer uma xícara de café :)

<a href="https://www.buymeacoffee.com/gautam.hz" target="_blank"><img src="https://www.buymeacoffee.com/assets/img/custom_images/yellow_img.png" alt="Buy Me A Coffee" style="height: 41px !important;width: 174px !important;box-shadow: 0px 3px 2px 0px rgba(190, 190, 190, 0.5) !important;-webkit-box-shadow: 0px 3px 2px 0px rgba(190, 190, 190, 0.5) !important;" ></a>


## Licença 🔖

```

MIT License

Copyright (c) 2026 Gautam Hazarika

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.



```

## Backend:

Estou desenvolvendo o backend totalmente em Kotlin usando ktor [aqui](https://github.com/gautam84/foodike-backend).


## Próximos Passos:

- Integrar o backend ao aplicativo Android.
- Atualizar todo o código para a versão mais recente.
- Escrever testes unitários, testes de integração e testes de UI/End-to-End.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-24

---