[![Releases](https://img.shields.io/github/release/GieziJo/ScriptableObjectVariant.svg)](https://github.com/GieziJo/ScriptableObjectVariant/releases/latest)
[![openupm](https://img.shields.io/npm/v/ch.giezi.tools.scriptableobjectvariant?label=openupm&registry_uri=https://package.openupm.com)](https://openupm.com/packages/ch.giezi.tools.scriptableobjectvariant/)
[![License: MIT](https://img.shields.io/badge/License-MIT-brightgreen.svg)](https://github.com/GieziJo/ScriptableObjectVariant/blob/master/LICENSE.txt)

# Variante de Scriptable Object para Unity (Sobrescritor de Datos de Scriptable Object)

> [!CAUTION]
> Si estás actualizando desde una versión anterior a la `2.0.0`, por favor lee la [sección de actualización](#upgrading-to-200-from-previous-versions)

## Tabla de contenidos
- [Descripción](#description)
- [Uso](#usage)
- [Implementación](#implementation)
- [Instalación](#installation)
- [Actualización a 2.0.0 desde versiones anteriores](#upgrading-to-200-from-previous-versions)
- [Problemas conocidos y ajustes a realizar](#known-issues-and-tweaks-to-be-made)

## Descripción
Agrega un campo a cualquier scriptable object etiquetado con el atributo `[SOVariant]` que te permite seleccionar un SO original (padre) y sobrescribir campos seleccionados en el objeto hijo.

Cuando se cambian los valores en el original, los valores se propagan automáticamente a los hijos.

<img src="https://raw.githubusercontent.com/GieziJo/ScriptableObjectVariant/assets/ScriptableObjectOverrideDemo.gif" width="100%">

## Uso
Agrega la etiqueta `[SOVariant]` antes del encabezado de la clase de cualquier clase ScriptableObject que quieras que sea sobrescribible, es decir, para poder crear una variante de ella.

Ejemplo:
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

### Crear variante de Scriptable Object desde el menú contextual

![Menú contextual](https://raw.githubusercontent.com/GieziJo/ScriptableObjectVariant/assets/ContextMenuExample.png)

En Unity, puedes hacer clic derecho en cualquier Scriptable Object etiquetado como `SOVariant` para crear una variante de este objeto (`Crear > Crear variante SO`).
El nuevo objeto tendrá como padre al objeto seleccionado.

### Uso avanzado en script de Editor
Se ha implementado un script auxiliar (`SOVariantHelper.cs`) que permite cambiar padres, sobrescribir estados y valores desde otros scripts de editor.

Establecer un nuevo padre:
```csharp
ScriptableObject target = AssetDatabase.LoadAssetAtPath<ScriptableObject>("Assets/Tests/child.asset");
ScriptableObject parent = AssetDatabase.LoadAssetAtPath<ScriptableObject>("Assets/Tests/parent.asset");
        
SOVariantHelper<ScriptableObject>.SetParent(target, parent);
```

Establecer un campo sobreescribible:
```csharp
ScriptableObject target = AssetDatabase.LoadAssetAtPath<ScriptableObject>("Assets/Tests/child.asset");
        
SOVariantHelper<ScriptableObject>.ChangeFieldOverrideState(target, "MyFloat", true);
```
Establecer un nuevo valor de un campo (se propaga automáticamente a los hijos):

```csharp
ScriptableObject target = AssetDatabase.LoadAssetAtPath<ScriptableObject>("Assets/Tests/child.asset");
        
SOVariantHelper<ScriptableObject>.ChangeFieldValue(target, "MyFloat", 45f);
```
Establecer un campo para que sea sobrescrito y asignar un nuevo valor (se propaga automáticamente a los hijos):

```csharp
ScriptableObject target = AssetDatabase.LoadAssetAtPath<ScriptableObject>("Assets/Tests/child.asset");
        
SOVariantHelper<ScriptableObject>.SetFieldOverrideAndSetValue(target, "MyFloat", 45f);
```

Establecer un padre y establecer un nuevo valor sobrescrito (se propaga automáticamente a los hijos):
```csharp
ScriptableObject target = AssetDatabase.LoadAssetAtPath<ScriptableObject>("Assets/Tests/child.asset");
ScriptableObject parent = AssetDatabase.LoadAssetAtPath<ScriptableObject>("Assets/Tests/parent.asset");
    
SOVariantHelper<ScriptableObject>.SetParentOverrideValue(target, parent, "MyFloat", 45f);
```

Establecer un padre y establecer nuevos valores anulados (se propaga automáticamente a los hijos):
```csharp
ScriptableObject target = AssetDatabase.LoadAssetAtPath<ScriptableObject>("Assets/Tests/child.asset");
ScriptableObject parent = AssetDatabase.LoadAssetAtPath<ScriptableObject>("Assets/Tests/parent.asset");
    
SOVariantHelper<ScriptableObject>.SetParentOverrideValues(target, parent, new Dictionary<string, object>(){{"MyFloat", 45f},{"MyInt", 12}});
```

## Implementación
La interfaz visual está implementada en [`OdinPropertyProcessor`](https://odininspector.com/tutorials/using-property-resolvers-and-attribute-processors/custom-property-processors) de [Odin](odininspector.com/).

Los datos con el padre y los campos sobrescritos se mantienen en un objeto de biblioteca ubicado en `Assets/Plugins/SOVariant/Editor/SOVariantDataLibrary.asset`

<p style="color: grey";>Antes de la versión 2.0.0:
<strike>Los datos con el padre y los campos sobrescritos se mantienen serializados dentro de los metadatos del asset, establecidos en Unity con `AssetImporter.GetAtPath(AssetDatabase.GetAssetPath(targetObject)).userData`.</strike></p>

## Instalación
> [!ADVERTENCIA]
> Requiere que la versión `3.2.1.0` de [Odin](odininspector.com/) esté instalada antes de agregar el paquete.

> [!ADVERTENCIA]
> Este paquete se mantiene para la versión 2022.3.16f1 LTS de Unity.

### Usando el gestor de paquetes de Unity
Agrega la línea

```
"ch.giezi.tools.scriptableobjectvariant": "https://github.com/GieziJo/ScriptableObjectVariant.git#master"
```
al archivo `Packages/manifest.json` bajo `dependencies`, o en el `Package Manager` añade el enlace [`https://github.com/GieziJo/ScriptableObjectVariant.git#master`](https://github.com/GieziJo/ScriptableObjectVariant.git#master) bajo `+ -> "Add package from git URL...`.

### Usando OpenUPM
El paquete está disponible en [OpenUPM](https://openupm.com/packages/ch.giezi.tools.scriptableobjectvariant/).
Los paquetes de OpenUPM pueden instalarse de diferentes maneras:
- vía [OpenUPM CLI](https://github.com/openupm/openupm-cli): `openupm add ch.giezi.tools.scriptableobjectvariant`
- descargando el [`.unitypackage`](https://package-installer.glitch.me/v1/installer/OpenUPM/ch.giezi.tools.scriptableobjectvariant?registry=https%3A%2F%2Fpackage.openupm.com) y añadiéndolo a tu proyecto con `Assets > Import Package > Custom Package...`.

el paquete será añadido como un registro con ámbito, que puedes inspeccionar bajo `Project Settings > Package Manager > OpenUPM`.

### Alternativa
Descarga y copia todos los archivos dentro de tu proyecto.

## Actualización a 2.0.0 desde versiones previas

En la versión `2.0.0` del paquete, los datos se movieron desde los metadatos de cada objeto a usar una biblioteca de Scriptable Objects.
El importador de Unity siendo demasiado inestable, leer y escribir los datos en los metadatos se volvió demasiado complicado y a menudo causaba errores y fallos.

Si usabas el paquete antes de la versión `2.0.0`, se ha creado una herramienta para migrar a la nueva versión.
Ejecuta `Tools/GieziTools/SOVariant/Upgrade user data to new version`.
Esto leerá todos los datos contenidos en los metadatos y construirá la biblioteca.
Si es necesario, puedes ejecutar `Tools/GieziTools/SOVariant/Fix SOVs`.
Esto recorrerá cada objeto y reconstruirá la relación padre/hijo, además de propagar los valores del padre a los hijos.
Debido a que la versión anterior de la herramienta era bastante inestable, este paso es muy recomendable.
Además, deberías revisar los datos para asegurarte de que cada objeto tenga los valores correctos.

Esta nueva versión debería corregir muchos de los problemas que aparecieron con versiones más recientes de Unity y con la inestabilidad del paquete.

## Problemas conocidos y ajustes a realizar
<details>
<summary>Lista de problemas conocidos</summary>


### [Eficiencia](https://github.com/GieziJo/ScriptableObjectVariant/issues/2)
El atributo `[SOVariant]` solo actúa como etiqueta, la cual luego se busca en `SOVariantAttributeProcessor:OdinPropertyProcessor -> ProcessMemberProperties`, donde la primera línea lee:
```csharp
if(!Property.Attributes.Select(attribute => attribute.GetType()).Contains(typeof(SOVariantAttribute)))
    return;
```
El problema con esto es que `SOVariantAttributeProcessor` está configurado para ser llamado para cada `ScriptableObject`:
```csharp
public class SOVariantAttributeProcessor<T> : OdinPropertyProcessor<T> where T : ScriptableObject
```
Probablemente exista una forma de llamar directamente a `SOVariantAttributeProcessor` desde el atributo, pero no he encontrado cómo.

### [Seleccionar el objeto padre](https://github.com/GieziJo/ScriptableObjectVariant/issues/3)
El padre seleccionado debe ser de la misma clase exacta que el elemento sobrescrito (de lo contrario, podrían faltar campos) y no debe ser el hijo mismo.
Esta verificación se realiza actualmente al establecer el padre como:
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
Sería mucho mejor filtrar directamente los posibles candidatos al seleccionar en el objeto, pero agregar el atributo `AssetSelector` con un filtro, o construir un `ValueDropdown` personalizado, no funcionó, no estoy seguro por qué.

</details>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-30

---