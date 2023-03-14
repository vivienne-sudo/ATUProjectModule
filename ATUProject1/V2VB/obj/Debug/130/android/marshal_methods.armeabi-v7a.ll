; ModuleID = 'obj\Debug\130\android\marshal_methods.armeabi-v7a.ll'
source_filename = "obj\Debug\130\android\marshal_methods.armeabi-v7a.ll"
target datalayout = "e-m:e-p:32:32-Fi8-i64:64-v128:64:128-a:0:32-n32-S64"
target triple = "armv7-unknown-linux-android"


%struct.MonoImage = type opaque

%struct.MonoClass = type opaque

%struct.MarshalMethodsManagedClass = type {
	i32,; uint32_t token
	%struct.MonoClass*; MonoClass* klass
}

%struct.MarshalMethodName = type {
	i64,; uint64_t id
	i8*; char* name
}

%class._JNIEnv = type opaque

%class._jobject = type {
	i8; uint8_t b
}

%class._jclass = type {
	i8; uint8_t b
}

%class._jstring = type {
	i8; uint8_t b
}

%class._jthrowable = type {
	i8; uint8_t b
}

%class._jarray = type {
	i8; uint8_t b
}

%class._jobjectArray = type {
	i8; uint8_t b
}

%class._jbooleanArray = type {
	i8; uint8_t b
}

%class._jbyteArray = type {
	i8; uint8_t b
}

%class._jcharArray = type {
	i8; uint8_t b
}

%class._jshortArray = type {
	i8; uint8_t b
}

%class._jintArray = type {
	i8; uint8_t b
}

%class._jlongArray = type {
	i8; uint8_t b
}

%class._jfloatArray = type {
	i8; uint8_t b
}

%class._jdoubleArray = type {
	i8; uint8_t b
}

; assembly_image_cache
@assembly_image_cache = local_unnamed_addr global [0 x %struct.MonoImage*] zeroinitializer, align 4
; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = local_unnamed_addr constant [214 x i32] [
	i32 26230656, ; 0: Microsoft.Extensions.DependencyModel => 0x1903f80 => 21
	i32 32687329, ; 1: Xamarin.AndroidX.Lifecycle.Runtime => 0x1f2c4e1 => 67
	i32 34715100, ; 2: Xamarin.Google.Guava.ListenableFuture.dll => 0x211b5dc => 85
	i32 101534019, ; 3: Xamarin.AndroidX.SlidingPaneLayout => 0x60d4943 => 76
	i32 117431740, ; 4: System.Runtime.InteropServices => 0x6ffddbc => 102
	i32 120558881, ; 5: Xamarin.AndroidX.SlidingPaneLayout.dll => 0x72f9521 => 76
	i32 159306688, ; 6: System.ComponentModel.Annotations => 0x97ed3c0 => 98
	i32 165246403, ; 7: Xamarin.AndroidX.Collection.dll => 0x9d975c3 => 54
	i32 182336117, ; 8: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0xade3a75 => 77
	i32 209399409, ; 9: Xamarin.AndroidX.Browser.dll => 0xc7b2e71 => 52
	i32 220171995, ; 10: System.Diagnostics.Debug => 0xd1f8edb => 6
	i32 230216969, ; 11: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0xdb8d509 => 64
	i32 230752869, ; 12: Microsoft.CSharp.dll => 0xdc10265 => 9
	i32 232815796, ; 13: System.Web.Services => 0xde07cb4 => 96
	i32 280482487, ; 14: Xamarin.AndroidX.Interpolator => 0x10b7d2b7 => 62
	i32 318968648, ; 15: Xamarin.AndroidX.Activity.dll => 0x13031348 => 45
	i32 321597661, ; 16: System.Numerics => 0x132b30dd => 38
	i32 342366114, ; 17: Xamarin.AndroidX.Lifecycle.Common => 0x146817a2 => 65
	i32 347068432, ; 18: SQLitePCLRaw.lib.e_sqlite3.android.dll => 0x14afd810 => 30
	i32 385762202, ; 19: System.Memory.dll => 0x16fe439a => 37
	i32 442521989, ; 20: Xamarin.Essentials => 0x1a605985 => 83
	i32 442565967, ; 21: System.Collections => 0x1a61054f => 4
	i32 450948140, ; 22: Xamarin.AndroidX.Fragment.dll => 0x1ae0ec2c => 61
	i32 465846621, ; 23: mscorlib => 0x1bc4415d => 27
	i32 469710990, ; 24: System.dll => 0x1bff388e => 36
	i32 476646585, ; 25: Xamarin.AndroidX.Interpolator.dll => 0x1c690cb9 => 62
	i32 486930444, ; 26: Xamarin.AndroidX.LocalBroadcastManager.dll => 0x1d05f80c => 71
	i32 513247710, ; 27: Microsoft.Extensions.Primitives.dll => 0x1e9789de => 25
	i32 526420162, ; 28: System.Transactions.dll => 0x1f6088c2 => 87
	i32 539058512, ; 29: Microsoft.Extensions.Logging => 0x20216150 => 23
	i32 545304856, ; 30: System.Runtime.Extensions => 0x2080b118 => 104
	i32 548916678, ; 31: Microsoft.Bcl.AsyncInterfaces => 0x20b7cdc6 => 8
	i32 605376203, ; 32: System.IO.Compression.FileSystem => 0x24154ecb => 91
	i32 627609679, ; 33: Xamarin.AndroidX.CustomView => 0x2568904f => 58
	i32 662205335, ; 34: System.Text.Encodings.Web.dll => 0x27787397 => 42
	i32 663517072, ; 35: Xamarin.AndroidX.VersionedParcelable => 0x278c7790 => 81
	i32 666292255, ; 36: Xamarin.AndroidX.Arch.Core.Common.dll => 0x27b6d01f => 49
	i32 666745355, ; 37: V2VB.dll => 0x27bdba0b => 0
	i32 672442732, ; 38: System.Collections.Concurrent => 0x2814a96c => 3
	i32 690569205, ; 39: System.Xml.Linq.dll => 0x29293ff5 => 97
	i32 748832960, ; 40: SQLitePCLRaw.batteries_v2 => 0x2ca248c0 => 28
	i32 775507847, ; 41: System.IO.Compression => 0x2e394f87 => 90
	i32 789151979, ; 42: Microsoft.Extensions.Options => 0x2f0980eb => 24
	i32 809851609, ; 43: System.Drawing.Common.dll => 0x30455ad9 => 89
	i32 843511501, ; 44: Xamarin.AndroidX.Print => 0x3246f6cd => 73
	i32 928116545, ; 45: Xamarin.Google.Guava.ListenableFuture => 0x3751ef41 => 85
	i32 967690846, ; 46: Xamarin.AndroidX.Lifecycle.Common.dll => 0x39adca5e => 65
	i32 975236339, ; 47: System.Diagnostics.Tracing => 0x3a20ecf3 => 100
	i32 992768348, ; 48: System.Collections.dll => 0x3b2c715c => 4
	i32 1012816738, ; 49: Xamarin.AndroidX.SavedState.dll => 0x3c5e5b62 => 75
	i32 1028951442, ; 50: Microsoft.Extensions.DependencyInjection.Abstractions => 0x3d548d92 => 19
	i32 1035644815, ; 51: Xamarin.AndroidX.AppCompat => 0x3dbaaf8f => 48
	i32 1052210849, ; 52: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x3eb776a1 => 68
	i32 1098259244, ; 53: System => 0x41761b2c => 36
	i32 1099692271, ; 54: Microsoft.DotNet.PlatformAbstractions => 0x418bf8ef => 11
	i32 1157931901, ; 55: Microsoft.EntityFrameworkCore.Abstractions => 0x4504a37d => 12
	i32 1175144683, ; 56: Xamarin.AndroidX.VectorDrawable.Animated => 0x460b48eb => 79
	i32 1202000627, ; 57: Microsoft.EntityFrameworkCore.Abstractions.dll => 0x47a512f3 => 12
	i32 1204270330, ; 58: Xamarin.AndroidX.Arch.Core.Common => 0x47c7b4fa => 49
	i32 1204575371, ; 59: Microsoft.Extensions.Caching.Memory.dll => 0x47cc5c8b => 17
	i32 1267360935, ; 60: Xamarin.AndroidX.VectorDrawable => 0x4b8a64a7 => 80
	i32 1292207520, ; 61: SQLitePCLRaw.core.dll => 0x4d0585a0 => 29
	i32 1293217323, ; 62: Xamarin.AndroidX.DrawerLayout.dll => 0x4d14ee2b => 60
	i32 1365406463, ; 63: System.ServiceModel.Internals.dll => 0x516272ff => 95
	i32 1376866003, ; 64: Xamarin.AndroidX.SavedState => 0x52114ed3 => 75
	i32 1379779777, ; 65: System.Resources.ResourceManager => 0x523dc4c1 => 2
	i32 1406073936, ; 66: Xamarin.AndroidX.CoordinatorLayout => 0x53cefc50 => 55
	i32 1411638395, ; 67: System.Runtime.CompilerServices.Unsafe => 0x5423e47b => 40
	i32 1457743152, ; 68: System.Runtime.Extensions.dll => 0x56e36530 => 104
	i32 1461234159, ; 69: System.Collections.Immutable.dll => 0x5718a9ef => 33
	i32 1462112819, ; 70: System.IO.Compression.dll => 0x57261233 => 90
	i32 1469204771, ; 71: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x57924923 => 47
	i32 1470490898, ; 72: Microsoft.Extensions.Primitives => 0x57a5e912 => 25
	i32 1479771757, ; 73: System.Collections.Immutable => 0x5833866d => 33
	i32 1490351284, ; 74: Microsoft.Data.Sqlite.dll => 0x58d4f4b4 => 10
	i32 1582372066, ; 75: Xamarin.AndroidX.DocumentFile.dll => 0x5e5114e2 => 59
	i32 1592978981, ; 76: System.Runtime.Serialization.dll => 0x5ef2ee25 => 94
	i32 1622152042, ; 77: Xamarin.AndroidX.Loader.dll => 0x60b0136a => 70
	i32 1636350590, ; 78: Xamarin.AndroidX.CursorAdapter => 0x6188ba7e => 57
	i32 1639515021, ; 79: System.Net.Http.dll => 0x61b9038d => 93
	i32 1657153582, ; 80: System.Runtime => 0x62c6282e => 41
	i32 1658251792, ; 81: Xamarin.Google.Android.Material.dll => 0x62d6ea10 => 84
	i32 1688112883, ; 82: Microsoft.Data.Sqlite => 0x649e8ef3 => 10
	i32 1689493916, ; 83: Microsoft.EntityFrameworkCore.dll => 0x64b3a19c => 13
	i32 1701541528, ; 84: System.Diagnostics.Debug.dll => 0x656b7698 => 6
	i32 1711441057, ; 85: SQLitePCLRaw.lib.e_sqlite3.android => 0x660284a1 => 30
	i32 1726116996, ; 86: System.Reflection.dll => 0x66e27484 => 101
	i32 1729485958, ; 87: Xamarin.AndroidX.CardView.dll => 0x6715dc86 => 53
	i32 1766324549, ; 88: Xamarin.AndroidX.SwipeRefreshLayout => 0x6947f945 => 77
	i32 1770582343, ; 89: Microsoft.Extensions.Logging.dll => 0x6988f147 => 23
	i32 1776026572, ; 90: System.Core.dll => 0x69dc03cc => 34
	i32 1788241197, ; 91: Xamarin.AndroidX.Fragment => 0x6a96652d => 61
	i32 1796167890, ; 92: Microsoft.Bcl.AsyncInterfaces.dll => 0x6b0f58d2 => 8
	i32 1808609942, ; 93: Xamarin.AndroidX.Loader => 0x6bcd3296 => 70
	i32 1813201214, ; 94: Xamarin.Google.Android.Material => 0x6c13413e => 84
	i32 1828688058, ; 95: Microsoft.Extensions.Logging.Abstractions.dll => 0x6cff90ba => 22
	i32 1867746548, ; 96: Xamarin.Essentials.dll => 0x6f538cf4 => 83
	i32 1885316902, ; 97: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0x705fa726 => 50
	i32 1886040351, ; 98: Microsoft.EntityFrameworkCore.Sqlite.dll => 0x706ab11f => 15
	i32 1894524299, ; 99: Microsoft.DotNet.PlatformAbstractions.dll => 0x70ec258b => 11
	i32 1900610850, ; 100: System.Resources.ResourceManager.dll => 0x71490522 => 2
	i32 1919157823, ; 101: Xamarin.AndroidX.MultiDex.dll => 0x7264063f => 72
	i32 1994271888, ; 102: V2VB => 0x76de2c90 => 0
	i32 2011961780, ; 103: System.Buffers.dll => 0x77ec19b4 => 32
	i32 2014489277, ; 104: Microsoft.EntityFrameworkCore.Sqlite => 0x7812aabd => 15
	i32 2019465201, ; 105: Xamarin.AndroidX.Lifecycle.ViewModel => 0x785e97f1 => 68
	i32 2055257422, ; 106: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x7a80bd4e => 66
	i32 2079903147, ; 107: System.Runtime.dll => 0x7bf8cdab => 41
	i32 2090596640, ; 108: System.Numerics.Vectors => 0x7c9bf920 => 39
	i32 2097448633, ; 109: Xamarin.AndroidX.Legacy.Support.Core.UI => 0x7d0486b9 => 63
	i32 2103459038, ; 110: SQLitePCLRaw.provider.e_sqlite3.dll => 0x7d603cde => 31
	i32 2181898931, ; 111: Microsoft.Extensions.Options.dll => 0x820d22b3 => 24
	i32 2192057212, ; 112: Microsoft.Extensions.Logging.Abstractions => 0x82a8237c => 22
	i32 2197979891, ; 113: Microsoft.Extensions.DependencyModel.dll => 0x830282f3 => 21
	i32 2201231467, ; 114: System.Net.Http => 0x8334206b => 93
	i32 2217644978, ; 115: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x842e93b2 => 79
	i32 2244775296, ; 116: Xamarin.AndroidX.LocalBroadcastManager => 0x85cc8d80 => 71
	i32 2252897993, ; 117: Microsoft.EntityFrameworkCore => 0x86487ec9 => 13
	i32 2256548716, ; 118: Xamarin.AndroidX.MultiDex => 0x8680336c => 72
	i32 2266799131, ; 119: Microsoft.Extensions.Configuration.Abstractions => 0x871c9c1b => 18
	i32 2279755925, ; 120: Xamarin.AndroidX.RecyclerView.dll => 0x87e25095 => 74
	i32 2315684594, ; 121: Xamarin.AndroidX.Annotation.dll => 0x8a068af2 => 46
	i32 2435904999, ; 122: System.ComponentModel.DataAnnotations.dll => 0x9130f5e7 => 99
	i32 2465273461, ; 123: SQLitePCLRaw.batteries_v2.dll => 0x92f11675 => 28
	i32 2471841756, ; 124: netstandard.dll => 0x93554fdc => 1
	i32 2475788418, ; 125: Java.Interop.dll => 0x93918882 => 7
	i32 2490993605, ; 126: System.AppContext.dll => 0x94798bc5 => 103
	i32 2501346920, ; 127: System.Data.DataSetExtensions => 0x95178668 => 88
	i32 2505896520, ; 128: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x955cf248 => 67
	i32 2562349572, ; 129: Microsoft.CSharp => 0x98ba5a04 => 9
	i32 2570120770, ; 130: System.Text.Encodings.Web => 0x9930ee42 => 42
	i32 2581819634, ; 131: Xamarin.AndroidX.VectorDrawable.dll => 0x99e370f2 => 80
	i32 2620871830, ; 132: Xamarin.AndroidX.CursorAdapter.dll => 0x9c375496 => 57
	i32 2634653062, ; 133: Microsoft.EntityFrameworkCore.Relational.dll => 0x9d099d86 => 14
	i32 2732626843, ; 134: Xamarin.AndroidX.Activity => 0xa2e0939b => 45
	i32 2737747696, ; 135: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0xa32eb6f0 => 47
	i32 2778768386, ; 136: Xamarin.AndroidX.ViewPager.dll => 0xa5a0a402 => 82
	i32 2810250172, ; 137: Xamarin.AndroidX.CoordinatorLayout.dll => 0xa78103bc => 55
	i32 2819470561, ; 138: System.Xml.dll => 0xa80db4e1 => 44
	i32 2847789619, ; 139: Microsoft.EntityFrameworkCore.Relational => 0xa9bdd233 => 14
	i32 2853208004, ; 140: Xamarin.AndroidX.ViewPager => 0xaa107fc4 => 82
	i32 2855708567, ; 141: Xamarin.AndroidX.Transition => 0xaa36a797 => 78
	i32 2901442782, ; 142: System.Reflection => 0xacf080de => 101
	i32 2903344695, ; 143: System.ComponentModel.Composition => 0xad0d8637 => 92
	i32 2905242038, ; 144: mscorlib.dll => 0xad2a79b6 => 27
	i32 2919462931, ; 145: System.Numerics.Vectors.dll => 0xae037813 => 39
	i32 2978675010, ; 146: Xamarin.AndroidX.DrawerLayout => 0xb18af942 => 60
	i32 3024354802, ; 147: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xb443fdf2 => 64
	i32 3069363400, ; 148: Microsoft.Extensions.Caching.Abstractions.dll => 0xb6f2c4c8 => 16
	i32 3111772706, ; 149: System.Runtime.Serialization => 0xb979e222 => 94
	i32 3124832203, ; 150: System.Threading.Tasks.Extensions => 0xba4127cb => 106
	i32 3147165239, ; 151: System.Diagnostics.Tracing.dll => 0xbb95ee37 => 100
	i32 3195844289, ; 152: Microsoft.Extensions.Caching.Abstractions => 0xbe7cb6c1 => 16
	i32 3204380047, ; 153: System.Data.dll => 0xbefef58f => 86
	i32 3211777861, ; 154: Xamarin.AndroidX.DocumentFile => 0xbf6fd745 => 59
	i32 3220365878, ; 155: System.Threading => 0xbff2e236 => 5
	i32 3247949154, ; 156: Mono.Security => 0xc197c562 => 105
	i32 3258312781, ; 157: Xamarin.AndroidX.CardView => 0xc235e84d => 53
	i32 3265893370, ; 158: System.Threading.Tasks.Extensions.dll => 0xc2a993fa => 106
	i32 3267021929, ; 159: Xamarin.AndroidX.AsyncLayoutInflater => 0xc2bacc69 => 51
	i32 3280506390, ; 160: System.ComponentModel.Annotations.dll => 0xc3888e16 => 98
	i32 3317135071, ; 161: Xamarin.AndroidX.CustomView.dll => 0xc5b776df => 58
	i32 3317144872, ; 162: System.Data => 0xc5b79d28 => 86
	i32 3340431453, ; 163: Xamarin.AndroidX.Arch.Core.Runtime => 0xc71af05d => 50
	i32 3353484488, ; 164: Xamarin.AndroidX.Legacy.Support.Core.UI.dll => 0xc7e21cc8 => 63
	i32 3358260929, ; 165: System.Text.Json => 0xc82afec1 => 43
	i32 3360279109, ; 166: SQLitePCLRaw.core => 0xc849ca45 => 29
	i32 3362522851, ; 167: Xamarin.AndroidX.Core => 0xc86c06e3 => 56
	i32 3366347497, ; 168: Java.Interop => 0xc8a662e9 => 7
	i32 3374999561, ; 169: Xamarin.AndroidX.RecyclerView => 0xc92a6809 => 74
	i32 3395150330, ; 170: System.Runtime.CompilerServices.Unsafe.dll => 0xca5de1fa => 40
	i32 3404865022, ; 171: System.ServiceModel.Internals => 0xcaf21dfe => 95
	i32 3428513518, ; 172: Microsoft.Extensions.DependencyInjection.dll => 0xcc5af6ee => 20
	i32 3429136800, ; 173: System.Xml => 0xcc6479a0 => 44
	i32 3430777524, ; 174: netstandard => 0xcc7d82b4 => 1
	i32 3476120550, ; 175: Mono.Android => 0xcf3163e6 => 26
	i32 3485117614, ; 176: System.Text.Json.dll => 0xcfbaacae => 43
	i32 3486566296, ; 177: System.Transactions => 0xcfd0c798 => 87
	i32 3501239056, ; 178: Xamarin.AndroidX.AsyncLayoutInflater.dll => 0xd0b0ab10 => 51
	i32 3509114376, ; 179: System.Xml.Linq => 0xd128d608 => 97
	i32 3567349600, ; 180: System.ComponentModel.Composition.dll => 0xd4a16f60 => 92
	i32 3627220390, ; 181: Xamarin.AndroidX.Print.dll => 0xd832fda6 => 73
	i32 3641597786, ; 182: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0xd90e5f5a => 66
	i32 3645089577, ; 183: System.ComponentModel.DataAnnotations => 0xd943a729 => 99
	i32 3657292374, ; 184: Microsoft.Extensions.Configuration.Abstractions.dll => 0xd9fdda56 => 18
	i32 3672681054, ; 185: Mono.Android.dll => 0xdae8aa5e => 26
	i32 3676310014, ; 186: System.Web.Services.dll => 0xdb2009fe => 96
	i32 3682565725, ; 187: Xamarin.AndroidX.Browser => 0xdb7f7e5d => 52
	i32 3689375977, ; 188: System.Drawing.Common => 0xdbe768e9 => 89
	i32 3718780102, ; 189: Xamarin.AndroidX.Annotation => 0xdda814c6 => 46
	i32 3748608112, ; 190: System.Diagnostics.DiagnosticSource => 0xdf6f3870 => 35
	i32 3754567612, ; 191: SQLitePCLRaw.provider.e_sqlite3 => 0xdfca27bc => 31
	i32 3786282454, ; 192: Xamarin.AndroidX.Collection => 0xe1ae15d6 => 54
	i32 3829621856, ; 193: System.Numerics.dll => 0xe4436460 => 38
	i32 3841636137, ; 194: Microsoft.Extensions.DependencyInjection.Abstractions.dll => 0xe4fab729 => 19
	i32 3849253459, ; 195: System.Runtime.InteropServices.dll => 0xe56ef253 => 102
	i32 3885922214, ; 196: Xamarin.AndroidX.Transition.dll => 0xe79e77a6 => 78
	i32 3896106733, ; 197: System.Collections.Concurrent.dll => 0xe839deed => 3
	i32 3896760992, ; 198: Xamarin.AndroidX.Core.dll => 0xe843daa0 => 56
	i32 3920810846, ; 199: System.IO.Compression.FileSystem.dll => 0xe9b2d35e => 91
	i32 3921031405, ; 200: Xamarin.AndroidX.VersionedParcelable.dll => 0xe9b630ed => 81
	i32 3945713374, ; 201: System.Data.DataSetExtensions.dll => 0xeb2ecede => 88
	i32 3955647286, ; 202: Xamarin.AndroidX.AppCompat.dll => 0xebc66336 => 48
	i32 4025784931, ; 203: System.Memory => 0xeff49a63 => 37
	i32 4073602200, ; 204: System.Threading.dll => 0xf2ce3c98 => 5
	i32 4101842092, ; 205: Microsoft.Extensions.Caching.Memory => 0xf47d24ac => 17
	i32 4105002889, ; 206: Mono.Security.dll => 0xf4ad5f89 => 105
	i32 4126470640, ; 207: Microsoft.Extensions.DependencyInjection => 0xf5f4f1f0 => 20
	i32 4130442656, ; 208: System.AppContext => 0xf6318da0 => 103
	i32 4151237749, ; 209: System.Core => 0xf76edc75 => 34
	i32 4182413190, ; 210: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0xf94a8f86 => 69
	i32 4213026141, ; 211: System.Diagnostics.DiagnosticSource.dll => 0xfb1dad5d => 35
	i32 4260525087, ; 212: System.Buffers => 0xfdf2741f => 32
	i32 4292120959 ; 213: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xffd4917f => 69
], align 4
@assembly_image_cache_indices = local_unnamed_addr constant [214 x i32] [
	i32 21, i32 67, i32 85, i32 76, i32 102, i32 76, i32 98, i32 54, ; 0..7
	i32 77, i32 52, i32 6, i32 64, i32 9, i32 96, i32 62, i32 45, ; 8..15
	i32 38, i32 65, i32 30, i32 37, i32 83, i32 4, i32 61, i32 27, ; 16..23
	i32 36, i32 62, i32 71, i32 25, i32 87, i32 23, i32 104, i32 8, ; 24..31
	i32 91, i32 58, i32 42, i32 81, i32 49, i32 0, i32 3, i32 97, ; 32..39
	i32 28, i32 90, i32 24, i32 89, i32 73, i32 85, i32 65, i32 100, ; 40..47
	i32 4, i32 75, i32 19, i32 48, i32 68, i32 36, i32 11, i32 12, ; 48..55
	i32 79, i32 12, i32 49, i32 17, i32 80, i32 29, i32 60, i32 95, ; 56..63
	i32 75, i32 2, i32 55, i32 40, i32 104, i32 33, i32 90, i32 47, ; 64..71
	i32 25, i32 33, i32 10, i32 59, i32 94, i32 70, i32 57, i32 93, ; 72..79
	i32 41, i32 84, i32 10, i32 13, i32 6, i32 30, i32 101, i32 53, ; 80..87
	i32 77, i32 23, i32 34, i32 61, i32 8, i32 70, i32 84, i32 22, ; 88..95
	i32 83, i32 50, i32 15, i32 11, i32 2, i32 72, i32 0, i32 32, ; 96..103
	i32 15, i32 68, i32 66, i32 41, i32 39, i32 63, i32 31, i32 24, ; 104..111
	i32 22, i32 21, i32 93, i32 79, i32 71, i32 13, i32 72, i32 18, ; 112..119
	i32 74, i32 46, i32 99, i32 28, i32 1, i32 7, i32 103, i32 88, ; 120..127
	i32 67, i32 9, i32 42, i32 80, i32 57, i32 14, i32 45, i32 47, ; 128..135
	i32 82, i32 55, i32 44, i32 14, i32 82, i32 78, i32 101, i32 92, ; 136..143
	i32 27, i32 39, i32 60, i32 64, i32 16, i32 94, i32 106, i32 100, ; 144..151
	i32 16, i32 86, i32 59, i32 5, i32 105, i32 53, i32 106, i32 51, ; 152..159
	i32 98, i32 58, i32 86, i32 50, i32 63, i32 43, i32 29, i32 56, ; 160..167
	i32 7, i32 74, i32 40, i32 95, i32 20, i32 44, i32 1, i32 26, ; 168..175
	i32 43, i32 87, i32 51, i32 97, i32 92, i32 73, i32 66, i32 99, ; 176..183
	i32 18, i32 26, i32 96, i32 52, i32 89, i32 46, i32 35, i32 31, ; 184..191
	i32 54, i32 38, i32 19, i32 102, i32 78, i32 3, i32 56, i32 91, ; 192..199
	i32 81, i32 88, i32 48, i32 37, i32 5, i32 17, i32 105, i32 20, ; 200..207
	i32 103, i32 34, i32 69, i32 35, i32 32, i32 69 ; 208..213
], align 4

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 4; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 4

; Function attributes: "frame-pointer"="all" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" uwtable willreturn writeonly
define void @xamarin_app_init (void (i32, i32, i32, i8**)* %fn) local_unnamed_addr #0
{
	store void (i32, i32, i32, i8**)* %fn, void (i32, i32, i32, i8**)** @get_function_pointer, align 4
	ret void
}

; Names of classes in which marshal methods reside
@mm_class_names = local_unnamed_addr constant [0 x i8*] zeroinitializer, align 4
@__MarshalMethodName_name.0 = internal constant [1 x i8] c"\00", align 1

; mm_method_names
@mm_method_names = local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	; 0
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		i8* getelementptr inbounds ([1 x i8], [1 x i8]* @__MarshalMethodName_name.0, i32 0, i32 0); name
	}
], align 8; end of 'mm_method_names' array


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="all" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="all" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1, !2}
!llvm.ident = !{!3}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"min_enum_size", i32 4}
!3 = !{!"Xamarin.Android remotes/origin/d17-5 @ 797e2e13d1706ace607da43703769c5a55c4de60"}
!llvm.linker.options = !{}
