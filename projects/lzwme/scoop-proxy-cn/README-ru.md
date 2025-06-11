# 🍡 scoop-proxy-cn

Подходит для пользователей из материкового Китая прокси-репозиторий [Scoop](https://scoop.sh) buckets. Синхронизируется обновление из нескольких открытых репозиториев `bucket`. Среди них:

- Ветка `sync` (по умолчанию): синхронизирует приложения из нескольких репозиториев, но не изменяет ссылки прокси ghproxy. **Подходит для использования с измененной китайской версией scoop на базе gitee**
- Ветка `main`: изменяет адреса загрузки приложений с `github release` на прокси-адреса, основанные на `https://ghfast.top`. **Из-за частых изменений и нестабильности прокси-адреса**

## Usage

Добавьте репозиторий `spc`. Подходит для совместного использования с [оптимизированным китайским зеркалом scoop](https://gitee.com/scoop-installer/scoop):

```bash
# Добавить bucket, по умолчанию используется ветка sync
scoop bucket add spc https://gitee.com/wlzwme/scoop-proxy-cn.git

# установка приложений
scoop install spc/<app_name>
```

Если хотите использовать только официальную версию Scoop, выполните следующие действия, чтобы переключить подписку на ветку `main`:

```bash
# Перейти в каталог spc
cd "$env:USERPROFILE\scoop\buckets\spc"
# Если установлен переменная окружения SCOOP, выполните
cd "$env:SCOOP\buckets\spc"

# Переключиться на ветку main
git fetch --all
git checkout -b main origin/main
```

## Справка по установке и настройке Scoop

### Способ 1: Установка на базе локального зеркала Китая (рекомендуется)

Поскольку исходники scoop и buckets приложений в основном хранятся в git на github, проблемы с доступом к github ухудшают опыт установки, обновления и загрузки приложений.

Ниже описан способ установки [оптимизированного китайского зеркала scoop](https://gitee.com/scoop-installer/scoop).

```bash
# Изменение политики выполнения скриптов, по умолчанию автоматически согласиться
Set-ExecutionPolicy RemoteSigned -scope CurrentUser -Force

# Способ 1: выполнить команду установки (по умолчанию устанавливается в каталог пользователя, для изменения см. ниже «Пользовательский каталог установки»)
iwr -useb scoop.201704.xyz | iex


## Способ 2: Пользовательский каталог установки (обязательно изменить путь на подходящий)
irm scoop.201704.xyz -outfile 'install.ps1'
.\install.ps1 -ScoopDir 'D:\Scoop' -ScoopGlobalDir 'D:\GlobalScoopApps'

# Если уже установлен официальный источник, переключитесь следующим образом
scoop config SCOOP_REPO "https://gitee.com/scoop-installer/scoop"

# Добавьте bucket spc
scoop bucket add spc https://gitee.com/wlzwme/scoop-proxy-cn.git

# Обновите репозитории
scoop update
```

Scoop, установленный таким образом, модифицирован и поддерживает пользовательские прокси-серверы для ускорения, по умолчанию использует прокси `scoop.201704.xyz` для загрузки приложений.

```bash
# Добавить прокси
scoop config URL_PROXY "https://scoop.201704.xyz"

# Удалить прокси
scoop config rm URL_PROXY
```

### Способ 2: Установка на базе официального репозитория с прокси

Откройте `PowerShell` и выполните следующие команды для установки:

```bash
# установка
Set-ExecutionPolicy -ExecutionPolicy RemoteSigned -Scope CurrentUser
# irm -useb get.scoop.sh | iex
irm https://ghfast.top/raw.githubusercontent.com/lzwme/scoop-proxy-cn/main/install.ps1 | iex

# настройка
scoop config SCOOP_REPO https://ghfast.top/github.com/ScoopInstaller/Scoop

# добавить bucket spc
scoop bucket add spc https://gitee.com/wlzwme/scoop-proxy-cn.git
# перейти в каталог spc
cd "$env:USERPROFILE\scoop\buckets\spc"
# переключиться на ветку main
git fetch --all && git checkout -b main origin/main

# показать справку
scoop help

# установить 7zip, aria2, scoop-search...
scoop install spc/7zip spc/aria2 spc/scoop-search
```

### О `scoop-search`

Так как репозиторий `scoop-proxy-cn` синхронизирует более 14 тысяч приложений, официальная команда `scoop search`, написанная на PowerShell, работает очень медленно и практически не пригодна к использованию. Рекомендуется установить и использовать инструмент `scoop-search`, написанный на языке `go`. Пример:

```bash
scoop install scoop-search
# использование scoop-search
scoop-search act
```

## Часто задаваемые вопросы

### Проблемы с загрузкой из-за `aria2`

При установке `aria2` scoop использует его для ускоренной загрузки по частям. Однако некоторые прокси-адреса не поддерживают или блокируют частичные запросы от `aria2`. В этом случае можно отключить `aria2` командой:

```bash
scoop config aria2-enabled false
```

### Проблема `Hash Check Failed`

Некоторые приложения используют адреса загрузки для последних релизов, но при этом имеют жёстко заданные хэши. При выходе новой версии возникает ошибка `Hash Check Failed`. В таких случаях можно добавить параметр `-s` для игнорирования проверки. Пример:

```bash
scoop install scoop-search -s
```

### Что делать при неработающем прокси-сервере, требующем обновления

Если вы используете официальную версию Scoop с подпиской на ветку `main`, используются прокси для ускорения git-репозиториев и загрузок приложений. Если старый прокси перестал работать, обновление невозможно. Выполните следующие команды для переустановки:

```bash
# Сначала обновите scoop repo
scoop config scoop_repo https://ghfast.top/github.com/ScoopInstaller/Scoop.git

# Способ 1: обновить адрес репозитория spc bucket
git -C "$env:USERPROFILE\scoop\buckets\spc" remote set-url origin https://gitee.com/wlzwme/scoop-proxy-cn.git
# Если изменён путь buckets, выполните
git -C "$env:SCOOP\buckets\spc" remote set-url origin https://gitee.com/wlzwme/scoop-proxy-cn.git

# Способ 2: удалить и заново добавить bucket spc
scoop bucket rm spc
scoop bucket add spc https://gitee.com/wlzwme/scoop-proxy-cn.git
```

## Репозитории для синхронизации

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

## Заявление

> [!WARNING]
> Этот репозиторий содержит информацию о приложениях, синхронизированную только с сторонних репозиториев, без индивидуальной проверки работоспособности и безопасности. Пожалуйста, самостоятельно проверяйте и идентифицируйте при установке. В случае нарушения прав, пожалуйста, создайте issue для решения.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---