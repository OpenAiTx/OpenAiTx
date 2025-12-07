<img src="https://raw.githubusercontent.com/franbarbalopez/mirror/master/art/logo.png" alt="Mirror ロゴ">

<div align="center">
    <img alt="Packagistの最新バージョン" src="https://img.shields.io/packagist/v/franbarbalopez/mirror.svg">
    <img alt="GitHubテストアクションステータス" src="https://img.shields.io/github/actions/workflow/status/franbarbalopez/mirror/tests.yml?label=tests">
    <img alt="合計ダウンロード数" src="https://img.shields.io/packagist/dt/franbarbalopez/mirror.svg">
    <img alt="ライセンス" src="https://img.shields.io/packagist/l/franbarbalopez/mirror.svg">
</div>

# Mirror

MirrorはLaravel向けのエレガントなユーザーなりすましパッケージです。管理者が他のユーザーとしてシームレスにログインし、問題のトラブルシューティング、サポート提供、またはユーザー体験のテストを行うことを可能にします。Mirrorは暗号検証によるセッションの整合性、自動期限切れ、マルチガード対応、柔軟なミドルウェア、監査ログ用のライフサイクルイベントを扱います。信頼性と安全なユーザーなりすましが必要な本番環境向けに最適です。

## 特徴

- 改ざん防止のためのHMAC-SHA256セッション整合性
- 設定可能なTTL（有効期限）
- アクセス制御およびTTL適用のためのミドルウェア
- マルチガード対応
- 柔軟なURLリダイレクション
- 監査ログ用のライフサイクルイベント

## 要件

- PHP 8.2以上
- Laravel 11以上

## インストール

```bash
composer require franbarbalopez/mirror
```
オプション - 設定ファイルを公開する:


```bash
php artisan vendor:publish --tag=mirror
```

## クイックスタート

### 1. ユーザーモデルにトレイトを追加する

```php
use Illuminate\Foundation\Auth\User as Authenticatable;
use Mirror\Concerns\Impersonatable;

class User extends Authenticatable
{
    use Impersonatable;

    public function canImpersonate(): bool
    {
        return $this->hasRole('admin');
    }

    public function canBeImpersonated(): bool
    {
        return ! $this->hasRole('super-admin');
    }
}
```

**重要:** `canImpersonate()` を実装しないと、誰でも誰にでもなりすますことができます。トレイトはデフォルトで `true` を返します。

### 2. なりすましを開始する

```php
use Mirror\Facades\Mirror;

public function impersonate(User $user)
{
    Mirror::start($user);

    return redirect()->route('dashboard');
}
```

### 3. なりすましをやめる

```php
public function leave()
{
    Mirror::stop();

    return redirect()->route('admin.users.index');
}
```

## セキュリティ

なりすましセッションは、アプリキーを用いたHMAC-SHA256ハッシュで保護されています。ハッシュはなりすましユーザーID、ガード名、開始時刻、リダイレクトURLを対象としています。`stop()`が呼ばれるたびに、Mirrorはこのハッシュを検証し、改ざんがあった場合は例外を投げてすべてをクリアします。

`config/mirror.php`でTTLを設定し、一定時間後にセッションを自動的に期限切れにできます。

## APIリファレンス

### なりすましの開始

ユーザーインスタンスによる:

```php
Mirror::start($user);

// With redirect URLs
$redirectUrl = Mirror::start(
    user: $targetUser,
    leaveRedirectUrl: route('admin.users.index'),
    startRedirectUrl: route('dashboard')
);

return redirect($redirectUrl);
```
プライマリキーによる検索（int、UUID、ULIDなどに対応）:


```php
Mirror::startByKey(123);

Mirror::startByKey('550e8400-e29b-41d4-a716-446655440000');
```
メールで：


```php
Mirror::startByEmail('user@example.com');
```

### なりすましの停止

```php
Mirror::stop();

// Force stop - bypasses TTL check but still verifies integrity
Mirror::forceStop();
```

管理者操作やクリーンアップスクリプトからのなりすましを終了する必要がある場合は、`forceStop()`を使用してください - TTLチェックをスキップしますが、セッションが改ざんされている場合は例外を投げます。

### 状態の確認

```php
Mirror::isImpersonating(): bool
Mirror::getImpersonator(): ?Authenticatable
Mirror::impersonatorId(): int|string|null
Mirror::getLeaveRedirectUrl(): ?string
```

### エイリアス

```php
Mirror::as($user);           // same as start()
Mirror::leave();             // same as stop()
Mirror::impersonating();     // same as isImpersonating()
Mirror::impersonator();      // same as getImpersonator()
```

## ミドルウェア

### `mirror.ttl`

なりすましセッションが期限切れかどうかを確認し、必要に応じて自動的に `stop()` を呼び出します:

```php
Route::middleware('mirror.ttl')->group(function () {
    Route::get('/admin/users', [UserController::class, 'index']);
    Route::get('/admin/users/{user}', [UserController::class, 'show']);
});
```

管理者の機密エリアを保護するのに適しており、有効期限切れのセッションが正常に終了することを保証します。TTLが切れると、このミドルウェアはなりすましを終了してリダイレクトするため、セッションのクリーンアップが適切に設定されていることを確認してください。

### `mirror.require`

なりすまし中の場合にのみアクセスを許可します：

```php
Route::middleware('mirror.require')->group(function () {
    Route::get('/impersonation/banner', function () {
        return view('impersonation.banner');
    });
});
```

なりすまし中にのみ意味を持つ特別なUIコンポーネントに便利です - 例えば、誰になりすましているかを示すバナーなど。

### `mirror.prevent`

なりすまし中のアクセスをブロックします：

```php
Route::middleware('mirror.prevent')->group(function () {
    Route::post('/admin/users/{user}/delete', [UserController::class, 'destroy']);
    Route::get('/admin/settings', [SettingsController::class, 'edit']);
});
```

破壊的な操作や、なりすまし中ではなく元のユーザーとしてのみアクセスすべき機密設定を保護します。

## 認可

`Impersonatable` トレイトは、デフォルトで両方とも `true` を返す2つのメソッドを提供します。これらをオーバーライドして独自のロジックを追加してください：

```php
use Mirror\Concerns\Impersonatable;

class User extends Authenticatable
{
    use Impersonatable;

    public function canImpersonate(): bool
    {
        return $this->hasRole('admin');
    }

    public function canBeImpersonated(): bool
    {
        return ! $this->hasRole('super-admin');
    }
}
```

トレイトは必要ありません - Mirror はこれらのメソッドをユーザーモデルで自動的に探します:

```php
class User extends Authenticatable
{
    public function canImpersonate(): bool
    {
        return $this->hasPermission('impersonate-users');
    }

    public function canBeImpersonated(): bool
    {
        return ! $this->is_system_account;
    }
}
```

## URLリダイレクション

なりすましの開始時と停止時にユーザーが移動する先を制御できます：

```php
public function impersonate(User $user)
{
    $redirectUrl = Mirror::start(
        user: $user,
        leaveRedirectUrl: route('admin.users.index'),  // where to go when they stop
        startRedirectUrl: route('dashboard')            // where to go right now
    );

    return redirect($redirectUrl);
}

public function leave()
{
    Mirror::stop();

    return redirect(Mirror::getLeaveRedirectUrl());
}
```
もし `leaveRedirectUrl` を指定しない場合、`start()` が呼び出された現在のURLがデフォルトになります。

## イベント

Mirrorはリッスン可能な2つのイベントを発行します：

- `Mirror\Events\ImpersonationStarted`
- `Mirror\Events\ImpersonationStopped`

両方のイベントにはなりすましを行うユーザー、対象ユーザー、およびガード名が含まれます。監査ログやワークフローのトリガーに適しています。

イベントはクライアントへのレスポンス送信**後**に発行され、重要ななりすまし操作が遅延なく完了することを保証します。これは、すべてのリクエストで実行される可能性がある `mirror.ttl` のようなミドルウェアにとって特に重要です。


```php
use Mirror\Events\ImpersonationStarted;

Event::listen(ImpersonationStarted::class, function (ImpersonationStarted $event) {
    // Log the activity to your audit system of choice
    Log::info('User impersonation started', [
        'impersonator_id' => $event->impersonator->id,
        'impersonated_id' => $event->impersonated->id,
        'guard' => $event->guardName,
    ]);
});
```

## パフォーマンスと最適化

Mirrorは高性能アプリケーション向けに最適化されています：

### リクエストスコープのキャッシュ

なりすましモデルは単一のリクエスト内でキャッシュされ、冗長なデータベースクエリを回避します：

```php
// This first call will query the database
$impersonator = Mirror::getImpersonator();

// Subsequent calls in the same request use the cached instance, therefore this one will not:
$impersonator = Mirror::getImpersonator();
```

これは、すべてのリクエストで実行される `mirror.ttl` のようなミドルウェアに特に有益です。

### イベントの遅延ディスパッチ

インパーソネーションイベントは、レスポンスがクライアントに送信された後にディスパッチされ、イベントリスナーがレスポンスタイムに影響を与えないようにします。これにより、リクエストサイクルを高速に保ちつつ、監査ログやその他のバックグラウンドタスクを可能にします。

## マルチガードサポート

Mirrorは使用しているガードを自動的に検出します：

```php
Auth::guard('admin')->login($admin);

Mirror::start($user); // uses 'admin' guard

Mirror::stop(); // restores to 'admin' guard
```

ガードを手動で指定する必要はありません - 現在の認証コンテキストから自動的に判断します。

## Bladeディレクティブ

**@impersonating**

```blade
@impersonating
    <div class="alert">
        You're impersonating {{ auth()->user()->name }}.
        <a href="{{ route('impersonation.leave') }}">Exit</a>
    </div>
@endimpersonating

{{-- Check specific guard --}}
@impersonating('admin')
    <div>Impersonating via admin guard</div>
@endimpersonating
```

**@canImpersonate**

```blade
@canImpersonate
    <a href="{{ route('admin.users.index') }}">Manage Users</a>
@endcanImpersonate

{{-- With guard --}}
@canImpersonate('admin')
    <div>Admin tools</div>
@endcanImpersonate
```

**@canBeImpersonated**

```blade
{{-- Check current user --}}
@canBeImpersonated
    <span>Available for support</span>
@endcanBeImpersonated

{{-- Check specific user --}}
@canBeImpersonated($user)
    <form method="POST" action="{{ route('impersonation.start', $user) }}">
        @csrf
        <button>Impersonate</button>
    </form>
@endcanBeImpersonated

{{-- With guard --}}
@canBeImpersonated($user, 'admin')
    <button>Login as this user</button>
@endcanBeImpersonated
```

## ライセンス

MIT。[LICENSE.md](https://raw.githubusercontent.com/franbarbalopez/mirror/master/LICENSE.md)を参照してください。

## クレジット

開発者：[franbarbalopez](https://github.com/franbarbalopez)。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-07

---