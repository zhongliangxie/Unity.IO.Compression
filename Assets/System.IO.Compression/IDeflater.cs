using System;
using System.Diagnostics.Contracts;
#if !NETFX_CORE
namespace Unity.IO.Compression {

    internal interface IDeflater : IDisposable {
        [Pure] bool NeedsInput();
        void SetInput(byte[] inputBuffer, int startIndex, int count);
        int GetDeflateOutput(byte[] outputBuffer);
        bool Finish(byte[] outputBuffer, out int bytesRead);
    }
}
#endif
