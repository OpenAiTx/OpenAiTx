# Hoja de Referencia

[![GitHub](https://img.shields.io/badge/github-michaelmagan/cheatsheet-blue?logo=github)](https://github.com/michaelmagan/cheatsheet)
[![License](https://img.shields.io/badge/license-MIT-green.svg)](./LICENSE)
[![Next.js](https://img.shields.io/badge/Next.js-15-black?logo=next.js)](https://nextjs.org/)
[![Tambo AI](https://img.shields.io/badge/Tambo-AI-purple)](https://tambo.co)

Un competidor de Google Sheets de código abierto, potenciado por IA, construido con [Tambo AI](https://tambo.co).

Crea y manipula hojas de cálculo interactivas con lenguaje natural, junto con gráficos y visualizaciones.

## Demo
Pruébalo tú mismo: **[CheatSheet](https://cheatsheet.tambo.co)**

### Vista previa
https://github.com/user-attachments/assets/da72aa8b-6bc5-468e-8f42-0da685105d22

## Características

- **Edición con IA**: Usa lenguaje natural para interactuar con una hoja de cálculo.
- **Selección de Celdas**: Selecciona celdas para que la IA interactúe con ellas.
- **Multimodal**: Adjunta imágenes junto con mensajes.
- **Gráficos y Diagramas**: Crea visualizaciones a partir de los datos de tu hoja de cálculo.
- **Protocolo de Contexto de Modelo (MCP)**: Conecta fuentes de datos y herramientas externas.

## Hoja de Ruta

- **Entrada por Voz**: Usa entrada de voz además de la escritura.
- **Soporte de Fórmulas**: Fórmulas de hoja de cálculo (SUMA, PROMEDIO, SI, BUSCARV, etc.)
- **Mejor Formato**: Más opciones visuales para tablas (colores, bordes, fuentes, alineación)
- **Importar/Exportar**: Soporte para CSV, XLSX y JSON

## Comenzar

1. Clona este repositorio

2. Navega al directorio del proyecto:

   ```bash
   cd spreadsheet-template
   ```

3. Instalar dependencias:
   ```bash
   npm install
   ```
4. Configure sus variables de entorno:

   **Opción A: Usando Tambo CLI (Recomendado)**

   ```bash
   npx tambo init
   ```
   Esto te solicitará interactivamente tu clave API de Tambo y creará `.env.local` automáticamente.

   **Opción B: Configuración Manual**
   ```bash
   cp example.env.local .env.local
   ```
   Luego edite `.env.local` y agregue su clave API desde [tambo.co/dashboard](https://tambo.co/dashboard).

5. Inicie el servidor de desarrollo:
   ```bash
   npm run dev
   ```

6. ¡Abre [http://localhost:3000](http://localhost:3000) en tu navegador para usar la aplicación!

## Resumen de la Arquitectura

Esta plantilla muestra cómo la IA lee y actualiza la hoja de cálculo a través de tres formas:

### Cómo la IA Accede al Estado de la Hoja de Cálculo

**Ayudantes de Contexto** (Datos de solo lectura)
- `spreadsheetContextHelper` - Proporciona a la IA los datos de la pestaña actual como una tabla markdown
- `spreadsheetSelectionContextHelper` - Indica a la IA qué está seleccionado actualmente
- `tabContextHelper` - Lista todas las pestañas y resalta la pestaña activa
- Se ejecuta automáticamente cada vez que envías un mensaje
- Ver: `src/lib/spreadsheet-context-helper.ts`, `src/lib/spreadsheet-selection-context.ts`, `src/lib/tab-context-helper.ts`

**Herramientas** (Realizan cambios)
- Herramientas de hoja de cálculo y de pestañas para que la IA cambie el estado o inspeccione metadatos
- Los ayudantes de contexto son de solo lectura; las herramientas realizan cambios
- Ver: `src/tools/spreadsheet-tools.ts`, `src/tools/tab-tools.ts`

### Referencia de Herramientas de Hoja de Cálculo

| Herramienta | Propósito |
|-------------|-----------|
| `updateCell` | Actualizar el valor de una sola celda |
| `updateRange` | Actualizar múltiples celdas a la vez |
| `addColumn` | Añadir una nueva columna |
| `removeColumn` | Eliminar una columna |
| `addRow` | Añadir una nueva fila |
| `removeRow` | Eliminar una fila |
| `readCell` | Leer el valor de una sola celda |
| `readRange` | Leer múltiples celdas |
| `clearRange` | Borrar valores de celdas en un rango |
| `sortByColumn` | Ordenar filas por valores de columna |

### Archivos Clave

**Configuración**
- `src/lib/tambo.ts` - Registro de componentes y herramientas
- `src/app/chat/page.tsx` - Interfaz principal del chat con TamboProvider

**Sistema de Hoja de Cálculo**
- `src/components/ui/spreadsheet-tabs.tsx` - Contenedor del libro de trabajo FortuneSheet + UI de pestañas
- `src/lib/fortune-sheet-store.tsx` - Almacén global en memoria que conecta el estado del libro de trabajo
- `src/lib/fortune-sheet-utils.ts` - Utilidades centradas en FortuneSheet (rangos, búsquedas)

**Gestión de Estado**
- `src/lib/canvas-storage.ts` - Gestión del estado del canvas/pestañas
- El estado de la hoja de cálculo fluye a través del proveedor FortuneSheet y las APIs del libro de trabajo.

**Nota sobre Dependencias:** FortuneSheet (`@fortune-sheet/{core,react}`) impulsa todas las interacciones con la hoja de cálculo.

## Personalización

### Añadiendo Componentes Personalizados

Registre componentes en `src/lib/tambo.ts` que la IA pueda renderizar en línea en el chat. Estructura de ejemplo:

```tsx
import type { TamboComponent } from "@tambo-ai/react";

const components: TamboComponent[] = [
  {
    name: "MyComponent",
    description: "When to use this component",
    component: MyComponent,
    propsSchema: myComponentSchema, // Zod schema
  },
];
```

Consulta `src/components/tambo/` para ejemplos de componentes y [documentación de Componentes Tambo](https://docs.tambo.co/concepts/components) para una guía detallada.

### Creación de Herramientas Personalizadas

Agrega herramientas en `src/tools/` siguiendo este patrón:

```tsx
export const myTool = {
  name: "toolName",
  description: "What this tool does",
  tool: async (param: string) => {
    // Implementation
    return { success: true, message: "Result" };
  },
  toolSchema: z.function().args(
    z.string().describe("Parameter description")
  ).returns(z.object({
    success: z.boolean(),
    message: z.string().optional(),
  })),
};
```
Registre en el arreglo tools de `src/lib/tambo.ts`. Consulte [Documentación de herramientas de Tambo](https://docs.tambo.co/concepts/tools) para más detalles.

### Protocolo de Contexto del Modelo (MCP)

Configure los servidores MCP a través del modal de configuración para conectar fuentes de datos externas. Los servidores se almacenan en localStorage del navegador y se envuelven con `TamboMcpProvider` en la interfaz de chat.

## Documentación

Aprenda más sobre Tambo:
- [Componentes](https://docs.tambo.co/concepts/components)
- [Componentes Interactivos](https://docs.tambo.co/concepts/components/interactable-components)
- [Herramientas](https://docs.tambo.co/concepts/tools)
- [Contexto Adicional](https://docs.tambo.co/concepts/additional-context)

Construido con [Tambo AI](https://tambo.co) - Un marco para construir interfaces de usuario impulsadas por IA. Tambo es de código abierto: [tambo-ai/tambo](https://github.com/tambo-ai/tambo).

![Demostración de Plantilla Tambo](https://raw.githubusercontent.com/tambo-ai/tambo/main/assets/template.gif)

## Contribuciones

¡Contribuciones bienvenidas! Consulte [CONTRIBUTING.md](https://raw.githubusercontent.com/michaelmagan/cheatsheet/main/./CONTRIBUTING.md) para las directrices.

## Licencia

Licencia MIT



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-16

---