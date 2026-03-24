## Sublime Self Patcher

Este es un plugin para Sublime Text 4 que puede parchear Sublime Text y Sublime Merge.

🔥 No se requiere ninguna dependencia de terceros. Lo único que necesitas es Sublime Text.

## Entornos Soportados

| Signo | Significado                                                             |
| ---- | ----------------------------------------------------------------------- |
| ✅   | Soportado.                                                             |
| ⚠️   | Patrones de parche inestables. Es posible que tengas que actualizar este plugin frecuentemente. |
| ☠️   | Lo siento, pero no lo uso.                                             |

|                   | Linux x64 | Windows x32 | Windows x64 | Otros  |
| ----------------- | --------- | ----------- | ----------- | ------ |
| **Sublime Text**  | ✅        | ✅          | ✅          | ☠️     |
| **Sublime Merge** | ✅⚠️      |             | ✅          | ☠️     |

Si estás en Windows 7, entonces se requiere el [Service Pack 2](https://answers.microsoft.com/en-us/windows/forum/all/how-to-obtain-and-install-windows-7-sp2/c2c7009f-3a10-4199-9c89-48e1e883051e).

## Descarga

https://github.com/n6333373/sublime-self-patcher/archive/refs/heads/main.zip

## Instalación

Primero, tienes que localizar el directorio `Packages`.

- Si usas una versión portátil de Sublime Text, es `Data/Packages`.
- Si usas una versión instalada de Sublime Text,
  - En Windows, es `%appdata%\Sublime Text\Packages`.
  - En Linux, es `$HOME/.config/sublime_text/Packages`.

Ahora, (descomprime si es necesario) coloca el directorio descargado dentro del directorio `Packages`
de modo que la estructura de directorios luzca así:

```text
Packages/
└── SelfPatcher/
    ├── boot.py
    ├── ...
```

Y luego reinicie Sublime Text si está en ejecución.

## Uso

### Parchear a sí mismo (El Sublime Text actual)

- Si está utilizando una versión de desarrollo no registrada, este complemento debería mostrar un cuadro emergente para parchear al iniciar.
- Si está utilizando una versión estable, puede parchear desde el menú: `Ayuda ⇒ Parchear esta aplicación`

### Parchear Sublime Text/Merge externo

Si su aplicación está instalada en un lugar que requiere permisos de administrador/root para escribir,
puede usar este complemento para crear un ejecutable parcheado en un directorio temporal.

Haga clic en el menú: `Ayuda ⇒ Parchear Sublime Text/Merge externo` y luego seleccione el ejecutable de Sublime Text/Merge.

## Preguntas y Respuestas

### ¿Cómo desactivar la actualización automática de Sublime Text/Merge?

Este complemento usualmente sigue funcionando para versiones futuras de Sublime Text/Merge.
Pero si desea desactivar la actualización automática de la aplicación, puede configurar los siguientes ajustes:

```jsonc
{
    "update_check": false, // this works only if you have registered
}
```

### Este Plugin es Sospechoso

No creo hacer nada malicioso, pero no tienes que confiar en mí. Puedes

- Hacer el parcheo en una máquina virtual y sacar el ejecutable parcheado.
- Hacerlo tú mismo. Consulta https://gist.github.com/maboloshi/feaa63c35f4c2baab24c9aaf9b3f4e47


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-24

---