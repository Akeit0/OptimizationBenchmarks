## .NET 6.0.36 (6.0.3624.51421), X64 RyuJIT AVX2
```assembly
; MethodCallBenchmarks.CallTypeBenchmark.CallDirect()
       mov       ecx,1
       mov       edx,2
       jmp       near ptr MethodCallBenchmarks.CallTypeBenchmark.Compare(Int32, Int32)
; Total bytes of code 15
```
```assembly
; MethodCallBenchmarks.CallTypeBenchmark.Compare(Int32, Int32)
       cmp       ecx,edx
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 9
```

## .NET 6.0.36 (6.0.3624.51421), X64 RyuJIT AVX2
```assembly
; MethodCallBenchmarks.CallTypeBenchmark.CallInterface()
       mov       rcx,21AB6A97790
       mov       rcx,[rcx]
       mov       r11,7FFF1D020448
       mov       edx,1
       mov       r8d,2
       mov       rax,[7FFF1D020448]
       cmp       [rcx],ecx
       jmp       rax
; Total bytes of code 46
```

## .NET 6.0.36 (6.0.3624.51421), X64 RyuJIT AVX2
```assembly
; MethodCallBenchmarks.CallTypeBenchmark.CallInterfaceNoTiered()
       sub       rsp,28
       mov       rcx,7FFF1D2E3600
       mov       edx,7
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1EC18007790
       mov       rcx,[rcx]
       mov       r11,7FFF1D0403E8
       mov       edx,1
       mov       r8d,2
       mov       rax,[7FFF1D0403E8]
       cmp       [rcx],ecx
       add       rsp,28
       jmp       rax
; Total bytes of code 74
```

## .NET 6.0.36 (6.0.3624.51421), X64 RyuJIT AVX2
```assembly
; MethodCallBenchmarks.CallTypeBenchmark.CallInterfaceStaticReadOnly()
       xor       eax,eax
       ret
; Total bytes of code 3
```

## .NET 6.0.36 (6.0.3624.51421), X64 RyuJIT AVX2
```assembly
; MethodCallBenchmarks.CallTypeBenchmark.CallDelegateStaticReadOnly()
       mov       rcx,2816B0377A0
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       edx,1
       mov       r8d,2
       mov       rax,[rax+18]
       jmp       rax
; Total bytes of code 35
```

## .NET 6.0.36 (6.0.3624.51421), X64 RyuJIT AVX2
```assembly
; MethodCallBenchmarks.CallTypeBenchmark.CallDelegate()
       mov       rcx,16EAD7B7798
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       edx,1
       mov       r8d,2
       mov       rax,[rax+18]
       jmp       rax
; Total bytes of code 35
```

## .NET 6.0.36 (6.0.3624.51421), X64 RyuJIT AVX2
```assembly
; MethodCallBenchmarks.CallTypeBenchmark.CallDelegateNoTiered()
       sub       rsp,28
       mov       rcx,7FFF1D2B3600
       mov       edx,7
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,26DC9E17798
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       edx,1
       mov       r8d,2
       mov       rax,[rax+18]
       add       rsp,28
       jmp       rax
; Total bytes of code 63
```

## .NET 6.0.36 (6.0.3624.51421), X64 RyuJIT AVX2
```assembly
; MethodCallBenchmarks.CallTypeBenchmark.CallStaticMethodDelegateStaticReadOnly()
       mov       rcx,212180077B0
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       edx,1
       mov       r8d,2
       mov       rax,[rax+18]
       jmp       rax
; Total bytes of code 35
```

## .NET 6.0.36 (6.0.3624.51421), X64 RyuJIT AVX2
```assembly
; MethodCallBenchmarks.CallTypeBenchmark.CallStaticMethodDelegate()
       mov       rcx,218980077A8
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       edx,1
       mov       r8d,2
       mov       rax,[rax+18]
       jmp       rax
; Total bytes of code 35
```

## .NET 6.0.36 (6.0.3624.51421), X64 RyuJIT AVX2
```assembly
; MethodCallBenchmarks.CallTypeBenchmark.CallStaticMethodDelegateNoTiered()
       sub       rsp,28
       mov       rcx,7FFF1D2C3600
       mov       edx,7
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2791B6A77A8
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       edx,1
       mov       r8d,2
       mov       rax,[rax+18]
       add       rsp,28
       jmp       rax
; Total bytes of code 63
```

## .NET 6.0.36 (6.0.3624.51421), X64 RyuJIT AVX2
```assembly
; MethodCallBenchmarks.CallTypeBenchmark.CallFunctionPointerStaticReadOnly()
       mov       ecx,1
       mov       edx,2
       mov       rax,offset MethodCallBenchmarks.CallTypeBenchmark.Compare(Int32, Int32)
       jmp       rax
; Total bytes of code 23
```
```assembly
; MethodCallBenchmarks.CallTypeBenchmark.Compare(Int32, Int32)
       cmp       ecx,edx
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 9
```

## .NET 6.0.36 (6.0.3624.51421), X64 RyuJIT AVX2
```assembly
; MethodCallBenchmarks.CallTypeBenchmark.CallFunctionPointer()
       mov       rax,[MethodCallBenchmarks.CallTypeBenchmark.Compare(Int32, Int32)]
       mov       ecx,1
       mov       edx,2
       jmp       rax
; Total bytes of code 20
```
```assembly
; MethodCallBenchmarks.CallTypeBenchmark.Compare(Int32, Int32)
       cmp       ecx,edx
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 9
```

## .NET 6.0.36 (6.0.3624.51421), X64 RyuJIT AVX2
```assembly
; MethodCallBenchmarks.CallTypeBenchmark.CallFunctionPointerNoTiered()
       sub       rsp,28
       mov       rcx,7FFF1D2C3600
       mov       edx,7
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rax,[MethodCallBenchmarks.CallTypeBenchmark.Compare(Int32, Int32)]
       mov       ecx,1
       mov       edx,2
       add       rsp,28
       jmp       rax
; Total bytes of code 48
```
```assembly
; MethodCallBenchmarks.CallTypeBenchmark.Compare(Int32, Int32)
       cmp       ecx,edx
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 9
```

