<div align="center">

<h1 style="border-bottom: none">
    <b><a href="https://next.yearning.io">Yearning</a></b><br />
</h1>
</div>

 견고하고 로컬에 배포되는 플랫폼으로, DB 관리자와 개발자를 위해 설계된 원활한 SQL 감지 및 쿼리 감사 환경을 제공합니다. 프라이버시와 효율성에 중점을 두어, MYSQL 감사를 위한 직관적이고 안전한 환경을 제공합니다.

---
[![OSCS Status](https://www.oscs1024.com/platform/badge/cookieY/Yearning.svg?size=small)](https://www.murphysec.com/dr/nDuoncnUbuFMdrZsh7)
![Platform Support](https://img.shields.io/badge/-x86_x64%20ARM%20Supports%20%E2%86%92-rgb(84,56,255)?style=flat-square&logoColor=white&logo=linux)
[![][github-license-shield]][github-license-link]
![GitHub top language](https://img.shields.io/github/languages/top/cookieY/Yearning?color=369eff&label=golang&labelColor=black&logo=golang&logoColor=white&style=flat-square)
[![][github-forks-shield]][github-forks-link]
[![][github-stars-shield]][github-stars-link]
[![Downloads](https://img.shields.io/github/downloads/cookieY/Yearning/total?labelColor=black&logo=download&logoColor=white&style=flat-square)](https://github.com/cookieY/Yearning/releases/latest)

English | [简体中文](https://raw.githubusercontent.com/cookieY/Yearning/next/README.zh-CN.md) | [日本語](https://raw.githubusercontent.com/cookieY/Yearning/next/README.ja-JP.md)

## ✨ 주요 기능

- **AI 어시스턴트**: AI 어시스턴트가 실시간으로 SQL 최적화 제안을 제공하여 SQL 성능을 향상시킵니다. 또한 텍스트-투-SQL 변환을 지원하여, 사용자가 자연어로 입력하면 최적화된 SQL 문을 받을 수 있습니다.
  
- **SQL 감사**: 승인 워크플로우와 자동 구문 검사를 포함한 SQL 감사 티켓을 생성합니다. SQL 문이 정확성, 보안성, 규정 준수 여부를 검증합니다. DDL/DML 작업에 대한 롤백 문이 자동으로 생성되며, 추적을 위한 포괄적인 이력 로그가 제공됩니다.

- **쿼리 감사**: 사용자 쿼리 감사를 지원하며, 데이터 소스 및 데이터베이스를 제한하고 민감한 필드를 익명화합니다. 쿼리 기록은 추후 참조를 위해 저장됩니다.

- **검사 규칙**: 자동 구문 검사기는 다양한 검사 규칙을 지원하여 대부분의 자동 검사 시나리오에 적합합니다.

- **프라이버시 중점**: Yearning은 로컬 배포가 가능한 오픈소스 솔루션으로, 데이터베이스와 SQL 문서의 보안을 보장합니다. 민감한 데이터를 보호하기 위한 암호화 메커니즘이 포함되어 있어, 비인가 접근 시에도 안전하게 데이터를 보호합니다.

- **RBAC(역할 기반 접근 제어)**: 특정 권한이 부여된 역할을 생성 및 관리하여, 사용자 역할에 따라 쿼리 작업 주문, 감사 기능 및 기타 민감한 작업에 대한 접근을 제한합니다.

> \[!TIP]
> 더 자세한 정보는 [Yearning 가이드](https://next.yearning.io)를 참고하세요.

## ⚙️ 설치

[최신 릴리스](https://github.com/cookieY/Yearning/releases/latest)를 다운로드하여 압축을 해제하세요. 진행 전에 `./config.toml` 파일을 설정했는지 확인하세요.

### 수동 설치

```bash
## 데이터베이스 초기화
./Yearning install

## Yearning 시작
./Yearning run

## 도움말
./Yearning --help
```

### 🚀 Docker로 배포하기
[![][docker-release-shield]][docker-release-link]
[![][docker-size-shield]][docker-size-link]
[![][docker-pulls-shield]][docker-pulls-link]
```bash
## 데이터베이스 초기화
docker run --rm -it -p8000:8000 -e SECRET_KEY=$SECRET_KEY -e MYSQL_USER=$MYSQL_USER -e MYSQL_ADDR=$MYSQL_ADDR -e MYSQL_PASSWORD=$MYSQL_PASSWORD -e MYSQL_DB=$Yearning_DB -e Y_LANG=zh_CN yeelabs/yearning "/opt/Yearning install"

## Yearning 시작
docker run -d -it -p8000:8000 -e SECRET_KEY=$SECRET_KEY -e MYSQL_USER=$MYSQL_USER -e MYSQL_ADDR=$MYSQL_ADDR -e MYSQL_PASSWORD=$MYSQL_PASSWORD -e MYSQL_DB=$Yearning_DB -e Y_LANG=zh_CN yeelabs/yearning
```
## 🤖 AI 어시스턴스

AI 어시스턴트는 대형 언어 모델을 활용하여 SQL 최적화 제안과 텍스트-투-SQL 변환을 제공합니다. 기본 또는 맞춤 프롬프트를 사용하든, AI 어시스턴트는 SQL 문을 최적화하고 자연어 입력을 SQL 쿼리로 변환하여 SQL 성능을 향상시킵니다.

![Text to SQL](https://raw.githubusercontent.com/cookieY/Yearning/next/img/text2sql.jpg)

## 🔖 자동 SQL 검사기

자동 SQL 검사기는 미리 정의된 규칙과 구문을 기반으로 SQL 문을 평가합니다. 구체적인 코딩 표준, 모범 사례, 보안 요구 사항을 준수하는지 확인하여, 견고한 검증 계층을 제공합니다.

![SQL Audit](https://raw.githubusercontent.com/cookieY/Yearning/next/img/audit.png)

## 💡 SQL 구문 하이라이트 및 자동 완성

SQL 구문 하이라이트 및 자동 완성 기능으로 쿼리 작성 효율을 높일 수 있습니다. 이 기능은 SQL 쿼리의 키워드, 테이블명, 컬럼명, 연산자 등 다양한 구성 요소를 시각적으로 구분하여, 쿼리 구조를 쉽게 읽고 이해할 수 있도록 도와줍니다.

![SQL Query](https://raw.githubusercontent.com/cookieY/Yearning/next/img/query.png)

## ⏺️ 주문/쿼리 기록

플랫폼은 사용자 주문 및 쿼리 문의에 대한 감사를 지원합니다. 이 기능을 통해 데이터 소스, 데이터베이스, 민감 필드 처리 등 모든 쿼리 작업을 추적 및 기록할 수 있어, 규정 준수와 쿼리 이력에 대한 추적성을 보장합니다.

![Order/Query Record](https://raw.githubusercontent.com/cookieY/Yearning/next/img/record.png)

이러한 주요 기능에 중점을 두어, Yearning은 사용자 경험을 향상시키고 SQL 성능을 최적화하며, 데이터베이스 운영에서 강력한 준수와 추적 가능성을 보장합니다.

## 🛠️ 추천 도구

- [Spug - 오픈소스 경량화 자동화 운영 플랫폼](https://github.com/openspug/spug)

## ☎️ 문의

문의 사항이 있으시면 다음 메일로 연락 주세요: henry@yearning.io
## 📋 라이선스

Yearning은 AGPL 라이선스를 따릅니다. 자세한 내용은 [LICENSE](LICENSE)를 참고하세요.

2024 © Henry Yee

---

Yearning과 함께 SQL 감사 및 최적화에 대한 간소화되고, 안전하며, 효율적인 접근 방식을 경험해보세요.


[docker-pulls-link]: https://hub.docker.com/r/yeelabs/yearning
[docker-pulls-shield]: https://img.shields.io/docker/pulls/yeelabs/yearning?color=45cc11&labelColor=black&style=flat-square
[docker-release-link]: https://hub.docker.com/r/yeelabs/yearning
[docker-release-shield]: https://img.shields.io/docker/v/yeelabs/yearning?color=369eff&label=docker&labelColor=black&logo=docker&logoColor=white&style=flat-square
[docker-size-link]: https://hub.docker.com/r/yeelabs/yearning
[docker-size-shield]: https://img.shields.io/docker/image-size/yeelabs/yearning?color=369eff&labelColor=black&style=flat-square
[github-forks-shield]: https://img.shields.io/github/forks/cookieY/Yearning?color=8ae8ff&labelColor=black&style=flat-square
[github-forks-link]: https://github.com/cookieY/Yearning/network/members
[github-stars-link]: https://github.com/cookieY/Yearning/network/stargazers
[github-stars-shield]: https://img.shields.io/github/stars/cookieY/Yearning?color=ffcb47&labelColor=black&style=flat-square
[github-license-link]: https://github.com/cookieY/Yearning/blob/main/LICENSE
[github-license-shield]: https://img.shields.io/badge/AGPL%203.0-white?labelColor=black&style=flat-square


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-29

---