<p align="center"><img src="https://ohmyzsh.s3.amazonaws.com/omz-ansi-github.png" alt="Oh My Zsh"></p>

Oh My Zsh คือเฟรมเวิร์กโอเพ่นซอร์สที่ขับเคลื่อนโดยชุมชน สำหรับการจัดการการตั้งค่า [zsh](https://www.zsh.org/) ของคุณ

ฟังดูน่าเบื่อ ลองใหม่อีกครั้ง

**Oh My Zsh จะไม่ทำให้คุณกลายเป็นนักพัฒนาระดับ 10x...แต่คุณอาจจะรู้สึกแบบนั้นก็ได้**

เมื่อคุณติดตั้งเรียบร้อยแล้ว เชลล์เทอร์มินัลของคุณจะกลายเป็นที่กล่าวถึง _หรือไม่ก็คืนเงิน!_ ด้วยทุกการกดแป้นพิมพ์ในพรอมต์คำสั่ง คุณจะได้ใช้ประโยชน์จากปลั๊กอินอันทรงพลังนับร้อยและธีมสวยงาม ผู้คนแปลกหน้าจะเดินเข้ามาหาคุณในคาเฟ่แล้วถามว่า _"นั่นมันสุดยอดมาก! คุณเป็นอัจฉริยะหรือเปล่า?"_

ในที่สุด คุณจะเริ่มได้รับความสนใจแบบที่คุณรู้สึกว่าควรได้ ...หรือบางทีคุณอาจจะใช้เวลาที่ประหยัดได้นั้นไปแปรงฟันด้วยไหมขัดฟันให้บ่อยขึ้น 😬

ต้องการเรียนรู้เพิ่มเติม เยี่ยมชม [ohmyz.sh](https://ohmyz.sh), ติดตาม [@ohmyzsh](https://x.com/ohmyzsh) บน X (เดิมคือ Twitter) และเข้าร่วมกับเราที่ [Discord](https://discord.gg/ohmyzsh)

[![CI](https://github.com/ohmyzsh/ohmyzsh/workflows/CI/badge.svg)](https://github.com/ohmyzsh/ohmyzsh/actions?query=workflow%3ACI)
[![X (formerly Twitter) Follow](https://img.shields.io/twitter/follow/ohmyzsh?label=%40ohmyzsh&logo=x&style=flat)](https://twitter.com/intent/follow?screen_name=ohmyzsh)
[![Mastodon Follow](https://img.shields.io/mastodon/follow/111169632522566717?label=%40ohmyzsh&domain=https%3A%2F%2Fmstdn.social&logo=mastodon&style=flat)](https://mstdn.social/@ohmyzsh)
[![Discord server](https://img.shields.io/discord/642496866407284746)](https://discord.gg/ohmyzsh)
[![Gitpod ready](https://img.shields.io/badge/Gitpod-ready-blue?logo=gitpod)](https://gitpod.io/#https://github.com/ohmyzsh/ohmyzsh)

<details>
<summary>สารบัญ</summary>

- [เริ่มต้นใช้งาน](#getting-started)
  - [ความเข้ากันได้ของระบบปฏิบัติการ](#operating-system-compatibility)
  - [ข้อกำหนดเบื้องต้น](#prerequisites)
  - [การติดตั้งพื้นฐาน](#basic-installation)
    - [การตรวจสอบด้วยตนเอง](#manual-inspection)
- [การใช้งาน Oh My Zsh](#using-oh-my-zsh)
  - [ปลั๊กอิน](#plugins)
    - [เปิดใช้งานปลั๊กอิน](#enabling-plugins)
    - [การใช้งานปลั๊กอิน](#using-plugins)
  - [ธีม](#themes)
    - [การเลือกธีม](#selecting-a-theme)
  - [คำถามที่พบบ่อย](#faq)
- [หัวข้อขั้นสูง](#advanced-topics)
  - [การติดตั้งขั้นสูง](#advanced-installation)
    - [ไดเรกทอรีที่กำหนดเอง](#custom-directory)
    - [การติดตั้งแบบไม่ต้องโต้ตอบ](#unattended-install)
    - [ติดตั้งจากรีโพ Fork](#installing-from-a-forked-repository)
    - [การติดตั้งด้วยตนเอง](#manual-installation)
  - [ปัญหาการติดตั้ง](#installation-problems)
  - [ปลั๊กอินและธีมที่กำหนดเอง](#custom-plugins-and-themes)
  - [เปิดใช้งาน GNU ls บน macOS และ freeBSD](#enable-gnu-ls-in-macos-and-freebsd-systems)
  - [ข้าม aliases](#skip-aliases)
  - [async git prompt](#async-git-prompt)
- [อัปเดต](#getting-updates)
  - [การแสดงผลการอัปเดต](#updates-verbosity)
  - [อัปเดตด้วยตนเอง](#manual-updates)
- [ถอนการติดตั้ง Oh My Zsh](#uninstalling-oh-my-zsh)
- [ฉันจะมีส่วนร่วมกับ Oh My Zsh ได้อย่างไร?](#how-do-i-contribute-to-oh-my-zsh)
  - [อย่าส่งธีมมาให้เรา](#do-not-send-us-themes)
- [ผู้มีส่วนร่วม](#contributors)
- [ติดตามเรา](#follow-us)
- [สินค้าที่ระลึก](#merchandise)
- [สัญญาอนุญาต](#license)
- [เกี่ยวกับ Planet Argon](#about-planet-argon)

</details>

## เริ่มต้นใช้งาน

### ความเข้ากันได้ของระบบปฏิบัติการ

| ระบบปฏิบัติการ | สถานะ |
| :------------- | :----: |
| Android        |   ✅   |
| freeBSD        |   ✅   |
| LCARS          |   🛸   |
| Linux          |   ✅   |
| macOS          |   ✅   |
| OS/2 Warp      |   ❌   |
| Windows (WSL2) |   ✅   |

### ข้อกำหนดเบื้องต้น

- ต้องติดตั้ง [Zsh](https://www.zsh.org) (v4.3.9 หรือใหม่กว่าใช้ได้ แต่แนะนำ 5.0.8 ขึ้นไป) หากยังไม่ติดตั้ง (รัน `zsh --version` เพื่อตรวจสอบ) โปรดดูคู่มือ [Installing ZSH](https://github.com/ohmyzsh/ohmyzsh/wiki/Installing-ZSH)
- ต้องติดตั้ง `curl` หรือ `wget`
- ต้องติดตั้ง `git` (แนะนำ v2.4.11 หรือใหม่กว่า)

### การติดตั้งพื้นฐาน

ติดตั้ง Oh My Zsh ได้โดยการรันคำสั่งใดคำสั่งหนึ่งต่อไปนี้ในเทอร์มินัล สามารถติดตั้งผ่าน command-line ด้วย `curl`, `wget` หรือเครื่องมือที่คล้ายกัน

| วิธี    | คำสั่ง                                                                                           |
| :-------- | :------------------------------------------------------------------------------------------------ |
| **curl**  | `sh -c "$(curl -fsSL https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)"` |
| **wget**  | `sh -c "$(wget -O- https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)"`   |
| **fetch** | `sh -c "$(fetch -o - https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)"` |

หากคุณอยู่ในประเทศที่มีการบล็อก `raw.githubusercontent.com` เช่น จีนหรืออินเดีย (บาง ISP) อาจต้องใช้ URL สำรองสำหรับติดตั้ง:

| วิธี    | คำสั่ง                                           |
| :-------- | :------------------------------------------------ |
| **curl**  | `sh -c "$(curl -fsSL https://install.ohmyz.sh/)"` |
| **wget**  | `sh -c "$(wget -O- https://install.ohmyz.sh/)"`   |
| **fetch** | `sh -c "$(fetch -o - https://install.ohmyz.sh/)"` |

_หมายเหตุ: ไฟล์ `.zshrc` เดิมจะถูกเปลี่ยนชื่อเป็น `.zshrc.pre-oh-my-zsh` หลังการติดตั้ง คุณสามารถย้ายการตั้งค่าที่ต้องการเก็บไว้ไปยัง `.zshrc` ใหม่ได้_

#### การตรวจสอบด้วยตนเอง

ควรตรวจสอบสคริปต์ติดตั้งจากโปรเจกต์ที่คุณยังไม่รู้จัก โดยดาวน์โหลดสคริปต์มาก่อน อ่านเนื้อหาให้แน่ใจว่าไม่มีอะไรผิดปกติแล้วจึงรัน

```sh
wget https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh
sh install.sh
```

หาก URL ข้างต้นใช้ไม่ได้หรือหมดเวลา ลองเปลี่ยนเป็น `https://install.ohmyz.sh` แทน

## การใช้งาน Oh My Zsh

### ปลั๊กอิน

Oh My Zsh มาพร้อมปลั๊กอินมากมายให้คุณใช้งาน ดูได้ที่ไดเรกทอรี [plugins](https://github.com/ohmyzsh/ohmyzsh/tree/master/plugins) หรือ [wiki](https://github.com/ohmyzsh/ohmyzsh/wiki/Plugins) เพื่อดูรายการทั้งหมด

#### เปิดใช้งานปลั๊กอิน

เมื่อคุณเจอปลั๊กอินที่อยากใช้กับ Oh My Zsh ให้เปิดใช้งานในไฟล์ `.zshrc` ซึ่งอยู่ในไดเรกทอรี `$HOME` ให้เปิดด้วย text editor ที่ชอบ แล้วเพิ่มชื่อปลั๊กอินที่ต้องการโหลด

```sh
vi ~/.zshrc
```

ตัวอย่างเช่น

```sh
plugins=(
  git
  bundler
  dotenv
  macos
  rake
  rbenv
  ruby
)
```

_หมายเหตุ: ปลั๊กอินแต่ละตัวแยกด้วยช่องว่าง (space, tab, ขึ้นบรรทัดใหม่...) **ห้าม** ใส่คอมม่า ไม่เช่นนั้นจะใช้งานไม่ได้_

#### การใช้งานปลั๊กอิน

แต่ละปลั๊กอินจะมี **README** อธิบายการใช้งาน รายการ aliases (ถ้ามี) และฟีเจอร์เพิ่มเติมในปลั๊กอินนั้น

### ธีม

ต้องยอมรับว่า ช่วงแรกของ Oh My Zsh เราคลั่งธีมมาก ตอนนี้มีธีมมากกว่า 150 แบบรวมมาให้แล้ว ส่วนใหญ่มี [ภาพตัวอย่าง](https://github.com/ohmyzsh/ohmyzsh/wiki/Themes) ใน wiki (กำลังอัปเดตเพิ่มเติม!) ลองเลือกดูได้เลย

#### การเลือกธีม

_ธีม Robby เป็นค่าเริ่มต้น มันไม่ใช่ธีมที่หรูหราหรือเรียบง่ายที่สุด แต่มันเป็นธีมที่ใช่ (สำหรับเขา)_

เมื่อเลือกธีมที่ต้องการได้แล้ว ให้แก้ไขไฟล์ `~/.zshrc` จะพบ environment variable (ตัวพิมพ์ใหญ่ทั้งหมด) ประมาณนี้

```sh
ZSH_THEME="robbyrussell"
```

ต้องการใช้ธีมอื่น ให้เปลี่ยนค่าให้ตรงกับชื่อธีมที่ต้องการ เช่น

```sh
ZSH_THEME="agnoster" # (นี่คือธีมหรูหราตัวหนึ่ง)
# ดู https://github.com/ohmyzsh/ohmyzsh/wiki/Themes#agnoster
```

<!-- prettier-ignore-start -->
> [!NOTE]
> คุณอาจเห็นภาพตัวอย่างธีม zsh แล้วลองใช้แต่พบว่ามันไม่เหมือนในภาพ
>
> เพราะธีมหลายตัวต้องติดตั้ง [Powerline Font](https://github.com/powerline/fonts) หรือ [Nerd Font](https://github.com/ryanoasis/nerd-fonts) เพื่อแสดงผลได้ถูกต้อง หากไม่มี จะเห็นสัญลักษณ์แปลกๆ ในพรอมต์ ดู [FAQ](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ#i-have-a-weird-character-in-my-prompt) สำหรับข้อมูลเพิ่มเติม
>
> และโปรดทราบว่าธีมจะควบคุมเฉพาะหน้าตาพรอมต์ (ข้อความก่อนหรือหลังเคอร์เซอร์ที่คุณพิมพ์คำสั่ง) เท่านั้น ธีมจะไม่ควบคุมสีของหน้าต่างเทอร์มินัล (_color scheme_) หรือฟอนต์ของเทอร์มินัล ซึ่งตั้งค่าได้ในโปรแกรมเทอร์มินัลของคุณ ดูรายละเอียด [what is a zsh theme](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ#what-is-a-zsh-theme)
<!-- prettier-ignore-end -->

เปิดหน้าต่างเทอร์มินัลใหม่ แล้วพรอมต์ของคุณจะมีหน้าตาประมาณนี้

![Agnoster theme](https://cloud.githubusercontent.com/assets/2618447/6316862/70f58fb6-ba03-11e4-82c9-c083bf9a6574.png)

หากยังไม่เจอธีมที่ถูกใจ ดูที่ wiki สำหรับ [ธีมเพิ่มเติม](https://github.com/ohmyzsh/ohmyzsh/wiki/External-themes)

หากอยากให้คอมพิวเตอร์เลือกธีมแบบสุ่มทุกครั้งที่เปิดเทอร์มินัล ให้ตั้งค่า

```sh
ZSH_THEME="random" # (...ขอให้เป็น pie... ขอเป็น pie ด้วยเถอะ..)
```

หรือจะสุ่มจากธีมโปรดที่เลือกไว้

```sh
ZSH_THEME_RANDOM_CANDIDATES=(
  "robbyrussell"
  "agnoster"
)
```

ถ้ารู้แค่ธีมที่ไม่ชอบ สามารถเพิ่มในรายการ ignore แบบนี้

```sh
ZSH_THEME_RANDOM_IGNORED=(pygmalion tjkirch_mod)
```

### คำถามที่พบบ่อย

มีคำถามหรือปัญหาอื่นๆ ดูคำตอบได้ใน [FAQ](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ)

## หัวข้อขั้นสูง

หากคุณชอบปรับแต่งแบบลึกๆ หัวข้อนี้เหมาะกับคุณ

### การติดตั้งขั้นสูง

ผู้ใช้บางคนอาจต้องการติดตั้ง Oh My Zsh ด้วยตนเอง หรือเปลี่ยน path หรือการตั้งค่าอื่นๆ ที่สคริปต์ติดตั้งรองรับ (ดูรายละเอียดที่ต้นสคริปต์ติดตั้ง)

#### ไดเรกทอรีที่กำหนดเอง

ตำแหน่งเริ่มต้นคือ `~/.oh-my-zsh` (ซ่อนใน home directory, เข้าถึงด้วย `cd ~/.oh-my-zsh`)

หากต้องการเปลี่ยนไดเรกทอรีติดตั้ง ให้ตั้งค่า environment variable `ZSH` ก่อนติดตั้ง เช่น

```sh
ZSH="$HOME/.dotfiles/oh-my-zsh" sh install.sh
```

#### การติดตั้งแบบไม่ต้องโต้ตอบ

เมื่อติดตั้ง Oh My Zsh แบบอัตโนมัติ สามารถส่ง flag `--unattended` ไปที่สคริปต์ `install.sh` จะไม่เปลี่ยน shell เอง และไม่รัน `zsh` หลังติดตั้งเสร็จ

```sh
sh -c "$(curl -fsSL https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)" "" --unattended
```

ถ้าอยู่ในจีน อินเดีย หรือประเทศที่บล็อก `raw.githubusercontent.com` ให้เปลี่ยน URL เป็น `https://install.ohmyz.sh`

#### ติดตั้งจากรีโพ Fork

สคริปต์ติดตั้งรองรับตัวแปรดังนี้ เพื่อให้ติดตั้งจากรีโพอื่น

- `REPO` (ค่าเริ่มต้น: `ohmyzsh/ohmyzsh`): ระบุเป็น `owner/repository` ถ้าตั้งค่าตัวนี้ สคริปต์จะค้นหาที่ `https://github.com/{owner}/{repository}`

- `REMOTE` (ค่าเริ่มต้น: `https://github.com/${REPO}.git`): URL เต็มของ git repository ใช้สำหรับ fork ที่ไม่ได้อยู่บน GitHub (GitLab, Bitbucket...) หรือ clone แบบ SSH (`git@github.com:user/project.git`)

  _หมายเหตุ: ไม่สามารถใช้ร่วมกับ `REPO` ค่านี้มีลำดับความสำคัญสูงกว่า_

- `BRANCH` (ค่าเริ่มต้น: `master`): ใช้กำหนด branch ที่ต้องการ checkout ขณะ clone เหมาะสำหรับทดสอบ Pull Request หรือใช้ branch อื่นนอกจาก `master`

ตัวอย่าง

```sh
REPO=apjanke/oh-my-zsh BRANCH=edge sh install.sh
```

#### การติดตั้งด้วยตนเอง

##### 1. โคลนรีโพสิโทรี

```sh
git clone https://github.com/ohmyzsh/ohmyzsh.git ~/.oh-my-zsh
```

##### 2. _เลือกได้_ สำรองไฟล์ `~/.zshrc` เดิม

```sh
cp ~/.zshrc ~/.zshrc.orig
```

##### 3. สร้างไฟล์ config ใหม่

สามารถสร้างไฟล์ config ใหม่โดย copy จากเทมเพลตที่ให้มา

```sh
cp ~/.oh-my-zsh/templates/zshrc.zsh-template ~/.zshrc
```

##### 4. เปลี่ยน shell เริ่มต้นของคุณ

```sh
chsh -s $(which zsh)
```

ต้อง log out และ log in ใหม่เพื่อให้เห็นผล

##### 5. เริ่มใช้งาน config ใหม่

เปิดหน้าต่างเทอร์มินัลใหม่ จะโหลด zsh พร้อม config ของ Oh My Zsh

### ปัญหาการติดตั้ง

หากติดตั้งแล้วมีปัญหา นี่คือวิธีแก้ที่พบบ่อย

- คุณ _อาจจะ_ ต้องแก้ไข `PATH` ใน `~/.zshrc` หากใช้บางคำสั่งไม่ได้หลังเปลี่ยนมาใช้ oh-my-zsh
- หากติดตั้งเองหรือเปลี่ยนตำแหน่งติดตั้ง ตรวจสอบตัวแปร `ZSH` ใน `~/.zshrc`

### ปลั๊กอินและธีมที่กำหนดเอง

ต้องการเปลี่ยนพฤติกรรมเริ่มต้นใดๆ ให้เพิ่มไฟล์ใหม่ (ลงท้ายด้วย `.zsh`) ในไดเรกทอรี `custom/`

ถ้ามีฟังก์ชันหลายตัวที่ใช้ร่วมกันได้ดี ให้รวมเป็นไฟล์ `XYZ.plugin.zsh` ใน `custom/plugins/` และเปิดใช้งานปลั๊กอินนี้

หากต้องการ override ฟังก์ชันของปลั๊กอินที่มากับ Oh My Zsh ให้สร้างปลั๊กอินชื่อเดียวกันใน `custom/plugins/` จะถูกโหลดแทนที่ของเดิมใน `plugins/`

### เปิดใช้งาน GNU ls บน macOS และ freeBSD

<a name="enable-gnu-ls"></a>

โดยปกติ Oh My Zsh จะใช้ BSD `ls` บน macOS และ FreeBSD ถ้าติดตั้ง GNU `ls` (ชื่อคำสั่ง `gls`) สามารถเลือกใช้แทนได้ ตั้งค่าด้วย zstyle ก่อน sourcing `oh-my-zsh.sh`:

```zsh
zstyle ':omz:lib:theme-and-appearance' gnu-ls yes
```

_หมายเหตุ: ไม่สามารถใช้ร่วมกับ `DISABLE_LS_COLORS=true`_

### ข้าม aliases

<a name="remove-directories-aliases"></a>

หากต้องการไม่ใช้ aliases เริ่มต้นของ Oh My Zsh (ที่กำหนดในไฟล์ `lib/*`) หรือ aliases ของปลั๊กอิน สามารถตั้งค่าต่อไปนี้ใน `~/.zshrc` **ก่อนโหลด Oh My Zsh** วิธีข้าม aliases มีหลายแบบ ขึ้นกับความต้องการ

```sh
# ข้าม aliases ทั้งหมด ทั้งใน lib และปลั๊กอินที่เปิดใช้
zstyle ':omz:*' aliases no

# ข้าม aliases ใน lib files ทั้งหมด
zstyle ':omz:lib:*' aliases no
# ข้ามเฉพาะ aliases ที่กำหนดใน directories.zsh
zstyle ':omz:lib:directories' aliases no

# ข้าม aliases ของปลั๊กอินทั้งหมด
zstyle ':omz:plugins:*' aliases no
# ข้ามเฉพาะ aliases ของ git plugin
zstyle ':omz:plugins:git' aliases no
```

สามารถใช้ร่วมกันแบบอื่นได้ โดย scope ที่เจาะจงกว่าจะมีลำดับความสำคัญสูงกว่า

```sh
# ข้าม aliases ของปลั๊กอินทั้งหมด ยกเว้น git
zstyle ':omz:plugins:*' aliases no
zstyle ':omz:plugins:git' aliases yes
```

เวอร์ชันก่อนของฟีเจอร์นี้เคยใช้การตั้งค่าด้านล่าง ซึ่งถูกถอดออกแล้ว

```sh
zstyle ':omz:directories' aliases no
```

ให้ใช้แบบนี้แทน

```sh
zstyle ':omz:lib:directories' aliases no
```

#### หมายเหตุ

> ฟีเจอร์นี้ยังอยู่ในช่วงทดสอบ อาจมีการเปลี่ยนแปลงในอนาคต และยังไม่รองรับ plugin manager เช่น zpm หรือ zinit ที่ไม่ได้ source สคริปต์ init (`oh-my-zsh.sh`) ที่มีฟีเจอร์นี้
>
> ยังไม่สามารถตรวจจับ "aliases" ที่นิยามเป็นฟังก์ชัน เช่น `gccd`, `ggf`, หรือ `ggl` จาก git plugin

### async git prompt

ฟังก์ชัน async prompt เป็นฟีเจอร์ทดลอง (รวมเมื่อ 3 เมษายน 2024) ช่วยให้ Oh My Zsh แสดงข้อมูล prompt แบบ asynchronous เพิ่มประสิทธิภาพการแสดง prompt แต่บาง setup อาจมีปัญหา หากพบปัญหา ให้ปิดฟีเจอร์นี้โดยเพิ่มบรรทัดใน .zshrc ก่อนโหลด Oh My Zsh

```sh
zstyle ':omz:alpha:lib:git' async-prompt no
```

หาก git prompt ไม่แสดงเลย ให้ลองบังคับด้วย config นี้ก่อน `oh-my-zsh.sh` หากยังไม่ได้ ให้แจ้งปัญหา

```sh
zstyle ':omz:alpha:lib:git' async-prompt force
```

## อัปเดต

โดยปกติ ระบบจะถามเพื่อเช็กอัปเดตทุก 2 สัปดาห์ สามารถเลือกโหมดอัปเดตอื่นได้โดยเพิ่มบรรทัดใน `~/.zshrc` **ก่อนโหลด Oh My Zsh**:

1. อัปเดตอัตโนมัติไม่ต้องยืนยัน

   ```sh
   zstyle ':omz:update' mode auto
   ```

2. แค่เตือนทุกกี่วัน หากมีอัปเดต

   ```sh
   zstyle ':omz:update' mode reminder
   ```

3. ปิดอัปเดตอัตโนมัติทั้งหมด

   ```sh
   zstyle ':omz:update' mode disabled
   ```

หมายเหตุ: ตั้งความถี่ในการเช็กอัปเดตได้ด้วย

```sh
# เช็กอัปเดตทุก 7 วัน
zstyle ':omz:update' frequency 7
# เช็กทุกครั้งที่เปิดเทอร์มินัล (ไม่แนะนำ)
zstyle ':omz:update' frequency 0
```

### การแสดงผลการอัปเดต

สามารถจำกัดข้อความแสดงผลขณะอัปเดตด้วยการตั้งค่า

```sh
zstyle ':omz:update' verbose default # แสดง prompt อัปเดตตามปกติ

zstyle ':omz:update' verbose minimal # แสดงไม่กี่บรรทัด

zstyle ':omz:update' verbose silent # แสดงเฉพาะ error
```

### อัปเดตด้วยตนเอง

หากต้องการอัปเดตทันที (เช่น มีปลั๊กอินใหม่ ไม่อยากรออัปเดตอัตโนมัติ) เพียงรัน

```sh
omz update
```

> [!NOTE]
> หากต้องการอัตโนมัติในสคริปต์ ให้เรียกสคริปต์ `upgrade` โดยตรง เช่น:
>
> ```sh
> $ZSH/tools/upgrade.sh
> ```
>
> ดูตัวเลือกเพิ่มเติมใน [FAQ: How do I update Oh My Zsh?](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ#how-do-i-update-oh-my-zsh)
>
> **ไม่รองรับ `omz update --unattended` อีกต่อไป เพราะมีผลข้างเคียง**

วิเศษ! 🎉

## ถอนการติดตั้ง Oh My Zsh

Oh My Zsh อาจไม่เหมาะกับทุกคน เราจะคิดถึงคุณ แต่เราต้องการให้แยกทางกันได้ง่าย

หากต้องการถอนการติดตั้ง `oh-my-zsh` เพียงรัน `uninstall_oh_my_zsh` จาก command-line ระบบจะลบตัวเองและคืนค่าการตั้งค่า `bash` หรือ `zsh` เดิมของคุณ

## ฉันจะมีส่วนร่วมกับ Oh My Zsh ได้อย่างไร?

ก่อนเข้าร่วมกับชุมชนของเรา กรุณาอ่าน [code of conduct](CODE_OF_CONDUCT.md)

ผมเองก็ไม่ใช่ผู้เชี่ยวชาญ [Zsh](https://www.zsh.org/) และเชื่อว่ามีวิธีพัฒนาให้ดีขึ้นอีกมาก — หากคุณมีไอเดียให้ config ดูแลง่ายขึ้น (และเร็วขึ้น) อย่าลังเลที่จะแตก branch แล้วส่ง pull request!

เราต้องการคนช่วยทดสอบ pull request ด้วย ดู [issue ที่เปิดอยู่](https://github.com/ohmyzsh/ohmyzsh/issues) แล้วช่วยกันได้เลย

ดูรายละเอียดเพิ่มเติมที่ [Contributing](CONTRIBUTING.md)

### อย่าส่งธีมมาให้เรา

ขณะนี้เรามีธีม (มากเกิน) พอแล้ว กรุณาเพิ่มธีมของคุณในหน้า [external themes](https://github.com/ohmyzsh/ohmyzsh/wiki/External-themes)

## ผู้มีส่วนร่วม

Oh My Zsh มีชุมชนผู้ใช้และผู้มีส่วนร่วมที่ยอดเยี่ยม หากไม่มีเวลาและความช่วยเหลือจากทุกท่าน โครงการนี้คงไม่เยี่ยมขนาดนี้

ขอบคุณมากๆ!

<a href="https://github.com/ohmyzsh/ohmyzsh/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=ohmyzsh/ohmyzsh" width="100%"/>
</a>

## ติดตามเรา

เรามีโซเชียลมีเดีย:

- [@ohmyzsh](https://x.com/ohmyzsh) บน X (เดิม Twitter) กดติดตามได้เลย
- [Facebook](https://www.facebook.com/Oh-My-Zsh-296616263819290/) ทักเราได้
- [Instagram](https://www.instagram.com/_ohmyzsh/) แท็กเราหากโพสต์เกี่ยวกับ Oh My Zsh!
- [Discord](https://discord.gg/ohmyzsh) มาคุยกับเรา!

## สินค้าที่ระลึก

เรามี [สติ๊กเกอร์ เสื้อยืด แก้วกาแฟ ฯลฯ](https://shop.planetargon.com/collections/oh-my-zsh?utm_source=github) ให้คุณแสดงความรักต่อ Oh My Zsh รับรองว่าคุณจะกลายเป็นที่พูดถึง!

## สัญญาอนุญาต

Oh My Zsh เผยแพร่ภายใต้ [MIT license](LICENSE.txt)

## เกี่ยวกับ Planet Argon

![Planet Argon](https://pa-github-assets.s3.amazonaws.com/PARGON_logo_digital_COL-small.jpg)

Oh My Zsh เริ่มต้นโดยทีมงาน [Planet Argon](https://www.planetargon.com/?utm_source=github) บริษัท [Ruby on Rails development agency](https://www.planetargon.com/services/ruby-on-rails-development?utm_source=github) ดู [โปรเจกต์โอเพ่นซอร์สอื่นๆ](https://www.planetargon.com/open-source?utm_source=github) ของเรา

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---