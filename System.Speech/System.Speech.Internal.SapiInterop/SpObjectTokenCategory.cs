using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Speech.Internal.SapiInterop
{
	[ComImport]
	[Guid("A910187F-0C7A-45AC-92CC-59EDAFB77B53")]
	internal class SpObjectTokenCategory
	{

#if WITH_USER_DEFINED_COM_CONSTRUCTOR
        [MethodImpl(MethodImplOptions.InternalCall)]
		public extern SpObjectTokenCategory();
#endif

    }
}
