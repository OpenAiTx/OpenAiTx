<h1 align="center">
  <a href="https://reactnative.dev/">
    React Native
  </a>
</h1>

<p align="center">
  <strong>一度学べば、どこでも書ける：</strong><br>
  Reactでモバイルアプリを構築しましょう。
</p>

<p align="center">
  <a href="https://github.com/facebook/react-native/blob/HEAD/LICENSE">
    <img src="https://img.shields.io/badge/license-MIT-blue.svg" alt="React NativeはMITライセンスでリリースされています。" />
  </a>
  <a href="https://www.npmjs.org/package/react-native">
    <img src="https://img.shields.io/npm/v/react-native?color=brightgreen&label=npm%20package" alt="現在のnpmパッケージバージョン。" />
  </a>
  <a href="https://reactnative.dev/docs/contributing">
    <img src="https://img.shields.io/badge/PRs-welcome-brightgreen.svg" alt="PRs歓迎！" />
  </a>
  <a href="https://twitter.com/intent/follow?screen_name=reactnative">
    <img src="https://img.shields.io/twitter/follow/reactnative.svg?label=Follow%20@reactnative" alt="@reactnativeをフォロー" />
  </a>
</p>

<h3 align="center">
  <a href="https://reactnative.dev/docs/getting-started">クイックスタート</a>
  <span> · </span>
  <a href="https://reactnative.dev/docs/tutorial">基本を学ぶ</a>
  <span> · </span>
  <a href="https://reactnative.dev/showcase">ショーケース</a>
  <span> · </span>
  <a href="https://reactnative.dev/docs/contributing">貢献する</a>
  <span> · </span>
  <a href="https://reactnative.dev/help">コミュニティ</a>
  <span> · </span>
  <a href="https://github.com/facebook/react-native/blob/HEAD/.github/SUPPORT.md">サポート</a>
</h3>

React Nativeは、[**React**][r] の宣言的UIフレームワークをiOSとAndroidに提供します。React Nativeを使用すると、ネイティブUIコントロールを利用し、ネイティブプラットフォームへ完全にアクセスできます。

- **宣言的。** ReactはインタラクティブなUIの作成を簡単にします。宣言的なビューにより、コードはより予測可能でデバッグしやすくなります。
- **コンポーネントベース。** 状態を管理するカプセル化されたコンポーネントを構築し、それらを組み合わせて複雑なUIを作成できます。
- **開発者の生産性。** ローカルでの変更を数秒で確認できます。JavaScriptコードの変更は、ネイティブアプリを再ビルドせずにライブリロード可能です。
- **移植性。** iOS、Android、[その他のプラットフォーム][p]間でコードを再利用できます。

React Nativeは多くの企業や個人のコアコントリビューターによって開発・サポートされています。詳細は[エコシステムの概要][e]をご覧ください。

[r]: https://react.dev/
[p]: https://reactnative.dev/docs/out-of-tree-platforms
[e]: https://github.com/facebook/react-native/blob/HEAD/ECOSYSTEM.md

## 目次

- [動作要件](#-requirements)
- [最初のReact Nativeアプリを作る](#-building-your-first-react-native-app)
- [ドキュメント](#-documentation)
- [アップグレード](#-upgrading)
- [貢献方法](#-how-to-contribute)
- [行動規範](#code-of-conduct)
- [ライセンス](#-license)

## 📋 動作要件

React NativeアプリはiOS 15.1およびAndroid 7.0（API 24）以降をターゲットにできます。開発用OSとしてWindows、macOS、Linuxを利用できますが、iOSアプリのビルドと実行はmacOSに限定されます。[Expo](https://expo.dev)などのツールでこの制限を回避できます。

## 🎉 最初のReact Nativeアプリを作る

[クイックスタートガイド](https://reactnative.dev/docs/getting-started)に従ってください。React Nativeの推奨インストール方法はプロジェクトによって異なります。以下に、よくあるシナリオごとの簡単なガイドを掲載しています。

- [React Nativeを試してみる][hello-world]
- [新しいアプリケーションの作成][new-app]
- [既存アプリケーションへのReact Native追加][existing]

[hello-world]: https://snack.expo.dev/@samples/hello-world
[new-app]: https://reactnative.dev/docs/getting-started
[existing]: https://reactnative.dev/docs/integration-with-existing-apps

## 📖 ドキュメント

React Nativeの完全なドキュメントは[公式ウェブサイト][docs]にあります。

React Nativeのドキュメントでは、React Native固有のコンポーネント、API、トピックについて解説しています。React NativeとReact DOMで共通するReact APIについては、[React公式ドキュメント][r-docs]を参照してください。

React Nativeのドキュメントとウェブサイトのソースコードは、別リポジトリの[**@facebook/react-native-website**][repo-website]で管理されています。

[docs]: https://reactnative.dev/docs/getting-started
[r-docs]: https://react.dev/learn
[repo-website]: https://github.com/facebook/react-native-website

## 🚀 アップグレード

React Nativeの新バージョンへアップグレードすると、より多くのAPI、ビュー、開発者ツール、その他の機能を利用できます。手順は[アップグレードガイド][u]をご覧ください。

React Nativeのリリースについては[このディスカッションリポジトリ](https://github.com/reactwg/react-native-releases/discussions)でも議論されています。

[u]: https://reactnative.dev/docs/upgrading
[repo-releases]: https://github.com/react-native-community/react-native-releases

## 👏 貢献方法

このリポジトリの主な目的は、React Nativeコアの進化を継続することです。本プロジェクトへの貢献をできるだけ簡単で透明にしたいと考えており、バグ修正や改善へのコミュニティからの貢献に感謝しています。React Nativeの改善に参加する方法については、以下をご覧ください。

### [行動規範][code]

Facebookは、プロジェクト参加者が遵守すべき行動規範を採用しています。
[全文][code]をお読みいただき、許容される行為・されない行為をご理解ください。

[code]: https://code.fb.com/codeofconduct/

### [コントリビューションガイド][contribute]

[**コントリビューションガイド**][contribute]をお読みいただき、開発プロセスやバグ修正・改善の提案方法、React Nativeのビルドやテスト方法をご確認ください。

[contribute]: https://reactnative.dev/docs/contributing

### [オープンソースロードマップ][roadmap]

React Nativeのビジョンについては[**ロードマップ**][roadmap]でご覧いただけます。

[roadmap]: https://github.com/facebook/react-native/wiki/Roadmap

### 初心者向けIssues

限定的な範囲で修正可能なバグをまとめた[初心者向けIssues][gfi]リストがあります。最初の貢献や経験を積むのに最適です。

[gfi]: https://github.com/facebook/react-native/labels/good%20first%20issue

### ディスカッション

より大きな議論や提案は、[**@react-native-community/discussions-and-proposals**][repo-meta]で行われています。

[repo-meta]: https://github.com/react-native-community/discussions-and-proposals

## 📄 ライセンス

React Nativeは[LICENSE][l]ファイルに記載の通りMITライセンスです。

[l]: https://github.com/facebook/react-native/blob/main/LICENSE

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---