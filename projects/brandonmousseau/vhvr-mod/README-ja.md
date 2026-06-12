# VHVR-Mod
これはPCゲーム「Valheim」にネイティブVRサポートをUnityとSteamVRのOpenVRを使って追加する実験的なモッドです。

モッドは[Nexus Mods](https://www.nexusmods.com/valheim/mods/847)からダウンロードできます！

進捗の開発ログは[YouTube](https://www.youtube.com/playlist?list=PL9EDvRwka57-swWbcOAq0lhIp5jSFPg-u)でご覧ください。

[Flatscreen to VR Modding Discord](https://discord.gg/ZFSCSDe)に参加しましょう。

## このパッケージには何が含まれていますか？
### Unityプロジェクト
このプロジェクトは主に、モッドで使用される必要なAssetBundleを生成するためのアセットジェネレーターとして存在し、適切な環境でSteamVRおよびUnity XRライブラリをビルドする手段でもあります。

Unityパッケージ内でいくつかのアセットが生成されていますが、最も重要なものは以下です：
* SteamVR Playerプレハブ：このプレハブはSteamVRを正しく使用するために必要なスクリプトをすべて含むUnityのGameObject階層です。階層内にカメラが含まれており、メインゲームのカメラと差し替えられます。カメラはHMDに表示される立体視3Dを使用するように設定されています。
* UnityとOpenVRのアセット：これらはゲーム起動時にUnityのXRエンジンを正しく起動するために必要なアセットです。
* [Amplify Occlusion](https://github.com/AmplifyCreations/AmplifyOcclusion) グラフィックスポストプロセッサー：ゲーム内のSSAOグラフィックス効果の高性能代替として使用されます。

### ValheimVRMod C#プロジェクト
このプロジェクトはモッドのコードの大部分を含んでいます。以下の機能を実装するクラス／UnityのMonoBehaviourスクリプトが含まれます：
* Unityの/OpenVRのXRエンジンを初期化する
* AssetBundleからSteamVRプレハブをインスタンス化する
* ゲームのメインカメラをVRカメラに差し替え、適切に配置する
* ゲームのGUIをVRに変換する
* モーションコントロールを実装する（作業中）

### 要件
このモッドは[BepInExPack Valheim](https://valheim.thunderstore.io/package/denikson/BepInExPack_Valheim/)を必要とします。BepInExはUnityゲーム用のモッドフレームワークで、モッダーがゲームのランタイムにコードを注入できるようにします。また、C#ライブラリの既存メソッドをパッチするためのツールである[Harmony](https://harmony.pardeike.net/articles/intro.html)も含まれています。

さらに、OpenVR/SteamVRをサポートするHMDが必要です。

### その他の情報
これは実験的なモッドであり、バグや不具合が多く含まれる可能性が非常に高いです。さらに、Valheimは現在アーリーアクセスゲームなので、ゲームのアップデートでこのモッドが動作しなくなる可能性も高いです。修正が行われるまで辛抱強くお待ちいただき、問題があればぜひ報告してください :)

ValheimはVR用に作られていないため、この実装はVR専用に作られたゲームほど快適ではありません。VRで気分が悪くなりやすい場合は、このモッドはあまり向いていないかもしれません。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-12

---