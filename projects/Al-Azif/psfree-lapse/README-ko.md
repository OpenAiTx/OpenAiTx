# PSFree 버전 1.5.1

PSFree는 PS4 콘솔을 위한 익스플로잇 모음입니다. 이 저장소의 주요 초점은 PS4이지만, 가능한 한 PS5로도 이식할 수 있도록 노력하고 있습니다.

## 기능

- **자동 감지:** 콘솔 종류와 펌웨어 버전을 자동으로 감지합니다 (`src/config.mjs`를 통해).
- **WebKit 익스플로잇 (PSFree):** 콘솔의 웹 브라우저를 통한 진입점.
- **커널 익스플로잇 (Lapse):** 권한을 커널 레벨로 상승시킵니다.
- **페이로드 로더:** 커널 익스플로잇 성공 후 9020 포트에서 페이로드를 대기합니다.

## 취약점 범위

|               | PSFree    | Lapse      |
| :------------ | :-------- | :--------- |
| PlayStation 4 | 6.00-9.60 | 1.01-12.02 |
| PlayStation 5 | 1.00-5.50 | 1.00-10.01 |

## 이 저장소에서 지원하는 버전

이 표는 _현재 버전_의 저장소에서 작동 및 테스트된 익스플로잇 체인을 제공하는 펌웨어 버전을 나타냅니다.

|               | PSFree    | Lapse     |
| :------------ | :-------- | :-------- |
| PlayStation 4 | 7.00-9.60 | 7.00-9.60 |
| PlayStation 5 | N/A       | N/A       |

_참고: "취약점 범위" 표에 나열된 다른 펌웨어에 대한 지원은 현재 작업 중이거나, 이 저장소의 이전 버전에서 지원되었을 수 있습니다. 과거 지원 내역은 [`CHANGELOG.md`](https://raw.githubusercontent.com/Al-Azif/psfree-lapse/main/CHANGELOG.md) 파일을 확인해 주세요._

## TODO 목록

- [ ] 일부 게임에서 발생하는 블랙스크린/저장 문제
- [ ] `lapse.mjs`: JIT 권한을 위한 비트만 설정
- [ ] `view.mjs`: PS4로 가정하고 있음, PS5도 지원 필요
- [ ] PS5 지원 추가

## 저작권 및 저자

AGPL-3.0-or-later (자세한 내용은 [LICENSE](https://raw.githubusercontent.com/Al-Azif/psfree-lapse/main/LICENSE) 참조). 이 저장소는 `anonymous` 그룹에 속합니다. 익명 기여자는 "anonymous"로 표기합니다.

## 크레딧

- PS4 펌웨어 커널 덤프를 제공한 anonymous
- **추가** 기여자는 해당 파일을 참고하세요. 별도의 명시가 없는 한, 이곳의 모든 것은 저희에게도 공로가 있습니다.

## 후원

(모네로/XMR): **86Fk3X9AE94EGKidzRbvyiVgGNYD3qZnuKNq1ZbsomFWXHYm6TtAgz9GNGitPWadkS3Wr9uXoT29U1SfdMtJ7QNKQpW1CVS**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---