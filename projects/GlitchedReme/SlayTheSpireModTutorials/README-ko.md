살륙 첨탑 mod 제작 튜토리얼
=====================

《살륙 첨탑2》 모드 제작 튜토리얼 업데이트 중: https://github.com/GlitchedReme/SlayTheSpire2ModdingTutorials

<b>본 튜토리얼은 Java 프로그래밍 지식을 다루지 않으니, 먼저 프로그래밍 기초를 익히고 학습하시길 권장합니다.</b>

<b>독자가 본 튜토리얼을 읽으면서 오류나 부적절한 부분을 발견하면, 이슈를 제출하여 튜토리얼 개선에 도움을 줄 수 있습니다.</b>

<b>궁금한 점이 있으면 아래의 개인 그룹에 참여하거나 위의 discussions에 질문을 남겨주세요.</b>

<b>상단의 Tutorials 폴더 또는 오른쪽의 [튜토리얼 사이트](https://glitchedreme.github.io/SlayTheSpireModTutorials/)를 클릭하여 모든 튜토리얼을 확인하세요.</b>

개인 그룹: 542370192

# 몇 가지 유용한 도구/사이트

## 목차
* [사이트](#사이트)
* [도구](#도구)
* [mod 샘플](mod샘플)
* [애니메이션](#애니메이션)

## 사이트
* [ModTheSpire Wiki](https://github.com/kiooeht/ModTheSpire/wiki)<br>
<b>ModTheSpire</b>(약칭 MTS)은 기본 게임 파일을 수정하지 않고 Slay the Spire에 외부 모드를 로드할 수 있는 도구이며, 모드가 자신의 코드를 게임 코드에 패치할 수 있도록 허용합니다.<br>
MTS Wiki에는 전역 저장, 패치 방법 등이 작성되어 있습니다.


* [BaseMod Wiki](https://github.com/daviscook477/BaseMod/wiki)<br>
<b>BaseMod</b>은 모드의 기본 API로, 모드 제작자가 게임에 자신의 카드 등 콘텐츠를 쉽게 추가하고 이를 집중 관리할 수 있게 해줍니다.<br>
Wiki에는 자동 카드 등록(AutoAdd), 카드 수정기(CardModifier), 한 게임 내 저장(CustomSavable) 등 유용한 소도구들이 소개되어 있습니다. BaseMod 제작자가 작성한 모드 제작 튜토리얼도 포함되어 있습니다.

## 도구
* [JD-GUI](http://java-decompiler.github.io/)<br>
Java 역컴파일 도구로 GUI 인터페이스를 갖추고 있습니다.<br>
게임이나 다른 모드의 리팩토링된 소스 코드를 확인하여 편리하게 ~~복사~~ 학습할 수 있습니다.<br>
패치를 위한 코드 행 수를 조회할 때도 사용할 수 있습니다.(IDEA 내장 역컴파일은 정확하지 않음)

* [sts 이미지 자르기 도구](https://github.com/JohnnyBazooka89/StSModdingToolCardImagesCreator)<br>
이미지를 뾰족탑 카드에 필요한 모양과 크기로 자릅니다.<br>
저는 이 도구를 사용해본 적이 없고, 그룹 내에 같은 기능을 가진 다른 도구를 직접 만든 분이 있습니다.

## mod 샘플
* [전사 휘장 mod](https://github.com/Rita-Bernstein/Warlord-Emblem)<br>
~~Rita 추천, 반드시 명품~~<br>
비교적 표준화된 mod 예제입니다.

## 애니메이션
* [DragonBones](https://dragonbones.github.io/cn/index.html)<br>
spine 애니메이션을 내보낼 수 있는 소프트웨어로, 일반적으로 이것만으로 충분하며 사용 가능한 버전을 직접 찾아도 됩니다.

*애니메이션 제작에는 약간의 기초가 필요하지만, 사실 대부분의 mod는 한 장의 그림만으로도 충분합니다.*
* [Spine](http://zh.esotericsoftware.com/)<br>
뾰족탑에서 사용하는 2D 애니메이션 소프트웨어입니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-19

---