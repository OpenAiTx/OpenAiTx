<p align="center">
    <img src="https://raw.githubusercontent.com/basketoengine/Basketo/main/readmeimgs/logo.png" alt="Logo do Basketo Game Engine" width="200"/>
</p>

<h2 align="center">Crie, Jogue, Inspire. Jogos Ganhando Vida. ✨</h2>

<h1 align="center">Basketo Game Engine</h1>

<div align="center">

[![Discord](https://img.shields.io/discord/1373185493742911609?logo=discord&label=Discord&color=5B5BD6&logoColor=white)](https://discord.gg/F3DswRMW) <!-- Substitua your_discord_server_id pelo ID real do seu servidor -->
[![GitHub stars](https://img.shields.io/github/stars/basketoengine/Basketo?style=social)](https://github.com/basketoengine/Basketo)
[![X (antigo Twitter)](https://img.shields.io/twitter/follow/BaslaelWorkneh?style=social&logo=x)](https://x.com/BaslaelWorkneh)

</div>

<p align="center">
Bem-vindo ao Basketo Engine - um projeto movido por paixão, onde estamos colocando nosso melhor esforço para criar um motor incrível e de alta performance, com o plano empolgante de torná-lo um motor de jogos AI-Nativo. Conta com uma interface de editor semelhante à do Unity, integração com Gemini AI, sistema avançado de efeitos sonoros múltiplos e poderosa arquitetura ECS. Esteja você aqui para contribuir, sugerir ideias ou apenas acompanhar o crescimento, você faz parte desta jornada! 🚀
</p>

## 🚀 Estado Atual do Motor
<p align="center">
  <img src="https://raw.githubusercontent.com/basketoengine/Basketo/main/readmeimgs/image3.png" alt="Estado Atual do Basketo Engine" width="700"/>
</p>

<p align="center">
  <em>Confira os desenvolvimentos mais recentes e os recursos em ação!</em> 🎮
</p>

## ✨ Principais Recursos

### 🎮 **Interface do Editor Semelhante ao Unity**
- **Configuração de janela dupla**: Editor de cena e visualização do jogo lado a lado
- **Edição ao vivo**: Modifique cenas enquanto o jogo está rodando
- **Painel do inspetor**: Edição visual de componentes com arrastar e soltar
- **Visualização de hierarquia**: Organize e gerencie entidades
- **Navegador de ativos**: Gerenciamento fácil de texturas e áudio

### 🤖 **Desenvolvimento Nativo em IA**
- **Integração com Gemini AI**: Comandos em linguagem natural para desenvolvimento de jogos
- **Geração inteligente de scripts**: Criação de scripts Lua com IA
- **Modificação de entidades**: Descreva alterações em inglês simples
- **Configuração fácil de API**: Configuração integrada da chave de API Gemini
### 🔊 **Sistema Avançado de Áudio**
- **Efeitos sonoros múltiplos**: Vários sons nomeados por entidade (andar, pular, atacar, etc.)
- **Áudio tradicional**: Música de fundo e sons ambientes
- **Integração com Lua**: Acione sons a partir de scripts com `PlaySound(entity, "action")`
- **Editor visual**: Gerencie efeitos sonoros através do inspetor

### 🎯 **Entity-Component-System (ECS)**
- **Alto desempenho**: Otimizado para grandes quantidades de entidades
- **Design modular**: Combine componentes conforme necessário
- **Integração com scripts**: Scripts em Lua com acesso total ao ECS
- **Atualizações em tempo real**: Edição de componentes ao vivo

### 🎨 **Gráficos & Animação**
- **Renderização de sprites**: Pipeline eficiente de gráficos 2D
- **Sistema de animação**: Animações baseadas em quadros com looping
- **Sistema de transformações**: Posição, rotação e escala
- **Sistema de câmera**: Suporte a múltiplas câmeras

### ⚡ **Física & Colisão**
- **Detecção de colisão**: Colisão AABB com otimização espacial
- **Física de corpo rígido**: Gravidade, velocidade e forças
- **Callbacks de colisão**: Eventos de colisão acessíveis por script
- **Particionamento espacial**: Otimização com Quadtree para desempenho
## 🎬 Clique na imagem abaixo para ver uma demonstração em vídeo:
<p align="center">
  <a href="https://x.com/BaslaelWorkneh/status/1922713614697288096">
    <img src="https://raw.githubusercontent.com/basketoengine/Basketo/main/readmeimgs/image2.png" alt="Demonstração do Basketo Engine" width="500"/>
  </a>
</p>

## � Guia de Início Rápido

### 1. **Obtenha sua Chave de API Gemini** (Opcional, mas Recomendado)
- Visite o [Google AI Studio](https://aistudio.google.com/app/apikey)
- Faça login e crie uma chave de API gratuita
- Isso habilita recursos com IA, como comandos em linguagem natural

### 2. **Compile e Execute**
```bash
git clone --recurse-submodules git@github.com:basketoengine/Basketo.git
cd Basketo && mkdir build && cd build
cmake .. && make -j$(nproc)
./BasketoGameEngine
```
### 3. **Configurar Recursos de IA**
- No engine, vá até o painel de Prompt de IA (na parte inferior)
- Procure por "🤖 Configuração do Gemini AI"
- Insira sua chave de API e clique em "Salvar"

### 4. **Comece a Criar**
- Experimente comandos de IA: `"create a player at 100 200"`
- Adicione efeitos sonoros às entidades no inspetor
- Escreva scripts em Lua ou deixe a IA gerá-los
- Use o editor de janelas duplas para desenvolvimento ao vivo

## �🛠️ Compilando o Engine (Linux) 🐧

### Pré-requisitos
- CMake 3.26.0 ou superior é necessário.
- SDL2, SDL2_image, SDL2_ttf, SDL2_mixer
- Lua 5.4
- g++ (C++17)
- libcurl (para recursos de IA)
- nlohmann/json (incluído como submódulo)
- ImGui (incluído como submódulo)

### Etapas de Compilação
```bash
# Clone o repositório
git clone --recurse-submodules git@github.com:basketoengine/Basketo.git

cd Basketo

mkdir build && cd build

cmake ..

make -j$(nproc)

```

### Execução
```bash
./BasketoGameEngine

```
Se você quiser executar o teste de física:
```bash
./PhysicsTest

```

## 🛠️ Compilando o Engine (Windows) 💻

### Pré-requisitos

1. **Visual Studio 2022 (Edição Community ou superior)**  
   Instale com as seguintes cargas de trabalho:
   - Desenvolvimento para desktop com C++
   - Ferramentas CMake para C++ no Windows
   - SDK do Windows 10 ou 11

2. **CMake** (incluído no Visual Studio ou baixe em https://cmake.org/download/)

3. **vcpkg** (usado para instalar dependências)


---
### Instalar Dependências

```bash
# Abra um Prompt de Comando de Desenvolvedor para VS 2022 ou PowerShell

# Clone o vcpkg

git clone https://github.com/microsoft/vcpkg.git
cd vcpkg

.\bootstrap-vcpkg.bat

# Instale as bibliotecas necessárias
.\vcpkg install sdl2 sdl2-image sdl2-ttf sdl2-mixer lua curl

```

---

### Etapas de Compilação
```bash
# Clone o repositório do Basketo
git clone --recurse-submodules git@github.com:basketoengine/Basketo.git
cd Basketo
mkdir build && cd build

# Configure com o CMake
cmake .. -DCMAKE_TOOLCHAIN_FILE=C:/caminho/para/vcpkg/scripts/buildsystems/vcpkg.cmake -DCMAKE_BUILD_TYPE=Release

# Substitua "C:/caminho/para/vcpkg" pelo caminho completo do seu diretório vcpkg

# Compile o engine
cmake --build . --config Release
```

---

### Execução

```bash
# A partir do diretório build/Release
./BasketoGameEngine.exe

# Para executar o teste de física
./PhysicsTest.exe
```

## 📚 Documentação

### Funcionalidades Principais
- **[Sistema de Efeitos Sonoros](https://raw.githubusercontent.com/basketoengine/Basketo/main/docs/SoundEffectsSystem.md)**: Guia completo para múltiplos efeitos sonoros
- **[Configuração da API Gemini](https://raw.githubusercontent.com/basketoengine/Basketo/main/docs/GeminiAPIKeySetup.md)**: Configuração de IA passo a passo
- **[Scripting em Lua](assets/Scripts/)**: Scripts de exemplo e referência da API

### Exemplo de Uso

#### Desenvolvimento com IA
```bash
# Comandos em linguagem natural
"criar um personagem jogador na posição 100 200"
"adicionar comportamento de pulo ao jogador"
"fazer o inimigo se mover mais rápido"

# Geração de Script
gemini_script criar um controlador de plataforma com pulo duplo
```

#### Efeitos Sonoros Múltiplos
```lua
-- Nos seus scripts Lua
PlaySound(entity, "jump")    -- Toca o som de pulo
PlaySound(entity, "walk")    -- Toca o som de caminhada
PlaySound(entity, "attack")  -- Toca o som de ataque

-- Verifica se o som existe
if HasSoundEffect(entity, "jump") then
    PlaySound(entity, "jump")
end
```

#### Sistema de Componentes
- **Transform**: Posição, rotação, escala
- **Sprite**: Renderização de textura
- **Animation**: Animações baseadas em quadros
- **Script**: Scripts de comportamento em Lua
- **Collider**: Colisão física
- **Rigidbody**: Simulação física
- **Audio**: Música de fundo
- **SoundEffects**: Múltiplos sons nomeados
- **Camera**: Gerenciamento de visualização
## 🤝 Participe

Adoramos contribuições da nossa comunidade ❤️. Para detalhes sobre como contribuir ou executar o projeto para desenvolvimento, confira nossas [Diretrizes de Contribuição](https://raw.githubusercontent.com/basketoengine/Basketo/main/ContributionGuidline.md). <!-- Supondo que você tenha este arquivo -->

- 🐛 Encontrou um bug? Abra uma issue!
- ✨ Tem uma ideia legal de recurso? Queremos ouvir!
- 💻 Quer contribuir? Faça um fork, codifique e crie um pull request!

Vamos construir este engine juntos e tornar o desenvolvimento de jogos divertido e fácil para todos. 🌍

## 👥 Comunidade
Seja bem-vindo com um grande abraço 🤗. Estamos super animados para contribuições da comunidade de todos os tipos – seja com melhorias no código 📝, atualizações na documentação 📚, relatos de problemas 🐞, solicitações de recursos 💡, e discussões no nosso Discord 🗣️.

Junte-se à nossa comunidade aqui:

- 👋 [Participe da nossa comunidade no Discord](https://discord.gg/F3DswRMW)
- ⭐ [Dê uma estrela para nós no GitHub](https://github.com/basketoengine/Basketo)

## 🙏 Apoie-nos:
Estamos constantemente melhorando, e mais recursos e exemplos estarão disponíveis em breve 🌟. Se você gosta deste projeto, por favor, nos dê uma estrela ⭐ no repositório do GitHub [![GitHub](https://img.shields.io/github/stars/basketoengine/Basketo?color=5B5BD6)](https://github.com/basketoengine/Basketo) para ficar por dentro e nos ajudar a crescer. 🌱

---

Feliz codificação e criação de jogos! 🎉🎮

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-10

---