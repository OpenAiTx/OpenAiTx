# Letterboxd-to-IMDb

[![GitHub stars](https://img.shields.io/github/stars/TobiasPankner/Letterboxd-to-IMDb.svg?style=social&label=Star)](https://GitHub.com/TobiasPankner/Letterboxd-to-IMDb/stargazers/)
[![Donate](https://img.shields.io/badge/Donate-PayPal-green.svg)](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=3TU2XDBK2JFU4&source=url)

- [필수 조건](#prerequisites)
- [스크립트 실행하기](#run-the-script)
- [IMDb 쿠키 얻기](#getting-the-imdb-cookie)
- [일반적인 사용 사례](#common-use-cases)
- [명령줄 옵션](#command-line-options)

Letterboxd 영화 목록을 IMDb로 가져오는 파이썬 스크립트입니다.  

작동 방식:  
스크립트는 먼저 ZIP 파일 내 모든 Letterboxd 링크를 "방문"하여 해당 IMDb 페이지를 가져옵니다. 이렇게 하면 올바른 영화가 평가되는지 확인할 수 있습니다.  
그 후, 쿠키를 사용하여 내부 IMDb GraphQL 평점 API에 인증된 요청을 보냅니다.  

**사용 방법 동영상 튜토리얼**: <https://www.youtube.com/watch?v=KF7cfdUTEgw>

## 이 스크립트를 온라인에서 실행하기 (Python 불필요)

[![Run Script](https://simple-script.com/api/badge/letterboxd-to-imdb)](https://simple-script.com/app/letterboxd-to-imdb)

## 필수 조건  
  
- Python 3 ([다운로드](https://www.python.org/downloads/))
- [Letterboxd](https://letterboxd.com/) 계정
- [IMDb](https://www.imdb.com/) 계정

## 스크립트 실행하기

 1. Letterboxd 평점 및 감상 목록 내보내기 ([방법](https://listy.is/help/how-to-export-letterboxd-watchlists-reviews/))
 2. [IMDb 쿠키 얻기](#getting-the-imdb-cookie) 후 스크립트 폴더에 "cookie.txt"로 저장
 3. 의존성 설치: `pip install -r requirements.txt`
 4. letterboxd2imdb.py 실행: `python letterboxd2imdb.py -f <YOUR ZIP FILE>.zip`

[일반적인 사용 사례](#common-use-cases)

## IMDb 쿠키 얻기

**이 쿠키를 비밀번호처럼 다루세요!**

  1. IMDb 계정에 로그인하세요
  2. 크롬 개발자 도구 열기 -> 네트워크
  3. Fetch/XHR로 필터링
  4. 페이지 새로 고침
  5. 요청 중 하나의 쿠키 복사 (우클릭 -> 값 복사)
  
  ![예시](https://imgur.com/chRo9wj.jpg)  

## 일반적인 사용 사례

**평점과 시청 목록 전송:**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -w`

**평점 5/10인 시청 영화 전송:**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -r 5`

**평가되지 않은 시청 영화용 IMDb 목록 생성:**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -l`

**평가되지 않은 시청 영화용 사용자 지정 IMDb 목록 생성:**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -l --list-name "내 레터박스드 영화"`

## 명령줄 옵션

```
usage: letterboxd2imdb.py [-h] -f ZIPFILE [-p PARALLEL] [-c] [-r RATING] [-w] [-l] [--list-name LIST_NAME]

Imports your Letterboxd ratings and watchlist into IMDb. Can also create custom lists for unrated movies.

required arguments:
  -f ZIPFILE            The exported zip file from letterboxd

options:
  -h, --help            show this help message and exit
  -p PARALLEL           Urls to be processed in parallel (valid: 1 to 20)
  -c                    Add this flag to disable the history
  -r RATING             The rating to give watched but unrated movies. By default they are ignored (valid: 1 to 10)
  -w                    Add this flag to also transfer your watchlist
  -l                    Create an IMDb list for watched but unrated movies instead of rating them
  --list-name LIST_NAME Name for the IMDb list to create for unrated movies (default: 'Watched on Letterboxd - Unrated')
```
`-p`: 프로세스를 가속화하려면 사용할 수 있으며, 너무 높게 설정하면 속도 제한에 걸릴 수 있습니다. 기본값: 5  
`-c`: 기록이 문제를 일으키는 경우 이 플래그를 추가하여 비활성화할 수 있습니다.  
`-r`: 시청했지만 평가하지 않은 영화에 평점을 부여하는 데 사용할 수 있습니다. IMDb에는 "그냥 시청" 옵션이 없기 때문에 기본 평점을 지정해야 합니다.  
`-w`: 시청 목록도 전송하는 데 사용됩니다.  
`-l`: 임의의 평점을 부여하는 대신 시청했지만 평가하지 않은 영화에 대해 IMDb 리스트를 만듭니다. 이렇게 하면 시청한 영화를 추적하면서도 깔끔한 평점 데이터를 유지할 수 있습니다.  
`--list-name`: `-l` 옵션으로 생성된 IMDb 리스트에 사용자 지정 이름을 지정합니다. 기본값: "Watched on Letterboxd - Unrated"  

**참고:** `-r` 옵션과 `-l` 옵션은 상호 배타적입니다. 평가하지 않은 영화에 기본 평점을 부여하거나(`-r`), 리스트를 생성할 수 있지만(`-l`), 둘 다 동시에 사용할 수 없습니다.  
  
## 사용 예시  
  
**기본 가져오기 (평점만):**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip`  
*Letterboxd에서 평가한 영화만 IMDb로 가져옵니다. 평가하지 않은 영화는 무시됩니다.*  
  
**평점과 시청 목록 가져오기:**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -w`  
*Letterboxd의 영화 평점과 시청 목록을 모두 IMDb로 전송합니다.*  
  
**평가하지 않은 영화에 기본 평점 부여:**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -r 7`  
*평가한 영화와 시청했지만 평가하지 않은 모든 영화에 7/10의 기본 평점을 부여하여 가져옵니다.*  
  
**평가하지 않은 영화에 대한 리스트 생성:**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -l`  
*시청했지만 평가하지 않은 영화에 대해 "Watched on Letterboxd - Unrated"라는 IMDb 리스트를 생성합니다.*  
  
**평가하지 않은 영화에 대해 사용자 지정 이름의 리스트 생성:**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -l --list-name "My Letterboxd Backlog"`  
*평가하지 않은 시청 영화에 대해 사용자 지정 이름을 가진 IMDb 리스트를 생성합니다.*  
  
**병렬 처리로 빠른 실행:**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -p 15`  
*15개의 영화를 병렬로 처리하여 실행 속도를 높입니다 (속도 제한에 주의하세요).*  
  
**사용자 지정 설정으로 완전한 전송:**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -p 10 -r 5 -w`  
*빠른 처리(10병렬), 평점 및 시청 목록 가져오기, 평가하지 않은 영화에 5/10 평점 부여.*  
  

**감시 목록 및 빠른 처리로 사용자 지정 목록 만들기:**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -p 10 -l --list-name "My Letterboxd Movies" -w`  
*빠르게 처리하며, 감시 목록을 가져오고 평가하지 않은 영화에 대해 사용자 지정 이름의 목록을 만듭니다.*  
  
**기록 비활성화 (문제 해결용):**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -c`  
*기록 기능을 사용하지 않고 실행하며, 기록 파일 관련 문제가 있을 때 유용합니다.*  
  
**보수적 접근법 (느리지만 안전함):**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -p 1 -w`  
*등급과 감시 목록을 모두 가져오는 동안 속도 제한 문제를 피하기 위해 한 번에 한 영화씩 처리합니다.*


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-06

---