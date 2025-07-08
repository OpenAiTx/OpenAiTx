# MoneyPrinter 💸

> ♥︎ 스폰서: 최고의 AI 채팅 앱: [shiori.ai](https://www.shiori.ai)
---

> 𝕏 X에서도 저를 팔로우하세요: [@DevBySami](https://x.com/DevBySami).

YouTube Shorts 제작을 자동화하세요. 대화할 동영상 주제만 제공하면 됩니다.

<a href="https://trendshift.io/repositories/7545" target="_blank"><img src="https://trendshift.io/api/badge/repositories/7545" alt="FujiwaraChoki%2FMoneyPrinter | Trendshift" style="width: 250px; height: 55px;" width="250" height="55"/></a>

> **중요** 새 이슈를 생성하기 전에 기존/닫힌 이슈를 꼭 확인해 주세요. 단순한 질문이라면 [discord](https://dsc.gg/fuji-community)에 참여해서 문의해 주세요.

> **🎥** [YouTube](https://youtu.be/mkZsaDA2JnA?si=pNne3MnluRVkWQbE)에서 동영상을 시청하세요.

로컬 버전 사용 설명서는 [여기](https://raw.githubusercontent.com/FujiwaraChoki/MoneyPrinter/main/Local.md)에서 확인하세요.

## FAQ 🤔

### TikTok 세션 ID는 어떻게 얻나요?

브라우저에서 TikTok에 로그인한 후 `sessionid` 쿠키의 값을 복사하여 TikTok 세션 ID를 얻을 수 있습니다.

### ImageMagick 바이너리가 감지되지 않습니다

`.env` 파일에서 ImageMagick 바이너리 경로를 올바르게 설정했는지 확인하세요. 예시는 다음과 같습니다:

```env
IMAGEMAGICK_BINARY="C:\\Program Files\\ImageMagick-7.1.0-Q16\\magick.exe"
```

경로에는 역슬래시(`\\`)를 두 번 사용해야 합니다. 한 번만 사용하면 안 됩니다.

### `playsound`를 설치할 수 없습니다: Wheel 빌드 실패

`playsound` 설치에 문제가 있다면, 다음 명령어로 설치를 시도해 보세요:

```bash
pip install -U wheel
pip install -U playsound
```

문제를 해결하지 못했다면, discord에서 문의하거나 새 이슈를 생성해 주세요. 커뮤니티가 도와드릴 수 있습니다.

## 기부하기 🎁

`MoneyPrinter`를 좋아하고 즐기신다면, 저장소 오른쪽에 있는 버튼을 클릭하여 기부하실 수 있습니다. ❤️
기부자 명단(및/또는 로고)이 감사의 표시로 이 저장소에 추가됩니다.

## 기여하기 🤝

현재는 Pull Request를 받지 않습니다.

## Star 히스토리 🌟

[![Star History Chart](https://api.star-history.com/svg?repos=FujiwaraChoki/MoneyPrinter&type=Date)](https://star-history.com/#FujiwaraChoki/MoneyPrinter&Date)

## 라이선스 📝

자세한 내용은 [`LICENSE`](LICENSE) 파일을 참조하세요.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---