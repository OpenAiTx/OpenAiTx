[![Banner](https://github.com/Omni-guides/Wabbajack-Modlist-Linux/blob/main/images/WabbajackModlistsBanner2.png)](https://github.com/Omni-guides/Wabbajack-Modlist-Linux)

<p align="center"><b>Wabbajack 애플리케이션 -</b>
  <a href="https://github.com/Omni-guides/Wabbajack-Modlist-Linux/wiki/Wabbajack-via-Proton">Proton을 통한 Deck/PC용 Wabbajack (권장) ·
  <a href="https://github.com/Omni-guides/Wabbajack-Modlist-Linux/wiki/Wabbajack-on-Linux-via-Wine">Wine을 통한 Linux용 Wabbajack (PC 전용)</a>
</p>

<p align="center"><b>Skyrim (Deck/PC) -</b>
  <a href="https://github.com/Omni-guides/Wabbajack-Modlist-Linux/wiki/Skyrim:-Tuxborn">Tuxborn</a> ·
  <a href="https://github.com/Omni-guides/Wabbajack-Modlist-Linux/wiki/Skyrim:-Licentia-DECK">Licentia DECK</a> ·
  <a href="https://github.com/Omni-guides/Wabbajack-Modlist-Linux/wiki/Skyrim:-Legends-of-the-Frost">Legends of the Frost</a>
</p>

<p align="center"><b>Skyrim (PC 전용) -</b>
  <a href="https://github.com/Omni-guides/Wabbajack-Modlist-Linux/wiki/General-Linux-Guide-(Anvil)">Anvil</a> ·
  <a href="https://github.com/Omni-guides/Wabbajack-Modlist-Linux/wiki/Skyrim:-Nordic-Souls">Nordic Souls</a> ·
  <a href="https://github.com/Omni-guides/Wabbajack-Modlist-Linux/wiki/Skyrim:-Keizaal">Keizaal</a> ·
  <a href="https://github.com/Omni-guides/Wabbajack-Modlist-Linux/wiki/Skyrim:-Living-Skyrim-4">Living Skyrim 4</a>
</p>

<p align="center"><b>Enderal (Deck/PC) -</b>
  <a href="https://github.com/Omni-guides/Wabbajack-Modlist-Linux/wiki/Enderal:-Emissaries-of-Tux">Emissaries of Tux</a>
</p>

<p align="center"><b>Fallout (Deck/PC) -</b>
  <a href="https://github.com/Omni-guides/Wabbajack-Modlist-Linux/wiki/Fallout-4:-Welcome-to-Paradise">Fallout 4: Welcome to Paradise</a> ·
  <a href="https://github.com/Omni-guides/Wabbajack-Modlist-Linux/wiki/Fallout-NV:-Begin-Again">Fallout New Vegas: Begin Again</a> ·
  <a href="https://github.com/Omni-guides/Wabbajack-Modlist-Linux/wiki/Fallout-NV:-Capital-Punishment">Fallout New Vegas: Capital Punishment</a>
</p>

<p align="center"><b>성능 -</b>
<a href="https://github.com/Omni-guides/Wabbajack-Modlist-Linux/wiki/Performance-Guide">Ouroboros의 우수한 성능 가이드</a>
</p>


<p align="center"><b>기타 -</b>
  <a href="https://github.com/Omni-guides/Wabbajack-Modlist-Linux/wiki">홈</a> ·
  <a href="https://github.com/Omni-guides/Wabbajack-Modlist-Linux/wiki/Using-the-omni%E2%80%90guides.sh-Automation-Script">자동화 스크립트</a> ·
  <a href="https://github.com/Omni-guides/Wabbajack-Modlist-Linux/wiki/General-Linux-Guide-(Anvil)">일반 Linux</a> ·
  <a href="https://github.com/Omni-guides/Wabbajack-Modlist-Linux/wiki/ENB,-Reshade-and-Community-Shaders">ENB 및 커뮤니티 셰이더</a> ·
  <a href="https://github.com/Omni-guides/Wabbajack-Modlist-Linux/wiki/Troubleshooting-and-FAQ">문제 해결 및 FAQ</a> 
</p>

---

면책 조항 - 저는 Wabbajack 그룹과 어떠한 관련도 없는, 단지 다른 게이머들을 돕고자 하는 게이머일 뿐입니다. 이 가이드에 대한 지원은 메인 [공식 Wabbajack 디스코드](https://discord.gg/wabbajack)의 #unofficial-linux-help 채널에서 받을 수 있을지도 모르지만, 디스코드에서 @저(@omni)로 연락하는 것이 가장 좋을 수 있습니다. 비공식 가이드이기 때문에 Wabbajack 지원팀이나 모드리스트 개발자들로부터 직접적인 지원을 받는 것은 매우 희박합니다.

[![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/D1D8H8WBD)

***

## 소개

이 포함된 가이드들은 진행 중인 작업으로, 주로 저의 테스트와 [공식 Wabbajack 디스코드](https://discord.gg/wabbajack)의 #unofficial-linux-help 채널에서 여러 사용자들과의 협업을 기반으로 하고 있습니다. 모든 참여자분들께 감사드립니다. 피드백은 언제나 환영합니다.

작은 문제에 대해 이 깃허브에 풀 리퀘스트를 제출하는 경우, 병합 없이 제안된 변경사항이 적용될 수 있습니다. 대신 수정 사항을 설명하는 이슈를 생성해 주세요.

### Wabbajack 애플리케이션

이제 Proton 또는 Wine을 통해 Linux(SteamOS/Deck 및 기타 배포판 모두)에서 직접 Wabbajack을 실행할 수 있습니다. Proton을 통한 구성은 Steam이 있는 모든 플랫폼에서 동일해야 하므로 선호되는 방법입니다. 만약 정말로 원하지 않는다면, 기본 Wine(스팀 덱 제외)을 사용할 수 있습니다.

### 자동 구성

가이드에는 모드리스트를 실행하기 위한 단계별 절차가 포함되어 있지만, 시작하는 데 필요한 작업을 대폭 줄이기 위해 자동화된 모드리스트 설치 스크립트를 만들었습니다. 현재 자동화 스크립트가 필요한 단계의 약 90%를 처리합니다.

과정을 배우거나 단순히 손보는 것을 즐기기 위해 수동으로 단계를 진행하고 싶다면, 각 가이드에 포함된 단계를 자유롭게 따라 하세요. 그렇지 않으면, 자동화 스크립트와 사용 지침은 여기에서 확인할 수 있습니다 - [Omni-Guides 자동화 스크립트 사용법](https://github.com/Omni-guides/Wabbajack-Modlist-Linux/wiki/Using-the-omni%E2%80%90guides.sh-Automation-Script).

### 수동 구성
각 가이드에 포함된 단계들은 Linux에서 Wabbajack 모드리스트를 실행하는 데 사용되었으나, Wabbajack 애플리케이션 자체를 실행하는 데는 사용되지 않았습니다. 현재로서는 Linux에서 Wabbajack 자체를 실행할 방법이 **전혀 없습니다** - 지금까지의 노력도 불안정성과 기능 부족으로 이어졌습니다. 이 가이드의 단계를 통해 Skyrim, Fallout 4, Oblivion, Fallout New Vegas 등의 모드리스트 실행에 성공했으며, Steam Deck(SteamOS/Arch), Garuda Linux(Arch), Fedora/Nobara와 같은 플랫폼에서 확인되었습니다. 대부분의 Linux 배포판에서 과정은 거의 동일할 것입니다.

Steam Deck 사용자는 링크된 모드리스트별 가이드를 따라 선택한 모드리스트를 실행하는 단계별 지침을 받을 수 있습니다.

일반 Linux 시스템(즉, Steam Deck이 아닌 경우)에서는 나열된 모드리스트별 가이드(“PC 전용” 섹션 포함)를 따르거나 [일반 Linux](https://github.com/Omni-guides/Wabbajack-Modlist-Linux/wiki/General-Linux-Guide-(Anvil)) 가이드의 단계를 따를 수 있습니다. 이 일반 Linux 가이드는 Anvil을 예시 리스트로 사용하지만, 원하는 모드리스트로 교체해도 대체로 동일한 단계를 따르게 됩니다. 문제가 있을 경우, 선택한 모드리스트 실행에 도움이 될 수 있는 추가 단계가 있는지 모드리스트별 가이드를 확인해 보세요.

마지막으로, 모드리스트 개발자이시고 제게 테스트를 요청하고 싶다면 알려 주세요! 즐거운 게임 되세요!

***


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-25

---