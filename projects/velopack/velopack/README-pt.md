<picture>
  <source media="(prefers-color-scheme: dark)" srcset="https://raw.githubusercontent.com/velopack/velopack/develop/artwork/velopack-white.svg">
  <img alt="Logo Velopack" src="https://raw.githubusercontent.com/velopack/velopack/develop/artwork/velopack-black.svg" width="400">
</picture>

---

[![Nuget](https://img.shields.io/nuget/v/Velopack?style=flat-square&logo=nuget&logoColor=white)](https://www.nuget.org/packages/Velopack/)
[![Discord](https://img.shields.io/badge/chat-Discord-5865F2?style=flat-square&logo=discord&logoColor=white)](https://discord.gg/M6he8ZPAAJ)
[![Build](https://img.shields.io/github/actions/workflow/status/velopack/velopack/build.yml?branch=develop&style=flat-square&logo=github&logoColor=white)](https://github.com/velopack/velopack/actions)
[![Codecov](https://img.shields.io/codecov/c/github/velopack/velopack?style=flat-square&logo=codecov&logoColor=white)](https://app.codecov.io/gh/velopack/velopack)
[![License](https://img.shields.io/github/license/velopack/velopack?style=flat-square)](https://github.com/velopack/velopack/blob/develop/LICENSE)

Velopack é um framework de instalação e atualização automática para aplicações multiplataforma. É opinativo, extremamente fácil de usar e não requer nenhuma configuração. Com apenas um comando você pode colocar uma aplicação instalável para rodar, e também é super rápido para seus usuários.

## Funcionalidades

- 😍 **Zero configuração** – O Velopack utiliza o output do seu compilador e gera um instalador, atualizações, pacotes delta e um pacote portátil autoinstalável com apenas um comando.
- 🎯 **Multiplataforma** – O Velopack suporta a criação de pacotes para **Windows**, **OSX** e **Linux**, permitindo usar uma única solução para todos os destinos.
- 🚀 **Migrações automáticas** – Se você está migrando de outros frameworks populares (ex: [Squirrel](https://github.com/Squirrel/Squirrel.Windows)), o Velopack pode migrar sua aplicação automaticamente.
- ⚡️ **Extremamente rápido** – O Velopack é escrito em Rust para desempenho nativo. Pacotes delta garantem que o usuário baixe apenas o que mudou entre as versões.
- 📔 **Independente de linguagem** – Suporta C#, C++, JS, Rust e outros. Use uma API familiar para atualizações, não importa a linguagem do seu projeto.

https://github.com/velopack/velopack/assets/1287295/0ff1bea7-15ed-42ae-8bdd-9519f1033432

## Documentação
- 📖 [Leia a documentação](https://docs.velopack.io/)
- ⚡ [Guias de início rápido](https://docs.velopack.io/category/quick-start)
- 🕶️ [Veja exemplos de aplicativos](https://docs.velopack.io/category/sample-apps)
- 📺 [Veja o site & demonstração](https://velopack.io/)

## Comunidade
- ❓ Tire dúvidas, obtenha suporte ou discuta ideias no [Discord](https://discord.gg/CjrCrNzd3F)
- 🗣️ Relate bugs ou solicite funcionalidades no [GitHub Issues](https://github.com/velopack/velopack/issues)

## Contribuição
- 💬 Junte-se a nós no [Discord](https://discord.gg/CjrCrNzd3F) para participar das discussões de desenvolvimento
- 🚦 Leia nosso [guia de contribuição](https://docs.velopack.io/category/contributing)

## Depoimentos 
Já coloquei minha aplicação externa usando o Velopack. Estou muito impressionado. Parece funcionar incrivelmente bem e é muito mais rápido tanto na compilação inicial quanto na atualização do software na máquina do usuário final do que o Squirrel era. É incrível e o melhor instalador que já usei em mais de 30 anos de desenvolvimento. Muito obrigado! Vocês estão fazendo um trabalho excelente!
[- Stefan (Discord)](https://discord.com/channels/767856501477343282/767856501477343286/1195642674078830613)

Só queria agradecer imensamente. Tenho usado o Clowd.Squirrel há alguns anos, desde que o Squirrel.Windows deixou de funcionar para mim. Entrei naquele repositório hoje para procurar alguma documentação e notei o lançamento do Velopack. Que surpresa! Funciona de forma fantástica e é muito mais rápido, uau! Obrigado novamente, a quantidade de trabalho investida tanto no Clowd.Squirrel quanto no Velopack é impressionante. É muito apreciado.
[- Kizari (Discord)](https://discord.com/channels/767856501477343282/767856501477343286/1200837489640878180)

Já utilizei muitos frameworks de instalador e o Velopack é de longe o melhor. Tudo parece mágica: você executa o instalador e o aplicativo já está aberto, pronto para usar. As atualizações são aplicadas e relançadas em cerca de 2 segundos, sem prompts de UAC. O processo de criação do instalador é simples e integra facilmente a assinatura de código, e a ferramenta de linha de comando facilita o upload dos arquivos de atualização. Você não precisa lidar com scripts de instalador em alguma linguagem estranha; pode embutir todos esses hooks no seu aplicativo principal! O suporte também é fenomenal; todas as dúvidas que tive foram respondidas. Este é o futuro dos instaladores desktop.
[- RandomEngy (Discord)](https://discord.com/channels/767856501477343282/947444323765583913/1200897478036299861)

Estou extremamente impressionado com o desempenho do Velopack na criação de releases, bem como na verificação e aplicação de atualizações. É significativamente mais rápido do que outras ferramentas. O CLI vpk é intuitivo e fácil de implementar, mesmo com meu pipeline de build complexo. Graças ao Velopack, consegui otimizar meu fluxo de trabalho e economizar tempo valioso. É uma ferramenta fantástica que recomendo muito!
[- khdc (Discord)](https://discord.com/channels/767856501477343282/947444323765583913/1216460920696344576)

---

Powered By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---