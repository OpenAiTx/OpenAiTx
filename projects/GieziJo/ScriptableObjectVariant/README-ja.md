[![Releases](https://img.shields.io/github/release/GieziJo/ScriptableObjectVariant.svg)](https://github.com/GieziJo/ScriptableObjectVariant/releases/latest)
[![openupm](https://img.shields.io/npm/v/ch.giezi.tools.scriptableobjectvariant?label=openupm&registry_uri=https://package.openupm.com)](https://openupm.com/packages/ch.giezi.tools.scriptableobjectvariant/)
[![License: MIT](https://img.shields.io/badge/License-MIT-brightgreen.svg)](https://github.com/GieziJo/ScriptableObjectVariant/blob/master/LICENSE.txt)

# Unity用Scriptable Object Variant（Scriptable Objectデータオーバーライダー）

> [!CAUTION]
> もし`2.0.0`未満のバージョンからアップグレードする場合は、[アップグレードセクション](#upgrading-to-200-from-previous-versions)をお読みください

## 目次
- [説明](#description)
- [使い方](#usage)
- [実装](#implementation)
- [インストール](#installation)
- [以前のバージョンから2.0.0へのアップグレード](#upgrading-to-200-from-previous-versions)
- [既知の問題と調整点](#known-issues-and-tweaks-to-be-made)

## 説明
`[SOVariant]`属性が付いた任意のScriptableObjectにフィールドを追加し、元のSO（親）を選択し、子オブジェクトの特定フィールドをオーバーライドできるようにします。

元の値を変更すると、その値が自動的に子に伝播されます。

<img src="https://raw.githubusercontent.com/GieziJo/ScriptableObjectVariant/assets/ScriptableObjectOverrideDemo.gif" width="100%">

## 使い方
オーバーライド可能にしたい任意のScriptableObjectクラスのクラスヘッダーの前に`[SOVariant]`タグを追加します。つまり、バリアントを作成できるようにします。

例：
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
### コンテキストメニューからスクリプタブルオブジェクトのバリアントを作成

![Context Menu](https://raw.githubusercontent.com/GieziJo/ScriptableObjectVariant/assets/ContextMenuExample.png)

Unityでは、`SOVariant`タグが付いた任意のスクリプタブルオブジェクトを右クリックして、このオブジェクトのバリアントを作成できます（`Create > Create SO Variant`）。
新しいオブジェクトは選択したオブジェクトを親として持ちます。

### エディタースクリプトでの高度な使用法
ヘルパースクリプト（`SOVariantHelper.cs`）が実装されており、他のエディタースクリプト内から親の変更、状態や値のオーバーライドが可能です。

新しい親を設定する:

```csharp
ScriptableObject target = AssetDatabase.LoadAssetAtPath<ScriptableObject>("Assets/Tests/child.asset");
ScriptableObject parent = AssetDatabase.LoadAssetAtPath<ScriptableObject>("Assets/Tests/parent.asset");
        
SOVariantHelper<ScriptableObject>.SetParent(target, parent);
```
フィールドをオーバーライド可能に設定：

```csharp
ScriptableObject target = AssetDatabase.LoadAssetAtPath<ScriptableObject>("Assets/Tests/child.asset");
        
SOVariantHelper<ScriptableObject>.ChangeFieldOverrideState(target, "MyFloat", true);
```
フィールドの新しい値を設定する（自動的に子に伝播）:

```csharp
ScriptableObject target = AssetDatabase.LoadAssetAtPath<ScriptableObject>("Assets/Tests/child.asset");
        
SOVariantHelper<ScriptableObject>.ChangeFieldValue(target, "MyFloat", 45f);
```
フィールドをオーバーライド可能に設定し、新しい値を設定する（自動的に子に伝播します）：

```csharp
ScriptableObject target = AssetDatabase.LoadAssetAtPath<ScriptableObject>("Assets/Tests/child.asset");
        
SOVariantHelper<ScriptableObject>.SetFieldOverrideAndSetValue(target, "MyFloat", 45f);
```
親を設定し、新しいオーバーライド値を設定します（自動的に子に伝播します）：

```csharp
ScriptableObject target = AssetDatabase.LoadAssetAtPath<ScriptableObject>("Assets/Tests/child.asset");
ScriptableObject parent = AssetDatabase.LoadAssetAtPath<ScriptableObject>("Assets/Tests/parent.asset");
    
SOVariantHelper<ScriptableObject>.SetParentOverrideValue(target, parent, "MyFloat", 45f);
```
親を設定し、新しいオーバーライド値を設定します（子に自動的に伝播します）：

```csharp
ScriptableObject target = AssetDatabase.LoadAssetAtPath<ScriptableObject>("Assets/Tests/child.asset");
ScriptableObject parent = AssetDatabase.LoadAssetAtPath<ScriptableObject>("Assets/Tests/parent.asset");
    
SOVariantHelper<ScriptableObject>.SetParentOverrideValues(target, parent, new Dictionary<string, object>(){{"MyFloat", 45f},{"MyInt", 12}});
```

## 実装
ビジュアルインターフェースは [Odin](odininspector.com/) の [`OdinPropertyProcessor`](https://odininspector.com/tutorials/using-property-resolvers-and-attribute-processors/custom-property-processors) で実装されています。

親とオーバーライドされたフィールドを持つデータは、`Assets/Plugins/SOVariant/Editor/SOVariantDataLibrary.asset` にあるライブラリオブジェクトに保持されます。

<p style="color: grey";>バージョン2.0.0以前:
<strike>親とオーバーライドされたフィールドを持つデータは、アセットのメタデータ内にシリアライズされて保持されており、Unityでは `AssetImporter.GetAtPath(AssetDatabase.GetAssetPath(targetObject)).userData` で設定されていました。</strike></p>

## インストール
> [!WARNING]
> パッケージを追加する前に [Odin](odininspector.com/) バージョン `3.2.1.0` のインストールが必要です。

> [!WARNING]
> このパッケージは Unity バージョン 2022.3.16f1 LTS 向けにメンテナンスされています。

### Unityのパッケージマネージャーを使用する場合
以下の行を追加してください

```
"ch.giezi.tools.scriptableobjectvariant": "https://github.com/GieziJo/ScriptableObjectVariant.git#master"
```
`Packages/manifest.json` の `dependencies` に、または `Package Manager` の `+ -> "Add package from git URL..."` に [`https://github.com/GieziJo/ScriptableObjectVariant.git#master`](https://github.com/GieziJo/ScriptableObjectVariant.git#master) のリンクを追加してください。

### OpenUPM の使用
このパッケージは [OpenUPM](https://openupm.com/packages/ch.giezi.tools.scriptableobjectvariant/) で利用可能です。  
OpenUPM パッケージは以下の方法でインストールできます：  
- [OpenUPM CLI](https://github.com/openupm/openupm-cli) を使って：`openupm add ch.giezi.tools.scriptableobjectvariant`  
- [`.unitypackage`](https://package-installer.glitch.me/v1/installer/OpenUPM/ch.giezi.tools.scriptableobjectvariant?registry=https%3A%2F%2Fpackage.openupm.com) をダウンロードし、`Assets > Import Package > Custom Package...` でプロジェクトに追加する。  

このパッケージはスコープ付きレジストリとして追加され、`Project Settings > Package Manager > OpenUPM` で確認できます。

### 代替手段
パッケージ内のすべてのファイルをダウンロードしてプロジェクトにコピーしてください。

## 以前のバージョンから 2.0.0 へのアップグレード

パッケージのバージョン `2.0.0` では、データが各オブジェクトのメタデータ内から Scriptable Object ライブラリを使用する形に移行しました。  
Unity のインポーターが不安定すぎたため、メタデータへの読み書きが複雑になり、エラーや失敗が頻発していました。

もし `2.0.0` より前のバージョンを使用していた場合、新しいバージョンに移行するためのツールが用意されています。  
`Tools/GieziTools/SOVariant/Upgrade user data to new version` を実行してください。  
これにより、メタデータに含まれるすべてのデータを読み取り、ライブラリを構築します。  
必要に応じて、`Tools/GieziTools/SOVariant/Fix SOVs` を実行できます。  
これはすべてのオブジェクトをループし、親子関係を再構築し、親の値を子に伝播します。  
前のバージョンのツールは非常に不安定だったため、このステップは強く推奨されます。  
さらに、各オブジェクトに正しい値が設定されているかデータを確認してください。

この新しいバージョンは、Unity の新しいバージョンやパッケージの不安定さによって発生した多くの問題を修正しています。

## 既知の問題および調整点
<details>
<summary>既知の問題一覧</summary>

### [効率](https://github.com/GieziJo/ScriptableObjectVariant/issues/2)
属性 `[SOVariant]` は単なるタグ付けとして機能し、これは `SOVariantAttributeProcessor:OdinPropertyProcessor -> ProcessMemberProperties` 内で検索されます。最初の行は以下の通りです：

```csharp
if(!Property.Attributes.Select(attribute => attribute.GetType()).Contains(typeof(SOVariantAttribute)))
    return;
```
これの問題は、`SOVariantAttributeProcessor` がすべての `ScriptableObject` に対して呼び出されるように設定されていることです:
```csharp
public class SOVariantAttributeProcessor<T> : OdinPropertyProcessor<T> where T : ScriptableObject
```
おそらく属性から直接 `SOVariantAttributeProcessor` を呼び出す方法があるはずですが、私はその方法を見つけていません。

### [親オブジェクトの選択](https://github.com/GieziJo/ScriptableObjectVariant/issues/3)
選択された親は、オーバーライドされたアイテムとまったく同じクラスである必要があります（そうでないとフィールドが不足する可能性があります）かつ子自身であってはなりません。
このチェックは現在、親を設定するときに次のように行われています：
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
オブジェクト内で選択する際に、直接候補をフィルタリングする方がはるかに良いのですが、`AssetSelector`属性にフィルターを追加したり、カスタムの`ValueDropdown`を作成したりしても動作しませんでした。理由は不明です。

</details>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-30

---