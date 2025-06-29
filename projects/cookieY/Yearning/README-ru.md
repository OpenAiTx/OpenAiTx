<div align="center">

<h1 style="border-bottom: none">
    <b><a href="https://next.yearning.io">Yearning</a></b><br />
</h1>
</div>

 Надежная, локально развёрнутая платформа, предназначенная для бесшовного обнаружения SQL и аудита запросов, специально разработанная для DBA и разработчиков. Ориентированная на конфиденциальность и эффективность, она предоставляет интуитивно понятную и безопасную среду для аудита MYSQL.

---
[![OSCS Status](https://www.oscs1024.com/platform/badge/cookieY/Yearning.svg?size=small)](https://www.murphysec.com/dr/nDuoncnUbuFMdrZsh7)
![Platform Support](https://img.shields.io/badge/-x86_x64%20ARM%20Supports%20%E2%86%92-rgb(84,56,255)?style=flat-square&logoColor=white&logo=linux)
[![][github-license-shield]][github-license-link]
![GitHub top language](https://img.shields.io/github/languages/top/cookieY/Yearning?color=369eff&label=golang&labelColor=black&logo=golang&logoColor=white&style=flat-square)
[![][github-forks-shield]][github-forks-link]
[![][github-stars-shield]][github-stars-link]
[![Downloads](https://img.shields.io/github/downloads/cookieY/Yearning/total?labelColor=black&logo=download&logoColor=white&style=flat-square)](https://github.com/cookieY/Yearning/releases/latest)

English | [简体中文](https://raw.githubusercontent.com/cookieY/Yearning/next/README.zh-CN.md) | [日本語](https://raw.githubusercontent.com/cookieY/Yearning/next/README.ja-JP.md)

## ✨ Возможности

- **AI-ассистент**: Наш AI-ассистент предлагает рекомендации по оптимизации SQL в реальном времени, улучшая производительность SQL. Также поддерживается преобразование текста в SQL, позволяя пользователям вводить текст на естественном языке и получать оптимизированные SQL-запросы.
  
- **Аудит SQL**: Создавайте тикеты аудита SQL с процессами согласования и автоматической проверкой синтаксиса. Проверяйте корректность, безопасность и соответствие SQL-запросов. Откатные операторы автоматически генерируются для DDL/DML-операций с подробным журналом истории для отслеживаемости.

- **Аудит запросов**: Аудит пользовательских запросов, ограничение источников данных и баз данных, анонимизация чувствительных полей. Записи запросов сохраняются для последующего использования.

- **Проверочные правила**: Наш автоматический синтаксический проверяющий поддерживает широкий спектр проверочных правил, подходящих для большинства сценариев автоматической проверки.

- **Ориентированность на конфиденциальность**: Yearning — это развёртываемое локально решение с открытым исходным кодом, которое обеспечивает безопасность вашей базы данных и SQL-запросов. Включает механизмы шифрования для защиты чувствительных данных, гарантируя их сохранность даже при несанкционированном доступе.

- **RBAC (Управление доступом на основе ролей)**: Создавайте и управляйте ролями с определёнными разрешениями, ограничивая доступ к заявкам на запросы, функциям аудита и другим чувствительным операциям в зависимости от ролей пользователей.

> \[!TIP]
> Для получения более подробной информации посетите наш [Yearning Guide](https://next.yearning.io)


## ⚙️ Установка

Скачайте [последний релиз](https://github.com/cookieY/Yearning/releases/latest) и распакуйте его. Перед запуском убедитесь, что настроили `./config.toml`.

### Ручная установка

```bash
## Инициализация базы данных
./Yearning install

## Запуск Yearning
./Yearning run

## Помощь
./Yearning --help
```

### 🚀 Развёртывание с помощью Docker
[![][docker-release-shield]][docker-release-link]
[![][docker-size-shield]][docker-size-link]
[![][docker-pulls-shield]][docker-pulls-link]
```bash
## Инициализация базы данных
docker run --rm -it -p8000:8000 -e SECRET_KEY=$SECRET_KEY -e MYSQL_USER=$MYSQL_USER -e MYSQL_ADDR=$MYSQL_ADDR -e MYSQL_PASSWORD=$MYSQL_PASSWORD -e MYSQL_DB=$Yearning_DB -e Y_LANG=zh_CN yeelabs/yearning "/opt/Yearning install"

## Запуск Yearning
docker run -d -it -p8000:8000 -e SECRET_KEY=$SECRET_KEY -e MYSQL_USER=$MYSQL_USER -e MYSQL_ADDR=$MYSQL_ADDR -e MYSQL_PASSWORD=$MYSQL_PASSWORD -e MYSQL_DB=$Yearning_DB -e Y_LANG=zh_CN yeelabs/yearning
```
## 🤖 AI-помощник

Наш AI-ассистент использует большую языковую модель для предоставления рекомендаций по оптимизации SQL и преобразования текста в SQL. Независимо от того, используются ли стандартные или пользовательские подсказки, AI-ассистент повышает производительность SQL за счёт оптимизации запросов и преобразования естественного языка в SQL-запросы.

![Text to SQL](https://raw.githubusercontent.com/cookieY/Yearning/next/img/text2sql.jpg)

## 🔖 Автоматическая проверка SQL

Автоматический проверяющий SQL оценивает запросы по заранее определённым правилам и синтаксису. Он гарантирует соответствие запросов определённым стандартам кодирования, лучшим практикам и требованиям безопасности, обеспечивая надёжный уровень валидации.

![SQL Audit](https://raw.githubusercontent.com/cookieY/Yearning/next/img/audit.png)

## 💡 Подсветка синтаксиса SQL и автодополнение

Повышайте эффективность написания запросов с помощью подсветки синтаксиса SQL и автодополнения. Эти функции помогают пользователям визуально различать разные компоненты SQL-запроса, такие как ключевые слова, имена таблиц, имена столбцов и операторы, что облегчает чтение и понимание структуры запроса.

![SQL Query](https://raw.githubusercontent.com/cookieY/Yearning/next/img/query.png)

## ⏺️ Запись заказов/запросов

Наша платформа поддерживает аудит пользовательских заявок и запросов. Эта функция позволяет отслеживать и регистрировать все операции запросов, включая источники данных, базы данных и обработку чувствительных полей, обеспечивая соблюдение нормативных требований и отслеживаемость истории запросов.

![Order/Query Record](https://raw.githubusercontent.com/cookieY/Yearning/next/img/record.png)

Сосредотачиваясь на этих ключевых возможностях, Yearning улучшает пользовательский опыт, оптимизирует производительность SQL и обеспечивает строгую соответствие и отслеживаемость операций с базой данных.

## 🛠️ Рекомендуемые инструменты

- [Spug - Открытая лёгкая платформа для автоматизации операций](https://github.com/openspug/spug)

## ☎️ Контакты

По вопросам обращайтесь на почту: henry@yearning.io
## 📋 Лицензия

Yearning распространяется под лицензией AGPL. См. [LICENSE](LICENSE) для подробностей.

2024 © Генри И

---

С Yearning вы получаете упрощённый, безопасный и эффективный подход к аудиту и оптимизации SQL.


[docker-pulls-link]: https://hub.docker.com/r/yeelabs/yearning
[docker-pulls-shield]: https://img.shields.io/docker/pulls/yeelabs/yearning?color=45cc11&labelColor=black&style=flat-square
[docker-release-link]: https://hub.docker.com/r/yeelabs/yearning
[docker-release-shield]: https://img.shields.io/docker/v/yeelabs/yearning?color=369eff&label=docker&labelColor=black&logo=docker&logoColor=white&style=flat-square
[docker-size-link]: https://hub.docker.com/r/yeelabs/yearning
[docker-size-shield]: https://img.shields.io/docker/image-size/yeelabs/yearning?color=369eff&labelColor=black&style=flat-square
[github-forks-shield]: https://img.shields.io/github/forks/cookieY/Yearning?color=8ae8ff&labelColor=black&style=flat-square
[github-forks-link]: https://github.com/cookieY/Yearning/network/members
[github-stars-link]: https://github.com/cookieY/Yearning/network/stargazers
[github-stars-shield]: https://img.shields.io/github/stars/cookieY/Yearning?color=ffcb47&labelColor=black&style=flat-square
[github-license-link]: https://github.com/cookieY/Yearning/blob/main/LICENSE
[github-license-shield]: https://img.shields.io/badge/AGPL%203.0-white?labelColor=black&style=flat-square


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-29

---