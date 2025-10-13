> 이 저장소는 v1 전용이며 Bilibil 및 YouTube를 지원합니다!

# 🤖 BibiGPT: 오디오/비디오 AI 요약 및 학습 콘텐츠 채팅 원클릭 [https://bibigpt.co](https://bibigpt.co)

🎉 AI 기반 비디오 요약기로 YouTube 및 Bilibili 영상을 손쉽게 요약하세요. 팟캐스트, 트위터, 회의, 강의, 틱톡 영상 등에도 적용 가능합니다. 최고의 AI 학습 동반자 ChatGPT와 함께 더 똑똑하게 학습하는 방법을 발견하세요! (이전 명칭 BiliGPT) "스트림 절약 도구 & 반장".

대체 주소: https://b.jimmylv.cn  
브라우저 확장 프로그램: https://bibigpt.co/extension

---

## 🤖 BibiGPT · AI 음영상 콘텐츠 원클릭 요약 & 대화 [https://bibigpt.co](https://bibigpt.co)

🎉 ChatGPT AI 음영상 원클릭 요약으로 Bilibili丨YouTube丨로컬 비디오丨로컬 오디오丨팟캐스트丨샤오홍슈丨틱톡丨회의丨강의丨웹 등 모든 콘텐츠를 쉽게 학습하세요. BibiGPT는 최고의 AI 학습 보조 도구가 되도록 돕고 무료 체험을 지원합니다! (이전 BiliGPT 절약神器 & AI 반장) (iOS 단축어 & 위챗 서비스 계정 지원).

예비 주소: https://b.jimmylv.cn  
브라우저 플러그인: https://bibigpt.co/extension

---

🎬 이 프로젝트는 AI를 사용하여 YouTube/Bilibili/Twitter/TikTok/팟캐스트/강의/회의/... 영상 또는 오디오를 요약합니다.

🤯 [Nutlope/news-summarizer](https://github.com/Nutlope/news-summarizer) & [zhengbangbo/chat-simplifier](https://github.com/zhengbangbo/chat-simplifier/) & [lxfater/BilibiliSummary](https://github.com/lxfater/BilibiliSummary)에서 영감을 받았습니다.

[![BibiGPT음영상 요약 도구](https://raw.githubusercontent.com/JimmyLv/BibiGPT-v1/main/./public/BibiGPT.gif)](https://twitter.com/Jimmy_JingLv/status/1630137750572728320?s=20)

🚀 첫 출시: [【BibiGPT】AI 자동 요약 B 사이트 영상 콘텐츠, GPT-3 지능형 자막 추출 및 요약](https://www.bilibili.com/video/BV1fX4y1Q7Ux/?vd_source=dd5a650b0ad84edd0d54bb18196ecb86)

## 작동 방식

이 프로젝트는 [OpenAI ChatGPT API](https://openai.com/api/) (특히 gpt-3.5-turbo)와 [Vercel Edge functions](https://vercel.com/features/edge-functions)의 스트리밍, 그리고 Redis 캐시 및 속도 제한을 위한 [Upstash](https://console.upstash.com/)를 사용합니다. Bilibili 영상의 콘텐츠를 가져와 GPT-3 API에 프롬프트로 보내 요약을 요청한 뒤, Vercel Edge function을 통해 응답을 애플리케이션에 스트리밍합니다.

## 비용 절감

이와 같은 프로젝트는 비용이 많이 들 수 있으므로, 자신의 버전을 만들고 공개하려는 경우 비용 절감을 위해 다음 세 가지를 권장합니다:

- [x] 1. 사이트 남용을 막기 위한 속도 제한 구현  
- [x] 2. 비싼 AI 재생성을 피하기 위한 캐싱 구현  
- [x] 3. `summarize` 엣지 함수에서 `text-dacinci-003` 대신 `text-curie-001` 사용

## 로컬 실행

레포를 클론한 후, [OpenAI](https://beta.openai.com/account/api-keys)에서 계정을 만들고 API 키를 `.env`라는 파일에 넣으세요.

그런 다음, 커맨드 라인에서 애플리케이션을 실행하면 `http://localhost:3000`에서 이용할 수 있습니다.

[구체적인 실행 절차는 이 문서에 설명되어 있습니다 - 중국어 버전](https://raw.githubusercontent.com/JimmyLv/BibiGPT-v1/main/./deploy-ch.md)

```bash
npm run dev
```
## 배포

[Vercel](https://vercel.com?utm_source=github&utm_medium=readme&utm_campaign=vercel-examples)을 사용하여 예제를 배포하세요.

`./example.env` 파일을 참고하여 환경 변수를 설정하세요.

## Docker 지원

https://github.com/JimmyLv/BibiGPT/pull/133


```shell
# make sure setup .env file firstly
docker compose up -d
```

## Support -> Contact Me

![](https://raw.githubusercontent.com/JimmyLv/BibiGPT-v1/main/./public/wechat.jpg)

## Star History

[![Star History Chart](https://api.star-history.com/svg?repos=JimmyLv/BibiGPT&type=Date)](https://star-history.com/#JimmyLv/BibiGPT&Date)

## Contributors

This project exists thanks to all the people who contribute.

 <a href="https://github.com/JimmyLv/BibiGPT/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=JimmyLv/BibiGPT" />
 </a>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-13

---