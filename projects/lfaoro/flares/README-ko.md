# 플레어 🔥

플레어는 CloudFlare DNS 백업 도구로, DNS 테이블을 화면에 출력하거나 BIND 형식의 존 파일로 내보냅니다.

[![BSD 라이선스](https://img.shields.io/badge/license-BSD-blue.svg?style=flat)](LICENSE)
[![FOSSA 상태](https://app.fossa.io/api/projects/git%2Bgithub.com%2Flfaoro%2Fflares.svg?type=shield)](https://app.fossa.io/projects/git%2Bgithub.com%2Flfaoro%2Fflares?ref=badge_shield)
[![Go 리포트 카드](https://goreportcard.com/badge/github.com/lfaoro/flares)](https://goreportcard.com/report/github.com/lfaoro/flares)

![도커 풀](https://img.shields.io/docker/pulls/lfaoro/flares.svg?logo=docker&style=popout-square)
[![페이팔](https://img.shields.io/badge/paypal-contribute-blue.svg?style=popout-square&logo=paypal)](https://www.paypal.com/pools/c/8fm4OKBYMa)

## 빠른 시작

### [비디오 튜토리얼](https://asciinema.org/a/NLVa6TyQzvTEhnzZDdH1q79lO)

### 도커

```bash
# Fetch your CloudFlare API token from here:
# https://dash.cloudflare.com/profile/api-tokens
# -> Create Token
# -> Edit zone DNS
# -> Permission: read
# -> Zone resources: Include -> All zones

$ export CF_API_TOKEN="KClp4y8BgD2LQiz2..."

$ docker run -it --rm \
-e CF_API_TOKEN="$CF_API_TOKEN" \
lfaoro/flares domain1.tld domain2.tld
```
### macOS

```bash
brew install lfaoro/tap/flares
```

### 리눅스/BSD
```bash
curl https://raw.githubusercontent.com/lfaoro/flares/master/install.sh | bash
```
### 개발자
> Go 설치 프로그램: https://golang.org/dl/

```bash
go get -u github.com/lfaoro/flares
make install
flares -h

make test
```

## 예제

```bash
$ make install
$ flares -h

$ flares domain1.tld
;;
;; Domain:     domain1.tld
;; Exported:   2019-06-03 06:31:29
...continued

$ flares --export domain1.tld domain2.tld
BIND table for domain1.tld successfully exported
BIND table for domain2.tld successfully exported
$ ls
domain1.tld domain2.tld
```

## 자동화

### GitLab CI/CD

- 저장소 내에 [.gitlab-ci.yml](.gitlab-ci.yml) 복사
- [파이프라인 스케줄](https://gitlab.com/help/user/project/pipelines/schedules) 기능 사용
- 작업이 실행될 때마다 다운로드 가능한 아티팩트로 저장된 DNS 백업이 생성됨

# 기여하기

> 모든 도움과 제안은 매우 환영하며 감사드립니다. [이슈](https://github.com/lfaoro/flares/issues/new)를 열어 시작하세요.

- 프로젝트를 포크하세요
- 기능 브랜치 생성 `git checkout -b my-new-feature`
- 변경사항 커밋 `git commit -am 'Add my feature'`
- 브랜치에 푸시 `git push origin my-new-feature`
- 마스터 브랜치에 대한 새 풀 리퀘스트 생성


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-19

---