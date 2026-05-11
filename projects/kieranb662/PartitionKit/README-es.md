# Partition Kit

![partition kit logo](https://github.com/kieranb662/PartitionKit/blob/master/partition-kit-logo.png)

Recientemente destacado en [Top 10 Bibliotecas de Android y iOS más populares en octubre](https://medium.com/better-programming/top-10-trending-android-and-ios-libraries-in-october-e7dd18f8b75b) y en [5 bibliotecas iOS para mejorar tu aplicación](https://medium.com/better-programming/5-ios-libraries-to-enhance-your-app-17ae7ed350db)!

![grid](/nestedGrid.gif)

¿Qué es PartitionKit?  
- Es la solución a la necesidad de contenido de interfaz de usuario componible y de tamaño dinámico en SwiftUI.  
- también es la primera pieza de software que he convertido en una biblioteca, así que por favor sé amable (tanto con los casos de uso como con mi corazón).

¿Qué **no** es PartitionKit?  
- PartitionKit no es un medio para trabajar con algún tipo de datos almacenados, esto no es para particionar discos duros ni ningún otro tipo de unidad formateable.

## Requisitos 

PartitionKit por defecto requiere que el Framework SwiftUI esté operativo, por lo que solo se soportan estas plataformas:

*  macOS 10.15 o superior  
* iOS 13 o superior  
* tvOS 13 o superior  
* watchOS 6 o superior  

## Cómo agregarlo a tu proyecto

1. Obtén esa URL del repositorio de GitHub  
2. En Xcode -> Archivo -> Paquetes Swift -> Añadir dependencia de paquete  
3. Pega la URL en el cuadro  
4. Especifica el número de versión mínima (Esto es nuevo, así que 1.0.0 o superior funcionará).

## Tutorial en menos de 2 minutos

[![Video tutorial: Cómo usar PartitionKit](https://img.youtube.com/vi/RSnEevQcqjk/0.jpg)](https://www.youtube.com/watch?v=RSnEevQcqjk)


## Cómo usar 




### Partición Vertical

1. Decida qué vista le gustaría tener en la `Parte superior`, cuál le gustaría tener en la `Parte inferior` y opcionalmente un `Mango` para usarlo para arrastrar las particiones a diferentes tamaños.
2. Haga esto 
``` Swift
VPart(top: {
    MyTopView()
    }, bottom: {
    MyBottomView()
    }) {
    MyHandle()
}
```

### Partición Horizontal 

1. Decida qué vista desea tener en la `Izquierda`, cuál desea tener en la `Derecha` y opcionalmente un `Mango` para usar para arrastrar las particiones a diferentes tamaños.
2. Haga Esto 
``` Swift
HPart(left: {
    MyLeftView()
    }, right: {
    MyRightView()
    }) {
    MyHandle()
}
```

### GridPartition 

1. Decida qué Vistas irán en cada esquina `TopLeft`, `TopRight`, `BottomLeft`, `BottomRight` y opcionalmente un `Handle` para que el usuario pueda arrastrar y cambiar el tamaño de las vistas. 
2. Haga esto 
``` Swift
    GridPart(topLeft: {
        MyTopLeftView()
        }, topRight: {
        MyTopRightView()
        }, bottomLeft: {
        MyBottomLeftView()
        }, bottomRight: {
        MyBottomRightView()
        }) {
        MyHandle()
}
```
## Ejemplos 

Copia y pega esto. He añadido imágenes con nombre para mostrar cómo deberían verse las vistas, estoy usando modo oscuro, por lo que los colores del modo claro pueden verse diferentes. 

| HPart                   | VPart                   | GridPart                      | NestGrids                              | Mixed                       |
|-------------------------|-------------------------|-------------------------------|----------------------------------------|-----------------------------|
| ![HPart](/hExample.png) | ![VPart](/vExample.png) | ![GridPart](/gridExample.png) | ![Nested Grid](/nestedGridExample.png) | ![Mixed](/nestedExample.png) |





``` Swift
import SwiftUI
import PartitionKit



struct ContentView: View {
    var vExample: some View {
        VPart(top: {
            RoundedRectangle(cornerRadius: 25).foregroundColor(.purple)
        }) {
            Circle().foregroundColor(.yellow)
        }
    }
    
    var hExample: some View {
        HPart(left: {
            RoundedRectangle(cornerRadius: 10).foregroundColor(.blue)
        }) {
            Circle().foregroundColor(.orange)
        }
    }
    
    var nestedExample: some View {
        VPart(top: {
            hExample
        }) {
            vExample
        }
    }
    
    var gridExample: some View {
        GridPart(topLeft: {
            RoundedRectangle(cornerRadius: 25).foregroundColor(.purple)
        }, topRight: {
            Circle().foregroundColor(.yellow)
        }, bottomLeft: {
            Circle().foregroundColor(.green)
        }) {
            RoundedRectangle(cornerRadius: 25).foregroundColor(.blue)
        }
    }
    
    var nestedGridsExample: some View {
        GridPart(topLeft: {
            gridExample
        }, topRight: {
            gridExample
        }, bottomLeft: {
            gridExample
        }) {
            gridExample
        }
    }
    
    var body: some View {
        nestedExample
        
    }
}


struct ContentView_Previews: PreviewProvider {
    static var previews: some View {
        ContentView()
    }
}
```
## Pendiente  
* Agregar restricciones para que las particiones no causen valores negativos en el marco que inviertan las vistas cuando el controlador se arrastra más allá del marco del contenedor  
* Añadir más personalización a los diseños iniciales  
* Añadir un diseño de colección de cuadrícula estilo `List` que pueda iniciarse con una lista de elementos de datos Identificables.  
* Limpieza general, algunas cosas no debían haberse quedado, las encontraré en algún momento.  






---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-11

---