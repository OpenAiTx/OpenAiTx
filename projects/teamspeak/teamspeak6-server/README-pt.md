# TeamSpeak 6 Server - Beta Release README

Bem-vindo à versão Beta do TeamSpeak 6 Server! Estamos animados por tê-lo a bordo enquanto você explora a próxima geração do TeamSpeak. Este documento irá guiá-lo no início e destacar detalhes importantes sobre o Beta atual.

Como esta é uma versão Beta, alguns recursos ainda estão em desenvolvimento e você pode encontrar bugs. Seu feedback é importante e nos ajudará a criar uma versão final mais estável e completa.

<h2><img width="24" src="/icons/teamspeak_blue.svg">&nbsp;Sobre o TeamSpeak</h2>

Testado e comprovado por quase 25 anos, temos uma solução que atende às necessidades de todos. O TeamSpeak oferece a comunicação de voz ideal para jogos, educação e treinamento, comunicação empresarial interna e para manter contato com amigos e familiares. Nosso foco principal é fornecer uma solução fácil de usar, com altos padrões de segurança, excelente qualidade de voz e baixo uso de sistema e banda.

## ℹ️ Status Beta & Problemas Conhecidos
**Esta é uma versão beta. O principal objetivo é coletar feedback diversificado e identificar possíveis problemas antes do lançamento da versão estável.**

**Arquivos de Servidor Auto-Hospedado:** O software de servidor dedicado do TeamSpeak 6 ainda está em desenvolvimento ativo e ainda não possui todos os recursos. Estamos comprometidos em entregar a experiência completa do TS6 para servidores auto-hospedados.

**Instabilidade de Recursos:** Alguns dos novos recursos podem estar instáveis ou sujeitos a alterações enquanto continuamos a refiná-los.

**Feedback é Essencial:** Sua experiência é inestimável e sua opinião é crucial para nós. Por favor, relate quaisquer problemas ou compartilhe suas sugestões em nosso [Fórum da Comunidade](https://community.teamspeak.com/c/teamspeak-6-server/45) ou diretamente aqui no [GitHub](https://github.com/teamspeak/teamspeak6-server/issues).

**Limitações:** Por favor, note que **as licenças do TeamSpeak 3 Server não são compatíveis** com os Servidores TeamSpeak 6 e, atualmente, **não há caminho de migração disponível entre as duas versões**.

**Licença de Prévia:** Em resposta ao seu feedback, o servidor agora vem com uma licença de prévia **temporária** de 32 slots para oferecer maior flexibilidade durante o período de avaliação. Note que esta licença é **válida por apenas dois meses**.

Além disso, **ainda não é possível obter ou fazer upgrade para uma licença maior do TeamSpeak 6**.

Agradecemos sinceramente sua paciência e compreensão enquanto continuamos trabalhando em soluções para melhor atender suas necessidades no futuro.

## 👇 Primeiros Passos com o TS6
Para começar com o TeamSpeak 6 Client, acesse nossa página de [Downloads](https://teamspeak.com/en/downloads/).

Para informações sobre auto-hospedagem, consulte o breve guia abaixo. Para as últimas atualizações, anúncios e para interagir com a comunidade TeamSpeak, não deixe de visitar nosso [Fórum da Comunidade](https://community.teamspeak.com/) e nos seguir no [Twitter](https://x.com/teamspeak).

Não quer auto-hospedar ou simplesmente precisa de uma maneira mais fácil de começar com o TeamSpeak 6? Você pode alugar Servidores Oficiais e Confiáveis do TeamSpeak 6 diretamente conosco em [TeamSpeak Communities](https://www.myteamspeak.com/communities).
## ⚙️ Configuração
### Você pode configurar seu servidor de três maneiras principais:

1. **Argumentos de Linha de Comando:** Passe opções diretamente ao iniciar o servidor (ex.: ./tsserver --default-voice-port 9987). Isto é útil para mudanças temporárias ou para scripting.

2. **Variáveis de Ambiente:** Defina variáveis de ambiente antes de iniciar o servidor. Isto é útil para Docker ou quando você quer evitar poluição na linha de comando.

3. **Arquivo de Configuração YAML:** Para uma configuração persistente, é altamente recomendado usar um arquivo tsserver.yaml. Você pode gerar um arquivo de configuração padrão usando a flag --write-config-file.

As principais configurações que você pode controlar incluem portas de rede (voz, transferência de arquivos), conexões de banco de dados (compatível com SQLite e MariaDB), binds de IP e opções de logging.

Para uma lista completa de opções disponíveis, execute o servidor com a flag `--help` ou consulte o [CONFIG.md](https://raw.githubusercontent.com/teamspeak/teamspeak6-server/main/CONFIG.md).

### Executando o Servidor com Binários
Se você não estiver usando Docker, pode executar o servidor diretamente no seu sistema operacional.

<h2><img width="22" src="/icons/linux.svg">&nbsp;No Linux:</h2>

Torne o binário do servidor executável:
```sh
chmod +x tsserver
```

Execute o servidor a partir do seu terminal, certificando-se de aceitar a licença:

```sh
./tsserver --accept-license
```

<h2><img width="22" src="/icons/windows.svg">&nbsp;No Windows:</h2>

Abra o Prompt de Comando ou o PowerShell e navegue até o diretório onde você extraiu os arquivos do servidor.

Execute o executável do servidor, certificando-se de aceitar a licença:
```powershell
tsserver.exe
```

<h2><img width="32" src="/icons/docker.svg">&nbsp;Executando o Servidor com Docker (Recomendado):</h2>
Docker é a maneira mais fácil de executar o servidor TeamSpeak 6 em um ambiente isolado e gerenciável.

### 1. Comando simples de docker run:

Para um início rápido, você pode usar o comando docker run.

```sh
docker run -it --rm \
  -p 9987:9987/udp \
  -p 30033:30033 \
  -e TSSERVER_LICENSE_ACCEPTED=accept \
  teamspeaksystems/teamspeak6-server:latest
```

### 2. Usando docker-compose.yaml (para instalações persistentes):
Esta é a melhor prática para um servidor que você pretende manter rodando. Crie um arquivo docker-compose.yaml:

```yaml
services:
  teamspeak:
    image: teamspeaksystems/teamspeak6-server:latest
    container_name: teamspeak-server
    restart: unless-stopped
    ports:
      - "9987:9987/udp"   # Porta de Voz
      - "30033:30033/tcp" # Transferência de Arquivos
      # - "10080:10080/tcp" # Web Query
    environment:
```
      - TSSERVER_LICENSE_ACCEPTED=accept
    volumes:
      - teamspeak-data:/var/tsserver/

volumes:
  teamspeak-data:
```

## 🔗 Links Úteis
[Site Oficial](https://teamspeak.com/en/)<br>
[Fórum da Comunidade](https://community.teamspeak.com)<br>
[Problemas no GitHub](https://github.com/teamspeak/teamspeak6-server/issues)<br>

Sua participação e feedback nos ajudarão a moldar o futuro do TeamSpeak! 💙<br>
Obrigado por fazer parte do programa Beta do TeamSpeak 6 e por contribuir para o seu progresso! 🫡

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---