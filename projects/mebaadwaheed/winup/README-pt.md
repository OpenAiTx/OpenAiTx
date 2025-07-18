<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

![PRs Bem-vindos](https://img.shields.io/badge/PRs-welcome-brightgreen)
![Python 3.9+](https://img.shields.io/badge/python-3.9%2B-blue)
![Component Driven](https://img.shields.io/badge/architecture-component--driven-orange)
![Aplicativo Desktop](https://img.shields.io/badge/platform-desktop-lightgrey)
![Suporte CLI](https://img.shields.io/badge/CLI-supported-critical)
![Live Reload](https://img.shields.io/badge/live--reload-enabled-blue)

## Exemplos de Imagem

![image](https://github.com/user-attachments/assets/81d016e9-e10a-4438-ab94-99b6d76b8efe)

![image](https://github.com/user-attachments/assets/154dc3f4-ea8c-4f6f-84d3-88c7ab74a46f)

![image](https://github.com/user-attachments/assets/2318f701-6ec8-4402-abcc-40c879bf1a10)

# WinUp 🚀

## Certifique-se de baixar a Última Versão Estável (LSR) e não a última/LFR! LSR atual: 2.4.9

`pip install winup==2.4.9`

**Um framework ridiculamente Pythonic e poderoso para criar belos aplicativos desktop.**

WinUp é um framework de UI moderno para Python que envolve o poder do PySide6 (Qt) em uma API simples, declarativa e amigável para desenvolvedores. Ele foi projetado para permitir que você crie aplicativos mais rápido, escreva códigos mais limpos e aproveite o processo de desenvolvimento.

### ✨ Agora com Suporte Web!
WinUp agora também suporta a criação de aplicações web totalmente interativas e com estado, usando a mesma abordagem centrada em Python e baseada em componentes. O módulo web usa FastAPI e WebSockets nos bastidores para trazer a simplicidade do WinUp ao navegador.

[Documentação Web](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/web/README.md)

> **Aviso:** O suporte web é um recurso opcional. Para usá-lo, você deve instalar as dependências web:
> ```bash
> pip install "winup[web]"
> ```

[Contribuindo](https://raw.githubusercontent.com/mebaadwaheed/winup/main/CONTRIBUTING.md)
[Changelog](https://raw.githubusercontent.com/mebaadwaheed/winup/main/CHANGELOG.md)
[Licença](LICENSE)

---

## Por que WinUp? (Em vez de PySide6 puro ou Tkinter)

O desenvolvimento desktop em Python pode parecer desajeitado. O WinUp foi criado para resolver isso.

| Recurso                 | Jeito WinUp ✨                                                                  | Jeito PySide6 / Tkinter Puro 😟                                                            |
| ----------------------- | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| **Layouts**             | `ui.Column(children=[...])`, `ui.Row(children=[...])`                          | `QVBoxLayout()`, `QHBoxLayout()`, `layout.addWidget()`, `pack()`, `grid()`                 |
| **Estilização**         | `props={"background-color": "blue", "font-size": "16px"}`                      | Strings QSS manuais, `widget.setStyleSheet(...)`, objetos de estilo complexos.             |
| **Gerenciamento de Estado** | `state.bind(widget, "prop", "key")`                                        | Funções de callback manuais, getters/setters, `StringVar()`, boilerplate por toda parte.   |
| **Vinculação Bidirecional** | `state.bind_two_way(input_widget, "key")`                                  | Inexistente. Exige manipuladores `on_change` manuais para atualizar estado e UI.           |
| **Ferramentas do Desenvolvedor** | **Hot Reloading Embutido**, profiler de código e ferramentas de janela prontas para uso. | Inexistente. Reinicie o app inteiro a cada alteração de UI.                                |
| **Estrutura do Código** | Componentes reutilizáveis e autocontidos com `@component`.                     | Geralmente resulta em classes grandes, monolíticas ou scripts procedurais.                 |

**Resumindo, o WinUp oferece os "recursos matadores" dos frameworks web modernos (como React ou Vue) para o desktop, economizando seu tempo e permitindo que você foque no que importa: a lógica do seu aplicativo.**

# 🧊 WinUp vs 🧱 PyEdifice (Pedido de Usuário do Reddit)

| Recurso                          | WinUp      | PyEdifice                        |
|----------------------------------|--------------------------------------|----------------------------------|
| 🧱 Arquitetura                   | Estilo React + estado       | Estilo React + estado            |
| 🌐 Roteamento Embutido           | ✅ Sim (`Router(routes={...})`)      | ❌ Sem roteamento embutido        |
| ♻️ Lifecycle Hooks               | ✅ `on_mount`, `on_unmount`, etc.    | ⚠️ Limitado (`did_mount`, etc.)  |
| 🎨 Sistema de Temas / Estilização| ✅ Temas Globais & Locais            | ❌ Injeção de CSS manual          |
| 🔲 Opções de Layout              | ✅ Row, Column, Grid, Stack, Flexbox | ⚠️ Principalmente Box & HBox/VBox |
| 🎞️ Animações                    | ✅ Embutidas (fade, scale, etc.)     | ❌ Nenhuma embutida               |
| 🔁 Hot Reloading (LHR)           | ✅ Estável + rápido (`loadup dev`)   | ⚠️ Experimental, suporte limitado |
| 📦 Empacotamento                 | ✅ Com LoadUp (baseado em PyInstaller) | ❌ Precisa integrar PyInstaller manualmente |
| 🧩 Reutilização de Componentes   | ✅ Alta, declarativa                 | ✅ Alta                           |

| 🛠 Ferramentas para Desenvolvedores    | ✅ DevTools planejado, Inspector em breve | ❌ Nenhuma ainda                  |
| 📱 Suporte Mobile                     | ❌ Ainda não                             | ❌ Não suportado                  |
| 🧠 Curva de Aprendizado                | ✅ Fácil para usuários de Python+React    | ✅ Fácil mas com menos ferramentas|

> ✅ = Integrado ou robusto  
> ⚠️ = Parcial ou limitado  
> ❌ = Totalmente ausente
---

## Recursos Principais

*   **UI Declarativa & Pythonica:** Construa layouts complexos com objetos simples `Row` e `Column` ao invés de layouts de caixas complicados.
*   **Arquitetura Baseada em Componentes:** Use o decorador `@component` para criar widgets de UI modulares e reutilizáveis a partir de funções simples.
*   **Sistema de Estilização Poderoso:** Estilize seus widgets com dicionários Python simples usando `props`. Crie classes globais "tipo CSS" com `style.add_style_dict`.
*   **Shell de Aplicação Completo:** Construa aplicativos profissionais com uma API declarativa para `MenuBar`, `ToolBar`, `StatusBar` e `SystemTrayIcon`.
*   **Executor de Tarefas Assíncronas:** Execute operações longas em segundo plano sem travar sua UI usando o decorador simples `@tasks.run`.
*   **Performance por Padrão:** Inclui o decorador opcional `@memo` para armazenar em cache renderizações de componentes e evitar recomputações desnecessárias.
*   **Extensibilidade Avançada:**
    *   **Fábrica de Widgets:** Substitua qualquer widget padrão por sua própria implementação personalizada (por exemplo, baseada em C++) usando `ui.register_widget()`.
    *   **Múltiplas Janelas:** Crie e gerencie várias janelas independentes para aplicativos complexos como paletas de ferramentas ou players de música.
*   **Gerenciamento de Estado Reativo:**
    *   **Vinculação Unidirecional:** Atualize automaticamente sua UI quando seus dados mudarem com `state.bind()`.
    *   **Vinculação Bidirecional:** Sincronize facilmente widgets de entrada com seu estado usando `state.bind_two_way()`.
    *   **Assinaturas:** Acione qualquer função em resposta a mudanças de estado com `state.subscribe()`.
*   **Ferramentas Amigáveis para Desenvolvedores:**
    *   **Hot Reloading:** Veja suas alterações de UI instantaneamente sem reiniciar o app.
    *   **Profiler:** Meça facilmente a performance de qualquer função com o decorador `@profiler.measure()`.
    *   **Ferramentas de Janela:** Centralize, pisque ou gerencie a janela do seu aplicativo com facilidade.
*   **Roteamento Integrado:** Crie facilmente aplicações com múltiplas páginas usando um roteador intuitivo e orientado a estado.
*   **Camada de Dados Flexível:** Inclui conectores simples e consistentes para SQLite, PostgreSQL, MySQL, MongoDB e Firebase.

---

# Documentação

Aprofunde-se nos recursos do WinUp:

## Conceitos Principais
- [**Modelo de Componente & Estilização**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/concepts.md)
- [**Gerenciamento de Estado**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/state.md)
- [**Lifecycle Hooks**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/concepts.md#component-lifecycle-hooks-on_mount-and-on_unmount)
- [**Roteamento**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/concepts.md#routing)
- [**Posicionamento Absoluto (Avançado)**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/absolute-layout.md)

## Ferramentas de Desenvolvimento
- [**Live Hot Reload (LHR)**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/live-hot-reload.md)
- [**Performance Profiler**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/profiler.md)
- [**Memoization**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/memoization.md)
- [**Executor de Tarefas Assíncronas**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/tasks.md)

## Componentes de UI
- [**Biblioteca Completa de Componentes**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/components/README.md)

---

## Contribuindo

WinUp é um projeto de código aberto. Contribuições são bem-vindas!

## Licença

Este projeto está licenciado sob a Licença MIT. Veja **LICENSE** para mais informações.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---