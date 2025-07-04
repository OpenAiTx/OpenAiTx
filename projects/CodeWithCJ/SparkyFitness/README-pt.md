# SparkyFitness - Alternativa selfhosted ao MyFitnessPal

SparkyFitness é um aplicativo abrangente de rastreamento e gerenciamento de fitness projetado para ajudar os usuários a monitorar sua nutrição, exercícios e medidas corporais. Ele oferece ferramentas para acompanhamento diário de progresso, definição de metas e relatórios detalhados para apoiar um estilo de vida saudável.


## ✨ Funcionalidades

### 🍎 Rastreamento de Nutrição

* **Registre suas refeições diárias**
* **Crie e gerencie alimentos e categorias personalizados**
* **Visualize resumos e analise tendências com gráficos interativos**

### 💪 Registro de Exercícios

* **Registre seus treinos**
* **Navegue e pesquise em um banco de dados abrangente de exercícios**
* **Acompanhe o progresso físico ao longo do tempo**

### 💧 Monitoramento de Consumo de Água

* **Acompanhe metas diárias de hidratação**
* **Registro de água simples e rápido**

### 📏 Medidas Corporais

* **Registre métricas corporais** (ex.: peso, cintura, braços)
* **Adicione tipos de medidas personalizadas**
* **Visualize o progresso por meio de gráficos**

### 🎯 Definição de Metas

* **Defina e gerencie metas de fitness e nutrição**
* **Acompanhe o progresso ao longo do tempo**

### 🗓️ Check-Ins Diários

* **Monitore a atividade diária**
* **Mantenha a consistência com o rastreamento de hábitos**

### 🤖 Treinador de Nutrição com IA (SparkyAI)

* **Registre alimentos, exercícios, estatísticas corporais e passos via chat**
* **Envie imagens de alimentos para registrar refeições automaticamente**
* **Inclui histórico de chat e orientação personalizada**

### 🔒 Autenticação de Usuário & Perfis

* **Sistema de login seguro**
* **Alterne entre perfis de usuário**
* **Suporte para acesso e gerenciamento familiar**

### 📊 Relatórios Abrangentes

* **Gere resumos de nutrição e métricas corporais**
* **Acompanhe tendências de longo prazo por semanas ou meses**

### 🎨 Temas Personalizáveis

* **Alterne entre modo claro e escuro**
* **Interface minimalista e livre de distrações**

### Precisa de Ajuda?
* **Entre no Discord**
  https://discord.gg/vcnMT5cPEA
* **Publique em discussões**


![image](https://github.com/user-attachments/assets/ccc7f34e-a663-405f-a4d4-a9888c3197bc)


## 🚀 Primeiros Passos

Para rodar o aplicativo SparkyFitness em sua máquina local, siga estes passos:

### Pré-requisitos

*   **Projeto Supabase**: Você precisará de um projeto Supabase configurado.
    *   **Crie um novo projeto no Supabase**: Acesse [Supabase](https://app.supabase.com/) e crie um novo projeto. (Você também pode tentar configurar um projeto Supabase local, se preferir.)
    *   Obtenha a URL do Projeto Supabase e a Anon Key nas configurações do seu projeto (seção API).
    *   **Nota Importante sobre a Autenticação Supabase:** Atualize sua Configuração de URL nas configurações de Autenticação do Supabase para coincidir com seu domínio. Isso é crucial para que seu domínio funcione e para receber convites por e-mail para cadastro. O Supabase oferece recursos avançados de segurança e opções de SSO de terceiros; configure conforme as necessidades do seu projeto.
    *   O deployment automatizado do banco de dados para o Supabase não funciona com IPV4 se você tiver a versão gratuita do Supabase. Portanto, é necessário configurar sua rede para usar conexão IPV6. Caso contrário, a migração do banco de dados falhará e será necessário implantar manualmente.       


    

### Instalação

1.  **Configure as Variáveis de Ambiente:**
    Crie um arquivo `.env` na pasta privada. Se estiver usando o Portainer, crie diretamente por lá.
    Adicione suas credenciais do Supabase:
    ```
    VITE_SUPABASE_URL="SUA_SUPABASE_PROJECT_URL"
    VITE_SUPABASE_ANON_KEY="SUA_SUPABASE_ANON_KEY"
    SUPABASE_PROJECT_REF="SEU_SUPABASE_PROJECT_REF"    
    ```

2.  **Execute com Docker Compose:**
    Baixe as imagens Docker e inicie os serviços:
    ```sh
    docker compose pull
    docker compose up -d
    ```

3.  **Acesse o Aplicativo:**
    Assim que os serviços estiverem ativos e em execução, acesse o SparkyFitness em seu navegador web em:
    ```
    http://localhost:3000
    ```

4.  **Chatbot de IA - Configuração Opcional:**
    Para habilitar todas as funcionalidades do Chatbot de IA, incluindo armazenamento seguro de chaves de API e acesso ao banco de dados, siga estes passos:

    *   **Configure `AI_API_ENCRYPTION_KEY`:** Gere um segredo em "Supabase -> Edge Functions" -> "Environment Variables". Esta chave é usada para criptografar suas chaves de IA quando armazenadas no Supabase.

    *   **Gere `SUPABASE_ACCESS_TOKEN`:**
        1.  Acesse o console do seu Docker.
        2.  Execute `supabase login` e autentique-se usando a URL fornecida.
        3.  Recupere o token de acesso executando `cat ~/.supabase/access-token`.
        4.  Atualize seu `docker-compose.yml` ou a configuração do Portainer com este token para fazer o redeploy.
        5.  Após o redeploy, faça login no SparkyFitness e configure o serviço de IA com seu provedor preferido.
     

### Implantação Manual do DB & Funções no Supabase
**Método 1:  
**Se você não possui conexão de rede IPV6 habilitada, a migração do banco de dados irá falhar, pois a versão gratuita do Supabase não suporta conexão direta via IPV4.

   1. Baixe a última versão e descompacte em seu PC.
   2. Navegue até a pasta do projeto. O Docker precisa estar ativo e em execução.
   3. Execute os comandos abaixo. (deploy das funções é necessário apenas para a configuração de IA. Se não precisar do ChatBOT, pode pular esta etapa)
``
      supabase login  
      supabase link  
      supabase db push  
      supabase functions deploy chat   
``
Execute novamente o Docker compose. O aplicativo Front-end começará a funcionar.

**Método 2:  
   1. Baixe a última versão e descompacte em seu PC.  
   2. Navegue até a pasta do projeto.  
   3. Vá para supabase/migrations. Copie os comandos SQL e execute-os no Supabase-->Projeto-->Editor SQL um por um em ordem ASC.  
   4. [Opcional] Faça o mesmo para supabase/functions/chat se precisar do ChatBOT de IA. Copie o index.js e execute-o em Supabase-->Projeto-->Edge Function-->Deploy new function.  


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-04

---