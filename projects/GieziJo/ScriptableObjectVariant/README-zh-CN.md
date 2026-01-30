[![Releases](https://img.shields.io/github/release/GieziJo/ScriptableObjectVariant.svg)](https://github.com/GieziJo/ScriptableObjectVariant/releases/latest)
[![openupm](https://img.shields.io/npm/v/ch.giezi.tools.scriptableobjectvariant?label=openupm&registry_uri=https://package.openupm.com)](https://openupm.com/packages/ch.giezi.tools.scriptableobjectvariant/)
[![License: MIT](https://img.shields.io/badge/License-MIT-brightgreen.svg)](https://github.com/GieziJo/ScriptableObjectVariant/blob/master/LICENSE.txt)

# Unity的可脚本化对象变体（Scriptable Object数据覆盖器）

> [!CAUTION]
> 如果您正在从`2.0.0`之前的版本升级，请阅读[升级部分](#upgrading-to-200-from-previous-versions)

## 目录
- [描述](#description)
- [使用方法](#usage)
- [实现](#implementation)
- [安装](#installation)
- [从之前版本升级到2.0.0](#upgrading-to-200-from-previous-versions)
- [已知问题及需调整项](#known-issues-and-tweaks-to-be-made)

## 描述
为任何带有`[SOVariant]`属性标记的可脚本化对象添加一个字段，允许您选择一个原始SO（父对象）并在子对象中覆盖选定的字段。

当原始对象的值发生更改时，值会自动传播到子对象。

<img src="https://raw.githubusercontent.com/GieziJo/ScriptableObjectVariant/assets/ScriptableObjectOverrideDemo.gif" width="100%">

## 使用方法
在任何您希望能够创建变体的ScriptableObject类的类头前添加标签`[SOVariant]`，使其可被覆盖。

示例：
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

### 从上下文菜单创建脚本化对象变体

![Context Menu](https://raw.githubusercontent.com/GieziJo/ScriptableObjectVariant/assets/ContextMenuExample.png)

在 Unity 中，你可以右键点击任何标记为 `SOVariant` 的脚本化对象来创建该对象的变体（`Create > Create SO Variant`）。
新对象将以所选对象作为父对象。

### 编辑器脚本中的高级用法
已经实现了一个辅助脚本（`SOVariantHelper.cs`），允许你在其他编辑器脚本中更改父对象、覆盖状态和值。

设置新的父对象：
```csharp
ScriptableObject target = AssetDatabase.LoadAssetAtPath<ScriptableObject>("Assets/Tests/child.asset");
ScriptableObject parent = AssetDatabase.LoadAssetAtPath<ScriptableObject>("Assets/Tests/parent.asset");
        
SOVariantHelper<ScriptableObject>.SetParent(target, parent);
```
设置字段可覆盖：

```csharp
ScriptableObject target = AssetDatabase.LoadAssetAtPath<ScriptableObject>("Assets/Tests/child.asset");
        
SOVariantHelper<ScriptableObject>.ChangeFieldOverrideState(target, "MyFloat", true);
```
设置字段的新值（自动传播到子项）：

```csharp
ScriptableObject target = AssetDatabase.LoadAssetAtPath<ScriptableObject>("Assets/Tests/child.asset");
        
SOVariantHelper<ScriptableObject>.ChangeFieldValue(target, "MyFloat", 45f);
```
设置一个字段以被覆盖并设置新值（自动传播到子项）：

```csharp
ScriptableObject target = AssetDatabase.LoadAssetAtPath<ScriptableObject>("Assets/Tests/child.asset");
        
SOVariantHelper<ScriptableObject>.SetFieldOverrideAndSetValue(target, "MyFloat", 45f);
```
设置父级并设置新的覆盖值（自动传播到子级）：

```csharp
ScriptableObject target = AssetDatabase.LoadAssetAtPath<ScriptableObject>("Assets/Tests/child.asset");
ScriptableObject parent = AssetDatabase.LoadAssetAtPath<ScriptableObject>("Assets/Tests/parent.asset");
    
SOVariantHelper<ScriptableObject>.SetParentOverrideValue(target, parent, "MyFloat", 45f);
```
设置父级并设置新的覆盖值（自动传播到子级）：

```csharp
ScriptableObject target = AssetDatabase.LoadAssetAtPath<ScriptableObject>("Assets/Tests/child.asset");
ScriptableObject parent = AssetDatabase.LoadAssetAtPath<ScriptableObject>("Assets/Tests/parent.asset");
    
SOVariantHelper<ScriptableObject>.SetParentOverrideValues(target, parent, new Dictionary<string, object>(){{"MyFloat", 45f},{"MyInt", 12}});
```
## 实现
可视化界面在 [Odin](odininspector.com/) 的 [`OdinPropertyProcessor`](https://odininspector.com/tutorials/using-property-resolvers-and-attribute-processors/custom-property-processors) 中实现。

带有父类和被重写字段的数据保存在位于 `Assets/Plugins/SOVariant/Editor/SOVariantDataLibrary.asset` 的库对象中。

<p style="color: grey";>2.0.0 之前：
<strike>带有父类和被重写字段的数据序列化保存在资源的元数据中，通过 Unity 的 `AssetImporter.GetAtPath(AssetDatabase.GetAssetPath(targetObject)).userData` 设置。</strike></p>

## 安装
> [!WARNING]
> 需要先安装版本为 `3.2.1.0` 的 [Odin](odininspector.com/) ，然后才能添加此包。

> [!WARNING]
> 该包维护针对 Unity 版本 2022.3.16f1 LTS。

### 使用 Unity 的包管理器
添加以下行


```
"ch.giezi.tools.scriptableobjectvariant": "https://github.com/GieziJo/ScriptableObjectVariant.git#master"
```
在文件 `Packages/manifest.json` 的 `dependencies` 下，或者在 `Package Manager` 中通过 `+ -> "Add package from git URL..."` 添加链接 [`https://github.com/GieziJo/ScriptableObjectVariant.git#master`](https://github.com/GieziJo/ScriptableObjectVariant.git#master)。

### 使用 OpenUPM
该包可在 [OpenUPM](https://openupm.com/packages/ch.giezi.tools.scriptableobjectvariant/) 获取。
OpenUPM 包可以通过多种方式安装：
- 通过 [OpenUPM CLI](https://github.com/openupm/openupm-cli)：`openupm add ch.giezi.tools.scriptableobjectvariant`
- 通过下载 [`.unitypackage`](https://package-installer.glitch.me/v1/installer/OpenUPM/ch.giezi.tools.scriptableobjectvariant?registry=https%3A%2F%2Fpackage.openupm.com)，并通过 `Assets > Import Package > Custom Package...` 添加到项目中。

该包会作为一个作用域注册表添加，您可以在 `Project Settings > Package Manager > OpenUPM` 下查看。

### 备选方案
下载并复制所有文件到您的项目中。

## 从旧版本升级到 2.0.0

在包的 `2.0.0` 版本中，数据从每个对象的元数据中移出，改用 Scriptable Object 库。
由于 Unity 的导入器过于不稳定，读写元数据中的数据变得过于复杂，且经常导致错误和失败。

如果您使用的是 `2.0.0` 之前的版本，已经编写了一个工具用于迁移到新版本。
运行 `Tools/GieziTools/SOVariant/Upgrade user data to new version`。
此操作会读取所有元数据中的数据并构建库。
如有必要，您可以运行 `Tools/GieziTools/SOVariant/Fix SOVs`。
此操作会遍历每个对象并重建父子关系，同时将父对象的值传递给子对象。
由于前一版本工具相当不稳定，强烈建议执行此步骤。
此外，您应检查数据以确保每个对象具有正确的值。

此新版本应修复许多在较新 Unity 版本中以及包本身不稳定时出现的问题。

## 已知问题及待调整项
<details>
<summary>已知问题列表</summary>


### [效率](https://github.com/GieziJo/ScriptableObjectVariant/issues/2)
特性 `[SOVariant]` 仅作为标记存在，随后在 `SOVariantAttributeProcessor:OdinPropertyProcessor -> ProcessMemberProperties` 中被查找，首行代码为：
```csharp
if(!Property.Attributes.Select(attribute => attribute.GetType()).Contains(typeof(SOVariantAttribute)))
    return;
```
问题在于，`SOVariantAttributeProcessor` 因此被设置为对每个 `ScriptableObject` 调用：
```csharp
public class SOVariantAttributeProcessor<T> : OdinPropertyProcessor<T> where T : ScriptableObject
```
可能有一种方法可以直接从属性调用 `SOVariantAttributeProcessor`，但我还没有找到方法。

### [选择父对象](https://github.com/GieziJo/ScriptableObjectVariant/issues/3)
所选的父对象应与被覆盖的项完全相同的类（否则字段可能会缺失），且不应是子对象本身。
该检查当前在设置父对象时执行，如下所示：
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
在对象中选择时直接过滤可能的候选项会好得多，但添加带有过滤器的 `AssetSelector` 属性或构建自定义的 `ValueDropdown` 都不起作用，不确定原因。

</details>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-30

---