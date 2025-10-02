# ronald-miniSpring 框架

一个轻量级的 Spring 框架实现，展示了核心的 Spring 原理和机制。该项目提取并简化了 Spring 的基本特性，同时保持其基础架构，是理解 Spring 内部机制的极佳学习资源。

## 🚀 主要特性

- **IoC 容器**：依赖注入和控制反转的完整实现
- **AOP 框架**：支持方法拦截和增强的面向切面编程
- **Bean 生命周期**：全面的 Bean 生命周期管理（实例化、初始化、销毁）
- **资源管理**：支持类路径和文件系统的灵活资源加载系统
- **事件系统**：应用事件的发布-订阅模式实现
- **类型转换**：支持基础和自定义类型的强大类型转换系统
- **XML 配置**：支持命名空间处理的完整 XML 配置

## 💡 技术亮点

### 1. 循环依赖解决
实现了一个复杂的三级缓存机制来处理循环依赖：
```java
// Three-level cache structure
Map<String, Object> singletonObjects = new ConcurrentHashMap<>();      // Level 1: Fully initialized beans
Map<String, Object> earlySingletonObjects = new HashMap<>();           // Level 2: Early exposed beans
Map<String, ObjectFactory<?>> singletonFactories = new HashMap<>();    // Level 3: Bean factories
```
### 2. AOP 实现
- 使用 JDK 和 CGLIB 进行动态代理生成
- 支持 AspectJ 切点表达式
- 灵活的通知类型（前置、后置、环绕）

### 3. Bean 生命周期管理
- 完整的生命周期钩子（InitializingBean，DisposableBean）
- 支持 BeanPostProcessor 定制化
- 实现 Aware 接口族

## 🛠️ 技术栈

- **语言**：Java 17
- **构建工具**：Maven 3.8.1
- **测试**：JUnit 5
- **依赖**：
  - DOM4J 用于 XML 解析
  - CGLIB 用于 AOP 代理
  - AspectJ 用于切点表达式
  - Logback 用于日志记录

## 📋 项目结构


```
src/main/java/com/minispring/
├── beans/          # IoC container implementation
├── context/        # Application context and event system
├── core/           # Core utilities and type conversion
├── aop/            # AOP framework implementation
└── web/            # Web-specific features
```

## 🎯 实现细节

### IoC 容器
- Bean 定义和注册系统
- 依赖注入（构造器和设值器）
- Bean 范围管理（单例，原型）
- 属性值处理

### AOP 框架
- 切点表达式解析
- 动态代理生成
- 方法拦截和增强
- AspectJ 集成

### 资源管理
- 统一资源抽象
- 类路径和文件系统支持
- 资源加载策略

## 🏗️ 架构

框架遵循模块化架构，职责分明：
1. **核心容器**：管理 Bean 及其依赖
2. **AOP 模块**：处理面向切面编程
3. **上下文模块**：提供应用上下文和事件系统
4. **资源模块**：管理资源加载和访问

## 🚀 入门指南

```bash
# Clone the project
git clone https://github.com/ronald-debugging/Ronald-miniSpring.git

# Build the project
mvn clean install

# Run tests
mvn test
```

## 📚 学习资源

- Spring 框架官方文档
- 《Spring 揭秘》
- 《Spring 源码深度分析》

## 🔄 当前状态

所有核心功能已实现并测试：
- ✅ IoC 容器
- ✅ AOP 框架
- ✅ Bean 生命周期
- ✅ 资源管理
- ✅ 事件系统
- ✅ 类型转换
- ✅ XML 配置
- ✅ 循环依赖解决



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-02

---