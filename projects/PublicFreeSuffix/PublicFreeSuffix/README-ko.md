<translate-content># 공개 무료 접미사: 모두를 위한 무료 도메인 이름

**공개 무료 접미사**는 다양한 커뮤니티를 지원하기 위해 설계된 비영리 무료 서브도메인 서비스입니다. 우리는 다음과 같은 접근 가능한 자원을 제공하는 것을 믿습니다:

* **개발자:** 프로젝트 테스트, 스테이징 환경 및 개인 개발 샌드박스에 적합합니다.
* **학생:** 학술 연구, 수업 프로젝트 및 새로운 기술 학습에 비용 장벽 없이 이상적입니다.
* **기술자:** 컴퓨터 및 네트워크 기술 연구, 실험실 구축 및 새로운 구성 실험에 훌륭한 자원입니다.
* **개인 사용자:** 준수 프레임워크 내에서 개인 블로그, 포트폴리오 또는 작은 열정 프로젝트를 호스팅하세요.

누구나 여기서 무료 도메인을 등록하고 받을 수 있으며 연간 갱신할 필요가 없습니다. 현재 서비스를 제공하는 접미사(sld)는 다음과 같습니다:</translate-content>
```text
pfsdns.org
nastu.net
tun.re
6ti.net
no.kg
htu.edu.kg
```
## 지원되는 서드파티 DNS 호스팅 플랫폼
사용자들이 테스트하고 지원하는 서드파티 DNS 서비스 호스팅 플랫폼(유료/무료)입니다. 원하는 도메인 이름을 먼저 이들 플랫폼에 추가하고 NS 레코드를 얻은 후, PR 등록 절차를 시작해야 합니다.

[<img alt="dns.he.net" title="dns.he.net" height="40px" style="margin-right:10px" src="https://dns.he.net/include/images/helogo.gif" />](https://dns.he.net/?src=PublicFreeSuffix)
[<img alt="desec.io" title="desec.io" height="40px" style="margin-right:10px" src="https://desec.io/assets/logo-CP29ePBl.svg" />](https://desec.io/?src=PublicFreeSuffix)
[<img alt="hostry.com" title="hostry.com" height="40px" src="https://hostry.com/img/logo.svg?v=1.00r3266" />](https://hostry.com/?src=PublicFreeSuffix)

## 도메인 이름은 어떻게 등록하나요?

[수용 가능한 사용 정책](https://raw.githubusercontent.com/PublicFreeSuffix/PublicFreeSuffix/main/agreements/acceptable-use-policy.md) | 
[개인정보 보호 정책](https://raw.githubusercontent.com/PublicFreeSuffix/PublicFreeSuffix/main/agreements/privacy-policy.md) | 
[등록 및 사용 계약](https://raw.githubusercontent.com/PublicFreeSuffix/PublicFreeSuffix/main/agreements/registration-and-use-agreement-sokg.md) | 
[예약어 목록](https://raw.githubusercontent.com/PublicFreeSuffix/PublicFreeSuffix/main/reserved_words.txt)
1. 저장소를 클론합니다:

```bash
git clone https://github.com/PublicFreeSuffix/PublicFreeSuffix.git
```
자신의 도메인 이름을 위한 새 브랜치를 만드세요:
```bash
git checkout main
git pull origin main
git checkout -b yourdomain.no.kg-request-1
```
PR(풀 리퀘스트) 작업을 수행하기 전에—도메인의 Whois 파일을 등록, 업데이트 또는 삭제하는 경우에도—항상 메인 브랜치로 전환하고 최신 변경 사항을 로컬 환경에 동기화해야 합니다.  
그 후, 지정된 브랜치 명명 규칙에 따라 새 브랜치를 생성하십시오. 변경 사항을 저장한 다음 이 새 브랜치에서 새로운 PR을 생성합니다.  
브랜치 명명 규칙은 항상 특정 작업 수에 맞게 조정되어야 하며, 형식은 다음과 같습니다: `yourdomain.no.kg-request-{a_number_here}`.  
  
2. 사용 가능한 도메인 이름을 선택하고, `./whois/{your-new-domain-name}.json` 폴더에 새 whois 파일을 생성하십시오:
```json
{
  "registrant": "your-own-example@gmail.com",
  "domain": "mynewdomain",
  "sld": "no.kg",
  "nameservers": [
    "nameserver1.example.com",
    "nameserver2.example.com",
    "nameserver3.example.com",
    "nameserver4.example.com"
  ],
  "agree_to_agreements": {
    "registration_and_use_agreement": true,
    "acceptable_use_policy": true,
    "privacy_policy": true
  }
}
```
<translate-content>- `registrant`: 도메인 소유자의 이메일 주소입니다.
- `domain`: 최상위 도메인을 제외한 도메인 이름(e.g., "mynewdomain"), 도메인 길이는 3자 이상이어야 합니다.
- `sld`: 등록하려는 접미사(e.g., "no.kg" 또는 이전 목록에 있는 SLD 중 하나).
- `nameservers`: 도메인 해석을 담당하는 DNS 서버 목록, 2~4개의 서버 허용.
- `agree_to_agreements`: 사용자가 등록 및 이용 약관, 허용된 사용 정책, 개인정보 보호정책에 동의했는지를 나타내는 불리언 값.
- 이 파일의 이름은 `{your-new-domain-name}.json`이어야 하며, 예를 들어 여기서는 `mynewdomain.no.kg.json`입니다.

> **공지** 활용도를 높이고 등록의 사재기 및 자원 낭비를 방지하기 위해, 30일 연속으로 웹사이트 콘텐츠가 배포되지 않은 경우 등록된 도메인 이름이 취소됩니다.

3. 새 도메인 이름과 whois 파일로 풀 리퀘스트를 생성하세요. PR 설명은 [PR 설명 템플릿](https://raw.githubusercontent.com/PublicFreeSuffix/PublicFreeSuffix/main/.github/pull_request_template.md) 형식이어야 하며, 제목은 다음과 같이 작성해야 합니다:</translate-content>
```text
Registration/Update/Remove: {your-new-domain-name}.{sld}
```
한 개의 Pull Request에는 하나의 도메인 이름 등록 요청만 제출할 수 있습니다.

4. [이메일을 통한 자동 등록자 승인(Automated Registrant Authorization via Email, ARAE)](https://raw.githubusercontent.com/PublicFreeSuffix/PublicFreeSuffix/main/AUTHORIZATION.md) 설명에 따라 등록자 이메일 인증을 완료하세요.

5. 도메인이 설정되면 웹사이트나 기타 용도로 사용할 수 있습니다.

## 도메인의 NS / 등록자 이메일을 어떻게 업데이트 하나요?
간단합니다, whois 파일을 수정하고 새로운 pull request를 생성한 후 다시 등록자 이메일 인증을 완료하세요.

[<img title="도메인 남용 신고" src="https://i.postimg.cc/Xq7VHpLs/rebuse-log.png" height="35px" />](https://forms.gle/cXkxrKbdoeBsKBQdA)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---