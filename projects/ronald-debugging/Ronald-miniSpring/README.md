# ronald-miniSpring Framework

A lightweight Spring framework implementation that demonstrates core Spring principles and mechanisms. This project extracts and simplifies Spring's essential features while maintaining its fundamental architecture, making it an excellent learning resource for understanding Spring's internals.

## 🚀 Key Features

- **IoC Container**: Complete implementation of dependency injection and inversion of control
- **AOP Framework**: Aspect-oriented programming with support for method interception and enhancement
- **Bean Lifecycle**: Comprehensive bean lifecycle management (instantiation, initialization, destruction)
- **Resource Management**: Flexible resource loading system supporting classpath and file system
- **Event System**: Publish-subscribe pattern implementation for application events
- **Type Conversion**: Robust type conversion system for basic and custom types
- **XML Configuration**: Full XML configuration support with namespace handling

## 💡 Technical Highlights

### 1. Circular Dependency Resolution
Implemented a sophisticated three-level cache mechanism to handle circular dependencies:
```java
// Three-level cache structure
Map<String, Object> singletonObjects = new ConcurrentHashMap<>();      // Level 1: Fully initialized beans
Map<String, Object> earlySingletonObjects = new HashMap<>();           // Level 2: Early exposed beans
Map<String, ObjectFactory<?>> singletonFactories = new HashMap<>();    // Level 3: Bean factories
```

### 2. AOP Implementation
- Dynamic proxy generation using both JDK and CGLIB
- Support for AspectJ pointcut expressions
- Flexible advice types (Before, After, Around)

### 3. Bean Lifecycle Management
- Complete lifecycle hooks (InitializingBean, DisposableBean)
- BeanPostProcessor support for customization
- Aware interface family implementation

## 🛠️ Technical Stack

- **Language**: Java 17
- **Build Tool**: Maven 3.8.1
- **Testing**: JUnit 5
- **Dependencies**:
  - DOM4J for XML parsing
  - CGLIB for AOP proxy
  - AspectJ for pointcut expressions
  - Logback for logging

## 📋 Project Structure

```
src/main/java/com/minispring/
├── beans/          # IoC container implementation
├── context/        # Application context and event system
├── core/           # Core utilities and type conversion
├── aop/            # AOP framework implementation
└── web/            # Web-specific features
```

## 🎯 Implementation Details

### IoC Container
- Bean definition and registration system
- Dependency injection (constructor and setter)
- Bean scope management (singleton, prototype)
- Property value handling

### AOP Framework
- Pointcut expression parsing
- Dynamic proxy generation
- Method interception and enhancement
- AspectJ integration

### Resource Management
- Unified resource abstraction
- Classpath and file system support
- Resource loading strategies

## 🏗️ Architecture

The framework follows a modular architecture with clear separation of concerns:
1. **Core Container**: Manages beans and their dependencies
2. **AOP Module**: Handles aspect-oriented programming
3. **Context Module**: Provides application context and event system
4. **Resource Module**: Manages resource loading and access

## 🚀 Getting Started

```bash
# Clone the project
git clone https://github.com/ronald-debugging/Ronald-miniSpring.git

# Build the project
mvn clean install

# Run tests
mvn test
```

## 📚 Learning Resources

- Spring Framework Official Documentation
- "Spring Revealed"
- "Spring Source Code Deep Analysis"

## 🔄 Current Status

All core features have been implemented and tested:
- ✅ IoC Container
- ✅ AOP Framework
- ✅ Bean Lifecycle
- ✅ Resource Management
- ✅ Event System
- ✅ Type Conversion
- ✅ XML Configuration
- ✅ Circular Dependency Resolution

