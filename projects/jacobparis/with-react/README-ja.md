# with-react

![GitHub Repo stars](https://img.shields.io/github/stars/jacobparis/with-react?style=social)
![npm](https://img.shields.io/npm/v/with-react?style=plastic)
![GitHub](https://img.shields.io/github/license/jacobparis/with-react?style=plastic)
![npm](https://img.shields.io/npm/dy/with-react?style=plastic)
![npm](https://img.shields.io/npm/dw/with-react?style=plastic)
![GitHub top language](https://img.shields.io/github/languages/top/jacobparis/with-react?style=plastic)

A collection of React components that wrap React hooks to provide a more composable API. Each component accepts a render prop that receives the hook's return value.

This enables a lot of features that previously violate the Rules of Hooks

## Conditional Hooks

```tsx
function UserProfile({ user, showDetails }) {
  return (
    <div>
      <h1>{user.name}</h1>

      <p>
        This is a really long description and there could be more markup
        or other components between here and the top of the component.
        Since hooks need to be declared at the top of the component function,
        instead of in the JSX, you may want to use WithState instead of useState
        just for colocation reasons.
      </p>

      {showDetails && (
        <WithState initialState={user.lastLogin}>
          {(lastLogin, setLastLogin) => (
            <div>
              Last login: {lastLogin}
              <button onClick={() => setLastLogin(new Date())}>
                Update
              </button>
            </div>
          )}
        </WithState>
      )}
    </div>
  )
}
```



## ループ内のフック

これは条件付きフックの特別なケースですが、ループで多くのアイテムをレンダリングしている場合、それらにカスタムコンポーネントを作成する価値がないことがあります。なぜなら、親のスコープから多くのデータが必要だからです。

しかし、それぞれに状態を追加する必要があるとき、Reactはそれをコンポーネントでラップすることを強制します。WithStateを使うことで、そのコンポーネントが提供され、親が所有するリストアイテムを維持できます。


```tsx
const items = ['apple', 'banana', 'orange']

function FruitList() {
  return (
    <ul>
      {items.map((item) => (
        <WithState key={item} initialState={0}>
          {(count, setCount) => (
            <li>
              {item}: {count}
              <button onClick={() => setCount(count + 1)}>+</button>
            </li>
          )}
        </WithState>
      ))}
    </ul>
  )
}
```
## フォームステータス

react-dom の `useFormStatus()` フックは、親の `<form>` をコンテキストプロバイダーとして扱うため、フォームの子コンポーネント内で使用する必要があります。

`WithFormStatus` を使用してコンポーネント境界を作成せず、値をインラインで取得することを避けてください。


```tsx
function SearchForm() {
  return (
    <form action="/search">
      <input name="q" />
      <WithFormStatus>
        {(status) => (
          <button disabled={status.pending}>
            {status.pending ? 'Submitting...' : 'Submit'}
          </button>
        )}
      </WithFormStatus>
    </form>
  )
}
```
## Promiseの解決

`use()`フックはPromiseをアンラップできますが、それがトリガーするサスペンス境界の子で使用する必要があります。データはルートレベルで取得するのが最適なため、これらのPromiseはほとんどの場合、サスペンス境界が必要なUIよりも自然に上位に位置します。

WithUseコンポーネントを使うと、Promiseを渡してその解決済みの値を直接取得できます。

このユースケースは[React RouterのAwaitコンポーネント](https://reactrouter.com/api/components/Await)に似ています。こちらの方が良い名前ですが、ここではテーマに合わせる必要がありました。


```tsx
function UserDetails() {
  return (
    <div>
      <h1>User Details</h1>
      <Suspense fallback={<Spinner />}>
        <WithUse value={getUserPromise}>
          {(user) => (
            <div>
              <p>Name: {user.name}</p>
              <p>Email: {user.email}</p>
            </div>
          )}
        </WithUse>
      </Suspense>
    </div>
  )
}
```


## 利用可能なコンポーネント

WithState と WithFormStatus は最も便利です
| フック | コンポーネント |
|------|-----------|
| `useActionState` | `WithActionState` |
| `useCallback` | `WithCallback` |
| `useContext` | X |
| `useDeferredValue` | `WithDeferredValue` |
| `useEffect` | X |
| `useFormStatus` | `WithFormStatus` |
| `useId` | `WithId` |
| `useImperativeHandle` | X |
| `useInsertionEffect` | X |
| `useLayoutEffect` | X |
| `useMemo` | `WithMemo` |
| `useReducer` | `WithReducer` |
| `useRef` | X |
| `useState` | `WithState` |
| `useSyncExternalStore` | `WithSyncExternalStore` |
| `useTransition` | `WithTransition` |
| `use` | `WithUse` |



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-23

---