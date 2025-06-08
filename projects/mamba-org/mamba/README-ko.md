# Mamba: 빠른 크로스 플랫폼 패키지 관리자

![mamba header image](https://raw.githubusercontent.com/mamba-org/mamba/main/docs/assets/mamba_header.png)

<!-- markdownlint-disable-file MD033 -->

<table>
<thead align="center" cellspacing="10">
  <tr>
    <th colspan="3" align="center" border="">mamba-org의 일부</th>
  </tr>
</thead>
<tbody>
  <tr background="#FFF">
    <td align="center">패키지 관리자 <a href="https://github.com/mamba-org/mamba">mamba</a></td>
    <td align="center">패키지 서버 <a href="https://github.com/mamba-org/quetz">quetz</a></td>
  </tr>
</tbody>
</table>

## mamba

[![Build Status](https://github.com/mamba-org/mamba/actions/workflows/tests.yml/badge.svg)](https://github.com/mamba-org/mamba/actions/workflows/tests.yml?query=branch%3Amain)
[![Join the Gitter Chat](https://badges.gitter.im/Join%20Chat.svg)](https://gitter.im/mamba-org/Lobby?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)
[![docs](https://readthedocs.org/projects/mamba/badge/?version=latest&style=flat)](https://mamba.readthedocs.io/en/latest)
[![Gurubase](https://img.shields.io/badge/Gurubase-Ask%20mamba%20Guru-006BFF)](https://gurubase.io/g/mamba)

`mamba`는 conda 패키지 관리자를 C++로 다시 구현한 것입니다.

- 멀티스레딩을 사용한 저장소 데이터 및 패키지 파일의 병렬 다운로드
- Red Hat, Fedora, OpenSUSE의 RPM 패키지 관리자에서 사용되는 최신 라이브러리인 libsolv를 통한 훨씬 빠른 의존성 해결
- `mamba`의 핵심 부품은 최대 효율성을 위해 C++로 구현됨

동시에, `mamba`는 가능한 한 호환성을 유지하기 위해 conda와 동일한 명령줄 파서, 패키지 설치 및 제거 코드, 트랜잭션 검증 루틴을 사용합니다.

`mamba`는 오픈 소스 `conda` 패키지 서버인 `quetz`와 함께 [conda-forge](https://conda-forge.org/) 생태계의 일부입니다.

[공지 블로그 포스트](https://medium.com/@QuantStack/open-software-packaging-for-science-61cecee7fc23)를 읽어보세요.

## micromamba

`micromamba`는 정적으로 링크된 버전의 `mamba`입니다.

별도의 의존성 없이 독립 실행 파일로 설치할 수 있어 CI/CD 파이프라인 및 컨테이너 환경에 적합합니다.

자세한 내용은 [micromamba 문서](https://mamba.readthedocs.io/en/latest/user_guide/micromamba.html)를 참고하세요.

## `mamba` vs. `micromamba`

다음과 같은 경우에는 `mamba`를 사용하는 것이 좋습니다:

- 동일 환경에서 다른 소프트웨어가 `libmambapy` 또는 `libmamba`를 사용하는 경우
- 라이브러리의 정기적인 업데이트(특히 보안 패치)가 필요한 경우
- 종속성의 디스크 공간 사용을 줄이는 데 중점을 둔 환경

다음과 같은 경우에는 `micromamba`를 사용하는 것이 좋습니다:

- 하나의 독립 실행 파일에만 의존해야 하는 경우
- miniforge 배포판이 없는 경우
- 최소한의 런타임이 필요한 경우

## 설치

[mamba](https://mamba.readthedocs.io/en/latest/installation/mamba-installation.html) 및 [micromamba](https://mamba.readthedocs.io/en/latest/installation/micromamba-installation.html) 설치 가이드를 문서에서 참고하세요.

## Mamba 및 Micromamba의 추가 기능

`mamba`와 `micromamba`는 기본 `conda`에 비해 다양한 추가 기능을 제공합니다.

### `repoquery`

저장소 및 패키지 의존성 정보를 효율적으로 조회하려면 `mamba repoquery` 또는 `micromamba repoquery`를 사용할 수 있습니다.

자세한 내용은 [repoquery 문서](https://mamba.readthedocs.io/en/latest/user_guide/mamba.html#repoquery)를 참고하세요.

### Lock 파일 설치

`micromamba`는 [conda-lock](https://conda.github.io/conda-lock/)에서 생성된 lock 파일을 별도의 `conda-lock` 설치 없이 설치할 수 있습니다.

`-lock.yml` 또는 `-lock.yaml`로 끝나는 환경 lock 파일 이름을 `-f` 옵션과 함께 `micromamba create`에 전달하면 됩니다. 예:

```bash
micromamba create -n my-env -f conda-lock.yml
```

### setup-micromamba (setup-miniconda 대체)

[setup-micromamba](https://github.com/marketplace/actions/setup-micromamba)는 `micromamba`를 사용하는 [setup-miniconda](https://github.com/marketplace/actions/setup-miniconda) 대체 도구입니다.

이 도구는 다음과 같이 CI 설정 시간을 대폭 줄일 수 있습니다:

- 설치에 약 1초가 걸리는 `micromamba` 사용
- 패키지 다운로드 캐싱
- 전체 `conda` 환경 캐싱

## `conda`와의 차이점

`mamba`와 `micromamba`는 일반적으로 `conda`의 대체로 사용할 수 있지만 몇 가지 차이점이 있습니다:

- `mamba`와 `micromamba`는 revision을 지원하지 않습니다(관련 논의는 <https://github.com/mamba-org/mamba/issues/803> 참조)
- `mamba`와 `micromamba`는 `MatchSpec` 문자열을 가장 단순한 형태로 정규화하지만, `conda`는 더 자세한 형태를 사용합니다.
  이로 인해 `conda env export`와 `mamba env export`의 출력에 약간의 차이가 있을 수 있습니다.

## 개발용 설치

[공식 문서](https://mamba.readthedocs.io/en/latest/developer_zone/dev_environment.html)의 지침을 참고하세요.

## API 및 ABI 안정성

Mamba 프로젝트는 `MAJOR.MINOR.PATCH` 형태의 [시맨틱 버전](https://semver.org/)을 사용합니다.
사용자에게 안정성을 제공하기 위해 노력하지만, 기술적 부채를 줄이고 Mamba를 개선하기 위해 호환성 깨지는 변경이 필요할 수 있습니다.
향후 Mamba 버전에서는 더 강력한 보장을 제공할 수 있습니다.

### `libmamba` (C++)

C++ API의 사용자를 인지하지 못했으므로, 개선을 위한 여지를 남겨두고 있습니다.
`libmamba`에서 _하위 호환성(Backward compatible)_ 이란 다음을 의미합니다:

- _ABI 하위 호환성_은 라이브러리 바이너리 파일만 교체해도 코드의 재컴파일 없이 동작이 동일함을 의미합니다(버그 및 성능 차이 제외).
- _API 하위 호환성_은 새 라이브러리 버전의 헤더로 코드만 다시 빌드하면 코드 변경 없이 동작이 동일함을 의미합니다(버그 및 성능 차이 제외). 단, `detail` 서브 네임스페이스 등 비공개 선언을 사용하지 않은 경우에 한합니다.
  선언이 deprecated 되었으나 제거되지 않고 여전히 동작하는 경우도 하위 호환으로 간주합니다(컴파일 시 경고만 발생).

이를 바탕으로, `libmamba`는 다음과 같은 보장을 제공합니다:

- `PATCH` 릴리스는 API 및 ABI 하위 호환성을 가짐
- `MINOR` 릴리스는 `mamba/api` 내 선언에 대해 API 호환성을 가짐, 이외는 API/ABI 깨질 수 있음
- `MAJOR` 릴리스는 보장 없음

### `libmambapy` (Python)

`libmambapy`에서 _API 하위 호환성_은 파이썬 코드가 비공개(예: `_`로 시작하는 이름)에 접근하지 않는 한, 새 버전에서도 동일하게 동작함을 의미합니다(버그 및 성능 차이 제외).
선언이 deprecated 되었으나 제거되지 않고 여전히 동작하는 경우도 하위 호환으로 간주합니다(파이썬의 `DeprecationWarning`이 활성화된 경우에만 관찰 가능, 일반적으로 개발 시에만 활성화됨).

이를 바탕으로, `libmambapy`는 다음과 같은 보장을 제공합니다:

- `PATCH` 릴리스는 API 하위 호환성을 가짐
- `MINOR` 릴리스는 API 하위 호환성을 가짐
- `MAJOR` 릴리스는 보장 없음

### `mamba` 및 `micromamba` (실행 파일)

실행 파일의 경우, _하위 호환성_은 프로그래밍 가능한 입력/출력(프로그램 이름, 명령줄 인자, 설정 파일, 환경 변수, JSON 명령줄 출력, 생성 파일)에 대해 적용되어, 스크립트 등이 새 버전에서도 수정 없이 동작함을 의미합니다.
단, 사람 읽기용 출력 및 에러 메시지(예: Deprecation Warning 등)는 보장 대상이 아닙니다.

이를 바탕으로, `mamba` 및 `micromamba`는 다음과 같은 보장을 제공합니다:

- `PATCH` 릴리스는 하위 호환성을 가짐
- `MINOR` 릴리스는 하위 호환성을 가짐
- `MAJOR` 릴리스는 보장 없음

## 지원 안내

`mamba` 및 `micromamba` 2.0 이상 버전만 지원 및 적극적으로 개발되고 있습니다.

`1.x` 브랜치는 보안 이슈(CVE 등)에 한해서만 유지 관리됩니다.

질문이 있다면 [QuantStack 채팅방](https://gitter.im/QuantStack/Lobby) 또는 [Conda 채널](https://gitter.im/conda/conda)에서 문의하실 수 있습니다(이 프로젝트는 공식적으로 `conda` 또는 Anaconda Inc.와 제휴되어 있지 않습니다).

## 라이선스

모든 기여자가 자신의 기여에 대한 저작권을 유지할 수 있도록 공유 저작권 모델을 사용합니다.

이 소프트웨어는 BSD-3-Clause 라이선스로 제공됩니다. 자세한 내용은 [LICENSE](https://raw.githubusercontent.com/mamba-org/mamba/main/LICENSE) 파일을 참조하세요.

---

### 격주 개발자 미팅

격주로 화상회의를 열어 진행 중인 작업을 공유하고 피드백을 주고받습니다.

주제 논의 또는 청취만 원하는 누구나 참석할 수 있습니다.

- 일정: 화요일 [오후 4시 CET (유럽)](https://calendar.google.com/calendar/u/0/embed?src=ab3jrfpede0kq0ubsroe82cd00@group.calendar.google.com&ctz=Europe/Paris)
- 장소: [Mamba jitsi](https://meet.jit.si/mamba-org)
- 내용: [회의록](https://hackmd.io/@guj2k_aBSSyr1YHBG9raWw/HyHt-Ekzj)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---