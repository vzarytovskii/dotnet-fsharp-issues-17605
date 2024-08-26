namespace _17605fs

open _17605

type First =
    interface IFirst<First> with
        static member Metadata = 42
        static member Create(_: string) = Unchecked.defaultof<_>
        static member Create(_: int) = Unchecked.defaultof<_>
        static member Create(_: decimal) = Unchecked.defaultof<_>

        member _.MetadataInstance = 42
        member _.CreateInstance(_: string) = Unchecked.defaultof<_>
        member _.CreateInstance(_: int) = Unchecked.defaultof<_>
        member _.CreateInstance(_: decimal) = Unchecked.defaultof<_>
