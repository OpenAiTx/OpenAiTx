# ronald-miniSpring Framework

Une implémentation légère du framework Spring qui démontre les principes et mécanismes fondamentaux de Spring. Ce projet extrait et simplifie les fonctionnalités essentielles de Spring tout en conservant son architecture fondamentale, ce qui en fait une excellente ressource d'apprentissage pour comprendre les internals de Spring.

## 🚀 Fonctionnalités clés

- **Conteneur IoC** : Implémentation complète de l'injection de dépendances et de l'inversion de contrôle  
- **Framework AOP** : Programmation orientée aspect avec support pour l'interception et l'amélioration des méthodes  
- **Cycle de vie des Beans** : Gestion complète du cycle de vie des beans (instanciation, initialisation, destruction)  
- **Gestion des ressources** : Système flexible de chargement des ressources supportant le classpath et le système de fichiers  
- **Système d'événements** : Implémentation du modèle publish-subscribe pour les événements applicatifs  
- **Conversion de types** : Système robuste de conversion de types pour types basiques et personnalisés  
- **Configuration XML** : Support complet de la configuration XML avec gestion des espaces de noms  

## 💡 Points techniques majeurs

### 1. Résolution des dépendances circulaires  
Mise en œuvre d’un mécanisme sophistiqué de cache à trois niveaux pour gérer les dépendances circulaires :
```java
// Three-level cache structure
Map<String, Object> singletonObjects = new ConcurrentHashMap<>();      // Level 1: Fully initialized beans
Map<String, Object> earlySingletonObjects = new HashMap<>();           // Level 2: Early exposed beans
Map<String, ObjectFactory<?>> singletonFactories = new HashMap<>();    // Level 3: Bean factories
```

### 2. Implémentation AOP
- Génération dynamique de proxy utilisant à la fois JDK et CGLIB
- Support des expressions pointcut AspectJ
- Types de conseils flexibles (Avant, Après, Autour)

### 3. Gestion du cycle de vie des Beans
- Crochets complets du cycle de vie (InitializingBean, DisposableBean)
- Support de BeanPostProcessor pour la personnalisation
- Implémentation de la famille d’interfaces Aware

## 🛠️ Stack Technique

- **Langage** : Java 17
- **Outil de build** : Maven 3.8.1
- **Tests** : JUnit 5
- **Dépendances** :
  - DOM4J pour le parsing XML
  - CGLIB pour le proxy AOP
  - AspectJ pour les expressions pointcut
  - Logback pour la journalisation

## 📋 Structure du projet

```
src/main/java/com/minispring/
├── beans/          # IoC container implementation
├── context/        # Application context and event system
├── core/           # Core utilities and type conversion
├── aop/            # AOP framework implementation
└── web/            # Web-specific features
```

## 🎯 Détails de l'implémentation

### Conteneur IoC
- Système de définition et d'enregistrement des beans
- Injection de dépendances (constructeur et setter)
- Gestion du scope des beans (singleton, prototype)
- Gestion des valeurs des propriétés

### Framework AOP
- Analyse des expressions pointcut
- Génération de proxy dynamique
- Interception et amélioration des méthodes
- Intégration AspectJ

### Gestion des ressources
- Abstraction unifiée des ressources
- Support du classpath et du système de fichiers
- Stratégies de chargement des ressources

## 🏗️ Architecture

Le framework suit une architecture modulaire avec une séparation claire des responsabilités :
1. **Conteneur Core** : Gère les beans et leurs dépendances
2. **Module AOP** : Gère la programmation orientée aspects
3. **Module Contexte** : Fournit le contexte applicatif et le système d'événements
4. **Module Ressources** : Gère le chargement et l'accès aux ressources

## 🚀 Pour commencer

```bash
# Clone the project
git clone https://github.com/ronald-debugging/Ronald-miniSpring.git

# Build the project
mvn clean install

# Run tests
mvn test
```
## 📚 Ressources d'apprentissage

- Documentation officielle du Spring Framework
- "Spring Révélé"
- "Analyse approfondie du code source de Spring"

## 🔄 État actuel

Toutes les fonctionnalités principales ont été implémentées et testées :
- ✅ Conteneur IoC
- ✅ Framework AOP
- ✅ Cycle de vie des Beans
- ✅ Gestion des ressources
- ✅ Système d'événements
- ✅ Conversion de types
- ✅ Configuration XML
- ✅ Résolution des dépendances circulaires




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-02

---