# Ventoy CPIO

[Ventoy](https://github.com/ventoy/Ventoy)을 위한 대체 램디스크입니다.

문서는 [여기](https://github.com/fnr1r/ventoy-meta/tree/main/docs)
릴리스는 [여기](https://github.com/fnr1r/ventoy-cpio/releases)에서 확인할 수 있습니다.

참고: 이것은 Ventoy에 합리적(-ish) 빌드 시스템을 추가하려는 시도의
작은 부분일 뿐입니다. 내 Ventoy 관련 모든 프로젝트의 인덱스는
[여기](https://github.com/fnr1r/ventoy-meta)에서 찾을 수 있습니다.

## 목표

Ventoy용 대체 램디스크 만들기

- [?] 합리적(-er) 빌드 시스템과 함께
- [x] 부팅 가능한 것
- [ ] 기능적으로 동일한 것  
  (즉, 상위 버전과 동일한 작업 가능)
- [x] 더 작은 것

### 비목표

- ❌ 공식 것과 바이너리 동일 램디스크
  - 주어진 지침으로 동일한 바이너리를 컴파일하는 것은 거의
  불가능하며 궁극적으로 무의미함
  - 하지만 이 프로젝트로 빌드된 램디스크는 재현 가능해야 함

### 향후 변경 가능성

- 바이너리 접미사 제거 (짜증나고 일관성 없음)  
  (상위 버전 변경 불필요)
- 램디스크를 x86 32비트와 64비트로 분리  
  (grub 변경 필요)
- 램디스크 내 셸 스크립트 정리  
  (상위 버전 변경 불필요)

## 진행 상황

부팅은 되나 일부 기능은 작동하지 않을 수 있음.

### ventoy.cpio

100%, 단순히 여러 파일을 xz 압축한 것임.

크기 비율:

- du - 1 (64 / 64)
- ls -l - 1 (62976 / 62976)

### ventoy_ARCH.cpio

약 75%

모든 도구가 여기 있음(대부분), 어쨌든 컴파일되어 있음. 이제 남은 것은
최적화뿐.

크기 비율 (x86):

- du - 0.8540245566166439 (2504 / 2932)
- ls -l - 0.8624375107740045 (2561536 / 2970112)

크기 비율 (arm64):

- du - 0.8159806295399516 (1348 / 1652)
- ls -l - 0.8159490600363857 (1377792 / 1688576)

크기 비율 (mips64):

- du - 0.9816849816849817 (1072 / 1092)
- ls -l - 0.981642955484167 (1095168 / 1115648)

### vtloopex.cpio

TODO: 추가 예정

## 사용법

### 빌드하기

```sh
docker compose build
```

```sh
docker compose up
```
힌트:

컨테이너를 다시 빌드할 때마다 아카이브를 다시 다운로드하고 싶지 않다면,
`docker/base/{dietlibc,musl,toolchains}`로 이동하여 설정 스크립트를 확인하고
수동으로 `wget`을 사용해 파일을 다운로드하세요.

컨테이너에 들어가려면 다음 명령어를 실행할 수도 있습니다:


```sh
docker run -it --rm \
  -v ".:/build" \
  ventoy-cpio-builder:latest \
  bash
```
### 설치

`ventoy*.cpio` 파일을 확보한 후:

1. Ventoy USB의 두 번째 파티션을 마운트합니다.
1. !!! 원본 `ventoy*.cpio` 파일을 반드시 백업하세요 !!!
1. 사용해보고 싶은 cpio 파일을 복사합니다. (힌트: 어떤 파일인지 모르면,
  아마도 `ventoy_x86.cpio`일 것입니다)

## 미니 할 일

- 호환성을 위해 오래된 버전의 Linux 헤더로 빌드하기

## 참고 사항

- [GCC 용어로](https://gcc.gnu.org/onlinedocs/gccint/Configure-Terms.html):
  - 빌드는 x86_64 *nix로 가정합니다
  - 호스트(ventoy 설치 도구용)는 x86_64로 가정합니다
  - 타깃은 x86_64, i386, aarch64 및 mips64el입니다



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-30

---