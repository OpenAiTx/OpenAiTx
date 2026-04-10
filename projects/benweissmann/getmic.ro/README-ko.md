# getmic.ro

![테스트](https://github.com/benweissmann/getmic.ro/workflows/Test/badge.svg)

[Micro](https://micro-editor.github.io/)를 설치하는 가장 빠른 방법입니다.

```Bash
# local install just for your user
curl https://getmic.ro | bash
```

또는, `curl` 대신 `wget`을 사용하고 `bash` 대신 임의의 `sh` 셸 인터프리터를 사용하여:

```Bash
# local install just for your user
wget -O- https://getmic.ro | sh
```
이 스크립트는 현재 디렉토리에 micro를 설치합니다. 다른 위치에 설치하려면 (예: /usr/local/bin), 해당 디렉토리로 이동한 후 쓰기 권한이 있는지 확인하세요. 예: `cd /usr/local/bin; curl https://getmic.ro | sudo sh` 다음과 같이:


```Bash
# global install for all users
cd /usr/bin
curl https://getmic.ro | sudo sh
```
이 스크립트는 update-alternatives를 사용하여 micro를 시스템 텍스트 편집기로 등록할 수도 있습니다.  
예를 들어, 이렇게 하면 `crontab -e` 명령어가 micro로 크론 파일을 열 수 있습니다.  

이 기능을 활성화하려면 `GETMICRO_REGISTER` 변수를 정의하거나 다음 URL을 사용하세요.  
`https://getmic.ro/r` 이때 micro를 모든 사용자가 접근할 수 있는 디렉터리, 일반적으로 /usr/bin에 설치해야 합니다:



```Bash
# global install for all users, registering with update-alternatives
cd /usr/bin
curl https://getmic.ro/r | sudo sh
```
> 영어를 이해하지 못하나요? 프랑스어를 사용하나요? **[*프랑스어 LISEZ-MOI*](https://raw.githubusercontent.com/benweissmann/getmic.ro/master/./README.fr.md)를 확인하세요!**

## 고급 사용법

getmic.ro로 할 수 있는 다른 몇 가지 기능이 있습니다. 아래는 선택할 수 있는 환경 변수 목록입니다:

* `GETMICRO_HTTP=<COMMAND ...ARGS>`
    + 공백으로 구분된 인수와 함께 이 명령어를 사용하여 인터넷에서 파일을 다운로드합니다.
        - 리디렉션(HTTP Location 헤더)을 반드시 따라야 합니다.
        - 결과 파일 내용을 반드시 stdout에 출력해야 합니다.
        - 다음 인수로 다운로드할 파일의 URL을 반드시 받아야 합니다.
        - 비필수 GitHub 인증 대체용 `--header` 매개변수를 명령어가 받아도 됩니다.
    + 예를 들어, `curl` 사용을 강제하려면 이렇게 하세요: `curl https://getmic.ro | GETMICRO_HTTP="curl -L" sh`
    + 예를 들어, `wget` 사용을 강제하려면 이렇게 하세요: `wget -O- https://getmic.ro | GETMICRO_HTTP="wget -O-" sh`
* `GETMICRO_PLATFORM=[freebsd32 | freebsd64 linux-arm | linux-arm64 | linux32 | linux64 | linux64-static | macos-arm64 | netbsd32 | netbsd64 | openbsd32 | openbsd64 | osx | win32 | win64]`
    + 이 옵션은 플랫폼 감지 메커니즘을 수동으로 무시하고 지정한 플랫폼용 바이너리를 다운로드합니다.
    + 한 가지 용도는 musl과 같은 비호환 libc 구현을 사용할 때 `https://getmic.ro | GETMICRO_PLATFORM=linux64-static sh`를 지정하는 것입니다.
* `GETMICRO_REGISTER=[y | n]`
    + micro를 `update-alternatives`에 등록하여 시스템 텍스트 편집기로 원활하게 사용할지 여부입니다.
        - y => 예
        - n => 아니오 (기본값)
    + GETMICRO_REGISTER가 정의되어 있지만 시스템이 `update-alternatives`를 지원하지 않으면 이 옵션은 조용히 무시됩니다.
    + 활성화되면 getmicro는 `update-alternatives`를 사용하기 위해 충분한 권한(일반적으로 루트 사용자)으로 실행되어야 하며, 그렇지 않으면 오류와 함께 종료됩니다.
    + 축약형으로 `https://getmic.ro/r`를 사용하면 `GETMICRO_REGISTER=y`가 정의됩니다.

이 모든 것을 합치면, 다음 명령줄은 항상 wget을 사용하고, 항상 linux32 바이너리를 설치하며, 항상 `update-alternatives`에 등록합니다:


```Bash
wget -O- https://getmic.ro | GETMICRO_HTTP="wget -O-" GETMICRO_PLATFORM=linux32 GETMICRO_REGISTER=y sh
```
### 스크립트 체크섬 확인하기

스크립트를 확인하려면 다운로드하여 체크섬을 계산할 수 있습니다. sha256 체크섬은 `d041f51b97871dc7de1f01879c12a978b074a5acdb6528e884ce8f4c05d2ad35`입니다.


```Bash
gmcr="$(curl https://getmic.ro)" && [ $(echo "$gmcr" | shasum -a 256 | cut -d' ' -f1) = d041f51b97871dc7de1f01879c12a978b074a5acdb6528e884ce8f4c05d2ad35 ] && echo "$gmcr" | sh
```

또는 다음 수동 방법을 사용할 수 있습니다.

```Bash
# 1. Manually verify that this outputs d041f51b97871dc7de1f01879c12a978b074a5acdb6528e884ce8f4c05d2ad35
curl https://getmic.ro | shasum -a 256

# 2. If #1 was successful, then execute getmicro
curl https://getmic.ro | sh
```
## 기여하기

기여해 주셔서 감사합니다! 우리는 Github 풀 리퀘스트 워크플로우를 사용합니다: 이 저장소를 포크하고, 변경사항을 만든 후, 풀 리퀘스트를 제출하세요. PR이 병합되기 위해 해야 할 몇 가지가 있습니다:

- 모든 테스트가 통과하는지 확인하세요. PR 페이지에서 Github Actions가 테스트 실패를 보고합니다.

- 새로운 동작을 도입했다면, 해당 동작을 테스트하도록 Github Actions 테스트([`.github/workflows/test.yml`](https://github.com/benweissmann/getmic.ro/blob/master/.github/workflows/test.yml))를 업데이트하세요.

- 사용자에게 노출되는 새로운 옵션이나 동작을 도입했다면, README 파일을 업데이트하여 해당 동작을 문서화하세요 (대상 파일 언어를 모르면 번역하지 마세요).

이 중 어느 것도 어떻게 해야 할지 확실하지 않다면, 진행 중인 작업과 질문을 포함하여 PR을 열어도 됩니다!

## 감사의 말:

- 물론 Micro: https://micro-editor.github.io/

- Chef curl|bash를 느슨하게 기반으로 함: https://docs.chef.io/install_omnibus.html

- ASCII 아트 제공: figlet: http://www.figlet.org/

<!--shasum=d041f51b97871dc7de1f01879c12a978b074a5acdb6528e884ce8f4c05d2ad35-->



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-10

---