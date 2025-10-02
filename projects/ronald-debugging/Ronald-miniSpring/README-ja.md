# ronald-miniSpring フレームワーク

コアなSpringの原則と仕組みを示す軽量のSpringフレームワーク実装です。このプロジェクトはSpringの本質的な機能を抽出・簡素化しつつ、その基本的なアーキテクチャを維持しており、Springの内部構造を理解するための優れた学習リソースとなっています。

## 🚀 主な機能

- **IoCコンテナ**: 依存性注入と制御の反転の完全実装
- **AOPフレームワーク**: メソッドのインターセプトと拡張をサポートするアスペクト指向プログラミング
- **Beanライフサイクル**: インスタンス化、初期化、破棄を含む包括的なBeanライフサイクル管理
- **リソース管理**: クラスパスおよびファイルシステムをサポートする柔軟なリソース読み込みシステム
- **イベントシステム**: アプリケーションイベントのためのパブリッシュ・サブスクライブパターン実装
- **型変換**: 基本型およびカスタム型に対応した堅牢な型変換システム
- **XML設定**: ネームスペース処理を含む完全なXML設定サポート

## 💡 技術的ハイライト

### 1. 循環依存性の解決
循環依存性を処理するために高度な三層キャッシュ機構を実装しました：
```java
// Three-level cache structure
Map<String, Object> singletonObjects = new ConcurrentHashMap<>();      // Level 1: Fully initialized beans
Map<String, Object> earlySingletonObjects = new HashMap<>();           // Level 2: Early exposed beans
Map<String, ObjectFactory<?>> singletonFactories = new HashMap<>();    // Level 3: Bean factories
```
### 2. AOPの実装
- JDKおよびCGLIBの両方を使用した動的プロキシ生成
- AspectJポイントカット式のサポート
- 柔軟なアドバイス種類（Before、After、Around）

### 3. Beanライフサイクル管理
- 完全なライフサイクルフック（InitializingBean、DisposableBean）
- カスタマイズ用のBeanPostProcessorサポート
- Awareインターフェース群の実装

## 🛠️ 技術スタック

- **言語**: Java 17
- **ビルドツール**: Maven 3.8.1
- **テスト**: JUnit 5
- **依存関係**:
  - XML解析用のDOM4J
  - AOPプロキシ用のCGLIB
  - ポイントカット式用のAspectJ
  - ロギング用のLogback

## 📋 プロジェクト構成


```
src/main/java/com/minispring/
├── beans/          # IoC container implementation
├── context/        # Application context and event system
├── core/           # Core utilities and type conversion
├── aop/            # AOP framework implementation
└── web/            # Web-specific features
```
## 🎯 実装の詳細

### IoCコンテナ
- ビーン定義と登録システム
- 依存性注入（コンストラクタおよびセッター）
- ビーンスコープ管理（シングルトン、プロトタイプ）
- プロパティ値の処理

### AOPフレームワーク
- ポイントカット式の解析
- 動的プロキシ生成
- メソッドのインターセプトと強化
- AspectJ統合

### リソース管理
- 統一されたリソース抽象化
- クラスパスおよびファイルシステム対応
- リソース読み込み戦略

## 🏗️ アーキテクチャ

フレームワークは関心の分離が明確なモジュラーアーキテクチャに従っています：
1. **コアコンテナ**：ビーンとその依存関係を管理
2. **AOPモジュール**：アスペクト指向プログラミングを処理
3. **コンテキストモジュール**：アプリケーションコンテキストとイベントシステムを提供
4. **リソースモジュール**：リソースの読み込みとアクセスを管理

## 🚀 はじめに


```bash
# Clone the project
git clone https://github.com/ronald-debugging/Ronald-miniSpring.git

# Build the project
mvn clean install

# Run tests
mvn test
```
## 📚 学習リソース

- Spring Framework 公式ドキュメント
- 「Spring Revealed」
- 「Spring ソースコード深堀り解析」

## 🔄 現状

全てのコア機能は実装およびテスト済み：
- ✅ IoC コンテナ
- ✅ AOP フレームワーク
- ✅ Bean ライフサイクル
- ✅ リソース管理
- ✅ イベントシステム
- ✅ 型変換
- ✅ XML 設定
- ✅ 循環依存性の解決




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-02

---