[![Maven Central](https://maven-badges.herokuapp.com/maven-central/dev.b3nedikt.viewpump/viewpump/badge.svg)](https://maven-badges.herokuapp.com/maven-central/dev.b3nedikt.viewpump/viewpump)
[![Documentation](https://javadoc.io/badge2/dev.b3nedikt.viewpump/viewpump/javadoc.svg)](https://javadoc.io/doc/dev.b3nedikt.viewpump/viewpump)

# ViewPump 4.0.15

View inflation you can intercept using an API of pre/post-inflation interceptors.

## Getting started

### Dependency

Include the dependencies:

```groovy
dependencies {

    implementation 'androidx.appcompat:appcompat:1.5.1'

    implementation 'dev.b3nedikt.viewpump:viewpump:4.0.15'
}
```

### Usage

Define your interceptor. Below is a somewhat arbitrary example of a post-inflation interceptor that prefixes the text in a TextView.

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
Below is an example of a pre-inflation interceptor that returns a CustomTextView when a TextView was defined in the layout's XML.


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

### Installation

Add your interceptors to the `ViewPump.builder()`, in your `Application` class in the `#onCreate()` method and `init` the `ViewPump`. The order of the interceptors is important since they form the interceptor chain of requests and results.

An interceptor may choose to return a programmatically instantiated view rather than letting the default inflation occur, in which case interceptors added after it will be skipped. For this reason, it is better to add your post-inflation interceptors before the pre-inflation interceptors

```java
@Override
public void onCreate() {
    super.onCreate();

    ViewPump.init(new TextUpdatingInterceptor(), new CustomTextViewInterceptor());
    //....
}
```

### Inject into Context

Add the following to your base activity:

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

For practical examples see my libraries [Restring](https://github.com/B3nedikt/restring) or [AppLocale](https://github.com/B3nedikt/AppLocale).

## Collaborators

This library was originally created by:

- [@jbarr21](https://github.com/jbarr21)
- [@chrisjenx](https://github.com/chrisjenx)

My fork has nearly all the code changed though and has a slightly different API.

## Licence

    Copyright 2017 InflationX & Contributors

    Licensed under the Apache License, Version 2.0 (the "License");
    you may not use this file except in compliance with the License.
    You may obtain a copy of the License at

        http://www.apache.org/licenses/LICENSE-2.0

    Unless required by applicable law or agreed to in writing, software
    distributed under the License is distributed on an "AS IS" BASIS,
    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    See the License for the specific language governing permissions and
    limitations under the License.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-01

---