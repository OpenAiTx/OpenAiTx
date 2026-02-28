# ouch.yazi

[ouch](https://github.com/ouch-org/ouch) 플러그인으로 [Yazi](https://github.com/sxyazi/yazi)를 위한 플러그인입니다.

![ouch.yazi](https://github.com/ndtoan96/ouch.yazi/assets/33489972/946397ec-b37b-4bf4-93f1-c676fc8e59f2)

## 특징
- 아카이브 미리보기
- 압축

## 설치

### Yazi 패키지 관리자
```bash
ya pkg add ndtoan96/ouch
```

### Git
```bash
# Linux/macOS
git clone https://github.com/ndtoan96/ouch.yazi.git ~/.config/yazi/plugins/ouch.yazi

# Windows with cmd
git clone https://github.com/ndtoan96/ouch.yazi.git %AppData%\yazi\config\plugins\ouch.yazi

# Windows with powershell
git clone https://github.com/ndtoan96/ouch.yazi.git "$($env:APPDATA)\yazi\config\plugins\ouch.yazi"
```

[ouch](https://github.com/ouch-org/ouch)가 설치되어 있고 `PATH`에 포함되어 있는지 확인하세요.

## 사용법

### 미리보기
아카이브 미리보기를 위해 `yazi.toml`에 다음을 추가하세요:

```toml
[[plugin.prepend_previewers]]
mime = "application/{*zip,tar,bzip2,7z*,rar,xz,zstd,java-archive}"
run  = "ouch"
```
이제 Yazi에서 아카이브로 이동하면 미리보기 창에 아카이브의 내용이 표시됩니다. `J`와 `K`를 사용하여 미리보기를 위아래로 스크롤할 수 있습니다.

#### 사용자 정의

미리보기는 `run` 문자열에 추가 인수를 넣어 사용자 정의할 수 있습니다:


```toml
[plugin]
prepend_previewers = [
	# Change the top-level archive icon
	{ ..., run = "ouch --archive-icon='🗄️ '" },
	# Or remove it by setting it to ''
	{ ..., run = "ouch --archive-icon=''" },

	# Enable file icons
	{ ..., run = "ouch --show-file-icons" },

	# Disable tree view
	{ ..., run = "ouch --list-view" },

	# These can be combined
	{ ..., run = "ouch --archive-icon='🗄️ ' --show-file-icons --list-view" },
]
```

### 압축
압축을 위해, `keymap.toml`에 다음을 추가하세요:

```toml
[[mgr.prepend_keymap]]
on = ["C"]
run = "plugin ouch"
desc = "Compress with ouch"
```

플러그인은 기본적으로 `zip` 형식을 사용합니다. 출력 파일 이름을 지정할 때 형식을 변경할 수 있으며, `ouch`는 파일 확장자를 기반으로 형식을 감지합니다.

예를 들어 기본 형식을 `7z`로 설정하려면 `plugin ouch 7z`를 사용할 수 있습니다.

### 압축 해제
이 플러그인은 Yazi에서 이미 지원되기 때문에 압축 해제 기능을 제공하지 않습니다.
`ouch`로 압축을 해제하려면 `yazi.toml`에서 오프너를 구성하세요.

```toml
[opener]
extract = [
	{ run = 'ouch d -y %*', desc = "Extract here with ouch", for = "windows" },
	{ run = 'ouch d -y "$@"', desc = "Extract here with ouch", for = "unix" },
]
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-28

---