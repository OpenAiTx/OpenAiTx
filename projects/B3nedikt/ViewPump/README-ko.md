[![Maven Central](https://maven-badges.herokuapp.com/maven-central/dev.b3nedikt.viewpump/viewpump/badge.svg)](https://maven-badges.herokuapp.com/maven-central/dev.b3nedikt.viewpump/viewpump)
[![Documentation](https://javadoc.io/badge2/dev.b3nedikt.viewpump/viewpump/javadoc.svg)](https://javadoc.io/doc/dev.b3nedikt.viewpump/viewpump)

# ViewPump 4.0.15

프리/포스트 인플레이션 인터셉터 API를 사용하여 뷰 인플레이션을 가로챌 수 있습니다.

## 시작하기

### 의존성

의존성을 포함하세요:

```groovy
dependencies {

    implementation 'androidx.appcompat:appcompat:1.5.1'

    implementation 'dev.b3nedikt.viewpump:viewpump:4.0.15'
}
```

### 사용법

인터셉터를 정의하세요. 아래는 텍스트뷰의 텍스트 앞에 접두사를 붙이는 다소 임의의 후-인플레이션 인터셉터 예제입니다.

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
아래는 레이아웃의 XML에서 TextView가 정의되었을 때 CustomTextView를 반환하는 사전 인플레이션 인터셉터의 예시입니다.


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

### 설치

`Application` 클래스의 `#onCreate()` 메서드에서 `ViewPump.builder()`에 인터셉터를 추가하고 `ViewPump`를 초기화하세요. 인터셉터의 순서는 요청과 결과의 인터셉터 체인을 형성하기 때문에 중요합니다.

인터셉터는 기본 인플레이션이 발생하는 대신 프로그래밍 방식으로 생성된 뷰를 반환할 수 있으며, 이 경우 이후에 추가된 인터셉터는 건너뛰게 됩니다. 이러한 이유로, 사전 인플레이션 인터셉터보다 사후 인플레이션 인터셉터를 먼저 추가하는 것이 좋습니다.

```java
@Override
public void onCreate() {
    super.onCreate();

    ViewPump.init(new TextUpdatingInterceptor(), new CustomTextViewInterceptor());
    //....
}
```

### 컨텍스트에 주입하기

기본 액티비티에 다음을 추가하세요:

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
실용적인 예제는 제 라이브러리 [Restring](https://github.com/B3nedikt/restring) 또는 [AppLocale](https://github.com/B3nedikt/AppLocale)을 참조하세요.

## 협력자

이 라이브러리는 원래 다음에 의해 만들어졌습니다:

- [@jbarr21](https://github.com/jbarr21)
- [@chrisjenx](https://github.com/chrisjenx)

하지만 제 포크는 거의 모든 코드가 변경되었으며 약간 다른 API를 가지고 있습니다.

## 라이선스

    Copyright 2017 InflationX & Contributors

    Apache License, Version 2.0 (이하 "라이선스")에 따라 라이선스가 부여됩니다.
    이 파일을 라이선스 없이 사용할 수 없습니다.
    라이선스 사본은 아래에서 얻을 수 있습니다.

        http://www.apache.org/licenses/LICENSE-2.0

    적용 가능한 법률에 의해 요구되거나 서면으로 동의하지 않는 한,
    이 소프트웨어는 "있는 그대로" 배포되며,
    명시적이거나 묵시적인 보증 없이 제공됩니다.
    라이선스에서 허용하는 권한 및 제한 사항을 참조하십시오.




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-01

---