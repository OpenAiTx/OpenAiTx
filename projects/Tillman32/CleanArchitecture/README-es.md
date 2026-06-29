[![Licencia: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![CI - Build and Test](https://github.com/Tillman32/CleanArchitecture/actions/workflows/ci.yml/badge.svg)](https://github.com/Tillman32/CleanArchitecture/actions/workflows/ci.yml)
[![Deploy to GitHub Pages](https://github.com/Tillman32/CleanArchitecture/actions/workflows/pages.yml/badge.svg)](https://github.com/Tillman32/CleanArchitecture/actions/workflows/pages.yml)

![](https://raw.githubusercontent.com/Tillman32/CleanArchitecture/master/./src/CleanArchitecture.WASM/Preview.png)

[DEMO EN VIVO - WASM en GitHub Pages](https://tillman32.github.io/CleanArchitecture/)

# La motivación detrás de todo esto

¿Para qué sirve todo esto? Bueno, además de mostrar a Bob Ross... pensé que sería inteligente tener una aplicación "del mundo real" para referenciar al hablar de arquitectura. Quiero algo para establecer un estándar, algo para clonar, algo para utilizar en todos mis próximos proyectos .Net Core. Como todo software (y el vino), esto mejorará con el tiempo.

También me pareció apropiado que "Tío Bob" (Robert C. Martin) comparta un nombre similar, y este proyecto intenta alinearse con su arquitectura [descrita aquí en su sitio web.](https://blog.cleancoder.com/uncle-bob/2012/08/13/the-clean-architecture.html)

También escribí una publicación en el blog para acompañarlo aquí: [https://www.brandontillman.com/blog/clean-architecture-dotnet](https://www.brandontillman.com/blog/clean-architecture-dotnet)

# Puntos clave:

### :trident: Arquitectura N-Capas

Un enfoque de 3 capas, para prepararnos para múltiples interfaces de usuario que usen la misma funcionalidad núcleo de negocio/back-end.

### :open_file_folder: Separación de Responsabilidades

Estrechamente relacionado con el principio de ["Responsabilidad Única"](http://deviq.com/single-responsibility-principle/), la Separación de Responsabilidades (SoC) hace que tu código sea más mantenible, al no colocar ideas juntas. Cuando las cosas cambian, SoC ayudará a asegurar que tus cambios se limiten a tu conjunto de características, y no se extiendan por toda tu aplicación.

### :droplet: No hay Abstracciones que Fugan

Al usar interfaces, podemos evitar abstracciones que fugan, y tener mejor control de cómo se usa nuestro código. Por el contrario, los consumidores de nuestro código no tienen que conocer los detalles de implementación, simplemente pueden usar tus interfaces/clases.

### :microscope: Testeable

Probar código que está fuertemente acoplado es casi imposible. Siguiendo el principio SoC, y usando interfaces nuestro código será más fácil de probar.

### :electric_plug: Modular

El código será más fácil de modificar en el futuro, por varias razones. La separación de responsabilidades permite menos cambios/pruebas en toda la aplicación. Puedes construir sobre conjuntos específicos de características, sin modificar el resto del código.

### :wrench: Mantenible

El código será inherentemente más mantenible siguiendo los patrones de Arquitectura Limpia. Otros desarrolladores verán el beneficio de la separación limpia y seguirán su ejemplo.

# Tecnologías Primarias Usadas

- [.Net](https://dotnet.microsoft.com/)
- [Blazor WASM](https://www.learnblazor.com/)
- [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/)
- [AutoMapper](https://automapper.org/)
- [NLog](https://nlog-project.org/)

### :star2: ¡Dale una Estrella! 
Si te gusta o estás usando este proyecto para aprender o comenzar tu solución, por favor considera darle una estrella. ¡Gracias!


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-29

---