# wechat2tg-mac

Com base no protocolo do WeChat para Mac, envie e receba mensagens do WeChat no Telegram. O serviço wx2tg-server não é open source por motivos de segurança.

## Grupo TG: [@Wx2TgUserGroup](https://t.me/+AD02MEZa-og3ZGY1)

## Funcionalidades Principais

1. Recepção de mensagens de chats individuais do WeChat, grupos do WeChat, contas oficiais e mensagens do WeChat Empresarial
2. Envio de mensagens do Telegram para usuários, grupos e contas oficiais do WeChat especificados
3. Bloqueio de mensagens de grupos específicos

## Tipos de Mensagem Suportados

### Lista de tipos de mensagens suportadas pelo WeChat

+ [x] Mensagem de texto
+ [x] Mensagem do WeChat Empresarial
+ [x] Pacote de figurinhas do WeChat
+ [x] Mensagem de imagem
+ [x] Mensagem de vídeo
+ [x] Chamada de áudio/vídeo (apenas notificação)
+ [x] Mensagem de arquivo
+ [x] Mensagem de link
+ [x] Mensagem de grupo
+ [x] Mensagem de grupo com @ (mencionar todos e mencionar você será convertido para @ no Telegram)
+ [x] Mensagem de conta oficial
+ [x] emoji
+ [x] Mensagem de localização
+ [x] Mensagem de retirada
+ [x] Mensagem de voz
+ [ ] Mensagem de envelope vermelho (apenas aviso, não é possível obter o conteúdo)
+ [ ] Mensagem de mini-programa

### Lista de tipos de mensagens suportadas pelo Telegram

+ [x] Mensagem de texto
+ [x] Figurinha/Sticker
+ [x] Mensagem de imagem
+ [x] Mensagem de vídeo
+ [x] Mensagem de arquivo
+ [x] Mensagem de voz

## Observações

1. Este projeto é apenas para pesquisa técnica e aprendizado, não deve ser usado para fins ilegais
2. Em caso de qualquer problema, sinta-se à vontade para abrir um issue

## Instalação e Deploy

Primeiro, copie o arquivo `.env.example` para `.env` e configure as variáveis de ambiente.

Copie o arquivo `app.conf.example` presente no projeto para `app.conf` na pasta `conf`, configure o endereço do Redis para o endereço do seu Redis.

### docker-compose

Crie o arquivo `docker-compose.yml`:

```yaml
version: '3'

services:
  wx2tg-mac:
    image: finalpi/wechat2tg-mac:latest
    container_name: wx2tg-mac
    volumes:
      - ./config:/app/storage
      - ./save-files:/app/save-files # Ao montar esta pasta, não é necessário reconverter figurinhas
    env_file: ".env"
    restart: unless-stopped

  wx2tg-server:
    image: finalpi/wx2tg-server:latest # Baixar imagem
    container_name: wx2tg-server
    ports:
      - "8058:8058"
    volumes:
      - ./conf:/usr/wic-go/conf
    restart: unless-stopped

  wx2tg-redis:
    image: redis:7.2
    container_name: wx2tg-redis
    ports:
      - "16379:6379"
    volumes:
      - ./redis-data:/data
    command: ["redis-server", "--appendonly", "yes"]
    restart: unless-stopped
```

#### Execução

```shell
docker-compose up -d
```

#### Desativar modo de privacidade do bot

Desative o modo de privacidade do bot. Abra o BotFather, digite `/mybots`, selecione seu bot. Clique em `Bot Settings` - `Group Privacy` - `Turn off`. Se aparecer `Privacy mode is disabled for xxx`, está desativado com sucesso.

## Instruções de Uso

### Comandos do BOT

- `/login`: Obter QR code de login; ao iniciar pela primeira vez, a primeira pessoa que enviar o comando `/login` será o proprietário do `BOT`

- `/flogin`: Obter QR code do assistente de transferência de arquivos, suporta recebimento de vídeos e arquivos

- `/update`: Atualizar avatar e informações de nome dos grupos

- `/message`: Ativar/desativar recebimento de mensagens de grupo

- `/forward`: Ativar/desativar encaminhamento de mensagens de outras pessoas ou bots no grupo

- `/user`: Obter lista de usuários do WeChat; ao clicar no botão, pode criar novo grupo ou vincular usuário (pode buscar por nome ou comentário, ex: `/user Zhang` para encontrar usuários do WeChat contendo "Zhang")

- `/room`: Obter lista de grupos do WeChat; ao clicar no botão, pode criar novo grupo ou vincular grupo do WeChat (pode buscar por nome ou comentário, ex: `/room Delivery` para encontrar grupos contendo "Delivery")

- `/settings`: Configurações do programa

- `/unbind`: Desvincular grupo ou usuário do WeChat (suportado apenas em grupos)

### Explicação das Variáveis de Ambiente

|Nome| Obrigatório | Descrição                                                             |
|--|------|----------------------------------------------------------------|
|`BOT_TOKEN`| Sim    | Token do Bot do Telegram, criado via [BotFather](https://t.me/BotFather) |
|`API_ID`| Sim    | API ID do Telegram                                          |
|`API_HASH`| Sim    | API HASH do Telegram                                        |
|`BASE_API`| Sim    | Endereço completo da API do container wx2tg-server                            | |
|`PROXY_PROTOCOL`| Não    | Tipo de proxy (socks5,http,https)                                     |
|`PROXY_HOST`| Não    | URL do proxy                                                        |
|`PROXY_PORT`| Não    | Porta do proxy                                                         |
|`PROXY_USERNAME`| Não    | Usuário do proxy                                                         |
|`PROXY_PASSWORD`| Não    | Senha do proxy                                                          |
|`ROOM_MESSAGE`| Não    | Formato de exibição de mensagens de grupo do WeChat no BOT                                              |
|`OFFICIAL_MESSAGE`| Não    | Formato de exibição de mensagens de conta oficial no BOT                                              |
|`CONTACT_MESSAGE`| Não    | Formato de exibição de mensagens de usuário do WeChat no BOT                                             |
|`ROOM_MESSAGE_GROUP`| Não    | Formato de exibição de mensagens de grupo do WeChat em grupos                                                 |
|`CONTACT_MESSAGE_GROUP`| Não    | Formato de exibição de mensagens de usuário do WeChat em grupos                                                |
|`OFFICIAL_MESSAGE_GROUP`| Não    | Formato de exibição de mensagens de conta oficial em grupos                                                 |
|`CREATE_ROOM_NAME`| Não    | Formato do nome do grupo ao criar grupos do WeChat automaticamente                                           |
|`CREATE_CONTACT_NAME`| Não    | Formato do nome do grupo ao criar grupos de contatos do WeChat automaticamente                                         |
|`MESSAGE_DISPLAY`| Não    | Formato de exibição de mensagens de texto                                                      |

 ---

### Explicação do comando `/settings`

1. Mostrar emojis do WeChat como links de imagens: Ativando, os emojis enviados por amigos aparecerão como links de imagem

2. Sincronizar informações de grupo ao iniciar: Ativando, ao iniciar o programa todas as informações serão sincronizadas, incluindo avatar e nome do grupo

---

### Transcrição de Voz

1. Configure `TENCENT_SECRET_ID` e `TENCENT_SECRET_KEY`, disponível no [console de reconhecimento de voz da Tencent](https://console.cloud.tencent.com/asr). Há uma cota gratuita
2. Ative a função de transcrição automática de voz para texto em `/settings`

---

### Como obter `API_ID` e `API_HASH`

1. Acesse [telegram account](https://my.telegram.org/)

2. Clique em "API development tools" e preencha os dados do aplicativo (apenas título e nome curto são necessários)

3. Por fim, clique em "Create application"

---

### Modelos de mensagem personalizados

Se desejar alterar o formato do remetente da mensagem, modifique a variável de ambiente no docker ou o arquivo `.env`

Marcadores de modelo de mensagem personalizados:

`#[alias]`: Comentário do contato

`#[name]`: Apelido do contato

`#[topic]`: Nome do grupo

`#[alias_first]`: Prioridade para o comentário, se não houver, mostra o apelido

`#[identity]`: Texto de identidade

`#[body]`: Corpo da mensagem

`#[br]`: Nova linha

### Como @todos

Mensagens começando com `@all` vão mencionar todos, somente mensagens de texto suportam @todos

---

## Perguntas Frequentes

## Contribuindo

1. Faça um fork do projeto, troque para o branch `wx2tg-mac-dev` ou crie um novo branch. Não envie código diretamente para o branch principal
2. Envie Pull Request para o branch `wx2tg-mac-dev`

## Licença

[MIT](LICENSE)

## Agradecimentos

Agradecimento à Jetbrains pelo apoio a este projeto

[<img src="https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png" width="200">](https://www.jetbrains.com)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---