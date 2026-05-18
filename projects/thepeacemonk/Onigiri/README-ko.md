<div align="center">
  <img width="360" height="112" alt="onigiri" src="https://github.com/user-attachments/assets/eaebfec6-f6df-45b4-a3be-22e2ae97c1e8" />
  <br>
  <br>
  <h3>오니기리 (베타)</h3>
</div>

<div align="center">
  <img width="400" height="22" alt="Onigiri divider" src="https://github.com/user-attachments/assets/77958660-41fd-4a43-85df-6c17cda02958" />
</div>

오니기리는 표준 Anki 인터페이스를 현대적이고 고도로 맞춤화된 개인화 대시보드로 대체하는 **실험적 애드온**으로, Anki의 외관을 완전히 변화시켜 매일 카드를 공부하도록 동기를 부여하는 방법입니다.

오니기리(お握り)는 오무스비(おむすび) 또는 주먹밥(🍙)이라고도 불리며, 에너지를 제공하는 데 필수적인 탄수화물이 풍부한 전통적인 일본 요리입니다. 이것이 오니기리의 의도로, 아름다운 새로운 Anki(暗記) 레이아웃과 함께 카드를 공부할 적절한 동기를 부여하는 추가 탄수화물을 제공하는 것입니다.

### 📝 철학

- **Anki는 민주적입니다**: Anki는 전 세계 모든 사용자들이 사용하는 도구이며, 모든 사용자는 자신이 원하는 색상과 형태로 자신의 필요에 맞게 조정할 권리가 있습니다. 오니기리는 Anki를 더욱 민주적이고 사용자 친화적인 경험으로 만듭니다.
- **훌륭한 디자인은 동기를 부여할 수 있습니다**: 동기는 학생들이 더 자주 앱을 방문하고 공부하도록 유도하는 생산성과 동기를 높일 수 있습니다. 연구에 따르면 잘 구조화되고 사용자 친화적인 디자인이 실제로 [동기를 키울 수 있음](https://www.mdpi.com/2414-4088/2/1/6)이 입증되었습니다.
- **차분한 기본값, 강력한 옵션**: 기본 경험은 단순하게 유지됩니다. 고급 제어는 발견 가능하며 압도적이지 않아 사용자가 자신의 속도에 맞게 복잡성에 적응할 수 있습니다.
- **유연성을 가진 일관성**: 사용자는 핵심 Anki 패러다임—카드, 복습, 간격—을 깨뜨리지 않고 모양과 느낌을 변경할 수 있어 근육 기억이 계속 작동합니다.
&nbsp;

### 🧐 왜 오니기리인가?

"이미 Anki가 잘 작동하는데 왜 바꿔야 하지?"라고 생각할 수 있습니다.
알고 있습니다, Anki는 잘 작동하지만 오니기리는 사용하기 좋게 느끼도록 돕습니다. 차분한 기본값, 읽기 쉬운 타이포그래피, 부드러운 신호로 인터페이스를 새롭게 하여 오니기리는 마찰을 줄이고 동기를 높여 더 자주, 더 활기차게 카드를 보게 합니다.

###  🚨 자주 발생하는 문제들
오니기리를 사용하는 동안 문제가 발생하면 주저하지 말고 [이슈](https://github.com/thepeacemonk/Onigiri/issues)를 올려주세요. 이 애드온을 가능한 한 원활하게 만들고자 합니다. 다음은 발생할 수 있는 몇 가지 잠재적 버그이며 해결 중입니다:

- 개발 과정에서 이미지 배경을 사용할 때 Reviewer에서 카드 형식 관련 문제가 있었습니다. 이는 애드온과 카드의 CSS 함수 상호작용 때문이며, 문제가 있으면 알려주세요.
- 일부 설정은 Anki를 재시작해야 하므로 "저장"을 눌러도 변화가 없으면 재시작이 필요한 설정일 가능성이 큽니다. 또한, 일부 설정은 새로고침만 필요하니 메인 메뉴에서 "D"를 눌러 새로고침하세요.
- 이 애드온은 Shige의 리더보드(표시되지 않음, Onigiri와 충돌하는 기능 때문)와 The KING of Button Add-ons(버튼의 색상, 배경 또는 정렬이 다르게 보일 수 있음)와 같은 일부 다른 애드온과 호환되지 않습니다.
- .gif 및 .webp 형식의 애니메이션 배경을 다루는 모든 애드온과 마찬가지로 Anki가 높은 CPU 사용률을 보일 수 있으나, 이는 버그가 아닌 Anki의 구조적 문제이며 두 형식이 CPU에서 지속적으로 렌더링되기 때문입니다.
- 다운로드하면 외부 애드온이 보관됨으로 표시됩니다. 설정 -> 메뉴 -> 메인 메뉴에서 "보관된 외부 애드온"을 정리하세요.
- 오니기리가 Gamification 모드 때문에 Anki를 "느리게" 만들 수 있는데, 이는 학습 중 데이터 등록의 증상이며 정상으로 간주됩니다. 향후 업데이트에서 최적화를 진행할 예정입니다.
- 오니기리는 구버전 Anki에서는 작동하지 않으며, 25.07.5 및 25.09 버전만 지원하므로 더 나은 경험을 위해 Anki를 최신 상태로 유지하세요.

### 📜 라이선스
이 프로젝트는 `GNU Affero General Public License v3.0 (AGPL-3.0)` 라이선스 하에 배포됩니다. 요약하자면: 이 코드를 자유롭게 사용, 연구 및 수정할 수 있지만, 이를 서비스로 운영하거나 수정된 버전을 배포하는 경우 동일한 라이선스 하에 소스 코드를 공개해야 합니다.

이 작업을 설계하고 유지하는 데 많은 시간을 투자했습니다. 라이선스와 제 노력을 존중해 주세요:
- 이 프로젝트의 일부를 폐쇄 소스나 상업용 제품에 복사하지 마세요.
- 이를 기반으로 개발한다면 원작자를 명시하고 변경 사항을 공개하세요.
- 이곳에서 가치를 발견했다면 기여하거나 프로젝트를 지원하는 것을 고려해 주세요.

## 공지

[Onigiri Anki](https://www.onigiri-anki.com/)와는 제휴되어 있지 않습니다. 어떠한 보증이나 지지도 표현되지 않았습니다.

Onigiri(이 애드온)는 앱 UI를 맞춤화하는 독립적인 Anki 애드온입니다. 반면, [Onigiri Anki](https://www.onigiri-anki.com/)는 자체 시스템을 갖춘 일본어 학습 덱을 제공합니다. 이들은 별개의 제품이며 어떤 방식으로도 연관되어 있지 않습니다.


### 크레딧 및 감사의 말씀
이 애드온의 설계 및 개발에 참고된 프로젝트와 자료는 다음과 같습니다:

- 색상 팔레트 및 테마: [Catppuccin](https://github.com/catppuccin), [Dracula](https://draculatheme.com/), [Rosé Pine](https://rosepinetheme.com/palette/), [Nord](https://www.nordtheme.com/docs/colors-and-palettes), [Solarized](https://ethanschoonover.com/solarized/), [Antinote themes](https://antinote.io/).
- 시각적 및 주제적 영감: [Mochi Cards](https://mochi.cards/)
- Shige의 애드온 선례: [Enhance main window](https://ankiweb.net/shared/info/911023479), [Rearrange home addons](https://ankiweb.net/shared/info/1797615099), [Anki Re-design](https://ankiweb.net/shared/info/1959668791) (모두 Shige 제작)
- 기능 및 UI 지침: [Review Heatmap](https://ankiweb.net/shared/info/1771074083) (Glutanamite 제작), [Modern Material Theme](https://ankiweb.net/shared/info/1321246682), [Coloris](https://github.com/mdbassit/Coloris)에서 영감을 받음

### 🫶 감사의 마음

코딩과 애드온 개발의 기초를 가르쳐 준 **Anki** 및 [**Ankimon**](https://github.com/h0tp-ftw/ankimon) 커뮤니티에 감사드립니다! 버그 식별에 특별히 도움을 준 @Ouranos에게 특별한 감사를 전합니다.

### 💞 제 작업 지원하기

저는 지속적으로 업데이트와 새로운 기능을 제공합니다. 제 애드온이 학습이나 작업 흐름에 도움이 되었다면, 제 작업을 지원해 주세요. 여러분의 후원은 프로젝트가 유지되고 모두에게 무료로 제공될 수 있도록 합니다. 우리 [Discord](https://discord.gg/ZU9VZHMk3u)에 참여하세요.

<a href="https://www.buymeacoffee.com/peacemonk">
<img width="30%" height="auto" alt="Buy me an onigiri" src="https://github.com/user-attachments/assets/2c993906-ccb5-4a75-9235-9b63a8d62252" />
<br>
<br>
</a>

### ⭐ GitHub 별 기록

[![Star History Chart](https://api.star-history.com/svg?repos=thepeacemonk/Onigiri&type=date&logscale&legend=top-left)](https://www.star-history.com/#thepeacemonk/Onigiri&type=date&logscale&legend=top-left)


### 🍙 This is Onigiri

<img width="60%" height="auto" alt="1" src="https://github.com/user-attachments/assets/523a7890-d599-4030-80c5-45bf9626ad17" />
<img width="60%" height="auto" alt="2" src="https://github.com/user-attachments/assets/75fa35cb-e74b-402d-880a-0b98a7ce3ce4" />
<img width="60%" height="auto" alt="3" src="https://github.com/user-attachments/assets/44e0627d-2a57-40b5-9e5a-6b237a848f7c" />
<img width="60%" height="auto" alt="4" src="https://github.com/user-attachments/assets/6bddc6d2-2105-40fd-9b89-df86f39732a3" />
<img width="60%" height="auto" alt="5" src="https://github.com/user-attachments/assets/983121f6-6c63-4f5d-9cf0-3491100ed28d" />
<img width="60%" height="auto" alt="6" src="https://github.com/user-attachments/assets/6a907210-1d64-4d3f-986c-6816641a7080" />


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-18

---