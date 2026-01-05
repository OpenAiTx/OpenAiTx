# Laravel Eloquent Sequencer

[![Latest Version](https://img.shields.io/github/release/gurgentil/laravel-eloquent-sequencer.svg?style=flat-square)](https://github.com/gurgentil/laravel-eloquent-sequencer/releases)
![GitHub Workflow Status](https://img.shields.io/github/workflow/status/gurgentil/laravel-eloquent-sequencer/run-tests?label=tests)
[![Quality Score](https://img.shields.io/scrutinizer/g/gurgentil/laravel-eloquent-sequencer.svg?style=flat-square)](https://scrutinizer-ci.com/g/gurgentil/laravel-eloquent-sequencer)
[![MIT Licensed](https://img.shields.io/badge/license-MIT-brightgreen.svg?style=flat-square)](LICENSE.md)

이 패키지는 Eloquent 모델을 위한 시퀀스를 생성하고 관리할 수 있게 해줍니다.

## 설치

컴포저를 통해 패키지를 설치하세요:

```bash
composer require gurgentil/laravel-eloquent-sequencer
```

## 구성

구성 파일을 게시하려면 다음을 실행하세요:

```bash
php artisan vendor:publish --provider="Gurgentil\LaravelEloquentSequencer\LaravelEloquentSequencerServiceProvider"
```
### 구성 매개변수

기본 열 이름, 초기 값 및 시퀀싱 전략은 `config/eloquentsequencer.php`에서 변경할 수 있습니다:


```php
return [
    'column_name' => 'position',
    'initial_value' => 1,
    'strategy' => 'always',
];
```

`strategy` 구성은 시퀀싱이 언제 트리거되어야 하는지를 결정하며, 다음 값 중 하나를 허용합니다: `always`, `on_create`, `on_update` 또는 `never`.

### 모델 구성

`$sequenceable` 속성은 모델의 시퀀스 열 이름을 지정합니다:

```php
protected static $sequenceable = 'order';
```
시퀀스 항목을 함께 그룹화할 관계 키:


```php
protected static $sequenceableKeys = [
    'task_list_id',
];
```
위 예제에서 작업 목록에는 여러 작업이 있습니다.

**다형 관계**의 경우 두 관계 키를 모두 지정하십시오:


```php
protected static $sequenceableKeys = [
    'commentable_id',
    'commentable_type',
];
```

## 사용법

아래 예제에서 작업 목록에는 여러 작업이 있을 수 있습니다.

``` php
use Gurgentil\LaravelEloquentSequencer\Traits\Sequenceable;
use Illuminate\Database\Eloquent\Model;

class Task extends Model
{
    use Sequenceable;

    protected $fillable = [
        'position',
    ];
    
    protected static $sequenceableKeys = [
        'task_list_id',
    ];

    public function taskList()
    {
        return $this->belongsTo(TaskList::class);
    }
}
```

### 객체 생성

```php
Task::create([
    'position' => 1,
    'task_list_id' => 1,
]);
```

sequence 속성에 값이 제공되지 않으면, 객체는 시퀀스의 끝에 배치됩니다.

```php
Task::create(['task_list_id' => 1]);
```

### 객체 업데이트 및 삭제

시퀀스 내의 다른 항목들은 시퀀스 일관성을 유지하기 위해 재배열됩니다.

```php
$task->update(['position' => 4]);
```

```php
$task->delete();
```

### 객체의 시퀀스 값 가져오기

```php
$value = $task->getSequenceValue();
```

### 시퀀스 열 이름 가져오기

```php
$columnName = Task::getSequenceColumnName();
```

### 자동 순서 지정 비활성화

```php
$task->withoutSequencing()->update(['position' => 3]);
```

```php
$task->withoutSequencing()->delete();
```

### 시퀀스 값으로 결과를 정렬하는 범위 쿼리

```php
$tasks = Task::sequenced()->get();
```

## Artisan 명령어

값이 `null`로 설정된 모든 레코드에 시퀀스 값을 할당합니다.

```bash
php artisan sequence:populate \\App\\Task
```
모델에 대한 모든 시퀀스 값을 플러시합니다.


```bash
php artisan sequence:flush \\App\\Task
```

### 테스트

``` bash
composer test
```
### 변경 로그

최근에 변경된 내용에 대한 자세한 정보는 [CHANGELOG](https://raw.githubusercontent.com/gurgentil/laravel-eloquent-sequencer/master/CHANGELOG.md)를 참조하십시오.

## 기여

자세한 내용은 [CONTRIBUTING](https://raw.githubusercontent.com/gurgentil/laravel-eloquent-sequencer/master/CONTRIBUTING.md)를 참조하십시오.

### 보안

보안 관련 문제를 발견하면 이슈 트래커를 사용하지 마시고 gustavorgentil@outlook.com으로 이메일을 보내주십시오.

## 크레딧

- [구스타보 로라토 젠틸](https://github.com/gurgentil)
- [마이클 슬로윅](https://github.com/sl0wik)
- [모든 기여자](../../contributors)

## 라이선스

MIT 라이선스 (MIT). 자세한 내용은 [라이선스 파일](https://raw.githubusercontent.com/gurgentil/laravel-eloquent-sequencer/master/LICENSE.md)을 참조하십시오.

## Laravel 패키지 보일러플레이트

이 패키지는 [Laravel Package Boilerplate](https://laravelpackageboilerplate.com)를 사용하여 생성되었습니다.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-05

---