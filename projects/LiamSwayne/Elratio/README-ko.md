# EʅɾαՇισ
<a href="https://liamswayne.github.io/elratio/security.mp4">
    <img src="https://img.shields.io/badge/Visitor_IP_address-66.122.23.197-blue" height="25">
</a>

# ~~최종 업데이트.~~ [역최종 업데이트.](https://github.com/LiamSwayne/Elratio/blob/main/announcements.md)

루비의 성능과 펄의 가독성을 결합한 파이썬 기반 프로그래밍 언어입니다.

> "어셈블리의 해답"

자신만의 Elratio 프로그램을 작성하려면 [template.py](https://raw.githubusercontent.com/LiamSwayne/Elratio/main/template.py)를 다운로드하여 지정된 공간에 프로그램을 작성하세요.

# 특징
Elratio는 모든 다른 언어에 비해 수많은 장점을 제공합니다!

## 대담한 새로운 공백 처리
현대 언어는 빈 줄이 비어 있음을 표시하지 않습니다. Elratio는 `empty` 키워드로 공백을 대담하게 새 방향으로 이끕니다.
###### 파이썬/자바/씨/고/자바스크립트:
<pre>

</pre>
###### Elratio:
```python
empty;
```
Elratio는 빈 줄을 허용하지 않습니다. 모든 빈 줄에는 키워드 `empty`가 포함되어야 합니다.

## 명확한 줄 및 프로그램 종료
많은 현대 프로그래밍 언어들은 트렌드를 따라가며 무미건조한 줄 끝 구문을 대중화했습니다. 반면 Elratio는 명확하게 정의된 `;` 기호를 사용하여 줄 끝을 정의합니다 (단, `:`로 끝나는 줄 제외).

###### 파이썬:
<pre>
if True:
    pass
</pre>

###### Elratio:
```python
    if True:
pass;
```
또한, 모든 프로그램은 반드시 `end` 키워드로 끝나야 합니다. 다시 한 번, Elratio가 경쟁을 압도합니다.
###### Python/R/JavaScript:
<pre>

</pre>
###### Elratio:

```python
end;
```

## 반전된 들여쓰기
main에서 실행된 라인을 한 단계 낮추어야 해서, 반전된 들여쓰기 시스템을 도입했습니다.

```python
        while True:
    if True:
1000;
```
이제 더 이상 주변의 놀라운 줄들을 의심하지 않고 들여쓰기에 대해 걱정할 필요가 없습니다.

## 창조 그 자체의 힘
Elratio는 `create` 키워드를 사용하여 신의 역할을 할 수 있게 합니다. 숫자를 생성하여 무한한 수치 가능성을 열어보세요.
<pre>
SystemOutPrint(7);
>>> 1행에서 오류 발생: SystemOutPrint(7);
>>> 농담인가요? 숫자 "7"이 아직 생성되지 않았습니다. 먼저 "create 7"을 사용하세요.
</pre>

```python
create 7;
SystemOutPrint(7);
>>> 7
```
하지만 숫자를 생성하기 전에, 반드시 `create`를 생성해야 합니다.

```python
create create;
```
많은 언어들이 클래스 생성을 명확히 표시하지 않지만, 다시 한 번 Elratio에게는 계속되는 대성공입니다.

```python
    create class book:
pass;
```

## 획기적인 주석
`#` 기호는 오랫동안 특정 행이 주석임을 나타내고 실행되지 않아야 함을 표시하는 데 사용되어 왔습니다. Elratio를 설계할 때 우리는 주석을 처음부터 다시 구축하여 `comment` 키워드를 도입했습니다.
```python
comment rewrite this segment;
```
주석을 다는 방법은 `comment`, 스페이스바, 주석 내용, 세미콜론만 있으면 매우 간단합니다.

## `def` 재정의하기
`def`는 즉석에서 편리할 수 있지만 스파게티 코드로 이어질 수 있어, 우리는 이를 `definition`으로 대체했습니다.
```python
    definition doNothing:
pass;
```
## 향상된 출력 구문
파이썬은 출력할 때 불명확한 구문인 `print()`를 사용합니다. 엘라트리오는 명확성을 위해 `systemOutPrint()`를 사용합니다.
<pre>
print(10);
>>> 나는 원칙의 컴파일러입니다. print()를 허용하지 않습니다. 대신 systemOutPrint()를 사용하세요.
</pre>

```python
systemOutPrint(10);
>>> 10
```
이 변경에 영감을 준 자바에게 감사할 수 있습니다.

## 컴파일러의 개인화된 피드백
Elratio는 차세대 문자열 기술을 활용하여 사용자에게 고유하고 설명적인 오류 메시지를 제공합니다.
<pre>
>>> 빈 프로그램입니다. 다음에는 그런 쓰레기 보내지 마세요, 바보야!
</pre>
<pre>
>>> 31행 오류: 비어 있음
>>> 콜론으로 끝나지 않는 문장은 ASCII (2^6)-5로 끝나야 합니다.
</pre>
<pre>
>>> 42행 실수: print(44);
>>> 바보야? 숫자 "4"는 아직 생성되지 않았어. 먼저 "create 4"를 사용해.
</pre>

# 예제
[examples](examples) 폴더에서 예제 프로그램을 찾을 수 있습니다. 다음은 Elratio로 작성된 시간 출력 프로그램 예제입니다:
```python
        comment imports;
        import time;
        comment create number;
        create create;
        create 1;
        empty;
        definition print_formatted_time(current_time, format_string):
    formatted_time = time.strftime(format_string, current_time);
    systemOutPrint("Formatted time:", formatted_time);
    empty;
        definition main():
    systemOutPrint("Welcome to the Simple Time Printer!");
    systemOutPrint("Select an option:");
    create 2;
    systemOutPrint("1. Print current time in default format");
    systemOutPrint("2. Print current time in custom format");
    choice = input("Enter your choice: ");
    empty;
    comment get the current time;
    current_time = time.localtime();
    empty;
    if choice == 1:
comment print the time with formatting;
print_formatted_time(current_time, "%Y-%m-%d %H:%M:%S");
    elif choice == 2:
custom_format = input("Enter your custom format (e.g., %Y/%m/%d %I:%M %p): ");
print_formatted_time(current_time, custom_format);
    else:
systemOutPrint("Invalid choice.");
    empty;
        if __name__ == "__main__":
    main();
        end;
>>> Welcome to the Simple Time Printer!
>>> Select an option:
>>> 1. Print current time in default format
>>> 2. Print current time in custom format
>>> Enter your choice: 1
>>> ('Formatted time:', '2023-08-26 00:34:10')
```
다시 한 번 말씀드리자면, [template.py](https://raw.githubusercontent.com/LiamSwayne/Elratio/main/template.py)를 다운로드하여 지금 **바로** Elratio에서 코딩을 시작할 수 있습니다!


# 패키지 지원
Elratio는 모든 기존 Python 패키지를 지원합니다! 패키지를 수정할 필요 없이 Elratio에 바로 임포트할 수 있습니다.

# 후원사 ❤️
<a href="https://liamswayne.github.io/elratio/antarctica_public_school.jpeg"><img src="/sponsors/antarctica_public_schools.jpg" height="150"></a> <a href="https://liamswayne.github.io/elratio/enron_guy.png"><img src="/sponsors/enron.png" height="150"></a> <a href="https://liamswayne.github.io/elratio/sbf_link.png"><img src="/sponsors/sam_bankman_reeee.png" height="150"></a>

# 라이선스
Elratio는 GPL 3.0 라이선스 하에 있으며, 모든 Elratio 프로그램은 오픈 소스여야 합니다. 컴퓨터에 Elratio 프로그램이 있으면서 온라인에 자유롭게 접근 가능한 미러가 없다면 이는 라이선스 위반입니다. 우리를 폭력으로 몰아넣지 마세요.

<!--
아직도 여기 있나요? 끝났습니다. 집에 가세요.
-->


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-29

---