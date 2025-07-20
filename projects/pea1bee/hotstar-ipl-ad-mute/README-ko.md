![HOTSTAR IPL 광고 음소거기](https://raw.githubusercontent.com/pea1bee/hotstar-ipl-ad-mute/main/chrome/128.png?raw=true) 
# Hotstar 광고 음소거기

이 작은 브라우저 확장 프로그램은 Hotstar의 광고 추적 픽셀을 가로채 IPL 같은 Hotstar 라이브 스포츠 스트림의 특정 광고를 자동으로 음소거합니다. 또한 광고 식별자로부터 광고 지속 시간을 추정해 동적으로 음소거 시간을 결정합니다.

다음 광고를 기본적으로 음소거하여 귀를 편안하게 해줍니다: **Parle Marie, Vimal Elaichi, Kamla Pasand, My11 Circle, Poker Baazi, Policy Bazaar**.

참고: 이 브라우저 애드온은 개인 용도로 제작되었으며, 현재 광고 음소거 목록에서 음소거할 광고를 추가하거나 제거할 수 있습니다. 자유롭게 저장소를 포크하여 자신만의 맞춤 설정을 추가하거나, 사용자 정의 섹션을 읽어 자신만의 맞춤 광고 음소거 목록을 추가해 보세요.

---

## 설치 방법

 **이 저장소를 컴퓨터에 클론하세요** 

   ```bash
   git clone https://github.com/pea1bee/hotstar-ipl-ad-mute
   ```
   (또는 여기에서 zip 파일을 다운로드할 수 있습니다: https://github.com/pea1bee/hotstar-ipl-ad-mute/archive/refs/heads/main.zip)

## 구글 크롬 설치

1. **크롬을 열고**, `chrome://extensions/`로 이동합니다.
2. 오른쪽 상단에서 **개발자 모드 활성화** (이미 활성화되어 있지 않은 경우)
3. **"압축 해제된 확장 프로그램 로드"** 클릭
4. `hotstar-ipl-ad-mute` 폴더 내 `chrome` 폴더 선택
5. 라이브 스포츠 스트림 중 광고 음소거를 즐기세요!

참고: **Microsoft Edge** 또는 **Brave** 같은 다른 Chromium 기반 브라우저도 동일한 절차를 따릅니다. URL만 `edge://extensions/` 또는 `brave://extensions/`로 변경하세요.

## 모질라 파이어폭스 설치
1. **파이어폭스를 열고**, `about:debugging`으로 이동합니다.
2. **This Firefox** 클릭
3. **임시 애드온 로드** 클릭
4. `hotstar-ipl-ad-mute/firefox` 폴더 내 `manifest.json` 파일 선택
5. 라이브 스포츠 스트림 중 광고 음소거를 즐기세요!

참고: 확장 기능은 설치 후 제거하거나 파이어폭스를 재시작할 때까지 유지됩니다.

---

## 사용자 설정


### 모든 광고 음소거
`background.js` 파일 내 `MUTE_ALL_ADS` 변수를 `true`로 설정하면 모든 광고를 음소거할 수 있습니다.

### 광고 ID별 음소거
`background.js` 파일 내 `targetAdIds` 배열을 수정하여 음소거할 광고를 맞춤 설정할 수 있습니다.  
새 광고 키워드를 추가하려면:


```js
const targetAdIds = [
  "PARLE_MARIE",
  "KAMLA_PASAND",
  "DREAM11",
  // Add your own here
];
```
### 광고 식별자 찾는 방법 (Google Chrome):
1. **Chrome을 열고**, 확장 프로그램 페이지 `chrome://extensions/`로 이동합니다.
2. `Hotstar IPL Ad Muter` 확장 프로그램을 찾아 선택합니다. "세부정보"를 클릭하세요.
3. "Inspect views" 라벨이 붙은 섹션을 클릭합니다.
4. **IPL 라이브 스트림 중에**, `Ad detected:` 콘솔 로그와 이어지는 `adName`을 찾으세요.
5. 음소거할 광고 식별자의 전체 또는 고유 부분을 `background.js`의 `targetAdIds` 배열에 추가합니다.

또는 브라우저 개발자 도구를 열고, 라이브 스포츠 스트림 중 **네트워크 탭**에서 `https://bifrost-api.hotstar.com/v1/events/track/ct_impression`로 시작하는 URL을 찾아 `adName` 쿼리 매개변수에서 광고 식별자를 확인할 수도 있습니다.

---


## 주의사항
- 방송사가 다음 광고가 시작되기 전에 한 개의 광고를 더 넣으려 할 때가 있습니다. 광고가 갑자기 중단되면, 확장 프로그램이 탭 음소거를 해제하기 전에 몇 초간 라이브 영상이 계속 음소거 상태로 남을 수 있습니다.
- Hotstar가 현재 추적 픽셀 URL을 변경하거나 광고 식별자에 사용되는 형식이나 키워드를 변경하면 이 확장 프로그램이 작동하지 않을 수 있습니다.

## 라이선스

MIT © 2025



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---