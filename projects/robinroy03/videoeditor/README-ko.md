<samp>
  
<h1>오픈 소스 비디오 편집기</h1>
<p>React, Remotion, TypeScript를 사용한 평범하지 않은 비디오 편집기 애플리케이션입니다.</p>
<br />

> [!NOTE]  
> 이 애플리케이션은 활발히 개발 중입니다. 현재는 초기 MVP 버전입니다. 실행하시려면 [Discord 서버](https://discord.gg/GSknuxubZK)에 참여해 주세요.

<br />

<p align="center">
  <img src="https://raw.githubusercontent.com/robinroy03/videoeditor/main/public/screenshot-app.png" alt="React Video Editor Screenshot">
</p>
<p align="center">Capcut, Canva, RVE의 오픈 소스 대안입니다.</p>
</samp>

## ✨기능

- 🎬비선형 비디오 편집
- 🔀멀티 트랙 지원
- 👀실시간 미리보기
- 📤비디오 내보내기
- 📜MIT 라이선스

## 🐋배포

```
git clone https://github.com/robinroy03/videoeditor.git
cd videoeditor
docker compose up
```

## 🧑‍💻개발

```
pnpm i
pnpm run dev (프론트엔드)
pnpm dlx tsx app/videorender/videorender.ts (백엔드)
uv run backend/main.py
`/app/utils/api.ts`에서 `isProduction`을 `false`로 변경하세요.

AI 기능을 사용하려면 GEMINI_API_KEY도 필요합니다.
```

## 📃TODO

할 일이 많습니다! 우선 Remotion의 모든 API를 통합할 계획입니다. 곧 자세한 로드맵을 추가하겠습니다. 업데이트 및 지원을 위해 [Discord 서버](https://discord.com/invite/GSknuxubZK)에 참여해 주세요.

## ❤️기여

여러분의 기여를 환영합니다! ❤️ [기여 가이드](https://raw.githubusercontent.com/robinroy03/videoeditor/main/CONTRIBUTING.md)를 확인해 주세요.

## 📜라이선스

이 프로젝트는 MIT 라이선스로 제공됩니다. 프로젝트 관련 부분에는 [Remotion 라이선스](https://github.com/remotion-dev/remotion/blob/main/LICENSE.md)도 적용됩니다.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---