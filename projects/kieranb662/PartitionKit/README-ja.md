# Partition Kit

![partition kit logo](https://github.com/kieranb662/PartitionKit/blob/master/partition-kit-logo.png)

最近[10月の注目のAndroidおよびiOSライブラリトップ10](https://medium.com/better-programming/top-10-trending-android-and-ios-libraries-in-october-e7dd18f8b75b)や[アプリを強化する5つのiOSライブラリ](https://medium.com/better-programming/5-ios-libraries-to-enhance-your-app-17ae7ed350db)で紹介されました！

![grid](/nestedGrid.gif)

PartitionKitとは？  
- SwiftUIでの合成可能かつ動的サイズのユーザーインターフェイスコンテンツのニーズに応えるソリューションです。  
- また、私が初めてライブラリ化したソフトウェアなので、優しく扱ってください（ユースケースにも私の心にも）。

PartitionKitが**ではない**もの？  
- PartitionKitはデータの保存形式を扱う手段ではありません。ハードドライブのパーティション分割やその他のフォーマット可能なデータドライブ用ではありません。

## 要件

PartitionKitはデフォルトでSwiftUIフレームワークの動作を必要とするため、以下のプラットフォームのみ対応しています：

* macOS 10.15以上  
* iOS 13以上  
* tvOS 13以上  
* watchOS 6以上  

## プロジェクトへの追加方法

1. GitHubリポジトリからURLを取得  
2. Xcode -> File -> Swift Packages -> Add Package Dependencies  
3. ボックスにURLを貼り付け  
4. 最小バージョン番号を指定（これは新機能なので1.0.0以上が動作します）。

## 2分未満のチュートリアル動画

[![チュートリアル動画: PartitionKitの使い方](https://img.youtube.com/vi/RSnEevQcqjk/0.jpg)](https://www.youtube.com/watch?v=RSnEevQcqjk)

## 使い方 





### 垂直パーティション

1. `Top`に表示したいビュー、`Bottom`に表示したいビュー、およびオプションでパーティションのサイズを変更するために使用する`Handle`を決定します。
2. これを行います
``` Swift
VPart(top: {
    MyTopView()
    }, bottom: {
    MyBottomView()
    }) {
    MyHandle()
}
```

### 水平方向のパーティション

1. `左` に表示したいビュー、`右` に表示したいビュー、およびオプションでパーティションのサイズを変更するために使用する `ハンドル` を決定します。
2. これを行います。
``` Swift
HPart(left: {
    MyLeftView()
    }, right: {
    MyRightView()
    }) {
    MyHandle()
}
```

### GridPartition 

1. 各コーナーに配置するビューを決定します：`TopLeft`、`TopRight`、`BottomLeft`、`BottomRight`、およびオプションでユーザーがビューをドラッグしてサイズ変更できるようにするための `Handle`。
2. これを行います。
``` Swift
    GridPart(topLeft: {
        MyTopLeftView()
        }, topRight: {
        MyTopRightView()
        }, bottomLeft: {
        MyBottomLeftView()
        }, bottomRight: {
        MyBottomRightView()
        }) {
        MyHandle()
}
```


## 例 

以下をコピーして貼り付けてください。ビューの見た目のために名前付き画像を追加しました。私はダークモードを使用しているため、ライトモードの色は異なる場合があります。 

| HPart                   | VPart                   | GridPart                      | NestGrids                              | Mixed                       |
|-------------------------|-------------------------|-------------------------------|----------------------------------------|-----------------------------|
| ![HPart](/hExample.png) | ![VPart](/vExample.png) | ![GridPart](/gridExample.png) | ![Nested Grid](/nestedGridExample.png) | ![Mixed](/nestedExample.png) |



``` Swift
import SwiftUI
import PartitionKit



struct ContentView: View {
    var vExample: some View {
        VPart(top: {
            RoundedRectangle(cornerRadius: 25).foregroundColor(.purple)
        }) {
            Circle().foregroundColor(.yellow)
        }
    }
    
    var hExample: some View {
        HPart(left: {
            RoundedRectangle(cornerRadius: 10).foregroundColor(.blue)
        }) {
            Circle().foregroundColor(.orange)
        }
    }
    
    var nestedExample: some View {
        VPart(top: {
            hExample
        }) {
            vExample
        }
    }
    
    var gridExample: some View {
        GridPart(topLeft: {
            RoundedRectangle(cornerRadius: 25).foregroundColor(.purple)
        }, topRight: {
            Circle().foregroundColor(.yellow)
        }, bottomLeft: {
            Circle().foregroundColor(.green)
        }) {
            RoundedRectangle(cornerRadius: 25).foregroundColor(.blue)
        }
    }
    
    var nestedGridsExample: some View {
        GridPart(topLeft: {
            gridExample
        }, topRight: {
            gridExample
        }, bottomLeft: {
            gridExample
        }) {
            gridExample
        }
    }
    
    var body: some View {
        nestedExample
        
    }
}


struct ContentView_Previews: PreviewProvider {
    static var previews: some View {
        ContentView()
    }
}
```
## Todo 
* コンテナのフレームを超えてハンドルがドラッグされたときにビューが反転するような負のフレーム値を引き起こさないように、パーティションに制約を追加する 
* 初期レイアウトのカスタマイズ性を向上させる 
* 識別可能なデータ要素のリストで初期化できる `List` スタイルのグリッドコレクションレイアウトを追加する 
* 全体的なクリーンアップ、一部のコードは残すつもりはなかったので、そのうち見つけて修正する予定。 






---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-11

---