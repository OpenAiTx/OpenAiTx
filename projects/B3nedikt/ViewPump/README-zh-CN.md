[![Maven Central](https://maven-badges.herokuapp.com/maven-central/dev.b3nedikt.viewpump/viewpump/badge.svg)](https://maven-badges.herokuapp.com/maven-central/dev.b3nedikt.viewpump/viewpump)
[![Documentation](https://javadoc.io/badge2/dev.b3nedikt.viewpump/viewpump/javadoc.svg)](https://javadoc.io/doc/dev.b3nedikt.viewpump/viewpump)

# ViewPump 4.0.15

通过预加载/后加载拦截器的API，您可以拦截视图膨胀。

## 快速开始

### 依赖

包含以下依赖：

```groovy
dependencies {

    implementation 'androidx.appcompat:appcompat:1.5.1'

    implementation 'dev.b3nedikt.viewpump:viewpump:4.0.15'
}
```

### 用法

定义你的拦截器。下面是一个比较随意的示例，展示了一个在膨胀后拦截的拦截器，它会给 TextView 中的文本添加前缀。

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
以下是一个预膨胀拦截器的示例，当布局的 XML 中定义了 TextView 时，它会返回一个 CustomTextView。


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

### 安装

在你的 `Application` 类的 `#onCreate()` 方法中，将拦截器添加到 `ViewPump.builder()`，并初始化 `ViewPump`。拦截器的顺序很重要，因为它们组成了请求和结果的拦截链。

拦截器可以选择返回一个程序化实例化的视图，而不是让默认的布局膨胀发生，这种情况下，后添加的拦截器将被跳过。基于此原因，最好先添加后膨胀拦截器，再添加前膨胀拦截器。

```java
@Override
public void onCreate() {
    super.onCreate();

    ViewPump.init(new TextUpdatingInterceptor(), new CustomTextViewInterceptor());
    //....
}
```

### 注入上下文

将以下内容添加到您的基础活动中：

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

有关实际示例，请参阅我的库 [Restring](https://github.com/B3nedikt/restring) 或 [AppLocale](https://github.com/B3nedikt/AppLocale)。

## 合作者

此库最初由以下人员创建：

- [@jbarr21](https://github.com/jbarr21)
- [@chrisjenx](https://github.com/chrisjenx)

不过我的分支几乎更改了所有代码，并且具有稍微不同的 API。

## 许可证

    版权所有 2017 InflationX 及其贡献者

    根据 Apache 许可证 2.0 版本（“许可证”）授权；
    您不得使用此文件，除非符合许可证。
    您可以在以下地址获得许可证副本：

        http://www.apache.org/licenses/LICENSE-2.0

    除非适用法律要求或书面同意，否则按“原样”分发软件，
    不附带任何明示或暗示的保证或条件。
    请参阅许可证以了解管理权限和限制的具体语言。




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-01

---