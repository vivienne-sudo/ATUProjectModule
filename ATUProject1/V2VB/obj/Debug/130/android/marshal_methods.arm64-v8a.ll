; ModuleID = 'obj\Debug\130\android\marshal_methods.arm64-v8a.ll'
source_filename = "obj\Debug\130\android\marshal_methods.arm64-v8a.ll"
target datalayout = "e-m:e-i8:8:32-i16:16:32-i64:64-i128:128-n32:64-S128"
target triple = "aarch64-unknown-linux-android"


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
@assembly_image_cache = local_unnamed_addr global [0 x %struct.MonoImage*] zeroinitializer, align 8
; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = local_unnamed_addr constant [214 x i64] [
	i64 15690660930947125, ; 0: Microsoft.DotNet.PlatformAbstractions.dll => 0x37be92af148835 => 11
	i64 98382396393917666, ; 1: Microsoft.Extensions.Primitives.dll => 0x15d8644ad360ce2 => 25
	i64 120698629574877762, ; 2: Mono.Android => 0x1accec39cafe242 => 26
	i64 210515253464952879, ; 3: Xamarin.AndroidX.Collection.dll => 0x2ebe681f694702f => 54
	i64 232391251801502327, ; 4: Xamarin.AndroidX.SavedState.dll => 0x3399e9cbc897277 => 75
	i64 295915112840604065, ; 5: Xamarin.AndroidX.SlidingPaneLayout => 0x41b4d3a3088a9a1 => 76
	i64 634308326490598313, ; 6: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x8cd840fee8b6ba9 => 67
	i64 702024105029695270, ; 7: System.Drawing.Common => 0x9be17343c0e7726 => 89
	i64 720058930071658100, ; 8: Xamarin.AndroidX.Legacy.Support.Core.UI => 0x9fe29c82844de74 => 63
	i64 870603111519317375, ; 9: SQLitePCLRaw.lib.e_sqlite3.android => 0xc1500ead2756d7f => 30
	i64 872800313462103108, ; 10: Xamarin.AndroidX.DrawerLayout => 0xc1ccf42c3c21c44 => 60
	i64 940822596282819491, ; 11: System.Transactions => 0xd0e792aa81923a3 => 87
	i64 1000557547492888992, ; 12: Mono.Security.dll => 0xde2b1c9cba651a0 => 105
	i64 1120440138749646132, ; 13: Xamarin.Google.Android.Material.dll => 0xf8c9a5eae431534 => 84
	i64 1301485588176585670, ; 14: SQLitePCLRaw.core => 0x120fce3f338e43c6 => 29
	i64 1315114680217950157, ; 15: Xamarin.AndroidX.Arch.Core.Common.dll => 0x124039d5794ad7cd => 49
	i64 1425944114962822056, ; 16: System.Runtime.Serialization.dll => 0x13c9f89e19eaf3a8 => 94
	i64 1518315023656898250, ; 17: SQLitePCLRaw.provider.e_sqlite3 => 0x151223783a354eca => 31
	i64 1624659445732251991, ; 18: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0x168bf32877da9957 => 47
	i64 1628611045998245443, ; 19: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0x1699fd1e1a00b643 => 69
	i64 1636321030536304333, ; 20: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0x16b5614ec39e16cd => 64
	i64 1672383392659050004, ; 21: Microsoft.Data.Sqlite.dll => 0x17357fd5bfb48e14 => 10
	i64 1743969030606105336, ; 22: System.Memory.dll => 0x1833d297e88f2af8 => 37
	i64 1795316252682057001, ; 23: Xamarin.AndroidX.AppCompat.dll => 0x18ea3e9eac997529 => 48
	i64 1836611346387731153, ; 24: Xamarin.AndroidX.SavedState => 0x197cf449ebe482d1 => 75
	i64 1865037103900624886, ; 25: Microsoft.Bcl.AsyncInterfaces => 0x19e1f15d56eb87f6 => 8
	i64 1875917498431009007, ; 26: Xamarin.AndroidX.Annotation.dll => 0x1a08990699eb70ef => 46
	i64 1981742497975770890, ; 27: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x1b80904d5c241f0a => 68
	i64 2040001226662520565, ; 28: System.Threading.Tasks.Extensions.dll => 0x1c4f8a4ea894a6f5 => 106
	i64 2070896759355658693, ; 29: V2VB.dll => 0x1cbd4da16be6d1c5 => 0
	i64 2136356949452311481, ; 30: Xamarin.AndroidX.MultiDex.dll => 0x1da5dd539d8acbb9 => 72
	i64 2165725771938924357, ; 31: Xamarin.AndroidX.Browser => 0x1e0e341d75540745 => 52
	i64 2192948757939169934, ; 32: Microsoft.EntityFrameworkCore.Abstractions.dll => 0x1e6eeb46cf992a8e => 12
	i64 2262844636196693701, ; 33: Xamarin.AndroidX.DrawerLayout.dll => 0x1f673d352266e6c5 => 60
	i64 2284400282711631002, ; 34: System.Web.Services => 0x1fb3d1f42fd4249a => 96
	i64 2287834202362508563, ; 35: System.Collections.Concurrent => 0x1fc00515e8ce7513 => 3
	i64 2287887973817120656, ; 36: System.ComponentModel.DataAnnotations.dll => 0x1fc035fd8d41f790 => 99
	i64 2329709569556905518, ; 37: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x2054ca829b447e2e => 66
	i64 2335503487726329082, ; 38: System.Text.Encodings.Web => 0x2069600c4d9d1cfa => 42
	i64 2337758774805907496, ; 39: System.Runtime.CompilerServices.Unsafe => 0x207163383edbc828 => 40
	i64 2470498323731680442, ; 40: Xamarin.AndroidX.CoordinatorLayout => 0x2248f922dc398cba => 55
	i64 2479423007379663237, ; 41: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x2268ae16b2cba985 => 79
	i64 2497223385847772520, ; 42: System.Runtime => 0x22a7eb7046413568 => 41
	i64 2547086958574651984, ; 43: Xamarin.AndroidX.Activity.dll => 0x2359121801df4a50 => 45
	i64 2592350477072141967, ; 44: System.Xml.dll => 0x23f9e10627330e8f => 44
	i64 2624866290265602282, ; 45: mscorlib.dll => 0x246d65fbde2db8ea => 27
	i64 2656907746661064104, ; 46: Microsoft.Extensions.DependencyInjection => 0x24df3b84c8b75da8 => 20
	i64 2783046991838674048, ; 47: System.Runtime.CompilerServices.Unsafe.dll => 0x269f5e7e6dc37c80 => 40
	i64 3017704767998173186, ; 48: Xamarin.Google.Android.Material => 0x29e10a7f7d88a002 => 84
	i64 3289520064315143713, ; 49: Xamarin.AndroidX.Lifecycle.Common => 0x2da6b911e3063621 => 65
	i64 3311221304742556517, ; 50: System.Numerics.Vectors.dll => 0x2df3d23ba9e2b365 => 39
	i64 3522470458906976663, ; 51: Xamarin.AndroidX.SwipeRefreshLayout => 0x30e2543832f52197 => 77
	i64 3523004241079211829, ; 52: Microsoft.Extensions.Caching.Memory.dll => 0x30e439b10bb89735 => 17
	i64 3531994851595924923, ; 53: System.Numerics => 0x31042a9aade235bb => 38
	i64 3571415421602489686, ; 54: System.Runtime.dll => 0x319037675df7e556 => 41
	i64 3638003163729360188, ; 55: Microsoft.Extensions.Configuration.Abstractions => 0x327cc89a39d5f53c => 18
	i64 3716579019761409177, ; 56: netstandard.dll => 0x3393f0ed5c8c5c99 => 1
	i64 3727469159507183293, ; 57: Xamarin.AndroidX.RecyclerView => 0x33baa1739ba646bd => 74
	i64 3869221888984012293, ; 58: Microsoft.Extensions.Logging.dll => 0x35b23cceda0ed605 => 23
	i64 3966267475168208030, ; 59: System.Memory => 0x370b03412596249e => 37
	i64 4337444564132831293, ; 60: SQLitePCLRaw.batteries_v2.dll => 0x3c31b2d9ae16203d => 28
	i64 4513320955448359355, ; 61: Microsoft.EntityFrameworkCore.Relational => 0x3ea2897f12d379bb => 14
	i64 4525561845656915374, ; 62: System.ServiceModel.Internals => 0x3ece06856b710dae => 95
	i64 4612482779465751747, ; 63: Microsoft.EntityFrameworkCore.Abstractions => 0x4002d4a662a99cc3 => 12
	i64 4636684751163556186, ; 64: Xamarin.AndroidX.VersionedParcelable.dll => 0x4058d0370893015a => 81
	i64 4743821336939966868, ; 65: System.ComponentModel.Annotations => 0x41d5705f4239b194 => 98
	i64 4782108999019072045, ; 66: Xamarin.AndroidX.AsyncLayoutInflater.dll => 0x425d76cc43bb0a2d => 51
	i64 4794310189461587505, ; 67: Xamarin.AndroidX.Activity => 0x4288cfb749e4c631 => 45
	i64 4795410492532947900, ; 68: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0x428cb86f8f9b7bbc => 77
	i64 5081566143765835342, ; 69: System.Resources.ResourceManager.dll => 0x4685597c05d06e4e => 2
	i64 5099468265966638712, ; 70: System.Resources.ResourceManager => 0x46c4f35ea8519678 => 2
	i64 5129462924058778861, ; 71: Microsoft.Data.Sqlite => 0x472f835a350f5ced => 10
	i64 5203618020066742981, ; 72: Xamarin.Essentials => 0x4836f704f0e652c5 => 83
	i64 5205316157927637098, ; 73: Xamarin.AndroidX.LocalBroadcastManager => 0x483cff7778e0c06a => 71
	i64 5376510917114486089, ; 74: Xamarin.AndroidX.VectorDrawable.Animated => 0x4a9d3431719e5d49 => 79
	i64 5408338804355907810, ; 75: Xamarin.AndroidX.Transition => 0x4b0e477cea9840e2 => 78
	i64 5446034149219586269, ; 76: System.Diagnostics.Debug => 0x4b94333452e150dd => 6
	i64 5507995362134886206, ; 77: System.Core.dll => 0x4c705499688c873e => 34
	i64 6183170893902868313, ; 78: SQLitePCLRaw.batteries_v2 => 0x55cf092b0c9d6f59 => 28
	i64 6222399776351216807, ; 79: System.Text.Json.dll => 0x565a67a0ffe264a7 => 43
	i64 6319713645133255417, ; 80: Xamarin.AndroidX.Lifecycle.Runtime => 0x57b42213b45b52f9 => 67
	i64 6401687960814735282, ; 81: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0x58d75d486341cfb2 => 66
	i64 6504860066809920875, ; 82: Xamarin.AndroidX.Browser.dll => 0x5a45e7c43bd43d6b => 52
	i64 6548213210057960872, ; 83: Xamarin.AndroidX.CustomView.dll => 0x5adfed387b066da8 => 58
	i64 6560151584539558821, ; 84: Microsoft.Extensions.Options => 0x5b0a571be53243a5 => 24
	i64 6591024623626361694, ; 85: System.Web.Services.dll => 0x5b7805f9751a1b5e => 96
	i64 6659513131007730089, ; 86: Xamarin.AndroidX.Legacy.Support.Core.UI.dll => 0x5c6b57e8b6c3e1a9 => 63
	i64 6876862101832370452, ; 87: System.Xml.Linq => 0x5f6f85a57d108914 => 97
	i64 6894844156784520562, ; 88: System.Numerics.Vectors => 0x5faf683aead1ad72 => 39
	i64 7103753931438454322, ; 89: Xamarin.AndroidX.Interpolator.dll => 0x62959a90372c7632 => 62
	i64 7338192458477945005, ; 90: System.Reflection => 0x65d67f295d0740ad => 101
	i64 7473077275758116397, ; 91: Microsoft.DotNet.PlatformAbstractions => 0x67b5b430309b3e2d => 11
	i64 7488575175965059935, ; 92: System.Xml.Linq.dll => 0x67ecc3724534ab5f => 97
	i64 7637365915383206639, ; 93: Xamarin.Essentials.dll => 0x69fd5fd5e61792ef => 83
	i64 7654504624184590948, ; 94: System.Net.Http => 0x6a3a4366801b8264 => 93
	i64 7735176074855944702, ; 95: Microsoft.CSharp => 0x6b58dda848e391fe => 9
	i64 7820441508502274321, ; 96: System.Data => 0x6c87ca1e14ff8111 => 86
	i64 7836164640616011524, ; 97: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x6cbfa6390d64d704 => 47
	i64 7972383140441761405, ; 98: Microsoft.Extensions.Caching.Abstractions.dll => 0x6ea3983a0b58267d => 16
	i64 8044118961405839122, ; 99: System.ComponentModel.Composition => 0x6fa2739369944712 => 92
	i64 8064050204834738623, ; 100: System.Collections.dll => 0x6fe942efa61731bf => 4
	i64 8083354569033831015, ; 101: Xamarin.AndroidX.Lifecycle.Common.dll => 0x702dd82730cad267 => 65
	i64 8087206902342787202, ; 102: System.Diagnostics.DiagnosticSource => 0x703b87d46f3aa082 => 35
	i64 8103644804370223335, ; 103: System.Data.DataSetExtensions.dll => 0x7075ee03be6d50e7 => 88
	i64 8167236081217502503, ; 104: Java.Interop.dll => 0x7157d9f1a9b8fd27 => 7
	i64 8185542183669246576, ; 105: System.Collections => 0x7198e33f4794aa70 => 4
	i64 8290740647658429042, ; 106: System.Runtime.Extensions => 0x730ea0b15c929a72 => 104
	i64 8318905602908530212, ; 107: System.ComponentModel.DataAnnotations => 0x7372b092055ea624 => 99
	i64 8518412311883997971, ; 108: System.Collections.Immutable => 0x76377add7c28e313 => 33
	i64 8601935802264776013, ; 109: Xamarin.AndroidX.Transition.dll => 0x7760370982b4ed4d => 78
	i64 8626175481042262068, ; 110: Java.Interop => 0x77b654e585b55834 => 7
	i64 8638972117149407195, ; 111: Microsoft.CSharp.dll => 0x77e3cb5e8b31d7db => 9
	i64 8684531736582871431, ; 112: System.IO.Compression.FileSystem => 0x7885a79a0fa0d987 => 91
	i64 8725526185868997716, ; 113: System.Diagnostics.DiagnosticSource.dll => 0x79174bd613173454 => 35
	i64 9111603110219107042, ; 114: Microsoft.Extensions.Caching.Memory => 0x7e72eac0def44ae2 => 17
	i64 9250544137016314866, ; 115: Microsoft.EntityFrameworkCore => 0x806088e191ee0bf2 => 13
	i64 9324707631942237306, ; 116: Xamarin.AndroidX.AppCompat => 0x8168042fd44a7c7a => 48
	i64 9662334977499516867, ; 117: System.Numerics.dll => 0x8617827802b0cfc3 => 38
	i64 9678050649315576968, ; 118: Xamarin.AndroidX.CoordinatorLayout.dll => 0x864f57c9feb18c88 => 55
	i64 9808709177481450983, ; 119: Mono.Android.dll => 0x881f890734e555e7 => 26
	i64 9834056768316610435, ; 120: System.Transactions.dll => 0x8879968718899783 => 87
	i64 9864956466380592553, ; 121: Microsoft.EntityFrameworkCore.Sqlite => 0x88e75da3af4ed5a9 => 15
	i64 9998632235833408227, ; 122: Mono.Security => 0x8ac2470b209ebae3 => 105
	i64 10038780035334861115, ; 123: System.Net.Http.dll => 0x8b50e941206af13b => 93
	i64 10229024438826829339, ; 124: Xamarin.AndroidX.CustomView => 0x8df4cb880b10061b => 58
	i64 10430153318873392755, ; 125: Xamarin.AndroidX.Core => 0x90bf592ea44f6673 => 56
	i64 10447083246144586668, ; 126: Microsoft.Bcl.AsyncInterfaces.dll => 0x90fb7edc816203ac => 8
	i64 10714184849103829812, ; 127: System.Runtime.Extensions.dll => 0x94b06e5aa4b4bb34 => 104
	i64 10811915265162633087, ; 128: Microsoft.EntityFrameworkCore.Relational.dll => 0x960ba3a651a45f7f => 14
	i64 10847732767863316357, ; 129: Xamarin.AndroidX.Arch.Core.Common => 0x968ae37a86db9f85 => 49
	i64 10964653383833615866, ; 130: System.Diagnostics.Tracing => 0x982a4628ccaffdfa => 100
	i64 11002576679268595294, ; 131: Microsoft.Extensions.Logging.Abstractions => 0x98b1013215cd365e => 22
	i64 11023048688141570732, ; 132: System.Core => 0x98f9bc61168392ac => 34
	i64 11037814507248023548, ; 133: System.Xml => 0x992e31d0412bf7fc => 44
	i64 11162124722117608902, ; 134: Xamarin.AndroidX.ViewPager => 0x9ae7d54b986d05c6 => 82
	i64 11226290749488709958, ; 135: Microsoft.Extensions.Options.dll => 0x9bcbcbf50c874146 => 24
	i64 11340910727871153756, ; 136: Xamarin.AndroidX.CursorAdapter => 0x9d630238642d465c => 57
	i64 11392833485892708388, ; 137: Xamarin.AndroidX.Print.dll => 0x9e1b79b18fcf6824 => 73
	i64 11398376662953476300, ; 138: Microsoft.EntityFrameworkCore.Sqlite.dll => 0x9e2f2b2f0b71c0cc => 15
	i64 11432101114902388181, ; 139: System.AppContext => 0x9ea6fb64e61a9dd5 => 103
	i64 11485890710487134646, ; 140: System.Runtime.InteropServices => 0x9f6614bf0f8b71b6 => 102
	i64 11529969570048099689, ; 141: Xamarin.AndroidX.ViewPager.dll => 0xa002ae3c4dc7c569 => 82
	i64 11530571088791430846, ; 142: Microsoft.Extensions.Logging => 0xa004d1504ccd66be => 23
	i64 11580057168383206117, ; 143: Xamarin.AndroidX.Annotation => 0xa0b4a0a4103262e5 => 46
	i64 11597940890313164233, ; 144: netstandard => 0xa0f429ca8d1805c9 => 1
	i64 11672361001936329215, ; 145: Xamarin.AndroidX.Interpolator => 0xa1fc8e7d0a8999ff => 62
	i64 12102847907131387746, ; 146: System.Buffers => 0xa7f5f40c43256f62 => 32
	i64 12137774235383566651, ; 147: Xamarin.AndroidX.VectorDrawable => 0xa872095bbfed113b => 80
	i64 12145679461940342714, ; 148: System.Text.Json => 0xa88e1f1ebcb62fba => 43
	i64 12269460666702402136, ; 149: System.Collections.Immutable.dll => 0xaa45e178506c9258 => 33
	i64 12279246230491828964, ; 150: SQLitePCLRaw.provider.e_sqlite3.dll => 0xaa68a5636e0512e4 => 31
	i64 12451044538927396471, ; 151: Xamarin.AndroidX.Fragment.dll => 0xaccaff0a2955b677 => 61
	i64 12466513435562512481, ; 152: Xamarin.AndroidX.Loader.dll => 0xad01f3eb52569061 => 70
	i64 12487638416075308985, ; 153: Xamarin.AndroidX.DocumentFile.dll => 0xad4d00fa21b0bfb9 => 59
	i64 12538491095302438457, ; 154: Xamarin.AndroidX.CardView.dll => 0xae01ab382ae67e39 => 53
	i64 12550732019250633519, ; 155: System.IO.Compression => 0xae2d28465e8e1b2f => 90
	i64 12700543734426720211, ; 156: Xamarin.AndroidX.Collection => 0xb041653c70d157d3 => 54
	i64 12843321153144804894, ; 157: Microsoft.Extensions.Primitives => 0xb23ca48abd74d61e => 25
	i64 12843770487262409629, ; 158: System.AppContext.dll => 0xb23e3d357debf39d => 103
	i64 12963446364377008305, ; 159: System.Drawing.Common.dll => 0xb3e769c8fd8548b1 => 89
	i64 13370592475155966277, ; 160: System.Runtime.Serialization => 0xb98de304062ea945 => 94
	i64 13401370062847626945, ; 161: Xamarin.AndroidX.VectorDrawable.dll => 0xb9fb3b1193964ec1 => 80
	i64 13454009404024712428, ; 162: Xamarin.Google.Guava.ListenableFuture => 0xbab63e4543a86cec => 85
	i64 13491513212026656886, ; 163: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0xbb3b7bc905569876 => 50
	i64 13572454107664307259, ; 164: Xamarin.AndroidX.RecyclerView.dll => 0xbc5b0b19d99f543b => 74
	i64 13647894001087880694, ; 165: System.Data.dll => 0xbd670f48cb071df6 => 86
	i64 13955418299340266673, ; 166: Microsoft.Extensions.DependencyModel.dll => 0xc1ab9b0118299cb1 => 21
	i64 13959074834287824816, ; 167: Xamarin.AndroidX.Fragment => 0xc1b8989a7ad20fb0 => 61
	i64 14124974489674258913, ; 168: Xamarin.AndroidX.CardView => 0xc405fd76067d19e1 => 53
	i64 14125464355221830302, ; 169: System.Threading.dll => 0xc407bafdbc707a9e => 5
	i64 14133832980772275001, ; 170: Microsoft.EntityFrameworkCore.dll => 0xc425763635a1c339 => 13
	i64 14172845254133543601, ; 171: Xamarin.AndroidX.MultiDex => 0xc4b00faaed35f2b1 => 72
	i64 14261073672896646636, ; 172: Xamarin.AndroidX.Print => 0xc5e982f274ae0dec => 73
	i64 14327695147300244862, ; 173: System.Reflection.dll => 0xc6d632d338eb4d7e => 101
	i64 14551742072151931844, ; 174: System.Text.Encodings.Web.dll => 0xc9f22c50f1b8fbc4 => 42
	i64 14644440854989303794, ; 175: Xamarin.AndroidX.LocalBroadcastManager.dll => 0xcb3b815e37daeff2 => 71
	i64 14669215534098758659, ; 176: Microsoft.Extensions.DependencyInjection.dll => 0xcb9385ceb3993c03 => 20
	i64 14792063746108907174, ; 177: Xamarin.Google.Guava.ListenableFuture.dll => 0xcd47f79af9c15ea6 => 85
	i64 14852515768018889994, ; 178: Xamarin.AndroidX.CursorAdapter.dll => 0xce1ebc6625a76d0a => 57
	i64 14954917835170835695, ; 179: Microsoft.Extensions.DependencyInjection.Abstractions.dll => 0xcf8a8a895a82ecef => 19
	i64 14987728460634540364, ; 180: System.IO.Compression.dll => 0xcfff1ba06622494c => 90
	i64 14988210264188246988, ; 181: Xamarin.AndroidX.DocumentFile => 0xd000d1d307cddbcc => 59
	i64 15227001540531775957, ; 182: Microsoft.Extensions.Configuration.Abstractions.dll => 0xd3512d3999b8e9d5 => 18
	i64 15370334346939861994, ; 183: Xamarin.AndroidX.Core.dll => 0xd54e65a72c560bea => 56
	i64 15391712275433856905, ; 184: Microsoft.Extensions.DependencyInjection.Abstractions => 0xd59a58c406411f89 => 19
	i64 15582737692548360875, ; 185: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xd841015ed86f6aab => 69
	i64 15609085926864131306, ; 186: System.dll => 0xd89e9cf3334914ea => 36
	i64 15620595871140898079, ; 187: Microsoft.Extensions.DependencyModel => 0xd8c7812eef49651f => 21
	i64 15777549416145007739, ; 188: Xamarin.AndroidX.SlidingPaneLayout.dll => 0xdaf51d99d77eb47b => 76
	i64 15963349826457351533, ; 189: System.Threading.Tasks.Extensions => 0xdd893616f748b56d => 106
	i64 16154507427712707110, ; 190: System => 0xe03056ea4e39aa26 => 36
	i64 16187823716728651867, ; 191: V2VB => 0xe0a6b3e75241405b => 0
	i64 16321164108206115771, ; 192: Microsoft.Extensions.Logging.Abstractions.dll => 0xe2806c487e7b0bbb => 22
	i64 16565028646146589191, ; 193: System.ComponentModel.Composition.dll => 0xe5e2cdc9d3bcc207 => 92
	i64 16755018182064898362, ; 194: SQLitePCLRaw.core.dll => 0xe885c843c330813a => 29
	i64 16822611501064131242, ; 195: System.Data.DataSetExtensions => 0xe975ec07bb5412aa => 88
	i64 16833383113903931215, ; 196: mscorlib => 0xe99c30c1484d7f4f => 27
	i64 17037200463775726619, ; 197: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xec704b8e0a78fc1b => 64
	i64 17187273293601214786, ; 198: System.ComponentModel.Annotations.dll => 0xee8575ff9aa89142 => 98
	i64 17333249706306540043, ; 199: System.Diagnostics.Tracing.dll => 0xf08c12c5bb8b920b => 100
	i64 17544493274320527064, ; 200: Xamarin.AndroidX.AsyncLayoutInflater => 0xf37a8fada41aded8 => 51
	i64 17685921127322830888, ; 201: System.Diagnostics.Debug.dll => 0xf571038fafa74828 => 6
	i64 17704177640604968747, ; 202: Xamarin.AndroidX.Loader => 0xf5b1dfc36cac272b => 70
	i64 17710060891934109755, ; 203: Xamarin.AndroidX.Lifecycle.ViewModel => 0xf5c6c68c9e45303b => 68
	i64 17712670374920797664, ; 204: System.Runtime.InteropServices.dll => 0xf5d00bdc38bd3de0 => 102
	i64 17838668724098252521, ; 205: System.Buffers.dll => 0xf78faeb0f5bf3ee9 => 32
	i64 17928294245072900555, ; 206: System.IO.Compression.FileSystem.dll => 0xf8ce18a0b24011cb => 91
	i64 18017743553296241350, ; 207: Microsoft.Extensions.Caching.Abstractions => 0xfa0be24cb44e92c6 => 16
	i64 18025913125965088385, ; 208: System.Threading => 0xfa28e87b91334681 => 5
	i64 18116111925905154859, ; 209: Xamarin.AndroidX.Arch.Core.Runtime => 0xfb695bd036cb632b => 50
	i64 18129453464017766560, ; 210: System.ServiceModel.Internals.dll => 0xfb98c1df1ec108a0 => 95
	i64 18245806341561545090, ; 211: System.Collections.Concurrent.dll => 0xfd3620327d587182 => 3
	i64 18370042311372477656, ; 212: SQLitePCLRaw.lib.e_sqlite3.android.dll => 0xfeef80274e4094d8 => 30
	i64 18380184030268848184 ; 213: Xamarin.AndroidX.VersionedParcelable => 0xff1387fe3e7b7838 => 81
], align 8
@assembly_image_cache_indices = local_unnamed_addr constant [214 x i32] [
	i32 11, i32 25, i32 26, i32 54, i32 75, i32 76, i32 67, i32 89, ; 0..7
	i32 63, i32 30, i32 60, i32 87, i32 105, i32 84, i32 29, i32 49, ; 8..15
	i32 94, i32 31, i32 47, i32 69, i32 64, i32 10, i32 37, i32 48, ; 16..23
	i32 75, i32 8, i32 46, i32 68, i32 106, i32 0, i32 72, i32 52, ; 24..31
	i32 12, i32 60, i32 96, i32 3, i32 99, i32 66, i32 42, i32 40, ; 32..39
	i32 55, i32 79, i32 41, i32 45, i32 44, i32 27, i32 20, i32 40, ; 40..47
	i32 84, i32 65, i32 39, i32 77, i32 17, i32 38, i32 41, i32 18, ; 48..55
	i32 1, i32 74, i32 23, i32 37, i32 28, i32 14, i32 95, i32 12, ; 56..63
	i32 81, i32 98, i32 51, i32 45, i32 77, i32 2, i32 2, i32 10, ; 64..71
	i32 83, i32 71, i32 79, i32 78, i32 6, i32 34, i32 28, i32 43, ; 72..79
	i32 67, i32 66, i32 52, i32 58, i32 24, i32 96, i32 63, i32 97, ; 80..87
	i32 39, i32 62, i32 101, i32 11, i32 97, i32 83, i32 93, i32 9, ; 88..95
	i32 86, i32 47, i32 16, i32 92, i32 4, i32 65, i32 35, i32 88, ; 96..103
	i32 7, i32 4, i32 104, i32 99, i32 33, i32 78, i32 7, i32 9, ; 104..111
	i32 91, i32 35, i32 17, i32 13, i32 48, i32 38, i32 55, i32 26, ; 112..119
	i32 87, i32 15, i32 105, i32 93, i32 58, i32 56, i32 8, i32 104, ; 120..127
	i32 14, i32 49, i32 100, i32 22, i32 34, i32 44, i32 82, i32 24, ; 128..135
	i32 57, i32 73, i32 15, i32 103, i32 102, i32 82, i32 23, i32 46, ; 136..143
	i32 1, i32 62, i32 32, i32 80, i32 43, i32 33, i32 31, i32 61, ; 144..151
	i32 70, i32 59, i32 53, i32 90, i32 54, i32 25, i32 103, i32 89, ; 152..159
	i32 94, i32 80, i32 85, i32 50, i32 74, i32 86, i32 21, i32 61, ; 160..167
	i32 53, i32 5, i32 13, i32 72, i32 73, i32 101, i32 42, i32 71, ; 168..175
	i32 20, i32 85, i32 57, i32 19, i32 90, i32 59, i32 18, i32 56, ; 176..183
	i32 19, i32 69, i32 36, i32 21, i32 76, i32 106, i32 36, i32 0, ; 184..191
	i32 22, i32 92, i32 29, i32 88, i32 27, i32 64, i32 98, i32 100, ; 192..199
	i32 51, i32 6, i32 70, i32 68, i32 102, i32 32, i32 91, i32 16, ; 200..207
	i32 5, i32 50, i32 95, i32 3, i32 30, i32 81 ; 208..213
], align 4

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 8; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 8

; Function attributes: "frame-pointer"="non-leaf" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "target-cpu"="generic" "target-features"="+neon,+outline-atomics" uwtable willreturn writeonly
define void @xamarin_app_init (void (i32, i32, i32, i8**)* %fn) local_unnamed_addr #0
{
	store void (i32, i32, i32, i8**)* %fn, void (i32, i32, i32, i8**)** @get_function_pointer, align 8
	ret void
}

; Names of classes in which marshal methods reside
@mm_class_names = local_unnamed_addr constant [0 x i8*] zeroinitializer, align 8
@__MarshalMethodName_name.0 = internal constant [1 x i8] c"\00", align 1

; mm_method_names
@mm_method_names = local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	; 0
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		i8* getelementptr inbounds ([1 x i8], [1 x i8]* @__MarshalMethodName_name.0, i32 0, i32 0); name
	}
], align 8; end of 'mm_method_names' array


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="non-leaf" "target-cpu"="generic" "target-features"="+neon,+outline-atomics" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="non-leaf" "target-cpu"="generic" "target-features"="+neon,+outline-atomics" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1, !2, !3, !4, !5}
!llvm.ident = !{!6}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"branch-target-enforcement", i32 0}
!3 = !{i32 1, !"sign-return-address", i32 0}
!4 = !{i32 1, !"sign-return-address-all", i32 0}
!5 = !{i32 1, !"sign-return-address-with-bkey", i32 0}
!6 = !{!"Xamarin.Android remotes/origin/d17-5 @ 797e2e13d1706ace607da43703769c5a55c4de60"}
!llvm.linker.options = !{}
