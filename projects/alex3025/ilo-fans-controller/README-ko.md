<h1 align="center">iLO 팬 컨트롤러</h1>

<p align="center">
  <img width="800" src="https://raw.githubusercontent.com/alex3025/ilo-fans-controller/main/screenshot.png" alt="웹페이지 스크린샷">
  <br>
  <i>어디서든 HP 서버 팬 속도를 쉽게 관리하세요!</i>
</p>

---

<h3 align="center"> 🎉 <code>1,000+</code> 컨테이너 다운로드 감사합니다! 🎉 </h3>

> ℹ **참고:** v1.0.0은 도구의 **완전한 재작성** 버전이므로, 피드백을 언제나 환영합니다!<br>
> 버그를 발견하거나 제안 사항이 있으면 [이슈를 열어주세요](https://github.com/alex3025/ilo-fans-controller/issues). 감사합니다! 😄

## FAQ

### 어떻게 작동하나요? 🛠

이 도구는 `php-curl` 확장을 사용하여 **iLO REST API에서 현재 서버 팬 속도를 가져오고**, `php-ssh2` 확장을 사용하여 **[패치된 iLO SSH 인터페이스](#can-i-use-this-tool-with-my-hp-server-%EF%B8%8F)를 통해 팬 속도를 설정하는 단일 PHP 스크립트**입니다. 또한 [Alpine.js](https://alpinejs.dev/)와 [TailwindCSS](https://tailwindcss.com/)를 사용해 만든 **간단하고 깔끔한 웹 인터페이스**로 클릭 한 번에 특정 팬 구성을 설정할 수 있는 **맞춤 프리셋을 만들 수도 있습니다.**

### 이 도구를 내 HP 서버에서 사용할 수 있나요? 🖥️

이 도구는 팬 속도 조작 명령을 iLO SSH 인터페이스에 노출하는 **패치된 iLO 펌웨어**가 필요합니다. 이 패치에 대한 자세한 내용은 [이 Reddit 게시물](https://www.reddit.com/r/homelab/comments/sx3ldo/hp_ilo4_v277_unlocked_access_to_fan_controls/)에서 확인할 수 있습니다.

현재로서는 이 패치(따라서 이 도구)는 **iLO 4가 탑재된 Gen8 및 Gen9 서버에서만 작동합니다.**

> 🚫 iLO 5/6/7이 탑재된 Gen10/11/12 서버는 지원하지 않으며, 아마도 지원하지 않을 것입니다.

### 왜 PHP를 사용했나요? 📄

제 생각에 PHP는 간단한 서버 사이드 작업을 수행하고 쉽게 배포할 수 있어 이런 종류의 작업에 적합합니다 (PHP가 설치된 웹 서버만 있으면 됩니다).

### 왜 이 도구를 만들었나요? 🤔

이 도구의 배경 이야기는 제 [r/homelab 원본 댓글](https://www.reddit.com/r/homelab/comments/rcel73/comment/hnu3iyp/?utm_source=share&utm_medium=web2x&context=3)을 참조하세요!

### 이 프로젝트가 마음에 드나요? 피자 한 조각을 선물해 주세요! 🍕

이 도구가 유용했다면, 제 작업을 지원하기 위해 [PayPal](https://paypal.me/alex3025)이나 [GitHub Sponsors](https://github.com/sponsors/alex3025)를 통해 피자 한 조각(또는 전체)을 선물하는 것을 고려해 주세요! 정말 감사합니다! 🙏

---

## Getting started with Docker / Docker Compose

If you already have a Docker environment, you can be up and running in minutes using the following command (obviously you need to change the value):

```sh
docker run -d --name ilo-fans-controller --restart always \
    -p 8000:80 \
    -e ILO_HOST='your-ilo-address' \
    -e ILO_USERNAME='your-ilo-username' \
    -e ILO_PASSWORD='your-ilo-password' \
    ghcr.io/alex3025/ilo-fans-controller:latest
```
또는 원하신다면, [docker-compose.yaml](https://github.com/alex3025/ilo-fans-controller/blob/main/docker-compose.yaml) 파일도 제공되므로 `docker compose`를 사용할 수 있습니다.

**사용 가능한 모든 환경 변수는 [`config.inc.php`](https://github.com/alex3025/ilo-fans-controller/blob/main/config.inc.php)를 확인하세요!**

---

> ⚠ **중요!** ⚠
>
> 다시 한 번, 이 도구는 팬 속도를 조절하는 명령어를 iLO SSH 인터페이스에 노출하는 **[패치된 iLO 펌웨어](#can-i-use-this-tool-with-my-hp-server-%EF%B8%8F)** 덕분에 작동합니다.
>
> **이 도구를 사용하려면 이 패치가 필요합니다!**

## 수동 설치

### 다음 가이드는 다음 환경에서 실행되었습니다

* **HP ProLiant DL380e Gen8** 서버
* **패치된 iLO 4** Advanced **v2.77** (2020년 12월 07일)
* **Ubuntu 22.04**를 실행하는 Proxmox 컨테이너 (LXC)
* **Apache 2** 및 **PHP 8.1**

### 환경 준비

1. 시스템을 업데이트합니다:


    ```sh
    sudo apt-get update && sudo apt-get upgrade
    ```
2. 필요한 패키지(`apache2`, `php`, `php-curl` 및 `php-ssh2`)를 설치합니다:


    ```sh
    sudo apt-get install apache2 php php-curl php-ssh2
    ```
### 도구 다운로드

1. `wget`과 `tar`를 사용하여 최신 소스 코드를 다운로드하고 압축을 풉니다:


    ```sh
    wget -qL https://github.com/alex3025/ilo-fans-controller/archive/refs/heads/main.tar.gz -O - | tar -xz
    ```

2. 디렉터리로 이동하세요:

    ```sh
    cd ilo-fans-controller-main
    ```

### 도구 구성 및 설치

1. 좋아하는 텍스트 편집기로 `config.inc.php` 파일을 열고 구성에 따라 변수를 변경합니다.

    > ℹ **참고:** `$ILO_HOST`는 서버 자체의 IP가 아니라 iLO 인터페이스의 IP 주소임을 기억하세요.

    > ℹ **참고:** SSH 인터페이스와 REST API(원격 콘솔 액세스)에 접근하는 데 필요한 최소 권한만 가진 새로운 iLO 사용자를 생성하는 것이 권장됩니다.

    다음은 예시입니다:

    ```php
    /*
    ILO ACCESS CREDENTIALS
    --------------
    These are used to connect to the iLO
    interface and manage the fan speeds.
    */

    $ILO_HOST = '192.168.1.69';
    $ILO_USERNAME = 'Administrator';
    $ILO_PASSWORD = 'AdministratorPassword1234';
    ```
2. 완료되면 웹 서버 루트 디렉터리(보통 `/var/www/html/`)에 새 하위 디렉터리를 만들고 `config.inc.php`, `ilo-fans-controller.php` 및 `favicon.ico` 파일을 복사하십시오:


    ```sh
    sudo mkdir /var/www/html/ilo-fans-controller
    sudo cp config.inc.php ilo-fans-controller.php favicon.ico /var/www/html/ilo-fans-controller/
    ```

    그런 다음 `ilo-fans-controller.php`의 이름을 `index.php`로 변경합니다 (URL에서 파일 이름을 지정하지 않고 작동하도록):

    ```sh
    sudo mv /var/www/html/ilo-fans-controller/ilo-fans-controller.php /var/www/html/ilo-fans-controller/index.php
    ```
3. 이제 끝났습니다! 도구에 접속하려면 `http://<your-server-ip>/ilo-fans-controller/` (또는 API 요청의 경우 `http://<your-server-ip>/ilo-fans-controller/index.php`)로 접속하세요.

> ℹ **참고:** 이 도구를 설치한 웹 서버가 **네트워크 외부에서 접근 가능할 경우**, _무단 팬 관리 방지_를 위해 **기본 인증(Basic Auth) 같은 인증 설정**을 반드시 하세요.

---

## 문제 해결

문제가 발생했을 때 가장 먼저 할 일은 **로그를 확인하는 것**입니다.

> Apache를 사용 중이라면, PHP 오류는 `/var/log/apache2/error.log` 파일에 기록됩니다.

버그라고 생각되면 [이슈를 등록](https://github.com/alex3025/ilo-fans-controller/issues)해 주시면 확인하겠습니다.

아래에는 자주 발생하는 문제와 해결 방법을 정리했습니다.

### 프리셋이 저장되지 않음

새 프리셋을 생성할 때 로그에 다음과 같은 오류가 보인다면:


```log
PHP Warning:  file_put_contents(presets.json): Failed to open stream: Permission denied in .../index.php on line X
```

아마도 `presets.json` 파일이 웹 서버 사용자가 쓸 수 없기 때문입니다.<br>
이를 해결하려면 다음 명령어를 실행하여 파일 소유자를 `www-data`(기본 Apache 사용자)로 변경하세요:

```sh
sudo chown www-data:www-data /var/www/html/ilo-fans-controller/presets.json
```

---

## API 문서

이 도구는 다음 작업에 사용할 수 있는 간단한 API를 제공합니다:

* iLO에서 현재 팬 속도 가져오기
* 팬 속도 설정하기
* 모든 프리셋 가져오기
* 프리셋 생성하기

> 다음 예제들은 API 사용법을 보여주기 위해 cURL을 사용하지만, 원하는 다른 도구를 사용해도 됩니다.

### 팬 API

다음 API를 사용하려면 URL 끝에 `?api=fans`를 추가해야 합니다.

#### 팬 속도 가져오기 (`GET`)

<details>
<summary>JSON 구조 (응답)</summary>

```jsonc
{
    "Fan 1": 85,
    "Fan 2": 48,
    "Fan 3": 69,
    "Fan 4": 18,
    "Fan 5": 44,
    "Fan 6": 96
}
```

</details>

<details>
<summary>cURL 예제</summary>

```sh
curl 'http://<server ip>/ilo-fans-controller/index.php?api=fans'
```

</details>

#### 팬 속도 설정 (`POST`)

<details>
<summary>JSON 구조 예시</summary>

```jsonc
{
    "action": "fans",
    // You can use either an object or a single number value (that will be applied to all fans):
    // Example: `fans: { ... }` or `fans: 50`
    "fans": {
        "Fan 1": 40,
        "Fan 2": 23,
        "Fan 5": 70
        // ...
    }
}
```

</details>

<details>
<summary>cURL 예제</summary>

```sh
curl -X POST 'http://<server ip>/ilo-fans-controller/index.php' \
    -H 'Content-Type: application/json' \
    -d '{"action": "fans", "fans": 50}'
```
이 명령어는 모든 팬을 50%로 설정합니다.<br>
_개인적으로 서버 부팅 시 팬 속도를 자동으로 낮추기 위해 이 명령어를 사용합니다._
</details>

### 프리셋 API

다음 API를 사용하려면 URL 끝에 `?api=preset`을 추가해야 합니다.

#### 모든 프리셋 가져오기 (`GET`)

<details>
<summary>JSON 구조 (응답)</summary>


```jsonc
[
    {
        "name": "Silent Mode",
        "speeds": [15]  // Like when setting the speeds, this number applies to all fans.
    },
    {
        "name": "Normal Mode",
        "speeds": [50]
    },
    {
        "name": "Turbo Mode",
        "speeds": [100]
    },
    {
        "name": "My Custom Preset",
        "speeds": [10, 10, 25, 30, 10, 15]  // Here you can see the different speeds for each fan.
    }
]
```

</details>

<details>
<summary>cURL 예제</summary>

```sh
curl 'http://<server ip>/ilo-fans-controller/index.php?api=presets'
```

</details>

#### 프리셋 생성 (`POST`)

<details>
<summary>JSON 구조 예시</summary>

```jsonc
{
    "action": "presets",
    // WARNING: The API will replace all the saved presets with the new data!
    // To add a preset you should get all the presets first and then add the new one to the existing array.
    "presets": [
        {
            "name": "Silent Mode",
            "speeds": [15]
        },
        {
            "name": "Normal Mode",
            "speeds": [50]
        },
        {
            "name": "Turbo Mode",
            "speeds": [100]
        },
        {
            "name": "My Custom Preset",
            "speeds": [10, 10, 25, 30, 10, 15]
        }
    ]
}
```

</details>

<details>
<summary>cURL 예제</summary>

```sh
curl -X POST 'http://<server ip>/ilo-fans-controller/index.php' \
    -H 'Content-Type: application/json' \
    -d '{"action": "presets", "presets": [{"My Custom Preset 1": [50], "My Custom Preset 2": [10, 20, 30, 30, 20, 10]}]}'
```

</details>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-10

---