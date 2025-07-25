# Wyvernbox

다목적 인벤토리 시스템을 위한 애드온입니다.

필요한 씬은 `addons/wyvernbox_prefabs` 안에 있습니다. 그냥 드래그 앤 드롭하세요!

`example/wyvernbox` 폴더에는 시작할 수 있는 몇 가지 아이템과 장비 스탯이 포함되어 있습니다. 예제 씬도 꼭 확인하세요!

## 필요한 것들:

- 하나의 `InventoryView` 객체,
- 아이템을 검사할 `InventoryTooltip` (*몇 개의 `TooltipProperty` 스크립트가 첨부되어 있을 수 있음*),
- 마우스로 아이템을 옮기기 위한 `GrabbedItemStackView`,
- 그리고 아이템 유형을 정의할 몇 개의 `ItemType` 리소스.

## 작동 방식:

- `InventoryView`는 일치하는 유형의 `Inventory`와 사용자 상호작용을 제공합니다;
- 인벤토리는 `ItemStack`을 보유합니다;
- `ItemStack`은 `ItemType`에서 생성됩니다.
- `ItemType`은 기본 데이터를 저장하며, 제작 레시피와 아이템 생성기에 사용됩니다.

## 기능:

- 다양한 인벤토리 유형, 모두 GUI 컨테이너와 호환, 예:
  - 기본
  - 그리드 (*아이템이 타일의 사각형을 차지함*)
  - 제한된 (*장비나 탄약 같은 특정 플래그가 있는 아이템만 넣을 수 있음*)
  - 화폐 (*커스텀 최대 스택 크기, 하지만 지정된 아이템만*)

- 제작 및 상점:
  - 자판기는 인벤토리의 내장 기능이지만, 더 많은 설정이 필요하면 `InventoryVendor` 클래스를 사용하세요!
  - 제작 레시피는 `ItemConversion`을 통해 정의됩니다 - 미리 정해진 결과, 무작위 개수, 또는 `ItemGenerator`에서 새로 생성된 아이템을 줄 수 있습니다!
  - `ItemPattern`을 사용해 여러 아이템 중 하나를 필터나 레시피에서 매칭, 예를 들어 효율이 다른 연료 유형들!

- **제스처**: 빠른 이동(Shift-클릭), 해당 유형의 모든 아이템 모으기/이동(더블 클릭), 하나/절반 나누기(우클릭)
- 다용도 `ItemPattern` 클래스로 바닥과 인벤토리 아이템 필터링! 인벤토리 삽입과 제작 입력을 제어하는 데 사용하세요.
- 사용자 정의 인스펙터 테이블로 아이템을 여러분 클래스의 값에 매핑 - ShopManager, ItemGenerator, ItemPattern 객체에서 사용! 아이템 브라우저 팝업 포함, 프로젝트에서 아이템 유형, 생성기, 패턴을 쉽게 드래그 앤 드롭할 수 있습니다.
- `TooltipProperty` 클래스로 확장 가능한 툴팁! 스크립트를 여러 개 붙이기만 하면 됩니다.

#
2022년 Don Tnowe 제작.

[내 웹사이트](https://redbladegames.netlify.app)

[Itch](https://don-tnowe.itch.io)

[트위터](https://twitter.com/don_tnowe)

**도움이 필요하거나 이야기하고 싶나요? 메시지 주세요!** [텔레그램](https://t.me/don_tnowe), [디스코드](https://discord.com/channels/@me/726139164566880426)

**이 도구가 많이 도움이 되었다면 후원도 환영합니다!** [PayPal로 기부하기!](https://redbladegames.netlify.app/tip/index.html)

#

복사 및 수정은 MIT 라이선스에 따라 허용됩니다, 별도 명시가 없는 한. 라이선스 텍스트 포함.

예제의 폰트는 [Abaddon, 크리에이티브 커먼즈 저작자표시 3.0 라이선스 하에 있음](https://caffinate.itch.io/abaddon)입니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-25

---