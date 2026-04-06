# Spicetify DJ 정보

Spicetify DJ 정보 확장 프로그램에 오신 것을 환영합니다! 이 확장 프로그램은 각 트랙에 대한 키, BPM, 인기 및 연도와 같은 유용한 노래 분석 데이터를 제공하여 Spicetify 경험을 향상시킵니다. 이 확장 프로그램을 통해 음악 라이브러리에 대한 더 깊은 통찰력을 얻고 DJ 세트 또는 플레이리스트에 완벽하게 맞는 노래를 발견할 수 있습니다.

## ⭐기능

- **키:** 각 노래의 키를 표준 표기법(DbM) 또는 카멜롯 시스템(3B)으로 식별합니다. 카멜롯 시스템은 하모니가 호환되는 그룹으로 키를 분류하여 하모닉 믹싱을 단순화합니다. 이를 통해 DJ 세트 중이나 일관성 있는 플레이리스트를 만들 때 노래 간 전환이 부드러워집니다.
- **BPM ♫ (분당 비트 수):** 각 노래의 템포를 확인할 수 있으며, 이는 음악이 연주되는 속도 또는 페이스를 나타냅니다. BPM은 비슷한 속도의 플레이리스트를 만들거나 특정 활동에 맞는 노래를 선택할 때 유용합니다.
- **인기도 ♥:** 노래의 인기도 평점을 통해 노래가 얼마나 인기 있는지 알 수 있습니다. 이 데이터는 트랙의 전반적인 반응과 인기도를 이해하는 데 도움이 됩니다.
- **연도:** 노래가 발매된 연도를 확인할 수 있습니다. 이 데이터는 특정 기간의 노래로 플레이리스트를 만들 때 유용합니다.

![스크린샷](https://raw.githubusercontent.com/L3-N0X/spicetify-dj-info/main/img/playlist.png)
![스크린샷](https://raw.githubusercontent.com/L3-N0X/spicetify-dj-info/main/img/now-playing.png)

## 💻 설치

`dist/djinfo.mjs` 파일을 [Spicetify](https://github.com/spicetify/spicetify-cli) 확장 프로그램 디렉터리에 복사하세요:

| **플랫폼**   | **경로**                                                                             |
| ------------ | ------------------------------------------------------------------------------------ |
| **리눅스**   | `~/.config/spicetify/Extensions` 또는 `$XDG_CONFIG_HOME/.config/spicetify/Extensions/` |
| **MacOS**    | `~/.config/spicetify/Extensions` 또는 `$SPICETIFY_CONFIG/Extensions`                   |
| **윈도우**   | `%appdata%/spicetify/Extensions/`                                                    |

확장 프로그램 파일을 올바른 폴더에 넣은 후, 다음 명령어를 실행하여 확장 프로그램을 설치하세요:

```bash
spicetify config extensions djinfo.mjs
spicetify apply
```
또는 `config-xpui.ini` 파일을 수동으로 편집할 수 있습니다. 확장자 키에 원하는 확장자 파일명을 | 문자로 구분하여 추가하세요.  
예:


```ini
[AdditionalOptions]
...
extensions = autoSkipExplicit.js|shuffle+.js|trashbin.js|djinfo.mjs
```

그런 다음 실행:

```bash
spicetify apply
```

**별점 평가에 문제가 발생할 수 있습니다!**

## ❌ 제거

확장 기능을 제거하려면 다음 명령어를 실행하세요(끝에 -가 있는 것에 주의):

```bash
spicetify config extensions djinfo.mjs-
spicetify apply
```

`config-xpui.ini` 파일을 수동으로 편집할 수도 있습니다. 확장자의 파일 이름을 완전히 제거하기만 하면 됩니다.
예:

```ini
[AdditionalOptions]
...
extensions = autoSkipExplicit.js|shuffle+.js|trashbin.js
```

그런 다음 실행하십시오:

```bash
spicetify apply
```
## ⚙️ 설정

확장 프로그램에서 DJ 정보를 표시하거나 숨길 수 있는 옵션이 있습니다. 기본적으로 각 곡과 현재 재생 중인 곡 옆에 Key, BPM, 인기, 연도 등의 DJ 정보가 표시됩니다. 하지만 더 깔끔한 인터페이스를 원한다면 이 정보를 개별적으로 쉽게 숨길 수 있습니다.

DJ 정보 표시를 전환하려면 다음 단계를 따르세요:

1. 스포티파이 열기
2. 인터페이스 오른쪽 상단에 있는 메뉴 아이콘(프로필 사진)을 찾아 클릭
3. 메뉴에서 'DJ 정보' 옵션 찾기
4. 하위 메뉴에서 표시하거나 숨기고 싶은 항목의 토글 스위치를 클릭
5. 변경 사항 적용 버튼을 눌러 설정을 반영

## 📜 변경 로그

### V 2.4.0

- 다른 API로 업데이트됨
- 스타일 개선
- 새로운 오디오 기능을 위한 옵션 추가

### V 2.3.3

- 로그 스팸 수정

### V 2.3.2

- 새로운 믹스 UI에 맞춰 레이아웃 수정

### V 2.3.1

- API 문제로 인한 확장 프로그램 오류 수정
- 새 API에서 제공되지 않는 Danceability와 Energy 제거
- DJ 정보를 위한 새로운 UI 추가 및 기존 UI 개선, 풍부한 UI 비활성화 시 기존 버전 사용 가능
- 캐싱 문제 수정 및 LocalStorage 대신 IndexedDB 사용하는 새 시스템으로 이전
- 새로운 카멜롯 키 색상은 CSS 변수 덮어쓰기로 사용자 정의 가능

### V 2.2.1

- 추천 기능에서 드디어 정상 작동

- 캐시가 크게 개선되었습니다  
- 데이터가 배치로 가져와져서, 속도 제한 때문에 누락되는 데이터가 수정되었습니다  
- 새로운 플레이리스트 UI와 다시 작동합니다  
- 로딩 성능이 향상되었습니다  
- 오류 로깅이 개선되었습니다  
- #16, #23, #24, #25 버그 수정  

### V 2.1.1  

- 추천 곡 섹션의 스타일이 수정되었습니다  

### V 2.1.0  

- 추천 곡 섹션에서 DJ 정보를 볼 수 있는 옵션이 추가되었습니다  
- 디스코그래피 섹션에서 DJ 정보가 표시되지 않는 버그가 수정되었습니다 ([#2](https://github.com/L3-N0X/spicetify-dj-info/issues/2))  
- 큐에서 발생하던 버그가 수정되었습니다 ([#9](https://github.com/L3-N0X/spicetify-dj-info/issues/9))  

### V 2.0.0  

- 로딩 시간을 단축하고 API 호출을 줄이기 위해 데이터를 로컬에 저장하는 성능이 개선되었습니다  
- 설정 메뉴가 재작업되어 DJ 정보의 표시를 훨씬 쉽게 토글할 수 있게 되었습니다  

### V 1.1.0  

- 표준 표기법에서 연도, 인기, 댄서빌리티, 키를 토글하는 옵션이 추가되었습니다  
- 버그 수정  

## 🌐 크레딧 & 감사  

내부 API가 중단된 후 확장 기능을 수정하고 전체 API를 내부 protobuf 기반 API로 마이그레이션하며 더 나은 파일 구조와 번들링을 추가해 주신 [obafgkmdh](https://github.com/obafgkmdh)와 [FixeQD](https://github.com/FixeQD)에게 큰 감사를 드립니다!  

또한 플레이리스트에서 DJ 정보를 더 잘 정렬하는 아이디어를 제공해 주신 [Golevka2001](https://github.com/Golevka2001)께도 감사드립니다!  

플레이리스트와 현재 재생 위젯에 무언가를 표시하는 주요 코드를 제공해 주신 [duffey](https://github.com/Tetrax-10)에게도 큰 감사를 드립니다!  

또한 표준 표기법과 카멜롯 시스템을 모두 표시하는 코드와 현재 재생 화면 왼쪽에 표시하는 옵션을 기여해 주신 [je09](https://github.com/je09)에게도 감사드립니다!  

## 💬 피드백 및 기여  

이 확장 기능에서 문제가 발생하거나 개선 제안이 있으시면 [GitHub 저장소](https://github.com/L3-N0X/spicetify-dj-info)에 이슈를 열어 주세요. 기여도 환영합니다! 저장소를 포크하고 변경 사항을 만든 후 개선 사항과 함께 풀 리퀘스트를 제출해 주세요.

## ⚖️ 라이선스

이 프로젝트는 [MIT 라이선스](https://raw.githubusercontent.com/L3-N0X/spicetify-dj-info/main/LICENSE.md)에 따라 라이선스가 부여되었습니다. 이 라이선스 조건에 따라 코드를 자유롭게 사용, 수정 및 배포할 수 있습니다.

---

Spicetify DJ Info 확장으로 향상된 음악 분석 경험을 즐기세요! 이 확장이 유용하다면 GitHub에서 ⭐️를 눌러주세요. DJ Info를 사용해 주셔서 감사합니다!


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-06

---