# Colección Integral de Agentes de Claude Code

**Idioma**: [Inglés](https://raw.githubusercontent.com/dl-ezo/claude-code-sub-agents/main/README.md) | [日本語](https://raw.githubusercontent.com/dl-ezo/claude-code-sub-agents/main/README_JA.md)

Una colección completa de 35 sub-agentes especializados para Claude Code que permiten la automatización de desarrollo de software de extremo a extremo, desde el análisis de requisitos hasta el despliegue en producción y mantenimiento continuo.

## 🎯 Visión General

Este repositorio contiene un conjunto integral de sub-agentes de Claude Code diseñados para manejar ciclos completos de desarrollo de software con mínima intervención humana. Los agentes están organizados en seis categorías que cubren cada aspecto del desarrollo moderno de software.

## 📦 Categorías de Agentes

### 1. Requisitos y Análisis (4 agentes)
**Propósito**: Transformar necesidades de negocio en especificaciones técnicas detalladas

- **requirements-analyst** - Analiza las necesidades del usuario y crea especificaciones funcionales detalladas
- **user-story-generator** - Crea historias de usuario completas y criterios de aceptación  
- **business-process-analyst** - Analiza procesos de negocio y los traduce en requisitos técnicos
- **requirements-validator** - Valida los requisitos para verificar completitud y consistencia

### 2. Diseño y Arquitectura (5 agentes)
**Propósito**: Crear diseños de sistemas robustos y escalables

- **system-architect** - Diseña arquitecturas de sistemas completas y pilas tecnológicas
- **data-architect** - Diseña modelos de datos, esquemas y estrategias de integración
- **interface-designer** - Diseña interfaces de usuario y especificaciones de API
- **security-architect** - Diseña marcos de seguridad y estrategias de protección de datos
- **design-reviewer** - Revisa y valida los diseños del sistema para asegurar calidad

### 3. Implementación y Desarrollo (10 agentes)
**Propósito**: Manejar todos los aspectos del desarrollo de código y aseguramiento de calidad

- **code-reviewer** - Realiza evaluaciones exhaustivas de calidad de código
- **test-suite-generator** - Genera cobertura de pruebas completa
- **code-refactoring-specialist** - Mejora la estructura del código de manera segura y reduce la deuda técnica
- **security-analyzer** - Identifica vulnerabilidades y problemas de seguridad
- **performance-optimizer** - Analiza y optimiza el rendimiento del código
- **api-designer** - Diseña APIs limpias, RESTful con especificaciones apropiadas
- **documentation-generator** - Crea documentación técnica y comentarios de código
- **dependency-manager** - Gestiona dependencias de paquetes y resuelve conflictos
- **database-schema-designer** - Diseña esquemas eficientes de base de datos y migraciones
- **cicd-builder** - Crea y configura pipelines de CI/CD

### 4. Gestión de Proyectos (5 agentes)
**Propósito**: Coordinar y gestionar todo el proceso de desarrollo

- **project-planner** - Crea planes de proyecto y cronogramas detallados
- **risk-manager** - Identifica riesgos del proyecto y crea estrategias de mitigación
- **progress-tracker** - Monitorea el progreso del proyecto e identifica bloqueos
- **qa-coordinator** - Establece estándares de calidad y coordina las pruebas
- **stakeholder-communicator** - Gestiona la comunicación y reportes con los interesados

### 5. Despliegue y Operaciones (5 agentes)
**Propósito**: Manejar el despliegue en producción y operaciones continuas

- **project-orchestrator** - Coordinador maestro para la ejecución integral del proyecto
- **deployment-ops-manager** - Gestiona el despliegue en producción y monitoreo operativo
- **uat-coordinator** - Coordina pruebas de aceptación de usuario con las partes interesadas del negocio
- **training-change-manager** - Crea materiales de capacitación y gestiona la adopción del sistema
- **project-template-manager** - Gestiona plantillas de proyecto y configuraciones rápidas para patrones comunes

### 6. Meta-Gestión (6 agentes)
**Propósito**: Optimizar Claude Code para máxima eficiencia

- **context-manager** - Monitorea el contexto de la sesión y gestiona información para continuidad
- **session-continuity-manager** - Asegura transiciones fluidas entre sesiones de Claude Code
- **memory-manager** - Optimiza el uso de memoria de Claude Code y la documentación del proyecto
- **workflow-optimizer** - Analiza y optimiza flujos de trabajo y uso de agentes
- **resource-monitor** - Monitorea uso de recursos y sugiere estrategias de optimización
- **agent-creator** - Crea dinámicamente nuevos agentes especializados cuando surgen necesidades del proyecto

## 🚀 Características Clave

### Automatización Completa
- **Desarrollo de extremo a extremo**: Desde requisitos hasta despliegue en producción
- **Orquestación inteligente**: Los agentes coordinan y secuencian el trabajo automáticamente
- **Especialización dinámica**: Creación de nuevos agentes para necesidades únicas del proyecto
- **Continuidad de sesión**: Mantiene el contexto a lo largo de largas sesiones de desarrollo

### Calidad Profesional
- **Mejores prácticas de la industria**: Cada agente sigue metodologías establecidas
- **Pruebas integrales**: Generación automatizada de pruebas y aseguramiento de calidad
- **Seguridad primero**: Análisis de seguridad integrado y verificación de cumplimiento
- **Listo para producción**: Soporte completo para despliegue y operación

### Arquitectura Escalable
- **Diseño modular**: Uso de agentes individuales o flujos de trabajo completos
- **Preservación del contexto**: Gestión eficiente de memoria para proyectos prolongados
- **Optimización de recursos**: Monitoreo y optimización del uso de Claude Code
- **Basado en plantillas**: Configuración rápida de proyectos con patrones probados

## 💡 Casos de Uso

### Automatización Completa de Proyectos
```
User: "Create a library management system for our company"
Result: Fully functional web application with database, API, frontend, tests, documentation, and deployment
```
### Tareas de Desarrollo Especializadas

```
User: "Review this authentication code for security issues"
Agent: security-analyzer performs comprehensive security audit
```

### Gestión de Proyectos a Largo Plazo
```
User: "Manage the development of a multi-tenant SaaS platform"
Agent: project-orchestrator coordinates all phases with appropriate specialists
```

## 📋 Instalación

1. **Clona o copia las definiciones del agente** en el directorio `.claude/agents/` de tu proyecto:
   ```bash
   mkdir -p .claude/agents
   # Copy the 35 agent definition files to this directory
   ```
2. **Verificar la instalación**:

   ```bash
   ls .claude/agents/
   # Should show all 35 agent files (.md format)
   ```
3. **Comience a usar agentes** en Claude Code:

   ```
   Use the project-orchestrator agent to build a complete web application
   ```

## 🎮 Ejemplos de Uso

### Iniciar una Nueva Aplicación Web
```
"I want to build a task management web application with user authentication, real-time updates, and mobile responsiveness. Handle everything from requirements to deployment."
```
El **orquestador-del-proyecto**:
1. Usará **analista-de-requisitos** para recopilar requisitos detallados
2. Coordinará al **arquitecto-del-sistema** y al **arquitecto-de-datos** para el diseño
3. Gestionará la implementación con los agentes de desarrollo
4. Manejará las pruebas, el despliegue y la documentación
5. Proporcionará materiales de capacitación para los usuarios finales

### Revisión de Calidad de Código

```
"Review my e-commerce checkout process for security vulnerabilities, performance issues, and code quality."
```

Múltiples agentes coordinan:
- **security-analyzer** verifica vulnerabilidades
- **performance-optimizer** identifica cuellos de botella  
- **code-reviewer** asegura las mejores prácticas

### Gestión de proyectos a largo plazo
```
"Manage the development of our new customer portal over the next 6 months with regular stakeholder updates."
```
El sistema proporciona:  
- Planificación automatizada de proyectos y gestión de riesgos  
- Seguimiento y reporte regular del progreso  
- Puertas de calidad y coordinación de pruebas  
- Gestión de comunicación con los interesados  

## 🔧 Patrones de Flujo de Trabajo de Agentes  

### Patrón Secuencial  
Requisitos → Diseño → Implementación → Pruebas → Despliegue  

### Patrón Paralelo  
Múltiples agentes de desarrollo trabajando simultáneamente en diferentes componentes  

### Patrón Adaptativo  
**agent-creator** genera agentes especializados para requisitos únicos  

### Patrón Continuo  
Agentes de meta-gestión proporcionan optimización y monitoreo continuo  

## 📝 Formato de Definición de Agentes  

Cada agente sigue el formato estándar de Claude Code:

```markdown
---
name: agent-name
description: Detailed description with examples and usage patterns
---

Comprehensive system prompt defining the agent's expertise, responsibilities, and methodologies.
```

## 🔄 Interacciones entre Agentes

### Coordinador Principal
- **orquestador-de-proyecto** gestiona el flujo general del proyecto
- Selecciona y secuencia automáticamente los agentes apropiados
- Maneja la comunicación entre agentes y la gestión de dependencias

### Equipos Especializados
- **Equipo de Requisitos**: Recopila y valida las necesidades del proyecto
- **Equipo de Diseño**: Crea la arquitectura técnica y las especificaciones  
- **Equipo de Desarrollo**: Implementa, prueba y optimiza el código
- **Equipo de Operaciones**: Despliega y mantiene los sistemas en producción
- **Equipo Meta**: Optimiza el uso y la continuidad del Código Claude

## 📚 Documentación

Cada agente incluye:
- **Descripción detallada** con ejemplos de uso
- **Casos de uso específicos** y condiciones de activación
- **Resultados esperados** y entregables
- **Patrones de integración** con otros agentes

## 🎯 Ejemplo Completo de Automatización

### Entrada
```
"Create a library management system for our company"
```
### Proceso Automatizado
1. **Análisis de Requisitos**: Necesidades de los interesados → Especificaciones técnicas
2. **Diseño del Sistema**: Arquitectura → Diseño de base de datos → Diseño de API → Diseño de UI
3. **Implementación**: Backend → Frontend → Pruebas → Documentación
4. **Aseguramiento de Calidad**: Revisión de código → Análisis de seguridad → Optimización de rendimiento
5. **Despliegue**: Configuración de producción → Pipeline CI/CD → Monitoreo
6. **Entrega**: Capacitación de usuarios → Documentación → Procedimientos de soporte

### Resultado
- Aplicación web completamente funcional
- Suite completa de pruebas con alta cobertura
- Despliegue en producción con monitoreo
- Documentación de usuario y materiales de capacitación
- Procedimientos de mantenimiento continuo

## 🤝 Contribuciones

¡Damos la bienvenida a las contribuciones! Por favor:

1. Sigue el formato establecido para la definición de agentes
2. Incluye ejemplos y documentación exhaustiva
3. Prueba a fondo con proyectos reales
4. Asegúrate que los agentes se integren bien con los flujos de trabajo existentes
5. Envía documentación clara sobre las capacidades del agente

## 📄 Licencia

Licencia MIT - siéntete libre de usar, modificar y distribuir estos agentes para cualquier propósito.

## 🙏 Agradecimientos

Diseñado para trabajar sin problemas con [Claude Code](https://claude.ai/code) y sigue todos los patrones establecidos y mejores prácticas para el desarrollo de sub-agentes.

## 📞 Soporte

Para problemas, preguntas o sugerencias:
- Abre un issue en este repositorio
- Consulta la documentación de Claude Code en https://docs.anthropic.com/en/docs/claude-code
- Revisa ejemplos de agentes y patrones de uso

---

*Transforma tu proceso de desarrollo con automatización inteligente. Desde un solo requisito hasta un sistema en producción - deja que los agentes manejen la complejidad mientras tú te enfocas en la visión.*

## 🚀 Inicio Rápido

1. **Copia los agentes** al directorio `.claude/agents/` de tu proyecto
2. **Inicia Claude Code** en tu proyecto
3. **Di**: "Usa el project-orchestrator para construir [tu descripción del proyecto]"
4. **Observa** cómo el sistema maneja todo desde requisitos hasta despliegue

**¡Eso es todo!** Los agentes se coordinarán automáticamente para entregar una solución completa y lista para producción.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---