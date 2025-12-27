![preview](https://github.com/user-attachments/assets/e6762b5a-479a-4261-8e5c-e6b5d04344c5)
# 팬트리
[![build](https://github.com/imRohan/Pantry/actions/workflows/continuous_integration.yml/badge.svg)](https://github.com/imRohan/Pantry/actions/workflows/continuous_integration.yml)
![Maintainability](https://api.codeclimate.com/v1/badges/8f1460270ced1f60744c/maintainability)
![Issues Open](https://img.shields.io/github/issues/imrohan/Pantry?&logo=github)
![Issues Closed](https://img.shields.io/github/issues-closed-raw/imrohan/pantry?color=green&logo=github)
[![Coverage Status](https://coveralls.io/repos/github/imRohan/Pantry/badge.svg?branch=master)](https://coveralls.io/github/imRohan/Pantry?branch=master)

[Pantry](https://getpantry.cloud/)는 소규모 프로젝트를 위한 부패성 데이터 저장소를 제공하는 무료 서비스입니다. 데이터는 여러분과 사용자가 필요로 하는 동안 안전하게 저장되며, 비활성 기간이 지나면 삭제됩니다. 단순히 RESTful API를 사용하여 JSON 객체를 전송하면 나머지는 우리가 처리합니다.

작고 재사용 가능한 저장 솔루션을 제공하기 위해 만들어졌습니다. 개발자를 위해 개발자가 만들었으며, 필요할 때 언제든지 사용할 수 있고 다음 프로젝트를 빠르게 프로토타입할 수 있도록 도와줍니다.

## 개발

#### 레포 복제
`git clone https://github.com/imRohan/Pantry.git && cd Pantry`

#### 의존성 설치
`yarn`

#### Redis 설치
머신에 Redis (v^6.2.0)를 설치하고 기본 설정으로 서버를 실행해야 합니다.

#### `.env` 및 `config.ts` 생성 및 편집
`cp env.sample .env`
`cp src/app/config.dev.ts src/app/config.ts`

#### 프론트엔드 자산 빌드 및 서버 실행 (기본 포트 3000)

`yarn run dev`

#### 예제 HTML 페이지 열기

사용하는 브라우저에서 `http://localhost:3000/` 열기



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-27

---