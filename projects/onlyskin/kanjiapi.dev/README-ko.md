# kanjiapi.dev: 현대적인 한자용 JSON API

13,000개 이상의 한자를 [https://kanjiapi.dev](https://kanjiapi.dev)에서 제공합니다

## 링크
- API 문서: https://kanjiapi.dev/#!/documentation
- 어떤 한자가 어떤 목록에 있는지 이해하는 데 도움: https://onlyskin.dev/official-kanji-list-diffs/

## 커피 한 잔 사주세요

https://buymeacoffee.com/onlyskin

## 예시

### 한자 `/v1/kanji/{character}`
```
$ curl https://kanjiapi.dev/v1/kanji/猫
{
  "kanji": "猫",
  "grade": 8,
  "stroke_count": 11,
  "meanings": [
    "cat"
  ],
  "kun_readings": [
    "ねこ"
  ],
  "on_readings": [
    "ビョウ"
  ],
  "name_readings": [],
  "jlpt": 2,
  "unicode": "732b"
}
```

```javascript
> fetch('https://kanjiapi.dev/v1/kanji/猫').then(r => r.json()).then(console.log);
{
  "kanji": "猫",
  "grade": 8,
  "stroke_count": 11,
  "meanings": [
    "cat"
  ],
  "kun_readings": [
    "ねこ"
  ],
  "on_readings": [
    "ビョウ"
  ],
  "name_readings": [],
  "jlpt": 2,
  "unicode": "732b"
}
```
#### 지원되는 모든 한자 목록

`$ curl https://kanjiapi.dev/v1/kanji/all`

#### 상용 한자 목록

`$ curl https://kanjiapi.dev/v1/kanji/joyo` (또는 `/jouyou`)

상용 한자는 일본 정부가 지정한 일반 사용 한자입니다.  
Unihan 데이터베이스는 추가로 4개의 한자를 상용 한자로 분류하여 총 2140개의 코드포인트가 있습니다.  
이는 상용 한자 중 4개가 JIS X 0208 인코딩에 없기 때문에, JIS X 0208에 포함된 다른 한자가  
역사적으로 사용되었기 때문입니다. 따라서 Unihan 데이터베이스에서는 공식 4개의 한자와  
JIS X 0208 호환 한자 4개 모두를 상용 한자로 표시합니다. 이는 kanjiapi.dev에서 제공하는  
`/joyo` 목록에도 반영되어 있습니다.

영향을 받는 문자들은 다음과 같습니다:  
| 공식 상용 한자 | 역사적 JIS X 0208 호환 한자 |  
| --- | --- |  
|𠮟 U+20B9F |叱 U+53F1|  
|塡 U+5861  |填 U+586B|  
|剝 U+525D  |剥 U+5265|  
|頰 U+9830  |頬 U+982C|

#### 인명용 한자 목록

`$ curl https://kanjiapi.dev/v1/kanji/jinmeiyo` (또는 `/jinmeiyou`)

참고로, 인명용 목록에 있는 82개의 한자는 유니코드 CJK 호환 코드 블록에 코드포인트가 있습니다.  
따라서 때때로 다른 문자와 “같은 한자”로 취급되기도 합니다. 이는 Unihan 데이터베이스에서  
유니코드로 명시되어 있습니다.

`kanjiapi.dev`는 이러한 CJK 호환 코드포인트에 대해 `/kanji/{character}` 엔드포인트를 제공하지만,  
문자의 통합된 버전을 쉽게 접근할 수 있도록 특별한 필드를 추가했습니다. 또한, 이러한  
호환 문자는 대부분 동등한 `/words/{character}` 엔드포인트 파일에 단어가 없으며,  
`/kanji/{character}` 엔드포인트 필드의 정보도 훨씬 제한적입니다. 이는 데이터가 존재하는 것을 반영합니다.





`KANJIDIC` 파일에서.

예를 들어, 진메이요 문자 海 (U+FA45)는 유니코드에서
조요 문자 海 (U+6d77)와 동일한 것으로 간주됩니다. 따라서 진메이요 버전은
CJK 호환 블록에 존재합니다.

이것은 소프트웨어의 어떤 계층(예: 브라우저 캐싱, URL
인코딩)이 유니코드 정규화를 수행할 수 있기 때문에 문제입니다. 이 경우 진메이요
문자가 다른 문자로 변환될 수 있습니다. 진메이요 문자를 볼 것으로 기대했는데,
조요 문자가 보인다면, 아마 이 때문일 것입니다.

필요하다면, CSS 속성 `font-variant-east-asian: traditional;`을
사용하여 브라우저에게 통합된 동등 문자을 전통적인 방식으로 표시하도록
지시할 수 있습니다. 이는 조요 문자 코드포인트가 진메이요 대응 문자로
표시된다는 의미입니다.

#### 헤이시히 히라가나 목록

`$ curl https://kanjiapi.dev/v1/kanji/heisig`

헤이시히 키워드가 할당된 문자 목록입니다. 참고로, 헤이시히 목록에는
정상 키워드 뒤에 '[alt]'가 붙은 네 개의 추가 한자가 있습니다.
이들은 누락된 JIS X 0208 한자의 네 개 공식 조요 변형입니다 (헤이시히 책 시리즈는
이 키워드를 JIS 호환 문자에 할당했지만, 이를 찾는 사람은 JIS 호환 버전이나
공식 버전 중 어느 쪽에서 올 수 있습니다). 위의 `조요 한자 목록` 섹션을
참조하세요.

#### 특정 학년의 한자 목록

`$ curl https://kanjiapi.dev/v1/kanji/grade-1` (학교 1~6학년, 8학년은 고등학교 나머지 학년을 표시)

### `/v1/reading/{reading}` 읽기
```
$ curl https://kanjiapi.dev/v1/reading/クウ
{
  "reading": "クウ",
  "main_kanji": [
    "宮",
    "供",
    "空",
    "咼",
    "啌",
    "喎",
    "垙",
    "瘸",
    "盉",
    "舙"
  ],
  "name_kanji": []
}
```

```javascript
> fetch('https://kanjiapi.dev/v1/reading/クウ').then(r => r.json()).then(console.log);
{
  "reading": "クウ",
  "main_kanji": [
    "宮",
    "供",
    "空",
    "咼",
    "啌",
    "喎",
    "垙",
    "瘸",
    "盉",
    "舙"
  ],
  "name_kanji": []
}
```

### 단어 `/v1/words/{character}`
```
$ curl https://kanjiapi.dev/v1/words/猫
[
  {
    "variants": [
      {
        "written": "どら猫",
        "pronounced": "どらねこ",
        "priorities": []
      }
    ],
    "meanings": [
      {
        "glosses": [
          "stray cat"
        ]
      }
    ]
  },
  {
    "variants": [
      {
        "written": "アンゴラ猫",
        "pronounced": "アンゴラねこ",
        "priorities": []
      }
    ],
    "meanings": [
      {
        "glosses": [
          "Angora cat"
        ]
      }
    ]
  },
  ...
]
```

```javascript
> fetch('https://kanjiapi.dev/v1/reading/クウ').then(r => r.json()).then(console.log);
[
  {
    "variants": [
      {
        "written": "どら猫",
        "pronounced": "どらねこ",
        "priorities": []
      }
    ],
    "meanings": [
      {
        "glosses": [
          "stray cat"
        ]
      }
    ]
  },
  {
    "variants": [
      {
        "written": "アンゴラ猫",
        "pronounced": "アンゴラねこ",
        "priorities": []
      }
    ],
    "meanings": [
      {
        "glosses": [
          "Angora cat"
        ]
      }
    ]
  },
  ...
]
```
## 개발:

### 요구 사항:

`python 3`, `make` 및 `node`가 사용 가능하다고 가정합니다.

### 설정:

requirements.txt를 사용하여 파이썬 라이브러리를 설치합니다.

`yarn` 또는 `npm install`을 사용하여 노드 종속성을 설치합니다.

[EDRDG](http://www.edrdg.org/wiki/index.php/KANJIDIC_Project)에서 한자 사전 파일 `kanjidic2.xml`을 프로젝트 루트에 저장하고 압축을 풉니다.

[EDRDG](http://www.edrdg.org/wiki/index.php/JMdict-EDICT_Dictionary_Project)에서 jmdict 사전 파일 `JMdict`를 프로젝트 루트에 저장하고 압축을 풉니다.

[Unicode](https://www.unicode.org/versions/components-15.0.0.html)에서 Unihan.zip의 파일 Unihan_OtherMappings.txt를 프로젝트 루트에 저장하고 압축을 풉니다.

[Unicode](https://www.unicode.org/versions/components-15.0.0.html)에서 Unihan.zip의 파일 Unihan_IRGSources.txt를 프로젝트 루트에 저장하고 압축을 풉니다.

파비콘 생성을 위해 시스템에 `System/Library/Fonts/ヒラギノ丸ゴ\ ProN\ W4.ttc` 폰트가
설치되어 있는지 확인합니다.

### 빌드:

`make`를 실행하여 사이트 및 API 엔드포인트를 정적 자산으로 빌드합니다.

`python -m pytest tests`를 실행하여 테스트를 수행합니다.

참고: 사이트의 로컬 빌드에서 API의 로컬 빌드 데이터를 가져오려면, 파일서버의 루트를 out/site로 설정할 수 있습니다 (예: `serveit`: `serveit -s out/site make`). 이를 위해 out/site 내에 out/v1에 대한 심볼릭 링크가 있습니다.

참고: 유니코드 CJK 호환 블록의 문자에 대한 엔드포인트 파일은 일부 파일 시스템이 비호환 등가 문자로 정규화하기 때문에 별도의 디렉터리에 작성됩니다. 이로 인해 일부 `/kanji/{character}` 및 `/words/{character}` 엔드포인트가 로컬 개발 중 API의 일반 경로에서 표시되지 않을 수 있습니다.








### 배포 (구글 클라우드 계정 자격 증명 필요):

#### 버전 관리

배포용 API 버전은 `api_data.py`와 `makefile`에 하드코딩되어 있습니다.


#### 버킷에 업로드

빌드 후, 빌드된 자산을 웹사이트 버킷과 동기화하려면 다음을 실행하세요:

참고: 모든 명령을 먼저 `rsync -n`으로 실행하여 시뮬레이션하는 것이 좋습니다.

빌드된 사이트 디렉토리(`out/site`)를 버킷 루트와 비재귀적으로 동기화하려면:
`gsutil -m rsync -c -d -x ".*\.map$" out/site gs://kanjiapi.dev`

빌드된 API 디렉토리 폴더들(`out/{version}`)을 파일 해시 기준으로 버킷 내 `/{version}` 디렉토리와 재귀적으로 동기화하려면:
`gsutil -m -h "Content-Type:application/json" rsync -r -c -d out/v1/kanji gs://kanjiapi.dev/v1/kanji/`
`gsutil -m -h "Content-Type:application/json" rsync -r -c out/v1/kanji_cjk gs://kanjiapi.dev/v1/kanji/`
`gsutil -m -h "Content-Type:application/json" rsync -r -c -d out/v1/words gs://kanjiapi.dev/v1/words/`
`gsutil -m -h "Content-Type:application/json" rsync -r -c out/v1/words_cjk gs://kanjiapi.dev/v1/words/`
`gsutil -m -h "Content-Type:application/json" rsync -r -c -d out/v1/reading gs://kanjiapi.dev/v1/reading/`

#### CORS 정책 설정:

CORS 정책은 `cors.json`에 저장되어 있으며, 이 파일을 수정한 후 `gsutil cors set cors.json gs://kanjiapi.dev`를 실행하여 업데이트할 수 있습니다.

### 로깅:

로그 파일은 API용 클라우드 스토리지 버킷에서 생성되며,
로그 파일이 작성될 때마다 트리거되는 클라우드 함수가 있습니다.
이 클라우드 함수는 로그 파일을 읽어 유용한 정보를 집계하고,
[로그 페이지](https://kanjiapi.dev/#!/logs)에 표시합니다.

클라우드 함수는 `popularity-contest` 디렉토리에 있습니다.

배포하려면 다음 명령을 실행하세요: `gcloud functions deploy popularity-contest --gen2
--region=us-west1 --runtime=python310 --source popularity-contest --entry-point
handle --trigger-bucket=kanjiapi-dev-logging --trigger-location=us` from the

프로젝트의 루트. (인증 필요)

클라우드 함수를 로컬에서 실행하려면 `popularity-contest` 디렉터리로 이동하고,
해당 하위 디렉터리의 `requirements.txt` 파일을 기반으로 가상 환경을 생성 및/또는 활성화한 후,
`python main.py`를 실행합니다. 이는 클라우드 함수를 배포하거나 트리거하지 않고
일부 로그 파일을 수동으로 (재)처리하는 데 유용합니다. (인증 필요)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-03

---