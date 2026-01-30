[![Releases](https://img.shields.io/github/release/GieziJo/ScriptableObjectVariant.svg)](https://github.com/GieziJo/ScriptableObjectVariant/releases/latest)
[![openupm](https://img.shields.io/npm/v/ch.giezi.tools.scriptableobjectvariant?label=openupm&registry_uri=https://package.openupm.com)](https://openupm.com/packages/ch.giezi.tools.scriptableobjectvariant/)
[![License: MIT](https://img.shields.io/badge/License-MIT-brightgreen.svg)](https://github.com/GieziJo/ScriptableObjectVariant/blob/master/LICENSE.txt)

# Unity용 스크립터블 오브젝트 변형 (스크립터블 오브젝트 데이터 오버라이더)

> [!CAUTION]
> `2.0.0` 이전 버전에서 업그레이드하는 경우, [업그레이드 섹션](#upgrading-to-200-from-previous-versions)을 반드시 읽어주세요.

## 목차
- [설명](#description)
- [사용법](#usage)
- [구현](#implementation)
- [설치](#installation)
- [이전 버전에서 2.0.0으로 업그레이드하기](#upgrading-to-200-from-previous-versions)
- [알려진 문제 및 수정 사항](#known-issues-and-tweaks-to-be-made)

## 설명
`[SOVariant]` 속성이 태그된 모든 스크립터블 오브젝트에 원본 SO(부모)를 선택하고 자식 오브젝트에서 선택된 필드를 오버라이드할 수 있는 필드를 추가합니다.

원본 값이 변경되면, 값이 자동으로 자식에게 전파됩니다.

<img src="https://raw.githubusercontent.com/GieziJo/ScriptableObjectVariant/assets/ScriptableObjectOverrideDemo.gif" width="100%">

## 사용법
오버라이드 가능하거나 변형본을 만들 수 있도록 하고 싶은 모든 ScriptableObject 클래스의 클래스 헤더 앞에 `[SOVariant]` 태그를 추가하세요.

예시:
```csharp
using Giezi.Tools;

[SOVariant]
[CreateAssetMenu(fileName = "TestScriptable", menuName = "Create new TestScriptable")]
public class TestScriptable : ScriptableObject
{
    [SerializeField] private float myFloat = 3L;
    [SerializeField] private GameObject myGameObject;
    [SerializeField] private int myInt;
    [SerializeField] private TestScriptable myTestScriptable;
}
```
### 컨텍스트 메뉴에서 스크립터블 오브젝트 변형 생성

![Context Menu](https://raw.githubusercontent.com/GieziJo/ScriptableObjectVariant/assets/ContextMenuExample.png)

Unity에서는 `SOVariant`로 태그된 스크립터블 오브젝트를 우클릭하여 이 오브젝트의 변형을 생성할 수 있습니다(`Create > Create SO Variant`).
새 오브젝트는 선택된 오브젝트를 부모로 가집니다.

### 에디터 스크립트에서 고급 사용법
부모 변경, 상태 및 값을 다른 에디터 스크립트 내에서 재정의할 수 있는 도우미 스크립트(`SOVariantHelper.cs`)가 구현되어 있습니다.

새 부모 설정:

```csharp
ScriptableObject target = AssetDatabase.LoadAssetAtPath<ScriptableObject>("Assets/Tests/child.asset");
ScriptableObject parent = AssetDatabase.LoadAssetAtPath<ScriptableObject>("Assets/Tests/parent.asset");
        
SOVariantHelper<ScriptableObject>.SetParent(target, parent);
```

필드를 재정의 가능하도록 설정:
```csharp
ScriptableObject target = AssetDatabase.LoadAssetAtPath<ScriptableObject>("Assets/Tests/child.asset");
        
SOVariantHelper<ScriptableObject>.ChangeFieldOverrideState(target, "MyFloat", true);
```
필드의 새 값을 설정합니다(자동으로 자식에게 전파됨):

```csharp
ScriptableObject target = AssetDatabase.LoadAssetAtPath<ScriptableObject>("Assets/Tests/child.asset");
        
SOVariantHelper<ScriptableObject>.ChangeFieldValue(target, "MyFloat", 45f);
```

재정의할 필드를 설정하고 새 값 설정(자동으로 자식에게 전파):
```csharp
ScriptableObject target = AssetDatabase.LoadAssetAtPath<ScriptableObject>("Assets/Tests/child.asset");
        
SOVariantHelper<ScriptableObject>.SetFieldOverrideAndSetValue(target, "MyFloat", 45f);
```

부모를 설정하고 새로 재정의된 값 설정 (자동으로 자식에게 전파):
```csharp
ScriptableObject target = AssetDatabase.LoadAssetAtPath<ScriptableObject>("Assets/Tests/child.asset");
ScriptableObject parent = AssetDatabase.LoadAssetAtPath<ScriptableObject>("Assets/Tests/parent.asset");
    
SOVariantHelper<ScriptableObject>.SetParentOverrideValue(target, parent, "MyFloat", 45f);
```
부모를 설정하고 새로 재정의된 값을 설정합니다(자동으로 자식에게 전파됨):

```csharp
ScriptableObject target = AssetDatabase.LoadAssetAtPath<ScriptableObject>("Assets/Tests/child.asset");
ScriptableObject parent = AssetDatabase.LoadAssetAtPath<ScriptableObject>("Assets/Tests/parent.asset");
    
SOVariantHelper<ScriptableObject>.SetParentOverrideValues(target, parent, new Dictionary<string, object>(){{"MyFloat", 45f},{"MyInt", 12}});
```

## 구현
시각적 인터페이스는 [Odin](odininspector.com/)'의 [`OdinPropertyProcessor`](https://odininspector.com/tutorials/using-property-resolvers-and-attribute-processors/custom-property-processors)에서 구현되었습니다.

상위 및 재정의된 필드가 포함된 데이터는 `Assets/Plugins/SOVariant/Editor/SOVariantDataLibrary.asset`에 위치한 라이브러리 객체에 저장됩니다.

<p style="color: grey";>2.0.0 이전:
<strike>상위 및 재정의된 필드가 포함된 데이터는 에셋 메타데이터 내에 직렬화되어 저장되며, Unity에서는 `AssetImporter.GetAtPath(AssetDatabase.GetAssetPath(targetObject)).userData`로 설정되었습니다.</strike></p>

## 설치
> [!WARNING]
> 패키지를 추가하기 전에 [Odin](odininspector.com/) 버전 `3.2.1.0`이 설치되어 있어야 합니다.

> [!WARNING]
> 이 패키지는 Unity 버전 2022.3.16f1 LTS용으로 유지 관리됩니다.

### Unity 패키지 매니저 사용하기
다음 줄을 추가하십시오

```
"ch.giezi.tools.scriptableobjectvariant": "https://github.com/GieziJo/ScriptableObjectVariant.git#master"
```
`Packages/manifest.json` 파일의 `dependencies` 아래에 추가하거나, `Package Manager`에서 [`https://github.com/GieziJo/ScriptableObjectVariant.git#master`](https://github.com/GieziJo/ScriptableObjectVariant.git#master) 링크를 `+ -> "Add package from git URL..."`에 추가하세요.

### OpenUPM 사용하기
이 패키지는 [OpenUPM](https://openupm.com/packages/ch.giezi.tools.scriptableobjectvariant/)에서 사용할 수 있습니다.
OpenUPM 패키지는 여러 방법으로 설치할 수 있습니다:
- [OpenUPM CLI](https://github.com/openupm/openupm-cli)를 통해: `openupm add ch.giezi.tools.scriptableobjectvariant`
- [`.unitypackage`](https://package-installer.glitch.me/v1/installer/OpenUPM/ch.giezi.tools.scriptableobjectvariant?registry=https%3A%2F%2Fpackage.openupm.com)를 다운로드하여 `Assets > Import Package > Custom Package...`로 프로젝트에 추가

패키지는 스코프 레지스트리로 추가되며, `Project Settings > Package Manager > OpenUPM`에서 확인할 수 있습니다.

### 대안
프로젝트 내에 모든 파일을 다운로드하여 복사하세요.

## 이전 버전에서 2.0.0으로 업그레이드

패키지의 `2.0.0` 버전에서는 데이터가 각 객체의 메타데이터 내에서 Scriptable Object 라이브러리로 이동했습니다.
Unity의 임포터가 너무 불안정하여, 메타데이터에 데이터를 읽고 쓰는 것이 너무 복잡하고 오류 및 실패가 자주 발생했습니다.

`2.0.0` 이전 버전을 사용 중이었다면, 새 버전으로 마이그레이션하는 도구가 작성되었습니다.
`Tools/GieziTools/SOVariant/Upgrade user data to new version`을 실행하세요.
이 도구는 메타데이터에 포함된 모든 데이터를 읽어 라이브러리를 구축합니다.
필요하다면 `Tools/GieziTools/SOVariant/Fix SOVs`를 실행할 수 있습니다.
이 도구는 각 객체를 순회하며 부모/자식 관계를 재구성하고 부모 값을 자식에게 전파합니다.
이전 도구 버전이 상당히 불안정했기 때문에 이 단계는 매우 권장됩니다.
추가로 각 객체가 올바른 값을 가지고 있는지 데이터를 확인해야 합니다.

이 새 버전은 Unity 최신 버전과 패키지 불안정 문제로 발생한 많은 문제를 해결해야 합니다.

## 알려진 문제 및 조정 사항
<details>
<summary>알려진 문제 목록</summary>


### [효율성](https://github.com/GieziJo/ScriptableObjectVariant/issues/2)
속성 `[SOVariant]`는 태그 역할만 하며, `SOVariantAttributeProcessor:OdinPropertyProcessor -> ProcessMemberProperties`에서 검색됩니다. 첫 번째 줄은 다음과 같습니다:
```csharp
if(!Property.Attributes.Select(attribute => attribute.GetType()).Contains(typeof(SOVariantAttribute)))
    return;
```
이 문제는 `SOVariantAttributeProcessor`가 모든 `ScriptableObject`에 대해 호출되도록 설정된다는 점입니다:
```csharp
public class SOVariantAttributeProcessor<T> : OdinPropertyProcessor<T> where T : ScriptableObject
```
아마도 속성에서 `SOVariantAttributeProcessor`를 직접 호출하는 방법이 있을 텐데, 아직 찾지 못했습니다.

### [부모 객체 선택하기](https://github.com/GieziJo/ScriptableObjectVariant/issues/3)
선택된 부모는 오버라이드된 항목과 정확히 같은 클래스여야 합니다(그렇지 않으면 필드가 누락될 수 있음) 그리고 자식 자신이어서는 안 됩니다.
이 검사는 현재 부모를 설정할 때 다음과 같이 수행됩니다:
 ```csharp
if (parent.GetType() != target.GetType())
{
    Debug.Log("Only equal types can be selected as parent");
    return;
}

if (AssetDatabase.GetAssetPath(parent) == AssetDatabase.GetAssetPath(target))
{
    Debug.Log("You can't select the same object as parent");
    return;
}
 ```
객체를 선택할 때 가능한 후보를 직접 필터링하는 것이 훨씬 좋겠지만, 필터가 있는 `AssetSelector` 속성을 추가하거나 사용자 정의 `ValueDropdown`을 만드는 것은 모두 작동하지 않았으며, 이유를 잘 모르겠습니다.

</details>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-30

---