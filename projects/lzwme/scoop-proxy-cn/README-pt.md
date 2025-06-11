# 🍡 scoop-proxy-cn

Repositório de espelho proxy de buckets do [Scoop](https://scoop.sh) adequado para usuários da China continental. Sincroniza atualizações de vários repositórios `bucket` de código aberto. Entre eles:

- Ramo `sync` (padrão): Sincroniza aplicativos de vários repositórios, mas não faz modificações para proxy ghproxy. **Adequado para cenários que usam a versão modificada do Scoop no Gitee para a China**
- Ramo `main`: Modifica os endereços de download de aplicativos do `github release` para endereços proxy baseados em `https://ghfast.top`. **Como os endereços proxy frequentemente mudam devido a falhas, não é estável**

## Uso

Adicione o repositório de aplicativos `spc`. Compatível para uso com o [repositório otimizado de espelhos Scoop na China](https://gitee.com/scoop-installer/scoop):

```bash
# Adicionar bucket, busca o ramo sync por padrão
scoop bucket add spc https://gitee.com/wlzwme/scoop-proxy-cn.git

# instalar aplicativos
scoop install spc/<nome_do_app>
```

Se desejar usar apenas a versão oficial do Scoop, faça o seguinte para mudar o ramo do repositório para `main`:

```bash
# Entre no diretório spc
cd "$env:USERPROFILE\scoop\buckets\spc"
# Se a variável de ambiente SCOOP estiver configurada, execute:
cd "$env:SCOOP\buckets\spc"

# Mudar para o ramo main
git fetch --all
git checkout -b main origin/main
```

## Referência para instalação e configuração do Scoop

### Método 1: Instalação baseada em espelho personalizado nacional (recomendado)

Como o código-fonte do Scoop e os buckets são mantidos no GitHub, o acesso ao GitHub na China pode causar uma experiência ruim ao instalar, atualizar e baixar aplicativos.

A seguir está o método para instalar o [repositório otimizado de espelhos Scoop na China](https://gitee.com/scoop-installer/scoop).

```bash
# Alterar política de execução do script para aceitar automaticamente
Set-ExecutionPolicy RemoteSigned -scope CurrentUser -Force

# Método 1: executar o comando de instalação (instala por padrão no diretório do usuário, para alterar veja "diretório personalizado" abaixo)
iwr -useb scoop.201704.xyz | iex


## Método 2: diretório de instalação personalizado (modifique o diretório conforme necessário)
irm scoop.201704.xyz -outfile 'install.ps1'
.\install.ps1 -ScoopDir 'D:\Scoop' -ScoopGlobalDir 'D:\GlobalScoopApps'

# Se já tiver a fonte oficial instalada, pode alternar executando:
scoop config SCOOP_REPO "https://gitee.com/scoop-installer/scoop"

# Adicionar bucket spc
scoop bucket add spc https://gitee.com/wlzwme/scoop-proxy-cn.git

# Atualizar para puxar o novo endereço do repositório
scoop update
```

Esta versão do Scoop é customizada, suporta configuração de proxy personalizado para aceleração e usa por padrão o proxy `scoop.201704.xyz` para baixar aplicativos.

```bash
# Adicionar proxy
scoop config URL_PROXY "https://scoop.201704.xyz"

# Remover proxy
scoop config rm URL_PROXY
```

### Método 2: Instalação a partir do repositório oficial com proxy

Abra o `PowerShell` e execute os seguintes comandos para instalar:

```bash
# instalar
Set-ExecutionPolicy -ExecutionPolicy RemoteSigned -Scope CurrentUser
# irm -useb get.scoop.sh | iex
irm https://ghfast.top/raw.githubusercontent.com/lzwme/scoop-proxy-cn/main/install.ps1 | iex

# configurar
scoop config SCOOP_REPO https://ghfast.top/github.com/ScoopInstaller/Scoop

# adicionar bucket spc
scoop bucket add spc https://gitee.com/wlzwme/scoop-proxy-cn.git
# entrar no diretório spc
cd "$env:USERPROFILE\scoop\buckets\spc"
# mudar para o ramo main
git fetch --all && git checkout -b main origin/main

# mostrar ajuda
scoop help

# instalar 7zip, aria2, scoop-search...
scoop install spc/7zip spc/aria2 spc/scoop-search
```

### Sobre o `scoop-search`

Como o repositório `scoop-proxy-cn` sincroniza mais de `14.000` aplicativos, o comando oficial `scoop search` baseado em PowerShell é muito lento para usar. Recomenda-se instalar e usar a ferramenta `scoop-search` desenvolvida em `go`. Exemplo:

```bash
scoop install scoop-search
# usar scoop-search
scoop-search act
```

## Perguntas frequentes

### Problema de falha de download causado pelo `aria2`

Quando o `aria2` está instalado, o Scoop usa o `aria2` para acelerar o download com múltiplas conexões. Mas alguns proxies não suportam ou bloqueiam os downloads fragmentados do `aria2`. Neste caso, desative o `aria2` com:

```bash
scoop config aria2-enabled false
```

### Problema de `Hash Check Failed`

Alguns aplicativos configuram o endereço de download como a versão mais recente, mas também configuram um hash fixo. Quando há uma nova versão, ocorre erro `Hash Check Failed`. Use o parâmetro `-s` para ignorar o hash. Exemplo:

```bash
scoop install scoop-search -s
```

### Como lidar com proxies desatualizados que precisam ser atualizados

Quando se usa a versão oficial do Scoop e o ramo `main`, o proxy acelera o repositório git e os downloads de aplicativos. Se o proxy antigo falhar, o site não será atualizado. Execute os comandos seguintes para corrigir:

```bash
# Primeiro atualize o repositório scoop
scoop config scoop_repo https://ghfast.top/github.com/ScoopInstaller/Scoop.git

# Método 1: atualizar o repositório do bucket spc
git -C "$env:USERPROFILE\scoop\buckets\spc" remote set-url origin https://gitee.com/wlzwme/scoop-proxy-cn.git
# Se você modificou o local padrão dos buckets, execute:
git -C "$env:SCOOP\buckets\spc" remote set-url origin https://gitee.com/wlzwme/scoop-proxy-cn.git

# Método 2: remover e adicionar novamente o bucket spc
scoop bucket rm spc
scoop bucket add spc https://gitee.com/wlzwme/scoop-proxy-cn.git
```

## Buckets sincronizados de

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

## Declaração

> [!WARNING]
> Este repositório contém informações de aplicativos sincronizadas apenas de repositórios de terceiros, sem verificação individual de usabilidade ou segurança. Por favor, verifique e identifique por conta própria antes de instalar. Em caso de violação de direitos autorais, por favor, abra issues para resolução.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---