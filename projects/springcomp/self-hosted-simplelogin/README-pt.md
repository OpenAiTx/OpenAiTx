
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# SimpleLogin

Esta é uma configuração auto-hospedada do docker-compose para o [SimpleLogin](https://simplelogin.io).

## Pré-requisitos

- um servidor Linux (pode ser uma VM ou servidor dedicado). Este documento mostra a configuração para Ubuntu 18.04 LTS, mas os passos podem ser adaptados para outras distribuições populares de Linux. Como a maioria dos componentes roda em container Docker e o Docker pode ser um pouco pesado, recomenda-se pelo menos 2 GB de RAM. O servidor precisa ter as portas 25 (e-mail), 80, 443 (para o webapp), 22 (para acesso SSH) abertas.

- um domínio para o qual você pode configurar o DNS. Pode ser um subdomínio. No restante deste documento, vamos usar `mydomain.com` para o email e `app.mydomain.com` para o SimpleLogin webapp. Certifique-se de substituir esses valores pelo nome do seu domínio e subdomínio sempre que aparecerem no documento. Uma dica que usamos é baixar este arquivo README no seu computador e substituir todas as ocorrências de `mydomain.com` e `app.mydomain.com` pelo seu domínio.

Exceto pela configuração do DNS, que normalmente é feita na interface do registrador do domínio, todas as etapas abaixo devem ser realizadas no seu servidor. Os comandos devem ser executados com `bash` (ou qualquer shell compatível com bash, como `zsh`) sendo o shell. Se você usar outros shells como `fish`, certifique-se de adaptar os comandos.

- Alguns pacotes utilitários usados para verificar a configuração. Instale-os com:

```bash
sudo apt update \
  && sudo apt install -y net-tools dnsutils
```

## Configuração de DNS

_Consulte a [documentação de referência](https://github.com/springcomp/self-hosted-simplelogin/wiki/DNS-Configuration) para mais detalhes_

> **Atenção:** alterações de DNS podem levar até 24 horas para se propagarem. Na prática, costuma ser bem mais rápido (~1 minuto em nossos testes). Na configuração de DNS, normalmente usamos o domínio com um ponto final (`.`) para forçar o uso do domínio absoluto.

Você precisará configurar os seguintes registros DNS:

- **A**: Mapeia seu domínio para o endereço IPv4 do seu servidor.
- **AAAA**: Mapeia seu domínio para o endereço IPv6 do seu servidor.
- **MX**: Direciona os e-mails recebidos para seu servidor de e-mail (incluindo curingas `*`).
- **PTR**: Mapeia o endereço IP do seu servidor de volta para o nome do domínio.

Configure as políticas de segurança obrigatórias:

- **DKIM**: Assina digitalmente e-mails enviados para verificar sua autenticidade.
- **DMARC**: Define como os destinatários devem tratar mensagens que falharem na autenticação.
- **SPF**: Autoriza servidores de e-mail específicos a enviar e-mails em nome do seu domínio.

Passos adicionais:

- **CAA**: Especifica quais autoridades certificadoras podem emitir certificados SSL para seu domínio.
- **MTA-STS**: Impõe conexões seguras e criptografadas entre servidores de e-mail.
- **TLS-RPT**: Relata falhas de conexão TLS para melhorar a segurança na entrega de e-mails.

**Atenção:** configurar um registro CAA irá restringir quais autoridades certificadoras podem emitir certificados SSL para seu domínio.
Isso impedirá a emissão de certificados pelos servidores de testes do Let’s Encrypt. Você pode adiar esse registro DNS até que os certificados SSL tenham sido emitidos com sucesso para seu domínio.

## Docker

Se você ainda não tem o Docker instalado em seu servidor, siga as etapas em [Docker CE para Ubuntu](https://docs.docker.com/v17.12/install/linux/docker-ce/ubuntu/) para instalar o Docker.

Você também pode instalar o Docker usando o script [docker-install](https://github.com/docker/docker-install) que é

```bash
curl -fsSL https://get.docker.com | sh
```

Habilite IPv6 para [a rede bridge padrão](https://docs.docker.com/config/daemon/ipv6/#use-ipv6-for-the-default-bridge-network)

```json
{
  "ipv6": true,
  "fixed-cidr-v6": "2001:db8:1::/64",
  "experimental": true,
  "ip6tables": true
}
```

Este procedimento irá guiá-lo na execução de toda a stack usando containers Docker.
Isso inclui:

- traefik
- Os containers do [SimpleLogin app](https://github.com/simple-login/app)
- postfix

Execute o SimpleLogin a partir de containers Docker:

1. Clone este repositório em `/opt/simplelogin`
1. Copie `.env.example` para `.env` e defina os valores apropriados.

    - defina a variável `DOMAIN` para o seu domínio.
    - defina a variável `SUBDOMAIN` para o seu domínio. O valor padrão é `app`.
    - defina a variável `POSTGRES_USER` para corresponder às credenciais do postgres (ao iniciar do zero, use `simplelogin`).
    - defina o `POSTGRES_PASSWORD` para corresponder às credenciais do postgres (ao iniciar do zero, defina uma chave aleatória).
    - defina o `FLASK_SECRET` para uma chave secreta arbitrária.

### Postgres SQL

Este repositório executa um postgres SQL em um container Docker.

**Atenção**: versões anteriores deste repositório utilizavam a versão `12.1`.
Por favor, consulte a [documentação de referência](https://github.com/springcomp/self-hosted-simplelogin/wiki/PostgreSQL) para mais detalhes e
instruções de atualização.

### Executando o aplicativo

Execute o aplicativo utilizando os seguintes comandos:

```sh
docker compose up --detach --remove-orphans --build && docker compose logs -f
```

Você pode querer configurar a [Autorização de Autoridade Certificadora (CAA)](https://github.com/springcomp/self-hosted-simplelogin/wiki/dns-caa) neste ponto.

## Próximos passos

Se todas as etapas acima forem bem-sucedidas, abra <https://app.mydomain.com/> e crie sua primeira conta!

Por padrão, novas contas não são premium e, portanto, não têm aliases ilimitados. Para tornar sua conta premium,
acesse o banco de dados, tabela "users" e defina a coluna "lifetime" como "1" ou "TRUE":

```bash
docker compose exec -it postgres psql -U myuser simplelogin
> UPDATE users SET lifetime = TRUE;
> \q
```

Depois de criar todas as contas de login desejadas, adicione estas linhas ao `.env` para desabilitar novos registros:

```env
DISABLE_REGISTRATION=1
DISABLE_ONBOARDING=true
```
Em seguida, para reiniciar o aplicativo web, aplique: `docker compose restart app`

## Diversos

### Configuração do Postfix - Spamhaus

O Projeto Spamhaus mantém uma lista confiável de endereços IP conhecidos por serem fonte de SPAM.
Você pode verificar se um determinado endereço IP está nessa lista enviando consultas para a infraestrutura DNS.

Como o Spamhaus bloqueia consultas provenientes de resolvedores DNS públicos (abertos) (veja: <https://check.spamhaus.org/returnc/pub>) e seu contêiner postfix pode usar
um resolvedor público por padrão, é recomendável cadastrar-se para o
[Spamhaus Data Query Service](https://www.spamhaus.com/free-trial/sign-up-for-a-free-data-query-service-account/)
gratuito e obter uma chave Spamhaus DQS.

Cole essa chave como `SPAMHAUS_DQS_KEY` em seu `.env`

Se nenhuma chave DQS for fornecida, seu contêiner postfix verificará se os espelhos públicos do Spamhaus estão aceitando suas consultas e os usará em vez disso.
Se o Spamhaus rejeitar consultas do seu contêiner postfix para os espelhos públicos, será totalmente desativado.

### Configuração do Postfix - Aliases virtuais

A configuração do postfix suporta aliases virtuais usando os arquivos `postfix/conf.d/virtual` e `postfix/conf.d/virtual-regexp`.
Esses arquivos são criados automaticamente na inicialização com base nos arquivos de modelo correspondentes [`postfix/templates/virtual.tpl`](https://raw.githubusercontent.com/springcomp/self-hosted-simplelogin/main/./postfix/templates/virtual.tpl)
e [`postfix/templates/virtual-regexp.tpl`](https://raw.githubusercontent.com/springcomp/self-hosted-simplelogin/main/./postfix/templates/virtual-regexp.tpl).

A configuração padrão é a seguinte:

#### virtual.tpl

O arquivo `virtual` suporta as configurações de `virtual_alias_maps` do postfix.
Ele inclui uma regra que mapeia `unknown@mydomain.com` para `contact@mydomain.com` para demonstrar o recebimento
de um e-mail de um endereço específico que não corresponde a um alias existente para outro que corresponde.


```postfix-conf
unknown@mydomain.com  contact@mydomain.com
```

#### virtual-regexp.tpl

O arquivo `virtual-regexp` suporta configurações de `virtual_alias_maps` do postfix.
Ele inclui uma regra que reescreve e-mails endereçados a um subdomínio arbitrário, que não corresponde
a um alias existente, para um novo alias que pertence a um diretório cujo nome é retirado do subdomínio.
Esse alias pode ser criado dinamicamente caso não exista.

```postfix-conf
/^([^@]+)@([^.]+)\.mydomain.com/   $2/$1@mydomain.com
```

Por exemplo, emails enviados para `someone@directory.mydomain.com` serão encaminhados para `directory/someone@mydomain.com` pelo postfix.

## Como atualizar a partir da versão 3.4.0

_Esta seção foi movida para a [documentação de referência](https://github.com/springcomp/self-hosted-simplelogin/wiki/upgrade-sl)_

## Como atualizar a partir de uma configuração anterior baseada em NGinx

_Esta seção foi movida para a [documentação de referência](https://github.com/springcomp/self-hosted-simplelogin/wiki/upgrade-from-nginx)_


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-15

---