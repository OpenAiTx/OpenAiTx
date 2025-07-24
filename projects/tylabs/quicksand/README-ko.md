# QuickSand 버전 2

QuickSand 파이썬 패키지 및 명령줄 도구

QuickSand는 의심되는 악성 문서를 분석하여 다양한 인코딩 또는 압축 스트림 내의 익스플로잇을 식별하는 파이썬 기반 분석 프레임워크입니다. QuickSand는 문서, PDF, Mime/이메일, 포스트스크립트 및 기타 일반 형식을 지원합니다. 내장된 명령줄 도구는 단일 문서 또는 문서 디렉터리를 처리할 수 있습니다.

QuickSand는 문서 및 PDF의 디코딩된 스트림 내에서 Yara 시그니처를 사용하여 익스플로잇 또는 고위험 활성 콘텐츠를 식별합니다.

설치 없이 사용해 볼 수 있는 호스팅 버전이 [scan.tylabs.com](https://scan.tylabs.com/)에 제공됩니다.


## 파일:

- src/quicksand/quicksand.py: 주요 quicksand 클래스 및 CLI 도구

- src/quicksand/quicksand_exe.yara: 실행 파일 탐지용 Yara 규칙

- src/quicksand/quicksand_exploits.yara: 문서 내 익스플로잇 탐지용 Yara 규칙

- src/quicksand/quicksand_pdf.yara: PDF 내 익스플로잇 탐지용 Yara 규칙

- bin/quicksand: 명령줄 도구

- requirements.txt: 파이썬 의존성

- [lambda/](https://raw.githubusercontent.com/tylabs/quicksand/main/lambda/README.md) 선택적 AWS Lambda 함수


### 감사의 말씀을 드립니다:

- pdfreader

- oletools

- cryptography

- zipfile38

- olefile

- yara-python (버전 4.3.0 이상 필요)

- yara


## pip를 사용한 Pypi에서 설치 방법

```
pip3 install quicksand
```


## Upgrade from Pypi using pip

```
pip3 install --upgrade quicksand
```

## 소스에서 설치하기

GitHub에서 다운로드한 uicksand-main.zip과 같은 소스에서 설치하려면:

```
pip3 install quicksand-main.zip
```

## 명령줄 사용법

json 또는 txt 결과를 처리하고 출력하기 위한 quicksand용 명령줄 도구입니다.


```
usage: quicksand [-h] [-v] [-c] [-y] [-t TIMEOUT] [-e EXPLOIT] [-x EXE] [-a PDF] [-f {json,txt}] [-o OUT] [-p PASSWORD]
                 [-d DROPDIR]
                 document

QuickSand Document and PDF maldoc analysis tool.

positional arguments:
  document              document or directory to scan

optional arguments:
  -h, --help            show this help message and exit
  -v, --verbose         increase output verbosity
  -c, --capture         capture stream content
  -y, --yara            capture yara matched strings
  -t TIMEOUT, --timeout TIMEOUT
                        timeout in seconds
  -e EXPLOIT, --exploit EXPLOIT
                        yara exploit signatures
  -x EXE, --exe EXE     yara executable signatures
  -a PDF, --pdf PDF     yara PDF signatures
  -f {json,txt}, --format {json,txt}
                        output format
  -o OUT, --out OUT     save output to this filename
  -p PASSWORD, --password PASSWORD
                        password to decrypt ole or pdf
  -d DROPDIR, --dropdir DROPDIR
                        save objects to this directory

```

### 단일 파일 처리

```
quicksand document.doc
```

### 파일 디렉토리 처리

```
quicksand malware/
```

## 파이썬 모듈 사용법


### 메모리에서 파일 사용하기

```
from quicksand.quicksand import quicksand
import pprint

qs = quicksand(data, timeout=18, strings=True)
qs.process()
pprint.pprint(qs.results)
```

### 파일 이름을 사용한 처리

```
from quicksand.quicksand import quicksand

qs2 = quicksand("file.doc")
qs2.process()
qs.results
```

### 디렉터리 처리

```
from quicksand.quicksand import quicksand
qs = quicksand.readDir("malware")
qs
```
파일 이름과 `qs_results`의 딕셔너리 {filename: `qs_results`,...}를 반환합니다.


### 선택적 초기화 값

- capture: True|False 추출된 스트림의 내용을 반환

- debug: True|False 디버깅 메시지를 stdout에 출력

- exploityara: 익스플로잇 yara 규칙 경로

- execyara: 실행 파일 yara 규칙 경로

- pdfyara: PDF 익스플로잇 yara 규칙

- password: 암호화된 문서/PDF의 비밀번호

- timeout: 처리 타임아웃: 0은 무제한


## 점수 매기기

문서는 관련 Yara 서명 메타데이터의 순위 값에 따라 점수가 매겨집니다.

또한 각 서명은 감지된 항목이 익스플로잇인지, 경고인지, 위험한 기능인지 정의합니다. 결과 해석에 대한 자세한 내용은 [https://scan.tylabs.com/howto](https://quicksand.io/howto)를 참조하십시오.

자체 서명을 추가하는 경우, 기능을 위해 추가 메타데이터를 포함할 필요는 없습니다.

### MacOS에서의 zlib 문제

MacOS 사용자는 MacOS 10.4 이후 OpenSSL 헤더가 없기 때문에 zlib 문제(PDF FlateDecode 등)를 겪을 수 있습니다.


```
zlib.error: Error -3 while decompressing data: unknown compression method
zlib.error: Error -3 while decompressing data: incorrect header check
```

한 가지 해결책은 Brew.sh로 zlib를 설치하고 pyenv를 사용하여 Python 3을 다시 설치하는 것입니다:

```
export LDFLAGS="-L/usr/local/opt/zlib/lib"
export CPPFLAGS="-I/usr/local/opt/zlib/include"
pyenv install 3.8.5
```

## 퀵샌드 사용 중이신가요?

[알려주세요](https://tylabs.com) @tylabs


## 문제 및 프로젝트 홈

[QuickSand GitHub](https://github.com/tylabs/quicksand/)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-24

---