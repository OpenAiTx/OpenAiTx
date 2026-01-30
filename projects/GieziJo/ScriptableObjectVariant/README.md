[![Releases](https://img.shields.io/github/release/GieziJo/ScriptableObjectVariant.svg)](https://github.com/GieziJo/ScriptableObjectVariant/releases/latest)
[![openupm](https://img.shields.io/npm/v/ch.giezi.tools.scriptableobjectvariant?label=openupm&registry_uri=https://package.openupm.com)](https://openupm.com/packages/ch.giezi.tools.scriptableobjectvariant/)
[![License: MIT](https://img.shields.io/badge/License-MIT-brightgreen.svg)](https://github.com/GieziJo/ScriptableObjectVariant/blob/master/LICENSE.txt)

# Scriptable Object Variant for Unity (Scriptable Object Data Overrider)

> [!CAUTION]
> If you are upgrading from a pre-`2.0.0` version, please read the [upgrade section](#upgrading-to-200-from-previous-versions)

## Table of contents
- [Description](#description)
- [Usage](#usage)
- [Implementation](#implementation)
- [Installation](#installation)
- [Upgrading to 2.0.0 from previous versions](#upgrading-to-200-from-previous-versions)
- [Known issues and tweaks to be made](#known-issues-and-tweaks-to-be-made)

## Description
Adds a field to any scriptable object tagged with the `[SOVariant]` attribute that lets you select an original SO (parent) and override selected fields in the child object.

When changing values in the original, values are automagically propagated to the children.

<img src="https://raw.githubusercontent.com/GieziJo/ScriptableObjectVariant/assets/ScriptableObjectOverrideDemo.gif" width="100%">

## Usage
Add the tag `[SOVariant]` before the class header of any ScriptableObject class you want to be overridable, i.e. to be able to create a variant of.

Example:
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

### Create Scriptable Object Variant from context menu

![Context Menu](https://raw.githubusercontent.com/GieziJo/ScriptableObjectVariant/assets/ContextMenuExample.png)

In Unity, you can right click any scriptable object tagged `SOVariant` to create a variant of this object (`Create > Create SO Variant`).
The new object will have the selected object as parent.

### Advanced usage in Editor Script
A helper script has been implemented (`SOVariantHelper.cs`) which allows you to changed parents, override states and values from within other editor scripts.

Set a new parent:
```csharp
ScriptableObject target = AssetDatabase.LoadAssetAtPath<ScriptableObject>("Assets/Tests/child.asset");
ScriptableObject parent = AssetDatabase.LoadAssetAtPath<ScriptableObject>("Assets/Tests/parent.asset");
        
SOVariantHelper<ScriptableObject>.SetParent(target, parent);
```

Set a field overridable:
```csharp
ScriptableObject target = AssetDatabase.LoadAssetAtPath<ScriptableObject>("Assets/Tests/child.asset");
        
SOVariantHelper<ScriptableObject>.ChangeFieldOverrideState(target, "MyFloat", true);
```

Set a new value of a field (automatically propagates to children):
```csharp
ScriptableObject target = AssetDatabase.LoadAssetAtPath<ScriptableObject>("Assets/Tests/child.asset");
        
SOVariantHelper<ScriptableObject>.ChangeFieldValue(target, "MyFloat", 45f);
```

Set a filed to be overridden and set new value (automatically propagates to children):
```csharp
ScriptableObject target = AssetDatabase.LoadAssetAtPath<ScriptableObject>("Assets/Tests/child.asset");
        
SOVariantHelper<ScriptableObject>.SetFieldOverrideAndSetValue(target, "MyFloat", 45f);
```

Set a parent and set new overridden value (automatically propagates to children):
```csharp
ScriptableObject target = AssetDatabase.LoadAssetAtPath<ScriptableObject>("Assets/Tests/child.asset");
ScriptableObject parent = AssetDatabase.LoadAssetAtPath<ScriptableObject>("Assets/Tests/parent.asset");
    
SOVariantHelper<ScriptableObject>.SetParentOverrideValue(target, parent, "MyFloat", 45f);
```

Set a parent and set new overridden values (automatically propagates to children):
```csharp
ScriptableObject target = AssetDatabase.LoadAssetAtPath<ScriptableObject>("Assets/Tests/child.asset");
ScriptableObject parent = AssetDatabase.LoadAssetAtPath<ScriptableObject>("Assets/Tests/parent.asset");
    
SOVariantHelper<ScriptableObject>.SetParentOverrideValues(target, parent, new Dictionary<string, object>(){{"MyFloat", 45f},{"MyInt", 12}});
```


## Implementation
The visual interface is implemented in [Odin](odininspector.com/)'s [`OdinPropertyProcessor`](https://odininspector.com/tutorials/using-property-resolvers-and-attribute-processors/custom-property-processors).

The data with the parent and the overriden fields is kept in a library object located at `Assets/Plugins/SOVariant/Editor/SOVariantDataLibrary.asset`

<p style="color: grey";>Before 2.0.0:
<strike>The data with the parent and the overriden fields is kept serialized inside the asset's metadata, set in unity with `AssetImporter.GetAtPath(AssetDatabase.GetAssetPath(targetObject)).userData`.</strike></p>

## Installation
> [!WARNING]
> Requires [Odin](odininspector.com/) version `3.2.1.0` to be installed before adding the package.

> [!WARNING]
> This package is maintained for Unity version 2022.3.16f1 LTS.

### Using Unity's package manager
Add the line
```
"ch.giezi.tools.scriptableobjectvariant": "https://github.com/GieziJo/ScriptableObjectVariant.git#master"
```
to the file `Packages/manifest.json` under `dependencies`, or in the `Package Manager` add the link [`https://github.com/GieziJo/ScriptableObjectVariant.git#master`](https://github.com/GieziJo/ScriptableObjectVariant.git#master) under `+ -> "Add package from git URL...`.

### Using OpenUPM
The package is available on [OpenUPM](https://openupm.com/packages/ch.giezi.tools.scriptableobjectvariant/).
OpenUPM packages can be installed in different ways:
- via [OpenUPM CLI](https://github.com/openupm/openupm-cli): `openupm add ch.giezi.tools.scriptableobjectvariant`
- by downloading the [`.unitypackage`](https://package-installer.glitch.me/v1/installer/OpenUPM/ch.giezi.tools.scriptableobjectvariant?registry=https%3A%2F%2Fpackage.openupm.com) and adding it to your project with `Assets > Import Package > Custom Package...`.

the package will be added as a scoped registry, which you can inspect under `Project Settings > Package Manager > OpenUPM`.

### Alternative
Download and copy all files inside your project.

## Upgrading to 2.0.0 from previous versions

In version `2.0.0` of the package, the data moved from within each object's metadata to using a Scriptable Object library.
Unity's importer being too unstable, reading and writing the data to the metadata became too complicated and often led to errors and failures.

If you were using the package pre-`2.0.0`, a tool has been written to migrate to the new version.
Run `Tools/GieziTools/SOVariant/Upgrade user data to new version`.
This will read all data contained in the metadata and build the library.
If necessary, you can run `Tools/GieziTools/SOVariant/Fix SOVs`.
This will loop through each object and rebuild the parent/child relationship, as well as propagate the parent values to the children.
Because the previous version of the tool was quite unstable, this step is highly encouraged
Additionally, you should check the data to make sure each object has the right values.

This new version should fix a lot of the issues that appeared with newer versions of Unity and with the package being unstable.

## Known issues and tweaks to be made
<details>
<summary>List of known issues</summary>


### [Efficiency](https://github.com/GieziJo/ScriptableObjectVariant/issues/2)
The attribute `[SOVariant]` only acts as tagger, which is then looked for in `SOVariantAttributeProcessor:OdinPropertyProcessor -> ProcessMemberProperties`, where the first line reads:
```csharp
if(!Property.Attributes.Select(attribute => attribute.GetType()).Contains(typeof(SOVariantAttribute)))
    return;
```
The problem with this is that `SOVariantAttributeProcessor` is thus set to be called for every `ScriptableObject`:
```csharp
public class SOVariantAttributeProcessor<T> : OdinPropertyProcessor<T> where T : ScriptableObject
```
There is probably a way to directly call `SOVariantAttributeProcessor` from the attribute, but I haven't found how.

### [Selecting the parent object](https://github.com/GieziJo/ScriptableObjectVariant/issues/3)
The selected parent should be of the exact same class as the overriden item (otherwise fields might be missing) and should not be the child itself.
This check is currently done when setting the parent as:
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
It would be alot better to directly filter the possible candidates when selecting in the object, but adding the `AssetSelector` attribute with a filter, or building a custom `ValueDropdown` both did not work, not sure why.

</details>
