# Shape up 다운로더

## 무엇을 하나요?
이것은 [basecamp의 훌륭한 무료 shape up 책](https://basecamp.com/shapeup)을
단일의 독립형 HTML 파일로 다운로드하는 간단한 CLI 애플리케이션입니다.
* base64 이미지 사용
* 문서 내부 링크 사용
* 최소한의 CSS만 사용

## 왜 존재하나요?
이 책은 현재 HTML 형식으로 제공되며, 각 장이 하나의 문서이고 PDF 문서에서는 모든
장이 하나의 독립형 파일에 포함되어 있습니다. 책을 읽으면서 전자책 리더기에서 읽을 방법을
찾고 있었지만, 킨들에서 PDF를 읽는 것은 형편없고 PDF를 epub이나 mobi로 변환하는 것도
최고로 잘 되어도 불안정합니다. 이 특정 PDF를 생성하는 데 사용된 소프트웨어는 일부 문자 조합(예: "tf")을
합자(ligatures)가 있는 단일 UTF-8 코드포인트로 결합했습니다. 그러나 이것이 대부분의 변환 소프트웨어를
혼란스럽게 만듭니다.

그래서 이 프로젝트는 모든 웹 문서를 스타일 없이 단일 독립형 파일로 다운로드하고 결합하기 위해
탄생했습니다. 이 HTML 형식으로 책을 읽도록 의도된 것은 아니지만, 추가 변환 단계의
기반으로 사용할 수 있습니다.

파일을 더 유용한 형식으로 변환하려면 calibres의 `ebook-convert` 유틸리티를 사용하는 것을 권장합니다:
```bash
$ ebook-convert shape-up.html shape-up.epub \
    --authors "Ryan Singer" \
    --title "Shape Up: Stop Running in Circles and Ship Work that Matters" \
    --book-producer "Basecamp" \
    --publisher "Basecamp" \
    --language "en"
```
## 이 HTML/EPUB/MOBI 단일 페이지 버전을 어디서 다운로드할 수 있나요?
이 파일들을 호스팅하는 것에 대한 법적 영향이 확실하지 않아서 직접 호스팅하지 않고 있습니다.
직접 다운로드하는 코드는 여기 있지만, 직접 사용해야 합니다.

## 사용법
### 로컬 PHP

1. [PHP 설치](https://www.php.net/manual/en/install.php)
2. [Composer 설치](https://getcomposer.org/download/)
3. `php composer.phar install` 실행 (또는 composer가 전역에 설치된 경우 `composer install`)
4. `php cli.php download:single-html` 실행

이렇게 하면 현재 디렉터리에 `shape-up.html` 파일이 생성됩니다.
끝입니다.

### 도커 방식

PHP를 전혀 다루지 않는 방법이 있습니다. 이를 위해서는 도커 엔진이 설치되어 있으면 충분합니다.

사용법

```
docker run -it --rm -v $(pwd)/output:/app/output thej6s/shape-up-downloader

```
이 작업은 ./output 디렉토리에 `shape-up.html` 파일을 생성합니다  


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-19

---