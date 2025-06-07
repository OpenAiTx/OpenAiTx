# mimotion
![刷步数](https://github.com/xunichanghuan/mimotion-run/actions/workflows/run.yml/badge.svg)
[![GitHub forks](https://img.shields.io/github/forks/xunichanghuan/mimotion-run?style=flat-square)](https://github.com/xunichanghuan/mimotion-run/network)
[![GitHub stars](https://img.shields.io/github/stars/xunichanghuan/mimotion-run?style=flat-square)](https://github.com/xunichanghuan/mimotion-run/stargazers)
[![GitHub issues](https://img.shields.io/github/issues/xunichanghuan/mimotion-run?style=flat-square)](https://github.com/xunichanghuan/mimotion-run/issues)

# Автоматическая накрутка шагов для Mi Fit

> Автоматическая накрутка шагов для Mi Fit

## Руководство по развертыванию с помощью Github Actions

### 1. Форкните этот репозиторий

### 2. Настройте аккаунт и пароль
# Добавлено 20230224
Добавьте переменную с именем **CONFIG**: Settings-->Secrets-->New secret, настройте несколько аккаунтов с помощью следующего шаблона json, поддерживаются email, номер телефона
```
{
  "TG_BOT_TOKEN": "telegram TG_BOT_TOKEN, если нет — оставьте пустым",
  "TG_USER_ID": "telegram TG_USER_ID, если нет — оставьте пустым",
  "SKEY": "Ключ от 酷推, если нет — оставьте пустым",
  "SCKEY": "Ключ server酱, если нет — оставьте пустым",
  "POSITION": "Включить ли отправку в корпоративный WeChat, если нет — оставьте пустым",
  "CORPID": "ID компании, войдите в корпоративный WeChat, см. Моя компания-->Информация о компании, если нет — оставьте пустым",
  "CORPSECRET": "Секрет для собственного приложения в корпоративном WeChat, у каждого приложения свой secret, если нет — оставьте пустым",
  "AGENTID": "ID собственного приложения в корпоративном WeChat, без кавычек, целое число (AgentId), если нет — оставьте пустым",
  "TOUSER": "Список ID участников, получающих сообщения (несколько получателей разделяйте символом ”&#166;”, максимум 1000). Особый случай: если указано ”@all”, то сообщение отправится всем участникам данного приложения. Если нет — оставьте пустым",
  "TOPARTY": "ID отделов, получающих сообщения, несколько — через ”&#166;”, максимум 100. Если touser — ”@all”, укажите ”@all”, если нет — оставьте пустым",
  "TOTAG": "ID тегов, получающих сообщения, несколько — через ”&#166;”, максимум 100. Если touser — ”@all”, укажите ”@all”, если нет — оставьте пустым",
  "OPEN_GET_WEATHER": "Включить снижение шагов в зависимости от погоды, если нет — оставьте пустым",
  "AREA": "Регион для получения погоды (обязательно при включении выше), например, Пекин, если нет — оставьте пустым",
  "QWEATHER": "Здесь введите Private KEY от HeWeather, получить по адресу https://console.qweather.com/#/apps, если нет — оставьте пустым",
  "MIMOTION": [
    {
      "max_step": "20000",
      "min_step": "10000",
      "password": "Sitoi",
      "user": "18888xxxxxx"
    },
    {
      "max_step": "Укажите максимальное количество шагов для второго аккаунта, см. выше",
      "min_step": "Укажите минимальное количество шагов для второго аккаунта, см. выше",
      "password": "Пароль для второго аккаунта, см. выше",
      "user": "Телефон для второго аккаунта, см. выше"
    }
  ]
}
```
> Добавьте переменную с именем **PAT**: Settings-->Secrets-->New secret

| Secrets |  Формат  |
| ------- | ------- |
| PAT     |   Здесь необходимо получить **PAT**, значение — github token, инструкция: https://www.jianshu.com/p/bb82b3ad1d11 , требуются права repo и workflow, ОБЯЗАТЕЛЬНО, чтобы избежать ошибок при git push. |

**Пример CONFIG**
```
{
  "TG_BOT_TOKEN": "",
  "TG_USER_ID": "",
  "SKEY": "",
  "SCKEY": "",
  "POSITION": "",
  "CORPID": "",
  "CORPSECRET": "",
  "AGENTID": "",
  "TOUSER": "",
  "TOPARTY": "",
  "TOTAG": "",
  "OPEN_GET_WEATHER": "",
  "AREA": "",
  "QWEATHER": "",
  "MIMOTION": [
    {
      "max_step": "20000",
      "min_step": "10000",
      "password": "Sitoi",
      "user": "18888xxxxxx"
    },
    {
      "max_step": "Укажите максимальное количество шагов для второго аккаунта, см. выше",
      "min_step": "Укажите минимальное количество шагов для второго аккаунта, см. выше",
      "password": "Пароль для второго аккаунта, см. выше",
      "user": "Телефон для второго аккаунта, см. выше"
    }
  ]
}
```

### 3. Настройка времени запуска

Редактируйте **random_cron.sh**
Измените время в условии **if** на UTC, то есть **Пекинское время минус 8**. Например, 8:00 по Пекину — это 0:00 по UTC, нужное время запуска -8 и получите время UTC



## Важные замечания

1. Запуск происходит семь раз в день, управляется random_cron.sh, минуты выбираются случайным образом

2. Количество аккаунтов и паролей должны совпадать, иначе не будет работать!!!

3. Время запуска должно быть в UTC!

4. Регистрация на server酱 [по ссылке](https://sct.ftqq.com/)

5. Если шаги не обновляются в Alipay, перейдите в Mi Fit->Настройки->Аккаунт->Выйти из аккаунта->Очистить данные, затем заново войдите и повторно привяжите сторонние сервисы

6. Mi Fit не обновляет шаги, только связанные сервисы синхронизируют шаги!!!!!!

7. Используйте Fork [основной ветки](https://github.com/xunichanghuan/mimotion-run/), чтобы избежать ненужных ошибок.

8. Обратите внимание, что аккаунт — это не [Mi аккаунт], а аккаунт [Mi Fit].

## Историческое количество звезд

[![Stargazers over time](https://starchart.cc/xunichanghuan/mimotion-run.svg)](https://starchart.cc/xunichanghuan/mimotion-run)

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx) - 2025-06-07

---