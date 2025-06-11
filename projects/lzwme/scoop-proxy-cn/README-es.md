# 🍡 scoop-proxy-cn

Repositorio espejo proxy de buckets de [Scoop](https://scoop.sh) adecuado para usuarios de China continental. Sincroniza actualizaciones desde múltiples repositorios `bucket` de código abierto. Entre ellos:

- Rama `sync` (por defecto): Sincroniza aplicaciones de múltiples repositorios sin modificar las direcciones para usar ghproxy. **Adecuado para escenarios que usan la versión modificada nacional de Scoop basada en gitee.**
- Rama `main`: Modifica las direcciones de descarga de aplicaciones desde `github release` para usar direcciones proxy basadas en `https://ghfast.top`. **Debido a que las direcciones proxy suelen cambiar por fallos y no son estables.**

## Uso

Agrega el repositorio de aplicaciones `spc`. Compatible con [scoop repositorio espejo nacional](https://gitee.com/scoop-installer/scoop):

```bash
# Agregar bucket, por defecto usa la rama sync
scoop bucket add spc https://gitee.com/wlzwme/scoop-proxy-cn.git

# instalar aplicaciones
scoop install spc/<app_name>
```

Si solo deseas usar la versión oficial de Scoop, puedes cambiar la rama de suscripción a la rama `main`:

```bash
# Ir al directorio spc
cd "$env:USERPROFILE\scoop\buckets\spc"
# Si tienes configurada la variable de entorno SCOOP, ejecuta:
cd "$env:SCOOP\buckets\spc"

# Cambiar a la rama main
git fetch --all
git checkout -b main origin/main
```

## Referencia de instalación y configuración de Scoop

### Método 1: Instalación basada en espejo nacional personalizado (recomendado)

Dado que el código fuente de scoop y las aplicaciones buckets se mantienen en github mediante git, el acceso a github es problemático en China, lo que empeora la experiencia de instalación, actualización y descarga de aplicaciones.

Aquí se presenta el método de instalación para el [repositorio espejo nacional de scoop](https://gitee.com/scoop-installer/scoop).

```bash
# Cambiar la política de ejecución del script, acepta automáticamente por defecto
Set-ExecutionPolicy RemoteSigned -scope CurrentUser -Force

# Método 1: Ejecutar el comando de instalación (se instala por defecto en el directorio de usuario, para cambiar usa el comando "directorio de instalación personalizado" abajo)
iwr -useb https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/scoop.201704.xyz | iex


## Método 2: Directorio de instalación personalizado (modifica la ruta a una adecuada)
irm https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/scoop.201704.xyz -outfile 'install.ps1'
.\install.ps1 -ScoopDir 'D:\Scoop' -ScoopGlobalDir 'D:\GlobalScoopApps'

# Si ya tienes instalado el origen oficial, cambia con:
scoop config SCOOP_REPO "https://gitee.com/scoop-installer/scoop"

# Agregar bucket spc
scoop bucket add spc https://gitee.com/wlzwme/scoop-proxy-cn.git

# Actualizar repositorio
scoop update
```

La versión instalada por este método está personalizada para soportar aceleradores proxy configurables, y usa por defecto `scoop.201704.xyz` para descargar aplicaciones.

```bash
# Agregar proxy
scoop config URL_PROXY "https://scoop.201704.xyz"

# Eliminar proxy
scoop config rm URL_PROXY
```

### Método 2: Instalación basada en el repositorio oficial con proxy

Abre `PowerShell` y ejecuta los siguientes comandos para instalar:

```bash
# instalar
Set-ExecutionPolicy -ExecutionPolicy RemoteSigned -Scope CurrentUser
# irm -useb get.scoop.sh | iex
irm https://ghfast.top/raw.githubusercontent.com/lzwme/scoop-proxy-cn/main/install.ps1 | iex

# configurar
scoop config SCOOP_REPO https://ghfast.top/github.com/ScoopInstaller/Scoop

# agregar bucket spc
scoop bucket add spc https://gitee.com/wlzwme/scoop-proxy-cn.git
# ir al directorio spc
cd "$env:USERPROFILE\scoop\buckets\spc"
# cambiar a la rama main
git fetch --all && git checkout -b main origin/main

# mostrar ayuda
scoop help

# instalar 7zip, aria2, scoop-search...
scoop install spc/7zip spc/aria2 spc/scoop-search
```

### Sobre `scoop-search`

Dado que el repositorio `scoop-proxy-cn` sincroniza más de 14,000 aplicaciones, el comando oficial `scoop search` basado en `PowerShell` es ineficiente y casi inutilizable. Se recomienda instalar y usar la herramienta `scoop-search` desarrollada en lenguaje `go` como reemplazo. Ejemplo:

```bash
scoop install scoop-search
# usar scoop-search
scoop-search act
```

## Preguntas frecuentes

### Problema de fallos en descarga causados por `aria2`

Cuando se instala `aria2`, scoop usa `aria2` para acelerar las descargas por fragmentos. Algunos proxies no soportan o bloquean solicitudes fragmentadas de `aria2`. En ese caso, desactiva `aria2` con el siguiente comando:

```bash
scoop config aria2-enabled false
```

### Problema `Hash Check Failed`

Algunas aplicaciones usan URLs de descarga de la última versión publicada junto con un hash fijo. Cuando hay una nueva versión, aparece el error `Hash Check Failed`. Para ignorarlo, añade el parámetro `-s` al instalar. Ejemplo:

```bash
scoop install scoop-search -s
```

### Cómo actualizar cuando falla el proxy

Cuando se usa la versión oficial de Scoop con la rama `main`, se usan proxies para acelerar las descargas. Si el proxy antiguo falla, no se puede actualizar. Para solucionarlo, ejecuta:

```bash
# Primero actualiza el repositorio scoop
scoop config scoop_repo https://ghfast.top/github.com/ScoopInstaller/Scoop.git

# Método 1: actualizar la URL remota del bucket spc
git -C "$env:USERPROFILE\scoop\buckets\spc" remote set-url origin https://gitee.com/wlzwme/scoop-proxy-cn.git
# Si cambiaste la ubicación por defecto de buckets, ejecuta:
git -C "$env:SCOOP\buckets\spc" remote set-url origin https://gitee.com/wlzwme/scoop-proxy-cn.git

# Método 2: eliminar y volver a agregar el bucket spc
scoop bucket rm spc
scoop bucket add spc https://gitee.com/wlzwme/scoop-proxy-cn.git
```

## Buckets sincronizados desde

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

## Declaración

> [!WARNING]
> La información de las aplicaciones contenida en este repositorio se sincroniza únicamente desde repositorios de terceros, sin realizar una verificación individual de usabilidad o seguridad. Por favor, verifique y reconozca por su cuenta antes de instalar. Si existe alguna infracción, por favor abra un issue para su gestión.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---