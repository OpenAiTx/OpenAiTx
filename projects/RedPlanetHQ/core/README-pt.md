<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

<div align="center">
  <a href="https://core.heysol.ai">
    <img src="https://github.com/user-attachments/assets/89066cdd-204b-46c2-8ad4-4935f5ca9edd" width="200px" alt="LOGO CORE" />
  </a>

### C.O.R.E: Seu cérebro digital para a era da IA

<p align="center">
    <a href="https://deepwiki.com/RedPlanetHQ/core">
        <img src="https://deepwiki.com/badge.svg" alt="DeepWiki Badge" />
    </a>
</p>
<p align="center">
    <a href="https://docs.heysol.ai/core/overview"><b>Documentação</b></a> •
    <a href="https://discord.gg/YGUZcvDjUa"><b>Discord</b></a>
</p>
</div>

## 🧠 C.O.R.E.

**Contextual Observation & Recall Engine**

C.O.R.E é um grafo de memória portátil criado a partir das suas interações com LLM e dados pessoais, tornando todo o seu contexto e histórico de trabalho acessíveis a qualquer ferramenta de IA, como um cérebro digital. Isso elimina a necessidade de compartilhar contexto repetidamente. O objetivo é fornecer:

- **Memória Unificada e Portátil**: Adicione e recupere contexto facilmente, conectando sua memória entre aplicativos como Claude, Cursor, Windsurf e outros.
- **Relacional, Não Apenas Fatos Isolados**: O CORE organiza seu conhecimento, armazenando fatos e relações para uma memória mais profunda e rica, como um cérebro real.
- **Propriedade do Usuário**: Você decide o que manter, atualizar ou excluir, e compartilha sua memória nas ferramentas que quiser, livre de aprisionamento por fornecedores.

## 🎥 Vídeo de Demonstração

[Veja a Demonstração do C.O.R.E](https://youtu.be/iANZ32dnK60)

<img width="954" height="700" alt="Painel do Core" src="https://github.com/user-attachments/assets/d684b708-6907-47be-9499-a30b25434694" />

## 🧩  Funcionalidades Principais

- **Grafo de Memória**: Visualize como seus fatos e preferências estão conectados
- **Converse com a Memória**: Faça perguntas sobre a memória para obter insights e compreensão instantâneos
- **Plug n Play**: Use instantaneamente a memória CORE em aplicativos como Cursor, Claude

## ☁️ Configuração do C.O.R.E Cloud

1. Cadastre-se no [Core Cloud](https://core.heysol.ai) e comece a construir seu grafo de memória.
2. Adicione o texto que deseja salvar na memória. Ao clicar no botão `+ Add`, seu grafo de memória será gerado.
3. [Conecte o Core Memory MCP com o Cursor](#connecting-core-mcp-with-cursor)

## 💻 Configuração Local do C.O.R.E

#### Pré-requisitos

1. Docker
2. Chave de API OpenAI


> **Nota:** Estamos trabalhando ativamente para melhorar o suporte a modelos Llama. No momento, o C.O.R.E não fornece resultados ideais com modelos baseados em Llama, mas estamos progredindo para garantir melhor compatibilidade e resultados em breve.
> 
#### Execute o C.O.R.E localmente

1. **Copie as Variáveis de Ambiente**

   Copie o arquivo de ambiente de exemplo para `.env`:


   ```bash
   cp .env.example .env
   ```
2. **Inicie o Aplicativo**

   Use o Docker Compose para iniciar todos os serviços necessários:


   ```bash
   docker-compose up
   ```
3. **Acesse o App**

   Quando os containers estiverem em execução, abra seu navegador e vá para [http://localhost:3000](http://localhost:3000).

4. **Criar Conta com Magic Link**

   - Para criar uma conta, clique no botão `Continue with email`

     <img width="865" height="490" alt="Create account" src="https://github.com/user-attachments/assets/65de110b-2b1f-42a5-9b8a-954227d68d52" />

   - Digite seu e-mail e clique no botão `Send a Magic Link`

     <img width="824" height="429" alt="Enter email" src="https://github.com/user-attachments/assets/76128b61-2086-48df-8332-38c2efa14087" />

   - `Copie o magic link dos logs do terminal` e abra-o em seu navegador

     <img width="1010" height="597" alt="Magic link" src="https://github.com/user-attachments/assets/777cb4b1-bb93-4d54-b6ab-f7147e65aa5c" />


5. **Crie Seu Espaço Privado & Adicione Dados**

   - No painel, vá para a seção superior direita -> Digite uma mensagem, por exemplo, `Eu adoro jogar badminton`, e clique em `+Add`.
   - Sua memória será colocada na fila para processamento; você pode monitorar o status dela na seção `Logs`.
     
     <img width="1496" height="691" alt="Core memory logs" src="https://github.com/user-attachments/assets/dc34a7af-fe52-4142-9ecb-49ddc4e0e854" />

   - Quando o processamento for concluído, nós serão adicionados ao seu grafo de conhecimento privado e ficarão visíveis no painel.
   - Depois, você pode optar por conectar essa memória a outras ferramentas ou mantê-la privada.

6. **Pesquise Sua Memória**

   - Use o recurso de busca do painel para consultar seus dados ingeridos dentro do seu espaço privado.


## Conectando o CORE MCP com o Cursor

1. Abra o painel do CORE e navegue até a seção de API para gerar um novo token de API.
2. No Cursor, vá para: Settings → Tools & Integrations → New MCP Server.
3. Adicione o servidor CORE MCP usando o formato de configuração abaixo. Certifique-se de substituir o valor de API_TOKEN pelo token gerado no passo 1.

   Configuração do MCP para adicionar no Cursor


   ```json
   {
     "mcpServers": {
       "memory": {
         "command": "npx",
         "args": ["-y", "@redplanethq/core-mcp"],
         "env": {
           "API_TOKEN": "YOUR_API_TOKEN_HERE",
           "API_BASE_URL": "https://core.heysol.ai",
           "SOURCE": "cursor"
         }
       }
     }
   }
   ```
4. Vá para Configurações -> Regras do usuário -> Nova Regra -> e adicione a regra abaixo para garantir que todas as suas interações de chat estejam sendo armazenadas na memória CORE


```
After every interaction, update the memory with the user's query and the assistant's
response to core-memory mcp. sessionId should be the uuid of the conversation
```
## Documentação

Explore nossa documentação para aproveitar ao máximo o CORE
- [Conceitos Básicos](https://docs.heysol.ai/core/overview)
- [Referência da API](https://docs.heysol.ai/core/local-setup)
- [Conectar Core Memory MCP com Cursor](#connecting-core-mcp-with-cursor)


## 🧑‍💻 Suporte
Tem dúvidas ou feedback? Estamos aqui para ajudar:
- Discord: [Junte-se ao canal core-support](https://discord.gg/YGUZcvDjUa)
- Documentação: [docs.heysol.ai/core](https://docs.heysol.ai/core/overview)
- E-mail: manik@poozle.dev

## Diretrizes de Uso

**Armazene:**

- Histórico de conversas
- Preferências do usuário
- Contexto de tarefas
- Materiais de referência

**Não armazene:**

- Dados sensíveis (PII)
- Credenciais
- Logs do sistema
- Dados temporários

## 👥 Contribuidores

<a href="https://github.com/RedPlanetHQ/core/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=RedPlanetHQ/core" />
</a>



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-23

---