# BookBounty

![Build Status](https://github.com/TheWicklowWolf/BookBounty/actions/workflows/main.yml/badge.svg)
![Docker Pulls](https://img.shields.io/docker/pulls/thewicklowwolf/bookbounty.svg)

<img src="/src/static/bookbounty.png" alt="image">


BookBounty is a tool for finding missing Readarr books.


## Run using docker-compose

```yaml
services:
  bookbounty:
    image: thewicklowwolf/bookbounty:latest
    container_name: bookbounty
    ports:
      - 5000:5000
    volumes:
      - /path/to/config:/bookbounty/config
      - /path/to/downloads:/bookbounty/downloads
      - /etc/localtime:/etc/localtime:ro
    restart: unless-stopped

```
---

## 환경 변수로 구성하기

일부 값들은 환경 변수를 통해 설정할 수 있습니다:

* __PUID__: 앱을 실행할 사용자 ID입니다. 기본값은 `1000`입니다.  
* __PGID__: 앱을 실행할 그룹 ID입니다. 기본값은 `1000`입니다.
* __readarr_address__: Readarr의 URL입니다. 기본값은 `http://192.168.1.2:8787`입니다.
* __readarr_api_key__: Readarr의 API 키입니다. 기본값은 ` `입니다.
* __libgen_address__: Library Genesis의 URL입니다. 현재 지원되는 URL은 `http://libgen.is`뿐입니다.
* __sleep_interval__: 다운로드 간 대기 시간(초)입니다. 기본값은 `0`입니다.
* __sync_schedule__: 실행할 예약 시간(24시간 기준, 쉼표로 구분된 값)입니다. 예: 14는 오후 2시를 의미합니다. 기본값은 ` `입니다.
* __minimum_match_ratio__: 매칭을 위한 최소 비율(%)입니다. 기본값은 `90`입니다.
* __selected_path_type__: 다운로드 구조 선택 (파일 또는 폴더). 기본값은 `file`입니다.
* __search_type__: 검색 유형 선택 (소설 또는 논픽션). 기본값은 `fiction`입니다.
* __library_scan_on_completion__: 완료 시 Readarr 라이브러리 스캔 여부. 기본값은 `True`입니다.
* __request_timeout__: 요청 타임아웃(초)입니다. 기본값은 `120`입니다.
* __thread_limit__: 사용할 최대 스레드 수입니다. 기본값은 `1`입니다.
* __selected_language__: 언어별 다운로드 필터 (특정 언어나 전체). 기본값은 `English`입니다. 이는 BookBounty가 Readarr 메타데이터 프로필에서 언어를 가져올 수 없을 때 사용됩니다.
* __preferred_extensions_fiction__: 소설 다운로드 필터 확장자(쉼표로 구분). 기본값은 `.epub, .mobi, .azw3, .djvu`입니다.
* __preferred_extensions_non_fiction__: 논픽션 다운로드 필터 확장자(쉼표로 구분). 기본값은 `.pdf .epub, .mobi, .azw3, .djvu`입니다.
* __search_last_name_only__: 검색 시 저자의 성만 사용합니다. 기본값은 `False`입니다.
* __search_shortened_title__: 검색 시 축약된 제목 사용 (`:` 이후 내용 제거). 기본값은 `False`입니다.


## 동기화 일정

쉼표로 구분된 시간 목록을 사용해 동기화를 시작합니다 (예: `2, 20`은 오전 2시와 오후 8시에 동기화를 시작).
> 참고: 예약된 시작 시간에서 최대 10분까지 지연이 있을 수 있습니다.


## Readarr 통합

BookBounty를 Readarr와 통합하는 두 가지 방법이 있습니다:

1. `/bookbounty/downloads`를 메인 Readarr 폴더에 직접 매핑하고 `selected_path_type=folder`로 설정합니다.  
   이 방법은 파일을 각 폴더에 직접 다운로드하기 전에 올바른 폴더 구조(`/author/book/filename.ext` 등)를 생성하려고 시도합니다.

2. 또는 `/bookbounty/downloads`를 `_unprocessed` 폴더에 매핑하고 `selected_path_type=file`로 설정합니다.
   This method downloads all files into a single folder. After a library scan in Readarr, some files may remain unmapped and require manual import.  
   After importing, you can use the "**Rename Files**" function in Readarr to organize the files into the correct folders.

For both methods, setting `library_scan_on_completion=True` automates the import process in Readarr.

**Note:** Readarr does not automatically rename files upon import.


---


<img src="/src/static/dark.png" alt="image">


---


<img src="/src/static/light.png" alt="image">


---

https://hub.docker.com/r/thewicklowwolf/bookbounty



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-14

---