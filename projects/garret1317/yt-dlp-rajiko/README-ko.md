# yt-dlp-rajiko

향상된 [radiko.jp](https://radiko.jp) 추출기 플러그인 for yt-dlp (빠르고 지역 제한 없음)

<p>yt-dlp-rajiko를 사용하면 <a href="https://radiko.jp">radiko.jp</a>에서 VPN 없이 일본 라디오 방송을 다운로드할 수 있습니다. <a href="https://github.com/yt-dlp/yt-dlp">yt-dlp</a>를 사용합니다.
빠르게 다운로드하며 전 세계 어디서나 참여하는 모든 방송국*에서 작동합니다.<br>
<small>*NHK 제외, 그러나 NHK는 <a href="https://www.nhk.or.jp/radio/">자체 사이트</a>가 있으며 yt-dlp 자체에서 지원됩니다</small></p>

<p>개인 저장용으로 의도되었으며 상업적 용도가 아닙니다. 가능하다면 radiko Premium에 가입해 주세요.<br>
<small>(무료 소프트웨어이므로, 강제 사항이 아니라 저의 정중한 부탁입니다. radiko가 계속 존재할 수 있도록 꼭 해주세요)<br>
(또한, timefree30 플랜을 사용하면 yt-dlp와 함께 사용할 수 있습니다 :P)
</small></p>

### [日本語  🇯🇵](https://427738.xyz/yt-dlp-rajiko/index.ja.html)

## 설치

[플러그인 번들 다운로드](https://427738.xyz/yt-dlp-rajiko/dl/yt_dlp_rajiko-latest.bundle.zip) 또는 `pip install yt-dlp-rajiko`

<p>yt-dlp 2025.02.19 이상 버전이 필요합니다.</p>

<p>pip로 yt-dlp를 설치했다면 위의 pip 명령어를 사용하세요.
만약 <code>pipx</code>로 설치했다면,
<code>pipx inject yt-dlp yt-dlp-rajiko</code>를 사용하여 yt-dlp 환경에 플러그인을 설치하세요.</p>

<p>.exe/바이너리 또는 다른 방법으로 설치했다면,
번들을 다운로드하여 아래 위치 중 하나에 넣으세요: </p>

<ul>
	<li><code>%appdata%\yt-dlp\plugins\</code> (Windows에서)</li>
	<li><code>~/.config/yt-dlp/plugins/</code> (Linux 및 Mac에서)</li>
	<li><code>yt-dlp.exe</code> 옆에 <code>yt-dlp-plugins</code> 폴더 생성 <a href="https://427738.xyz/yt-dlp-rajiko/i/installation-pluginsfolder2.png">(이와 같이)</a><br>
	<li><a href="https://github.com/yt-dlp/yt-dlp#installing-plugins">yt-dlp 문서</a>에 나열된 다른 위치</li>
</ul>

<p>해당 폴더가 없으면 직접 만들어야 합니다.<br>
<b>zip 파일을 압축 해제할 필요가 없습니다.</b></p>



<p>설치가 제대로 되었는지 확인하려면 <code>yt-dlp -v</code>를 실행하고 <code>[debug] Extractor Plugins:</code> 또는 <code>[debug] Plugin directories:</code> 줄을 찾으세요. <a href="https://427738.xyz/yt-dlp-rajiko/i/plugincheck.png">(이와 같이)</a>
</p>

yt-dlp 플러그인에 대한 자세한 정보는 [yt-dlp 문서](https://github.com/yt-dlp/yt-dlp#plugins)에서 확인할 수 있습니다.

## 더 많은 정보

[자세한 내용은 웹사이트를 참조하세요](https://427738.xyz/yt-dlp-rajiko/) (사용법, 연락 방법 등)

[일본어 번역도 있습니다](https://427738.xyz/yt-dlp-rajiko/index.ja.html)

## 이 저장소에 대하여

여기는 소스 코드와 버그 트래커가 있는 곳입니다. 대부분의 정보는 웹사이트에 있습니다.

일반적으로 릴리스 버전을 사용하는 것이 좋습니다.
`master` 브랜치는 보통 작동하지만 실험적이며 버그가 있을 수 있습니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-28

---