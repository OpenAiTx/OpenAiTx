# 자율론(Autology)

Lisp 메타프로그래밍에 대한 핫한 견해인 `Autology`는 자신의 인터프리터에 접근할 수 있는 Lisp입니다.

저는 이 프로젝트에 대해 런던 클로저리안(London Clojurians)에서 강연을 했습니다 (2025-05-13):
[Autology: Writing a self-rewriting Lisp - London Clojurians (YouTube)](https://www.youtube.com/watch?v=ptN53mef_IY)

또한 크라코우에서 열린 람다 데이즈(Lambda Days)에서 같은 강연의 짧은 버전을 발표했습니다 (2025-06-13):
[Autology: Writing a self-rewriting Lisp - Lambda Days (YouTube)](https://www.youtube.com/watch?v=-cppTsLgVbI)

# 이것이 무엇인가?

Autology는 Clojure로 작성된 함수형 인터프리터 Lisp 언어입니다.

Autology 인터프리터 함수는 Autology 프로그램에서 사용할 수 있는 데이터 구조로 정의되며, 변수 `*i*`에 바인딩됩니다.

표현식을 평가해야 할 때마다 Autology는 현재 렉시컬 스코프 실행 환경에서 `*i*`의 현재 값을 가져와 그 값을 사용해 표현식을 평가합니다.

`*i*`의 새로운 값을 바인딩함으로써 프로그램 실행 중에도 Autology 언어의 동작을 변경할 수 있습니다.

# 왜 이것을 했나요?

주로 재미와 멋진 아이디어를 탐구하기 위해서입니다.

Autology는 본질적으로 매우 느리고 자원 집약적이어서 특히 유용한 언어는 아닙니다.

매크로는 Lisp 언어에서 문법이나 동작을 수정하는 일반적인 도구이지만, 보통 컴파일 타임에만 사용할 수 있습니다. Autology는 런타임에 언어를 동적으로 재작성할 수 있도록 합니다.

다른 비 Lisp 언어들도 프로그래머가 문제를 더 명확히 표현할 수 있도록 도메인 특화 언어(DSL)를 정의할 수 있지만, 일반적으로 범위가 제한적입니다. Autology는 언어 문법을 완전히 임의로 재작성할 수 있을 뿐만 아니라, 새로운 기능을 정의하거나 기존 기능을 제거할 수도 있습니다.

# 사용법

프로젝트 루트에 있는 `autology` 스크립트를 사용하여 autology 프로그램을 실행할 수 있습니다:


``` Bash
./autology foo.atl
```
시작하는 데 도움이 되는 여러 예제 프로그램이 제공됩니다:


``` Bash
./autology resources/examples/eval-order-1.atl

./autology resources/examples/eval-order-2.atl
```

인수를 전달하지 않고도 REPL을 실행할 수 있습니다:

``` Bash
./autology
```
@NOTE: REPL은 정말 개선이 필요합니다.

# 무엇을 할 수 있나요?

우선 언어에 함수를 추가하는 것을 좋아할 수 있습니다. Autology는 기본적으로 함수를 제공하지 않지만, `*i*` 심볼을 새로운 인터프리터 함수, 즉 함수를 가진 인터프리터를 나타내는 데이터 구조로 재바인딩할 수 있습니다.


```Clojure
(bind (;; grab a copy of the `:atl/eval-list` section of the
       ;; interpreter which is responsible for evaluating lists.
       original (get-marker *i* :atl/eval-list)

       ;; define a case test+body for use when the list expression
       ;; starts with our function special form, in this case `λ`.
       λ-form (qu (λ (let [[_λ params body] e]
                       (fn [& values]
                         (autology.core/evaluate
                          body
                          (reduce (fn [acc-env [s v]]
                                    (assoc acc-env s v))
                                  env
                                  (zipmap params values)))))))

       ;; rebind `*i*` to be a new interpreter with the
       ;; `:atl/eval-list` section replaced with a version that
       ;; includes our lambda handling special form.
       *i* (replace-marker *i* :atl/eval-list
                           (list :atl/eval-list
                                 (concat (butlast original)
                                         λ-form
                                         (list (last original)))))

       ;; We can now immediately define functions since the
       ;; interpreter will have already been updated to evaluate the
       ;; remaining bindings like this one.
       double (λ (n)
                 (+ n n)))

      ;; Finally we can invoke our new function!
      (double (double (double (double (double 1.3125))))))
```
그 다음에는, 원하는 거의 모든 것을 할 수 있습니다!

- 왜 적용 차수 평가에서 정상 차수 평가로 전환하지 않나요?
- 아마도 언어를 수정하여 계속 전달 스타일을 사용하도록 할까요?
- 자신의 인터프리터뿐만 아니라 Autology 인터프리터에도 접근할 수 있는 메타순환 Lisp를 프로그램 내에 정의하세요.

# 테스트 실행


```bash
clojure -X:test
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-19

---