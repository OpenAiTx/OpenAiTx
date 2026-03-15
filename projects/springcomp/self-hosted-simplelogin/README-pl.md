
<div align="right">
  <details>
    <summary >🌐 Język</summary>
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

To jest samodzielna konfiguracja docker-compose dla [SimpleLogin](https://simplelogin.io).

## Wymagania wstępne

- serwer z systemem Linux (może to być maszyna wirtualna lub serwer dedykowany). Ten dokument przedstawia konfigurację dla Ubuntu 18.04 LTS, ale kroki można dostosować do innych popularnych dystrybucji Linuksa. Ponieważ większość komponentów działa w kontenerach Dockera, a Docker może być dość zasobożerny, zaleca się co najmniej 2 GB RAM. Serwer musi mieć otwarte porty 25 (e-mail), 80, 443 (dla aplikacji webowej), 22 (aby móc połączyć się przez ssh).

- domena, dla której możesz skonfigurować DNS. Może to być subdomena. W dalszej części dokumentu załóżmy, że jest to `mydomain.com` dla poczty e-mail oraz `app.mydomain.com` dla aplikacji webowej SimpleLogin. Pamiętaj, aby za każdym razem, gdy pojawią się te wartości w dokumencie, zastąpić je swoją nazwą domeny i subdomeny. Sposób, którego używamy, to pobranie tego pliku README na komputer i zamiana wszystkich wystąpień `mydomain.com` oraz `app.mydomain.com` na Twoją domenę.

Poza konfiguracją DNS, która zwykle odbywa się w panelu rejestratora domeny, wszystkie poniższe kroki należy wykonać na swoim serwerze. Polecenia należy uruchamiać w powłoce `bash` (lub innej zgodnej z bash, jak `zsh`). Jeśli używasz innych powłok, np. `fish`, upewnij się, że odpowiednio dostosujesz polecenia.

- Niektóre pakiety narzędziowe wykorzystywane do weryfikacji konfiguracji. Zainstaluj je poleceniem:

```bash
sudo apt update \
  && sudo apt install -y net-tools dnsutils
```

## Konfiguracja DNS

_Zapoznaj się z [dokumentacją referencyjną](https://github.com/springcomp/self-hosted-simplelogin/wiki/DNS-Configuration) po więcej szczegółów_

> **Uwaga:** Zmiany w DNS mogą propagować się do 24 godzin. W praktyce jest to jednak dużo szybsze (~1 minuta w naszym teście). W konfiguracji DNS często używamy domeny z kropką (`.`) na końcu, by wymusić użycie domeny absolutnej.

Musisz ustawić następujące rekordy DNS:

- **A**: Mapuje Twoją domenę na adres IPv4 serwera.
- **AAAA**: Mapuje Twoją domenę na adres IPv6 serwera.
- **MX**: Kieruje przychodzące e-maile do Twojego serwera pocztowego (w tym także z `*` wildcardami).
- **PTR**: Mapuje adres IP Twojego serwera z powrotem na nazwę domeny.

Ustaw obowiązkowe polityki bezpieczeństwa:

- **DKIM**: Cyfrowo podpisuje wychodzące e-maile w celu weryfikacji autentyczności.
- **DMARC**: Określa jak odbiorcy powinni traktować wiadomości, które nie przeszły uwierzytelniania.
- **SPF**: Autoryzuje konkretne serwery pocztowe do wysyłania e-maili z Twojej domeny.

Dodatkowe kroki:

- **CAA**: Określa, które urzędy certyfikacji mogą wydawać certyfikaty SSL dla Twojej domeny.
- **MTA-STS**: Wymusza bezpieczne, szyfrowane połączenia między serwerami pocztowymi.
- **TLS-RPT**: Raportuje błędy połączeń TLS w celu zwiększenia bezpieczeństwa dostarczania e-maili.

**Ostrzeżenie**: ustawienie rekordu CAA ograniczy, który urząd certyfikacji może skutecznie wydać certyfikat SSL dla Twojej domeny.
To uniemożliwi wydanie certyfikatu przez serwery testowe Let’s Encrypt. Możesz chcieć odłożyć dodanie tego rekordu DNS do momentu, gdy certyfikaty SSL zostaną pomyślnie wydane dla Twojej domeny.

## Docker

Jeśli nie masz jeszcze zainstalowanego Dockera na swoim serwerze, wykonaj kroki z [Docker CE dla Ubuntu](https://docs.docker.com/v17.12/install/linux/docker-ce/ubuntu/), aby zainstalować Dockera.

Możesz również zainstalować Dockera używając skryptu [docker-install](https://github.com/docker/docker-install), który jest

```bash
curl -fsSL https://get.docker.com | sh
```

Włącz IPv6 dla [domyślnej sieci mostu](https://docs.docker.com/config/daemon/ipv6/#use-ipv6-for-the-default-bridge-network)

```json
{
  "ipv6": true,
  "fixed-cidr-v6": "2001:db8:1::/64",
  "experimental": true,
  "ip6tables": true
}
```

Ta procedura poprowadzi Cię przez uruchomienie całego stosu przy użyciu kontenerów Docker.
Obejmuje to:

- traefik
- Kontenery [aplikacji SimpleLogin](https://github.com/simple-login/app)
- postfix

Uruchom SimpleLogin z kontenerów Docker:

1. Sklonuj to repozytorium do `/opt/simplelogin`
1. Skopiuj `.env.example` do `.env` i ustaw odpowiednie wartości.

    - ustaw zmienną `DOMAIN` na swoją domenę.
    - ustaw zmienną `SUBDOMAIN` na swoją domenę. Domyślną wartością jest `app`.
    - ustaw zmienną `POSTGRES_USER` tak, aby pasowała do danych uwierzytelniających postgres (jeśli zaczynasz od zera, użyj `simplelogin`).
    - ustaw `POSTGRES_PASSWORD`, aby pasowało do danych uwierzytelniających postgres (jeśli zaczynasz od zera, ustaw losowy klucz).
    - ustaw `FLASK_SECRET` na dowolny klucz tajny.

### Postgres SQL

To repozytorium uruchamia postgres SQL w kontenerze Docker.

**Uwaga**: wcześniejsze wersje tego repozytorium używały wersji `12.1`.
Proszę, zapoznaj się z [dokumentacją referencyjną](https://github.com/springcomp/self-hosted-simplelogin/wiki/PostgreSQL) po więcej szczegółów oraz
instrukcje aktualizacji.

### Uruchamianie aplikacji

Uruchom aplikację, korzystając z poniższych poleceń:

```sh
docker compose up --detach --remove-orphans --build && docker compose logs -f
```

Na tym etapie możesz chcieć skonfigurować [Autoryzację Urzędu Certyfikacji (CAA)](https://github.com/springcomp/self-hosted-simplelogin/wiki/dns-caa).

## Kolejne kroki

Jeśli wszystkie powyższe kroki zakończyły się sukcesem, otwórz <https://app.mydomain.com/> i utwórz swoje pierwsze konto!

Domyślnie nowe konta nie są premium, więc nie mają nieograniczonej liczby aliasów. Aby uczynić swoje konto premium,
przejdź do bazy danych, tabeli "users" i ustaw kolumnę "lifetime" na "1" lub "TRUE":

```bash
docker compose exec -it postgres psql -U myuser simplelogin
> UPDATE users SET lifetime = TRUE;
> \q
```

Gdy już utworzysz wszystkie potrzebne konta logowania, dodaj te linie do `.env`, aby wyłączyć dalsze rejestracje:

```env
DISABLE_REGISTRATION=1
DISABLE_ONBOARDING=true
```

Następnie, aby ponownie uruchomić aplikację webową, zastosuj: `docker compose restart app`

## Różne

### Konfiguracja Postfix - Spamhaus

Projekt Spamhaus utrzymuje wiarygodną listę adresów IP znanych jako źródła SPAMu.
Możesz sprawdzić, czy dany adres IP znajduje się na tej liście, przesyłając zapytania do infrastruktury DNS.

Ponieważ Spamhaus blokuje zapytania pochodzące od publicznych (otwartych) resolverów DNS (zobacz: <https://check.spamhaus.org/returnc/pub>) i twój kontener postfix może domyślnie używać
publicznego resolvera, zaleca się zarejestrowanie w darmowej
[Spamhaus Data Query Service](https://www.spamhaus.com/free-trial/sign-up-for-a-free-data-query-service-account/)
i uzyskanie klucza Spamhaus DQS.

Wklej ten klucz jako `SPAMHAUS_DQS_KEY` do swojego `.env`

Jeśli nie zostanie podany klucz DQS, twój kontener postfix sprawdzi, czy publiczne mirrory Spamhaus akceptują jego zapytania i użyje ich zamiast tego.
Jeśli Spamhaus odrzuci zapytania z twojego kontenera postfix do publicznych mirrorów, zostanie to całkowicie wyłączone.

### Konfiguracja Postfix - Wirtualne aliasy

Konfiguracja postfix wspiera wirtualne aliasy za pomocą plików `postfix/conf.d/virtual` oraz `postfix/conf.d/virtual-regexp`.
Te pliki są automatycznie tworzone przy starcie na podstawie odpowiednich plików szablonów [`postfix/templates/virtual.tpl`](https://raw.githubusercontent.com/springcomp/self-hosted-simplelogin/main/./postfix/templates/virtual.tpl)
oraz [`postfix/templates/virtual-regexp.tpl`](https://raw.githubusercontent.com/springcomp/self-hosted-simplelogin/main/./postfix/templates/virtual-regexp.tpl).

Domyślna konfiguracja wygląda następująco:

#### virtual.tpl

Plik `virtual` obsługuje ustawienia postfix `virtual_alias_maps`.
Zawiera regułę mapującą `unknown@mydomain.com` na `contact@mydomain.com`, aby zademonstrować odbieranie
i wiadomości e-mail z konkretnego adresu, który nie odpowiada istniejącemu aliasowi, na inny, który odpowiada.

```postfix-conf
unknown@mydomain.com  contact@mydomain.com
```

#### virtual-regexp.tpl

Plik `virtual-regexp` obsługuje ustawienia `virtual_alias_maps` postfixa.
Zawiera regułę, która przepisuje wiadomości e-mail skierowane do dowolnej subdomeny, która nie odpowiada
istniejącemu aliasowi, na nowy alias należący do katalogu, którego nazwa jest pobierana z subdomeny.
Taki alias może zostać utworzony dynamicznie, jeśli nie istnieje.

```postfix-conf
/^([^@]+)@([^.]+)\.mydomain.com/   $2/$1@mydomain.com
```

Na przykład, e-maile wysłane na `someone@directory.mydomain.com` zostaną przekierowane przez postfix na `directory/someone@mydomain.com`.

## Jak zaktualizować z wersji 3.4.0

_Ten rozdział został przeniesiony do [dokumentacji referencyjnej](https://github.com/springcomp/self-hosted-simplelogin/wiki/upgrade-sl)_

## Jak zaktualizować z wcześniejszej konfiguracji opartej na NGinx

_Ten rozdział został przeniesiony do [dokumentacji referencyjnej](https://github.com/springcomp/self-hosted-simplelogin/wiki/upgrade-from-nginx)_


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-15

---