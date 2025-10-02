# ronald-miniSpring Framework

Una implementación ligera del framework Spring que demuestra los principios y mecanismos centrales de Spring. Este proyecto extrae y simplifica las características esenciales de Spring mientras mantiene su arquitectura fundamental, siendo un recurso de aprendizaje excelente para entender el funcionamiento interno de Spring.

## 🚀 Características Clave

- **Contenedor IoC**: Implementación completa de inyección de dependencias e inversión de control
- **Framework AOP**: Programación orientada a aspectos con soporte para interceptación y mejora de métodos
- **Ciclo de Vida de Bean**: Gestión completa del ciclo de vida de beans (instanciación, inicialización, destrucción)
- **Gestión de Recursos**: Sistema flexible de carga de recursos que soporta classpath y sistema de archivos
- **Sistema de Eventos**: Implementación del patrón publicar-suscribir para eventos de la aplicación
- **Conversión de Tipos**: Sistema robusto de conversión de tipos para tipos básicos y personalizados
- **Configuración XML**: Soporte completo para configuración XML con manejo de espacios de nombres

## 💡 Aspectos Técnicos Destacados

### 1. Resolución de Dependencias Circulares
Implementación de un mecanismo sofisticado de caché de tres niveles para manejar dependencias circulares:
```java
// Three-level cache structure
Map<String, Object> singletonObjects = new ConcurrentHashMap<>();      // Level 1: Fully initialized beans
Map<String, Object> earlySingletonObjects = new HashMap<>();           // Level 2: Early exposed beans
Map<String, ObjectFactory<?>> singletonFactories = new HashMap<>();    // Level 3: Bean factories
```

### 2. Implementación de AOP
- Generación dinámica de proxies usando tanto JDK como CGLIB
- Soporte para expresiones de pointcut de AspectJ
- Tipos de advice flexibles (Before, After, Around)

### 3. Gestión del Ciclo de Vida de Beans
- Hooks completos del ciclo de vida (InitializingBean, DisposableBean)
- Soporte BeanPostProcessor para personalización
- Implementación de la familia de interfaces Aware

## 🛠️ Stack Técnico

- **Lenguaje**: Java 17
- **Herramienta de Construcción**: Maven 3.8.1
- **Pruebas**: JUnit 5
- **Dependencias**:
  - DOM4J para análisis XML
  - CGLIB para proxy AOP
  - AspectJ para expresiones de pointcut
  - Logback para registro

## 📋 Estructura del Proyecto

```
src/main/java/com/minispring/
├── beans/          # IoC container implementation
├── context/        # Application context and event system
├── core/           # Core utilities and type conversion
├── aop/            # AOP framework implementation
└── web/            # Web-specific features
```

## 🎯 Detalles de Implementación

### Contenedor IoC
- Sistema de definición y registro de beans
- Inyección de dependencias (constructor y setter)
- Gestión del alcance de beans (singleton, prototipo)
- Manejo de valores de propiedades

### Framework AOP
- Análisis de expresiones pointcut
- Generación dinámica de proxies
- Intercepción y mejora de métodos
- Integración con AspectJ

### Gestión de Recursos
- Abstracción unificada de recursos
- Soporte para classpath y sistema de archivos
- Estrategias de carga de recursos

## 🏗️ Arquitectura

El framework sigue una arquitectura modular con clara separación de responsabilidades:
1. **Contenedor Core**: Gestiona beans y sus dependencias
2. **Módulo AOP**: Maneja la programación orientada a aspectos
3. **Módulo de Contexto**: Proporciona contexto de aplicación y sistema de eventos
4. **Módulo de Recursos**: Gestiona la carga y acceso a recursos

## 🚀 Primeros Pasos

```bash
# Clone the project
git clone https://github.com/ronald-debugging/Ronald-miniSpring.git

# Build the project
mvn clean install

# Run tests
mvn test
```
## 📚 Recursos de Aprendizaje

- Documentación Oficial del Framework Spring
- "Spring Revelado"
- "Análisis Profundo del Código Fuente de Spring"

## 🔄 Estado Actual

Todas las funciones principales han sido implementadas y probadas:
- ✅ Contenedor IoC
- ✅ Framework AOP
- ✅ Ciclo de Vida del Bean
- ✅ Gestión de Recursos
- ✅ Sistema de Eventos
- ✅ Conversión de Tipos
- ✅ Configuración XML
- ✅ Resolución de Dependencias Circulares




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-02

---