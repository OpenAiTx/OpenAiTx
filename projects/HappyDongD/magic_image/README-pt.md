
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# Pintura Mágica com IA

<div align="right">中文 | <a href="README-EN.md">English</a></div>

[![Licença](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)
[![Next.js](https://img.shields.io/badge/Next.js-14-black.svg)](https://nextjs.org/)
[![TypeScript](https://img.shields.io/badge/TypeScript-5.0-blue.svg)](https://www.typescriptlang.org/)
[![Tailwind CSS](https://img.shields.io/badge/Tailwind%20CSS-3.0-38B2AC.svg)](https://tailwindcss.com/)

Um aplicativo de desenho com IA desenvolvido com base no Next.js, com as seguintes funcionalidades principais:
- 🎨 Suporte a múltiplos modelos de IA (Sora, DALL-E, GPT, GEMINI, etc.) e adição de modelos personalizados
- 🖼️ Funções de geração de imagem por texto e geração de imagem por imagem, com suporte a referências múltiplas e edição por regiões
- 🔐 Todos os dados e chaves de API são armazenados localmente, garantindo privacidade e segurança
- 💻 Compatível com versão web e empacotamento para aplicativo desktop, uso multiplataforma

## Experiência Online

Endereço de acesso: [https://image-front-eight.vercel.app/](https://image-front-eight.vercel.app/)

### Capturas de Tela do Aplicativo

<div align="center">
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/4.png" alt="Captura de Tela 4" width="800" style="margin-bottom: 20px"/>
      <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/5.png" alt="Captura de Tela 4" width="800" style="margin-bottom: 20px"/>
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/0.png" alt="Captura de Tela 1" width="800" style="margin-bottom: 20px"/>
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/1.png" alt="Captura de Tela 2" width="800" style="margin-bottom: 20px"/>
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/2.png" alt="Captura de Tela 3" width="800" style="margin-bottom: 20px"/>
</div>

## Características Funcionais

- 🎨 Suporte a diversos modelos de IA
  - Modelo GPT Sora_Image
  - Modelo GPT 4o_Image
  - Modelo GPT Image 1
  - Modelo DALL-E 3
  - Modelo GEMINI
  - 🆕 Modelo personalizado (suporta adição de modelos privados)
- 🔄 Alternância entre múltiplos modelos
  - Suporte à troca rápida entre diferentes modelos
  - Cada modelo possui opções de configuração independentes
- ✍️ Função de geração de imagem por texto
  - Suporta personalização de prompts
  - Permite escolher proporção da imagem
  - Suporta diversos tamanhos de imagem
- 🖼️ Função de geração de imagem por imagem
  - Suporte à edição de imagens
  - Suporte à edição de máscaras por regiões
  - Suporte ao ajuste da qualidade da imagem
  - Suporte a múltiplas imagens de referência (faça upload de várias imagens ao mesmo tempo)
- 🔒 Segurança de dados
  - Todas as imagens geradas e históricos ficam salvos apenas no navegador local
  - Suporte a configuração de endereço proxy de API personalizado
  - Suporte à configuração de API Key
- 📱 Design da UI
  - Interface de usuário moderna
  - Experiência de interação fluida
  - Exibição em formato Markdown
  - Suporte a destaque de código
- 🖥️ Suporte multiplataforma
  - Suporte à empacotamento como aplicativo desktop (Windows, macOS, Linux)
  - Suporte ao uso offline (necessário configurar a interface da API)

## Stack Tecnológica

- Next.js 14
- TypeScript
- Tailwind CSS
- shadcn/ui
- React
- Tauri (empacotamento de aplicativo desktop)

## Desenvolvimento local

1. Clone o projeto
```bash
git clone https://github.com/HappyDongD/magic_image.git
cd magic_image
```
2. Instalar dependências

```bash
npm install
# 或
yarn install
# 或
pnpm install
```
3. Inicie o servidor de desenvolvimento

```bash
npm run dev
# 或
yarn dev
# 或
pnpm dev
```
4. Acesse [http://localhost:3000](http://localhost:3000)

## Empacotamento de Aplicativo Desktop

Este projeto utiliza o Tauri para empacotar aplicativos desktop, suportando sistemas Windows, macOS e Linux.

### Preparação do Ambiente

Antes de empacotar o aplicativo desktop, é necessário instalar as seguintes dependências:

1. **Instalar Rust**:
   - Acesse [https://www.rust-lang.org/tools/install](https://www.rust-lang.org/tools/install)
   - Siga as instruções para instalar Rust e Cargo

2. **Dependências do Sistema**:
   - **Windows**: Instale [Visual Studio C++ Build Tools](https://visualstudio.microsoft.com/visual-cpp-build-tools/)
   - **macOS**: Instale as ferramentas de linha de comando do Xcode (`xcode-select --install`)
   - **Linux**: Instale as dependências necessárias, consulte [documentação do Tauri](https://tauri.app/v1/guides/getting-started/prerequisites)

### Modo de Desenvolvimento


```bash
# 安装 Tauri CLI
npm install -D @tauri-apps/cli

# 启动桌面应用开发模式
npm run tauri:dev
```
### Construindo aplicativos desktop


```bash
# 构建桌面应用安装包
npm run desktop
```
Após a conclusão da construção, o pacote de instalação para o sistema correspondente pode ser encontrado no diretório `src-tauri/target/release/bundle`.

## Implantação no Vercel

1. Faça um fork deste projeto para sua conta do GitHub

2. Crie um novo projeto no [Vercel](https://vercel.com)

3. Importe o seu repositório do GitHub

4. Clique em implantar

## Instruções de uso

1. É necessário configurar a chave de API na primeira utilização
   - Clique em "Configuração de Chave" no canto superior direito
   - Insira a chave de API e o endereço base
   - Clique em salvar
   - Também é possível configurar rapidamente via parâmetro na URL:

     ```
     http://localhost:3000?url=你的API地址&apikey=你的API密钥
     ```
     例如：
     ```
     http://localhost:3000?url=https%3A%2F%2Fapi.example.com&apikey=sk-xxx
     ```
     Nota: Caracteres especiais na URL precisam ser codificados usando URL encoding

2. Escolha o modo de geração
   - Texto para imagem: gera imagens a partir de descrições textuais
   - Imagem para imagem: edite imagens enviando uma imagem

3. Defina os parâmetros de geração
   - Escolha o modelo de IA (modelo interno ou personalizado)
   - Defina a proporção da imagem
   - Ajuste a qualidade da imagem (modo imagem para imagem)

4. Gerenciamento de modelos personalizados
   - Clique no ícone de configurações ao lado da caixa de seleção de modelo
   - Adicionar novo modelo: insira o nome do modelo, valor do modelo e selecione o tipo de modelo
   - Editar modelo: clique no botão de edição de um modelo existente
   - Excluir modelo: clique no botão de exclusão de um modelo existente
   - Selecionar modelo: clique no botão de adição para selecionar e usar o modelo imediatamente

5. Explicação dos tipos de modelo
   - Formato DALL-E: usa a interface de geração de imagens (/v1/images/generations)
   - Formato OpenAI: usa a interface de chat (/v1/chat/completions)

6. Gerar imagem
   - Insira palavras-chave
   - Clique no botão "Gerar imagem"
   - Aguarde a conclusão da geração

7. Gerenciamento de imagens
   - Visualize o histórico
   - Baixe as imagens geradas
   - Edite imagens existentes

## Observações

- Todas as imagens geradas e o histórico são armazenados apenas no navegador local
- Usar o modo de navegação privada ou trocar de dispositivo pode causar perda de dados
- Faça o download e backup das imagens importantes prontamente
- A configuração da API será armazenada com segurança no seu navegador e não será enviada ao servidor
- O carregamento de recursos HTTP em sites HTTPS será bloqueado pelo navegador, e o aplicativo irá converter automaticamente interfaces HTTP para HTTPS

## Guia de Contribuição

Seja bem-vindo para enviar Issues e Pull Requests para ajudar a melhorar o projeto.

## Licença

Este projeto utiliza a licença [Apache License 2.0](https://www.apache.org/licenses/LICENSE-2.0).

De acordo com a licença, você pode:
- ✅ Uso comercial: pode utilizar o software para fins comerciais
- ✅ Modificar: pode modificar o código-fonte do software
- ✅ Distribuir: pode distribuir o software
- ✅ Uso privado: pode usar o software de forma privada
- ✅ Autorização de patentes: esta licença também fornece autorização de patentes

Mas é necessário cumprir as seguintes condições:
- 📝 Declaração de licença e direitos autorais: você deve incluir a licença original e a declaração de direitos autorais
- 📝 Declaração de alterações: você deve declarar alterações significativas ao código original
- 📝 Declaração de marca registrada: não pode usar as marcas dos contribuintes

---

## Me pague um café

Se este projeto foi útil para você, sinta-se à vontade para me pagar um café ☕️

<div align="center">
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/wechat-pay.jpg" alt="Código de pagamento WeChat" width="300" />
  <p>Me pague um café</p>
</div>

## Informações de contato

Se você tiver qualquer dúvida ou sugestão, entre em contato comigo pelo WeChat:

<div align="center">
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/wechat-connect.jpg" alt="Informações de contato WeChat" width="300" />
  <p>Escaneie o QR code para adicionar no WeChat</p>
</div>



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-09

---