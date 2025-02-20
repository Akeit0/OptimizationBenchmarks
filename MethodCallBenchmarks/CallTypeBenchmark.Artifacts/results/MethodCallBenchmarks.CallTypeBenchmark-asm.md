## .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
```assembly
; MethodCallBenchmarks.CallTypeBenchmark.CallDirect()
       mov       ecx,1
       mov       edx,2
       jmp       qword ptr [7FFEFFFEE118]; MethodCallBenchmarks.CallTypeBenchmark.Compare(Int32, Int32)
; Total bytes of code 16
```
```assembly
; MethodCallBenchmarks.CallTypeBenchmark.Compare(Int32, Int32)
       cmp       ecx,edx
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 9
```

## .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
```assembly
; MethodCallBenchmarks.CallTypeBenchmark.CallInterface()
       push      rbx
       sub       rsp,20
       mov       rax,2336EC003F8
       mov       rcx,[rax]
       mov       rax,offset MT_System.Collections.Generic.GenericEqualityComparer`1[[System.Int32, System.Private.CoreLib]]
       cmp       [rcx],rax
       jne       short M00_L01
       xor       ebx,ebx
M00_L00:
       movzx     eax,bl
       add       rsp,20
       pop       rbx
       ret
M00_L01:
       mov       r11,7FFEFFB90500
       mov       edx,1
       mov       r8d,2
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       short M00_L00
; Total bytes of code 72
```

## .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
```assembly
; MethodCallBenchmarks.CallTypeBenchmark.CallInterfaceNoTiered()
       sub       rsp,28
       test      byte ptr [7FFEFFEC8AB0],1
       je        short M00_L01
M00_L00:
       mov       rcx,1AAFEC003F8
       mov       rcx,[rcx]
       mov       r11,7FFEFFB904A0
       mov       edx,1
       mov       r8d,2
       cmp       [rcx],ecx
       add       rsp,28
       jmp       qword ptr [r11]
M00_L01:
       mov       rcx,offset MT_MethodCallBenchmarks.CallTypeBenchmark
       call      CORINFO_HELP_GET_NONGCSTATIC_BASE
       jmp       short M00_L00
; Total bytes of code 73
```

## .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
```assembly
; MethodCallBenchmarks.CallTypeBenchmark.CallInterfaceStaticReadOnly()
       xor       eax,eax
       ret
; Total bytes of code 3
```

## .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
```assembly
; MethodCallBenchmarks.CallTypeBenchmark.CallDelegateStaticReadOnly()
       mov       rax,1F60B400400
       mov       r10,[rax]
       mov       rax,7FFEFFFBA130
       cmp       [r10+18],rax
       jne       short M00_L00
       xor       eax,eax
       ret
M00_L00:
       mov       edx,1
       mov       r8d,2
       mov       rcx,[r10+8]
       jmp       qword ptr [r10+18]
; Total bytes of code 51
```

## .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
```assembly
; MethodCallBenchmarks.CallTypeBenchmark.CallDelegate()
       mov       rax,21A80000408
       mov       r10,[rax]
       mov       rax,7FFEFFFDA130
       cmp       [r10+18],rax
       jne       short M00_L00
       xor       eax,eax
       ret
M00_L00:
       mov       edx,1
       mov       r8d,2
       mov       rcx,[r10+8]
       jmp       qword ptr [r10+18]
; Total bytes of code 51
```

## .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
```assembly
; MethodCallBenchmarks.CallTypeBenchmark.CallDelegateNoTiered()
       sub       rsp,28
       test      byte ptr [7FFEFFE98AB0],1
       je        short M00_L01
M00_L00:
       mov       rdx,18FA8400408
       mov       rax,[rdx]
       mov       edx,1
       mov       r8d,2
       mov       rcx,[rax+8]
       add       rsp,28
       jmp       qword ptr [rax+18]
M00_L01:
       mov       rcx,offset MT_MethodCallBenchmarks.CallTypeBenchmark
       call      CORINFO_HELP_GET_NONGCSTATIC_BASE
       jmp       short M00_L00
; Total bytes of code 66
```

## .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
```assembly
; MethodCallBenchmarks.CallTypeBenchmark.CallStaticMethodDelegateStaticReadOnly()
       mov       rdx,22C2EC00418
       mov       rax,[rdx]
       mov       edx,1
       mov       r8d,2
       mov       rcx,[rax+8]
       jmp       qword ptr [rax+18]
; Total bytes of code 32
```

## .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
```assembly
; MethodCallBenchmarks.CallTypeBenchmark.CallStaticMethodDelegate()
       mov       rdx,20710C00410
       mov       rax,[rdx]
       mov       edx,1
       mov       r8d,2
       mov       rcx,[rax+8]
       jmp       qword ptr [rax+18]
; Total bytes of code 32
```

## .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
```assembly
; MethodCallBenchmarks.CallTypeBenchmark.CallStaticMethodDelegateNoTiered()
       sub       rsp,28
       test      byte ptr [7FFEFFEC7B08],1
       je        short M00_L01
M00_L00:
       mov       rdx,1C9E6000410
       mov       rax,[rdx]
       mov       edx,1
       mov       r8d,2
       mov       rcx,[rax+8]
       add       rsp,28
       jmp       qword ptr [rax+18]
M00_L01:
       mov       rcx,offset MT_MethodCallBenchmarks.CallTypeBenchmark
       call      CORINFO_HELP_GET_NONGCSTATIC_BASE
       jmp       short M00_L00
; Total bytes of code 66
```

## .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
```assembly
; MethodCallBenchmarks.CallTypeBenchmark.CallFunctionPointerStaticReadOnly()
       mov       ecx,1
       mov       edx,2
       mov       rax,7FFEFFFBA160
       jmp       rax
; Total bytes of code 23
```

## .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
```assembly
; MethodCallBenchmarks.CallTypeBenchmark.CallFunctionPointer()
       mov       rax,[7FFEFFB8B0B8]
       mov       ecx,1
       mov       edx,2
       jmp       rax
; Total bytes of code 20
```

## .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
```assembly
; MethodCallBenchmarks.CallTypeBenchmark.CallFunctionPointerNoTiered()
       sub       rsp,28
       test      byte ptr [7FFEFFEA7B08],1
       je        short M00_L01
M00_L00:
       mov       rax,[7FFEFFB6B0B8]
       mov       ecx,1
       mov       edx,2
       add       rsp,28
       jmp       rax
M00_L01:
       mov       rcx,offset MT_MethodCallBenchmarks.CallTypeBenchmark
       call      CORINFO_HELP_GET_NONGCSTATIC_BASE
       jmp       short M00_L00
; Total bytes of code 54
```

