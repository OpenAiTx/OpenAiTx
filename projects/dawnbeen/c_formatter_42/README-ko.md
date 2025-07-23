<p align="center">
  <a style="text-decoration:none" href="https://badge.fury.io/py/c-formatter-42"><img src="https://badge.fury.io/py/c-formatter-42.svg" alt="PyPI version" height="20"></a>
  <a style="text-decoration:none" href="https://github.com/dawnbeen/c_formatter_42/actions"><img src="https://github.com/cacharle/c_formatter_42/actions/workflows/python-package.yml/badge.svg" height="20"></a>
  <a style="text-decoration:none" href="https://github.com/dawnbeen/c_formatter_42/actions"><img src="https://github.com/cacharle/c_formatter_42/actions/workflows/python-publish.yml/badge.svg" height="20"></a>
  <a style="text-decoration:none" href="https://pypi.org/project/c-formatter-42/"><img src="https://img.shields.io/pypi/pyversions/c-formatter-42" height="20"></a>
</p>

<br />

<p align="center">
  <img width="65%" align="center" src="https://raw.githubusercontent.com/dawnbeen/c_formatter_42/master/./img/final_back.png">
</p>

# c_formatter_42

42 규칙 v3에 맞는 C 언어 코드 예쁘게 만들어주는 도구입니다.
당신이 이미 좋은 인간 규칙을 알고 있다는 걸 압니다.
그저 편의를 위해 만든 것입니다.

## 설치 방법

Python3.8+ (3.9, 3.10, 3.11, 3.12) 필요

### PyPI에서 설치하기

```sh
pip3 install c-formatter-42
pip3 install --user c-formatter-42  # If you don't have root privileges
```


만약 Ubuntu 22.04 이상 버전(또는 PEP 668이 활성화된 모든 Debian 기반 시스템)을 사용 중이라면, 다음과 같은 오류가 발생할 수 있습니다:

`error: externally-managed-environment`

이 문제를 해결하려면 `--break-system-packages` 플래그를 추가하세요:


```sh
pip3 install --break-system-packages c-formatter-42
```
### 출처에서


```sh
git clone https://github.com/cacharle/c_formatter_42
cd c_formatter_42
pip3 install -e .
```
## 사용법

### 명령줄


```sh
c_formatter_42 < file.c
python3 -m c_formatter_42 < file.c  # If you get 'command not found' with the previous one

c_formatter_42 --help
usage: c_formatter_42 [-h] [-c] [FILE [FILE ...]]

Format C source according to the norm

positional arguments:
  FILE           File to format inplace, if no file is provided read STDIN

optional arguments:
  -h, --help     show this help message and exit
  -c, --confirm  Ask confirmation before overwriting any file
```


## 플러그인 / 확장 기능

### Vim

[`c_formatter_42.vim`](https://github.com/cacharle/c_formatter_42.vim) 플러그인을 확인하세요. 이 플러그인은 pip를 사용하여 `c_formatter_42` 패키지를 자동으로 설치합니다.

### Visual Studio Code

1. `c_formatter_42`를 설치하세요
1. [`keyhr.42-c-format`](https://marketplace.visualstudio.com/items?itemName=keyhr.42-c-format) 확장 기능을 설치하세요
1. `.vscode/settings.json`에서 C 파일의 기본 포매터로 `keyhr.42-c-format`을 설정하세요


```json
{
  "[c]": {
    "editor.defaultFormatter": "keyhr.42-c-format"
  }
}
```
## 기여하기

문제점을 보고하거나 기여해 주세요. :)

### 테스트 실행하기


```sh
pip3 install tox
tox
tox -e py311  # for a specific python version
```
### 새 버전 배포


```sh
pip3 install bumpversion
bumpversion [major|minor|patch]
git push
git push --tags
```


다음으로 이동: <https://github.com/dawnbeen/c_formatter_42/tags> 에서 방금 생성한 태그를 클릭하세요.  
그런 다음 `Create release from tag`를 클릭하면 파이프라인이 해당 버전을 빌드하고 배포합니다.  



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-23

---