# Quick Prompt

<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

<p align="center">
  <img src="https://raw.githubusercontent.com/wenyuanw/quick-prompt/main/./assets/icon.png" alt="Quick Prompt Logo" width="128" style="background: transparent;">
</p>

Uma poderosa extensão de navegador, focada na gestão de prompts e entrada rápida. Ajuda o usuário a criar, gerenciar e organizar uma biblioteca de prompts, além de inserir rapidamente conteúdos predefinidos em qualquer campo de entrada em páginas web, aumentando a eficiência do trabalho.

> Como a extensão de navegador só pode ser usada na web, foi disponibilizado um [plugin Raycast](https://github.com/wenyuanw/quick-prompt-raycast) com as mesmas funcionalidades, compatível com o formato de dados da extensão e suporta migração perfeita usando os mesmos dados JSON.

## ✨ Funcionalidades

- 📚 **Gestão de prompts**: Crie, edite e gerencie facilmente sua biblioteca de prompts
- 🚀 **Entrada rápida**: Use `/p` em qualquer campo de entrada para acionar rapidamente o seletor de prompts
- ⌨️ Suporte para configurar atalhos para abrir o seletor de prompts & salvar texto selecionado como prompt
- 📑 Suporte ao menu do botão direito para salvar rapidamente texto selecionado como prompt
- 🎯 Suporte a prompts personalizados, incluindo categorias, títulos, conteúdo, tags e variáveis
- 🧑‍💻 **Suporte a variáveis**: Use variáveis no formato `{{nome_da_variavel}}` nos prompts e preencha valores ao usar
- 💾 **Backup de dados**: Exporte e importe a biblioteca de prompts para facilitar migração e backup entre dispositivos
- 🔗 **Sincronização com Notion**: Sincronize a biblioteca de prompts com um banco de dados do Notion
- 🔍 Suporte à busca e filtragem de prompts
- 🌙 Adapta-se automaticamente ao tema claro/escuro do sistema

## ⚠️ Problemas conhecidos

- No site doubao.com, após acionar o seletor de prompts com `/p`, alguns campos de entrada não removem o `/p` automaticamente. Mas não se preocupe, eu e meu velho parceiro Cursor estamos trabalhando dia e noite para solucionar isso o quanto antes!

## 🚀 Como usar

1. **Acionamento rápido**: Digite `/p` em qualquer campo de texto em uma página web para acionar o seletor de prompts
2. **Abrir seletor com atalho**: Use `Ctrl+Shift+P` (Windows/Linux) ou `Command+Shift+P` (macOS) para abrir o seletor de prompts
3. **Selecionar prompt**: Clique no prompt desejado no seletor exibido; ele será inserido automaticamente no campo de entrada atual
4. **Salvar prompt rapidamente**: Selecione qualquer texto e use `Ctrl+Shift+S` (Windows/Linux) ou `Command+Shift+S` (macOS) para salvar rapidamente como prompt
5. **Salvar pelo menu direito**: Selecione qualquer texto, clique com o botão direito e escolha "Salvar este prompt" para salvar o conteúdo selecionado como prompt
6. **Exportar biblioteca de prompts**: Clique no botão "Exportar" na página de gerenciamento para salvar todos os prompts como um arquivo JSON localmente
7. **Importar biblioteca de prompts**: Clique em "Importar" na página de gerenciamento para importar prompts de um arquivo JSON local (suporta mesclar ou sobrescrever prompts existentes)

## 📸 Prévia da interface

O Quick Prompt oferece uma interface intuitiva e amigável, facilitando o gerenciamento e uso dos prompts.

### Seletor de prompts

![Seletor de prompts](https://github.com/user-attachments/assets/41b9897c-d701-4ff0-97f7-2f1754f570a8)

![Seletor de prompts](https://github.com/user-attachments/assets/22d9d30c-b4c3-4e34-a0a0-8ef51e2cb942)

Use o comando rápido `/p` ou o atalho para chamar rapidamente o seletor de prompts em qualquer campo de entrada, facilitando a escolha e inserção do prompt desejado.

### Página de gerenciamento de prompts

![Gestão de prompts](https://github.com/user-attachments/assets/371ae51e-1cee-4a66-a2a5-cca017396872)

Na página de gerenciamento, você pode criar novos prompts, editar existentes, adicionar tags e gerenciar categorias. A interface é simples e direta, facilitando as operações.

### Salvar pelo menu direito

![Salvar pelo menu direito](https://github.com/user-attachments/assets/17fc3bfd-3fa4-4b0b-ae1a-5cfd0b62be2e)

Basta selecionar qualquer texto em uma página web e clicar com o botão direito para salvá-lo rapidamente como prompt, aumentando a eficiência do trabalho.

### Entrada de variáveis do prompt

![Janela de variáveis do prompt](https://github.com/user-attachments/assets/c91c1156-983a-454d-aad0-5698b0291b9b)

Os prompts suportam configuração de variáveis e, ao selecionar, uma janela pop-up permite inserir os valores correspondentes.

## ⚙️ Configuração personalizada

1. Clique no ícone da extensão e depois no botão "Gerenciar prompts"

2. Na página de gerenciamento, você pode:
   - Adicionar novos prompts
   - Editar prompts existentes
   - Excluir prompts desnecessários
   - Adicionar tags aos prompts para categorização
   - Exportar o banco de prompts para backup
   - Importar um banco de prompts previamente salvo

## 📦 Guia de Instalação

### Instalar pela loja de aplicativos

Agora disponível na Chrome Web Store! [Clique aqui para baixar e instalar](https://chromewebstore.google.com/detail/quick-prompt/hnjamiaoicaepbkhdoknhhcedjdocpkd)

### Obter pelo GitHub Releases

1. Acesse a [página de GitHub Releases](https://github.com/wenyuanw/quick-prompt/releases)
2. Baixe o pacote mais recente do plugin pronto
3. Extraia o arquivo baixado
4. Instale a extensão compilada conforme as instruções abaixo

### Construindo a partir do código-fonte

1. Clone o repositório
   ```bash
   git clone https://github.com/wenyuanw/quick-prompt.git
   cd quick-prompt
   ```
2. Instalar dependências
   ```bash
   pnpm install
   ```
3. Desenvolvimento e Construção

   ```bash
   # 开发模式 (Chrome)
   pnpm dev
   
   # 开发模式 (Firefox)
   pnpm dev:firefox
   
   # 构建扩展 (Chrome)
   pnpm build
   
   # 构建扩展 (Firefox)
   pnpm build:firefox
   ```
### Instalar a extensão já compilada

#### Chrome / Edge
1. Abra a página de gerenciamento de extensões (`chrome://extensions` ou `edge://extensions`)
2. Ative o "Modo do desenvolvedor"
3. Clique em "Carregar sem compactação"
4. Selecione o diretório `.output/chrome-mv3/` do projeto

#### Firefox
1. Abra `about:debugging`
2. Clique em "Este Firefox"
3. Clique em "Carregar complemento temporário"
4. Selecione o arquivo `manifest.json` no diretório `.output/firefox-mv2/` do projeto

## 📄 Licença

MIT

## 🤝 Guia de Contribuição

Pull Requests e Issues são bem-vindos!

1. Faça um Fork deste repositório
2. Crie sua branch de funcionalidade (`git checkout -b feature/amazing-feature`)
3. Faça commit das suas alterações (`git commit -m 'Add some amazing feature'`)
4. Faça o push para a branch (`git push origin feature/amazing-feature`)
5. Abra um Pull Request

## 👏 Lista de Contribuidores

Agradecimentos a todos os desenvolvedores que contribuíram para o projeto!

<a href="https://github.com/wenyuanw/quick-prompt/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=wenyuanw/quick-prompt" />
</a>


## Histórico de Stars

[![Star History Chart](https://api.star-history.com/svg?repos=wenyuanw/quick-prompt&type=Date)](https://www.star-history.com/#wenyuanw/quick-prompt&Date)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-16

---