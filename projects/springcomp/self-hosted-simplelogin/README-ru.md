<div align="right">
  <details>
    <summary >🌐 Язык</summary>
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

Это самохостящийся docker-compose конфиг для [SimpleLogin](https://simplelogin.io).

## Необходимые условия

- сервер на Linux (виртуальная машина или выделенный сервер). В этом документе показана настройка для Ubuntu 18.04 LTS, но шаги могут быть адаптированы для других популярных дистрибутивов Linux. Поскольку большинство компонентов работают в контейнерах Docker, а Docker может быть довольно ресурсоёмким, рекомендуется минимум 2 ГБ оперативной памяти. Сервер должен иметь открытые порты 25 (электронная почта), 80, 443 (для веб-приложения), 22 (для ssh-подключения).


- домен, для которого вы можете настроить DNS. Это может быть поддомен. В остальной части документа допустим, что это `mydomain.com` для электронной почты и `app.mydomain.com` для веб-приложения SimpleLogin. Пожалуйста, убедитесь, что вы заменили эти значения на имя вашего домена и поддомена везде, где они встречаются в документе. Один из приёмов — скачать этот README файл на ваш компьютер и заменить все вхождения `mydomain.com` и `app.mydomain.com` на ваш домен.

За исключением настройки DNS, которая обычно выполняется через интерфейс вашего регистратора домена, все последующие шаги необходимо выполнять на вашем сервере. Команды следует запускать в `bash` (или любой совместимой оболочке, такой как `zsh`). Если вы используете другие оболочки, например `fish`, пожалуйста, адаптируйте команды соответственно.

- Некоторые утилиты, используемые для проверки настройки. Установите их с помощью:

```bash
sudo apt update \
  && sudo apt install -y net-tools dnsutils
```

## Настройка DNS

_Обратитесь к [референсной документации](https://github.com/springcomp/self-hosted-simplelogin/wiki/DNS-Configuration) для получения более подробной информации_

> **Обратите внимание**, что изменения в DNS могут распространяться до 24 часов. На практике это происходит гораздо быстрее (~1 минута или около того по нашим тестам). При настройке DNS мы обычно используем домен с точкой (`.`) на конце, чтобы принудительно использовать абсолютное доменное имя.

Вам потребуется настроить следующие DNS-записи:

- **A**: Привязывает ваш домен к IPv4-адресу вашего сервера.
- **AAAA**: Привязывает ваш домен к IPv6-адресу вашего сервера.
- **MX**: Направляет входящие письма на ваш почтовый сервер (включая подстановочные знаки `*`).
- **PTR**: Привязывает IP-адрес вашего сервера обратно к вашему доменному имени.

Настройте обязательные политики безопасности:

- **DKIM**: Цифровая подпись исходящих писем для подтверждения подлинности.
- **DMARC**: Определяет, как получатели электронной почты должны обрабатывать сообщения, не прошедшие аутентификацию.
- **SPF**: Авторизует определённые почтовые серверы для отправки писем от имени вашего домена.

Дополнительные шаги:

- **CAA**: Определяет, какие центры сертификации могут выдавать SSL-сертификаты для вашего домена.
- **MTA-STS**: Обеспечивает безопасное, зашифрованное соединение между почтовыми серверами.
- **TLS-RPT**: Отчёты о сбоях TLS-соединений для повышения безопасности доставки почты.

**Внимание**: настройка записи CAA ограничит, какой центр сертификации сможет успешно выдавать SSL-сертификаты для вашего домена.
Это предотвратит выпуск сертификатов с тестовых серверов Let’s Encrypt. Возможно, стоит отложить добавление этой записи до успешного выпуска SSL-сертификатов для вашего домена.

## Docker

Если у вас ещё не установлен Docker на сервере, пожалуйста, следуйте инструкциям на странице [Docker CE для Ubuntu](https://docs.docker.com/v17.12/install/linux/docker-ce/ubuntu/) для установки Docker.

Вы также можете установить Docker, используя скрипт [docker-install](https://github.com/docker/docker-install), который

```bash
curl -fsSL https://get.docker.com | sh
```

Включите IPv6 для [сети мост по умолчанию](https://docs.docker.com/config/daemon/ipv6/#use-ipv6-for-the-default-bridge-network)

```json
{
  "ipv6": true,
  "fixed-cidr-v6": "2001:db8:1::/64",
  "experimental": true,
  "ip6tables": true
}
```

Эта процедура поможет вам запустить весь стек с использованием Docker-контейнеров.
Это включает:

- traefik
- Контейнеры [SimpleLogin app](https://github.com/simple-login/app)
- postfix

Запуск SimpleLogin из Docker-контейнеров:

1. Клонируйте этот репозиторий в `/opt/simplelogin`
1. Скопируйте `.env.example` в `.env` и задайте соответствующие значения.

    - установите переменную `DOMAIN` на ваш домен.
    - установите переменную `SUBDOMAIN` на ваш домен. Значение по умолчанию — `app`.
    - установите переменную `POSTGRES_USER` в соответствии с учетными данными postgres (если вы начинаете с нуля, используйте `simplelogin`).
    - установите значение `POSTGRES_PASSWORD` в соответствии с учетными данными postgres (если вы начинаете с нуля, задайте случайный ключ).
    - установите значение `FLASK_SECRET` на произвольный секретный ключ.

### Postgres SQL

В этом репозитории запускается postgres SQL в Docker-контейнере.

**Внимание**: предыдущие версии этого репозитория использовали версию `12.1`.
Пожалуйста, обратитесь к [справочной документации](https://github.com/springcomp/self-hosted-simplelogin/wiki/PostgreSQL) для получения подробной информации и
инструкций по обновлению.

### Запуск приложения

Запустите приложение с помощью следующих команд:

```sh
docker compose up --detach --remove-orphans --build && docker compose logs -f
```

В этот момент вы можете настроить [Авторизацию Центра Сертификации (CAA)](https://github.com/springcomp/self-hosted-simplelogin/wiki/dns-caa).

## Следующие шаги

Если все вышеперечисленные шаги прошли успешно, откройте <https://app.mydomain.com/> и создайте свой первый аккаунт!

По умолчанию новые аккаунты не являются премиальными, поэтому не имеют неограниченных псевдонимов. Чтобы сделать ваш аккаунт премиальным,
перейдите в базу данных, таблицу "users" и установите значение столбца "lifetime" на "1" или "TRUE":

```bash
docker compose exec -it postgres psql -U myuser simplelogin
> UPDATE users SET lifetime = TRUE;
> \q
```

После того как вы создали все необходимые учетные записи для входа, добавьте эти строки в файл `.env`, чтобы запретить дальнейшую регистрацию:

```env
DISABLE_REGISTRATION=1
DISABLE_ONBOARDING=true
```

Затем, чтобы перезапустить веб-приложение, выполните: `docker compose restart app`

## Разное

### Конфигурация Postfix - Spamhaus

Проект Spamhaus поддерживает надежный список IP-адресов, известных как источники СПАМа.
Вы можете проверить, находится ли данный IP-адрес в этом списке, отправляя запросы в инфраструктуру DNS.

Поскольку Spamhaus блокирует запросы, поступающие от публичных (открытых) DNS-резолверов (см.: <https://check.spamhaus.org/returnc/pub>), а ваш контейнер postfix может использовать
публичный резолвер по умолчанию, рекомендуется зарегистрироваться для бесплатного
[Spamhaus Data Query Service](https://www.spamhaus.com/free-trial/sign-up-for-a-free-data-query-service-account/)
и получить ключ Spamhaus DQS.

Вставьте этот ключ как `SPAMHAUS_DQS_KEY` в ваш `.env`

Если DQS-ключ не предоставлен, ваш контейнер postfix проверит, принимают ли публичные зеркала Spamhaus его запросы, и будет использовать их вместо.
Если Spamhaus отклоняет запросы вашего контейнера postfix к публичным зеркалам, сервис будет полностью отключен.

### Конфигурация Postfix - Виртуальные алиасы

Конфигурация postfix поддерживает виртуальные алиасы с использованием файлов `postfix/conf.d/virtual` и `postfix/conf.d/virtual-regexp`.
Эти файлы автоматически создаются при запуске на основе соответствующих шаблонов [`postfix/templates/virtual.tpl`](https://raw.githubusercontent.com/springcomp/self-hosted-simplelogin/main/./postfix/templates/virtual.tpl)
и [`postfix/templates/virtual-regexp.tpl`](https://raw.githubusercontent.com/springcomp/self-hosted-simplelogin/main/./postfix/templates/virtual-regexp.tpl).

Конфигурация по умолчанию следующая:

#### virtual.tpl

Файл `virtual` поддерживает настройки postfix `virtual_alias_maps`.
Он включает правило, которое сопоставляет `unknown@mydomain.com` с `contact@mydomain.com`, чтобы продемонстрировать получение
и электронной почты с определенного адреса, который не соответствует существующему алиасу, на другой, который соответствует.

```postfix-conf
unknown@mydomain.com  contact@mydomain.com
```

#### virtual-regexp.tpl

Файл `virtual-regexp` поддерживает настройки postfix `virtual_alias_maps`.
Он включает правило, которое перенаправляет письма, адресованные на произвольный поддомен, который не соответствует
существующему алиасу, на новый алиас, принадлежащий каталогу, имя которого взято из поддомена.
Этот алиас может быть создан на лету, если он не существует.

```postfix-conf
/^([^@]+)@([^.]+)\.mydomain.com/   $2/$1@mydomain.com
```

Например, письма, отправленные на `someone@directory.mydomain.com`, будут перенаправлены postfix на `directory/someone@mydomain.com`.

## Как обновиться с версии 3.4.0

_Этот раздел был перенесён в [справочную документацию](https://github.com/springcomp/self-hosted-simplelogin/wiki/upgrade-sl)_

## Как обновиться с предыдущей конфигурации на базе NGinx

_Этот раздел был перенесён в [справочную документацию](https://github.com/springcomp/self-hosted-simplelogin/wiki/upgrade-from-nginx)_


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-15

---