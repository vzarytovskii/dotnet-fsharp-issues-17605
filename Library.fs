namespace _17605fs

open _17605

type First =
    interface IFirst<First> with
        static member Metadata = 42
        static member Create(_: string) = Unchecked.defaultof<_>
        static member Create(_: int) = Unchecked.defaultof<_>
        static member Create(_: decimal) = Unchecked.defaultof<_>
