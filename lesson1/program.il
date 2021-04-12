
//  Microsoft (R) .NET Framework IL Disassembler.  Version 4.0.30319.33440




// Metadata version: v4.0.30319
.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 4:0:0:0
}
.assembly lesson1
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                             63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.

  // --- Следующий настраиваемый атрибут добавлен автоматически, не следует отменять преобразование в комментарий -------
  //  .custom instance void [mscorlib]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [mscorlib]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 02 00 00 00 00 00 ) 

  .custom instance void [mscorlib]System.Reflection.AssemblyTitleAttribute::.ctor(string) = ( 01 00 07 6C 65 73 73 6F 6E 31 00 00 )             // ...lesson1..
  .custom instance void [mscorlib]System.Reflection.AssemblyDescriptionAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyConfigurationAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyCompanyAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyProductAttribute::.ctor(string) = ( 01 00 07 6C 65 73 73 6F 6E 31 00 00 )             // ...lesson1..
  .custom instance void [mscorlib]System.Reflection.AssemblyCopyrightAttribute::.ctor(string) = ( 01 00 12 43 6F 70 79 72 69 67 68 74 20 C2 A9 20   // ...Copyright .. 
                                                                                                  20 32 30 32 31 00 00 )                            //  2021..
  .custom instance void [mscorlib]System.Reflection.AssemblyTrademarkAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.InteropServices.ComVisibleAttribute::.ctor(bool) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.InteropServices.GuidAttribute::.ctor(string) = ( 01 00 24 65 62 34 34 34 66 34 37 2D 35 34 35 32   // ..$eb444f47-5452
                                                                                                  2D 34 30 30 64 2D 39 39 64 35 2D 39 38 36 30 61   // -400d-99d5-9860a
                                                                                                  34 30 64 37 39 61 38 00 00 )                      // 40d79a8..
  .custom instance void [mscorlib]System.Reflection.AssemblyFileVersionAttribute::.ctor(string) = ( 01 00 07 31 2E 30 2E 30 2E 30 00 00 )             // ...1.0.0.0..
  .custom instance void [mscorlib]System.Runtime.Versioning.TargetFrameworkAttribute::.ctor(string) = ( 01 00 1A 2E 4E 45 54 46 72 61 6D 65 77 6F 72 6B   // ....NETFramework
                                                                                                        2C 56 65 72 73 69 6F 6E 3D 76 34 2E 38 01 00 54   // ,Version=v4.8..T
                                                                                                        0E 14 46 72 61 6D 65 77 6F 72 6B 44 69 73 70 6C   // ..FrameworkDispl
                                                                                                        61 79 4E 61 6D 65 12 2E 4E 45 54 20 46 72 61 6D   // ayName..NET Fram
                                                                                                        65 77 6F 72 6B 20 34 2E 38 )                      // ework 4.8
  .hash algorithm 0x00008004
  .ver 1:0:0:0
}
.module lesson1.exe
// MVID: {41626EBD-BCEC-4B04-A5FE-3F5B394FF654}
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00020003    //  ILONLY 32BITPREFERRED
// Image base: 0x000001DBB37F0000


// =============== CLASS MEMBERS DECLARATION ===================

.class private auto ansi beforefieldinit lesson1.Program
       extends [mscorlib]System.Object
{
  .method private hidebysig static void  Main(string[] args) cil managed
  {
    .entrypoint
    // Размер кода:       86 (0x56)
    .maxstack  5
    .locals init ([0] string[] numbers,
             [1] string filename,
             [2] uint8[] 'array',
             [3] int32 i)
    IL_0000:  ldstr      bytearray (12 04 32 04 35 04 34 04 38 04 42 04 35 04 20 00   // ..2.5.4.8.B.5. .
                                    47 04 38 04 41 04 3B 04 30 04 20 00 3E 04 42 04   // G.8.A.;.0. .>.B.
                                    20 00 30 00 20 00 34 04 3E 04 20 00 32 00 35 00   //  .0. .4.>. .2.5.
                                    35 00 20 00 47 04 35 04 40 04 35 04 37 04 20 00   // 5. .G.5.@.5.7. .
                                    3F 04 40 04 3E 04 31 04 35 04 3B 04 3A 00 20 00 ) // ?.@.>.1.5.;.:. .
    IL_0005:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_000a:  ldstr      "1 10 100"
    IL_000f:  ldc.i4.1
    IL_0010:  newarr     [mscorlib]System.Char
    IL_0015:  dup
    IL_0016:  ldc.i4.0
    IL_0017:  ldc.i4.s   32
    IL_0019:  stelem.i2
    IL_001a:  callvirt   instance string[] [mscorlib]System.String::Split(char[])
    IL_001f:  stloc.0
    IL_0020:  ldstr      "file.bin"
    IL_0025:  stloc.1
    IL_0026:  ldloc.0
    IL_0027:  ldlen
    IL_0028:  conv.i4
    IL_0029:  newarr     [mscorlib]System.Byte
    IL_002e:  stloc.2
    IL_002f:  ldc.i4.0
    IL_0030:  stloc.3
    IL_0031:  br.s       IL_0042

    IL_0033:  ldloc.2
    IL_0034:  ldloc.3
    IL_0035:  ldloc.0
    IL_0036:  ldloc.3
    IL_0037:  ldelem.ref
    IL_0038:  call       uint8 [mscorlib]System.Convert::ToByte(string)
    IL_003d:  stelem.i1
    IL_003e:  ldloc.3
    IL_003f:  ldc.i4.1
    IL_0040:  add
    IL_0041:  stloc.3
    IL_0042:  ldloc.3
    IL_0043:  ldloc.0
    IL_0044:  ldlen
    IL_0045:  conv.i4
    IL_0046:  blt.s      IL_0033

    IL_0048:  ldloc.1
    IL_0049:  ldloc.2
    IL_004a:  call       void [mscorlib]System.IO.File::WriteAllBytes(string,
                                                                      uint8[])
    IL_004f:  call       valuetype [mscorlib]System.ConsoleKeyInfo [mscorlib]System.Console::ReadKey()
    IL_0054:  pop
    IL_0055:  ret
  } // end of method Program::Main

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Размер кода:       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  ret
  } // end of method Program::.ctor

} // end of class lesson1.Program


// =============================================================

// *********** ДИЗАССЕМБЛИРОВАНИЕ ЗАВЕРШЕНО ***********************
// ВНИМАНИЕ: создан файл ресурсов Win32 C:\lesson1\lesson1\program.res
