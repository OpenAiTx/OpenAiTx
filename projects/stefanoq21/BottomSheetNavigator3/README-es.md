# Navegación BottomSheet Material3

Esta biblioteca proporciona una solución de navegación para proyectos Compose que utilizan BottomSheets de Material3. Permite definir tu BottomSheet como rutas de navegación, eliminando la necesidad de las bibliotecas `androidx.compose.material.navigation` y ` androidx.compose.material:material`. Esto simplifica las dependencias de tu aplicación y garantiza una experiencia Material3 consistente.  
Esta biblioteca también aprovecha la nueva funcionalidad de `androidx.navigation:navigation-compose:2.8.0-beta0X` para permitirte definir rutas con clases serializadas.

[![Maven Central](https://img.shields.io/maven-central/v/io.github.stefanoq21/material3-navigation)](https://central.sonatype.com/artifact/io.github.stefanoq21/material3-navigation)

![Insignia Estática](https://img.shields.io/badge/minSdk-21-blue?link=https%3A%2F%2Fgithub.com%2Fstefanoq21%2FBottomSheetNavigator3%2Fblob%2Fmain%2Fmaterial3-navigation%2Fbuild.gradle.kts%23L15)

## Implementación

Puedes seguir el enfoque de implementación usado en el módulo [app](https://github.com/stefanoq21/BottomSheetNavigator3/tree/main/app "app"). Alternativamente, puedes encontrar una explicación detallada a continuación.

### Dependencias  
¡La biblioteca ya está disponible en MavenCentral!  
Agrega las dependencias a tu `libs.versions.toml`

```
[versions]
...
material3Navigation = "X.X.X" current release version

[libraries]
...
material3-navigation = { group = "io.github.stefanoq21", name = "material3-navigation", version.ref = "material3Navigation" }

```
En tu `build.gradle.kts` implementa tus dependencias:
```
...
dependencies {
...
 implementation(libs.material3.navigation)
```
### Uso
Define tu **BottomSheetNavigator**
```
...
   val bottomSheetNavigator =
                    rememberBottomSheetNavigator(skipPartiallyExpanded = true/false)
                val navController = rememberNavController(bottomSheetNavigator)
```
Agregue el **ModalBottomSheetLayout** encima del componente **NavHost** y pase el **bottomSheetNavigator** como parámetro:
```
ModalBottomSheetLayout(
                        modifier = Modifier
                            .fillMaxSize(),
                        bottomSheetNavigator = bottomSheetNavigator
                    ) {
                        NavHost(
                            navController = navController,
                            startDestination = Screen.Home
                        ) {
...
```
Define tus rutas como cadenas o clases de datos (dependiendo de la versión de navegación de compose que estés utilizando):
```
...
   bottomSheet<Screen.BottomSheetFullScreen> {
                                BSFullScreenLayout()
                            }
  bottomSheet("BottomSheetFullScreen") {
                                BSFullScreenLayout()
                            }
...
```
¡Todo está listo! Simplemente navega a tu nuevo destino como de costumbre:
```
...
Button(onClick = { navController.navigate(Screen.BottomSheetFullScreen) }) {
                                        Text(text = "BottomSheetFullScreen")
                                    }
...
```

### Navegando hacia atrás desde un Bottom Sheet

Para implementar un botón de retroceso o cierre en tu bottom sheet, sugiero usar `onBackPressedDispatcher.onBackPressed()`. Esto se debe a que si usas `navController.popBackStack()` la animación no aparecerá. La animación fue deshabilitada, en este caso, para evitar problemas durante la navegación que comienza desde los bottom sheets.

### Personalización

La biblioteca actualmente soporta las mismas opciones de personalización que el estándar `androidx.compose.material3.ModalBottomSheet`. Puedes personalizar la apariencia de todos los bottom sheets usados en tu gráfico de navegación pasando los parámetros al `ModalBottomSheetLayout`.

## Vista previa
![](https://github.com/stefanoq21/BottomSheetNavigator3/assets/22545898/c971f6cf-bb04-41c1-b3ea-7b72757e09af)


## Contribuciones

¡Damos la bienvenida a contribuciones para esta biblioteca! Si tienes reportes de errores, solicitudes de funciones o mejoras de código, no dudes en crear una pull request. Agradezco tu ayuda para hacer esta biblioteca aún mejor.

## Licencia

   Copyright 2024 stefanoq21

   Licenciado bajo la Licencia Apache, Versión 2.0 (la "Licencia");
   no puedes usar este archivo excepto en cumplimiento con la Licencia.
   Puedes obtener una copia de la Licencia en

       http://www.apache.org/licenses/LICENSE-2.0

   A menos que lo exija la ley aplicable o se acuerde por escrito, el software
   distribuido bajo la Licencia se distribuye "TAL CUAL",
   SIN GARANTÍAS NI CONDICIONES DE NINGÚN TIPO, ya sean expresas o implícitas.
   Consulta la Licencia para conocer el lenguaje específico que rige los permisos y
   limitaciones bajo la Licencia.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-13

---