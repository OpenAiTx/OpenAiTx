<h1 align="center">📮 Just a Temp</h1>
<p align="center">Cloudflare가 지원하는 무료 임시 이메일 서비스
  <br>
  </br>
  <img alt="CodeQL" src="https://github.com/berrysauce/justatemp/actions/workflows/github-code-scanning/codeql/badge.svg">
  <img alt="GitHub release (latest by date including pre-releases)" src="https://img.shields.io/github/v/release/berrysauce/junk.boats?color=blue&include_prereleases&label=latest%20release">
</p>

> ℹ️ 이 서비스는 100% [Cloudflare](https://www.cloudflare.com/)가 지원합니다.

> [!IMPORTANT]
> 이 프로젝트는 이전에 "junk.boats" 도메인에서 제공되었습니다.

### justatemp.com이란?
justatemp.com은 또 하나의, 무료로 사용할 수 있고, 오픈 소스이며, 물론 개인정보 보호 친화적인 임시 이메일 생성기입니다. 이메일을 주기 꺼려지는 사이트들로부터 이메일을 받기 위해 justatemp.com을 사용할 수 있습니다. 수신된 모든 이메일은 2시간 동안 공개 저장되며 이후 영구 삭제됩니다.

<img alt="Just A Temp Screenshot" src="https://public-cdn.berrysauce.me/shared/justatemp-screenshot-yWtqO.png">

### 개인정보 보호는 어떻게 되나요?
justatemp.com은 수신된 이메일만 저장합니다. 그 외 다른 사용자 데이터는 저장하지 않습니다. 이메일은 2시간 후 자동 삭제됩니다. 그때까지는 해당 수신 주소를 가진 누구나 이 주소가 받은 이메일을 볼 수 있습니다. 분석을 위해 justatemp.com은 Cloudflare의 익명 웹 분석을 사용합니다.

### collector, postmaster, postoffice는 무엇인가요?
- 📮 `mailbox`는 모든 수신 메일을 받고 저장하는 Cloudflare 이메일 워커입니다
- 🚚 `postservice`는 HonoJS Cloudflare 워커가 지원하는 API 형태의 이메일 배포 서비스입니다
- 🏤 `frontend`는 수신된 이메일을 사용자에게 보여주는 SvelteKit 프론트엔드입니다

### justatemp.com은 어떻게 작동하나요?
수신된 메일은 `mailbox` 이메일 워커로 전달됩니다. 이 워커는 이메일을 Cloudflare KV 데이터베이스에 저장합니다. Svelte 프론트엔드는 무작위 이메일 주소를 생성하고 `postservice`에 해당 주소의 모든 이메일을 요청합니다. 이메일이 있으면 KV 항목에 포함된 UNIX 타임스탬프 순으로 정렬해 보여줍니다.

### 개발
곧 더 자세히 안내 예정입니다


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---