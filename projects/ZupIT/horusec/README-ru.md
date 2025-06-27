<p align="center" margin="20 0"><a href="https://horusec.io/">
    <img src="https://raw.githubusercontent.com/ZupIT/horusec/main/assets/horusec_logo.png" alt="logo_header" width="65%" style="max-width:100%;"/></a></p>

<p align="center">
    <a href="https://github.com/ZupIT/horusec/releases" alt="version">
        <img src="https://img.shields.io/github/v/release/ZupIT/horusec?label=version"/></a>
    <a href="https://github.com/ZupIT/horusec/pulse" alt="activity">
        <img src="https://img.shields.io/github/commit-activity/m/ZupIT/horusec?label=activity"/></a>
    <a href="https://github.com/ZupIT/horusec/graphs/contributors" alt="contributors">
        <img src="https://img.shields.io/github/contributors/ZupIT/horusec?label=contributors"/></a>
    <a href="https://github.com/ZupIT/horusec/actions/workflows/lint.yml" alt="lint">
        <img src="https://img.shields.io/github/workflow/status/ZupIT/horusec/Lint?label=lint"/></a>
    <a href="https://github.com/ZupIT/horusec/actions/workflows/test.yml" alt="test">
        <img src="https://img.shields.io/github/workflow/status/ZupIT/horusec/Test?label=test"/></a>
    <a href="https://github.com/ZupIT/horusec/actions/workflows/security.yml" alt="security">
        <img src="https://img.shields.io/github/workflow/status/ZupIT/horusec/Security?label=security"/></a>
    <a href="https://github.com/ZupIT/horusec/actions/workflows/coverage.yml" alt="coverage">
        <img src="https://img.shields.io/github/workflow/status/ZupIT/horusec/Coverage?label=coverage"/></a>
    <a href="https://github.com/ZupIT/horusec/actions/workflows/e2e.yml" alt="e2e">
        <img src="https://img.shields.io/github/workflow/status/ZupIT/horusec/e2e?label=e2e"/></a>
    <a href="https://github.com/ZupIT/horusec/actions/workflows/build.yaml" alt="build">
        <img src="https://img.shields.io/github/workflow/status/ZupIT/horusec/Build?label=build"/></a>
    <a href="https://opensource.org/licenses/Apache-2.0" alt="license">
        <img src="https://img.shields.io/badge/license-Apache%202-blue"/></a>
    <a href="https://bestpractices.coreinfrastructure.org/projects/5146"><img src="https://bestpractices.coreinfrastructure.org/projects/5146/badge"></a>
</p>

## **Содержание**
### 1. [**О проекте**](#about)
### 2. [**Начало работы**](#getting-started)
>#### 2.1.   [**Требования**](#requirements)
>#### 2.2.  [**Установка**](#installing-horusec)
### 3. [**Использование**](#usage)
>#### 3.1. [**Использование CLI**](#cli-usage)
>#### 3.2. [**Использование Docker**](#using-docker)
>#### 3.3. [**Старые версии**](#older-versions)
>#### 3.4. [**Использование Horusec-Web приложения**](#using-horusec-web-application)
>#### 3.5.  [**Использование Visual Studio Code**](#using-visual-studio-code)
>#### 3.6. [**Использование в Pipeline**](#using-the-pipeline)
### 4. [**Документация**](#documentation)       
### 5. [**Дорожная карта**](#roadmap)
### 6. [**Вклад в проект**](#contributing)
### 7. [**Кодекс поведения**](#code-of-conduct)
### 8. [**Лицензия**](#license)
### 9. [**Сообщество**](#community)



<br>
<br>
<br>

# **О проекте**
Horusec — это инструмент с открытым исходным кодом, который выполняет статический анализ кода для выявления уязвимостей безопасности на этапе разработки. В настоящее время поддерживаются языки: C#, Java, Kotlin, Python, Ruby, Golang, Terraform, Javascript, Typescript, Kubernetes, PHP, C, HTML, JSON, Dart, Elixir, Shell, Nginx.  
Инструмент позволяет искать утечки ключей и уязвимости во всех файлах вашего проекта, а также в истории Git. Horusec может использоваться разработчиком через CLI и командой DevSecOps на CI/CD конвейерах.

Ознакомьтесь с нашей [**документацией**](https://docs.horusec.io/docs/overview/), где вы найдете полный список инструментов и языков, поддерживаемых Horusec.

<p align="center" margin="20 0"><img src="https://raw.githubusercontent.com/ZupIT/horusec/main/assets/horusec-complete-architecture.png" alt="architecture" width="100%" style="max-width:100%;"/></p>

### **Пример вывода:**

<img src="https://raw.githubusercontent.com/ZupIT/horusec/main/assets/usage_horusec.gif" alt="usage_gif" width="100%" style="max-width:100%;"/>

# **Начало работы**

## **Требования**

- Docker

Вам необходимо установить Docker на вашу машину, чтобы запускать Horusec со всеми инструментами, которые мы используем.
Если у вас нет Docker, у нас есть [**флаг**](https://docs.horusec.io/docs/cli/commands-and-flags/#3-flags) `-D true`, который отключает эту зависимость, однако при этом теряется большая часть возможностей анализа.
Рекомендуем использовать Horusec с Docker.

Если вы включаете авторов коммитов `-G true`, потребуется также зависимость `git`.

## **Установка Horusec**
### **Mac или Linux**
```
make install
```

или

```sh
curl -fsSL https://raw.githubusercontent.com/ZupIT/horusec/master/deployments/scripts/install.sh | bash -s latest
```

#### **Проверка установки**
```bash
horusec version
```

### **Windows**
- **amd64**
    ```sh
    curl -k "https://github.com/ZupIT/horusec/releases/latest/download/horusec_win_amd64.exe" -o "./horusec.exe" -L
    ```

- **arm64**
    ```sh
    curl -k "https://github.com/ZupIT/horusec/releases/latest/download/horusec_win_arm64.exe" -o "./horusec.exe" -L
    ```

#### **Проверка установки**
```bash
./horusec.exe version
```

### **И другое**

- Все бинарные файлы с версиями можно найти на нашей [**странице релизов**](https://github.com/ZupIT/horusec/releases).

- Подробнее о способах установки читайте в [**документации**](https://docs.horusec.io/docs/cli/installation) 


## **Использование**
### **Использование CLI**
Чтобы использовать horusec-cli и проверить уязвимости приложения, выполните команду:
```bash
horusec start -p .
```
> При запуске анализа horusec создает папку **`.horusec`**. Эта папка нужна для того, чтобы не изменять ваш код. Рекомендуем добавить строку **`.horusec`** в ваш файл **`.gitignore`**, чтобы эту папку не отправлять на ваш git-сервер.

### **Использование Docker**
Вы можете использовать Horusec через docker-образ **`horuszup/horusec-cli:latest`**.

Запустите следующую команду:
```sh
docker run -v /var/run/docker.sock:/var/run/docker.sock -v $(pwd):/src horuszup/horusec-cli:latest horusec start -p /src -P $(pwd)
```

- Мы создали том, содержащий проект `-v $(pwd):/src`.

При использовании docker-образа у нас оказывается два пути, где может находиться проект.

Флаг `-p` будет обозначать путь к проекту внутри контейнера, в нашем примере это `/src`.
Флаг `-P` будет обозначать путь к проекту вне контейнера, в нашем примере это `$(pwd)`,
также потребуется передать путь к проекту для монтирования тома `-v $(pwd):/src`.

### **Старые версии**

Horusec v1 все еще доступен.

**ВНИМАНИЕ:** Эндпоинт с v1 будет удален, пожалуйста, обновите ваш CLI до v2. Подробнее читайте в [**документации**](https://docs.horusec.io/docs/migrate-v1-to-v2/).

### **Mac или Linux**
``` sh
curl -fsSL https://horusec.io/bin/install.sh | bash -s latest
```

### **Windows**
```sh
curl "https://horusec.io/bin/latest/win_x64/horusec.exe" -o "./horusec.exe" && ./horusec.exe version
```

- Старые бинарные файлы можно найти по этому адресу, включая последнюю версию v1 **`v1.10.3`**. 
- Начиная с v2, бинарные файлы больше не будут распространяться по этому адресу, их можно найти на [**странице релизов**](https://github.com/ZupIT/horusec/releases).

### **Использование Horusec-Web приложения**
Управляйте вашими уязвимостями через наш веб-интерфейс. Вы получите дашборд с метриками по уязвимостям, контроль ложных срабатываний, токен авторизации, обновление уязвимостей и многое другое.
Смотрите раздел [**web application**](https://github.com/ZupIT/horusec-platform), чтобы узнать больше.

Посмотрите пример ниже — он отправляет анализ в веб-сервисы Horusec:
```bash
horusec start -p <PATH_TO_YOUR_PROJECT> -a <YOUR_AUTHORIZATION_TOKEN>
```

Посмотрите [**инструкцию по созданию токена авторизации через Horusec Manager Web Service**](https://docs.horusec.io/docs/tutorials/how-to-create-an-authorization-token).

**ВНИМАНИЕ:** Наши веб-сервисы были перенесены в [**новый репозиторий**](https://github.com/ZupIT/horusec-platform). Необходимо обновить CLI до v2, ознакомьтесь с [**инструкцией по миграции с v1 на v2**](https://docs.horusec.io/docs/migrate-v1-to-v2).

### **Использование Visual Studio Code**
Вы можете анализировать ваш проект с помощью расширения Horusec для Visual Studio Code.
Подробнее смотрите в [**документации**](https://docs.horusec.io/docs/extensions/visual-studio-code/).

### **Использование в Pipeline**
Вы можете выполнить анализ проекта перед его развертыванием в вашей среде, чтобы обеспечить максимальную безопасность вашей организации.
Подробнее смотрите в [**документации**](https://docs.horusec.io/docs/cli/installation/#installation-via-pipeline):

### **Возможности**
Смотрите ниже:
- Одновременный анализ 18 языков с помощью 20 различных инструментов безопасности для повышения точности;
- Поиск по истории git на предмет секретов и других утечек;
- Анализ полностью настраиваемый, [**смотрите все доступные опции CLI**](https://docs.horusec.io/docs/cli/commands-and-flags/#3-flags).

## **Документация**
Документацию Horusec можно найти на нашем [**сайте**](https://docs.horusec.io/docs/overview/).

## **Дорожная карта**
У нас есть [**дорожная карта**](ROADMAP.md) проекта, вы можете присоединиться к развитию!

У Horusec есть и другие репозитории, ознакомьтесь с ними:

- [**Horusec Platform**](https://github.com/ZupIT/horusec-platform)
- [**Horusec DevKit**](https://github.com/ZupIT/horusec-devkit)
- [**Horusec Engine**](https://github.com/ZupIT/horusec-engine)
- [**Horusec Operator**](https://github.com/ZupIT/horusec-operator)
- [**Horusec VsCode**](https://github.com/ZupIT/horusec-vscode-plugin)
## **Вклад в проект**

Не стесняйтесь использовать, предлагать улучшения или вносить свой вклад в новые реализации.

Ознакомьтесь с нашим [**руководством для участников**](https://raw.githubusercontent.com/ZupIT/horusec/main/CONTRIBUTING.md), чтобы узнать о нашем процессе разработки, а также о том, как предлагать исправления ошибок и улучшения.

### **Сертификат происхождения разработчика - DCO**

Это дополнительный уровень безопасности для проекта и для разработчиков. Является обязательным.

Следуйте одному из двух способов, чтобы добавить DCO к вашим коммитам:

**1. Командная строка**  
Следуйте шагам:  
**Шаг 1:** Настройте вашу локальную среду git, добавив то же имя и e-mail, что и в вашем аккаунте GitHub. Это помогает вручную подписывать коммиты во время ревью и предложений.

```
git config --global user.name “Name”
git config --global user.email “email@domain.com.br”
```
**Шаг 2:** Добавьте строку Signed-off-by с помощью флага `'-s'` в команде git commit:

```
$ git commit -s -m "This is my commit message"
```
**2. Сайт GitHub**

Вы также можете вручную подписывать свои коммиты во время ревью и предложений на GitHub, выполните следующие шаги:

**Шаг 1:** Когда откроется окно изменений коммита, вручную введите или вставьте вашу подпись в поле комментария, см. пример:

```
Signed-off-by: Name < e-mail address >
```

Для этого способа ваше имя и e-mail должны совпадать с зарегистрированными в вашем аккаунте GitHub.

## **Кодекс поведения**
Пожалуйста, соблюдайте [**Кодекс поведения**](https://github.com/ZupIT/horusec/blob/main/CODE_OF_CONDUCT.md) во всех ваших взаимодействиях с нашим проектом.

## **Лицензия**
[**Apache License 2.0**](https://raw.githubusercontent.com/ZupIT/horusec/main/LICENSE).

## **Сообщество**

Вы всегда можете связаться с нами:

- [**GitHub Issues**](https://github.com/ZupIT/horusec/issues)
- Если у вас есть вопросы или идеи, давайте обсудим их на нашем [**Форуме Zup Open Source**](https://forum.zup.com.br).

Этот проект существует благодаря всем участникам. Вы лучшие! ❤️ 🚀

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---