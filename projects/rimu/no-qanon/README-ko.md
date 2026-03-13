# No-QAnon

QAnon, 음모론, 가짜 뉴스, 극우 및 차별적 웹사이트에 대한 반파시스트 도메인 차단 목록입니다.

증오 집단 및 악의적 행위자와 연결된 웹사이트를 차단함으로써 모집, 선전 활동을 무력화하고, 심리전, 인위적 여론 조성, 트롤, 거짓 깃발, 소크퍼페팅, 확률적 테러리즘, FUD와 같은 전술을 통한 허위 정보 확산을 늦추는 것을 목표로 합니다.

도메인 차단 목록은 전체 웹사이트만 차단합니다: 급진화가 자주 발생하는 소셜 미디어 내의 개별 콘텐츠는 차단할 수 없습니다.
그럼에도 불구하고 허위 및 유해 정보에 대한 노출을 확실히 줄일 수 있습니다.
파시스트들은 취약한 사람들을 노리므로 경계를 유지하고 필요하다면 소셜 미디어 차단 목록 사용도 고려하세요.

[반파시스트 라이선스](https://github.com/rimu/no-qanon/blob/master/LICENSE.txt) 하에 배포됩니다.

## Hosts 형식

[Hosts 형식 차단 목록](https://raw.githubusercontent.com/rimu/no-qanon/master/hosts.txt)은 [hosts](https://en.wikipedia.org/wiki/Hosts_(file)) 파일이나 PiHole에서 사용 가능합니다.

[IPV6 버전](https://raw.githubusercontent.com/rimu/no-qanon/master/hosts.txt.ipv6).

- [Windows 컴퓨터에 설치하는 방법.](https://github.com/yui-konnu/qanon-block-guide)

- [PiHole에 설치하는 방법.](https://www.reddit.com/r/QAnonCasualties/comments/wekhem/how_to_use_pihole_to_block_q_related_websites/)

알려진 문제: Firefox의 DNS over HTTPS 옵션은 컴퓨터의 hosts 파일 규칙을 우회합니다. https://bugzilla.mozilla.org/show_bug.cgi?id=1453207

## Dnsmasq 형식

[Dnsmasq 형식 차단 목록](https://raw.githubusercontent.com/rimu/no-qanon/master/dnsmasq.txt)은 [Dnsmasq](https://thekelleys.org.uk/dnsmasq/doc.html) DNS 서버 소프트웨어와 함께 사용합니다.

## 브라우저 확장 프로그램

### Netsane 형식

[Netsane 형식 차단 목록](https://raw.githubusercontent.com/rimu/no-qanon/master/netsane.txt)은 [Netsane](https://github.com/rimu/netsane) 소프트웨어와 함께 사용합니다.

### AdBlock Plus 문법

[AdBlock 형식 차단 목록](https://raw.githubusercontent.com/rimu/no-qanon/master/adblock.txt)은 광고 차단기([uBlock Origin](https://ublockorigin.com), [Adguard](https://adguard.com) 등) 또는 Adguard Home에서 사용합니다. 엄격한 차단 규칙([strict blocking rule](https://github.com/gorhill/uBlock/wiki/Strict-blocking))을 사용하여 브라우저에서 해당 사이트 접근을 차단합니다.

[구독하려면 여기를 클릭하세요.](https://subscribe.adblockplus.org/?location=https://raw.githubusercontent.com/rimu/no-qanon/master/adblock.txt&title=No-QAnon)

### uBlacklist 구문

[uBlacklist 형식의 차단 목록](https://raw.githubusercontent.com/rimu/no-qanon/master/ublacklist.txt)은 [uBlacklist](https://github.com/iorate/ublacklist)와 함께 사용됩니다. 검색 엔진 결과에서 차단된 사이트를 제거합니다.

[구독하려면 여기를 클릭하세요.](https://iorate.github.io/ublacklist/subscribe?name=No-QAnon&url=https://raw.githubusercontent.com/rimu/no-qanon/master/ublacklist.txt) (이 자동 구독 링크는 Chrome에서만 호환되며, 다른 브라우저에서는 직접 추가해야 합니다!)

### 도메인 목록

[도메인 목록 형식](https://raw.githubusercontent.com/rimu/no-qanon/master/domains.txt)은 [Search Engine Spam Blocker](https://github.com/no-cmyk/Search-Engine-Spam-Blocker)와 함께 사용됩니다. 검색 엔진 결과에서 차단된 사이트를 제거합니다.

## 기여 방법

이 저장소를 클론하고 `sources` 폴더 내 적절한 `.txt` 파일에 새 도메인을 추가하세요. 분류를 원하지 않으면 `sources/default.txt` 파일에 추가하면 차단됩니다.

> `https://www.example.com` 웹사이트는 `sources/default.txt` 파일에 `example.com`을 추가하세요.

그런 다음 변경사항을 `sources` 폴더에 푸시하면 GitHub Actions가 자동으로 차단 목록의 새 버전을 생성합니다. 직접 생성하려면 `scripts/update.sh` 스크립트를 실행할 수 있습니다(필수 조건: bash, python).

마지막으로 풀 리퀘스트를 만드세요: 며칠 내에 검토하고 승인할 것입니다.

### 분류

차단된 사이트는 `sources` 폴더 내 하위 폴더와 `.txt` 파일로 구성됩니다. 더 많은 정보와 참고를 위해 마크다운(`.md`) 파일과 주석(`#`)을 사용하세요.

### 기여 방법 (쉬운 모드)

Git 사용법을 모른다 해도 기여할 수 있습니다! [이슈를 열어](https://github.com/rimu/no-qanon/issues) 추가하고 싶은 URL을 언어 및 카테고리별로 그룹화하여 알려주세요. 곧 확인 후 추가하겠습니다.

## 기타 유용한 목록

[Jmdugan 차단 목록](https://github.com/jmdugan/blocklists/tree/master/corporations): 트위터, 유튜브, 페이스북처럼 많은 가짜 뉴스를 퍼뜨리는 사이트 차단을 고려하세요.

[Antifa-n 차단 목록](https://github.com/antifa-n/pihole/blob/master/blocklist.txt)도 파시스트 사이트에 초점을 맞춘 훌륭한 차단 목록입니다.

[우회 방법 차단 목록](https://github.com/nextdns/metadata/blob/master/parentalcontrol/bypass-methods)은 우회 방법(VPN, 프록시, DNS 등)을 차단하는 데 사용할 수 있습니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-13

---