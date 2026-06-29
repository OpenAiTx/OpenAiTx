[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![CI - Build and Test](https://github.com/Tillman32/CleanArchitecture/actions/workflows/ci.yml/badge.svg)](https://github.com/Tillman32/CleanArchitecture/actions/workflows/ci.yml)
[![Deploy to GitHub Pages](https://github.com/Tillman32/CleanArchitecture/actions/workflows/pages.yml/badge.svg)](https://github.com/Tillman32/CleanArchitecture/actions/workflows/pages.yml)

![](https://raw.githubusercontent.com/Tillman32/CleanArchitecture/master/./src/CleanArchitecture.WASM/Preview.png)

[LIVE DEMO - WASM on GitHub Pages](https://tillman32.github.io/CleanArchitecture/)

# すべての背後にある動機

これは一体何のためか？そうですね、Bob Rossを紹介する以外に…アーキテクチャについて話すときに参照できる「現実の」アプリケーションを持つのが賢いと思ったのです。標準を設定し、複製し、次のすべての .Net Core プロジェクトで利用できるものが欲しかったのです。すべてのソフトウェア（とワイン）のように、これは時間とともに改善されていきます。

また、「Uncle Bob」（Robert C. Martin）と名前が似ているのも適切だと思いました。このプロジェクトは彼のアーキテクチャに合わせようと試みています。[彼のウェブサイトに記載されているものはこちらです。](https://blog.cleancoder.com/uncle-bob/2012/08/13/the-clean-architecture.html)

これに合わせてブログ記事も書きました：[https://www.brandontillman.com/blog/clean-architecture-dotnet](https://www.brandontillman.com/blog/clean-architecture-dotnet)

# 重要なポイント：

### :trident: N層アーキテクチャ

3層のアプローチで、同じコアのビジネス機能/バックエンドを使う複数のUIを設定します。

### :open_file_folder: 関心の分離

「単一責任」（["Single Responsibility"](http://deviq.com/single-responsibility-principle/)）原則に密接に関連する関心の分離（SoC）は、アイデアを同じ場所にまとめないことでコードの保守性を高めます。変更があった場合、SoCは変更が機能セットに限定され、アプリケーション全体に広がらないように助けます。

### :droplet: 漏れない抽象化

インターフェースを使用することで、漏れのある抽象化を避け、コードの使用方法をより良く制御できます。逆に言えば、コードの利用者は実装の詳細を知る必要がなく、単にインターフェースやクラスを使うだけで済みます。

### :microscope: テスト可能

密結合したコードのテストはほぼ不可能です。SoC原則に従い、インターフェースを使用することで、コードはよりテストしやすくなります。

### :electric_plug: モジュール化

将来的にコードの修正が容易になる理由はいくつかあります。関心の分離により、アプリケーション全体の変更やテストが減ります。特定の機能セットを構築しても、他のコードを変更せずに済みます。

### :wrench: 保守可能

コードはクリーンアーキテクチャのパターンに従うことで、本質的に保守性が高くなります。  
他の開発者はクリーンな分離の利点を理解し、それに従うでしょう。

# 主な使用技術

- [.Net](https://dotnet.microsoft.com/)
- [Blazor WASM](https://www.learnblazor.com/)
- [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/)
- [AutoMapper](https://automapper.org/)
- [NLog](https://nlog-project.org/)

### :star2: スターを付けてください！  
このプロジェクトが気に入ったり、学習やソリューションの開始に使用している場合は、スターを付けていただけると嬉しいです。ありがとうございます！

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-29

---