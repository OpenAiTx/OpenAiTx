# 🍡 scoop-proxy-cn

중국 대륙 사용자에게 적합한 [Scoop](https://scoop.sh) buckets 프록시 미러 저장소입니다. 여러 오픈소스 `bucket` 저장소에서 동기화하여 업데이트합니다. 그중에서:

- `sync` 브랜치(기본): 여러 저장소의 앱을 동기화하지만 ghproxy 프록시 수정 처리는 하지 않습니다. **국내 수정판 scoop(gitee 기반)을 사용하는 경우에 적합합니다.**
- `main` 브랜치: `github release`에서 다운로드하는 앱 주소를 `https://ghfast.top` 기반 프록시 다운로드 주소로 변경합니다. **프록시 주소가 자주 변경되어 안정적이지 않습니다.**

## 사용법

`spc` 앱 저장소를 추가합니다. [scoop 국내 미러 최적화 저장소](https://gitee.com/scoop-installer/scoop)와 함께 사용하기 적합합니다:

```bash
# bucket 추가, 기본으로 sync 브랜치를 가져옵니다.
scoop bucket add spc https://gitee.com/wlzwme/scoop-proxy-cn.git

# 앱 설치
scoop install spc/<app_name>
```

Scoop 공식판만 사용하고 싶다면 다음과 같이 구독 브랜치를 `main` 브랜치로 변경할 수 있습니다:

```bash
# spc 디렉터리로 이동
cd "$env:USERPROFILE\scoop\buckets\spc"
# 환경변수 SCOOP가 설정된 경우 다음 명령어를 실행하세요
cd "$env:SCOOP\buckets\spc"

# main 브랜치로 전환
git fetch --all
git checkout -b main origin/main
```

## Scoop 설치 및 설정 참고

### 방법 1: 국내 맞춤 미러 기반 설치(추천)

scoop의 소스 코드와 buckets 앱은 대부분 github의 git 형태로 관리되는데, github 접속이 어려워 설치, 업데이트 및 앱 다운로드가 매우 불편해집니다.

다음은 [scoop 국내 미러 최적화 저장소](https://gitee.com/scoop-installer/scoop) 설치 방법입니다.

```bash
# 스크립트 실행 정책 변경, 기본 자동 동의
Set-ExecutionPolicy RemoteSigned -scope CurrentUser -Force

# 방법 1: 설치 명령 실행(기본적으로 사용자 디렉터리에 설치, 변경하려면 아래 '사용자 지정 설치 경로' 명령 실행)
iwr -useb scoop.201704.xyz | iex


## 방법 2: 사용자 지정 설치 경로 (경로를 적절히 수정하세요)
irm scoop.201704.xyz -outfile 'install.ps1'
.\install.ps1 -ScoopDir 'D:\Scoop' -ScoopGlobalDir 'D:\GlobalScoopApps'

# 공식 소스가 이미 설치되어 있다면 다음 명령으로 변경 가능
scoop config SCOOP_REPO "https://gitee.com/scoop-installer/scoop"

# spc bucket 추가
scoop bucket add spc https://gitee.com/wlzwme/scoop-proxy-cn.git

# 저장소 주소 업데이트
scoop update
```

이 방식으로 설치된 scoop은 맞춤 수정되어 프록시 가속 사이트를 지정할 수 있으며 기본적으로 `scoop.201704.xyz` 프록시를 통해 앱을 다운로드합니다.

```bash
# 프록시 추가
scoop config URL_PROXY "https://scoop.201704.xyz"

# 프록시 삭제
scoop config rm URL_PROXY
```

### 방법 2: 공식 저장소 기반 프록시 형태 설치

`PowerShell`을 열고 다음 명령어를 실행하세요:

```bash
# 설치
Set-ExecutionPolicy -ExecutionPolicy RemoteSigned -Scope CurrentUser
# irm -useb get.scoop.sh | iex
irm https://ghfast.top/raw.githubusercontent.com/lzwme/scoop-proxy-cn/main/install.ps1 | iex

# 설정
scoop config SCOOP_REPO https://ghfast.top/github.com/ScoopInstaller/Scoop

# spc bucket 추가
scoop bucket add spc https://gitee.com/wlzwme/scoop-proxy-cn.git
# spc 디렉터리로 이동
cd "$env:USERPROFILE\scoop\buckets\spc"
# main 브랜치로 전환
git fetch --all && git checkout -b main origin/main

# 도움말 표시
scoop help

# 7zip, aria2, scoop-search 등 설치
scoop install spc/7zip spc/aria2 spc/scoop-search
```

### `scoop-search`에 대하여

`scoop-proxy-cn` 저장소는 1.4만 개 이상의 앱을 동기화합니다. 공식 PowerShell 기반 `scoop search` 명령은 효율이 너무 낮아 사용할 수 없으므로, Go 언어로 개발된 `scoop-search` 도구 사용을 권장합니다. 예:

```bash
scoop install scoop-search
# scoop-search 사용
scoop-search act
```

## 자주 묻는 질문

### `aria2`로 인한 다운로드 실패 문제

`aria2`가 설치되어 있으면 scoop은 `aria2`를 사용해 분할 가속 다운로드를 합니다. 하지만 일부 프록시 주소는 `aria2`의 분할 다운로드 요청을 지원하지 않거나 차단합니다. 이 경우 다음 명령으로 `aria2`를 비활성화할 수 있습니다:

```bash
scoop config aria2-enabled false
```

### `Hash Check Failed` 문제

일부 앱은 최신 릴리스 주소를 다운로드 주소로 지정하였으나, 해시 값도 함께 지정되어 있어 새 버전이 나오면 `Hash Check Failed` 오류가 발생합니다. 이 경우 `-s` 옵션을 추가하여 무시할 수 있습니다. 예:

```bash
scoop install scoop-search -s
```

### 프록시 사이트가 만료되어 업데이트가 필요한 경우

Scoop 공식판을 사용하고 `main` 브랜치를 구독하면 git 저장소 및 앱 다운로드 주소에 프록시 가속을 사용합니다. 하지만 이전 프록시 사이트가 만료되면 업데이트가 불가능해집니다. 다음 명령으로 다시 추가하세요:

```bash
# 먼저 scoop repo 업데이트
scoop config scoop_repo https://ghfast.top/github.com/ScoopInstaller/Scoop.git

# 방법 1: spc bucket 저장소 업데이트
git -C "$env:USERPROFILE\scoop\buckets\spc" remote set-url origin https://gitee.com/wlzwme/scoop-proxy-cn.git
# buckets 기본 경로를 변경했다면 다음 명령 실행
git -C "$env:SCOOP\buckets\spc" remote set-url origin https://gitee.com/wlzwme/scoop-proxy-cn.git

# 방법 2: spc bucket 제거 후 재추가
scoop bucket rm spc
scoop bucket add spc https://gitee.com/wlzwme/scoop-proxy-cn.git
```

## 동기화된 Buckets 목록

- [ScoopInstaller/PHP](https://github.com/ScoopInstaller/PHP)
- [ScoopInstaller/Main](https://github.com/ScoopInstaller/Main)
- [ScoopInstaller/Extras](https://github.com/ScoopInstaller/Extras)
- [ScoopInstaller/Java](https://github.com/ScoopInstaller/Java)
- [ScoopInstaller/Versions](https://github.com/ScoopInstaller/Versions)
- [ScoopInstaller/Nirsoft](https://github.com/ScoopInstaller/Nirsoft)
- [ScoopInstaller/Nonportable](https://github.com/ScoopInstaller/Nonportable)
- [renxia/scoop-bucket](https://github.com/renxia/scoop-bucket)
- [scoopcn/scoopcn](https://github.com/scoopcn/scoopcn)
- [rasa/scoops](https://github.com/rasa/scoops)
- [amorphobia/siku](https://github.com/amorphobia/siku)
- [ACooper81/scoop-apps](https://github.com/ACooper81/scoop-apps)
- [kkzzhizhou/scoop-zapps](https://github.com/kkzzhizhou/scoop-zapps)
- [Calinou/scoop-games](https://github.com/Calinou/scoop-games)
- [cderv/r-bucket](https://github.com/cderv/r-bucket)
- [chawyehsu/dorado](https://github.com/chawyehsu/dorado)
- [borger/scoop-galaxy-integrations](https://github.com/borger/scoop-galaxy-integrations)
- [ivaquero/scoopet](https://github.com/ivaquero/scoopet)
- [KNOXDEV/wsl](https://github.com/KNOXDEV/wsl)
- [kodybrown/scoop-nirsoft](https://github.com/kodybrown/scoop-nirsoft)
- [kidonng/sushi](https://github.com/kidonng/sushi)
- [littleli/scoop-clojure](https://github.com/littleli/scoop-clojure)
- [niheaven/scoop-sysinternals](https://github.com/niheaven/scoop-sysinternals)
- [matthewjberger/scoop-nerd-fonts](https://github.com/matthewjberger/scoop-nerd-fonts)
- [TheCjw/scoop-retools](https://github.com/TheCjw/scoop-retools)
- [TheRandomLabs/Scoop-Bucket](https://github.com/TheRandomLabs/Scoop-Bucket)
- [TheRandomLabs/scoop-nonportable](https://github.com/TheRandomLabs/scoop-nonportable)
- [TheRandomLabs/Scoop-Spotify](https://github.com/TheRandomLabs/Scoop-Spotify)
- [Paxxs/Cluttered-bucket](https://github.com/Paxxs/Cluttered-bucket)
- [zhoujin7/tomato](https://github.com/zhoujin7/tomato)
- [HCLonely/my-scoop-bucket](https://github.com/HCLonely/my-scoop-bucket)
- [Weidows-projects/scoop-3rd](https://github.com/Weidows-projects/scoop-3rd)
- [hermanjustnu/scoop-emulators](https://github.com/hermanjustnu/scoop-emulators)
- [everyx/scoop-bucket](https://github.com/everyx/scoop-bucket)
- [borger/scoop-emulators](https://github.com/borger/scoop-emulators)
- [ZvonimirSun/scoop-iszy](https://github.com/ZvonimirSun/scoop-iszy)
- [kiennq/scoop-misc](https://github.com/kiennq/scoop-misc)
- [wzv5/ScoopBucket](https://github.com/wzv5/ScoopBucket)
- [TheRandomLabs/Scoop-Python](https://github.com/TheRandomLabs/Scoop-Python)
- [naderi/scoop-bucket](https://github.com/naderi/scoop-bucket)
- [ViCrack/scoop-bucket](https://github.com/ViCrack/scoop-bucket)
- [42wim/scoop-bucket](https://github.com/42wim/scoop-bucket)
- [akirco/aki-apps](https://github.com/akirco/aki-apps)
- [batkiz/backit](https://github.com/batkiz/backit)
- [iquiw/scoop-bucket](https://github.com/iquiw/scoop-bucket)
- [ygguorun/scoop-bucket](https://github.com/ygguorun/scoop-bucket)
- [seumsc/scoop-seu](https://github.com/seumsc/scoop-seu)
- [cc713/ownscoop](https://github.com/cc713/ownscoop)
- [aoisummer/scoop-bucket](https://github.com/aoisummer/scoop-bucket)
- [yuusakuri/scoop-bucket](https://github.com/yuusakuri/scoop-bucket)
- [hu3rror/scoop-muggle](https://github.com/hu3rror/scoop-muggle)
- [starise/Scoop-Confetti](https://github.com/starise/Scoop-Confetti)
- [dodorz/scoop](https://github.com/dodorz/scoop)
- [SayCV/scoop-cvp](https://github.com/SayCV/scoop-cvp)
- [Qv2ray/mochi](https://github.com/Qv2ray/mochi)
- [Homeland-Community/scoop](https://github.com/Homeland-Community/scoop)
- [jingyu9575/scoop-jingyu9575](https://github.com/jingyu9575/scoop-jingyu9575)
- [couleur-tweak-tips/utils](https://github.com/couleur-tweak-tips/utils)
- [wangzq/scoop-bucket](https://github.com/wangzq/scoop-bucket)
- [jonz94/scoop-sarasa-nerd-fonts](https://github.com/jonz94/scoop-sarasa-nerd-fonts)
- [NyaMisty/scoop_bucket_misty](https://github.com/NyaMisty/scoop_bucket_misty)
- [jfut/scoop-jfut](https://github.com/jfut/scoop-jfut)
- [mogeko/scoop-sysinternals](https://github.com/mogeko/scoop-sysinternals)
- [ChungZH/peach](https://github.com/ChungZH/peach)
- [DoveBoy/Apps](https://github.com/DoveBoy/Apps)
- [Velgus/Scoop-Portapps](https://github.com/Velgus/Scoop-Portapps)
- [starise/Scoop-Gaming](https://github.com/starise/Scoop-Gaming)
- [mo-san/scoop-bucket](https://github.com/mo-san/scoop-bucket)
- [brian6932/dank-scoop](https://github.com/brian6932/dank-scoop)
- [AkariiinMKII/Scoop4kariiin](https://github.com/AkariiinMKII/Scoop4kariiin)
- [littleli/Scoop-littleli](https://github.com/littleli/Scoop-littleli)
- [ChinLong/scoop-customize](https://github.com/ChinLong/scoop-customize)
- [Darkatse/Scoop-KanColle](https://github.com/Darkatse/Scoop-KanColle)
- [aliesbelik/poldi](https://github.com/aliesbelik/poldi)
- [MCOfficer/scoop-bucket](https://github.com/MCOfficer/scoop-bucket)
- [KnotUntied/scoop-fonts](https://github.com/KnotUntied/scoop-fonts)
- [beerpiss/scoop-bucket](https://github.com/beerpiss/scoop-bucket)
- [HUMORCE/nuke](https://github.com/HUMORCE/nuke)
- [AkinoKaede/maple](https://github.com/AkinoKaede/maple)
- [hulucc/bucket](https://github.com/hulucc/bucket)
- [Deide/deide-bucket](https://github.com/Deide/deide-bucket)
- [echoiron/echo-scoop](https://github.com/echoiron/echo-scoop)
- [tetradice/scoop-iyokan-jp](https://github.com/tetradice/scoop-iyokan-jp)

## 선언

> [!WARNING]
> 본 저장소에 포함된 애플리케이션 정보는 제3자 저장소에서 동기화된 것으로, 사용 가능성 및 보안성 검증을 일일이 수행하지 않았으니 설치 시 스스로 검증 및 인식하시기 바랍니다. 저작권 침해가 있을 경우 issue를 통해 처리해 주시기 바랍니다.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---