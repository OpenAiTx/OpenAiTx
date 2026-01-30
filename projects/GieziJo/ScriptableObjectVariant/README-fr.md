[![Releases](https://img.shields.io/github/release/GieziJo/ScriptableObjectVariant.svg)](https://github.com/GieziJo/ScriptableObjectVariant/releases/latest)
[![openupm](https://img.shields.io/npm/v/ch.giezi.tools.scriptableobjectvariant?label=openupm&registry_uri=https://package.openupm.com)](https://openupm.com/packages/ch.giezi.tools.scriptableobjectvariant/)
[![License: MIT](https://img.shields.io/badge/License-MIT-brightgreen.svg)](https://github.com/GieziJo/ScriptableObjectVariant/blob/master/LICENSE.txt)

# Variante d’Objet Scriptable pour Unity (Surcharge de données d’objet scriptable)

> [!CAUTION]
> Si vous effectuez une mise à jour depuis une version antérieure à `2.0.0`, veuillez lire la [section de mise à niveau](#upgrading-to-200-from-previous-versions)

## Table des matières
- [Description](#description)
- [Utilisation](#usage)
- [Implémentation](#implementation)
- [Installation](#installation)
- [Mise à niveau vers 2.0.0 depuis les versions précédentes](#upgrading-to-200-from-previous-versions)
- [Problèmes connus et ajustements à effectuer](#known-issues-and-tweaks-to-be-made)

## Description
Ajoute un champ à tout objet scriptable marqué avec l’attribut `[SOVariant]` qui vous permet de sélectionner un objet SO original (parent) et de surcharger des champs sélectionnés dans l’objet enfant.

Lorsque les valeurs sont modifiées dans l’original, elles sont automatiquement propagées aux enfants.

<img src="https://raw.githubusercontent.com/GieziJo/ScriptableObjectVariant/assets/ScriptableObjectOverrideDemo.gif" width="100%">

## Utilisation
Ajoutez le tag `[SOVariant]` avant l’en-tête de la classe de toute classe ScriptableObject que vous souhaitez rendre modifiable, c’est-à-dire pour pouvoir créer une variante.

Exemple :
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

### Créer une variante de Scriptable Object depuis le menu contextuel

![Menu Contextuel](https://raw.githubusercontent.com/GieziJo/ScriptableObjectVariant/assets/ContextMenuExample.png)

Dans Unity, vous pouvez faire un clic droit sur n'importe quel scriptable object marqué `SOVariant` pour créer une variante de cet objet (`Create > Create SO Variant`).
Le nouvel objet aura l'objet sélectionné comme parent.

### Utilisation avancée dans un script éditeur
Un script d'assistance a été implémenté (`SOVariantHelper.cs`) qui vous permet de changer les parents, d'outrepasser les états et les valeurs depuis d'autres scripts éditeur.

Définir un nouveau parent :
```csharp
ScriptableObject target = AssetDatabase.LoadAssetAtPath<ScriptableObject>("Assets/Tests/child.asset");
ScriptableObject parent = AssetDatabase.LoadAssetAtPath<ScriptableObject>("Assets/Tests/parent.asset");
        
SOVariantHelper<ScriptableObject>.SetParent(target, parent);
```

Définir un champ modifiable :
```csharp
ScriptableObject target = AssetDatabase.LoadAssetAtPath<ScriptableObject>("Assets/Tests/child.asset");
        
SOVariantHelper<ScriptableObject>.ChangeFieldOverrideState(target, "MyFloat", true);
```
Définir une nouvelle valeur d’un champ (se propage automatiquement aux enfants) :

```csharp
ScriptableObject target = AssetDatabase.LoadAssetAtPath<ScriptableObject>("Assets/Tests/child.asset");
        
SOVariantHelper<ScriptableObject>.ChangeFieldValue(target, "MyFloat", 45f);
```
Définir un champ à remplacer et définir une nouvelle valeur (se propage automatiquement aux enfants) :

```csharp
ScriptableObject target = AssetDatabase.LoadAssetAtPath<ScriptableObject>("Assets/Tests/child.asset");
        
SOVariantHelper<ScriptableObject>.SetFieldOverrideAndSetValue(target, "MyFloat", 45f);
```
Définir un parent et définir une nouvelle valeur remplacée (se propage automatiquement aux enfants) :

```csharp
ScriptableObject target = AssetDatabase.LoadAssetAtPath<ScriptableObject>("Assets/Tests/child.asset");
ScriptableObject parent = AssetDatabase.LoadAssetAtPath<ScriptableObject>("Assets/Tests/parent.asset");
    
SOVariantHelper<ScriptableObject>.SetParentOverrideValue(target, parent, "MyFloat", 45f);
```

Définir un parent et définir de nouvelles valeurs remplacées (se propage automatiquement aux enfants) :
```csharp
ScriptableObject target = AssetDatabase.LoadAssetAtPath<ScriptableObject>("Assets/Tests/child.asset");
ScriptableObject parent = AssetDatabase.LoadAssetAtPath<ScriptableObject>("Assets/Tests/parent.asset");
    
SOVariantHelper<ScriptableObject>.SetParentOverrideValues(target, parent, new Dictionary<string, object>(){{"MyFloat", 45f},{"MyInt", 12}});
```
## Implémentation
L'interface visuelle est implémentée dans [`OdinPropertyProcessor`](https://odininspector.com/tutorials/using-property-resolvers-and-attribute-processors/custom-property-processors) de [Odin](odininspector.com/).

Les données avec le parent et les champs surchargés sont conservées dans un objet bibliothèque situé à `Assets/Plugins/SOVariant/Editor/SOVariantDataLibrary.asset`

<p style="color: grey";>Avant la version 2.0.0 :
<strike>Les données avec le parent et les champs surchargés étaient conservées sérialisées à l'intérieur des métadonnées de l'asset, définies dans Unity avec `AssetImporter.GetAtPath(AssetDatabase.GetAssetPath(targetObject)).userData`.</strike></p>

## Installation
> [!WARNING]
> Nécessite la version `3.2.1.0` de [Odin](odininspector.com/) installée avant d'ajouter le package.

> [!WARNING]
> Ce package est maintenu pour la version 2022.3.16f1 LTS de Unity.

### Utilisation du gestionnaire de packages de Unity
Ajoutez la ligne


```
"ch.giezi.tools.scriptableobjectvariant": "https://github.com/GieziJo/ScriptableObjectVariant.git#master"
```
au fichier `Packages/manifest.json` sous `dependencies`, ou dans le `Package Manager` ajoutez le lien [`https://github.com/GieziJo/ScriptableObjectVariant.git#master`](https://github.com/GieziJo/ScriptableObjectVariant.git#master) sous `+ -> "Add package from git URL...`.

### Utilisation d'OpenUPM
Le package est disponible sur [OpenUPM](https://openupm.com/packages/ch.giezi.tools.scriptableobjectvariant/).
Les packages OpenUPM peuvent être installés de différentes manières :
- via [OpenUPM CLI](https://github.com/openupm/openupm-cli) : `openupm add ch.giezi.tools.scriptableobjectvariant`
- en téléchargeant le [`.unitypackage`](https://package-installer.glitch.me/v1/installer/OpenUPM/ch.giezi.tools.scriptableobjectvariant?registry=https%3A%2F%2Fpackage.openupm.com) et en l'ajoutant à votre projet via `Assets > Import Package > Custom Package...`.

le package sera ajouté en tant que registre scindé, que vous pouvez inspecter sous `Project Settings > Package Manager > OpenUPM`.

### Alternative
Téléchargez et copiez tous les fichiers dans votre projet.

## Mise à niveau vers la version 2.0.0 depuis les versions précédentes

Dans la version `2.0.0` du package, les données sont passées de chaque métadonnée d'objet à une bibliothèque de Scriptable Object.
L'importateur de Unity étant trop instable, lire et écrire les données dans les métadonnées est devenu trop compliqué et entraînait souvent des erreurs et des échecs.

Si vous utilisiez le package avant la version `2.0.0`, un outil a été écrit pour migrer vers la nouvelle version.
Exécutez `Tools/GieziTools/SOVariant/Upgrade user data to new version`.
Cela lira toutes les données contenues dans les métadonnées et construira la bibliothèque.
Si nécessaire, vous pouvez exécuter `Tools/GieziTools/SOVariant/Fix SOVs`.
Cela parcourra chaque objet et reconstruira la relation parent/enfant, ainsi que propagera les valeurs du parent vers les enfants.
Parce que la version précédente de l'outil était assez instable, cette étape est fortement recommandée.
De plus, vous devriez vérifier les données pour vous assurer que chaque objet a les bonnes valeurs.

Cette nouvelle version devrait résoudre beaucoup des problèmes apparus avec les versions récentes de Unity et avec l'instabilité du package.

## Problèmes connus et ajustements à effectuer
<details>
<summary>Liste des problèmes connus</summary>


### [Efficacité](https://github.com/GieziJo/ScriptableObjectVariant/issues/2)
L'attribut `[SOVariant]` agit uniquement comme un marqueur, qui est ensuite recherché dans `SOVariantAttributeProcessor:OdinPropertyProcessor -> ProcessMemberProperties`, où la première ligne lit :
```csharp
if(!Property.Attributes.Select(attribute => attribute.GetType()).Contains(typeof(SOVariantAttribute)))
    return;
```
Le problème avec cela est que `SOVariantAttributeProcessor` est ainsi configuré pour être appelé pour chaque `ScriptableObject` :
```csharp
public class SOVariantAttributeProcessor<T> : OdinPropertyProcessor<T> where T : ScriptableObject
```
Il existe probablement un moyen d'appeler directement `SOVariantAttributeProcessor` depuis l'attribut, mais je n'ai pas trouvé comment.

### [Sélection de l'objet parent](https://github.com/GieziJo/ScriptableObjectVariant/issues/3)
Le parent sélectionné doit être de la même classe exacte que l'élément surchargé (sinon des champs pourraient manquer) et ne doit pas être l'enfant lui-même.
Cette vérification est actuellement effectuée lors de la définition du parent comme suit :
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
Il serait beaucoup mieux de filtrer directement les candidats possibles lors de la sélection dans l'objet, mais l'ajout de l'attribut `AssetSelector` avec un filtre, ou la création d'un `ValueDropdown` personnalisé n'a pas fonctionné, je ne sais pas pourquoi.

</details>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-30

---