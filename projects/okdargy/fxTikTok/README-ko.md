# fxTikTok

Discord에서 TikTok 비디오와 슬라이드쇼를 `s/i/n` 만으로 임베드하세요

> [!NOTE]  
> fxTikTok에서 보고 싶은 기능이 있거나 버그를 신고하고 싶으신가요? 이슈를 만들어 주세요! 여러분의 피드백을 듣고 싶습니다.

## 📸 스크린샷

<details>
  <summary>fxTikTok이 실제로 어떻게 작동하는지 미리보려면 클릭하세요</summary>

| <img src="/.github/readme/compare.png" alt="Video Preview" height="400px" /> |
| :--------------------------------------------------------------------------: |
|          Discord에서 `tiktok.com` vs. `tnktok.com` 임베드 비교           |

| <img src="/.github/readme/slideshow.png" alt="Slideshow Preview" /> |
| :-----------------------------------------------------------------: |
|                          슬라이드쇼 임베드                           |

| <img src="/.github/readme/direct.png" alt="Direct Preview" height="400px" /> |
| :--------------------------------------------------------------------------: |
|                          직접 이미지/비디오 지원                          |

</details>

## 📖 사용법

Discord에서 fxTikTok 사용은 쉽습니다. TikTok 링크를 보내고 `s/i/n`을 입력하여 못생기고 반응하지 않는 임베드를 수정하세요

<details>
  <summary>👁️ 시각적으로 배우고 싶나요? GIF 튜토리얼을 보려면 클릭하세요</summary>

  <img src="https://raw.githubusercontent.com/okdargy/fxTikTok/hono-rewrite/.github/readme/introduction.gif" alt="Introduction GIF" height="500px" style="border-radius:2%" />
</details>

### 어떻게 작동하나요?

Discord에서 `s/i/n`을 입력하면 [sed](https://www.gnu.org/software/sed/manual/sed.html) 형식을 사용하여 가장 최근 메시지를 수정합니다. 구체적으로, 메시지에서 두 번째 매개변수(`i`)의 첫 번째 발생을 세 번째 매개변수(`n`)로 교체합니다.

|     이전     |     이후      |
| :------------: | :------------: |
| t**i**ktok.com | t**n**ktok.com |

> [!TIP]
> 디스코드 서버를 운영 중이라면 [FixTweetBot](https://github.com/Kyrela/FixTweetBot)을 서버에 추가하는 것을 강력히 추천합니다. 이 봇은 fxTikTok 같은 임베드 수정기를 자동으로 적용하며 매우 커스터마이징 가능합니다.

### 직접 임베드 사용하기

임베드에 통계 정보가 모두 나오지 않고 영상이나 이미지 만을 원하나요? URL을 `d.tnktok.com`으로 변경하기만 하면 됩니다.

|         이전         |        이후         |
| :--------------------: | :------------------: |
| **www**.t**i**ktok.com | **d**.t**n**ktok.com |

> 또는 URL 쿼리에 `?isDirect=true`를 추가하여 `isDirect`를 true로 설정할 수도 있습니다.

### "영상의 캡션이 보이지 않아요!"

기본적으로 설명을 `og:description` 태그에 넣지만, 임베드에 영상이 포함되어 있으면 디스코드가 이를 임베드에서 제거합니다. [tfxktok.com](https://tfxktok.com)처럼 임베드 상단에 추가하면 해시태그로 너무 복잡해지므로 그렇게 하지 않았습니다.

하지만 영상에 추가 정보를 제공할 필요가 있을 경우 사용자가 설명을 임베드 상단에 추가할 수 있도록 옵션을 제공합니다. URL을 `a.tnktok.com`으로 변경하면 설명이 상단에 추가됩니다.

|         이전         |        이후         |
| :--------------------: | :------------------: |
| **www**.t**i**ktok.com | **a**.t**n**ktok.com |

> 또는 URL 쿼리에 `?addDesc=true`를 추가하여 `addDesc`를 true로 설정할 수도 있습니다.

### 고화질로 변경하기

틱톡은 H.265/HEVC(고효율 비디오 코딩)를 지원하며, 이는 동일 용량 대비 훨씬 나은 화질을 제공하지만 호환성 문제가 있습니다. 기본적으로는 [많은 사용자가 H.265 임베드 문제를 보고했기](https://github.com/okdargy/fxTikTok/issues/14) 때문에 H.264 화질을 사용하지만 H.265 활성화도 지원합니다.

고화질 H.265 재생을 활성화하려면 `?hq=true`를 추가하거나 `hq.tnktok.com`을 사용하세요:
| 이전 | 이후 |
| :--------------------: | :------------------: |
| **www**.t**i**ktok.com | **hq**.t**n**ktok.com |

### 모드 결합하기

서로 다른 모드를 특정 호스트명이나 URL 쿼리 매개변수를 사용하여 조합할 수 있습니다. 예를 들어, H.265를 활성화하고 자막도 보고 싶다면 `hq.a.tnktok.com`을 사용하거나 URL에 `?hq=true&addDesc=true`를 추가하면 됩니다.

> 직접 모드와 자막 모드는 서로 상충되므로 동시에 사용할 수 없습니다.

### 왜 tnktok.com을 사용해야 할까요?

우리는 다른 곳에 없는 다양한 기능을 갖춘 최고의 틱톡 임베딩 서비스 중 하나로 모든 조건을 충족합니다. 다음 표는 우리의 서비스인 tnktok.com과 다른 틱톡 임베딩 서비스 및 틱톡 기본 임베드 기능을 비교한 내용입니다.

|                                        | [fxTikTok](https://www.tnktok.com) | 기본 틱톡      | [kkScript](https://kktiktok.com/) | [tfxktok.com](https://tfxktok.com) | [EmbedEZ](https://tiktokez.com) |
| -------------------------------------- | ---------------------------------- | -------------- | --------------------------------- | ---------------------------------- | ------------------------------- |
| 재생 가능한 비디오 임베드               | ☑️                                 | ☑️             | ☑️                                | ☑️                                 | ☑️                              |
| 다중 이미지 슬라이드쇼 임베드            | ☑️                                 | ❌             | ❌                                | ☑️                                 | ☑️                              |
| 오픈 소스                             | ☑️                                 | ❌             | ❔                                | ❌                                 | ❌                              |
| 직접 임베드 지원                      | ☑️                                 | ❌             | ❔                                | ❌                                 | ❌                              |
| 좋아요, 공유, 댓글 표시                 | ☑️                                 | ☑️             | ❌                                | ☑️                                 | ☑️                              |
| 리다이렉트 추적 제거                   | ☑️                                 | ❌             | ❌                                | ☑️                                 | ☑️                              |
| 다중 대륙 단축 URL 지원                | ☑️                                 | ☑️             | ❌                                | ❌                                 | ☑️                              |
| h265/고화질 지원                      | ☑️                                 | ❌             | ❌                                | ❌                                 | ❌                              |
| 마지막 커밋                           | [![][tnk]][tnkc]                   | 해당 없음       | [![][kkt]][kktc]                  | 해당 없음                           | 해당 없음                       |

[tnk]: https://img.shields.io/github/last-commit/okdargy/fxTikTok?label  
[tnkc]: https://github.com/okdargy/fxTikTok/commits  
[kkt]: https://img.shields.io/github/last-commit/kkscript/kk?label  
[kktc]: https://github.com/kkscript/kk/commits  

다음 임베드 서비스들은 유지보수되지 않거나 작동하지 않아 목록에서 제외되었습니다:

- [tiktxk.com](https://tiktxk.com)  
- [vxtiktok.com](https://vxtiktok.com) (kkScript로 리다이렉트)  

## 💻 셀프호스팅

기본적으로 새로운 fxTikTok 인스턴스를 설정할 때 기본 오프로딩 서버는 `offload.tnktok.com`입니다.  
자신만의 서버를 설정하려면 [`offload.ts`](/src/offload.ts)를 컴파일하고 실행하면 포트 **8787**에서 시작됩니다.

```bash
# Install all necessary dependencies
pnpm install
# Start your server
bun run src/offload.ts
```
> 이 구성을 자신의 도메인과 함께 [nginx](https://nginx.org) 같은 리버스 프록시 및 Cloudflare 위에 보호 설정과 함께 구성할 것을 권장합니다.

다음으로, 아래 버튼을 눌러 Worker를 배포하고 지침을 따르세요.

[![Cloudflare Workers에 배포](https://deploy.workers.cloudflare.com/button)](https://deploy.workers.cloudflare.com/?url=https://github.com/okdargy/fxtiktok)

배포가 완료되면 "설정"으로 이동하여 "변수 및 비밀" 아래에서 오프로드 서버를 변경하세요:

<img src="https://raw.githubusercontent.com/okdargy/fxTikTok/hono-rewrite/.github/readme/settings.png" alt="설정 페이지, 오프로드 서버 변경 위치 표시" height="300px" style="border-radius:2%" />

#### 🎉 끝났습니다! 이제 언제 어디서나 사용할 수 있는 자신만의 fxTikTok 인스턴스를 갖게 되었습니다.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-04

---