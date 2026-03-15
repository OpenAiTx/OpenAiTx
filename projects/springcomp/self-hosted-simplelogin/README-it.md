
<div align="right">
  <details>
    <summary >🌐 Lingua</summary>
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

Questa è una configurazione docker-compose self-hosted per [SimpleLogin](https://simplelogin.io).

## Prerequisiti

- un server Linux (sia una VM che un server dedicato). Questo documento mostra la configurazione per Ubuntu 18.04 LTS, ma i passaggi possono essere adattati per altre distribuzioni Linux popolari. Poiché la maggior parte dei componenti gira come container Docker e Docker può essere piuttosto pesante, si raccomanda di avere almeno 2 GB di RAM. Il server deve avere aperte le porte 25 (email), 80, 443 (per la webapp), 22 (per poter accedere via ssh).

- un dominio per il quale puoi configurare il DNS. Può anche essere un sottodominio. Nel resto del documento, supponiamo che sia `mydomain.com` per l'email e `app.mydomain.com` per la webapp SimpleLogin. Assicurati di sostituire questi valori con il nome del tuo dominio e sottodominio ogni volta che appaiono nel documento. Un trucco che usiamo è scaricare questo file README sul tuo computer e sostituire tutte le occorrenze di `mydomain.com` e `app.mydomain.com` con il tuo dominio.

Tranne che per la configurazione del DNS, che di solito viene eseguita tramite l'interfaccia del registrar del tuo dominio, tutti i passaggi seguenti devono essere eseguiti sul tuo server. I comandi devono essere eseguiti con `bash` (o qualsiasi shell compatibile con bash come `zsh`). Se utilizzi altre shell come `fish`, assicurati di adattare i comandi.

- Alcuni pacchetti di utilità utilizzati per verificare la configurazione. Installali tramite:

```bash
sudo apt update \
  && sudo apt install -y net-tools dnsutils
```

## Configurazione DNS

_Fai riferimento alla [documentazione di riferimento](https://github.com/springcomp/self-hosted-simplelogin/wiki/DNS-Configuration) per maggiori dettagli_

> **Nota bene** che le modifiche DNS possono richiedere fino a 24 ore per propagarsi. In pratica, tuttavia, è molto più veloce (~1 minuto circa nei nostri test). Nella configurazione DNS, di solito si utilizza il dominio con un punto finale (`.`) per forzare l'uso del dominio assoluto.

Dovrai configurare i seguenti record DNS:

- **A**: Mappa il tuo dominio all'indirizzo IPv4 del tuo server.
- **AAAA**: Mappa il tuo dominio all'indirizzo IPv6 del tuo server.
- **MX**: Indirizza le email in arrivo al tuo mail server (inclusi i caratteri jolly `*`).
- **PTR**: Mappa l'indirizzo IP del tuo server al nome del tuo dominio.

Configura le policy di sicurezza obbligatorie:

- **DKIM**: Firma digitalmente le email in uscita per verificare l'autenticità.
- **DMARC**: Definisce come i destinatari devono gestire i messaggi che falliscono l'autenticazione.
- **SPF**: Autorizza specifici mail server a inviare email dal tuo dominio.

Passaggi aggiuntivi:

- **CAA**: Specifica quali autorità di certificazione possono emettere certificati SSL per il tuo dominio.
- **MTA-STS**: Impone connessioni sicure e criptate tra mail server.
- **TLS-RPT**: Riporta i fallimenti di connessione TLS per migliorare la sicurezza nella consegna delle email.

**Attenzione**: la configurazione di un record CAA limiterà quali autorità di certificazione possono emettere certificati SSL per il tuo dominio.
Questo impedirà l'emissione di certificati dai server di staging di Let’s Encrypt. Potresti voler differire questo record DNS fino a quando i certificati SSL non saranno stati emessi correttamente per il tuo dominio.

## Docker

Se Docker non è già installato sul tuo server, segui i passaggi su [Docker CE per Ubuntu](https://docs.docker.com/v17.12/install/linux/docker-ce/ubuntu/) per installare Docker.

Puoi anche installare Docker utilizzando lo script [docker-install](https://github.com/docker/docker-install) che è

```bash
curl -fsSL https://get.docker.com | sh
```

Abilita IPv6 per [la rete bridge predefinita](https://docs.docker.com/config/daemon/ipv6/#use-ipv6-for-the-default-bridge-network)

```json
{
  "ipv6": true,
  "fixed-cidr-v6": "2001:db8:1::/64",
  "experimental": true,
  "ip6tables": true
}
```

Questa procedura ti guiderà nell'esecuzione dell'intero stack utilizzando i container Docker.
Questo include:

- traefik
- I container dell'[app SimpleLogin](https://github.com/simple-login/app)
- postfix

Esegui SimpleLogin dai container Docker:

1. Clona questo repository in `/opt/simplelogin`
1. Copia `.env.example` in `.env` e imposta i valori appropriati.

    - imposta la variabile `DOMAIN` sul tuo dominio.
    - imposta la variabile `SUBDOMAIN` sul tuo dominio. Il valore predefinito è `app`.
    - imposta la variabile `POSTGRES_USER` per corrispondere alle credenziali di postgres (se inizi da zero, usa `simplelogin`).
    - imposta `POSTGRES_PASSWORD` per corrispondere alle credenziali di postgres (se inizi da zero, imposta una chiave casuale).
    - imposta `FLASK_SECRET` su una chiave segreta arbitraria.

### Postgres SQL

Questo repository esegue un postgres SQL in un container Docker.

**Attenzione**: le versioni precedenti di questo repository utilizzavano la versione `12.1`.
Per favore, consulta la [documentazione di riferimento](https://github.com/springcomp/self-hosted-simplelogin/wiki/PostgreSQL) per maggiori dettagli e
istruzioni di aggiornamento.

### Avvio dell'applicazione

Esegui l'applicazione utilizzando i seguenti comandi:

```sh
docker compose up --detach --remove-orphans --build && docker compose logs -f
```

A questo punto potresti voler configurare la [Certificate Authority Authorization (CAA)](https://github.com/springcomp/self-hosted-simplelogin/wiki/dns-caa).

## Prossimi passi

Se tutti i passaggi precedenti sono stati completati con successo, apri <https://app.mydomain.com/> e crea il tuo primo account!

Per impostazione predefinita, i nuovi account non sono premium e quindi non hanno alias illimitati. Per rendere il tuo account premium,
vai al database, tabella "users" e imposta la colonna "lifetime" su "1" o "TRUE":

```bash
docker compose exec -it postgres psql -U myuser simplelogin
> UPDATE users SET lifetime = TRUE;
> \q
```

Una volta creati tutti gli account di accesso desiderati, aggiungi queste righe a `.env` per disabilitare ulteriori registrazioni:

```env
DISABLE_REGISTRATION=1
DISABLE_ONBOARDING=true
```

Quindi, per riavviare l'app web, applica: `docker compose restart app`

## Varie

### Configurazione Postfix - Spamhaus

Il progetto Spamhaus mantiene un elenco affidabile di indirizzi IP noti come sorgente di SPAM.
Puoi verificare se un determinato indirizzo IP è presente in quell'elenco inviando richieste all'infrastruttura DNS.

Poiché Spamhaus blocca le richieste provenienti da resolver DNS pubblici (open) (vedi: <https://check.spamhaus.org/returnc/pub>) e il tuo container postfix potrebbe usare
un resolver pubblico di default, si consiglia di registrarsi per il servizio gratuito
[Spamhaus Data Query Service](https://www.spamhaus.com/free-trial/sign-up-for-a-free-data-query-service-account/)
e ottenere una chiave Spamhaus DQS.

Incolla questa chiave come `SPAMHAUS_DQS_KEY` nel tuo file `.env`

Se non viene fornita una chiave DQS, il tuo container postfix controllerà se i mirror pubblici di Spamhaus accettano le sue richieste e li utilizzerà in alternativa.
Se Spamhaus rifiuta le richieste dal tuo container postfix ai mirror pubblici, verrà disabilitato completamente.

### Configurazione Postfix - Alias virtuali

La configurazione di postfix supporta alias virtuali tramite i file `postfix/conf.d/virtual` e `postfix/conf.d/virtual-regexp`.
Questi file vengono creati automaticamente all'avvio in base ai rispettivi file modello [`postfix/templates/virtual.tpl`](https://raw.githubusercontent.com/springcomp/self-hosted-simplelogin/main/./postfix/templates/virtual.tpl)
e [`postfix/templates/virtual-regexp.tpl`](https://raw.githubusercontent.com/springcomp/self-hosted-simplelogin/main/./postfix/templates/virtual-regexp.tpl).

La configurazione predefinita è la seguente:

#### virtual.tpl

Il file `virtual` supporta le impostazioni `virtual_alias_maps` di postfix.
Include una regola che mappa `unknown@mydomain.com` su `contact@mydomain.com` per dimostrare la ricezione
di un'email da un indirizzo specifico che non corrisponde a un alias esistente, su un altro che invece esiste.

```postfix-conf
unknown@mydomain.com  contact@mydomain.com
```

#### virtual-regexp.tpl

Il file `virtual-regexp` supporta le impostazioni `virtual_alias_maps` di postfix.
Include una regola che riscrive le email indirizzate a un sottodominio arbitrario, che non corrisponde
a un alias esistente, verso un nuovo alias che appartiene a una directory il cui nome è preso dal sottodominio.
Quell'alias può essere creato al volo se non esiste.

```postfix-conf
/^([^@]+)@([^.]+)\.mydomain.com/   $2/$1@mydomain.com
```

Ad esempio, le email inviate a `someone@directory.mydomain.com` saranno indirizzate a `directory/someone@mydomain.com` da postfix.

## Come aggiornare dalla versione 3.4.0

_Questa sezione è stata spostata nella [documentazione di riferimento](https://github.com/springcomp/self-hosted-simplelogin/wiki/upgrade-sl)_

## Come aggiornare dalla precedente configurazione basata su NGinx

_Questa sezione è stata spostata nella [documentazione di riferimento](https://github.com/springcomp/self-hosted-simplelogin/wiki/upgrade-from-nginx)_


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-15

---