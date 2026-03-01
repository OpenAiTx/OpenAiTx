[![Maven Central](https://maven-badges.herokuapp.com/maven-central/dev.b3nedikt.viewpump/viewpump/badge.svg)](https://maven-badges.herokuapp.com/maven-central/dev.b3nedikt.viewpump/viewpump)
[![Documentation](https://javadoc.io/badge2/dev.b3nedikt.viewpump/viewpump/javadoc.svg)](https://javadoc.io/doc/dev.b3nedikt.viewpump/viewpump)

# ViewPump 4.0.15

ViewPumpは、プレ/ポストインフレーションインターセプターのAPIを使用してビューのインフレーションをインターセプトできます。

## はじめに

### 依存関係

依存関係を含めます：

```groovy
dependencies {

    implementation 'androidx.appcompat:appcompat:1.5.1'

    implementation 'dev.b3nedikt.viewpump:viewpump:4.0.15'
}
```

### 使い方

インターセプターを定義します。以下は、TextView内のテキストに接頭辞を付ける、やや任意のポストインフレーションインターセプターの例です。

```java
public class TextUpdatingInterceptor implements Interceptor {

  @Override
  public InflateResult intercept(Chain chain) {
    InflateResult result = chain.proceed(chain.request());
    if (result.view() instanceof TextView) {
      // Do something to result.view()
      // You have access to result.context() and result.attrs()
      TextView textView = (TextView) result.view();
      textView.setText("[Prefix] " + textView.getText());
    }
    return result;
  }
}
```
以下は、レイアウトのXMLでTextViewが定義されていた場合にCustomTextViewを返すプリインフレーションインターセプターの例です。


```java
public class CustomTextViewInterceptor implements Interceptor {

  @NotNull
  @Override
  public InflateResult intercept(Chain chain) {
    InflateRequest request = chain.request();
    View view = inflateView(
      request.getName(),
      request.getContext(),
      request.getAttrs()
    );

    if (view != null) {
      return new InflateResult(
        view,
        request.getName(),
        request.getContext(),
        request.getAttrs()
      );
    } else {
      return chain.proceed(request);
    }
  }

  @Nullable
  private View inflateView(String name, Context context, AttributeSet attrs) {
    if ("TextView".equals(name)) {
      return new CustomTextView(context, attrs);
    }
    return null;
  }
}
```

### インストール

`Application`クラスの`#onCreate()`メソッド内で、`ViewPump.builder()`にインターセプターを追加し、`ViewPump`を初期化します。インターセプターの順序は、リクエストと結果のインターセプターチェーンを形成するため重要です。

インターセプターは、デフォルトのインフレーションを行わずにプログラムで生成したビューを返すことを選択でき、その場合は後に追加されたインターセプターはスキップされます。このため、ポストインフレーションのインターセプターをプレインフレーションのインターセプターの前に追加する方が良いです。

```java
@Override
public void onCreate() {
    super.onCreate();

    ViewPump.init(new TextUpdatingInterceptor(), new CustomTextViewInterceptor());
    //....
}
```

### コンテキストに注入する

次の内容をベースアクティビティに追加してください:

```java
public class MainActivity extends AppCompatActivity {

    private AppCompatDelegate appCompatDelegate = null;

    ...

    @NonNull
    @Override
    public AppCompatDelegate getDelegate() {
        if (appCompatDelegate == null) {
            appCompatDelegate = new ViewPumpAppCompatDelegate(
                    super.getDelegate(),
                    this
            );
        }
        return appCompatDelegate;
    }
}
```
実用的な例については、私のライブラリ [Restring](https://github.com/B3nedikt/restring) または [AppLocale](https://github.com/B3nedikt/AppLocale) を参照してください。

## コラボレーター

このライブラリは元々以下の方々によって作成されました：

- [@jbarr21](https://github.com/jbarr21)
- [@chrisjenx](https://github.com/chrisjenx)

私のフォークではほとんどのコードが変更されており、APIも少し異なっています。

## ライセンス

    Copyright 2017 InflationX & Contributors

    Licensed under the Apache License, Version 2.0 (the "License");
    you may not use this file except in compliance with the License.
    You may obtain a copy of the License at

        http://www.apache.org/licenses/LICENSE-2.0

    適用される法律または書面での同意がない限り、
    本ソフトウェアは「現状のまま」提供され、
    明示的または黙示的な保証は一切ありません。
    ライセンスの詳細については、該当するライセンス文書をご覧ください。




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-01

---