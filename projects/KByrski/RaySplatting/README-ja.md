# RaySplats: レイトレーシングに基づくガウシアン・スプラッティング
Krzysztof Byrski, Marcin Mazur, Jacek Tabor, Tadeusz Dziarmaga, Marcin Kądziołka, Dawid Baran, Przemysław Spurek <br>

| arXiv |
| :---- |
| RaySplats: Ray Tracing based Gaussian Splatting [https://arxiv.org/pdf/2501.19196.pdf](http://arxiv.org/abs/2501.19196)|

<img src=assets/gif1.gif height="300" class="center"> 
<br>

<table align="center" cellspacing="0" cellpadding="0">
  <tr class="center">
    <td><img src=assets/screenshot1.png height="200" width="300" class="center"></td>
    <td><img src=assets/screenshot92.png height="200" width="300" class="center"></td>
    <td><img src=assets/screenshot10.png height="200" width="300" class="center"> </td>
  </tr>
  </tr class="center">
  <tr class="center">
    <td><img src=assets/screenshot7.png height="200" width="300" ></td>
    <td><img src=assets/screenshot82.png height="200" width="300" ></td>
    <td><img src=assets/screenshot4.png height="200" width="300" class="center"> </td>
  </tr>
</table>

# 特徴
- 球面調和関数を最大次数**4**までサポート。
- トレーニング済みモデルの状態をリアルタイムでプレビュー可能なインタラクティブなWindowsビューア／オプティマイザアプリケーション。
- **PLY**形式でのトレーニング済みモデルの出力をサポート。
- 高効率な純粋ガウシアンレンダラー（埋め込みプリミティブメッシュ近似なし）。
- 便利なテキスト設定ファイルに基づく高度に設定可能なオプティマイザ。
- **Blender**および**COLMAP**データセットの両方をサポート（3DGSによる前処理後）。
- モデルの組み込み評価および設定可能な頻度で*.bmpファイルへの可視化。

# インタラクティブなWindowsビューア／オプティマイザアプリケーションの操作方法

<img src="https://raw.githubusercontent.com/KByrski/RaySplatting/master/assets/app_main_window.png">

- **ダブル左クリック**: **静止カメラ**モードと**フリーローム**モードの切り替え。
- **マウス移動**: **フリーローム**モードでカメラを回転。
- **W / S**: 前進／後退。
- **A / D**: 左 / 右にステップ移動。
- **Spacebar / C**: 上 / 下に移動。
- **[ / ]**: カメラを前 / 次のトレーニングポーズに切り替え。
- **Print Screen**: スクリーンショットを撮影し、24ビットの*.bmpファイルとして保存。

# 前提条件:

- Visual Studio 2019 Enterprise;
- CUDA Toolkit 12.4.1;
- NVIDIA OptiX SDK 8.0.0;

# インタラクティブなWindowsビューア／オプティマイザアプリケーションのビルド

- 新しいWindowsデスクトップアプリケーションプロジェクトを作成し、「RaySplats」と命名する;
- 新規生成されたコードテンプレートを含むRaySplats.cppファイルを削除する;
- **Build Dependencies** -> **Build Customizations...** でインストール済みのCUDAバージョンに対応するチェックボックスを選択する。テスト環境では以下のチェックボックスを選択しました:

  **CUDA 12.4(.targets, .props)**
  
- ディレクトリ「RaySplats」内のすべてのファイルをプロジェクトに追加する;
- プロジェクトのプロパティで **Configuration** を **"Release"**、**Platform** を **"x64"** に設定する;
- **Properties** -> **Configuration Properties** -> **CUDA C/C++** -> **Common** -> **Generate Relocatable Device Code** で **Yes (-rdc=true)** を選択する;
- ファイル「shaders.cuh」について、**Properties** -> **Configuration Properties** -> **General** -> **Item Type** を **"CUDA C/C++"** に設定する;
- ファイル「shaders.cuh」、「shaders_SH0.cu」、「shaders_SH1.cu」、「shaders_SH2.cu」、「shaders_SH3.cu」、「shaders_SH4.cu」について、**Properties** -> **Configuration Properties** -> **CUDA C/C++** -> **Common** で:
  - **Compiler Output (obj/cubin)** のサフィックスを **".obj"** から **".ptx"** に変更する;
  - **Generate Relocatable Device Code** を **No** に設定する;
  - **NVCC Compilation Type** で **Generate device-only .ptx file (-ptx)"** を選択する;
- **Properties** -> **Configuration Properties** -> **VC++ Directories** -> **Include Directories** にOptiXの「include」ディレクトリのパスを追加する。テスト環境では以下のパスを追加しました:
  ```plaintext
  "C:\ProgramData\NVIDIA Corporation\OptiX SDK 8.0.0\include"
  ```
- **プロパティ** -> **構成プロパティ** -> **CUDA C/C++** -> **デバイス** -> **コード生成** にGPUのコンピュート能力とマイクロアーキテクチャのバージョンを入力します。テストシステムのRTX 4070 GPUでは、次のように入力しました:
  ```plaintext
  "compute_89,sm_89"
  ```
- **プロパティ** -> **構成プロパティ** -> **リンカー** -> **入力** -> **追加の依存ファイル** に3つの新しい行を追加します:
  ```plaintext
  "cuda.lib"
  ```
  ```plaintext
  "cudart.lib"
  ```
  ```plaintext
  "cufft.lib"
  ```
- InitializeOptiXRenderer.cuファイル内の2つの異なるコードブロックそれぞれで:
  ```plaintext
  if      constexpr (SH_degree == 0) f = fopen("C:/Users/pc/source/repos/RaySplats/RaySplats/x64/Release/shaders_SH0.cu.ptx", "rb");
  else if constexpr (SH_degree == 1) f = fopen("C:/Users/pc/source/repos/RaySplats/RaySplats/x64/Release/shaders_SH1.cu.ptx", "rb");
  else if constexpr (SH_degree == 2) f = fopen("C:/Users/pc/source/repos/RaySplats/RaySplats/x64/Release/shaders_SH2.cu.ptx", "rb");
  else if constexpr (SH_degree == 3) f = fopen("C:/Users/pc/source/repos/RaySplats/RaySplats/x64/Release/shaders_SH3.cu.ptx", "rb");
  else if constexpr (SH_degree == 4) f = fopen("C:/Users/pc/source/repos/RaySplats/RaySplats/x64/Release/shaders_SH4.cu.ptx", "rb");
  ```
  and
  ```plaintext
  if      constexpr (SH_degree == 0) f = fopen("C:/Users/pc/source/repos/RaySplats/RaySplats/x64/Release/shaders_SH0.cu.ptx", "rt");
  else if constexpr (SH_degree == 1) f = fopen("C:/Users/pc/source/repos/RaySplats/RaySplats/x64/Release/shaders_SH1.cu.ptx", "rt");
  else if constexpr (SH_degree == 2) f = fopen("C:/Users/pc/source/repos/RaySplats/RaySplats/x64/Release/shaders_SH2.cu.ptx", "rt");
  else if constexpr (SH_degree == 3) f = fopen("C:/Users/pc/source/repos/RaySplats/RaySplats/x64/Release/shaders_SH3.cu.ptx", "rt");
  else if constexpr (SH_degree == 4) f = fopen("C:/Users/pc/source/repos/RaySplats/RaySplats/x64/Release/shaders_SH4.cu.ptx", "rt");
  ```
  提供されたパスを、HDD上の*.ptxコンパイル済みシェーダーファイルのパスに置き換えてください。

# 最初のモデルのトレーニング（Blenderデータセット）：

- 3DGSを使用して、Blenderデータセット（例：「NeRF synthetic」セットの「lego」）のいくつかの小さなイテレーション数（例：100）でモデルをトレーニングします；
- データセットのメインディレクトリにある「train」と「test」のサブディレクトリ内のすべてのファイルを、名前を変更せずに24ビット*.bmpファイル形式に変換します；
- 設定ファイル「config.txt」をプロジェクトのメインディレクトリにコピーします。テストシステムでは、次のディレクトリにコピーしました：
  ```plaintext
  "C:\Users\<Windows username>\source\repos\RaySplats\RaySplats"
  ```
- 設定ファイルの4行目と5行目で、データセットのメインディレクトリの場所と、短時間のモデル事前学習後に得られた出力3DGS *.plyファイルの場所を指定します（**重要！** 事前学習に使用した球面調和関数の次数と、設定ファイルの7行目で指定された目標次数は一致している必要はありません）；
- 設定ファイルの13～15行目で、以下の式を用いて事前学習で使用した背景色に一致する背景色を指定します：
  
  R' = (R + 0.5) / 256<br>
  G' = (G + 0.5) / 256<br>
  B' = (B + 0.5) / 256<br>

  ここで、R、G、Bは0～255の範囲の非負整数の背景色座標です。
- Visual Studio IDEから「RaySplats」プロジェクトを実行します；

# RaySplatting ビューア
![image](https://github.com/user-attachments/assets/9a9d61cb-f54a-4301-8a52-4c2d0ce2cc72)
![](https://raw.githubusercontent.com/KByrski/RaySplatting/master/assets/tutorial.mp4)

これは、レイトレーシング対応のユーザーがロードした追加オブジェクトを含む**RaySplatting**を可視化するための軽量でユーザーフレンドリーなビューアです。ビューアはシーンへの**OBJ**および**PLY（ASCII形式）**ファイルのシームレスな統合を可能にします。  

現在のマテリアルシステムは、**反射的**または**ガラス状**に設計されたモデルに最適化されており、リアルな光の相互作用による高品質なビジュアルレンダリングに理想的です。  

## システム要件  

このビューアを使用するには、以下のシステム要件を満たしていることを確認してください：  

- **オペレーティングシステム**：Windows  
- **GPU**：NVIDIA RTX 20xxシリーズ以上（**RTX 30xx以上推奨**）  
- **CUDAバージョン**：12.4以上  
- **必要なDLL**：以下のファイルをディレクトリに配置してください：  
  ```plaintext
  C:\Program Files\NVIDIA GPU Computing Toolkit\CUDA\v12.4\bin
  ```
  - `cudart64_12.dll`  
  - `cufft64_11.dll`  

## インストールと使用方法  

1. 提供された**ZIPファイル**をダウンロードします。  [ZIPをダウンロード](https://drive.google.com/file/d/1XPivZb6-dVtuwQ3T9UrxOF2gTTnerGhp/view?usp=sharing)
2. 内容を解凍します。  
3. **exeファイル**を実行します—追加のセットアップは不要です！  
4. **mesh_config.txt**でメッシュのプロパティを変更します。  
5. `config.txt`内の**PLYファイルのパス**を編集してベースシーンを変更します。  

## 操作方法  

- インタラクティブなWindowsビューワー／オプティマイザーアプリケーションと全く同じです。

## 今後の機能  

現在、以下の新機能を積極的に開発しています：  
- **強化されたメッシュ変換**（`mesh_config.txt`を超えたスケーリング、回転、位置編集）  
- レンダリングシーンの**スクリーンショット撮影**  
- 異なる視点をシームレスに切り替えるための**ビュー設定プリセット**  
- **その他多数！**  

今後のアップデートと改善にご期待ください！





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-26

---